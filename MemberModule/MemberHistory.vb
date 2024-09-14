Imports System.IO
Public Class MemberHistory
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim sqlstring As String
    Dim i As Integer
    Dim pcount, scount As Integer
    Dim col1(100), col2(100) As String

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_Add As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents dt_created As System.Windows.Forms.DateTimePicker
    Friend WithEvents proposal_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents proposal_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents second_meet As System.Windows.Forms.DateTimePicker
    Friend WithEvents first_meet As System.Windows.Forms.DateTimePicker
    Friend WithEvents dt_proposal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_memname As System.Windows.Forms.TextBox
    Friend WithEvents txt_memcode As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents membership_dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents formal_meet As System.Windows.Forms.DateTimePicker
    Friend WithEvents approval_dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents review_dt As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmd_MemCodeHelp As System.Windows.Forms.Button
    Friend WithEvents SSgrid_Proposal As AxFPSpreadADO.AxfpSpread
    Friend WithEvents SSgrid_Seconder As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_Freeze As System.Windows.Forms.Button
    Friend WithEvents Data As System.Windows.Forms.Label
    Friend WithEvents lbl_Freeze As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MemberHistory))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.membership_dt = New System.Windows.Forms.DateTimePicker
        Me.Label12 = New System.Windows.Forms.Label
        Me.review_dt = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.formal_meet = New System.Windows.Forms.DateTimePicker
        Me.dt_created = New System.Windows.Forms.DateTimePicker
        Me.proposal_to = New System.Windows.Forms.DateTimePicker
        Me.proposal_from = New System.Windows.Forms.DateTimePicker
        Me.second_meet = New System.Windows.Forms.DateTimePicker
        Me.approval_dt = New System.Windows.Forms.DateTimePicker
        Me.first_meet = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmd_MemCodeHelp = New System.Windows.Forms.Button
        Me.SSgrid_Seconder = New AxFPSpreadADO.AxfpSpread
        Me.SSgrid_Proposal = New AxFPSpreadADO.AxfpSpread
        Me.dt_proposal = New System.Windows.Forms.DateTimePicker
        Me.txt_memname = New System.Windows.Forms.TextBox
        Me.txt_memcode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Freeze = New System.Windows.Forms.Button
        Me.Cmd_Add = New System.Windows.Forms.Button
        Me.cmd_clear = New System.Windows.Forms.Button
        Me.Data = New System.Windows.Forms.Label
        Me.lbl_Freeze = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SSgrid_Seconder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSgrid_Proposal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label1.Location = New System.Drawing.Point(255, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Member History Creation"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImage = CType(resources.GetObject("GroupBox1.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox1.Controls.Add(Me.membership_dt)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.review_dt)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.formal_meet)
        Me.GroupBox1.Controls.Add(Me.dt_created)
        Me.GroupBox1.Controls.Add(Me.proposal_to)
        Me.GroupBox1.Controls.Add(Me.proposal_from)
        Me.GroupBox1.Controls.Add(Me.second_meet)
        Me.GroupBox1.Controls.Add(Me.approval_dt)
        Me.GroupBox1.Controls.Add(Me.first_meet)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 284)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(920, 184)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'membership_dt
        '
        Me.membership_dt.CustomFormat = "dd-MMM-yyyy"
        Me.membership_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.membership_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.membership_dt.Location = New System.Drawing.Point(624, 104)
        Me.membership_dt.Name = "membership_dt"
        Me.membership_dt.Size = New System.Drawing.Size(105, 20)
        Me.membership_dt.TabIndex = 38
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label12.Location = New System.Drawing.Point(376, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(232, 23)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Alloted Membership On :"
        '
        'review_dt
        '
        Me.review_dt.CustomFormat = "dd-MMM-yyyy"
        Me.review_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.review_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.review_dt.Location = New System.Drawing.Point(232, 144)
        Me.review_dt.Name = "review_dt"
        Me.review_dt.Size = New System.Drawing.Size(102, 20)
        Me.review_dt.TabIndex = 36
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label15.Location = New System.Drawing.Point(16, 144)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(200, 23)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Review On :"
        '
        'formal_meet
        '
        Me.formal_meet.CustomFormat = "dd-MMM-yyyy"
        Me.formal_meet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.formal_meet.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.formal_meet.Location = New System.Drawing.Point(624, 25)
        Me.formal_meet.Name = "formal_meet"
        Me.formal_meet.Size = New System.Drawing.Size(104, 20)
        Me.formal_meet.TabIndex = 34
        '
        'dt_created
        '
        Me.dt_created.CustomFormat = "dd-MMM-yyyy"
        Me.dt_created.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_created.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_created.Location = New System.Drawing.Point(232, 24)
        Me.dt_created.Name = "dt_created"
        Me.dt_created.Size = New System.Drawing.Size(102, 20)
        Me.dt_created.TabIndex = 33
        '
        'proposal_to
        '
        Me.proposal_to.CustomFormat = "dd-MMM-yyyy"
        Me.proposal_to.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proposal_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.proposal_to.Location = New System.Drawing.Point(800, 144)
        Me.proposal_to.Name = "proposal_to"
        Me.proposal_to.Size = New System.Drawing.Size(104, 20)
        Me.proposal_to.TabIndex = 32
        '
        'proposal_from
        '
        Me.proposal_from.CustomFormat = "dd-MMM-yyyy"
        Me.proposal_from.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.proposal_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.proposal_from.Location = New System.Drawing.Point(624, 144)
        Me.proposal_from.Name = "proposal_from"
        Me.proposal_from.Size = New System.Drawing.Size(102, 20)
        Me.proposal_from.TabIndex = 31
        '
        'second_meet
        '
        Me.second_meet.CustomFormat = "dd-MMM-yyyy"
        Me.second_meet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.second_meet.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.second_meet.Location = New System.Drawing.Point(232, 104)
        Me.second_meet.Name = "second_meet"
        Me.second_meet.Size = New System.Drawing.Size(102, 20)
        Me.second_meet.TabIndex = 29
        '
        'approval_dt
        '
        Me.approval_dt.CustomFormat = "dd-MMM-yyyy"
        Me.approval_dt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.approval_dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.approval_dt.Location = New System.Drawing.Point(624, 65)
        Me.approval_dt.Name = "approval_dt"
        Me.approval_dt.Size = New System.Drawing.Size(104, 20)
        Me.approval_dt.TabIndex = 28
        '
        'first_meet
        '
        Me.first_meet.CustomFormat = "dd-MMM-yyyy"
        Me.first_meet.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.first_meet.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.first_meet.Location = New System.Drawing.Point(232, 64)
        Me.first_meet.Name = "first_meet"
        Me.first_meet.Size = New System.Drawing.Size(102, 20)
        Me.first_meet.TabIndex = 27
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label14.Location = New System.Drawing.Point(744, 144)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(40, 23)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "To "
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label13.Location = New System.Drawing.Point(376, 144)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(232, 23)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Display of Proposal Form From :"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label11.Location = New System.Drawing.Point(376, 64)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(232, 23)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Approved by Commitee On :"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label10.Location = New System.Drawing.Point(376, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(232, 23)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Formal Meeting On :"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label9.Location = New System.Drawing.Point(16, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(200, 23)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "2nd Informal Meeting On :"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label8.Location = New System.Drawing.Point(16, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(200, 23)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "1st Informal Meeting On :"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label7.Location = New System.Drawing.Point(16, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(200, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Personal Data Created On :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackgroundImage = CType(resources.GetObject("GroupBox2.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox2.Controls.Add(Me.cmd_MemCodeHelp)
        Me.GroupBox2.Controls.Add(Me.SSgrid_Seconder)
        Me.GroupBox2.Controls.Add(Me.SSgrid_Proposal)
        Me.GroupBox2.Controls.Add(Me.dt_proposal)
        Me.GroupBox2.Controls.Add(Me.txt_memname)
        Me.GroupBox2.Controls.Add(Me.txt_memcode)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(920, 208)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'cmd_MemCodeHelp
        '
        Me.cmd_MemCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemCodeHelp.Image = CType(resources.GetObject("cmd_MemCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemCodeHelp.Location = New System.Drawing.Point(240, 16)
        Me.cmd_MemCodeHelp.Name = "cmd_MemCodeHelp"
        Me.cmd_MemCodeHelp.Size = New System.Drawing.Size(24, 20)
        Me.cmd_MemCodeHelp.TabIndex = 29
        '
        'SSgrid_Seconder
        '
        Me.SSgrid_Seconder.ContainingControl = Me
        Me.SSgrid_Seconder.DataSource = Nothing
        Me.SSgrid_Seconder.Location = New System.Drawing.Point(520, 71)
        Me.SSgrid_Seconder.Name = "SSgrid_Seconder"
        Me.SSgrid_Seconder.OcxState = CType(resources.GetObject("SSgrid_Seconder.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_Seconder.Size = New System.Drawing.Size(368, 121)
        Me.SSgrid_Seconder.TabIndex = 28
        '
        'SSgrid_Proposal
        '
        Me.SSgrid_Proposal.ContainingControl = Me
        Me.SSgrid_Proposal.DataSource = Nothing
        Me.SSgrid_Proposal.Location = New System.Drawing.Point(72, 72)
        Me.SSgrid_Proposal.Name = "SSgrid_Proposal"
        Me.SSgrid_Proposal.OcxState = CType(resources.GetObject("SSgrid_Proposal.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSgrid_Proposal.Size = New System.Drawing.Size(368, 125)
        Me.SSgrid_Proposal.TabIndex = 27
        '
        'dt_proposal
        '
        Me.dt_proposal.CustomFormat = "dd-MMM-yyyy"
        Me.dt_proposal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt_proposal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_proposal.Location = New System.Drawing.Point(784, 16)
        Me.dt_proposal.Name = "dt_proposal"
        Me.dt_proposal.Size = New System.Drawing.Size(100, 20)
        Me.dt_proposal.TabIndex = 26
        '
        'txt_memname
        '
        Me.txt_memname.Location = New System.Drawing.Point(400, 17)
        Me.txt_memname.Name = "txt_memname"
        Me.txt_memname.Size = New System.Drawing.Size(220, 20)
        Me.txt_memname.TabIndex = 25
        Me.txt_memname.Text = ""
        '
        'txt_memcode
        '
        Me.txt_memcode.Location = New System.Drawing.Point(135, 17)
        Me.txt_memcode.Name = "txt_memcode"
        Me.txt_memcode.TabIndex = 24
        Me.txt_memcode.Text = ""
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label6.Location = New System.Drawing.Point(521, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 23)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Seconder :"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label5.Location = New System.Drawing.Point(72, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Proposer :"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label4.Location = New System.Drawing.Point(640, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 23)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Date of Proposal :"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label3.Location = New System.Drawing.Point(270, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 23)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Member Name :"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Label2.Location = New System.Drawing.Point(14, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 23)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Member Code :"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackgroundImage = CType(resources.GetObject("GroupBox3.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox3.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox3.Controls.Add(Me.Cmd_Print)
        Me.GroupBox3.Controls.Add(Me.Cmd_View)
        Me.GroupBox3.Controls.Add(Me.Cmd_Freeze)
        Me.GroupBox3.Controls.Add(Me.Cmd_Add)
        Me.GroupBox3.Controls.Add(Me.cmd_clear)
        Me.GroupBox3.Location = New System.Drawing.Point(96, 505)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(728, 64)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Cmd_Exit.Location = New System.Drawing.Point(610, 23)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 30)
        Me.Cmd_Exit.TabIndex = 5
        Me.Cmd_Exit.Text = "Exit [F11]"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Cmd_Print.Location = New System.Drawing.Point(494, 23)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 30)
        Me.Cmd_Print.TabIndex = 4
        Me.Cmd_Print.Text = "Print [F10]"
        '
        'Cmd_View
        '
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Cmd_View.Location = New System.Drawing.Point(377, 23)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 30)
        Me.Cmd_View.TabIndex = 3
        Me.Cmd_View.Text = "View [F9]"
        '
        'Cmd_Freeze
        '
        Me.Cmd_Freeze.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Freeze.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Cmd_Freeze.Location = New System.Drawing.Point(258, 23)
        Me.Cmd_Freeze.Name = "Cmd_Freeze"
        Me.Cmd_Freeze.Size = New System.Drawing.Size(104, 30)
        Me.Cmd_Freeze.TabIndex = 2
        Me.Cmd_Freeze.Text = "Freeze [F8]"
        '
        'Cmd_Add
        '
        Me.Cmd_Add.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Add.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.Cmd_Add.Location = New System.Drawing.Point(138, 23)
        Me.Cmd_Add.Name = "Cmd_Add"
        Me.Cmd_Add.Size = New System.Drawing.Size(104, 30)
        Me.Cmd_Add.TabIndex = 1
        Me.Cmd_Add.Text = "Add[F7]"
        '
        'cmd_clear
        '
        Me.cmd_clear.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clear.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.cmd_clear.Location = New System.Drawing.Point(17, 23)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(104, 30)
        Me.cmd_clear.TabIndex = 0
        Me.cmd_clear.Text = "Clear [F6]"
        '
        'Data
        '
        Me.Data.AutoSize = True
        Me.Data.BackColor = System.Drawing.Color.Transparent
        Me.Data.Font = New System.Drawing.Font("Times New Roman", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Data.ForeColor = System.Drawing.Color.Red
        Me.Data.Location = New System.Drawing.Point(13, 270)
        Me.Data.Name = "Data"
        Me.Data.Size = New System.Drawing.Size(169, 18)
        Me.Data.TabIndex = 121
        Me.Data.Text = "Data Not Metioned in History"
        Me.Data.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Data.Visible = False
        '
        'lbl_Freeze
        '
        Me.lbl_Freeze.AutoSize = True
        Me.lbl_Freeze.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Freeze.Font = New System.Drawing.Font("Times New Roman", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Freeze.ForeColor = System.Drawing.Color.Red
        Me.lbl_Freeze.Location = New System.Drawing.Point(336, 477)
        Me.lbl_Freeze.Name = "lbl_Freeze"
        Me.lbl_Freeze.Size = New System.Drawing.Size(173, 25)
        Me.lbl_Freeze.TabIndex = 120
        Me.lbl_Freeze.Text = "Record Freezed  On "
        Me.lbl_Freeze.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lbl_Freeze.Visible = False
        '
        'MemberHistory
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(936, 582)
        Me.Controls.Add(Me.Data)
        Me.Controls.Add(Me.lbl_Freeze)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Name = "MemberHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MemberHistory"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.SSgrid_Seconder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSgrid_Proposal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmd_MemCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemCodeHelp.Click
        Dim vform As New ListOperation
        Try
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
            M_WhereCondition = " "
            vform.Field = "MCODE,MNAME"
            vform.vFormatstring = "  Member Code  | Member Name                           "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_memcode.Text = Trim(vform.keyfield & "")
                'txt_memname.Text = Trim(vform.keyfield1 & "")
                txt_memcode.Select()
                Call txt_memcode_Validated(sender, e)
            End If
            vform.Close()
            vform = Nothing
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txt_memcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_memcode.Validated
        Dim StrSQL As String
        Dim memdet, MTABLE As DataTable
        Try
            If txt_memcode.Text <> "" Then
                StrSQL = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(PERSONAL_DATA,GETDATE()) AS PERSONAL_DATA,ISNULL(FIRST_MEET,GETDATE()) AS FIRST_MEET,"
                StrSQL = StrSQL & "ISNULL(SECOND_MEET,GETDATE()) AS SECOND_MEET,ISNULL(REVIEW_DT,GETDATE()) AS REVIEW_DT, ISNULL(FORMAL_MEET,GETDATE()) AS FORMAL_MEET,"
                StrSQL = StrSQL & "ISNULL(APPROVED_DT,GETDATE()) AS APPROVED_DT,ISNULL(ATDMEMBERSHIP_DT,GETDATE()) AS ATDMEMBERSHIP_DT,ISNULL(PROPOSAL_FROM,GETDATE()) AS PROPOSAL_FROM,"
                StrSQL = StrSQL & "ISNULL(PROPOSAL_TO,GETDATE()) AS PROPOSAL_TO,ISNULL(FREEZE,'N') AS FREEZE,ISNULL(UPDATEDATETIME,GETDATE()) AS UPDATEDATETIME FROM MEMBERHISTORY"
                StrSQL = StrSQL & " WHERE MCODE = '" & Trim(txt_memcode.Text) & "'"
                gconnection.getDataSet(StrSQL, "MEMHISTORY")
                If gdataset.Tables("MEMHISTORY").Rows.Count > 0 Then
                    dt_created.Value = Format(gdataset.Tables("MEMHISTORY").Rows(0).Item("PERSONAL_DATA"), "dd/MM/yyy")
                    first_meet.Value = Format(gdataset.Tables("MEMHISTORY").Rows(0).Item("FIRST_MEET"), "dd/MM/yyyy")
                    second_meet.Value = Format(gdataset.Tables("MEMHISTORY").Rows(0).Item("SECOND_MEET"), "dd/MM/yyyy")
                    review_dt.Value = Format(gdataset.Tables("MEMHISTORY").Rows(0).Item("REVIEW_DT"), "dd/MM/yyyy")
                    formal_meet.Value = Format(gdataset.Tables("MEMHISTORY").Rows(0).Item("FORMAL_MEET"), "dd/MM/yyyy")
                    approval_dt.Value = Format(gdataset.Tables("MEMHISTORY").Rows(0).Item("APPROVED_DT"), "dd/MM/yyyy")
                    membership_dt.Value = Format(gdataset.Tables("MEMHISTORY").Rows(0).Item("ATDMEMBERSHIP_DT"), "dd/MM/yyyy")
                    proposal_from.Value = Format(gdataset.Tables("MEMHISTORY").Rows(0).Item("PROPOSAL_FROM"), "dd/MM/yyyy")
                    proposal_to.Value = Format(gdataset.Tables("MEMHISTORY").Rows(0).Item("PROPOSAL_TO"), "dd/MM/yyyy")
                    If gdataset.Tables("MEMHISTORY").Rows(0).Item("Freeze") = "Y" Then
                        Me.lbl_Freeze.Visible = True
                        Me.lbl_Freeze.Text = ""
                        Me.lbl_Freeze.Text = "Record Freezed  On " & Format(CDate(gdataset.Tables("MEMHISTORY").Rows(0).Item("UPDATEDATETIME")), "dd/MM/yyyy")
                        Me.Cmd_Freeze.Text = "UnFreeze[F8]"
                    Else
                        Me.lbl_Freeze.Visible = False
                        Me.lbl_Freeze.Text = "Record Freezed  On "
                        Me.Cmd_Freeze.Text = "Freeze[F8]"
                    End If
                    Me.Cmd_Add.Text = "Update[F7]"
                    Me.Data.Visible = False
                Else
                    Me.lbl_Freeze.Visible = False
                    Me.lbl_Freeze.Text = "Record Freezed  On "
                    Me.Cmd_Add.Text = "Add[F7]"
                    Me.Data.Visible = True
                End If
                StrSQL = "SELECT ISNULL(MCODE,'') AS MCODE, ISNULL(MNAME,'') AS MNAME, ISNULL(DateOfProposal,GETDATE()) AS DateOfProposal FROM MEMBERMASTER WHERE MCODE = '" & Trim(txt_memcode.Text) & "'"
                MTABLE = gconnection.GetValues(StrSQL)
                If MTABLE.Rows.Count > 0 Then
                    Me.txt_memcode.ReadOnly = True
                    Me.txt_memcode.Text = MTABLE.Rows(0).Item("MCODE")
                    Me.txt_memname.Text = MTABLE.Rows(0).Item("MNAME")
                    Me.dt_proposal.Value = Format(MTABLE.Rows(0).Item("DateOfProposal"), "dd/MM/yyyy")
                End If
                StrSQL = "SELECT ISNULL(PCODE,'') AS PCODE, ISNULL(PNAME,'') AS PNAME FROM MEMDET"
                StrSQL = StrSQL & " WHERE MEM_CODE = '" & Trim(txt_memcode.Text) & "' AND TYPE0 IN ('PROP')"
                memdet = gconnection.GetValues(StrSQL)
                If memdet.Rows.Count > 0 Then
                    For i = 0 To memdet.Rows.Count - 1
                        With SSgrid_Proposal
                            .Row = i + 1
                            .Col = 1
                            .Text = Trim(memdet.Rows(i).Item("pcode"))
                            .Row = i + 1
                            .Col = 2
                            .Text = Trim(memdet.Rows(i).Item("pname"))
                            col1(i) = Trim(memdet.Rows(i).Item("pname"))
                        End With
                    Next i
                    pcount = i
                End If
                StrSQL = "SELECT ISNULL(PCODE,'') AS PCODE, ISNULL(PNAME,'') AS PNAME FROM MEMDET"
                StrSQL = StrSQL & " WHERE MEM_CODE = '" & Trim(txt_memcode.Text) & "' AND TYPE0 IN ('SECO')"
                memdet = gconnection.GetValues(StrSQL)
                If memdet.Rows.Count > 0 Then
                    For i = 0 To memdet.Rows.Count - 1
                        With SSgrid_Seconder
                            .Row = i + 1
                            .Col = 1
                            .Text = Trim(memdet.Rows(i).Item("pcode"))
                            .Row = i + 1
                            .Col = 2
                            .Text = Trim(memdet.Rows(i).Item("pname"))
                            col2(i) = Trim(memdet.Rows(i).Item("pname"))
                        End With
                    Next i
                    scount = i
                End If
            End If
            If gUserCategory <> "S" Then
                Call GetRights()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Member", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Cmd_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Add.Click
        Dim SQLSTR As String
        Try
            If Cmd_Add.Text = "Add[F7]" Then
                Call checkValidation() '''--->Check Validation
                If boolchk = False Then Exit Sub
                SQLSTR = "Insert into memberhistory (mcode,personal_data,first_meet,second_meet,review_dt,formal_meet,approved_dt,atdmembership_dt,"
                SQLSTR = SQLSTR & "proposal_from,proposal_to,adduserid,adddatetime,freeze)"

                SQLSTR = SQLSTR & "Values('" & Trim(txt_memcode.Text) & "','" & Format(dt_created.Value, "dd-MMM-yyyy") & "','" & Format(first_meet.Value, "dd-MMM-yyyy") & "',"
                SQLSTR = SQLSTR & "'" & Format(second_meet.Value, "dd-MMM-yyyy") & "','" & Format(review_dt.Value, "dd-MMM-yyyy") & "','" & Format(formal_meet.Value, "dd-MMM-yyyy") & "',"
                SQLSTR = SQLSTR & "'" & Format(approval_dt.Value, "dd-MMM-yyyy") & "', '" & Format(membership_dt.Value, "dd-MMM-yyyy") & "','" & Format(proposal_from.Value, "dd-MMM-yyyy") & "',"
                SQLSTR = SQLSTR & "'" & Format(proposal_to.Value, "dd-MMM-yyyy") & "','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm") & "','N')"
                gconnection.dataOperation(1, SQLSTR, "MemberHistory")
                MsgBox("Record Inserted", MsgBoxStyle.OKOnly)
                Call cmd_clear_Click(sender, e)
            ElseIf Cmd_Add.Text = "Update[F7]" Then
                Call checkValidation() '''--->Check Validation
                If boolchk = False Then Exit Sub
                If Mid(Me.Cmd_Add.Text, 1, 1) = "U" Then
                    If Me.lbl_Freeze.Visible = True Then
                        MessageBox.Show(" The Freezed Record Cannot Be Updated", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                        boolchk = False
                        Exit Sub
                    End If
                End If
                SQLSTR = "Update memberhistory set personal_data = '" & Format(dt_created.Value, "dd-MMM-yyyy") & "',first_meet = '" & Format(first_meet.Value, "dd-MMM-yyyy") & "',second_meet = '" & Format(second_meet.Value, "dd-MMM-yyyy") & "',"
                SQLSTR = SQLSTR & "review_dt = '" & Format(review_dt.Value, "dd-MMM-yyyy") & "',formal_meet = '" & Format(formal_meet.Value, "dd-MMM-yyyy") & "',approved_dt = '" & Format(approval_dt.Value, "dd-MMM-yyyy") & "',atdmembership_dt = '" & Format(membership_dt.Value, "dd-MMM-yyyy") & "',"
                SQLSTR = SQLSTR & "proposal_from='" & Format(proposal_from.Value, "dd-MMM-yyyy") & "',proposal_to = '" & Format(proposal_to.Value, "dd-MMM-yyyy") & "',"
                SQLSTR = SQLSTR & "Freeze='N',updateuser='" & Trim(gUsername) & "',updatedatetime='" & Format(Now, "dd-MMM-yyyy hh:mm") & "' Where mcode='" & Trim(txt_memcode.Text) & "'"
                gconnection.dataOperation(2, SQLSTR, "MemberHistory")
                MsgBox("Record Updated", MsgBoxStyle.OKOnly)
                Call cmd_clear_Click(sender, e)
            End If
        Catch ex As Exception
            MsgBox(ex, MsgBoxStyle.Information)
        End Try

    End Sub

    Private Sub MemberHistory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Show()
        txt_memcode.Focus()
        For i = 1 To 100
            col1(i) = ""
            col2(i) = ""
        Next
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_Freeze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Freeze.Click
        Dim ssql As String
        Try
            Call checkValidation() ''-->Check Validation
            If boolchk = False Then Exit Sub
            If Mid(Me.Cmd_Freeze.Text, 1, 1) = "F" Then
                ssql = "UPDATE  MemberHistory "
                ssql = ssql & " SET Freeze= 'Y',Updateuser='" & gUsername & " ', Updatedatetime='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
                ssql = ssql & " WHERE MCODE = '" & txt_memcode.Text & " '"
                gconnection.dataOperation(3, ssql, "memberhistory")
                Cmd_Add.Text = "Add[F7]"
                Me.cmd_clear_Click(sender, e)
            Else
                ssql = "UPDATE  MemberHIstory "
                ssql = ssql & " SET Freeze= 'N',Updateuser='" & gUsername & " ', Updatedatetime='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
                ssql = ssql & " WHERE MCODE = '" & txt_memcode.Text & " '"
                gconnection.dataOperation(4, ssql, "memberhistory")
                Me.cmd_clear_Click(sender, e)
                Cmd_Add.Text = "Add[F7]"
            End If
        Catch ex As Exception

        End Try
    End Sub
    Public Sub checkValidation()
        boolchk = False
        If Trim(txt_memcode.Text) = "" Then
            MessageBox.Show(" Member Code can't be blank ", "Member", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txt_memcode.Focus()
            Exit Sub
        End If
        boolchk = True
    End Sub

    Private Sub txt_memcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_memcode.KeyPress
        getAlphanumeric(e)
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_memcode.Text) <> "" Then
                Call txt_memcode_Validated(sender, e)
            Else
                Call cmd_MemCodeHelp_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        dt_created.Value = Format(Now, "dd/MM/yyy")
        first_meet.Value = Format(Now, "dd/MM/yyyy")
        second_meet.Value = Format(Now, "dd/MM/yyyy")
        review_dt.Value = Format(Now, "dd/MM/yyyy")
        formal_meet.Value = Format(Now, "dd/MM/yyyy")
        approval_dt.Value = Format(Now, "dd/MM/yyyy")
        membership_dt.Value = Format(Now, "dd/MM/yyyy")
        proposal_from.Value = Format(Now, "dd/MM/yyyy")
        proposal_to.Value = Format(Now, "dd/MM/yyyy")
        dt_proposal.Value = Format(Now, "dd/MM/yyyy")
        txt_memcode.Text = ""
        txt_memname.Text = ""
        SSgrid_Proposal.ClearRange(0, 0, -1, -1, True)
        SSgrid_Seconder.ClearRange(0, 0, -1, -1, True)
        txt_memcode.Focus()
        txt_memcode.ReadOnly = False
    End Sub

    Private Sub MemberHistory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F7 Then
            Call Cmd_Add_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call cmd_clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            Call Cmd_Freeze_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            Call Cmd_View_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F10 Then
            Call Cmd_Print_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Then
            Me.Close()
            Exit Sub
        End If
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        gPrint = False
        sqlstring = "select isnull(a.mcode,'') as mcode, isnull(a.personal_data,'') as personal_data, "
        sqlstring = sqlstring & " isnull(a.first_meet,'') first_meet, isnull(a.second_meet,'') as second_meet,"
        sqlstring = sqlstring & " isnull(a.review_dt,'') as review_dt, isnull(a.formal_meet,'') as formal_meet,"
        sqlstring = sqlstring & " isnull(a.approved_dt,'') as approved_dt, isnull(a.atdmembership_dt,'') as atdmembership_dt,"
        sqlstring = sqlstring & " isnull(a.proposal_from,'') as proposal_from, isnull(a.proposal_to,'') as proposal_to,"
        sqlstring = sqlstring & " isnull(b.dateofproposal,'') as proposal_dt, isnull(b.mname,'') as mname "
        'sqlstring = sqlstring & " isnull(c.pname,'') as pname "
        sqlstring = sqlstring & " from memberhistory a, membermaster b where a.mcode = b.mcode "
        sqlstring = sqlstring & " and a.mcode = '" & Trim(txt_memcode.Text) & "' "
        Call Check_List_View_MemberHistory()
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        gPrint = True
        sqlstring = "select isnull(a.mcode,'') as mcode, isnull(a.personal_data,'') as personal_data, "
        sqlstring = sqlstring & " isnull(a.first_meet,'') first_meet, isnull(a.second_meet,'') as second_meet,"
        sqlstring = sqlstring & " isnull(a.review_dt,'') as review_dt, isnull(a.formal_meet,'') as formal_meet,"
        sqlstring = sqlstring & " isnull(a.approved_dt,'') as approved_dt, isnull(a.atdmembership_dt,'') as atdmembership_dt,"
        sqlstring = sqlstring & " isnull(a.proposal_from,'') as proposal_from, isnull(a.proposal_to,'') as proposal_to,"
        sqlstring = sqlstring & " isnull(b.dateofproposal,'') as proposal_dt, isnull(b.mname,'') as mname "
        'sqlstring = sqlstring & " isnull(c.pname,'') as pname "
        sqlstring = sqlstring & " from memberhistory a, membermaster b where a.mcode = b.mcode "
        sqlstring = sqlstring & " and a.mcode = '" & Trim(txt_memcode.Text) & "' "
        Call Check_List_View_MemberHistory()
    End Sub
    Function Check_List_View_MemberHistory()
        If Me.txt_memcode.Text = "" Then
            MsgBox("Member Code Column Can't be Blank", MsgBoxStyle.Information)
            Exit Function
        End If
        Dim Filewrite As StreamWriter
        Dim tab, POSCode As String
        Dim HEADING(0), HEADERNAME, STR1 As String
        Dim GraQty, GraAmount, PAGESIZE, PAGENO, amount, ROWCOUNT, x As Integer

        Dim j, intPageLength As Int16
        Dim SSQL As String
        Try
            Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Mem" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine()
            gconnection.getDataSet(sqlstring, "MEMBERHISTORY")

            PAGENO = 1

            If gdataset.Tables("MEMBERHISTORY").Rows.Count > 0 Then
                Dim dr As DataRow
                Try
                    Dim sqlstr As String
                    PAGESIZE = 1
                    PAGENO = 1
                    HEADERNAME = " MEMBER HISTORY REPORT "
                    Filewrite.WriteLine(Chr(18))
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine()
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine("{0,-30}{1,49}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine("{0,-30}{1,-17}{2,-10}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING(0)), 1, 30), " ", gFinancalyearStart & " TO " & gFinancialYearEnd)
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine("{0,-30}{1,-16}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 30))
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine("{0,35}{1,-10}", " ", STR1 & Space(2) & HEADERNAME)
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine("{0,82}{1,-10}", " ", "PAGE : " & PAGENO)
                    PAGESIZE = PAGESIZE + 1
                    Filewrite.WriteLine(StrDup(120, "="))
                    PAGESIZE = PAGESIZE + 1
                    For Each dr In gdataset.Tables("MEMBERHISTORY").Rows
                        If PAGESIZE > 56 Then
                            Filewrite.WriteLine(Chr(12))
                            PAGENO = PAGENO + 1
                            PAGESIZE = 1
                            Filewrite.WriteLine(Chr(18))
                            PAGESIZE = PAGESIZE + 1
                            Filewrite.WriteLine("{0,80}{1,15}{2,10}", Chr(14) & Chr(15) & " ", "PRINTED ON : ", Format(Now, "dd/MM/yyyy"))
                            PAGESIZE = PAGESIZE + 1
                            Filewrite.WriteLine()
                            PAGESIZE = PAGESIZE + 1
                            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
                            PAGESIZE = PAGESIZE + 1
                            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING(0)), 1, 30), " ", gFinancalyearStart & " TO " & gFinancialYearEnd)
                            PAGESIZE = PAGESIZE + 1
                            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 30))
                            PAGESIZE = PAGESIZE + 1
                            Filewrite.WriteLine("{0,35}{1,-10}", " ", STR1 & Space(2) & HEADERNAME)
                            PAGESIZE = PAGESIZE + 1
                            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & PAGENO)
                            PAGESIZE = PAGESIZE + 1
                            Filewrite.WriteLine(StrDup(120, "-"))
                            PAGESIZE = PAGESIZE + 1
                            Filewrite.WriteLine(StrDup(120, "="))
                            PAGESIZE = PAGESIZE + 1
                        End If

                        Filewrite.WriteLine()
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine("{0,20}{1,-25}{2,41}{3,-20}", "Member Code              : ", Trim(CStr(dr("mcode"))), "Date of Proposal              : ", Trim(CStr(dr("proposal_dt"))))
                        Filewrite.WriteLine()
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine("{0,20}{1,-12}", "Member Name              : ", Trim(CStr(dr("mname"))))
                        Filewrite.WriteLine()
                        PAGESIZE = PAGESIZE + 1
                        If pcount > scount Then
                            x = pcount
                        Else
                            x = scount
                        End If
                        Filewrite.WriteLine("{0,20}{1,66}", "Proposer                 : ", "Seconder                      : ")
                        For i = 0 To x
                            Filewrite.WriteLine("{0,27}{1,-46}{2,20}{3,-67}", "", Trim(col1(i)), "", Trim(col2(i)))
                        Next i

                        'Filewrite.WriteLine("{0,20}{1,-34}{2,23}{3,-20}", "Proposer                 : ", Trim(CStr(dr("uname"))), "Seconder                      : ", Trim(CStr(dr("uname"))))
                        Filewrite.WriteLine()
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine("{0,20}{1,-34}{2,31}{3,-20}", "Personal Data Created On : ", Trim(CStr(dr("personal_data"))), "Formal Meeting On             : ", Trim(CStr(dr("formal_meet"))))
                        Filewrite.WriteLine()
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine("{0,20}{1,-34}{2,-18}{3,-20}", "1st Informal Meeting On  : ", Trim(CStr(dr("first_meet"))), "Approval On                   : ", Trim(CStr(dr("approved_dt"))))
                        Filewrite.WriteLine()
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine("{0,20}{1,-34}{2,-29}{3,-20}", "2nd Informal Meeting On  : ", Trim(CStr(dr("second_meet"))), "Alloted Membership On         : ", Trim(CStr(dr("atdmembership_dt"))))
                        Filewrite.WriteLine()
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine("{0,20}{1,-34}{2,-31}{3,-11}{4,-3}{5,-11}", "Review On                : ", Trim(CStr(dr("review_dt"))), "Display of Proposal Form from : ", Trim(CStr(dr("proposal_from"))), "TO", Trim(CStr(dr("proposal_to"))))
                        Filewrite.WriteLine()
                        PAGESIZE = PAGESIZE + 1
                        Filewrite.WriteLine(StrDup(120, "="))
                        PAGESIZE = PAGESIZE + 1
                    Next dr
                    Filewrite.WriteLine(Chr(15))
                    Filewrite.WriteLine(Chr(12))
                Catch ex As Exception
                    MsgBox(ex.Message)
                    Exit Function
                End Try
            End If
            Filewrite.Close()
            If gPrint = True Then
                PrintTextFile1(VFilePath)
            Else
                OpenTextFile(vOutfile)
            End If
        Catch Excep As Exception
            MessageBox.Show(Excep.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
        Me.cmd_Freeze.Enabled = False
        Me.Cmd_View.Enabled = False
        Me.Cmd_Print.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmd_Add.Enabled = True
                    Me.cmd_Freeze.Enabled = True
                    Me.Cmd_View.Enabled = True
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
                    Me.cmd_Freeze.Enabled = True
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

    Private Sub txt_memcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_memcode.TextChanged

    End Sub
End Class
