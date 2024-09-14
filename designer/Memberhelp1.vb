Option Strict Off
Option Explicit On 
Imports Microsoft.VisualBasic
Imports VB = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Friend Class Memberhelp1
    Inherits System.Windows.Forms.Form
    Dim strcn As String = "Data Source=" & gserver & ";Persist Security Info=False;User ID=sa;pwd=" & SQL_Password & ";Initial Catalog=  " & gDatabase & ";"
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        m_vb6FormDefInstance = Me
                    End If
                Catch
                End Try
            End If
        End If
        'This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub
    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
        If Disposing Then
            If Not components Is Nothing Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(Disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    Public ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents cmdGetDetails As System.Windows.Forms.Button
    Public WithEvents cmdDependents As System.Windows.Forms.Button
    Public WithEvents txtMembers As System.Windows.Forms.Button
    Public WithEvents cmdprint As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents txtSales As System.Windows.Forms.TextBox
    Public WithEvents txtReceipts As System.Windows.Forms.TextBox
    Public WithEvents TxtBalance As System.Windows.Forms.TextBox
    Public WithEvents sSgrid As AxFPSpreadADO.AxfpSpread
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents lbltotal As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents fraDetails As System.Windows.Forms.GroupBox
    Public WithEvents txtSelection As System.Windows.Forms.TextBox
    Public WithEvents optMCode As System.Windows.Forms.RadioButton
    Public WithEvents optAccName As System.Windows.Forms.RadioButton
    Public WithEvents OptCompany As System.Windows.Forms.RadioButton
    Public WithEvents OptOthers As System.Windows.Forms.RadioButton
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents OptPermanent As System.Windows.Forms.RadioButton
    Public WithEvents Optcommunication As System.Windows.Forms.RadioButton
    Public WithEvents lbladd3 As System.Windows.Forms.Label
    Public WithEvents lblAmount As System.Windows.Forms.Label
    Public WithEvents PImage As System.Windows.Forms.PictureBox
    Public WithEvents lblType As System.Windows.Forms.Label
    Public WithEvents lblname As System.Windows.Forms.Label
    Public WithEvents lbladd1 As System.Windows.Forms.Label
    Public WithEvents lbladd2 As System.Windows.Forms.Label
    Public WithEvents lblcity As System.Windows.Forms.Label
    Public WithEvents lblstate As System.Windows.Forms.Label
    Public WithEvents lblpin As System.Windows.Forms.Label
    Public WithEvents lblphone1 As System.Windows.Forms.Label
    Public WithEvents lblphone2 As System.Windows.Forms.Label
    Public WithEvents lblcellno As System.Windows.Forms.Label
    Public WithEvents lblEmail As System.Windows.Forms.Label
    Public WithEvents lblmcode As System.Windows.Forms.Label
    Public WithEvents lblSelection As System.Windows.Forms.Label
    Public WithEvents lbltermination As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents Mskfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Mskto As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents grdSelectionList As AxFPUSpreadADO.AxfpSpread
    Public WithEvents FraDependents As System.Windows.Forms.GroupBox
    Public WithEvents vaDependents As AxFPSpreadADO.AxfpSpread
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Img_Photo As System.Windows.Forms.PictureBox
    Public WithEvents cmd_clear As System.Windows.Forms.Button
    Friend WithEvents Grp_Print As System.Windows.Forms.GroupBox
    Friend WithEvents Chk_freeze As System.Windows.Forms.CheckBox
    Friend WithEvents CMDEXIT As System.Windows.Forms.Button
    Friend WithEvents CMD_WINDOWS As System.Windows.Forms.Button
    Friend WithEvents CMD_DOS As System.Windows.Forms.Button
    Public WithEvents ChkLast As System.Windows.Forms.CheckBox
    Public WithEvents lblCompany As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Memberhelp1))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdGetDetails = New System.Windows.Forms.Button
        Me.fraDetails = New System.Windows.Forms.GroupBox
        Me.sSgrid = New AxFPSpreadADO.AxfpSpread
        Me.FraDependents = New System.Windows.Forms.GroupBox
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.vaDependents = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Mskfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Mskto = New System.Windows.Forms.DateTimePicker
        Me.cmdDependents = New System.Windows.Forms.Button
        Me.txtMembers = New System.Windows.Forms.Button
        Me.cmdprint = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.txtSales = New System.Windows.Forms.TextBox
        Me.txtReceipts = New System.Windows.Forms.TextBox
        Me.TxtBalance = New System.Windows.Forms.TextBox
        Me.lbltotal = New System.Windows.Forms.Label
        Me.txtSelection = New System.Windows.Forms.TextBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.optMCode = New System.Windows.Forms.RadioButton
        Me.optAccName = New System.Windows.Forms.RadioButton
        Me.OptCompany = New System.Windows.Forms.RadioButton
        Me.OptOthers = New System.Windows.Forms.RadioButton
        Me.OptPermanent = New System.Windows.Forms.RadioButton
        Me.Optcommunication = New System.Windows.Forms.RadioButton
        Me.lbladd3 = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.PImage = New System.Windows.Forms.PictureBox
        Me.lblType = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.lbladd1 = New System.Windows.Forms.Label
        Me.lbladd2 = New System.Windows.Forms.Label
        Me.lblcity = New System.Windows.Forms.Label
        Me.lblstate = New System.Windows.Forms.Label
        Me.lblpin = New System.Windows.Forms.Label
        Me.lblphone1 = New System.Windows.Forms.Label
        Me.lblphone2 = New System.Windows.Forms.Label
        Me.lblcellno = New System.Windows.Forms.Label
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblmcode = New System.Windows.Forms.Label
        Me.lblSelection = New System.Windows.Forms.Label
        Me.lbltermination = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.grdSelectionList = New AxFPUSpreadADO.AxfpSpread
        Me.cmd_clear = New System.Windows.Forms.Button
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Label29 = New System.Windows.Forms.Label
        Me.Img_Photo = New System.Windows.Forms.PictureBox
        Me.Grp_Print = New System.Windows.Forms.GroupBox
        Me.Chk_freeze = New System.Windows.Forms.CheckBox
        Me.CMD_WINDOWS = New System.Windows.Forms.Button
        Me.CMDEXIT = New System.Windows.Forms.Button
        Me.CMD_DOS = New System.Windows.Forms.Button
        Me.ChkLast = New System.Windows.Forms.CheckBox
        Me.lblCompany = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.fraDetails.SuspendLayout()
        CType(Me.sSgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraDependents.SuspendLayout()
        CType(Me.vaDependents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdSelectionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp_Print.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(8, 248)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(66, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Exit (Esc)"
        Me.ToolTip1.SetToolTip(Me.Label5, "Click here")
        '
        'cmdGetDetails
        '
        Me.cmdGetDetails.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cmdGetDetails.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGetDetails.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetDetails.ForeColor = System.Drawing.Color.White
        Me.cmdGetDetails.Image = CType(resources.GetObject("cmdGetDetails.Image"), System.Drawing.Image)
        Me.cmdGetDetails.Location = New System.Drawing.Point(48, 384)
        Me.cmdGetDetails.Name = "cmdGetDetails"
        Me.cmdGetDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetDetails.Size = New System.Drawing.Size(120, 30)
        Me.cmdGetDetails.TabIndex = 40
        Me.cmdGetDetails.Text = "MORE DETAILS"
        '
        'fraDetails
        '
        Me.fraDetails.BackColor = System.Drawing.Color.Transparent
        Me.fraDetails.Controls.Add(Me.sSgrid)
        Me.fraDetails.Controls.Add(Me.FraDependents)
        Me.fraDetails.Controls.Add(Me.GroupBox1)
        Me.fraDetails.Controls.Add(Me.cmdDependents)
        Me.fraDetails.Controls.Add(Me.txtMembers)
        Me.fraDetails.Controls.Add(Me.cmdprint)
        Me.fraDetails.Controls.Add(Me.Command1)
        Me.fraDetails.Controls.Add(Me.txtSales)
        Me.fraDetails.Controls.Add(Me.txtReceipts)
        Me.fraDetails.Controls.Add(Me.TxtBalance)
        Me.fraDetails.Controls.Add(Me.Label5)
        Me.fraDetails.Controls.Add(Me.lbltotal)
        Me.fraDetails.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraDetails.ForeColor = System.Drawing.Color.Black
        Me.fraDetails.Location = New System.Drawing.Point(40, 416)
        Me.fraDetails.Name = "fraDetails"
        Me.fraDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDetails.Size = New System.Drawing.Size(944, 288)
        Me.fraDetails.TabIndex = 10
        Me.fraDetails.TabStop = False
        Me.fraDetails.Visible = False
        '
        'sSgrid
        '
        Me.sSgrid.ContainingControl = Me
        Me.sSgrid.DataSource = Nothing
        Me.sSgrid.Location = New System.Drawing.Point(0, 56)
        Me.sSgrid.Name = "sSgrid"
        Me.sSgrid.OcxState = CType(resources.GetObject("sSgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sSgrid.Size = New System.Drawing.Size(928, 176)
        Me.sSgrid.TabIndex = 45
        '
        'FraDependents
        '
        Me.FraDependents.BackColor = System.Drawing.Color.FromArgb(CType(138, Byte), CType(163, Byte), CType(168, Byte))
        Me.FraDependents.BackgroundImage = CType(resources.GetObject("FraDependents.BackgroundImage"), System.Drawing.Image)
        Me.FraDependents.Controls.Add(Me.LinkLabel1)
        Me.FraDependents.Controls.Add(Me.vaDependents)
        Me.FraDependents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FraDependents.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.FraDependents.Location = New System.Drawing.Point(24, 56)
        Me.FraDependents.Name = "FraDependents"
        Me.FraDependents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FraDependents.Size = New System.Drawing.Size(888, 144)
        Me.FraDependents.TabIndex = 51
        Me.FraDependents.TabStop = False
        Me.FraDependents.Text = "DEPENDENT NAME "
        '
        'LinkLabel1
        '
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(8, 184)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(64, 16)
        Me.LinkLabel1.TabIndex = 48
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "BACK"
        '
        'vaDependents
        '
        Me.vaDependents.ContainingControl = Me
        Me.vaDependents.DataSource = Nothing
        Me.vaDependents.Location = New System.Drawing.Point(8, 0)
        Me.vaDependents.Name = "vaDependents"
        Me.vaDependents.OcxState = CType(resources.GetObject("vaDependents.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vaDependents.Size = New System.Drawing.Size(968, 176)
        Me.vaDependents.TabIndex = 47
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Mskfrom)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Mskto)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 40)
        Me.GroupBox1.TabIndex = 50
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label6.Location = New System.Drawing.Point(56, 14)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(44, 16)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "FROM :"
        '
        'Mskfrom
        '
        Me.Mskfrom.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mskfrom.CustomFormat = "dd/MM/yyyy"
        Me.Mskfrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mskfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Mskfrom.Location = New System.Drawing.Point(104, 12)
        Me.Mskfrom.Name = "Mskfrom"
        Me.Mskfrom.Size = New System.Drawing.Size(104, 22)
        Me.Mskfrom.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label8.Location = New System.Drawing.Point(0, 13)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(56, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "PERIOD"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label7.Location = New System.Drawing.Point(232, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(27, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "TO :"
        '
        'Mskto
        '
        Me.Mskto.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mskto.CustomFormat = "dd/MM/yyyy"
        Me.Mskto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mskto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Mskto.Location = New System.Drawing.Point(264, 13)
        Me.Mskto.Name = "Mskto"
        Me.Mskto.Size = New System.Drawing.Size(104, 22)
        Me.Mskto.TabIndex = 49
        '
        'cmdDependents
        '
        Me.cmdDependents.BackColor = System.Drawing.Color.Transparent
        Me.cmdDependents.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDependents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDependents.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDependents.ForeColor = System.Drawing.Color.White
        Me.cmdDependents.Image = CType(resources.GetObject("cmdDependents.Image"), System.Drawing.Image)
        Me.cmdDependents.Location = New System.Drawing.Point(808, 56)
        Me.cmdDependents.Name = "cmdDependents"
        Me.cmdDependents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDependents.Size = New System.Drawing.Size(114, 25)
        Me.cmdDependents.TabIndex = 44
        Me.cmdDependents.Text = "DEPENDENTS"
        Me.cmdDependents.Visible = False
        '
        'txtMembers
        '
        Me.txtMembers.BackColor = System.Drawing.Color.Transparent
        Me.txtMembers.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtMembers.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMembers.ForeColor = System.Drawing.Color.White
        Me.txtMembers.Image = CType(resources.GetObject("txtMembers.Image"), System.Drawing.Image)
        Me.txtMembers.Location = New System.Drawing.Point(808, 56)
        Me.txtMembers.Name = "txtMembers"
        Me.txtMembers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMembers.Size = New System.Drawing.Size(119, 26)
        Me.txtMembers.TabIndex = 43
        Me.txtMembers.Text = "TOTAL MEMBERS"
        Me.txtMembers.Visible = False
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.Color.Transparent
        Me.cmdprint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdprint.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.ForeColor = System.Drawing.Color.White
        Me.cmdprint.Image = CType(resources.GetObject("cmdprint.Image"), System.Drawing.Image)
        Me.cmdprint.Location = New System.Drawing.Point(512, 8)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdprint.Size = New System.Drawing.Size(104, 32)
        Me.cmdprint.TabIndex = 42
        Me.cmdprint.Text = "PRINT"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.Color.Transparent
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Command1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.Color.White
        Me.Command1.Image = CType(resources.GetObject("Command1.Image"), System.Drawing.Image)
        Me.Command1.Location = New System.Drawing.Point(408, 8)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(104, 32)
        Me.Command1.TabIndex = 41
        Me.Command1.Text = "GET DETAILS"
        '
        'txtSales
        '
        Me.txtSales.AcceptsReturn = True
        Me.txtSales.AutoSize = False
        Me.txtSales.BackColor = System.Drawing.Color.Wheat
        Me.txtSales.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSales.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSales.Location = New System.Drawing.Point(708, 240)
        Me.txtSales.MaxLength = 0
        Me.txtSales.Name = "txtSales"
        Me.txtSales.ReadOnly = True
        Me.txtSales.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSales.Size = New System.Drawing.Size(95, 24)
        Me.txtSales.TabIndex = 13
        Me.txtSales.Text = ""
        Me.txtSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReceipts
        '
        Me.txtReceipts.AcceptsReturn = True
        Me.txtReceipts.AutoSize = False
        Me.txtReceipts.BackColor = System.Drawing.Color.Wheat
        Me.txtReceipts.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReceipts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceipts.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtReceipts.Location = New System.Drawing.Point(592, 240)
        Me.txtReceipts.MaxLength = 0
        Me.txtReceipts.Name = "txtReceipts"
        Me.txtReceipts.ReadOnly = True
        Me.txtReceipts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtReceipts.Size = New System.Drawing.Size(101, 24)
        Me.txtReceipts.TabIndex = 12
        Me.txtReceipts.Text = ""
        Me.txtReceipts.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtBalance
        '
        Me.TxtBalance.AcceptsReturn = True
        Me.TxtBalance.AutoSize = False
        Me.TxtBalance.BackColor = System.Drawing.Color.Wheat
        Me.TxtBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBalance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBalance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtBalance.Location = New System.Drawing.Point(821, 240)
        Me.TxtBalance.MaxLength = 0
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.ReadOnly = True
        Me.TxtBalance.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtBalance.Size = New System.Drawing.Size(93, 24)
        Me.TxtBalance.TabIndex = 11
        Me.TxtBalance.Text = ""
        Me.TxtBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BackColor = System.Drawing.Color.Transparent
        Me.lbltotal.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltotal.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(448, 240)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltotal.Size = New System.Drawing.Size(120, 18)
        Me.lbltotal.TabIndex = 19
        Me.lbltotal.Text = "TOTAL AMOUNT :"
        '
        'txtSelection
        '
        Me.txtSelection.AcceptsReturn = True
        Me.txtSelection.AutoSize = False
        Me.txtSelection.BackColor = System.Drawing.Color.Wheat
        Me.txtSelection.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSelection.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSelection.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelection.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSelection.Location = New System.Drawing.Point(144, 96)
        Me.txtSelection.MaxLength = 25
        Me.txtSelection.Name = "txtSelection"
        Me.txtSelection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSelection.Size = New System.Drawing.Size(233, 24)
        Me.txtSelection.TabIndex = 9
        Me.txtSelection.Text = ""
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me.optMCode)
        Me.Frame1.Controls.Add(Me.optAccName)
        Me.Frame1.Controls.Add(Me.OptCompany)
        Me.Frame1.Controls.Add(Me.OptOthers)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(144, 56)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(200, 35)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        '
        'optMCode
        '
        Me.optMCode.BackColor = System.Drawing.Color.Transparent
        Me.optMCode.Checked = True
        Me.optMCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMCode.Location = New System.Drawing.Point(4, 12)
        Me.optMCode.Name = "optMCode"
        Me.optMCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMCode.Size = New System.Drawing.Size(88, 15)
        Me.optMCode.TabIndex = 8
        Me.optMCode.TabStop = True
        Me.optMCode.Text = "CODE"
        '
        'optAccName
        '
        Me.optAccName.BackColor = System.Drawing.Color.Transparent
        Me.optAccName.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAccName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAccName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAccName.Location = New System.Drawing.Point(107, 13)
        Me.optAccName.Name = "optAccName"
        Me.optAccName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAccName.Size = New System.Drawing.Size(88, 15)
        Me.optAccName.TabIndex = 7
        Me.optAccName.TabStop = True
        Me.optAccName.Text = "NAME"
        '
        'OptCompany
        '
        Me.OptCompany.BackColor = System.Drawing.Color.Transparent
        Me.OptCompany.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptCompany.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCompany.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptCompany.Location = New System.Drawing.Point(208, 14)
        Me.OptCompany.Name = "OptCompany"
        Me.OptCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptCompany.Size = New System.Drawing.Size(99, 15)
        Me.OptCompany.TabIndex = 6
        Me.OptCompany.TabStop = True
        Me.OptCompany.Text = "COMPANY"
        Me.OptCompany.Visible = False
        '
        'OptOthers
        '
        Me.OptOthers.BackColor = System.Drawing.Color.Transparent
        Me.OptOthers.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptOthers.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptOthers.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptOthers.Location = New System.Drawing.Point(328, 14)
        Me.OptOthers.Name = "OptOthers"
        Me.OptOthers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptOthers.Size = New System.Drawing.Size(88, 15)
        Me.OptOthers.TabIndex = 5
        Me.OptOthers.TabStop = True
        Me.OptOthers.Text = "OTHERS"
        Me.OptOthers.Visible = False
        '
        'OptPermanent
        '
        Me.OptPermanent.BackColor = System.Drawing.Color.Transparent
        Me.OptPermanent.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptPermanent.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPermanent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptPermanent.Location = New System.Drawing.Point(728, 0)
        Me.OptPermanent.Name = "OptPermanent"
        Me.OptPermanent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptPermanent.Size = New System.Drawing.Size(136, 17)
        Me.OptPermanent.TabIndex = 3
        Me.OptPermanent.TabStop = True
        Me.OptPermanent.Text = "PERMANENT"
        '
        'Optcommunication
        '
        Me.Optcommunication.BackColor = System.Drawing.Color.Transparent
        Me.Optcommunication.Cursor = System.Windows.Forms.Cursors.Default
        Me.Optcommunication.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Optcommunication.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Optcommunication.Location = New System.Drawing.Point(872, 0)
        Me.Optcommunication.Name = "Optcommunication"
        Me.Optcommunication.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Optcommunication.Size = New System.Drawing.Size(168, 19)
        Me.Optcommunication.TabIndex = 2
        Me.Optcommunication.TabStop = True
        Me.Optcommunication.Text = "COMMUNICATION"
        '
        'lbladd3
        '
        Me.lbladd3.BackColor = System.Drawing.Color.Transparent
        Me.lbladd3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbladd3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd3.ForeColor = System.Drawing.Color.Black
        Me.lbladd3.Location = New System.Drawing.Point(560, 304)
        Me.lbladd3.Name = "lbladd3"
        Me.lbladd3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbladd3.Size = New System.Drawing.Size(408, 16)
        Me.lbladd3.TabIndex = 49
        Me.lbladd3.Text = "lblAdd3"
        '
        'lblAmount
        '
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAmount.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(368, 376)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAmount.Size = New System.Drawing.Size(128, 30)
        Me.lblAmount.TabIndex = 39
        Me.lblAmount.Text = "lblAmount"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblAmount.Visible = False
        '
        'PImage
        '
        Me.PImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.PImage.Location = New System.Drawing.Point(848, 144)
        Me.PImage.Name = "PImage"
        Me.PImage.Size = New System.Drawing.Size(106, 112)
        Me.PImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PImage.TabIndex = 51
        Me.PImage.TabStop = False
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblType.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(64, Byte), CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(560, 136)
        Me.lblType.Name = "lblType"
        Me.lblType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblType.Size = New System.Drawing.Size(59, 22)
        Me.lblType.TabIndex = 37
        Me.lblType.Text = "lbltype"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.Black
        Me.lblname.Location = New System.Drawing.Point(560, 208)
        Me.lblname.Name = "lblname"
        Me.lblname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblname.Size = New System.Drawing.Size(55, 18)
        Me.lblname.TabIndex = 36
        Me.lblname.Text = "lblname"
        '
        'lbladd1
        '
        Me.lbladd1.BackColor = System.Drawing.Color.Transparent
        Me.lbladd1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbladd1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd1.ForeColor = System.Drawing.Color.Black
        Me.lbladd1.Location = New System.Drawing.Point(560, 240)
        Me.lbladd1.Name = "lbladd1"
        Me.lbladd1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbladd1.Size = New System.Drawing.Size(408, 16)
        Me.lbladd1.TabIndex = 35
        Me.lbladd1.Text = "lblAdd1"
        '
        'lbladd2
        '
        Me.lbladd2.BackColor = System.Drawing.Color.Transparent
        Me.lbladd2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbladd2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd2.ForeColor = System.Drawing.Color.Black
        Me.lbladd2.Location = New System.Drawing.Point(560, 272)
        Me.lbladd2.Name = "lbladd2"
        Me.lbladd2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbladd2.Size = New System.Drawing.Size(408, 16)
        Me.lbladd2.TabIndex = 34
        Me.lbladd2.Text = "lblAdd2"
        '
        'lblcity
        '
        Me.lblcity.BackColor = System.Drawing.Color.Transparent
        Me.lblcity.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcity.ForeColor = System.Drawing.Color.Black
        Me.lblcity.Location = New System.Drawing.Point(560, 328)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcity.Size = New System.Drawing.Size(152, 18)
        Me.lblcity.TabIndex = 33
        Me.lblcity.Text = "lblcity"
        '
        'lblstate
        '
        Me.lblstate.BackColor = System.Drawing.Color.Transparent
        Me.lblstate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblstate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstate.ForeColor = System.Drawing.Color.Black
        Me.lblstate.Location = New System.Drawing.Point(560, 352)
        Me.lblstate.Name = "lblstate"
        Me.lblstate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblstate.Size = New System.Drawing.Size(152, 18)
        Me.lblstate.TabIndex = 32
        Me.lblstate.Text = "lblstate"
        '
        'lblpin
        '
        Me.lblpin.BackColor = System.Drawing.Color.Transparent
        Me.lblpin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblpin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpin.ForeColor = System.Drawing.Color.Black
        Me.lblpin.Location = New System.Drawing.Point(560, 376)
        Me.lblpin.Name = "lblpin"
        Me.lblpin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblpin.Size = New System.Drawing.Size(152, 18)
        Me.lblpin.TabIndex = 31
        Me.lblpin.Text = "lblpin"
        '
        'lblphone1
        '
        Me.lblphone1.BackColor = System.Drawing.Color.Transparent
        Me.lblphone1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblphone1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone1.ForeColor = System.Drawing.Color.Black
        Me.lblphone1.Location = New System.Drawing.Point(792, 352)
        Me.lblphone1.Name = "lblphone1"
        Me.lblphone1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblphone1.Size = New System.Drawing.Size(120, 18)
        Me.lblphone1.TabIndex = 30
        Me.lblphone1.Text = "lblphone1"
        '
        'lblphone2
        '
        Me.lblphone2.BackColor = System.Drawing.Color.Transparent
        Me.lblphone2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblphone2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone2.ForeColor = System.Drawing.Color.Black
        Me.lblphone2.Location = New System.Drawing.Point(792, 376)
        Me.lblphone2.Name = "lblphone2"
        Me.lblphone2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblphone2.Size = New System.Drawing.Size(68, 18)
        Me.lblphone2.TabIndex = 29
        Me.lblphone2.Text = "lblphone2"
        '
        'lblcellno
        '
        Me.lblcellno.BackColor = System.Drawing.Color.Transparent
        Me.lblcellno.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcellno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcellno.ForeColor = System.Drawing.Color.Black
        Me.lblcellno.Location = New System.Drawing.Point(792, 328)
        Me.lblcellno.Name = "lblcellno"
        Me.lblcellno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcellno.Size = New System.Drawing.Size(152, 18)
        Me.lblcellno.TabIndex = 28
        Me.lblcellno.Text = "lblCellno"
        '
        'lblEmail
        '
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Black
        Me.lblEmail.Location = New System.Drawing.Point(560, 400)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEmail.Size = New System.Drawing.Size(240, 18)
        Me.lblEmail.TabIndex = 27
        Me.lblEmail.Text = "lblEmail"
        '
        'lblmcode
        '
        Me.lblmcode.AutoSize = True
        Me.lblmcode.BackColor = System.Drawing.Color.Transparent
        Me.lblmcode.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmcode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmcode.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(64, Byte), CType(0, Byte))
        Me.lblmcode.Location = New System.Drawing.Point(560, 160)
        Me.lblmcode.Name = "lblmcode"
        Me.lblmcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmcode.Size = New System.Drawing.Size(78, 22)
        Me.lblmcode.TabIndex = 26
        Me.lblmcode.Text = "lblmcode"
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.BackColor = System.Drawing.Color.Transparent
        Me.lblSelection.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSelection.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.lblSelection.Location = New System.Drawing.Point(48, 96)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSelection.Size = New System.Drawing.Size(70, 18)
        Me.lblSelection.TabIndex = 25
        Me.lblSelection.Text = "SEARCH :"
        '
        'lbltermination
        '
        Me.lbltermination.AutoSize = True
        Me.lbltermination.BackColor = System.Drawing.Color.Transparent
        Me.lbltermination.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltermination.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltermination.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lbltermination.Location = New System.Drawing.Point(40, 152)
        Me.lbltermination.Name = "lbltermination"
        Me.lbltermination.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltermination.Size = New System.Drawing.Size(119, 22)
        Me.lbltermination.TabIndex = 23
        Me.lbltermination.Text = "lblTermination"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(560, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(60, 18)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "lblstatus"
        Me.Label2.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.grdSelectionList)
        Me.GroupBox3.Location = New System.Drawing.Point(40, 136)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(496, 248)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'grdSelectionList
        '
        Me.grdSelectionList.ContainingControl = Me
        Me.grdSelectionList.DataSource = Nothing
        Me.grdSelectionList.Location = New System.Drawing.Point(8, 8)
        Me.grdSelectionList.Name = "grdSelectionList"
        Me.grdSelectionList.OcxState = CType(resources.GetObject("grdSelectionList.OcxState"), System.Windows.Forms.AxHost.State)
        Me.grdSelectionList.Size = New System.Drawing.Size(488, 232)
        Me.grdSelectionList.TabIndex = 49
        '
        'cmd_clear
        '
        Me.cmd_clear.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.cmd_clear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmd_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_clear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clear.ForeColor = System.Drawing.Color.White
        Me.cmd_clear.Image = CType(resources.GetObject("cmd_clear.Image"), System.Drawing.Image)
        Me.cmd_clear.Location = New System.Drawing.Point(176, 384)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmd_clear.Size = New System.Drawing.Size(112, 30)
        Me.cmd_clear.TabIndex = 50
        Me.cmd_clear.Text = "CLEAR "
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Black
        Me.Label29.Location = New System.Drawing.Point(848, 120)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(112, 18)
        Me.Label29.TabIndex = 663
        Me.Label29.Text = "Member Photo"
        '
        'Img_Photo
        '
        Me.Img_Photo.BackColor = System.Drawing.Color.Transparent
        Me.Img_Photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Img_Photo.Location = New System.Drawing.Point(848, 144)
        Me.Img_Photo.Name = "Img_Photo"
        Me.Img_Photo.Size = New System.Drawing.Size(112, 112)
        Me.Img_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Img_Photo.TabIndex = 662
        Me.Img_Photo.TabStop = False
        '
        'Grp_Print
        '
        Me.Grp_Print.BackColor = System.Drawing.Color.Transparent
        Me.Grp_Print.Controls.Add(Me.Chk_freeze)
        Me.Grp_Print.Controls.Add(Me.CMD_WINDOWS)
        Me.Grp_Print.Controls.Add(Me.CMDEXIT)
        Me.Grp_Print.Controls.Add(Me.CMD_DOS)
        Me.Grp_Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_Print.Location = New System.Drawing.Point(656, 416)
        Me.Grp_Print.Name = "Grp_Print"
        Me.Grp_Print.Size = New System.Drawing.Size(320, 40)
        Me.Grp_Print.TabIndex = 664
        Me.Grp_Print.TabStop = False
        Me.Grp_Print.Visible = False
        '
        'Chk_freeze
        '
        Me.Chk_freeze.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_freeze.Location = New System.Drawing.Point(248, 64)
        Me.Chk_freeze.Name = "Chk_freeze"
        Me.Chk_freeze.TabIndex = 3
        Me.Chk_freeze.Text = "Freeze"
        '
        'CMD_WINDOWS
        '
        Me.CMD_WINDOWS.BackColor = System.Drawing.Color.White
        Me.CMD_WINDOWS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD_WINDOWS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_WINDOWS.ForeColor = System.Drawing.Color.White
        Me.CMD_WINDOWS.Image = CType(resources.GetObject("CMD_WINDOWS.Image"), System.Drawing.Image)
        Me.CMD_WINDOWS.Location = New System.Drawing.Point(120, 8)
        Me.CMD_WINDOWS.Name = "CMD_WINDOWS"
        Me.CMD_WINDOWS.Size = New System.Drawing.Size(104, 32)
        Me.CMD_WINDOWS.TabIndex = 1
        Me.CMD_WINDOWS.Text = "WINDOWS"
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.White
        Me.CMDEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMDEXIT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.Color.White
        Me.CMDEXIT.Image = CType(resources.GetObject("CMDEXIT.Image"), System.Drawing.Image)
        Me.CMDEXIT.Location = New System.Drawing.Point(224, 8)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.Size = New System.Drawing.Size(88, 32)
        Me.CMDEXIT.TabIndex = 2
        Me.CMDEXIT.Text = "EXIT"
        '
        'CMD_DOS
        '
        Me.CMD_DOS.BackColor = System.Drawing.Color.White
        Me.CMD_DOS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CMD_DOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMD_DOS.ForeColor = System.Drawing.Color.White
        Me.CMD_DOS.Image = CType(resources.GetObject("CMD_DOS.Image"), System.Drawing.Image)
        Me.CMD_DOS.Location = New System.Drawing.Point(24, 8)
        Me.CMD_DOS.Name = "CMD_DOS"
        Me.CMD_DOS.Size = New System.Drawing.Size(96, 32)
        Me.CMD_DOS.TabIndex = 0
        Me.CMD_DOS.Text = "DOS"
        '
        'ChkLast
        '
        Me.ChkLast.BackColor = System.Drawing.Color.FromArgb(CType(138, Byte), CType(163, Byte), CType(168, Byte))
        Me.ChkLast.BackgroundImage = CType(resources.GetObject("ChkLast.BackgroundImage"), System.Drawing.Image)
        Me.ChkLast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkLast.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkLast.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkLast.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkLast.Location = New System.Drawing.Point(18, 10)
        Me.ChkLast.Name = "ChkLast"
        Me.ChkLast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkLast.Size = New System.Drawing.Size(152, 16)
        Me.ChkLast.TabIndex = 0
        Me.ChkLast.Text = "PREVIOUS YEAR"
        Me.ChkLast.Visible = False
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCompany.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.Color.FromArgb(CType(0, Byte), CType(128, Byte), CType(0, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(824, 16)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCompany.Size = New System.Drawing.Size(143, 22)
        Me.lblCompany.TabIndex = 24
        Me.lblCompany.Text = "lblCompanyname"
        Me.lblCompany.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(192, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(163, 22)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "As on Outstanding :"
        '
        'Memberhelp1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1030, 690)
        Me.ControlBox = False
        Me.Controls.Add(Me.Grp_Print)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Img_Photo)
        Me.Controls.Add(Me.fraDetails)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtSelection)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.lbltermination)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lblmcode)
        Me.Controls.Add(Me.lblCompany)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.ChkLast)
        Me.Controls.Add(Me.PImage)
        Me.Controls.Add(Me.lbladd1)
        Me.Controls.Add(Me.lbladd2)
        Me.Controls.Add(Me.lblcity)
        Me.Controls.Add(Me.lblstate)
        Me.Controls.Add(Me.lblpin)
        Me.Controls.Add(Me.lbladd3)
        Me.Controls.Add(Me.cmdGetDetails)
        Me.Controls.Add(Me.cmd_clear)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.lblphone1)
        Me.Controls.Add(Me.lblphone2)
        Me.Controls.Add(Me.lblcellno)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.OptPermanent)
        Me.Controls.Add(Me.Optcommunication)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(5, 56)
        Me.Name = "Memberhelp1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.fraDetails.ResumeLayout(False)
        CType(Me.sSgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraDependents.ResumeLayout(False)
        CType(Me.vaDependents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdSelectionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp_Print.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Memberhelp1
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Memberhelp1
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Memberhelp1
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As Memberhelp1)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
    '***************************************************  Modified On 11/04/2007 **************************************
    Dim Vconn As New GlobalClass
    Dim FormUnload As Boolean
    Dim vTotal, total As Double
    Dim VRowCount As Short
    Dim SideLedgerName, MemberCode, vMemAcc, vUser, vSql, gPicture, creditdebit As String
    Private Sub ChkLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ChkLast.CheckStateChanged
        Dim gConnection As Object
        If ChkLast.CheckState = 1 Then
            vUser = Trim(gDatabase)
        Else
            vUser = Trim(gDatabase)
        End If
    End Sub
    Private Sub ChkLast_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ChkLast.Leave
        Call ChkLast_CheckStateChanged(eventSender, eventArgs)
    End Sub
    Private Sub cmdDependents_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDependents.Click
        Dim adOpenDynamic, MainMenu, DoubleApostrophe, ADODB As Object
        Dim loopindex As Integer
        Dim ssql As String
        If lblmcode.Text <> "" Then
            ssql = "SELECT ISNULL(CHILD_NM,'') AS DNAME,ISNULL(RELATION,'') AS RELATIONSHIP,ISNULL(CHILD_DOB,'') AS DOB,ISNULL(SEX,'') AS SEX "
            ssql = ssql & " FROM " & Trim(vUser) & "..MEMDET WHERE MEM_CODE = '" & Trim(lblmcode.Text) & "' and type0 = 'chld'"
            Vconn.getCompanyinfo(ssql, "DEPENDENTMASTER")
            If gdataset.Tables("DEPENDENTMASTER").Rows.Count > 0 Then
                For loopindex = 0 To gdataset.Tables("DEPENDENTMASTER").Rows.Count - 1
                    vaDependents.SetText(1, loopindex + 1, Trim(gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("DNAME")))
                    vaDependents.SetText(2, loopindex + 1, Trim(gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("RELATIONSHIP")))
                    If Format((gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("DOB")), "dd-MMM-yyyy") <> "01-Jan-1900" Then
                        vaDependents.SetText(3, loopindex + 1, Format((gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("DOB")), "dd-MMM-yyyy"))
                    Else
                        vaDependents.SetText(3, loopindex + 1, "")
                    End If
                    vaDependents.SetText(4, loopindex + 1, Trim(gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("SEX")))
                Next
                FraDependents.Visible = True
            Else
                MsgBox("Dependent Details are not there", MsgBoxStyle.Information, Trim(MyCompanyName))
                Exit Sub
            End If
        End If
    End Sub
    Private Sub CmdGetDetails_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGetDetails.Click
        fraDetails.Visible = True
        FraDependents.Visible = False
        TxtBalance.Text = ""
        txtReceipts.Text = ""
        TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        txtSales.Text = ""
        Mskfrom.Focus()
    End Sub
    Private Sub CmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdprint.Click
        Grp_Print.Visible = True
    End Sub
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        TxtBalance.Text = ""
        txtReceipts.Text = ""
        txtSales.Text = ""
        TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        Call FillGrid1()
        sSgrid.Focus()
    End Sub
    Private Sub Memberhelp1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim SideLedgerList As Object
        If KeyAscii = System.Windows.Forms.Keys.Escape Then
            Me.Close()
            SideLedgerList = Nothing
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub MyFillGrid1()
        Dim SQLSTRING As String
        lblAmount.Text = ""
        If OptOthers.Checked Then
            SQLSTRING = "SELECT ISNULL(PNAME,'') AS SUBNAME,ISNULL(PNAME,'') AS SUBCODE FROM ADDRESSSEARCH WHERE PNAME LIKE '" & (Trim(txtSelection.Text)) & "%' ORDER BY PNAME"
        Else
            If optMCode.Checked = True Then
                SQLSTRING = "SELECT ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(SUBCODE,'') AS SUBCODE FROM SUBLEDGERLIST1 "
                SQLSTRING = SQLSTRING & " WHERE   SUBCODE LIKE '" & (Trim(txtSelection.Text)) & "%' "
                SQLSTRING = SQLSTRING & " AND ACCODE='" & Trim(gDebtors) & "' ORDER BY SUBCODE "
            ElseIf optAccName.Checked Then
                SQLSTRING = "SELECT ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(SUBCODE,'') AS SUBCODE FROM SUBLEDGERLIST1 "
                SQLSTRING = SQLSTRING & " WHERE   SUBNAME LIKE '" & (Trim(txtSelection.Text)) & "%' "
                SQLSTRING = SQLSTRING & " AND ACCODE='" & Trim(gDebtors) & "' ORDER BY SUBCODE "
            ElseIf OptCompany.Checked Then
                SQLSTRING = "SELECT ISNULL(MNAME,'') AS SUBNAME,ISNULL(MCODE,'') AS SUBCODE FROM MEMBERMASTER WHERE UPPER(COMPANY) LIKE '" & (Trim(txtSelection.Text)) & "%' ORDER BY COMPANY,MCODE"
            End If
        End If
        Vconn.getDataSet(SQLSTRING, "SubledgerList1")
        Dim loopindex As Integer
        If gdataset.Tables("SubledgerList1").Rows.Count > 0 Then
            If grdSelectionList.DataRowCnt < gdataset.Tables("SubledgerList1").Rows.Count - 1 Then
                grdSelectionList.MaxRows = gdataset.Tables("SubledgerList1").Rows.Count + 3
            End If
            For loopindex = 0 To gdataset.Tables("SubledgerList1").Rows.Count - 1
                grdSelectionList.Col = 1
                grdSelectionList.Row = loopindex + 1
                grdSelectionList.Text = CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("Subcode"))
                grdSelectionList.Col = 2
                grdSelectionList.Row = loopindex + 1
                grdSelectionList.Text = CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("SubName"))
            Next
        Else
            lblAmount.Text = ""
            MsgBox("Details not found.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "" & gCompanyname)
            txtSelection.Text = ""
            FormUnload = True
        End If
    End Sub
    Private Sub GetMemAcc()
        Dim adLockPessimistic, adOpenDynamic, MainMenu, ADODB As Object
        vSql = "SELECT ISNULL(SLCODE,'') AS SLCODE FROM " & Trim(vUser & "") & "..ACCOUNTSSUBLEDGERMASTER WHERE SLCODE ='" & Trim(lblmcode.Text) & "'"
        Vconn.getDataSet(vSql, "ACCOUNTSSUBLEDGERMASTER")
        If gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows.Count > 0 Then
            vMemAcc = Trim(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("SLCODE") & "")
        End If
    End Sub
    Private Sub Memberhelp1_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        If FormUnload Then
            Me.Hide()
        End If
    End Sub
    Private Sub Memberhelp1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim gConnection As Object
        lblType.Text = ""
        lblname.Text = ""
        lblmcode.Text = ""
        lbladd1.Text = ""
        lbladd2.Text = ""
        lbladd3.Text = ""
        lblcity.Text = ""
        lblstate.Text = ""
        lblpin.Text = ""
        lblphone1.Text = ""
        lblphone2.Text = ""
        lblcellno.Text = ""
        lblEmail.Text = ""
        lblAmount.Text = ""
        lblCompany.Text = ""
        gPicture = ""
        Img_Photo.Image = Nothing
        OptPermanent.Checked = False
        Optcommunication.Checked = True
        Mskfrom.Value = gFinancialyearStart
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        lbltermination.Text = ""
        Me.Text = "Member Details"
        vUser = gDatabase
        txtSelection.Focus()
    End Sub

    Private Sub Label5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label5.Click
        Me.Close()
        Memberhelp1.DefInstance = Nothing
    End Sub

    Private Sub mskfrom_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim DateBoxBlocking As Object
        'Call DateBoxBlocking(mskfrom)
    End Sub
    'Private Sub MskFrom_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMSMask.MaskEdBoxEvents_KeyPressEvent)
    '    If eventArgs.keyAscii = System.Windows.Forms.Keys.Return Then
    '        Mskto.Focus()
    '    End If
    'End Sub
    Private Sub mskTo_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim DateBoxBlocking As Object
        'Call DateBoxBlocking(mskTo)
    End Sub
    'Private Sub Mskto_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As Mskto.KeyPressEvent)
    '    If eventArgs.keyAscii = System.Windows.Forms.Keys.Return Then
    '        Command1.Focus()
    '    End If
    'End Sub
    Private Sub optAccName_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optAccName.CheckedChanged
        If eventSender.Checked Then
            cmdGetDetails.Visible = True
            Label3.Visible = True
        End If
    End Sub

    Private Sub optAccName_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optAccName.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            cmdGetDetails.Visible = True
            Label3.Visible = True
            txtSelection.Focus()
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub Optcommunication_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Optcommunication.CheckedChanged
        If eventSender.Checked Then
            '            Call fgrdSelectionList_RowColChange(fgrdSelectionList, New System.EventArgs)
        End If
    End Sub
    Private Sub OptCommunication_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Optcommunication.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            grdSelectionList.Focus()
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub OptCompany_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptCompany.CheckedChanged
        If eventSender.Checked Then
            cmdGetDetails.Visible = True
            Label3.Visible = True
        End If
    End Sub

    Private Sub OptMcode_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optMCode.CheckedChanged
        If eventSender.Checked Then
            cmdGetDetails.Visible = True
            Label3.Visible = True
        End If
    End Sub
    Private Sub optMCode_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles optMCode.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            cmdGetDetails.Visible = True
            Label3.Visible = True
            txtSelection.Focus()
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub OptOthers_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptOthers.CheckedChanged
        If eventSender.Checked Then
            cmdGetDetails.Visible = False
            Label3.Visible = False
        End If
    End Sub
    Private Sub OptPermanent_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptPermanent.CheckedChanged
        If eventSender.Checked Then
            'Call grdSelectionList_RowColChange(fgrdSelectionList, New System.EventArgs)
        End If
    End Sub
    Private Sub OptPermanent_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles OptPermanent.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            grdSelectionList.Focus()
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub PImage_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles PImage.DoubleClick
        If Dir("\Program Files\Internet Explorer\Iexplore.exe") <> "" And gPicture <> "" Then
            Call Shell("\Program Files\Internet Explorer\Iexplore.exe " & Application.StartupPath & "\Photos\" & gPicture, AppWinStyle.MaximizedFocus)
        End If
    End Sub
    Private Sub txtMembers_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtMembers.Click
        Dim gPrint, DoubleApostrophe, MainMenu As Object
        Dim ssql, VOutputfile, vOutputfile1, vCaption, vType, SSQL1 As String
        Dim vTtotal, vLtotal, I As Integer
        Dim vLen, vLen1 As Short
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        vOutputfile1 = Mid("TME" & CStr(Int(Rnd() * 5000)), 1, 8)
        SSQL1 = " SELECT * FROM SYSOBJECTS WHERE TYPE = 'U' AND NAME = '" & Trim(vOutputfile1) & "'"
        Vconn.getDataSet(SSQL1, "SYSOBJECTS")
        If gdataset.Tables("SYSOBJECTS").Rows.Count > 0 Then
            SSQL1 = "DROP TABLE  " & vOutputfile1 & ""
            gcommand = New SqlClient.SqlCommand(SSQL1, Vconn.Myconn)
            Vconn.openConnection()
            gcommand.ExecuteNonQuery()
            Vconn.closeConnection()
        End If
        'SSQL1 = "CREATE TABLE " & vOutputfile1 & " (MemberType varchar(30),Termination numeric(5) default 0,Live numeric(5) default 0)"
        'gcommand = New SqlClient.SqlCommand(SSQL1, Vconn.Myconn)
        'Vconn.openConnection()
        'gcommand.ExecuteNonQuery()
        'Vconn.closeConnection()
        'ssql = "SELECT * FROM MEMBERTYPE ORDER BY MEMBERTYPE"
        'Vconn.getDataSet(ssql, "membertype")
        'If gdataset.Tables("membertype").Rows.Count > 0 Then
        '    For I = 0 To gdataset.Tables("membertype").Rows.Count - 1
        '        vLen = Len(gdataset.Tables("membertype").Rows(I).Item("membertype"))
        '        If CStr(gdataset.Tables("membertype").Rows(I).Item("membertype")) = "LTT" Then
        '            vType = gdataset.Tables("membertype").Rows(I).Item("Membertype")
        '        End If
        '        If CStr(gdataset.Tables("membertype").Rows(I).Item("membertype")) <> "LTT" Then
        '            ssql = "SELECT COUNT(*) FROM MEMBERMASTER WHERE MEMBERTYPECODE='" & (Trim(CStr(gdataset.Tables("membertype").Rows(I).Item("Membertype")))) & "' and (Isnull(Termination,'') =' ' or Isnull(Termination,'') ='' or Isnull(Termination,'') ='N')   AND MCODE<>'' "
        '            Vconn.getDataSet(ssql, "MEMBERMASTER")
        '            If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
        '                ssql = "INSERT INTO " & vOutputfile1 & " (MemberType,Live) VALUES('" & (gdataset.Tables("membertype").Rows(I).Item("Membertype")) & "'," & gdataset.Tables("membertype").Rows(0).Item(0) & ")"
        '                gcommand = New SqlClient.SqlCommand(ssql, Vconn.Myconn)
        '                Vconn.openConnection()
        '                gcommand.ExecuteNonQuery()
        '                Vconn.closeConnection()
        '            End If
        '            ssql = "SELECT COUNT(*) FROM MEMBERMASTER WHERE MEMBERTYPECODE='" & (Trim(CStr(gdataset.Tables("membertype").Rows(I).Item("Membertype")))) & "' and (Isnull(Termination,'') <>'') AND MCODE<>'' "
        '            Vconn.getDataSet(ssql, "MEMBERMASTER")
        '            If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
        '                ssql = "UPDATE " & vOutputfile1 & " SET TERMINATION = " & gdataset.Tables("membertype").Rows(I).Item(0) & " WHERE MEMBERTYPE ='" & Trim(gdataset.Tables("membertype").Rows(I).Item("Membertype")) & "'"
        '                gcommand = New SqlClient.SqlCommand(ssql, Vconn.Myconn)
        '                Vconn.openConnection()
        '                gcommand.ExecuteNonQuery()
        '                Vconn.closeConnection()
        '            End If
        '        End If
        '    Next
        'End If
        'Randomize()
        'FileClose()
        'VOutputfile = Mid("TMEM" & CStr(Int(Rnd() * 5000)), 1, 8)
        'FileOpen(1, AppPath & "\Reports\" & VOutputfile & ".txt", OpenMode.Output)
        'vCaption = "Total Members as " & Format(Today, "dd/MM/yyyy")
        'PrintLine(1)
        'PrintLine(1)
        'PrintLine(1, Trim(gCompanyname & ""))
        'PrintLine(1, vCaption)
        'PrintLine(1, New String("-", 71))
        'PrintLine(1, "|Type of Member                |Not Normal|Live Members|Total Members|")
        'PrintLine(1, New String("-", 71))
        'ssql = "SELECT * FROM  " & vOutputfile1 & " ORDER BY MEMBERTYPE"
        'Vconn.getDataSet(ssql, "MEMBERTYPE")
        'If gdataset.Tables("MEMBERTYPE").Rows.Count > 0 Then
        '    For I = 0 To gdataset.Tables("MEMBERTYPE").Rows.Count - 1
        '        PrintLine(1, "|" & Trim(gdataset.Tables("MEMBERTYPE").Rows(I).Item("MemberType") & "") & Space(30 - Len(Trim(gdataset.Tables("MEMBERTYPE").Rows(I).Item("MemberType") & ""))) & "|" & Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination"), "0") & Space(11 - Len(Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination"), "0"))) & "|" & Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live"), "0") & Space(12 - Len(Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live"), "0"))) & "|" & Format(CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination")) + CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live")), "0") & Space(13 - Len(Format(CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination")) + CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live")), "0"))) & "|")
        '        vLtotal = vLtotal + Val(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live") & "")
        '        vTtotal = vTtotal + Val(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination") & "")
        '    Next
        'End If
        'PrintLine(1, New String("-", 71))
        'PrintLine(1, "|" & "TOTAL" & Space(30 - Len("TOTAL")) & "|" & Format(vTtotal, "0") & Space(11 - Len(Format(vTtotal, "0"))) & "|" & Format(vLtotal, "0") & Space(12 - Len(Format(vLtotal, "0"))) & "|" & Format(vTtotal + vLtotal, "0") & Space(13 - Len(Format(vLtotal + vTtotal, "0"))) & "|")
        'PrintLine(1, New String("-", 71))
        'FileClose(1)
        'gPrint = False
        'ssql = "DROP TABLE  " & vOutputfile1 & ""
        'gcommand = New SqlClient.SqlCommand(ssql, Vconn.Myconn)
        'Vconn.openConnection()
        'gcommand.ExecuteNonQuery()
        'Vconn.closeConnection()
        'System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        'OpenTextFile(VOutputfile)
        'Else
        SSQL1 = "CREATE TABLE " & vOutputfile1 & " (MemberType varchar(30),Termination numeric(5) default 0,Live numeric(5) default 0)"
        gcommand = New SqlClient.SqlCommand(SSQL1, Vconn.Myconn)
        Vconn.openConnection()
        gcommand.ExecuteNonQuery()
        Vconn.closeConnection()
        ssql = "SELECT * FROM MEMBERTYPE ORDER BY MEMBERTYPE"
        Vconn.getDataSet(ssql, "membertype")
        If gdataset.Tables("membertype").Rows.Count > 0 Then
            For I = 0 To gdataset.Tables("membertype").Rows.Count - 1
                vLen = Len(gdataset.Tables("membertype").Rows(I).Item("membertype"))
                'If CStr(gdataset.Tables("membertype").Rows(I).Item("membertype")) = "LTT" Then
                '    vType = gdataset.Tables("membertype").Rows(I).Item("Membertype")
                'End If
                'If CStr(gdataset.Tables("membertype").Rows(I).Item("membertype")) <> "LTT" Then
                ssql = "SELECT COUNT(*) FROM MEMBERMASTER WHERE MEMBERTYPECODE='" & (Trim(CStr(gdataset.Tables("membertype").Rows(I).Item("Membertype")))) & "' and Isnull(Curentstatus,'') ='LIVE' AND MCODE<>'' "
                Vconn.getDataSet(ssql, "MEMBERMASTER")
                If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
                    ssql = "INSERT INTO " & vOutputfile1 & " (MemberType,Live) VALUES('" & (gdataset.Tables("membertype").Rows(I).Item("Membertype")) & "'," & gdataset.Tables("MEMBERMASTER").Rows(0).Item(0) & ")"
                    gcommand = New SqlClient.SqlCommand(ssql, Vconn.Myconn)
                    Vconn.openConnection()
                    gcommand.ExecuteNonQuery()
                    Vconn.closeConnection()
                End If
                ssql = "SELECT COUNT(*) AS COUNT1 FROM MEMBERMASTER WHERE MEMBERTYPECODE='" & (Trim(CStr(gdataset.Tables("membertype").Rows(I).Item("Membertype")))) & "' and Isnull(Curentstatus,'') <>'LIVE' AND MCODE<>'' "
                Vconn.getDataSet(ssql, "MEMBERMASTER1")
                ssql = "UPDATE " & vOutputfile1 & " SET TERMINATION = " & gdataset.Tables("MEMBERMASTER1").Rows(0).Item("COUNT1") & " WHERE MEMBERTYPE ='" & gdataset.Tables("MEMBERTYPE").Rows(I).Item("Membertype") & "'"
                gcommand = New SqlClient.SqlCommand(ssql, Vconn.Myconn)
                Vconn.openConnection()
                gcommand.ExecuteNonQuery()
                Vconn.closeConnection()
                'End If
            Next
            'End If
            Randomize()
            FileClose()
            VOutputfile = Mid("TMEM" & CStr(Int(Rnd() * 5000)), 1, 8)
            FileOpen(1, AppPath & "\Reports\" & VOutputfile & ".txt", OpenMode.Output)
            vCaption = "Total Members as on : " & Format(Today, "dd/MM/yyyy")
            PrintLine(1)
            PrintLine(1)
            PrintLine(1, Chr(27) + "E" & Trim(gCompanyname & "") & Chr(27) + "F")
            PrintLine(1, vCaption)
            PrintLine(1, New String("-", 81))
            PrintLine(1, "|CODE      | TYPE DESC                    |Not Normal |Live Members|Total Members|")
            PrintLine(1, New String("-", 81))
            ssql = "SELECT ISNULL(V.MEMBERTYPE,'') AS MEMBERTYPE,LIVE,TERMINATION,ISNULL(T.TYPEDESC,'') AS TYPEDESC FROM  " & vOutputfile1 & "  V LEFT OUTER JOIN MEMBERTYPE T ON T.MEMBERTYPE = V.MEMBERTYPE ORDER BY V.MEMBERTYPE"
            Vconn.getDataSet(ssql, "MEMBERTYPE")
            If gdataset.Tables("MEMBERTYPE").Rows.Count > 0 Then
                For I = 0 To gdataset.Tables("MEMBERTYPE").Rows.Count - 1
                    PrintLine(1, "|" & Trim(gdataset.Tables("MEMBERTYPE").Rows(I).Item("MemberType") & "") & Space(10 - Len(Trim(gdataset.Tables("MEMBERTYPE").Rows(I).Item("MemberType") & ""))) & "|" & Trim(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Typedesc") & "") & Space(30 - Len(Trim(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Typedesc") & ""))) & "|" & Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination"), "0") & Space(11 - Len(Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination"), "0"))) & "|" & Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live"), "0") & Space(12 - Len(Format(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live"), "0"))) & "|" & Format(CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination")) + CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live")), "0") & Space(13 - Len(Format(CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination")) + CDbl(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live")), "0"))) & "|")
                    vLtotal = vLtotal + Val(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Live") & "")
                    vTtotal = vTtotal + Val(gdataset.Tables("MEMBERTYPE").Rows(I).Item("Termination") & "")
                Next
            End If
            PrintLine(1, New String("-", 81))
            PrintLine(1, "|" & "TOTAL           " & Space(30 - Len("TOTAL")) & "|" & Format(vTtotal, "0") & Space(11 - Len(Format(vTtotal, "0"))) & "|" & Format(vLtotal, "0") & Space(12 - Len(Format(vLtotal, "0"))) & "|" & Format(vTtotal + vLtotal, "0") & Space(13 - Len(Format(vLtotal + vTtotal, "0"))) & "|")
            PrintLine(1, New String("-", 81))
            FileClose(1)
            gPrint = False
            ssql = "DROP TABLE  " & vOutputfile1 & ""
            gcommand = New SqlClient.SqlCommand(ssql, Vconn.Myconn)
            Vconn.openConnection()
            gcommand.ExecuteNonQuery()
            Vconn.closeConnection()
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            Dim YesrNo As String
            YesrNo = MessageBox.Show("Do you want to View Or Print", "Total Members List", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            If YesrNo = vbYes Then
                OpenTextFile(VOutputfile)
            Else
                PrintTextFile(VOutputfile)
            End If
        End If
    End Sub

    Private Sub txtSelection_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSelection.TextChanged
        If Trim(txtSelection.Text) <> "" Then
            Call txtSelection_Leave(eventSender, eventArgs)
        End If
    End Sub
    Private Sub txtSelection_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSelection.Enter
        'Call ClearGrid(SSGrid)
        TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&H80FF)
        TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        TxtBalance.Text = ""
        txtReceipts.Text = ""
        txtSales.Text = ""
        fraDetails.Visible = False
        FraDependents.Visible = False
    End Sub
    Private Sub txtSelection_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtSelection.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        Dim SideLedgerList As Object
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            grdSelectionList.Focus()
        End If
        If KeyAscii = System.Windows.Forms.Keys.Escape Then
            'Unload(SideLedgerList)
            SideLedgerList = Nothing
        End If
        KeyAscii = Asc(UCase(Chr(KeyAscii)))
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub txtSelection_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSelection.Leave
        Try
            Dim vFormatstring As String
            If OptOthers.Checked Then

                Call MyFillGrid1()
            Else
                vFormatstring = "MEMBER NAME                                                    | MEMBER CODE "
                grdSelectionList.ClearRange(1, 1, -1, -1, True)
                Call MyFillGrid1()

            End If
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub
    Private Sub FillGrid1()
        Dim MainMenu As Object
        ' Dim gDebtors As Object
        Dim ADODB As Object
        Dim sstr As String
        Dim loopindex, i As Integer
        If IsDate(Mskfrom.Value) = False Then
            MsgBox("From date format is wrong", MsgBoxStyle.Critical, Me.Text)
            Mskfrom.Focus()
            Exit Sub
        End If
        If IsDate(Mskto.Value) = False Then
            MsgBox("To date format is wrong", MsgBoxStyle.Critical, Me.Text)
            Mskto.Focus()
            Exit Sub
        End If
        If DateDiff(Microsoft.VisualBasic.DateInterval.Day, CDate(Mskfrom.Value), CDate(Mskto.Value)) < 0 Then
            MsgBox("From date should be Less then To date !!", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If
        If lblmcode.Text = "" Then
            MsgBox("Member Code should visible", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If
        sSgrid.ClearRange(1, 1, -1, -1, True)
        TxtBalance.Text = ""
        txtReceipts.Text = ""
        TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        txtSales.Text = ""
        Call GetMemAcc()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        vTotal = 0

        'sstr = "update bill_hdr set packamount = (select sum(t.packamount) from kot_det t where  t.billdetails = bill_hdr.billdetails )"
        'gcommand = New SqlClient.SqlCommand(sstr, Vconn.Myconn)
        'Vconn.openConnection()
        'gcommand.ExecuteNonQuery()
        'Vconn.closeConnection()
        ' end of change 

        Call GetOpBal()
        '--NEW
        'sstr = "SELECT ISNULL(SNO,'')AS VOUCHERNO,ISNULL(CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME),'') AS VOUCHERDATE,ISNULL(HEADDESC,'')AS VOUCHERCATEGORY,ISNULL('DEBIT','')AS CREDITDEBIT,0 AS RECNO,ISNULL(DRAMOUNT,0)AS AMOUNT,0 AS INSTRUMENTNO FROM VIEW_POS_SUMMARY WHERE SLCODE ='" & Trim(vMemAcc) & "' AND  CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME) BETWEEN '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND '" & Format(Mskto.Value, "dd/MMM/yyyy") & "' "
        'sstr = sstr & " UNION ALL SELECT VOUCHERNO,VOUCHERDATE,VOUCHERCATEGORY,CREDITDEBIT,ISNULL(RECEIPTNO,0) AS RECNO,AMOUNT,ISNULL(INSTRUMENTNO,'') AS INSTRUMENTNO FROM  " & Trim(vUser & "") & "..JOURNALENTRY WHERE ACCOUNTCODE =  '" & Trim(gDebtors) & "' AND SLCODE= '" & Trim(vMemAcc) & "' AND  CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) >= '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND VOUCHERDATE <= '" & Format(Mskto.Value, "dd/MMM/yyyy") & "'"
        'sstr = sstr & "  AND ISNULL(VOID,'') <> 'Y' AND ISNULL(VOID,'') <> 'C'AND CREDITDEBIT='Credit'ORDER BY VOUCHERDATE"

        'OLD FORMATE
        sstr = " SELECT VOUCHERNO,VOUCHERDATE,VOUCHERCATEGORY,CREDITDEBIT,ISNULL(RECEIPTNO,0) AS RECNO,AMOUNT,ISNULL(INSTRUMENTNO,'') AS INSTRUMENTNO FROM  " & Trim(vUser & "") & "..JOURNALENTRY WHERE ACCOUNTCODE =  '" & Trim(gDebtors) & "' AND SLCODE= '" & Trim(vMemAcc) & "' AND  CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) >= '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND VOUCHERDATE <= '" & Format(Mskto.Value, "dd/MMM/yyyy") & "'"
        sstr = sstr & "  AND ISNULL(VOID,'') <> 'Y' AND ISNULL(VOID,'') <> 'C' AND DESCRIPTION NOT LIKE 'POSTING FROM POS%' AND VOUCHERCATEGORY NOT IN('SBIL') "
        'sstr = sstr & " UNION ALL SELECT a.billdetails,CAST(CONVERT(VARCHAR(11),a.kotdate,106) AS DATETIME) as BILLDATE,'POSBILL'as VOUCHERCATEGORY,'DEBIT' as CREDITDEBIT,0 as RECNO, sum(ISNULL(A.AMOUNT,0)+ISNULL(A.TAXAMOUNT,0)+ISNULL(A.PACKAMOUNT,0)+ISNULL(A.SER_CHG,0)) AS amount,'' FROM KOT_DET A,MEMBERMASTER B WHERE A.MCODE=B.MCODE  AND  A.PAYMENTMODE IN('CREDIT','PARTY')  AND ISNULL(A.KOTSTATUS,'')<>'Y' AND ISNULL(A.DELFLAG,'')<>'Y'  "
        'sstr = sstr & " and b.mcode ='" & Trim(vMemAcc) & "' and CAST(CONVERT(VARCHAR(11),a.kotdate,106) AS DATETIME)>='" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND CAST(CONVERT(VARCHAR(11),a.kotdate,106) AS DATETIME) <= '" & Format(Mskto.Value, "dd/MMM/yyyy") & "'  AND a.billdetails IN (SELECT BILLDETAILS FROM BILL_HDR WHERE A.BILLDETAILS=BILLDETAILS AND ISNULL(ACCOUNTFLAG,'')<>'Y') group by a.billdetails,a.kotdate"
        sstr = sstr & " UNION ALL SELECT a.billdetails,CAST(CONVERT(VARCHAR(11),a.kotdate,106) AS DATETIME) as BILLDATE,'POSBILL'as VOUCHERCATEGORY,'DEBIT' as CREDITDEBIT,0 as RECNO, SUM(ISNULL(A.AMOUNT,0)+ISNULL(A.TAXAMOUNT,0)+ISNULL(A.PACKAMOUNT,0)+ISNULL(A.SER_CHG,0))+ISNULL(C.AC_CHG,0) AS AMOUNT,'' FROM KOT_DET A,MEMBERMASTER B,BILL_HDR C WHERE A.MCODE=B.MCODE  AND A.BILLDETAILS=C.BILLDETAILS AND A.PAYMENTMODE IN('CREDIT')  AND ISNULL(A.KOTSTATUS,'')<>'Y' AND ISNULL(A.DELFLAG,'')<>'Y'  "
        sstr = sstr & " and b.mcode ='" & Trim(vMemAcc) & "' and CAST(CONVERT(VARCHAR(11),a.kotdate,106) AS DATETIME)>='" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND CAST(CONVERT(VARCHAR(11),a.kotdate,106) AS DATETIME) <= '" & Format(Mskto.Value, "dd/MMM/yyyy") & "'  AND a.billdetails IN (SELECT BILLDETAILS FROM BILL_HDR WHERE A.BILLDETAILS=BILLDETAILS) AND AMOUNT >= 0 group by a.billdetails, CAST(CONVERT(VARCHAR(11),a.kotdate,106) AS DATETIME),c.ac_chg"
        sstr = sstr & " UNION ALL SELECT a.billdetails,CAST(CONVERT(VARCHAR(11),a.kotdate,106) AS DATETIME) as BILLDATE,'POSBILL'as VOUCHERCATEGORY,'CREDIT' as CREDITDEBIT,0 as RECNO, sum(ISNULL(A.AMOUNT,0)+ISNULL(A.TAXAMOUNT,0)+ISNULL(A.PACKAMOUNT,0)+ISNULL(A.SER_CHG,0)) /-1 AS amount,'' FROM KOT_DET A,MEMBERMASTER B WHERE A.MCODE=B.MCODE  AND  A.PAYMENTMODE IN('CREDIT')  AND ISNULL(A.KOTSTATUS,'')<>'Y' AND ISNULL(A.DELFLAG,'')<>'Y'  "
        sstr = sstr & " and b.mcode ='" & Trim(vMemAcc) & "' and CAST(CONVERT(VARCHAR(11),a.kotdate,106) AS DATETIME)>='" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND CAST(CONVERT(VARCHAR(11),a.kotdate,106) AS DATETIME) <= '" & Format(Mskto.Value, "dd/MMM/yyyy") & "'  AND a.billdetails IN (SELECT BILLDETAILS FROM BILL_HDR WHERE A.BILLDETAILS=BILLDETAILS) AND AMOUNT < 0 group by a.billdetails, CAST(CONVERT(VARCHAR(11),a.kotdate,106) AS DATETIME)"
        'sstr = sstr & "UNION ALL SELECT BILLDETAILS,ISNULL(CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME),'') AS BILLDATE,'BILL','DEBIT',0,(ISNULL(TOTALAMOUNT,0)-(Isnull(Itemwise_discount_amt,0)+Isnull(discountamount,0))),'' FROM BILL_HDR WHERE MCODE ='" & Trim(vMemAcc) & "' AND PAYMENTMODE IN('CREDIT','PARTY')  AND ISNULL(DELFLAG,'') <> 'Y' AND  CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME) BETWEEN '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND '" & Format(Mskto.Value, "dd/MMM/yyyy") & "'AND ISNULL(ACCOUNTFLAG,'')<>'Y' "
        'sstr = sstr & "UNION ALL SELECT BILLDETAILS,ISNULL(CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME),'') AS BILLDATE,'BILL','DEBIT',0,(ISNULL(TOTALAMOUNT,0)-Isnull(discountamount,0)),'' FROM BILL_HDR WHERE MCODE ='" & Trim(vMemAcc) & "' AND PAYMENTMODE IN('CREDIT','PARTY')  AND ISNULL(DELFLAG,'') <> 'Y' AND  CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME) BETWEEN '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND '" & Format(Mskto.Value, "dd/MMM/yyyy") & "'AND ISNULL(ACCOUNTFLAG,'')<>'Y' "
        sstr = sstr & " UNION ALL SELECT 'SUBSCRIPTION'AS BILLNO,ISNULL(CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME),'') AS BILLDATE,SUBSCODE,'DEBIT',0,(ISNULL(AMOUNT,0)+ISNULL(TAXAMOUNT,0)),'' FROM SUBSPOSTING WHERE MCODE ='" & Trim(vMemAcc) & "' AND SUBSCODE<>'MUC' AND CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME) BETWEEN '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND '" & Format(Mskto.Value, "dd/MMM/yyyy") & "' "
        sstr = sstr & " UNION ALL SELECT 'SUBSCRIPTION'AS BILLNO,ISNULL(CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME),'') AS BILLDATE,SUBSCODE,'CREDIT',0,(ISNULL(AMOUNT,0)+ISNULL(TAXAMOUNT,0)),'' FROM SUBSPOSTING WHERE MCODE ='" & Trim(vMemAcc) & "' AND SUBSCODE='MUC' AND CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME) BETWEEN '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND '" & Format(Mskto.Value, "dd/MMM/yyyy") & "' "
        sstr = sstr & "  ORDER BY VOUCHERDATE,VOUCHERNO"

        sstr = " SELECT VOUCHERNO,CAST(CONVERT(VARCHAR(11),VOUCHERDATE,106)AS DATETIME)AS VOUCHERDATE,VOUCHERCATEGORY,CREDITDEBIT,0 AS RECNO,ISNULL(SUM(AMOUNT),0) AS AMOUNT,'' AS INSTRUMENTNO FROM  " & Trim(vUser & "") & "..VIEW_OUTSTANDING WHERE ACCOUNTCODE =  '" & Trim(gDebtors) & "' AND SLCODE= '" & Trim(vMemAcc) & "' AND  CAST(CONVERT(VARCHAR(11),VOUCHERDATE,106)AS DATETIME) >= '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND CAST(CONVERT(VARCHAR(11),VOUCHERDATE,106)AS DATETIME) <= '" & Format(Mskto.Value, "dd/MMM/yyyy") & "'"
        sstr = sstr & "  GROUP BY VOUCHERNO,CAST(CONVERT(VARCHAR(11),VOUCHERDATE,106) AS DATETIME),VOUCHERCATEGORY,CREDITDEBIT ORDER BY CAST(CONVERT(VARCHAR(11),VOUCHERDATE,106) AS DATETIME),VOUCHERNO"
        Vconn.getDataSet(sstr, "Journalentry")
        loopindex = 2
        If gdataset.Tables("Journalentry").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("Journalentry").Rows.Count - 1
                sSgrid.SetText(1, loopindex, gdataset.Tables("Journalentry").Rows(i).Item("Voucherno"))
                sSgrid.SetText(2, loopindex, Format(gdataset.Tables("Journalentry").Rows(i).Item("voucherdate"), "dd/MM/yyyy"))
                sSgrid.SetText(3, loopindex, gdataset.Tables("Journalentry").Rows(i).Item("vouchercategory"))
                If UCase(CStr(gdataset.Tables("Journalentry").Rows(i).Item("Creditdebit"))) = "CREDIT" Then
                    If CDbl(gdataset.Tables("Journalentry").Rows(i).Item("Recno")) > 0 Then
                        sSgrid.SetText(1, loopindex, gdataset.Tables("Journalentry").Rows(i).Item("recno"))
                    Else
                        sSgrid.SetText(1, loopindex, gdataset.Tables("Journalentry").Rows(i).Item("Voucherno"))
                    End If
                    sSgrid.Col = 4
                    sSgrid.Row = loopindex
                    sSgrid.Text = Format(gdataset.Tables("Journalentry").Rows(i).Item("Amount"), "0.00")
                    txtReceipts.Text = Format(Val(txtReceipts.Text) + Val(CStr(gdataset.Tables("Journalentry").Rows(i).Item("Amount"))), "0.00")
                    vTotal = vTotal - Val(gdataset.Tables("Journalentry").Rows(i).Item("Amount") & "")
                Else
                    sSgrid.Col = 5
                    sSgrid.Row = loopindex
                    sSgrid.Text = Format(gdataset.Tables("Journalentry").Rows(i).Item("Amount"), "0.00")

                    If Val(CStr(gdataset.Tables("Journalentry").Rows(i).Item("Amount"))) < 0 Then
                        'MessageBox.Show(txtSales.Text)

                        'MessageBox.Show(Val(CStr(gdataset.Tables("Journalentry").Rows(i).Item("Amount"))))
                        txtSales.Text = Format(Val(txtSales.Text) + Val(CStr(gdataset.Tables("Journalentry").Rows(i).Item("Amount"))), "0.00")
                        'MessageBox.Show(txtSales.Text)
                    Else
                        'MessageBox.Show(txtSales.Text)
                        txtSales.Text = Format(Val(txtSales.Text) + Val(CStr(gdataset.Tables("Journalentry").Rows(i).Item("Amount"))), "0.00")

                    End If


                    vTotal = vTotal + Val(gdataset.Tables("Journalentry").Rows(i).Item("Amount") & "")
                End If
                sSgrid.SetText(6, loopindex, Format(Val(vTotal), "0.00"))
                sSgrid.SetText(7, loopindex, gdataset.Tables("Journalentry").Rows(i).Item("INSTRUMENTNO"))
                loopindex = loopindex + 1
                If loopindex > 50 Then
                    sSgrid.MaxRows = sSgrid.MaxRows + 1
                End If
            Next
        Else
            MsgBox("There is no Transactions", MsgBoxStyle.Information, Me.Text)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Exit Sub
        End If
        Call GetTotal()
        Me.Cursor = System.Windows.Forms.Cursors.Default
        TxtBalance.Text = CStr(Val(txtSales.Text) - Val(txtReceipts.Text))
        TxtBalance.Text = Format(Val(vTotal), "0.00")
        'TxtBalance.Text = Format(Math.Round(Val(TxtBalance.Text), 0), "0.00")
        TxtBalance.Text = Format(Val(TxtBalance.Text), "0.00")
        If Val(TxtBalance.Text) < 0 Then
            TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&H80FF)
        End If
    End Sub
    Private Sub GetOpBal()
        Dim i As Integer
        Dim MainMenu As Object
        Dim ADODB As Object
        Dim ssql As String
        Dim vReceipts, vSales As Double
        Dim vopbal As Double
        ssql = "SELECT ISNULL(CREDITDEBIT,'') AS  CREDITDEBIT,SUM(AMOUNT) AS AMT FROM " & Trim(vUser & "") & "..VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "' AND CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) < '" & Format(Mskfrom.Value, "dd-MMM-yyyy") & "' AND ACCOUNTCODE='" & Trim(gDebtors) & "'  GROUP BY CREDITDEBIT"
        'ssql = " select 'oplbal'AS VOCHERNO,VOUCHERDATE,'OPL' AS VOUCHERCATEGORY,'SDRS'AS ACCOUNTCODE,SLCODE,DRAMOUNT,CRAMOUNT,'OPENING BAL'AS DESCRIPTION  FROM credit_limit1 WHERE SLCODE = '" & Trim(vMemAcc) & "' AND CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) < '" & Format(Mskfrom.Value, "dd-MMM-yyyy") & "' AND ACCOUNTCODE='" & Trim(gDebtors) & "'  GROUP BY CREDITDEBIT"
        'ssql = " select SUM(DRAMOUNT)AS DRAMOUNT,SUM(CRAMOUNT)AS CRAMOUNT  FROM credit_limit1 WHERE SLCODE = '" & Trim(vMemAcc) & "' AND CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) < '" & Format(Mskfrom.Value, "dd-MMM-yyyy") & "'   GROUP BY DRAMOUNT,CRAMOUNT"
        'ssql = " select SUM(DEBIT),SUM(CREDIT) FROM OPENINGBAL WHERE SLCODE = '" & Trim(vMemAcc) & "' AND CAST(CONVERT(CHAR(11),BILLDATE) AS DATETIME) < '" & Format(Mskfrom.Value, "dd-MMM-yyyy") & "'   GROUP BY DEBIT,CREDIT"

        Vconn.getDataSet(ssql, "Outstanding")

        If gdataset.Tables("Outstanding").Rows.Count > 0 Then
            vopbal = 0
            For i = 0 To gdataset.Tables("Outstanding").Rows.Count - 1
                If UCase(CStr(gdataset.Tables("Outstanding").Rows(i).Item("Creditdebit"))) = "CREDIT" Then
                    vReceipts = Val(gdataset.Tables("Outstanding").Rows(i).Item("Amt") & "")
                ElseIf UCase(CStr(gdataset.Tables("Outstanding").Rows(i).Item("Creditdebit"))) = "DEBIT" Then
                    vSales = Val(gdataset.Tables("Outstanding").Rows(i).Item("Amt") & "")
                End If
            Next
        End If
        vopbal = vSales - vReceipts
        If sSgrid.DataRowCnt = 0 Then
            If vopbal >= 0 Then
                sSgrid.SetText(3, 1, "Opening Balance  -->")
                sSgrid.SetText(5, 1, Format(vopbal, "0.00"))
                sSgrid.SetText(6, 1, Format(vopbal, "0.00"))
                'vTotal = vTotal + vopbal
                vTotal = vTotal + vopbal
                creditdebit = "DEBIT"
                total = vTotal

            ElseIf vopbal <= 0 Then
                vopbal = -(vopbal)
                sSgrid.SetText(3, 1, "Opening Balance  -->")
                sSgrid.SetText(4, 1, Format(vopbal, "0.00"))
                sSgrid.SetText(6, 1, Format(vopbal, "0.00"))
                'vTotal = vTotal - vopbal
                vTotal = vTotal - vopbal
                creditdebit = "CREDIT"
                total = vTotal

            End If
        End If
        Call GetTotal()
    End Sub
    Private Sub GetTotal()
        txtReceipts.Text = ""
        txtSales.Text = ""
        Dim vReceipts, vSales As Double
        Dim loopindex As Integer
        For loopindex = 1 To sSgrid.DataRowCnt
            sSgrid.Col = 4
            sSgrid.Row = loopindex
            vReceipts = Val(sSgrid.Text)
            sSgrid.Col = 5
            sSgrid.Row = loopindex
            vSales = Val(sSgrid.Text)
            If Val(vReceipts) > 0 Then
                'txtReceipts.Text = Format(Math.Round(Val(txtReceipts.Text) + Val(vReceipts), 0), "0.00")
                txtReceipts.Text = Format(Val(txtReceipts.Text) + Val(vReceipts), "0.00")
                'txtReceipts.Text = Format(Math.Round(Val(txtReceipts.Text), 0), "0.00")

            End If
            If Val(vSales) > 0 Then
                txtSales.Text = Format(Val(txtSales.Text) + Val(vSales), "0.00")
                'txtSales.Text = Format(Math.Round(Val(txtSales.Text), 0), "0.00")
            End If
        Next loopindex
        'txtReceipts.Text = Format(Math.Round(Val(txtReceipts.Text), 0), "0.00")
        txtReceipts.Text = Format(Val(txtReceipts.Text), "0.00")
        'txtSales.Text = Format(Math.Round(Val(txtSales.Text), 0), "0.00")
        txtSales.Text = Format(Val(txtSales.Text), "0.00")
        TxtBalance.Text = ""
        If Val(txtReceipts.Text) > 0 Or Val(txtSales.Text) > 0 Then
            TxtBalance.Text = Format(Val(txtSales.Text) - Val(txtReceipts.Text), "0.00")
            ' TxtBalance.Text = Format(Math.Round(Val(TxtBalance.Text), 0), "0.00")
            TxtBalance.Text = Format(Val(TxtBalance.Text), "0.00")
        End If
        If Val(TxtBalance.Text) < 0 Then
            TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&H80FF)
        End If
    End Sub
    Private Sub PrintOperation()
        PRINTREP = False
        Dim str()() As String
        Dim row, rowno, j, pageno As Integer
        Dim cnt As Integer
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim write As File
        Dim corplist As DataTable
        Dim add1, add2 As String
        Dim STRARRAY(20) As String
        Dim corpname As String = ""
        'Dim PrintTextFile As Object
        Dim gPrint As Object
        Dim gUserName As Object
        Dim gDemo As Object
        'Dim gCompanyname As Object
        Randomize()
        Dim ssql As String
        Dim VOutputfile As String
        Dim vSales, vDescription, vBillNo, vbilldate, vReceipts, vBalance, tSales, tReceipts, tBalance As Object
        Dim vPageNumber As Integer
        Dim VRowCount As Integer
        Dim loopindex As Integer
        Dim vCaption As String
        Dim vMCode As String
        Dim vMembername As String
        Dim my_i As Integer
        VOutputfile = Mid("MSTA" & CStr(Int(Rnd() * 5000)), 1, 8)
        If sSgrid.DataRowCnt = 0 Then
            MsgBox("Empty Details cannot be Print", MsgBoxStyle.Information, "Member Statement")
            Exit Sub
        End If
        Try
            Randomize()
            vMCode = Trim(lblmcode.Text & "")
            vMembername = Trim(lblname.Text & "")
            vOutfile = Mid("corst" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            vPageNumber = 1
            vCaption = "SALES & RECEIPTS FROM " & Format(Mskfrom.Value, "dd/MM/yyyy") & " To " & Format(Mskto.Value, "dd/MM/yyyy")
            Filewrite.WriteLine(Space(55) & "PAGE NO : " & vPageNumber)
            Filewrite.WriteLine(Space(55) & "DATE :" & Format(Today, "dd/MM/yyyy"))
            Filewrite.WriteLine(Chr(14) & Chr(15) & Trim(gCompanyname) & Chr(18))
            Filewrite.WriteLine(Chr(14) & Chr(15) & Trim(vMCode) & " - " & Trim(vMembername) & Chr(18)) 'IIf(lblCompany.Text <> "", "   Company : " & Trim(lblCompany.Text), "") & Chr(18))
            Filewrite.WriteLine(vCaption)
            Filewrite.WriteLine(StrDup(93, "-"))
            Filewrite.WriteLine("BILL/RECPT         DATE         DESCRIPTION            RECEIPTS          SALES        BALANCE")
            Filewrite.WriteLine(StrDup(93, "-"))
            VRowCount = 8
            loopindex = 0
            For my_i = 0 To sSgrid.DataRowCnt - 1
                vBillNo = ""
                vbilldate = ""
                vReceipts = ""
                vSales = ""
                vBalance = ""
                With sSgrid
                    .Col = 1
                    .Row = my_i + 1
                    vBillNo = .Text
                    .Col = 2
                    .Row = my_i + 1
                    vbilldate = .Text
                    .Col = 3
                    .Row = my_i + 1
                    vDescription = .Text
                    .Col = 4
                    .Row = my_i + 1
                    vReceipts = Val(.Text)
                    tReceipts = tReceipts + vReceipts
                    .Col = 5
                    .Row = my_i + 1
                    vSales = Val(.Text)
                    tSales = tSales + vSales
                    .Col = 6
                    .Row = my_i + 1
                    vBalance = Val(.Text)
                End With
                Filewrite.WriteLine(Mid(Trim(vBillNo), 1, 16) & Space(17 - Len(Mid(Trim(vBillNo), 1, 16))) & vbilldate & Space(11 - Len(vbilldate)) & Mid(Trim(vDescription), 1, 23) & Space(24 - Len(Mid(Trim(vDescription), 1, 23))) & Space(10 - Len(Format(vReceipts, "0.00"))) & Format(vReceipts, "0.00") & Space(10) & Space(10 - Len(Format(vSales, "0.00"))) & Format(vSales, "0.00") & Space(10 - Len(Format(vBalance, "0.00"))) & Format(vBalance, "0.00"))
                VRowCount = VRowCount + 1
                If VRowCount > 60 Then
                    vPageNumber = vPageNumber + 1
                    Filewrite.WriteLine(Chr(12))
                    VRowCount = 0
                    Filewrite.WriteLine(Space(55) & "PAGE NO : " & vPageNumber)
                    Filewrite.WriteLine(Space(55) & "DATE :" & Format(Today, "dd/MM/yyyy"))
                    Filewrite.WriteLine(Chr(14) & Chr(15) & Trim(gCompanyname) & Chr(18))
                    Filewrite.WriteLine(Chr(14) & Chr(15) & Trim(vMCode) & " - " & Trim(vMembername) & IIf(lblCompany.Text <> "", "   Company : " & Trim(lblCompany.Text), "") & Chr(18))
                    Filewrite.WriteLine(vCaption)
                    Filewrite.WriteLine(StrDup(93, "-"))
                    Filewrite.WriteLine("BILL/RECPT       DATE             DESCRIPTION        RECEIPTS          SALES        BALANCE")
                    Filewrite.WriteLine(StrDup(93, "-"))
                End If
            Next my_i
            Filewrite.WriteLine(StrDup(93, "-"))
            'Filewrite.WriteLine(Space(43) & Space(12 - Len(Format(txtReceipts.Text, "0.00"))) & Format(txtReceipts.Text, "0.00") & Space(10) & Space(10 - Len(Format(txtSales.Text, "0.00"))) & Format(txtSales.Text, "0.00") & Space(10 - Len(Format(TxtBalance.Text, "0.00"))) & Format(TxtBalance.Text, "0.00"))
            tBalance = tSales - tReceipts
            Filewrite.WriteLine(Space(50) & Space(12 - Len(Format(tReceipts, "0.00"))) & Format(tReceipts, "0.00") & Space(10) & Space(10 - Len(Format(tSales, "0.00"))) & Format(tSales, "0.00") & Space(10 - Len(Format(tBalance, "0.00"))) & Format(tBalance, "0.00"))
            Filewrite.WriteLine(StrDup(93, "-"))
            Filewrite.WriteLine(gUserName & Space(5) & Format(Now, "dd/MM/yyyy hh:mm:ss Am/Pm") & Chr(12))
            Filewrite.Close()
            'PRINTREP = False
            'If PRINTREP = False Then
            '    OpenTextFile(vOutfile)
            'Else
            '    PRINTEXTFILE(vOutfile)
            'End If
            Dim YesrNo As String
            YesrNo = MessageBox.Show("Do you want to View Or Print", "Total Members List", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            If YesrNo = vbYes Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Sub
        End Try
        'Dim PrintTextFile As Object
        'Dim OpenTextFile As Object
        '        Dim gPrint As Object
        '        Dim gUserName As Object
        '        Dim gDemo As Object
        '        Dim gCompanyname As Object
        '        Randomize()
        '        Dim ssql As String
        '        Dim VOutputfile As String
        '        Dim vSales, vDescription, vBillNo, vbilldate, vReceipts, vBalance As Object
        '        Dim vPageNumber As Integer
        '        Dim VRowCount As Integer
        '        Dim loopindex As Double
        '        Dim vCaption As String
        '        Dim vMCode As String
        '        Dim vMembername As String
        '        VOutputfile = Mid("MSTA" & CStr(Int(Rnd() * 5000)), 1, 8)
        '        If sSgrid.DataRowCnt = 0 Then
        '            MsgBox("Empty Details cannot be Print", MsgBoxStyle.Information, "Member Statement")
        '            Exit Sub
        '        End If
        '        vMCode = Trim(lblmcode.Text & "")
        '        vMembername = Trim(lblname.Text & "")
        '        FileClose()
        '        FileOpen(1, Application.StartupPath & "\Reports\" & VOutputfile & ".txt", OpenMode.Output)
        '        vPageNumber = 1
        '        vCaption = "SALES & RECEIPTS FROM " & Format(Mskfrom.Value, "dd/MM/yyyy") & " To " & Format(Mskto.Value, "dd/MM/yyyy")
        '        PrintLine(1, Space(55) & "PAGE NO : " & vPageNumber)
        '        PrintLine(1, Space(55) & "DATE :" & Format(Today, "dd/MM/yyyy"))
        '        PrintLine(1, Chr(14) & Chr(15) & Trim(gCompanyname) & Chr(18))
        '        PrintLine(1, Chr(14) & Chr(15) & Trim(vMCode) & " - " & Trim(vMembername) & IIf(lblCompany.Text <> "", "   Company : " & Trim(lblCompany.Text), "") & Chr(18))
        '        PrintLine(1, vCaption)
        '        PrintLine(1, New String("-", 75))
        '        PrintLine(1, "BILL/RECPT       DATE         DESCRIPTION        RECEIPTS          SALES        BALANCE")
        '        PrintLine(1, New String("-", 75))
        '        VRowCount = 8
        '        If gDemo = True Then
        '            PrintLine(1, "Demo copy")
        '            VRowCount = VRowCount + 1
        '        End If
        '        For loopindex = 1 To sSgrid.DataRowCnt
        '            sSgrid.GetText(1, loopindex, vBillNo)
        '            sSgrid.GetText(2, loopindex, vbilldate)
        '            sSgrid.GetText(3, loopindex, vDescription)
        '            sSgrid.GetText(4, loopindex, vReceipts)
        '            sSgrid.GetText(5, loopindex, vSales)
        '            sSgrid.GetText(6, loopindex, vBalance)
        '            PrintLine(1, Mid(Trim(vBillNo), 1, 8) & Space(10 - Len(Mid(Trim(vBillNo), 1, 8))) & Format(vbilldate, "dd/MM/yyyy") & Space(11 - Len(Format(vbilldate, "dd/MM/yyyy"))) & Mid(Trim(vDescription), 1, 23) & Space(24 - Len(Mid(Trim(vDescription), 1, 23))) & Space(10 - Len(Format(vReceipts, "0.00"))) & Format(vReceipts, "0.00") & Space(10 - Len(Format(vSales, "0.00"))) & Format(vSales, "0.00") & Space(10 - Len(Format(vBalance, "0.00"))) & Format(vBalance, "0.00"))
        '            VRowCount = VRowCount + 1
        '            If VRowCount > 60 Then
        '                vPageNumber = vPageNumber + 1
        '                PrintLine(1, Chr(12))
        '                VRowCount = 0
        '                GoTo Header
        '            End If
        '        Next loopindex
        'PrintLine(1, New String("-", 75))
        'PrintLine(1, Space(43) & Space(12 - Len(Format(txtReceipts.Text, "0.00"))) & Format(txtReceipts.Text, "0.00") & Space(10 - Len(Format(txtSales.Text, "0.00"))) & Format(txtSales.Text, "0.00") & Space(10 - Len(Format(TxtBalance.Text, "0.00"))) & Format(TxtBalance.Text, "0.00"))
        'PrintLine(1, New String("-", 75))
        '        PrintLine(1, gUserName & Space(5) & Format(Now, "dd/MM/yyyy hh:mm:ss Am/Pm") & Chr(12))
        '        FileClose(1)
        '        gPrint = True
        '        Dim YesrNo As String
        '        YesrNo = MessageBox.Show("Do you want to View Or Print", "Total Members List", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
        '        If YesrNo = vbYes Then
        '            OpenTextFile(VOutputfile)
        '        Else
        '            PrintTextFile(VOutputfile)
        '        End If
        '        Exit Sub
        'Header:
        '        PrintLine(1, Space(55) & "PAGE NO : " & vPageNumber)
        '        PrintLine(1, Space(55) & "DATE  : " & Format(Today, "dd/MM/yyyy"))
        '        PrintLine(1, Chr(14) & Chr(15) & Trim(gCompanyname) & Chr(18))
        '        PrintLine(1, Chr(14) & Chr(15) & Trim(vMCode) & " - " & Trim(vMembername) & Chr(18))
        '        PrintLine(1, vCaption)
        '        PrintLine(1, New String("-", 75))
        '        PrintLine(1, "BILL/RECPT       DATE         DESCRIPTION        RECEIPTS          SALES        BALANCE")
        '        PrintLine(1, New String("-", 75))
        '        VRowCount = 8
        '        If gDemo = True Then
        '            PrintLine(1, "Demo Copy")
        '            VRowCount = VRowCount + 1
        '        End If
        '        Return
    End Sub
    Private Sub vaDependents_KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles vaDependents.KeyDownEvent
        Dim vphoto As Object
        If eventArgs.keyCode = System.Windows.Forms.Keys.Down Then
            vaDependents.GetText(7, vaDependents.ActiveRow + 1, vphoto)
            If Trim(vphoto & "") <> "" Then
                If Dir(Application.StartupPath & "\Photos\" & vphoto) <> "" Then
                    PImage.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\Photos\" & vphoto)
                Else
                    PImage.Image = System.Drawing.Image.FromFile("")
                    vaDependents.SetText(7, vaDependents.ActiveRow + 1, "NO")
                End If
            End If
        End If
        If eventArgs.keyCode = System.Windows.Forms.Keys.Up Then
            vaDependents.GetText(7, vaDependents.ActiveRow - 1, vphoto)
            If Trim(vphoto & "") <> "" Then
                If Dir(Application.StartupPath & "\Photos\" & vphoto) <> "" Then
                    PImage.Image = System.Drawing.Image.FromFile(Application.StartupPath & "\Photos\" & vphoto)
                Else
                    PImage.Image = System.Drawing.Image.FromFile("")
                    vaDependents.SetText(7, vaDependents.ActiveRow - 1, "NO")
                End If
            End If
        End If
    End Sub
    Private Sub MyFillGrid()
        Dim gCompanyname As Object
        Dim adLockOptimistic As Object
        Dim adOpenDynamic As Object
        Dim MainMenu As Object
        Dim gDebtors As Object
        Dim ADODB As Object
        If OptOthers.Checked Then
            vSql = "SELECT ISNULL(PNAME,'') AS PNAME FROM ADDRESSSEARCH WHERE PNAME LIKE '" & (Trim(txtSelection.Text)) & "%' ORDER BY PNAME"
        Else
            If optMCode.Checked = True Then
                vSql = "SELECT ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(SUBCODE,'') AS SUBCODE FROM " & Trim(vUser & "") & "..SUBLEDGERLIST1 "
                vSql = vSql & " WHERE   SUBCODE LIKE '" & (Trim(txtSelection.Text)) & "%' "
                vSql = vSql & " AND ACCODE='" & Trim(gDebtors) & "' ORDER BY SUBCODE "
            ElseIf optAccName.Checked Then
                vSql = "SELECT ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(SUBCODE,'') AS SUBCODE FROM " & Trim(vUser & "") & "..SUBLEDGERLIST1 "
                vSql = vSql & " WHERE   SUBNAME LIKE '" & (Trim(txtSelection.Text)) & "%' "
                vSql = vSql & " AND ACCODE='" & Trim(gDebtors) & "' ORDER BY SUBCODE "
            ElseIf OptCompany.Checked Then
                vSql = "SELECT ISNULL(COMPANY,'') AS COMPANY,ISNULL(MCODE,'') AS MCODE FROM " & Trim(vUser & "") & "..MEMBERMASTER WHERE UPPER(COMPANY) LIKE '" & (Trim(txtSelection.Text)) & "%' ORDER BY COMPANY,MCODE"
            End If
        End If
        Vconn.getDataSet(vSql, "SubledgerList1")
        Dim loopindex As Integer
        If gdataset.Tables("SubledgerList1").Rows.Count > 0 Then
            If grdSelectionList.DataRowCnt < gdataset.Tables("SubledgerList1").Rows.Count - 1 Then
                grdSelectionList.MaxRows = gdataset.Tables("SubledgerList1").Rows.Count + 3
            End If
            For loopindex = 0 To gdataset.Tables("SubledgerList1").Rows.Count - 1
                grdSelectionList.Col = 1
                grdSelectionList.Row = loopindex + 1
                grdSelectionList.Text = CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("Subcode"))
                grdSelectionList.Col = 2
                grdSelectionList.Row = loopindex + 1
                grdSelectionList.Text = CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("SubName"))
            Next
        Else
            lblAmount.Text = ""
            MsgBox("Details not found.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "" & gCompanyname)
            FormUnload = True
        End If
    End Sub
    Private Sub Mskfrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Mskfrom.KeyDown
        If e.KeyCode = Keys.Enter Then
            Mskto.Focus()
        End If
    End Sub

    Private Sub Mskto_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Mskto.KeyDown
        If e.KeyCode = Keys.Enter Then
            Command1.Focus()
        End If
    End Sub
    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub optMCode_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles optMCode.Layout

    End Sub
    Private Sub Shape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub grdSelectionList_ClickEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_ClickEvent) Handles grdSelectionList.ClickEvent
        If grdSelectionList.DataRowCnt > 0 Then
            With grdSelectionList
                .Col = 1
                .Row = .ActiveRow
                MemberCode = Trim(.Text)
                .Col = 2
                .Row = .ActiveRow
                SideLedgerName = Trim(.Text)
            End With
        End If
        'If fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 0) <> "" Then
        '    SideLedgerName = fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 0)
        '    MemberCode = fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 1)
        'End If
    End Sub
    Private Sub grdSelectionList_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdSelectionList.Enter
        'Call grdSelectionList_RowColChange(grdSelectionList, New System.EventArgs)
        sSgrid.ClearRange(1, 1, -1, -1, True)
        TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        TxtBalance.Text = ""
        txtReceipts.Text = ""
        txtSales.Text = ""
        fraDetails.Visible = False
        FraDependents.Visible = False
    End Sub
    Private Sub grdSelectionList_LeaveCell(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_LeaveCellEvent) Handles grdSelectionList.LeaveCell
        Dim adLockPessimistic, adOpenDynamic, DoubleApostrophe, MainMenu, ADODB As Object
        Dim ij As Integer
        Dim vPartyNameAddress(), vMemberCode, Vdesc, ssql As String
        Dim vBal, vCredits, vDebits As Double
        ij = grdSelectionList.ActiveRow
        With grdSelectionList
            .Col = 1
            .Row = .ActiveRow
            MemberCode = Trim(.Text)
            .Col = 2
            .Row = ij
            SideLedgerName = Trim(.Text)
        End With
        grdSelectionList.Col = 1
        grdSelectionList.Row = ij
        ssql = " SELECT ISNULL(TERMINATION,'') AS TERMINATE FROM MEMBERMASTER WHERE MCODE = '" & Trim(grdSelectionList.Text) & "'"
        Vconn.getDataSet(ssql, "MEMBERMASTER")
        If gdataset.Tables("MEMBERMASTER").Rows.Count > 0 Then
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "U" Then
                lbltermination.Text = "DEFAULTER"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "L" Then
                lbltermination.Text = "LEFT"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "D" Then
                lbltermination.Text = "DEAD"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "F" Then
                lbltermination.Text = "FREEZED"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "Y" Then
                lbltermination.Text = "TERMINATED"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "P" Then
                lbltermination.Text = "POSTED"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "B" Then
                lbltermination.Text = "BLOCKED"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "K" Then
                lbltermination.Text = "BLACK LISTED"
            End If
            If UCase(Trim(CStr(gdataset.Tables("MEMBERMASTER").Rows(0).Item("Terminate")))) = "" Then
                lbltermination.Text = "NORMAL"
            End If
        End If
        gPicture = ""
        If OptOthers.Checked Then
            If OptPermanent.Checked = True Then
                grdSelectionList.Col = 2
                grdSelectionList.Row = ij
                ssql = "SELECT ISNULL(PNAME,'') AS PNAME,ISNULL(PADD1,'') AS PADD1,ISNULL(PADD2,'') AS PADD2,ISNULL(PADD3,'') AS PADD3,ISNULL(PCITY,'') AS PCITY,"
                ssql = ssql & "ISNULL(PSTATE,'') AS PSTATE,ISNULL(PPINCODE,'') AS PPINCODE,ISNULL(PPHONE1,'') AS PPHONE1,ISNULL(PPHONE2,'') AS PPHONE2,ISNULL(PFAXNO,'') AS PFAXNO,ISNULL(PEMAIL,'') AS PEMAIL,ISNULL(PMOBILE,'') AS PMOBILE FROM ADDRESSSEARCH WHERE PNAME='" & Trim(grdSelectionList.Text) & "'"
                Vconn.getDataSet(ssql, "AddressSearch")
                If gdataset.Tables("AddressSearch").Rows.Count > 0 Then
                    lblname.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("Pname") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("Pname")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("Pname")), " ")
                    lbladd1.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("padd1") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("padd1")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("padd1")), " ")
                    lbladd2.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("padd2") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("padd2")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("padd2")), " ")
                    lbladd3.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("padd3") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("padd3")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("padd3")), " ")
                    lblcity.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pcity") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pcity")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pcity")), " ")
                    lblstate.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pstate") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pstate")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pstate")), " ")
                    lblpin.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("ppincode") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("ppincode")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("ppincode")), " ")
                    lblphone1.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pphone1") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pphone1")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pphone1")), " ")
                    lblphone2.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pphone2") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pphone2")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pphone2")), " ")
                    lblcellno.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pMobile") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pMobile")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pMobile")), " ") & " Fax:" & IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pMobile") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pFaxno")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pFaxno")), " ")
                    lblEmail.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("pemail") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("pemail")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("pemail")), " ")
                End If
            End If
            If Optcommunication.Checked = True Then
                grdSelectionList.Col = 2
                grdSelectionList.Row = ij
                ssql = "SELECT ISNULL(PNAME,'') AS PNAME,ISNULL(CADD1,'') AS CADD1,ISNULL(CADD2,'') AS CADD2,ISNULL(CADD3,'') AS CADD3,ISNULL(CCITY,'') AS CCITY,"
                ssql = ssql & "ISNULL(CSTATE,'') AS CSTATE,ISNULL(CPINCODE,'') AS CPINCODE,ISNULL(cPHONE1,'') AS CPHONE1,ISNULL(CPHONE2,'') AS CPHONE2,ISNULL(CFAXNO,'') AS CFAXNO,ISNULL(PEMAIL,'') AS CEMAIL,ISNULL(CMOBILE,'') AS CMOBILE FROM ADDRESSSEARCH WHERE PNAME='" & Trim(grdSelectionList.Text) & "'"
                Vconn.getDataSet(ssql, "AddressSearch")
                If gdataset.Tables("AddressSearch").Rows.Count > 0 Then
                    lblname.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("Pname") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("Pname")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("Pname")), " ")
                    lbladd1.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cadd1") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cadd1")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cadd1")), " ")
                    lbladd2.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cadd2") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cadd2")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cadd2")), " ")
                    lbladd3.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cadd3") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cadd3")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cadd3")), " ")
                    lblcity.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("ccity") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("ccity")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("ccity")), " ")
                    lblstate.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cstate") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cstate")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cstate")), " ")
                    lblpin.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cpincode") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cpincode")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cpincode")), " ")
                    lblphone1.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cphone1") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cphone1")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cphone1")), " ")
                    lblphone2.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cphone2") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cphone2")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cphone2")), " ")
                    lblcellno.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cMobile") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cMobile")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cMobile")), " ") & " Fax:" & IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cMobile") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cFaxno")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cFaxno")), " ")
                    lblEmail.Text = IIf(gdataset.Tables("AddressSearch").Rows(0).Item("cemail") <> "" Or Not IsDBNull(gdataset.Tables("AddressSearch").Rows(0).Item("cemail")), Trim(gdataset.Tables("AddressSearch").Rows(0).Item("cemail")), " ")
                End If
            End If

        End If
        'If grdSelectionList.DataRowCnt > 0 And OptOthers.Checked = False Then
        If OptOthers.Checked = False Then
            'If grdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 1) <> "" And OptOthers.Checked = False Then
            vSql = "SELECT ISNULL(SUBCODE,'') AS SUBCODE,ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(ACCODE,'') AS ACCODE,ISNULL(ACDESC,'') AS ACDESC,ISNULL(TERMINATE,'') AS TERMINATE,ISNULL(CLOSINGBAL,0) AS CLOSINGBAL"
            grdSelectionList.Col = 1
            grdSelectionList.Row = ij
            vSql = vSql & " FROM " & Trim(vUser) & "..SUBLEDGERLIST1 WHERE SUBCODE ='" & Trim(grdSelectionList.Text) & "'"

            'vSql = vSql & " UNION ALL SELECT KOTDETAILS,CAST(CONVERT(CHAR(39),KOTDATE,106) AS DATETIME) AS KOTDATE,'KOT','DEBIT',0,BILLAMOUNT,0 FROM KOT_HDR WHERE PAYMENTtype IN('CREDIT','PARTY') AND MCODE= '" & Trim(vMemAcc) & "' AND  CAST(CONVERT(CHAR(39),KOTDATE,106) AS DATETIME) BETWEEN '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND '" & Format(Mskto.Value, "dd/MMM/yyyy") & "' AND ISNULL(POSTINGSTATUS,'')<>'Y'"
            'vSql = vSql & " AND ISNULL(DELFLAG,'') <> 'Y'  ORDER BY VOUCHERDATE,VOUCHERNO"
            'SARAN

            Vconn.getDataSet(vSql, "SUBLEDGERLIST1")
            If gdataset.Tables("SUBLEDGERLIST1").Rows.Count > 0 Then
                lblmcode.Text = IIf(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("Subcode")) <> "" Or Not IsDBNull(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode")), Trim(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode"))), " ")
                lblname.Text = IIf(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubName")) <> "" Or Not IsDBNull(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubName")), Trim(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubName"))), " ")
                FraDependents.Visible = False
                fraDetails.Visible = False
                'vSql = "SELECT PHOTOIMAGE AS PHOTOIMAGE  FROM " & Trim(vUser) & "..PHOTOADDING WHERE MCODE = '" & Trim(lblmcode.Text) & "'"

                vSql = "SELECT memimage as memimage FROM membermaster WHERE mcode='" & Trim(lblmcode.Text) & "' "
                LoadFoto_DB(vSql, Img_Photo)
           
                'If gdataset.Tables("PHOTOADDING").Rows.Count > 0 Then
                '    Vdesc = Trim(gdataset.Tables("PHOTOADDING").Rows(0).Item(0) & "")
                'End If
                If Trim(Vdesc) <> "" Then
                    gPicture = Trim(Vdesc & "")
                End If
                vMemberCode = gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode")
                vMemberCode = IIf(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode")) <> "" Or Not IsDBNull(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode")), Trim(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode"))), " ")
                vBal = Val(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("ClosingBal") & "")

                If vBal > 0 Then
                    lblAmount.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF0000)
                    ' lblAmount.Text = Format(vBal, "0.00")
                    lblAmount.Text = " DR : " & Format(vBal, "0.00")
                Else
                    lblAmount.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF0000)
                    'lblAmount.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
                    lblAmount.Text = "CR : " & Format(vBal * -1, "0.00")
                End If
            End If
            If OptPermanent.Checked = True Then
                grdSelectionList.Col = 1
                grdSelectionList.Row = ij

                ssql = "SELECT ISNULL(M.MCODE,'') AS MCODE,ISNULL(M.COMPANY,'') AS COMPANY,ISNULL(M.TERMINATION,'') AS TERMINATION,ISNULL(M.CON_MCODE,'') AS CON_MCODE,ISNULL(M.MNAME,'') AS MNAME,"
                ssql = ssql & "ISNULL(M.PADD1,'') AS PADD1,ISNULL(M.PHOTO,'') AS PHOTO,ISNULL(M.PADD2,'') AS PADD2,ISNULL(M.PADD3,'') AS PADD3,ISNULL(M.PCITY,'') AS PCITY,ISNULL(M.PSTATE,'') AS PSTATE,ISNULL(M.PPIN,'') AS PPIN,ISNULL(M.PPHONE1,'') AS PPHONE1,ISNULL(M.PPHONE2,'') AS PPHONE2,ISNULL(M.PCELL,'') AS PCELL,"
                ssql = ssql & "ISNULL(M.PEMAIL,'') AS PEMAIL,ISNULL(T.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(T.TYPEDESC,'') AS TYPEDESC FROM " & Trim(vUser) & "..MEMBERMASTER AS M LEFT OUTER JOIN  " & Trim(vUser & "") & "..MEMBERTYPE AS T ON M.MEMBERTYPECODE = T.MEMBERTYPE WHERE   MCODE ='" & Trim(grdSelectionList.Text) & "'"
                Vconn.getDataSet(ssql, "MemberMaster")
                If gdataset.Tables("MemberMaster").Rows.Count > 0 Then
                    lblType.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Membertype") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Membertype")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("Membertype")), " ")
                    lblType.Text = lblType.Text & "-->" & Trim(gdataset.Tables("MemberMaster").Rows(0).Item("typedesc"))
                    lblmcode.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Mcode") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Mcode")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("Mcode")), " ")
                    lblCompany.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Company") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Company")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("company")), " ")
                    lblname.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Mname") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Mname")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("Mname")), " ")
                    lbladd1.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("padd1") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("padd1")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("padd1")), " ")
                    lbladd2.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("padd2") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("padd2")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("padd2")), " ")
                    lbladd3.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("padd3") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("padd3")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("padd3")), " ")
                    lblcity.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("pcity") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("pcity")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("pcity")), " ")
                    lblstate.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("pstate") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("pstate")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("pstate")), " ")
                    lblpin.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("ppin") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("ppin")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("ppin")), " ")
                    lblphone1.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("pphone1") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("pphone1")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("pphone1")), " ")
                    lblphone2.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("pphone2") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("pphone2")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("pphone2")), " ")
                    lblcellno.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("pcell") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("pcell")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("pcell")), " ")
                    lblEmail.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("pemail") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("pemail")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("pemail")), " ")
                End If
                Dim sqlstr As String
                sqlstr = "SELECT memimage as memimage FROM membermaster WHERE mcode='" & Trim(txtSelection.Text) & "' "
                LoadFoto_DB(sqlstr, Img_Photo)
            End If
            If Optcommunication.Checked = True Then
                grdSelectionList.Col = 1
                grdSelectionList.Row = ij

                ssql = "SELECT ISNULL(M.MCODE,'') AS MCODE,ISNULL(M.TERMINATION,'') as TERMINATION,ISNULL(MCODE,'') as CON_MCODE,ISNULL(M.MNAME,'') AS MNAME,ISNULL(M.COMPANY,'') AS COMPANY,ISNULL(M.CONTADD1,'') AS CADD1,ISNULL(M.PHOTO,'') AS PHOTO,ISNULL(M.CONTADD2,'') as CADD2,ISNULL(M.CONTADD3,'') As CADD3,ISNULL(M.CONTCITY,'') AS CCITY,"
                ssql = ssql & "ISNULL(M.CONTSTATE,'') AS CSTATE,ISNULL(M.CONTPIN,'') AS CPIN,ISNULL(M.CONTPHONE1,'') AS CPHONE1,ISNULL(M.CONTPHONE2,'') As CPHONE2,ISNULL(M.CONTCELL,'') AS CCELL,ISNULL(M.CONTEMAIL,'') as CEMAIL,ISNULL(T.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(T.TYPEDESC,'') AS TYPEDESC FROM " & Trim(vUser & "") & "..MEMBERMASTER AS M LEFT OUTER JOIN " & Trim(vUser & "") & "..MEMBERTYPE AS T ON M.MEMBERTYPECODE = T.MEMBERTYPE WHERE   MCODE ='" & Trim(grdSelectionList.Text) & "' "
                Vconn.getDataSet(ssql, "MemberMaster")
                If gdataset.Tables("MemberMaster").Rows.Count > 0 Then
                    If gdataset.Tables("MemberMaster").Rows(0).Item("Termination") = "C" Then
                        lbltermination.Text = "CONVERTED - " & Trim(gdataset.Tables("MemberMaster").Rows(0).Item("CON_MCODE") & "")
                    End If
                    lblType.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Membertype") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Membertype")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("Membertype")), " ")
                    lblType.Text = lblType.Text & "-->" & Trim(gdataset.Tables("MemberMaster").Rows(0).Item("typedesc"))
                    lblmcode.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Mcode") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Mcode")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("Mcode")), " ")
                    lblCompany.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Company") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Company")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("company")), " ")
                    lblname.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("Mname") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("Mname")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("Mname")), " ")
                    lbladd1.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cadd1") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cadd1")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cadd1")), " ")
                    lbladd2.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cadd2") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cadd2")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cadd2")), " ")
                    lbladd3.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cadd3") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cadd3")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cadd3")), " ")
                    lblcity.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("ccity") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("ccity")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("ccity")), " ")
                    lblstate.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cstate") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cstate")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cstate")), " ")
                    lblpin.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cpin") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cpin")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cpin")), " ")
                    lblphone1.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cphone1") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cphone1")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cphone1")), " ")
                    lblphone2.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cphone2") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cphone2")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cphone2")), " ")
                    lblcellno.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("ccell") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("ccell")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("ccell")), " ")
                    lblEmail.Text = IIf(gdataset.Tables("MemberMaster").Rows(0).Item("cEmail") <> "" Or Not IsDBNull(gdataset.Tables("MemberMaster").Rows(0).Item("cemail")), Trim(gdataset.Tables("MemberMaster").Rows(0).Item("cemail")), " ")
                End If
                Dim sqlstr As String
                sqlstr = "SELECT memimage as memimage FROM membermaster WHERE mcode='" & Trim(txtSelection.Text) & "' "
                LoadFoto_DB(sqlstr, Img_Photo)
            End If
        End If
    End Sub
    Private Sub grdSelectionList_KeyPressEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_KeyPressEvent) Handles grdSelectionList.KeyPressEvent
        If grdSelectionList.DataRowCnt > 0 Then
            With grdSelectionList
                .Col = 1
                .Row = .ActiveRow
                MemberCode = Trim(.Text)
                .Col = 2
                .Row = .ActiveRow
                SideLedgerName = Trim(.Text)
            End With
        End If
    End Sub
    Private Sub grdSelectionList_Advance(ByVal sender As System.Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_AdvanceEvent) Handles grdSelectionList.Advance

    End Sub

    Private Sub vaDependents_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles vaDependents.Advance

    End Sub

    Private Sub vaDependents_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles vaDependents.LeaveCell

    End Sub
    Private Sub grdSelectionList_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdSelectionList.LostFocus

    End Sub
    Private Sub grdSelectionList_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdSelectionList.Leave
    End Sub
    Private Sub AxfpSpread1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles vaDependents.Advance

    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        FraDependents.Visible = False
    End Sub

    Private Sub sSgrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles sSgrid.Advance

    End Sub
    Private Sub sSgrid_ClickEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_ClickEvent) Handles sSgrid.ClickEvent
        Dim MMHELP1 As New MMHELP
        sSgrid.Col = 1
        sSgrid.Row = sSgrid.ActiveRow
        MMHELP1.BILLDETAILS(sSgrid.Text)
        MMHELP1.Show()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        fraDetails.Top = 30
        fraDetails.Width = 960
        'fraDetails.Top = 400
        'fraDetails.Width = 960

    End Sub

    Private Sub ChkLast_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLast.CheckedChanged

    End Sub

    Private Sub Memberhelp1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F7 Then
            Dim frmSrc As New frmSearch
            frmSrc.farPoint = sSgrid
            frmSrc.ShowDialog(Me)
            Exit Sub
            'ElseIf e.KeyCode = Keys.F6 Then
            '    Call cmd_clear_Click(sender, e)
            '    Exit Sub
        End If
    End Sub

    Private Sub lblAmount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAmount.Click

    End Sub

    Private Sub txtSelection_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSelection.Validated
        Dim sqlstr As String
        sqlstr = "SELECT memimage as memimage FROM membermaster WHERE mcode='" & Trim(txtSelection.Text) & "' "
        LoadFoto_DB(sqlstr, Img_Photo)
    End Sub

    Private Sub BtnEXIT1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Public Sub LoadFoto_DB(ByVal quystr As String, ByVal PIC As PictureBox)
        Try
            Dim cn As New SqlConnection(strcn)
            Dim sssql As String
            'sssql = "SELECT * FROM SM_CARDFILE_HDR WHERE [16_DIGIT_CODE] ='" & Trim(CARDID.Text) & "' AND [16_DIGIT_CODE] NOT IN ( SELECT [16_DIGIT_CODE] FROM SM_CARDFILE_HDR WHERE [16_digit_code] = '" & Trim(CARDID.Text) & "' AND MEMIMAGE IS NULL)"
            Dim cmd As New SqlCommand(quystr, cn)
            Dim da As New SqlDataAdapter(cmd)
            Dim ds As New DataSet
            da.Fill(ds, "sm_image")
            Dim c As Integer = ds.Tables("SM_IMAGE").Rows.Count
            If c > 0 Then
                Dim bytMEMimage() As Byte = ds.Tables("SM_IMAGE").Rows(c - 1)("memimage")
                Dim stmMEMimage As New MemoryStream(bytMEMimage)
                PIC.Image = Image.FromStream(stmMEMimage)
            Else
                PIC.Image = Nothing
            End If
        Catch ex As Exception
            '            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        lblType.Text = ""
        lblname.Text = ""
        lblmcode.Text = ""
        lbladd1.Text = ""
        lbladd2.Text = ""
        lbladd3.Text = ""
        lblcity.Text = ""
        lblstate.Text = ""
        lblpin.Text = ""
        lblphone1.Text = ""
        lblphone2.Text = ""
        lblcellno.Text = ""
        lblEmail.Text = ""
        lblAmount.Text = ""
        lblCompany.Text = ""
        gPicture = ""
        txtSelection.Text = ""
        Img_Photo.Image = Nothing
        OptPermanent.Checked = False
        Grp_Print.Visible = False
        Optcommunication.Checked = True
        Mskfrom.Value = gFinancialyearStart
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        lbltermination.Text = ""
        Me.Text = "Member Details"
        vUser = gDatabase
        txtSelection.Focus()
    End Sub

    Private Sub CMD_DOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_DOS.Click
        Call PrintOperation()
    End Sub
    Private Sub CMD_WINDOWS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMD_WINDOWS.Click

        Dim i As Integer
        Dim ssql, Sqlstr, fromdate, todate As String
        Dim vReceipts, vSales As Double
        Dim vopbal, total1 As Double
        fromdate = Format(Mskfrom.Value, "dd/MMM/yyyy")
        todate = Format(Mskto.Value, "dd/MMM/yyyy")
        '  ssql = "SELECT ISNULL(CREDITDEBIT,'') AS  CREDITDEBIT,SUM(AMOUNT) AS AMT FROM " & Trim(vUser & "") & "..VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "' AND CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) < '" & Format(Mskfrom.Value, "dd-MMM-yyyy") & "' AND ACCOUNTCODE='" & Trim(gDebtors) & "'  GROUP BY CREDITDEBIT"

        Try
            Dim sqlstring As String
            Dim Viewer As New ReportViwer
            Dim r As New Cry_Memberledger
            Dim txtobj1 As TextObject
            If total < 0 Then
                total1 = total / -1
            Else
                total1 = total
            End If
            'ssql = "SELECT ISNULL(CREDITDEBIT,'') AS  CREDITDEBIT,SUM(AMOUNT) AS AMOUNT FROM " & Trim(vUser & "") & "..VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "' AND CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) < '" & Format(Mskfrom.Value, "dd-MMM-yyyy") & "' AND ACCOUNTCODE='" & Trim(gDebtors) & "'  GROUP BY CREDITDEBIT"
            If creditdebit = "CREDIT" Then
                ssql = "SELECT DISTINCT 'CREDIT' AS  CREDITDEBIT," & total1 & " AS AMOUNT FROM VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "'"
            Else
                ssql = "SELECT DISTINCT 'DEBIT' AS  CREDITDEBIT," & total1 & " AS AMOUNT FROM VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "'"

            End If

            'sqlstring = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,M.MEMBERTYPECODE,M.CURENTSTATUS,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell, '" & Format(Mskto.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND M.MCODE ='" & Trim(vMemAcc) & "'  AND O.BILLDATE < '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND  CURENTSTATUS = 'LIVE' AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,M.MEMBERTYPECODE,M.CURENTSTATUS "
            Sqlstr = "select * from MM_VIEW_HGALEDGER where Slcode=   '" & Trim(vMemAcc) & "'AND  CAST(CONVERT(CHAR(11),VOUCHERDATE,6) AS DATETIME) BETWEEN '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND '" & Format(Mskto.Value, "dd/MMM/yyyy") & "' "
            Sqlstr = Sqlstr & "order by VOUCHERDATE,VOUCHERNO"
            Call Viewer.GetDetails1(ssql, "VIEW_OUTSTANDING", r)
            Call Viewer.GetDetails1(Sqlstr, "MM_VIEW_HGALEDGER", r)
            'Call Viewer.GetDetails1(sqlstring, "membermaster", r)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            'txtobj1.Text = vopbal
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = fromdate
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = todate
            txtobj1 = r.ReportDefinition.ReportObjects("Text12")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text38")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text37")
            'txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            'txtobj1.Text = UCase(gUsername)
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub


    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        'Me.Close()
        Grp_Print.Visible = False
    End Sub

    Private Sub lblEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEmail.Click

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i, month1, noofdays, mindates As Integer
        Dim ssql, Sqlstr, fromdate, todate As String
        Dim vReceipts, vSales As Double
        Dim vopbal, total2 As Double
        fromdate = Format(Mskfrom.Value, "dd/MMM/yyyy")
        todate = Format(Mskto.Value, "dd/MMM/yyyy")
        '  ssql = "SELECT ISNULL(CREDITDEBIT,'') AS  CREDITDEBIT,SUM(AMOUNT) AS AMT FROM " & Trim(vUser & "") & "..VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "' AND CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) < '" & Format(Mskfrom.Value, "dd-MMM-yyyy") & "' AND ACCOUNTCODE='" & Trim(gDebtors) & "'  GROUP BY CREDITDEBIT"
        mindates = DateDiff(DateInterval.Month, Mskfrom.Value, Mskto.Value)
        'MessageBox.Show(mindates)
        Try
            Dim sqlstring As String
            Dim Viewer As New ReportViwer
            Dim r As New Cry_Memberledger1
            Dim txtobj1 As TextObject
            If total < 0 Then
                total2 = total / -1
            Else
                total2 = total

            End If
            'If Mid(Me.Mskfrom.Text, 4, 2) = "" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4)
            'If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4)
            'ssql = "SELECT ISNULL(CREDITDEBIT,'') AS  CREDITDEBIT,SUM(AMOUNT) AS AMOUNT FROM " & Trim(vUser & "") & "..VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "' AND CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) < '" & Format(Mskfrom.Value, "dd-MMM-yyyy") & "' AND ACCOUNTCODE='" & Trim(gDebtors) & "'  GROUP BY CREDITDEBIT"
            If creditdebit = "CREDIT" Then
                ssql = "SELECT DISTINCT 'CREDIT' AS  CREDITDEBIT," & total2 & " AS AMOUNT FROM VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "'"
            Else
                ssql = "SELECT DISTINCT 'DEBIT' AS  CREDITDEBIT," & total2 & " AS AMOUNT FROM VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "'"

            End If
            vSql = "EXEC MONTH_SUMMARY  " & "'" & Format(Mskfrom.Value, "dd-MMM-yyyy") & "','" & Format(Mskto.Value, "dd-MMM-yyyy") & "','" & Trim(vMemAcc) & "'"
            Vconn.GetValues(vSql)

            'Sqlstr = "EXEC MONTH_SUMMARY Mskfrom.Value"
            'sqlstring = " SELECT ISNULL(M.MCODE,'') AS MCODE,(ISNULL(M.PREFIX,'')+ '' +ISNULL(M.MNAME,'')) AS MNAME,ISNULL(M.CONTADD1,'') AS CONTADD1,ISNULL(M.CONTADD2,'') AS CONTADD2,ISNULL(M.CONTADD3,'') AS CONTADD3,ISNULL(M.CONTCITY,'') AS CONTCITY,M.MEMBERTYPECODE,M.CURENTSTATUS,ISNULL(M.CONTPIN,'') AS CONTPIN,ISNULL(M.contcell,'') AS contcell, '" & Format(Mskto.Value, "dd/MMM/yyyy") & "' AS ADDDATE, (SUM(O.DEBIT)-SUM(O.CREDIT)) AS CREDITLIMIT FROM OPENINGBAL O,MEMBERMASTER M WHERE M.MCODE = O.SLCODE AND M.MCODE ='" & Trim(vMemAcc) & "'  AND O.BILLDATE < '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND  CURENTSTATUS = 'LIVE' AND ISNULL(FREEZE,'')<>'Y' GROUP BY M.MCODE, M.MNAME,M.PREFIX,M.CONTADD1,M.CONTADD2,M.CONTADD3,M.CONTCITY,M.CONTPIN,m.contcell,M.MEMBERTYPECODE,M.CURENTSTATUS "
            Sqlstr = "select ISNULL(VOUCHERNO,'')AS VOUCHERNO,ISNULL(VOUCHERDATE,'')AS VOUCHERDATE,ISNULL(SLCODE,'')AS SLCODE,ISNULL(CREDIT,0)AS CRAMOUNT,ISNULL(DEBIT,0) AS DRAMOUNT from MONTHSUMMARY_MBC where Slcode=   '" & Trim(vMemAcc) & "' "
            Sqlstr = Sqlstr & "order by VOUCHERDATE"
            Call Viewer.GetDetails1(ssql, "VIEW_OUTSTANDING", r)
            Call Viewer.GetDetails1(Sqlstr, "MM_VIEW_HGALEDGER", r)
            'Call Viewer.GetDetails1(sqlstring, "membermaster", r)
            'txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            'txtobj1.Text = vopbal
            txtobj1 = r.ReportDefinition.ReportObjects("Text3")
            txtobj1.Text = fromdate
            txtobj1 = r.ReportDefinition.ReportObjects("Text4")
            txtobj1.Text = todate
            txtobj1 = r.ReportDefinition.ReportObjects("Text12")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gCompanyAddress(1))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text38")
            'txtobj1.Text = UCase(gCompanyAddress(2))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text37")
            'txtobj1.Text = UCase(gCompanyAddress(3))
            'txtobj1 = r.ReportDefinition.ReportObjects("Text16")
            'txtobj1.Text = UCase(gUsername)
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Exit Sub
        End Try

    End Sub
End Class