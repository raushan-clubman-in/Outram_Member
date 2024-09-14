Imports System.Data.SqlClient
Imports System.io
Imports System.Data
Public Class monthlyprocess
    Inherits System.Windows.Forms.Form
    Dim month1 As Object
    Dim vbilldate As String
    Dim noofdays As Object
    Dim mnth2 As Object
    Dim gconnection As New GlobalClass
    Dim ssql As String
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
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CMBMONTH As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cutoffdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmdMONTH As System.Windows.Forms.Button
    Friend WithEvents CMDCREDIT As System.Windows.Forms.Button
    Friend WithEvents CMDCASH As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTPFROM As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTPTO As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents SSGRID As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_AuditTrail As System.Windows.Forms.Button
    Friend WithEvents Lbl_AlreadyPosted As System.Windows.Forms.Label
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_Export As System.Windows.Forms.Button
    Friend WithEvents Txt_DebitTotal As System.Windows.Forms.TextBox
    Friend WithEvents Txt_CreditTotal As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Differnce As System.Windows.Forms.TextBox
    Friend WithEvents Lbl_Total As System.Windows.Forms.Label
    Friend WithEvents Lbl_Difference As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(monthlyprocess))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdMONTH = New System.Windows.Forms.Button
        Me.Cmd_AuditTrail = New System.Windows.Forms.Button
        Me.CMDCREDIT = New System.Windows.Forms.Button
        Me.CMDCASH = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cutoffdate = New System.Windows.Forms.DateTimePicker
        Me.CMBMONTH = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DTPFROM = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.DTPTO = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.SSGRID = New AxFPSpreadADO.AxfpSpread
        Me.Lbl_AlreadyPosted = New System.Windows.Forms.Label
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_Export = New System.Windows.Forms.Button
        Me.Txt_DebitTotal = New System.Windows.Forms.TextBox
        Me.Txt_CreditTotal = New System.Windows.Forms.TextBox
        Me.Txt_Differnce = New System.Windows.Forms.TextBox
        Me.Lbl_Total = New System.Windows.Forms.Label
        Me.Lbl_Difference = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.SSGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.cmdexit)
        Me.GroupBox3.Controls.Add(Me.CmdMONTH)
        Me.GroupBox3.Controls.Add(Me.Cmd_AuditTrail)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(232, 320)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(592, 56)
        Me.GroupBox3.TabIndex = 604
        Me.GroupBox3.TabStop = False
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdexit.BackgroundImage = CType(resources.GetObject("cmdexit.BackgroundImage"), System.Drawing.Image)
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Location = New System.Drawing.Point(400, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(184, 32)
        Me.cmdexit.TabIndex = 10
        Me.cmdexit.Text = "Exit[F11]"
        '
        'CmdMONTH
        '
        Me.CmdMONTH.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdMONTH.BackgroundImage = CType(resources.GetObject("CmdMONTH.BackgroundImage"), System.Drawing.Image)
        Me.CmdMONTH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdMONTH.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdMONTH.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdMONTH.ForeColor = System.Drawing.Color.White
        Me.CmdMONTH.Location = New System.Drawing.Point(8, 16)
        Me.CmdMONTH.Name = "CmdMONTH"
        Me.CmdMONTH.Size = New System.Drawing.Size(184, 32)
        Me.CmdMONTH.TabIndex = 7
        Me.CmdMONTH.Text = "MONTH PROCESS"
        '
        'Cmd_AuditTrail
        '
        Me.Cmd_AuditTrail.BackColor = System.Drawing.SystemColors.Menu
        Me.Cmd_AuditTrail.BackgroundImage = CType(resources.GetObject("Cmd_AuditTrail.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_AuditTrail.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_AuditTrail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_AuditTrail.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_AuditTrail.ForeColor = System.Drawing.Color.White
        Me.Cmd_AuditTrail.Location = New System.Drawing.Point(204, 16)
        Me.Cmd_AuditTrail.Name = "Cmd_AuditTrail"
        Me.Cmd_AuditTrail.Size = New System.Drawing.Size(184, 32)
        Me.Cmd_AuditTrail.TabIndex = 11
        Me.Cmd_AuditTrail.Text = "AUDIT TRAIL"
        '
        'CMDCREDIT
        '
        Me.CMDCREDIT.BackColor = System.Drawing.SystemColors.Menu
        Me.CMDCREDIT.BackgroundImage = CType(resources.GetObject("CMDCREDIT.BackgroundImage"), System.Drawing.Image)
        Me.CMDCREDIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDCREDIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMDCREDIT.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDCREDIT.ForeColor = System.Drawing.Color.White
        Me.CMDCREDIT.Location = New System.Drawing.Point(32, 576)
        Me.CMDCREDIT.Name = "CMDCREDIT"
        Me.CMDCREDIT.Size = New System.Drawing.Size(184, 32)
        Me.CMDCREDIT.TabIndex = 7
        Me.CMDCREDIT.Text = "ACCOUNTS POSTING"
        Me.CMDCREDIT.Visible = False
        '
        'CMDCASH
        '
        Me.CMDCASH.BackColor = System.Drawing.SystemColors.Menu
        Me.CMDCASH.BackgroundImage = CType(resources.GetObject("CMDCASH.BackgroundImage"), System.Drawing.Image)
        Me.CMDCASH.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMDCASH.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMDCASH.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDCASH.ForeColor = System.Drawing.Color.White
        Me.CMDCASH.Location = New System.Drawing.Point(152, 256)
        Me.CMDCASH.Name = "CMDCASH"
        Me.CMDCASH.Size = New System.Drawing.Size(104, 32)
        Me.CMDCASH.TabIndex = 7
        Me.CMDCASH.Text = "CASH-POST"
        Me.CMDCASH.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(413, 22)
        Me.Label3.TabIndex = 607
        Me.Label3.Text = "MONTH BILL PROCESS FOR THE MONTH OF : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(784, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 17)
        Me.Label2.TabIndex = 598
        Me.Label2.Text = "Cutoff Date :"
        Me.Label2.Visible = False
        '
        'cutoffdate
        '
        Me.cutoffdate.CustomFormat = "dd-MMM-yyyy"
        Me.cutoffdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cutoffdate.Location = New System.Drawing.Point(720, 264)
        Me.cutoffdate.Name = "cutoffdate"
        Me.cutoffdate.Size = New System.Drawing.Size(120, 20)
        Me.cutoffdate.TabIndex = 4
        Me.cutoffdate.Value = New Date(2008, 7, 19, 1, 33, 56, 531)
        Me.cutoffdate.Visible = False
        '
        'CMBMONTH
        '
        Me.CMBMONTH.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.CMBMONTH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBMONTH.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CMBMONTH.ItemHeight = 20
        Me.CMBMONTH.Items.AddRange(New Object() {"April", "May", "Jun", "July", "August", "September", "October", "November", "December", "January", "February", "March"})
        Me.CMBMONTH.Location = New System.Drawing.Point(488, 24)
        Me.CMBMONTH.Name = "CMBMONTH"
        Me.CMBMONTH.Size = New System.Drawing.Size(120, 28)
        Me.CMBMONTH.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CMBMONTH)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.DTPFROM)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(152, 216)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(712, 72)
        Me.GroupBox1.TabIndex = 603
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(104, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 18)
        Me.Label4.TabIndex = 598
        Me.Label4.Text = "FROM DATE:"
        Me.Label4.Visible = False
        '
        'DTPFROM
        '
        Me.DTPFROM.CustomFormat = "dd-MMM-yyyy"
        Me.DTPFROM.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPFROM.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPFROM.Location = New System.Drawing.Point(200, 72)
        Me.DTPFROM.Name = "DTPFROM"
        Me.DTPFROM.Size = New System.Drawing.Size(112, 22)
        Me.DTPFROM.TabIndex = 4
        Me.DTPFROM.Value = New Date(2008, 7, 19, 1, 33, 56, 531)
        Me.DTPFROM.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(331, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 598
        Me.Label5.Text = "TO DATE :"
        Me.Label5.Visible = False
        '
        'DTPTO
        '
        Me.DTPTO.CustomFormat = "dd-MMM-yyyy"
        Me.DTPTO.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPTO.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPTO.Location = New System.Drawing.Point(728, 256)
        Me.DTPTO.Name = "DTPTO"
        Me.DTPTO.Size = New System.Drawing.Size(120, 22)
        Me.DTPTO.TabIndex = 4
        Me.DTPTO.Value = New Date(2008, 7, 19, 1, 33, 56, 531)
        Me.DTPTO.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(321, 38)
        Me.Label1.TabIndex = 608
        Me.Label1.Text = "MONTHLY PROCESS"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(200, 456)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(656, 24)
        Me.Label6.TabIndex = 609
        Me.Label6.Text = "NOTES : BEFORE CLICK MONTH PROCESS VERIFY THAT YOU HAVE CHOSEN CORRECT MONTH."
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(256, 480)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(528, 24)
        Me.Label7.TabIndex = 610
        Me.Label7.Text = "NOTES : AFTER VERIFY THE MEMBER MONTH BILL CLICK ACCOUNTS POSTING"
        '
        'SSGRID
        '
        Me.SSGRID.DataSource = Nothing
        Me.SSGRID.Location = New System.Drawing.Point(24, 16)
        Me.SSGRID.Name = "SSGRID"
        Me.SSGRID.OcxState = CType(resources.GetObject("SSGRID.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRID.Size = New System.Drawing.Size(974, 488)
        Me.SSGRID.TabIndex = 611
        Me.SSGRID.Visible = False
        '
        'Lbl_AlreadyPosted
        '
        Me.Lbl_AlreadyPosted.AutoSize = True
        Me.Lbl_AlreadyPosted.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_AlreadyPosted.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_AlreadyPosted.ForeColor = System.Drawing.Color.Red
        Me.Lbl_AlreadyPosted.Location = New System.Drawing.Point(8, 576)
        Me.Lbl_AlreadyPosted.Name = "Lbl_AlreadyPosted"
        Me.Lbl_AlreadyPosted.Size = New System.Drawing.Size(223, 27)
        Me.Lbl_AlreadyPosted.TabIndex = 608
        Me.Lbl_AlreadyPosted.Text = "ALREADY POSTED"
        Me.Lbl_AlreadyPosted.Visible = False
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.SystemColors.Menu
        Me.Cmd_Clear.BackgroundImage = CType(resources.GetObject("Cmd_Clear.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_Clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Location = New System.Drawing.Point(224, 576)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(184, 32)
        Me.Cmd_Clear.TabIndex = 612
        Me.Cmd_Clear.Text = "CLEAR"
        Me.Cmd_Clear.Visible = False
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.SystemColors.Menu
        Me.Cmd_View.BackgroundImage = CType(resources.GetObject("Cmd_View.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_View.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Location = New System.Drawing.Point(416, 576)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(184, 32)
        Me.Cmd_View.TabIndex = 613
        Me.Cmd_View.Text = "VIEW"
        Me.Cmd_View.Visible = False
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.SystemColors.Menu
        Me.Cmd_Print.BackgroundImage = CType(resources.GetObject("Cmd_Print.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_Print.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Location = New System.Drawing.Point(608, 576)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(184, 32)
        Me.Cmd_Print.TabIndex = 614
        Me.Cmd_Print.Text = "PRINT"
        Me.Cmd_Print.Visible = False
        '
        'Cmd_Export
        '
        Me.Cmd_Export.BackColor = System.Drawing.SystemColors.Menu
        Me.Cmd_Export.BackgroundImage = CType(resources.GetObject("Cmd_Export.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_Export.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Cmd_Export.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Export.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Export.ForeColor = System.Drawing.Color.White
        Me.Cmd_Export.Location = New System.Drawing.Point(800, 576)
        Me.Cmd_Export.Name = "Cmd_Export"
        Me.Cmd_Export.Size = New System.Drawing.Size(184, 32)
        Me.Cmd_Export.TabIndex = 615
        Me.Cmd_Export.Text = "EXPORT TO EXCEL"
        Me.Cmd_Export.Visible = False
        '
        'Txt_DebitTotal
        '
        Me.Txt_DebitTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DebitTotal.Location = New System.Drawing.Point(696, 512)
        Me.Txt_DebitTotal.MaxLength = 15
        Me.Txt_DebitTotal.Name = "Txt_DebitTotal"
        Me.Txt_DebitTotal.ReadOnly = True
        Me.Txt_DebitTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_DebitTotal.Size = New System.Drawing.Size(120, 26)
        Me.Txt_DebitTotal.TabIndex = 616
        Me.Txt_DebitTotal.Text = ""
        Me.Txt_DebitTotal.Visible = False
        '
        'Txt_CreditTotal
        '
        Me.Txt_CreditTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_CreditTotal.Location = New System.Drawing.Point(824, 512)
        Me.Txt_CreditTotal.MaxLength = 15
        Me.Txt_CreditTotal.Name = "Txt_CreditTotal"
        Me.Txt_CreditTotal.ReadOnly = True
        Me.Txt_CreditTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_CreditTotal.Size = New System.Drawing.Size(120, 26)
        Me.Txt_CreditTotal.TabIndex = 617
        Me.Txt_CreditTotal.Text = ""
        Me.Txt_CreditTotal.Visible = False
        '
        'Txt_Differnce
        '
        Me.Txt_Differnce.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Differnce.Location = New System.Drawing.Point(696, 544)
        Me.Txt_Differnce.MaxLength = 15
        Me.Txt_Differnce.Name = "Txt_Differnce"
        Me.Txt_Differnce.ReadOnly = True
        Me.Txt_Differnce.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Txt_Differnce.Size = New System.Drawing.Size(120, 26)
        Me.Txt_Differnce.TabIndex = 618
        Me.Txt_Differnce.Text = ""
        Me.Txt_Differnce.Visible = False
        '
        'Lbl_Total
        '
        Me.Lbl_Total.AutoSize = True
        Me.Lbl_Total.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Total.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Total.Location = New System.Drawing.Point(600, 514)
        Me.Lbl_Total.Name = "Lbl_Total"
        Me.Lbl_Total.Size = New System.Drawing.Size(76, 22)
        Me.Lbl_Total.TabIndex = 608
        Me.Lbl_Total.Text = "TOTAL :"
        Me.Lbl_Total.Visible = False
        '
        'Lbl_Difference
        '
        Me.Lbl_Difference.AutoSize = True
        Me.Lbl_Difference.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Difference.Font = New System.Drawing.Font("Georgia", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Difference.Location = New System.Drawing.Point(549, 546)
        Me.Lbl_Difference.Name = "Lbl_Difference"
        Me.Lbl_Difference.Size = New System.Drawing.Size(134, 22)
        Me.Lbl_Difference.TabIndex = 619
        Me.Lbl_Difference.Text = "DIFFERENCE :"
        Me.Lbl_Difference.Visible = False
        '
        'monthlyprocess
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1028, 630)
        Me.Controls.Add(Me.SSGRID)
        Me.Controls.Add(Me.Lbl_Difference)
        Me.Controls.Add(Me.Txt_Differnce)
        Me.Controls.Add(Me.Txt_CreditTotal)
        Me.Controls.Add(Me.Txt_DebitTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Lbl_AlreadyPosted)
        Me.Controls.Add(Me.Lbl_Total)
        Me.Controls.Add(Me.Cmd_Export)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cutoffdate)
        Me.Controls.Add(Me.CMDCASH)
        Me.Controls.Add(Me.DTPTO)
        Me.Controls.Add(Me.CMDCREDIT)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "monthlyprocess"
        Me.Text = "MONTHLY BILL PROCESSING & POSTING TO ACCOUNTS -- FORM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.SSGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub monthlyprocess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        CMBMONTH.SelectedIndex = 0
        'monthlyprocessbool = True
    End Sub
    Function MyValidations() As Boolean
        MyValidations = True
        If Mid(Me.CMBMONTH.Text, 1, 5) = "April" Then month1 = 4 : noofdays = 30 : vbilldate = "30-Apr-" & Year(gFinancalyearStart)
        If Mid(Me.CMBMONTH.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : vbilldate = "31-May-" & Year(gFinancalyearStart)
        If Mid(Me.CMBMONTH.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : vbilldate = "30-Jun-" & Year(gFinancalyearStart)
        If Mid(Me.CMBMONTH.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : vbilldate = "31-Jul-" & Year(gFinancalyearStart)
        If Mid(Me.CMBMONTH.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : vbilldate = "31-Aug-" & Year(gFinancalyearStart)
        If Mid(Me.CMBMONTH.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : vbilldate = "30-Sep-" & Year(gFinancalyearStart)
        If Mid(Me.CMBMONTH.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : vbilldate = "31-Oct-" & Year(gFinancalyearStart)
        If Mid(Me.CMBMONTH.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : vbilldate = "30-Nov-" & Year(gFinancalyearStart)
        If Mid(Me.CMBMONTH.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : vbilldate = "31-Dec-" & Year(gFinancalyearStart)
        If Mid(Me.CMBMONTH.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : vbilldate = "31-Jan-" & Year(gFinancialYearEnd)
        If Mid(Me.CMBMONTH.Text, 1, 8) = "February" Then
            mnth2 = Year(gFinancialYearEnd) Mod 4
            month1 = 2
            If mnth2 = 0 Then
                noofdays = 29
                vbilldate = "29-feb-" & Year(gFinancialYearEnd)
            Else
                noofdays = 28
                vbilldate = "28-feb-" & Year(gFinancialYearEnd)
            End If
            If Mid(Me.CMBMONTH.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : vbilldate = "31-feb-" & Year(gFinancialYearEnd)
        End If
    End Function
    Private Sub CMBMONTH_CLICK(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdMONTH.Click
        Dim process As New DataTable
        If MyValidations() = False Then
            Exit Sub
        End If
        Try
            ssql = "SELECT COUNT(*) as nos FROM MONTHBILL WHERE MONTHNO=" & month1 & " AND ISNULL(POSTFLAG,'')='Y'"
            process = gconnection.GetValues(ssql)
            If Val(process.Rows(0).Item("nos")) <= 0 Then
                ssql = " exec CP_AccountUpdate "
                gconnection.ExcuteStoreProcedure(ssql)
                ssql = ""
                ssql = " exec Tp_Monthbill '" & vbilldate & "','" & Format(Now(), "dd-MMM-yyyy") & "','" & month1 & "'"
                gconnection.ExcuteStoreProcedure(ssql)
                MessageBox.Show("Transaction Completed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Accounts Posting Over,You Can Not Process", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
    End Sub
    Private Sub CMDCASH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCASH.Click
        Dim process As New DataTable
        If MyValidations() = False Then
            Exit Sub
        End If
        Try
            ssql = " SELECT COUNT(*) as nos FROM MONTHBILL_CASH WHERE MONTHNO=" & month1 & " AND ISNULL(POSTFLAG,'')='Y'"
            process = gconnection.GetValues(ssql)
            If Val(process.Rows(0).Item("nos")) <= 0 Then
                ssql = " exec MONTHLYACCOUNTSPOSTING_CASH  '" & Format(DTPFROM.Value, "dd/MMM/yyyy") & "','" & Format(DTPTO.Value, "dd/MMM/yyyy") & "'"
                'process = gconnection.ExcuteStoreProcedure(ssql)
                gconnection.ExcuteStoreProcedure(ssql)
                MessageBox.Show("Transaction Completed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Accounts Posting Over,You Can Not Process", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CMDCREDIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCREDIT.Click
        Dim process As New DataTable
        If MyValidations() = False Then
            Exit Sub
        End If
        Try
            ssql = "SELECT COUNT(*) as nos FROM MONTHBILL WHERE MONTHNO=" & month1 & " AND ISNULL(POSTFLAG,'')='Y'"
            process = gconnection.GetValues(ssql)
            If Val(process.Rows(0).Item("nos")) <= 0 Then
                ssql = " exec MONTHLYACCOUNTSPOSTING " & month1 & ",'" & vbilldate & "'"
                'process = gconnection.ExcuteStoreProcedure(ssql)
                gconnection.ExcuteStoreProcedure(ssql)
                MessageBox.Show("Transaction Completed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Accounts Posting Over,You Can Not Process", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub monthlyprocess_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave
        'monthlyprocessbool = False
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
        Me.CmdMONTH.Enabled = False
        Me.CMDCREDIT.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdMONTH.Enabled = True
                    Me.CMDCREDIT.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.CmdMONTH.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.CmdMONTH.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.CmdMONTH.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.CMDCREDIT.Enabled = True
                End If
                If Right(x) = "V" Then
                    'Me.CmdView.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        SSGRID.ClearRange(1, 1, -1, -1, True)
        SSGRID.Visible = False
        CMDCREDIT.Visible = False
        Cmd_View.Visible = False
        Cmd_Print.Visible = False
        Cmd_Export.Visible = False
        Lbl_AlreadyPosted.Visible = False
        Lbl_Total.Visible = False
        Lbl_Difference.Visible = False
        Txt_DebitTotal.Visible = False
        Txt_CreditTotal.Visible = False
        Txt_Differnce.Visible = False
        Cmd_Clear.Visible = False
    End Sub

    Private Sub Cmd_AuditTrail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_AuditTrail.Click
        Dim MonthNo As String
        If CMBMONTH.Text = "" Then
            Exit Sub
        End If
        If MyValidations() = False Then
            Exit Sub
        End If
        SSGRID.Visible = True
        CMDCREDIT.Visible = True
        Cmd_View.Visible = True
        Cmd_Print.Visible = True
        Cmd_Export.Visible = True
        Lbl_Total.Visible = False
        Lbl_Difference.Visible = True
        Txt_DebitTotal.Visible = True
        Txt_CreditTotal.Visible = True
        Txt_Differnce.Visible = True
        Cmd_Clear.Visible = True

        ssql = "select ISNULL(POSTFLAG,'') AS POSTFLAG from MONTHBILL where mONTHNO ='" & month1 & "' and POSTFLAG ='Y' "
        gconnection.getDataSet(ssql, "monthbill")
        If gdataset.Tables("MONTHBILL").Rows.Count > 0 Then
            Lbl_AlreadyPosted.Visible = True
            CMDCREDIT.Visible = False
        End If

        ssql = " exec MONTHLYACCOUNTSPOSTING_AUDIT_TRAIL '" & month1 & "','" & Format(Now(), "dd-MMM-yyyy") & "'"
        gconnection.ExcuteStoreProcedure(ssql)
        Call GRID_VIEW()

        'ssql = "UPDATE MONTH_VIEW SET ACCOUNTCODEDESC =G.ACDESC FROM MONTH_VIEW A INNER JOIN ACCOUNTSGLACCOUNTMASTER G  ON A.ACCOUNTCODE=G.ACCODE WHERE ISNULL(A.ACCOUNTCODEDESC,'')=''"
        'Call mdlMainFunctions.setRecordset(rs1, ssql)
        'ssql = "UPDATE MONTH_VIEW SET SLDESC =G.SLNAME FROM MONTH_VIEW A INNER JOIN ACCOUNTSSUBLEDGERMASTER G  ON A.ACCOUNTCODE=G.ACCODE AND A.SLCODE=G.SLCODE WHERE ISNULL(A.SLCODE,'')<>'' AND ISNULL(A.SLDESC,'')=''"
        'Call mdlMainFunctions.setRecordset(rs1, ssql)
    End Sub

    Function GRID_VIEW()
        Dim VOutputfile, Vcatefile As String
        Dim sout, rout As String
        Randomize()
        Vcatefile = Mid("CATE" & CStr(Int(Rnd() * 5000)), 1, 8)
        VOutputfile = Mid("SUBS" & CStr(Int(Rnd() * 5000)), 1, 8)
        'Dim rsset As ADODB.Recordset
        sout = Mid("SUS" & CStr(Int(Rnd() * 5000)), 1, 8)
        rout = Mid("REV" & CStr(Int(Rnd() * 5000)), 1, 8)
        Dim Ssql As String
        Dim vroomno As Long
        Dim vsplit() As String
        Dim vAcc As Double
        Dim Total, Debit, Credit, RowNo, I As Double
        Total = 0
        Debit = 0
        Credit = 0
        Ssql = "SELECT ACCOUNTCODE,ACCOUNTCODEDESC,SLCODE,SLDESC,CREDITDEBIT,SUM(AMOUNT) AS AMOUNT FROM MONTH_VIEW GROUP BY ACCOUNTCODE,ACCOUNTCODEDESC,SLCODE,SLDESC,CREDITDEBIT ORDER BY ACCOUNTCODE,SLCODE "
        gconnection.getDataSet(Ssql, "MONTH_VIEW")
        If gdataset.Tables("MONTH_VIEW").Rows.Count = 0 Then
            MsgBox("No Records Available ", vbInformation + vbOKOnly, "MESSAGE")
        Else
            For I = 0 To gdataset.Tables("MONTH_VIEW").Rows.Count - 1
                With SSGRID
                    .Row = I + 1
                    .Col = 1
                    .Text = Trim(gdataset.Tables("MONTH_VIEW").Rows(I).Item("ACCOUNTCODE") & "")
                    .Col = 2
                    .Text = Trim(gdataset.Tables("MONTH_VIEW").Rows(I).Item("ACCOUNTCODEDESC") & "")
                    .Col = 3
                    .Text = Trim(gdataset.Tables("MONTH_VIEW").Rows(I).Item("SLCODE") & "")
                    .Col = 4
                    .Text = Trim(gdataset.Tables("MONTH_VIEW").Rows(I).Item("SLDESC") & "")
                    If Trim(gdataset.Tables("MONTH_VIEW").Rows(I).Item("CREDITDEBIT") & "") = "DEBIT" Then
                        .Col = 6
                        .Text = Format(Val(gdataset.Tables("MONTH_VIEW").Rows(I).Item("AMOUNT")), "0.00")
                        Credit = Credit + Format(Val(gdataset.Tables("MONTH_VIEW").Rows(I).Item("AMOUNT")), "0.00")
                    End If
                    If Trim(gdataset.Tables("MONTH_VIEW").Rows(I).Item("CREDITDEBIT") & "") = "CREDIT" Then
                        .Col = 7
                        .Text = Format(Val(gdataset.Tables("MONTH_VIEW").Rows(I).Item("AMOUNT")), "0.00")
                        Debit = Debit + Format(Val(gdataset.Tables("MONTH_VIEW").Rows(I).Item("AMOUNT")), "0.00")
                    End If
                End With
                If SSGRID.MaxRows < I + 20 Then
                    SSGRID.MaxRows = SSGRID.MaxRows + 100
                End If
            Next
        End If
        With SSGRID
            .Row = .DataRowCnt + 1
            .Col = 4
            .Text = "TOTAL AMOUNT"
            .Col = 6
            .Text = Val(Debit)
            Debit = .Text
            .Col = 7
            .Text = Val(Credit)
            Credit = .Text
        End With
        Txt_DebitTotal.Text = Val(Debit)
        Txt_CreditTotal.Text = Val(Credit)
        Txt_Differnce.Text = Val(Debit) - Val(Credit)
    End Function

    Private Sub Cmd_Export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Export.Click
        Try
            If SSGRID.Visible = True Then
                Call ExportTo(SSGRID)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        PRINTREP = False
        Call Audit_Trail_View()
    End Sub
    Function Audit_Trail_View()
        Dim str()() As String
        Dim i, j, pagesize, pageno, sno As Integer
        Dim cnt As Integer
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim addlist As DataTable
        Try
            ssql = "SELECT ISNULL(ACCOUNTCODE,'') AS ACCOUNTCODE,ISNULL(ACCOUNTCODEDESC,'') AS ACCOUNTCODEDESC,ISNULL(SLCODE,'') AS SLCODE, ISNULL(SLDESC,'') AS SLDESC, ISNULL(CREDITDEBIT,'') AS CREDITDEBIT, SUM(AMOUNT) AS AMOUNT FROM MONTH_VIEW GROUP BY ACCOUNTCODE,ACCOUNTCODEDESC,SLCODE,SLDESC,CREDITDEBIT ORDER BY ACCOUNTCODE,SLCODE "
            addlist = gconnection.GetValues(ssql)
            pageno = 1
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine()
            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            pagesize = 0
            Filewrite.WriteLine("PRINT DATE:" & Format(Now(), "dd/MM/yyyy") & Space(50) & "PAGE NO:" & Trim(CStr(pageno)))
            Filewrite.WriteLine(StrDup(84, "-"))
            Filewrite.WriteLine("|S.NO|AC.CODE|ACCOUNT DESCRIPTION  |SL CODE| SL DESCRIPTION  |  DEBIT   |  CREDIT  |")
            Filewrite.WriteLine(StrDup(84, "-"))
            sno = 1
            For Each dr1 In addlist.Rows
                If pagesize > 60 Then
                    pagesize = 0
                    pageno = pageno + 1
                    Filewrite.WriteLine(StrDup(84, "-"))
                    Filewrite.WriteLine("USER NAME: " & gUsername & Space(30) & "DATE :" & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
                    Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                    Filewrite.WriteLine("PRINT DATE:" & Format(Now(), "dd/MM/yyyy") & Space(48) & "PAGE NO:" & Trim(CStr(pageno)))
                    Filewrite.WriteLine(StrDup(84, "-"))
                    Filewrite.WriteLine("|S.NO|AC.CODE|ACCOUNT DESCRIPTION  |SL CODE| SL DESCRIPTION  |  DEBIT   |  CREDIT  |")
                    Filewrite.WriteLine(StrDup(84, "-"))
                End If
                Dim opstr As String
                opstr = "|" & Mid(Trim(sno), 1, 4) & Space(4 - Len(Mid(sno, 1, 4))) & "" & "|"
                opstr = opstr & " " & Mid(Trim(CStr(dr1("ACCOUNTCODE"))), 1, 6) & Space(6 - Len(Mid(Trim(CStr(dr1("ACCOUNTCODE"))), 1, 6))) & "" & "|"
                opstr = opstr & " " & Mid(Trim(CStr(dr1("ACCOUNTCODEDESC"))), 1, 20) & Space(20 - Len(Mid(Trim(CStr(dr1("ACCOUNTCODEDESC"))), 1, 20))) & "" & "|"
                opstr = opstr & " " & Mid(Trim(CStr(dr1("SLCODE"))), 1, 6) & Space(6 - Len(Mid(Trim(CStr(dr1("SLCODE"))), 1, 6))) & "" & "|"
                opstr = opstr & " " & Mid(Trim(CStr(dr1("SLDESC"))), 1, 16) & Space(16 - Len(Mid(Trim(CStr(dr1("SLDESC"))), 1, 16))) & "" & "|"
                If dr1("CREDITDEBIT") = "DEBIT" Then
                    opstr = opstr & " " & Space(9 - Len(Mid(Trim(CStr(dr1("AMOUNT"))), 1, 9))) & Mid(Trim(CStr(dr1("AMOUNT"))), 1, 9) & "" & "|"
                    opstr = opstr & Space(10) & "|"
                Else
                    opstr = opstr & Space(10)
                    opstr = opstr & "| " & Space(9 - Len(Mid(Trim(CStr(dr1("AMOUNT"))), 1, 9))) & Mid(Trim(CStr(dr1("AMOUNT"))), 1, 9) & "" & "|"
                End If
                Filewrite.WriteLine(opstr)
                sno = sno + 1
                pagesize = pagesize + 1
            Next dr1
            sno = sno - 1
            Filewrite.WriteLine(StrDup(84, "-"))
            Filewrite.WriteLine("TOTAL DEBIT   : " & Txt_DebitTotal.Text)
            Filewrite.WriteLine("TOTAL CREDIT  : " & Txt_CreditTotal.Text)
            Filewrite.WriteLine("TOTAL DIFF.   : " & Txt_Differnce.Text)
            pagesize = pagesize + 4
            Filewrite.WriteLine(StrDup(84, "-"))
            Filewrite.WriteLine("NO. OF ROWS =" & Trim(CStr(sno)) & Space(5) & "USER NAME: " & gUsername & Space(15) & "DATE :" & Format(Date.Now, "dd/MM/yyyy"))
            Filewrite.WriteLine(StrDup(84, "-") & Chr(12))
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Function
        End Try
    End Function

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        PRINTREP = True
        Call Audit_Trail_View()
    End Sub
End Class