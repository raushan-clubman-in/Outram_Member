Option Strict Off
Option Explicit On 
Imports Microsoft.VisualBasic
Imports VB = Microsoft.VisualBasic
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine

Imports System.IO
Friend Class Memberhelp_Member
    Inherits System.Windows.Forms.Form
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
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents ChkLast As System.Windows.Forms.CheckBox
    Public WithEvents lbladd3 As System.Windows.Forms.Label
    Public WithEvents lblAmount As System.Windows.Forms.Label
    Public WithEvents PImage As System.Windows.Forms.PictureBox
    Public WithEvents Label3 As System.Windows.Forms.Label
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
    Public WithEvents lblCompany As System.Windows.Forms.Label
    Public WithEvents lbltermination As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Shape1 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    Friend WithEvents Mskfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Mskto As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents grdSelectionList As AxFPUSpreadADO.AxfpSpread
    Public WithEvents FraDependents As System.Windows.Forms.GroupBox
    Public WithEvents vaDependents As AxFPSpreadADO.AxfpSpread
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Public WithEvents txt_mcode As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Dtp_dob As System.Windows.Forms.DateTimePicker
    Public WithEvents Button1 As System.Windows.Forms.Button
    Public WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Cmd_McodeHelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Memberhelp_Member))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmdGetDetails = New System.Windows.Forms.Button
        Me.fraDetails = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.sSgrid = New AxFPSpreadADO.AxfpSpread
        Me.FraDependents = New System.Windows.Forms.GroupBox
        Me.vaDependents = New AxFPSpreadADO.AxfpSpread
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel
        Me.cmdDependents = New System.Windows.Forms.Button
        Me.txtMembers = New System.Windows.Forms.Button
        Me.cmdprint = New System.Windows.Forms.Button
        Me.Command1 = New System.Windows.Forms.Button
        Me.txtSales = New System.Windows.Forms.TextBox
        Me.txtReceipts = New System.Windows.Forms.TextBox
        Me.TxtBalance = New System.Windows.Forms.TextBox
        Me.lbltotal = New System.Windows.Forms.Label
        Me.Mskto = New System.Windows.Forms.DateTimePicker
        Me.Mskfrom = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtSelection = New System.Windows.Forms.TextBox
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.optMCode = New System.Windows.Forms.RadioButton
        Me.optAccName = New System.Windows.Forms.RadioButton
        Me.OptCompany = New System.Windows.Forms.RadioButton
        Me.OptOthers = New System.Windows.Forms.RadioButton
        Me.Frame2 = New System.Windows.Forms.GroupBox
        Me.OptPermanent = New System.Windows.Forms.RadioButton
        Me.Optcommunication = New System.Windows.Forms.RadioButton
        Me.ChkLast = New System.Windows.Forms.CheckBox
        Me.lbladd3 = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.PImage = New System.Windows.Forms.PictureBox
        Me.Label3 = New System.Windows.Forms.Label
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
        Me.lblCompany = New System.Windows.Forms.Label
        Me.lbltermination = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Shape1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Cmd_McodeHelp = New System.Windows.Forms.Button
        Me.Dtp_dob = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_mcode = New System.Windows.Forms.TextBox
        Me.grdSelectionList = New AxFPUSpreadADO.AxfpSpread
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.fraDetails.SuspendLayout()
        CType(Me.sSgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraDependents.SuspendLayout()
        CType(Me.vaDependents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdSelectionList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Image)
        Me.Label5.Location = New System.Drawing.Point(40, 336)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(72, 18)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Exit (Esc)"
        Me.ToolTip1.SetToolTip(Me.Label5, "Click here")
        '
        'cmdGetDetails
        '
        Me.cmdGetDetails.BackColor = System.Drawing.Color.Transparent
        Me.cmdGetDetails.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdGetDetails.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGetDetails.ForeColor = System.Drawing.Color.White
        Me.cmdGetDetails.Image = CType(resources.GetObject("cmdGetDetails.Image"), System.Drawing.Image)
        Me.cmdGetDetails.Location = New System.Drawing.Point(24, 184)
        Me.cmdGetDetails.Name = "cmdGetDetails"
        Me.cmdGetDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdGetDetails.Size = New System.Drawing.Size(152, 24)
        Me.cmdGetDetails.TabIndex = 40
        Me.cmdGetDetails.Text = "<<MORE DETAILS>>"
        Me.cmdGetDetails.Visible = False
        '
        'fraDetails
        '
        Me.fraDetails.BackColor = System.Drawing.Color.Transparent
        Me.fraDetails.Controls.Add(Me.Button2)
        Me.fraDetails.Controls.Add(Me.Button1)
        Me.fraDetails.Controls.Add(Me.sSgrid)
        Me.fraDetails.Controls.Add(Me.FraDependents)
        Me.fraDetails.Controls.Add(Me.cmdDependents)
        Me.fraDetails.Controls.Add(Me.txtMembers)
        Me.fraDetails.Controls.Add(Me.cmdprint)
        Me.fraDetails.Controls.Add(Me.Command1)
        Me.fraDetails.Controls.Add(Me.txtSales)
        Me.fraDetails.Controls.Add(Me.txtReceipts)
        Me.fraDetails.Controls.Add(Me.TxtBalance)
        Me.fraDetails.Controls.Add(Me.Label5)
        Me.fraDetails.Controls.Add(Me.lbltotal)
        Me.fraDetails.Controls.Add(Me.Mskto)
        Me.fraDetails.Controls.Add(Me.Mskfrom)
        Me.fraDetails.Controls.Add(Me.Label8)
        Me.fraDetails.Controls.Add(Me.Label6)
        Me.fraDetails.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraDetails.ForeColor = System.Drawing.Color.Black
        Me.fraDetails.Location = New System.Drawing.Point(120, 312)
        Me.fraDetails.Name = "fraDetails"
        Me.fraDetails.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraDetails.Size = New System.Drawing.Size(856, 368)
        Me.fraDetails.TabIndex = 10
        Me.fraDetails.TabStop = False
        Me.fraDetails.Visible = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(640, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button2.Size = New System.Drawing.Size(104, 25)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Summary[F7]"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(744, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(104, 25)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Clear[F1]"
        '
        'sSgrid
        '
        Me.sSgrid.ContainingControl = Me
        Me.sSgrid.DataSource = Nothing
        Me.sSgrid.Location = New System.Drawing.Point(8, 48)
        Me.sSgrid.Name = "sSgrid"
        Me.sSgrid.OcxState = CType(resources.GetObject("sSgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.sSgrid.Size = New System.Drawing.Size(848, 272)
        Me.sSgrid.TabIndex = 45
        '
        'FraDependents
        '
        Me.FraDependents.BackColor = System.Drawing.Color.FromArgb(CType(138, Byte), CType(163, Byte), CType(168, Byte))
        Me.FraDependents.BackgroundImage = CType(resources.GetObject("FraDependents.BackgroundImage"), System.Drawing.Image)
        Me.FraDependents.Controls.Add(Me.vaDependents)
        Me.FraDependents.Controls.Add(Me.LinkLabel1)
        Me.FraDependents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FraDependents.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(0, Byte), CType(64, Byte))
        Me.FraDependents.Location = New System.Drawing.Point(128, 72)
        Me.FraDependents.Name = "FraDependents"
        Me.FraDependents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FraDependents.Size = New System.Drawing.Size(808, 144)
        Me.FraDependents.TabIndex = 51
        Me.FraDependents.TabStop = False
        Me.FraDependents.Text = "DEPENDENT NAME "
        '
        'vaDependents
        '
        Me.vaDependents.ContainingControl = Me
        Me.vaDependents.DataSource = Nothing
        Me.vaDependents.Location = New System.Drawing.Point(24, 16)
        Me.vaDependents.Name = "vaDependents"
        Me.vaDependents.OcxState = CType(resources.GetObject("vaDependents.OcxState"), System.Windows.Forms.AxHost.State)
        Me.vaDependents.Size = New System.Drawing.Size(920, 168)
        Me.vaDependents.TabIndex = 47
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
        'cmdDependents
        '
        Me.cmdDependents.BackColor = System.Drawing.Color.Transparent
        Me.cmdDependents.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDependents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdDependents.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDependents.ForeColor = System.Drawing.Color.White
        Me.cmdDependents.Image = CType(resources.GetObject("cmdDependents.Image"), System.Drawing.Image)
        Me.cmdDependents.Location = New System.Drawing.Point(830, 48)
        Me.cmdDependents.Name = "cmdDependents"
        Me.cmdDependents.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDependents.Size = New System.Drawing.Size(120, 25)
        Me.cmdDependents.TabIndex = 44
        Me.cmdDependents.Text = "DEPENDENTS"
        Me.cmdDependents.Visible = False
        '
        'txtMembers
        '
        Me.txtMembers.BackColor = System.Drawing.Color.Transparent
        Me.txtMembers.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtMembers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtMembers.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMembers.ForeColor = System.Drawing.Color.White
        Me.txtMembers.Image = CType(resources.GetObject("txtMembers.Image"), System.Drawing.Image)
        Me.txtMembers.Location = New System.Drawing.Point(752, 16)
        Me.txtMembers.Name = "txtMembers"
        Me.txtMembers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMembers.Size = New System.Drawing.Size(64, 26)
        Me.txtMembers.TabIndex = 43
        Me.txtMembers.Text = "TOTAL MEMBERS"
        Me.txtMembers.Visible = False
        '
        'cmdprint
        '
        Me.cmdprint.BackColor = System.Drawing.Color.Transparent
        Me.cmdprint.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdprint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdprint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdprint.ForeColor = System.Drawing.Color.White
        Me.cmdprint.Image = CType(resources.GetObject("cmdprint.Image"), System.Drawing.Image)
        Me.cmdprint.Location = New System.Drawing.Point(536, 16)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdprint.Size = New System.Drawing.Size(104, 25)
        Me.cmdprint.TabIndex = 42
        Me.cmdprint.Text = "View[F6]"
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.Color.Transparent
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Command1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.Color.White
        Me.Command1.Image = CType(resources.GetObject("Command1.Image"), System.Drawing.Image)
        Me.Command1.Location = New System.Drawing.Point(424, 16)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(112, 25)
        Me.Command1.TabIndex = 41
        Me.Command1.Text = "Get Details[F5]"
        '
        'txtSales
        '
        Me.txtSales.AcceptsReturn = True
        Me.txtSales.AutoSize = False
        Me.txtSales.BackColor = System.Drawing.Color.White
        Me.txtSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSales.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSales.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSales.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSales.Location = New System.Drawing.Point(624, 328)
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
        Me.txtReceipts.BackColor = System.Drawing.Color.White
        Me.txtReceipts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReceipts.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReceipts.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceipts.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtReceipts.Location = New System.Drawing.Point(504, 328)
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
        Me.TxtBalance.BackColor = System.Drawing.Color.White
        Me.TxtBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBalance.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtBalance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBalance.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtBalance.Location = New System.Drawing.Point(736, 328)
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
        Me.lbltotal.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(384, 336)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltotal.Size = New System.Drawing.Size(91, 18)
        Me.lbltotal.TabIndex = 19
        Me.lbltotal.Text = "Total Amount"
        '
        'Mskto
        '
        Me.Mskto.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mskto.CustomFormat = "dd/MM/yyyy"
        Me.Mskto.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mskto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Mskto.Location = New System.Drawing.Point(312, 16)
        Me.Mskto.Name = "Mskto"
        Me.Mskto.Size = New System.Drawing.Size(104, 22)
        Me.Mskto.TabIndex = 49
        '
        'Mskfrom
        '
        Me.Mskfrom.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mskfrom.CustomFormat = "dd/MM/yyyy"
        Me.Mskfrom.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mskfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Mskfrom.Location = New System.Drawing.Point(104, 16)
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
        Me.Label8.Location = New System.Drawing.Point(16, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(71, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "From Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label6.Location = New System.Drawing.Point(240, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(54, 18)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "To Date"
        '
        'txtSelection
        '
        Me.txtSelection.AcceptsReturn = True
        Me.txtSelection.AutoSize = False
        Me.txtSelection.BackColor = System.Drawing.Color.White
        Me.txtSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSelection.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSelection.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSelection.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSelection.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSelection.Location = New System.Drawing.Point(32, 152)
        Me.txtSelection.MaxLength = 25
        Me.txtSelection.Name = "txtSelection"
        Me.txtSelection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSelection.Size = New System.Drawing.Size(96, 24)
        Me.txtSelection.TabIndex = 9
        Me.txtSelection.Text = ""
        Me.txtSelection.Visible = False
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
        Me.Frame1.Location = New System.Drawing.Point(24, 104)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(48, 35)
        Me.Frame1.TabIndex = 4
        Me.Frame1.TabStop = False
        Me.Frame1.Visible = False
        '
        'optMCode
        '
        Me.optMCode.BackColor = System.Drawing.Color.Transparent
        Me.optMCode.Checked = True
        Me.optMCode.Cursor = System.Windows.Forms.Cursors.Default
        Me.optMCode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optMCode.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optMCode.Location = New System.Drawing.Point(4, 11)
        Me.optMCode.Name = "optMCode"
        Me.optMCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optMCode.Size = New System.Drawing.Size(88, 15)
        Me.optMCode.TabIndex = 8
        Me.optMCode.TabStop = True
        Me.optMCode.Text = "Code"
        '
        'optAccName
        '
        Me.optAccName.BackColor = System.Drawing.Color.Transparent
        Me.optAccName.Cursor = System.Windows.Forms.Cursors.Default
        Me.optAccName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optAccName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optAccName.Location = New System.Drawing.Point(107, 12)
        Me.optAccName.Name = "optAccName"
        Me.optAccName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optAccName.Size = New System.Drawing.Size(88, 15)
        Me.optAccName.TabIndex = 7
        Me.optAccName.Text = "Name"
        '
        'OptCompany
        '
        Me.OptCompany.BackColor = System.Drawing.Color.Transparent
        Me.OptCompany.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptCompany.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptCompany.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptCompany.Location = New System.Drawing.Point(197, 8)
        Me.OptCompany.Name = "OptCompany"
        Me.OptCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptCompany.Size = New System.Drawing.Size(99, 24)
        Me.OptCompany.TabIndex = 6
        Me.OptCompany.Text = "Company"
        Me.OptCompany.Visible = False
        '
        'OptOthers
        '
        Me.OptOthers.BackColor = System.Drawing.Color.Transparent
        Me.OptOthers.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptOthers.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptOthers.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptOthers.Location = New System.Drawing.Point(328, 13)
        Me.OptOthers.Name = "OptOthers"
        Me.OptOthers.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OptOthers.Size = New System.Drawing.Size(88, 15)
        Me.OptOthers.TabIndex = 5
        Me.OptOthers.Text = "Others"
        Me.OptOthers.Visible = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.Transparent
        Me.Frame2.Controls.Add(Me.OptPermanent)
        Me.Frame2.Controls.Add(Me.Optcommunication)
        Me.Frame2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(544, 128)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame2.Size = New System.Drawing.Size(424, 40)
        Me.Frame2.TabIndex = 1
        Me.Frame2.TabStop = False
        Me.Frame2.Visible = False
        '
        'OptPermanent
        '
        Me.OptPermanent.BackColor = System.Drawing.Color.Transparent
        Me.OptPermanent.Cursor = System.Windows.Forms.Cursors.Default
        Me.OptPermanent.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptPermanent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OptPermanent.Location = New System.Drawing.Point(40, 16)
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
        Me.Optcommunication.Location = New System.Drawing.Point(240, 12)
        Me.Optcommunication.Name = "Optcommunication"
        Me.Optcommunication.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Optcommunication.Size = New System.Drawing.Size(168, 19)
        Me.Optcommunication.TabIndex = 2
        Me.Optcommunication.TabStop = True
        Me.Optcommunication.Text = "COMMUNICATION"
        '
        'ChkLast
        '
        Me.ChkLast.BackColor = System.Drawing.Color.Transparent
        Me.ChkLast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkLast.Cursor = System.Windows.Forms.Cursors.Default
        Me.ChkLast.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkLast.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ChkLast.Location = New System.Drawing.Point(18, 10)
        Me.ChkLast.Name = "ChkLast"
        Me.ChkLast.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkLast.Size = New System.Drawing.Size(22, 16)
        Me.ChkLast.TabIndex = 0
        Me.ChkLast.Text = "PREVIOUS YEAR"
        Me.ChkLast.Visible = False
        '
        'lbladd3
        '
        Me.lbladd3.AutoSize = True
        Me.lbladd3.BackColor = System.Drawing.Color.Transparent
        Me.lbladd3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbladd3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd3.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbladd3.Location = New System.Drawing.Point(8, 120)
        Me.lbladd3.Name = "lbladd3"
        Me.lbladd3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbladd3.Size = New System.Drawing.Size(54, 18)
        Me.lbladd3.TabIndex = 49
        Me.lbladd3.Text = "lblAdd3"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.BackColor = System.Drawing.Color.Transparent
        Me.lblAmount.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(312, 192)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblAmount.Size = New System.Drawing.Size(71, 18)
        Me.lblAmount.TabIndex = 39
        Me.lblAmount.Text = "lblAmount"
        Me.lblAmount.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.lblAmount.Visible = False
        '
        'PImage
        '
        Me.PImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.PImage.Location = New System.Drawing.Point(424, 120)
        Me.PImage.Name = "PImage"
        Me.PImage.Size = New System.Drawing.Size(106, 122)
        Me.PImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PImage.TabIndex = 51
        Me.PImage.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(128, Byte), CType(0, Byte), CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(174, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(163, 22)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "As on Outstanding :"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblType.Location = New System.Drawing.Point(176, 24)
        Me.lblType.Name = "lblType"
        Me.lblType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblType.Size = New System.Drawing.Size(48, 18)
        Me.lblType.TabIndex = 37
        Me.lblType.Text = "lbltype"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblname.Location = New System.Drawing.Point(8, 48)
        Me.lblname.Name = "lblname"
        Me.lblname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblname.Size = New System.Drawing.Size(55, 18)
        Me.lblname.TabIndex = 36
        Me.lblname.Text = "lblname"
        '
        'lbladd1
        '
        Me.lbladd1.AutoSize = True
        Me.lbladd1.BackColor = System.Drawing.Color.Transparent
        Me.lbladd1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbladd1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbladd1.Location = New System.Drawing.Point(8, 72)
        Me.lbladd1.Name = "lbladd1"
        Me.lbladd1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbladd1.Size = New System.Drawing.Size(54, 18)
        Me.lbladd1.TabIndex = 35
        Me.lbladd1.Text = "lblAdd1"
        '
        'lbladd2
        '
        Me.lbladd2.AutoSize = True
        Me.lbladd2.BackColor = System.Drawing.Color.Transparent
        Me.lbladd2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbladd2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd2.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lbladd2.Location = New System.Drawing.Point(8, 96)
        Me.lbladd2.Name = "lbladd2"
        Me.lbladd2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbladd2.Size = New System.Drawing.Size(54, 18)
        Me.lbladd2.TabIndex = 34
        Me.lbladd2.Text = "lblAdd2"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.BackColor = System.Drawing.Color.Transparent
        Me.lblcity.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcity.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblcity.Location = New System.Drawing.Point(8, 144)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcity.Size = New System.Drawing.Size(44, 18)
        Me.lblcity.TabIndex = 33
        Me.lblcity.Text = "lblcity"
        '
        'lblstate
        '
        Me.lblstate.AutoSize = True
        Me.lblstate.BackColor = System.Drawing.Color.Transparent
        Me.lblstate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblstate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstate.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblstate.Location = New System.Drawing.Point(224, 136)
        Me.lblstate.Name = "lblstate"
        Me.lblstate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblstate.Size = New System.Drawing.Size(52, 18)
        Me.lblstate.TabIndex = 32
        Me.lblstate.Text = "lblstate"
        '
        'lblpin
        '
        Me.lblpin.AutoSize = True
        Me.lblpin.BackColor = System.Drawing.Color.Transparent
        Me.lblpin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblpin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpin.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblpin.Location = New System.Drawing.Point(128, 144)
        Me.lblpin.Name = "lblpin"
        Me.lblpin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblpin.Size = New System.Drawing.Size(41, 18)
        Me.lblpin.TabIndex = 31
        Me.lblpin.Text = "lblpin"
        '
        'lblphone1
        '
        Me.lblphone1.AutoSize = True
        Me.lblphone1.BackColor = System.Drawing.Color.Transparent
        Me.lblphone1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblphone1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone1.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblphone1.Location = New System.Drawing.Point(8, 168)
        Me.lblphone1.Name = "lblphone1"
        Me.lblphone1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblphone1.Size = New System.Drawing.Size(68, 18)
        Me.lblphone1.TabIndex = 30
        Me.lblphone1.Text = "lblphone1"
        '
        'lblphone2
        '
        Me.lblphone2.AutoSize = True
        Me.lblphone2.BackColor = System.Drawing.Color.Transparent
        Me.lblphone2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblphone2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone2.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblphone2.Location = New System.Drawing.Point(224, 168)
        Me.lblphone2.Name = "lblphone2"
        Me.lblphone2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblphone2.Size = New System.Drawing.Size(68, 18)
        Me.lblphone2.TabIndex = 29
        Me.lblphone2.Text = "lblphone2"
        '
        'lblcellno
        '
        Me.lblcellno.AutoSize = True
        Me.lblcellno.BackColor = System.Drawing.Color.Transparent
        Me.lblcellno.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcellno.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcellno.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblcellno.Location = New System.Drawing.Point(8, 192)
        Me.lblcellno.Name = "lblcellno"
        Me.lblcellno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcellno.Size = New System.Drawing.Size(61, 18)
        Me.lblcellno.TabIndex = 28
        Me.lblcellno.Text = "lblCellno"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(128, 192)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEmail.Size = New System.Drawing.Size(56, 18)
        Me.lblEmail.TabIndex = 27
        Me.lblEmail.Text = "lblEmail"
        '
        'lblmcode
        '
        Me.lblmcode.AutoSize = True
        Me.lblmcode.BackColor = System.Drawing.Color.Transparent
        Me.lblmcode.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmcode.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmcode.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblmcode.Location = New System.Drawing.Point(8, 24)
        Me.lblmcode.Name = "lblmcode"
        Me.lblmcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmcode.Size = New System.Drawing.Size(64, 18)
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
        Me.lblSelection.Location = New System.Drawing.Point(32, 136)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSelection.Size = New System.Drawing.Size(42, 18)
        Me.lblSelection.TabIndex = 25
        Me.lblSelection.Text = "Serch"
        Me.lblSelection.Visible = False
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCompany.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.lblCompany.Location = New System.Drawing.Point(64, 8)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCompany.Size = New System.Drawing.Size(116, 18)
        Me.lblCompany.TabIndex = 24
        Me.lblCompany.Text = "lblCompanyname"
        '
        'lbltermination
        '
        Me.lbltermination.BackColor = System.Drawing.Color.Transparent
        Me.lbltermination.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbltermination.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltermination.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.lbltermination.Location = New System.Drawing.Point(24, 120)
        Me.lbltermination.Name = "lbltermination"
        Me.lbltermination.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbltermination.Size = New System.Drawing.Size(32, 22)
        Me.lbltermination.TabIndex = 23
        Me.lbltermination.Text = "lblTermination"
        Me.lbltermination.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(136, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(261, 26)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "MEMBER  OUTSTANDING"
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.Transparent
        Me.Shape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Shape1.Location = New System.Drawing.Point(16, 8)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(8, 408)
        Me.Shape1.TabIndex = 53
        Me.Shape1.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lblEmail)
        Me.GroupBox2.Controls.Add(Me.lblmcode)
        Me.GroupBox2.Controls.Add(Me.lblCompany)
        Me.GroupBox2.Controls.Add(Me.lblname)
        Me.GroupBox2.Controls.Add(Me.lbladd3)
        Me.GroupBox2.Controls.Add(Me.lblType)
        Me.GroupBox2.Controls.Add(Me.lbladd1)
        Me.GroupBox2.Controls.Add(Me.lbladd2)
        Me.GroupBox2.Controls.Add(Me.lblcity)
        Me.GroupBox2.Controls.Add(Me.lblstate)
        Me.GroupBox2.Controls.Add(Me.lblpin)
        Me.GroupBox2.Controls.Add(Me.lblphone1)
        Me.GroupBox2.Controls.Add(Me.lblphone2)
        Me.GroupBox2.Controls.Add(Me.lblcellno)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(544, 104)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(432, 208)
        Me.GroupBox2.TabIndex = 54
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Cmd_McodeHelp)
        Me.GroupBox3.Controls.Add(Me.Dtp_dob)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.txt_mcode)
        Me.GroupBox3.Controls.Add(Me.grdSelectionList)
        Me.GroupBox3.Controls.Add(Me.cmdGetDetails)
        Me.GroupBox3.Controls.Add(Me.lblAmount)
        Me.GroupBox3.Location = New System.Drawing.Point(120, 104)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(416, 208)
        Me.GroupBox3.TabIndex = 55
        Me.GroupBox3.TabStop = False
        '
        'Cmd_McodeHelp
        '
        Me.Cmd_McodeHelp.BackColor = System.Drawing.Color.White
        Me.Cmd_McodeHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_McodeHelp.ForeColor = System.Drawing.Color.White
        Me.Cmd_McodeHelp.Image = CType(resources.GetObject("Cmd_McodeHelp.Image"), System.Drawing.Image)
        Me.Cmd_McodeHelp.Location = New System.Drawing.Point(312, 24)
        Me.Cmd_McodeHelp.Name = "Cmd_McodeHelp"
        Me.Cmd_McodeHelp.Size = New System.Drawing.Size(40, 24)
        Me.Cmd_McodeHelp.TabIndex = 137
        '
        'Dtp_dob
        '
        Me.Dtp_dob.CalendarFont = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_dob.CustomFormat = "dd/MM/yyyy"
        Me.Dtp_dob.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dtp_dob.Location = New System.Drawing.Point(208, 72)
        Me.Dtp_dob.Name = "Dtp_dob"
        Me.Dtp_dob.Size = New System.Drawing.Size(120, 26)
        Me.Dtp_dob.TabIndex = 53
        Me.Dtp_dob.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label4.Location = New System.Drawing.Point(72, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(105, 22)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Date of Birth"
        Me.Label4.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(64, Byte), CType(64, Byte), CType(64, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(136, 22)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Member.Ship.No"
        '
        'txt_mcode
        '
        Me.txt_mcode.AcceptsReturn = True
        Me.txt_mcode.AutoSize = False
        Me.txt_mcode.BackColor = System.Drawing.Color.Gold
        Me.txt_mcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_mcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_mcode.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txt_mcode.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mcode.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_mcode.Location = New System.Drawing.Point(208, 24)
        Me.txt_mcode.MaxLength = 25
        Me.txt_mcode.Name = "txt_mcode"
        Me.txt_mcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txt_mcode.Size = New System.Drawing.Size(104, 24)
        Me.txt_mcode.TabIndex = 50
        Me.txt_mcode.Text = ""
        '
        'grdSelectionList
        '
        Me.grdSelectionList.ContainingControl = Me
        Me.grdSelectionList.DataSource = Nothing
        Me.grdSelectionList.Location = New System.Drawing.Point(8, 96)
        Me.grdSelectionList.Name = "grdSelectionList"
        Me.grdSelectionList.OcxState = CType(resources.GetObject("grdSelectionList.OcxState"), System.Windows.Forms.AxHost.State)
        Me.grdSelectionList.Size = New System.Drawing.Size(368, 96)
        Me.grdSelectionList.TabIndex = 49
        Me.grdSelectionList.Visible = False
        '
        'Memberhelp_Member
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1030, 738)
        Me.ControlBox = False
        Me.Controls.Add(Me.fraDetails)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtSelection)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbltermination)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.ChkLast)
        Me.Controls.Add(Me.PImage)
        Me.Controls.Add(Me.Shape1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(5, 56)
        Me.Name = "Memberhelp_Member"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.fraDetails.ResumeLayout(False)
        CType(Me.sSgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraDependents.ResumeLayout(False)
        CType(Me.vaDependents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdSelectionList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As Memberhelp_Member
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As Memberhelp_Member
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New Memberhelp_Member
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As Memberhelp_Member)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
    '***************************************************  Modified On 11/04/2007 **************************************
    Dim Vconn As New GlobalClass
    Dim FormUnload As Boolean
    Dim vTotal, total, total1, total2, total3 As Double
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

                    'vaDependents.SetText(5, loopindex + 1, Trim(gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("AGE")))
                    'vSql = "SELECT PHOTOIMAGE AS PHOTOIMAGE  FROM " & Trim(vUser) & "..PHOTOADDING WHERE MCODE = '" & Trim(lblmcode.Text) & "'"
                    'Vconn.getDataSet(vSql, "PHOTOADDING")
                    'If gdataset.Tables("PHOTOADDING").Rows.Count > 0 Then
                    '    If Trim(gdataset.Tables("PHOTOADDING").Rows(0).Item("PHOTOIMAGE") & "") <> "" Then
                    '        vaDependents.Col = 6
                    '        vaDependents.TypeButtonText = "YES"
                    '    Else
                    '        vaDependents.Col = 6
                    '        vaDependents.TypeButtonText = "NO"
                    '    End If
                    '    vaDependents.SetText(7, loopindex + 1, Trim(gdataset.Tables("DEPENDENTMASTER").Rows(loopindex).Item("PHOTO") & ""))
                    'End If

                Next
                FraDependents.Visible = True
            Else
                MsgBox("Dependent Details are not there", MsgBoxStyle.Information, Trim(MyCompanyName))
                Exit Sub
            End If
        End If
    End Sub
    Private Sub CmdGetDetails_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGetDetails.Click
        Try
            fraDetails.Visible = True
            FraDependents.Visible = False
            TxtBalance.Text = ""
            txtReceipts.Text = ""
            TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
            txtSales.Text = ""
            Mskfrom.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, gCompanyname)
        End Try
    End Sub
    Private Sub CmdPrint_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdprint.Click
        'Call PrintOperation()
        'Call Button1_Click_1(Button1, eventArgs)
        'Call CMD_WINDOWS_Click(Button1, eventArgs)

        Dim i As Integer
        Dim ssql, Sqlstr, fromdate, todate As String
        Dim vReceipts, vSales As Double
        Dim vopbal, total1 As Double
        fromdate = Format(Mskfrom.Value, "dd/MMM/yyyy")
        todate = Format(Mskto.Value, "dd/MMM/yyyy")
        '  ssql = "SELECT ISNULL(CREDITDEBIT,'') AS  CREDITDEBIT,SUM(AMOUNT) AS AMT FROM " & Trim(vUser & "") & "..VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "' AND CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) < '" & Format(Mskfrom.Value, "dd-MMM-yyyy") & "' AND ACCOUNTCODE='" & Trim(gDebtors) & "'  GROUP BY CREDITDEBIT"
      
        Try
            Dim sqlstring, sqlstr1 As String
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
            sqlstr1 = "SELECT MNAME FROM MEMBERMASTER WHERE MCODE= '" & Trim(vMemAcc) & "' AND CURENTSTATUS IN('ACTIVE','LIVE')"
            Call Viewer.GetDetails1(ssql, "VIEW_OUTSTANDING", r)
            Call Viewer.GetDetails1(Sqlstr, "MM_VIEW_HGALEDGER", r)
            Call Viewer.GetDetails1(sqlstr1, "MEMBERMASTER", r)
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

   
    Private Sub ADDRESS()
        Dim ssql As String
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
    End Sub
    Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
        Try
            'Dim ssql As String
            If txt_mcode.Text = "" Then
                MessageBox.Show("please Enter the Member Ship.No", MsgBoxStyle.Information, gCompanyname)
                txt_mcode.Focus()
                Exit Sub
            End If
            'ssql = " SELECT ISNULL(b.Typedesc,'') as TypeDesc,ISNULL(A.MNAME,'') AS PNAME,ISNULL(A.CONTADD1,'') AS PADD1,ISNULL(A.CONTADD2,'') AS PADD2,ISNULL(A.CONTADD3,'') AS PADD3,"
            'ssql = ssql & " ISNULL(A.CONTCITY,'') AS PCITY, ISNULL(A.CONTSTATE,'') AS PSTATE,ISNULL(A.CONTPIN,'') AS PPINCODE,"
            'ssql = ssql & " ISNULL(A.CONTPHONE1,'') AS PPHONE1,ISNULL(A.CONTPHONE2,'') AS PPHONE2,0 AS PFAXNO,"
            'ssql = ssql & " ISNULL(A.CONTEMAIL,'') AS PEMAIL,ISNULL(A.CONTCELL,'') AS PMOBILE  FROM Membermaster A, Membertype B WHERE A.Mcode='" & txt_mcode.Text & "' and A.membertypecode=B.membertype "
            ''ssql = ssql & " And dob='" & Format(Dtp_dob.Value, "yyyy/MM/dd") & "'"
            'Vconn.getDataSet(ssql, "MEM")
            'If gdataset.Tables("MEM").Rows.Count > 0 Then
            '    lblmcode.Text = txt_mcode.Text
            '    lblname.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("Pname") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("Pname")), Trim(gdataset.Tables("MEM").Rows(0).Item("Pname")), " ")
            '    lbladd1.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("padd1") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("padd1")), Trim(gdataset.Tables("MEM").Rows(0).Item("padd1")), " ")
            '    lbladd2.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("padd2") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("padd2")), Trim(gdataset.Tables("MEM").Rows(0).Item("padd2")), " ")
            '    lbladd3.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("padd3") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("padd3")), Trim(gdataset.Tables("MEM").Rows(0).Item("padd3")), " ")
            '    lblcity.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("pcity") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pcity")), Trim(gdataset.Tables("MEM").Rows(0).Item("pcity")), " ")
            '    lblstate.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("pstate") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pstate")), Trim(gdataset.Tables("MEM").Rows(0).Item("pstate")), " ")
            '    lblpin.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("ppincode") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("ppincode")), Trim(gdataset.Tables("MEM").Rows(0).Item("ppincode")), " ")
            '    lblphone1.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("pphone1") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pphone1")), Trim(gdataset.Tables("MEM").Rows(0).Item("pphone1")), " ")
            '    lblphone2.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("pphone2") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pphone2")), Trim(gdataset.Tables("MEM").Rows(0).Item("pphone2")), " ")
            '    lblcellno.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("pMobile") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pMobile")), Trim(gdataset.Tables("MEM").Rows(0).Item("pMobile")), " ") & " Fax:" & IIf(gdataset.Tables("MEM").Rows(0).Item("pMobile") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pFaxno")), Trim(gdataset.Tables("MEM").Rows(0).Item("pFaxno")), " ")
            '    lblEmail.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("pemail") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pemail")), Trim(gdataset.Tables("MEM").Rows(0).Item("pemail")), " ")
            '    lblType.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("TypeDesc") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("TypeDesc")), Trim(gdataset.Tables("MEM").Rows(0).Item("TypeDesc")), " ")
            'Else
            '    MessageBox.Show("Please Check the DOB ", MsgBoxStyle.Information,gcompanyname)
            '    Dtp_dob.Focus()
            '    Exit Sub
            'End If
            'Mskfrom.Focus()
            TxtBalance.Text = ""
            txtReceipts.Text = ""
            txtSales.Text = ""
            'TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
            Call FillGrid1()
            sSgrid.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, gCompanyname)
        End Try
    End Sub
    Private Sub Memberhelp_Member_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
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
        Call GetOpBal()
        'sstr = "SELECT ISNULL(RECEIPTNO,0) AS RECNO,ISNULL(INSTRUMENTNO,0) AS INSTRUMENTNO,* FROM  " & Trim(vUser & "") & "..JOURNALENTRY WHERE ACCOUNTCODE =  '" & Trim(gDebtors) & "' AND SLCODE= '" & Trim(vMemAcc) & "' AND  VOUCHERDATE >= '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND VOUCHERDATE <= '" & Format(Mskto.Value, "dd/MMM/yyyy") & "'"
        'sstr = sstr & "  AND ISNULL(VOID,'') <> 'Y' AND ISNULL(VOID,'') <> 'C' ORDER BY VOUCHERDATE,VOUCHERNO"
        sstr = " SELECT VOUCHERNO,VOUCHERDATE,VOUCHERCATEGORY,CREDITDEBIT,ISNULL(RECEIPTNO,0) AS RECNO,AMOUNT,ISNULL(INSTRUMENTNO,0) AS INSTRUMENTNO FROM  " & Trim(vUser & "") & "..JOURNALENTRY WHERE ACCOUNTCODE =  '" & Trim(gDebtors) & "' AND SLCODE= '" & Trim(vMemAcc) & "' AND  CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) >= '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND VOUCHERDATE <= '" & Format(Mskto.Value, "dd/MMM/yyyy") & "'  AND VOUCHERCATEGORY<>'SALE'"
        sstr = sstr & "  AND ISNULL(VOID,'') <> 'Y' AND ISNULL(VOID,'') <> 'C'"
        'sstr = sstr & " UNION ALL SELECT KOTDETAILS,CAST(CONVERT(CHAR(39),KOTDATE,106) AS DATETIME) AS KOTDATE,'KOT','DEBIT',0,BILLAMOUNT,0 FROM KOT_HDR WHERE PAYMENTtype='CREDIT' AND MCODE= '" & Trim(vMemAcc) & "' AND  CAST(CONVERT(CHAR(39),KOTDATE,106) AS DATETIME) BETWEEN '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND '" & Format(Mskto.Value, "dd/MMM/yyyy") & "' "
        '--AND ISNULL(POSTINGSTATUS,'')<>'Y'"

        'sstr = sstr & "UNION ALL SELECT BILLDETAILS,ISNULL(CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME),'') AS BILLDATE,'BILL','DEBIT',0,ISNULL(TOTALAMOUNT,0),0 FROM BILL_HDR WHERE MCODE ='" & Trim(vMemAcc) & "' AND PAYMENTMODE IN('CREDIT','PARTY')  AND ISNULL(DELFLAG,'') <> 'Y' AND  CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME) BETWEEN '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND '" & Format(Mskto.Value, "dd/MMM/yyyy") & "' AND ISNULL(ACCOUNTFLAG,'')<>'Y' "
        sstr = sstr & "UNION ALL SELECT BILLDETAILS,ISNULL(CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME),'') AS BILLDATE,'BILL','DEBIT',0,(ISNULL(TOTALAMOUNT,0)-(Isnull(Itemwise_discount_amt,0)+Isnull(discountamount,0))),0 FROM BILL_HDR WHERE MCODE ='" & Trim(vMemAcc) & "' AND PAYMENTMODE ='CREDIT'  AND ISNULL(DELFLAG,'') <> 'Y' AND  CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME) BETWEEN '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND '" & Format(Mskto.Value, "dd/MMM/yyyy") & "' "
        sstr = sstr & "UNION ALL SELECT BILLNO,ISNULL(CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME),'') AS BILLDATE,SUBSCODE,'DEBIT',0,(ISNULL(AMOUNT,0)+ISNULL(TAXAMOUNT,0)),0 FROM SUBSPOSTING WHERE MCODE ='" & Trim(vMemAcc) & "' AND  CAST(CONVERT(CHAR(11),BILLDATE,6) AS DATETIME) BETWEEN '" & Format(Mskfrom.Value, "dd/MMM/yyyy") & "' AND '" & Format(Mskto.Value, "dd/MMM/yyyy") & "' "

        sstr = sstr & "  ORDER BY VOUCHERDATE,VOUCHERNO"
        '''AND ISNULL(ACCOUNTFLAG,'')<>'Y'
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
                    txtSales.Text = Format(Val(txtSales.Text) + Val(CStr(gdataset.Tables("Journalentry").Rows(i).Item("Amount"))), "0.00")
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
        TxtBalance.Text = Format(Val(TxtBalance.Text), "0.00")
        If Val(TxtBalance.Text) < 0 Then
            TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&H80FF)
        End If
    End Sub

    Private Sub MyFillGrid1()
        Dim SQLSTRING As String
        lblAmount.Text = ""
        If OptOthers.Checked Then
            SQLSTRING = "SELECT ISNULL(PNAME,'') AS SUBNAME,ISNULL(PNAME,'') AS SUBCODE FROM ADDRESSSEARCH WHERE PNAME LIKE '" & (Trim(txtSelection.Text)) & "%' ORDER BY PNAME"
        Else
            If optMCode.Checked = True Then
                SQLSTRING = "SELECT ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(SUBCODE,'') AS SUBCODE FROM " & Trim(vUser & "") & "..SUBLEDGERLIST1 "
                SQLSTRING = SQLSTRING & " WHERE   SUBCODE LIKE '" & (Trim(txtSelection.Text)) & "%' "
                SQLSTRING = SQLSTRING & " AND ACCODE='" & Trim(gDebtors) & "' ORDER BY SUBCODE "
            ElseIf optAccName.Checked Then
                SQLSTRING = "SELECT ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(SUBCODE,'') AS SUBCODE FROM " & Trim(vUser & "") & "..SUBLEDGERLIST1 "
                SQLSTRING = SQLSTRING & " WHERE   SUBNAME LIKE '" & (Trim(txtSelection.Text)) & "%' "
                SQLSTRING = SQLSTRING & " AND ACCODE='" & Trim(gDebtors) & "' ORDER BY SUBCODE "
            ElseIf OptCompany.Checked Then
                SQLSTRING = "SELECT ISNULL(MNAME,'') AS SUBNAME,ISNULL(MCODE,'') AS SUBCODE FROM " & Trim(vUser & "") & "..MEMBERMASTER WHERE UPPER(COMPANY) LIKE '" & (Trim(txtSelection.Text)) & "%' ORDER BY COMPANY,MCODE"
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
        'vSql = "SELECT ISNULL(SLCODE,'') AS SLCODE FROM " & Trim(vUser & "") & "..ACCOUNTSSUBLEDGERMASTER WHERE SLCODE ='" & Trim(lblmcode.Text) & "'"
        vSql = "SELECT ISNULL(SLCODE,'') AS SLCODE FROM " & Trim(vUser & "") & "..ACCOUNTSSUBLEDGERMASTER WHERE SLCODE ='" & Trim(txt_mcode.Text) & "'"
        Vconn.getDataSet(vSql, "ACCOUNTSSUBLEDGERMASTER")
        If gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows.Count > 0 Then
            vMemAcc = Trim(gdataset.Tables("ACCOUNTSSUBLEDGERMASTER").Rows(0).Item("SLCODE") & "")
        End If
    End Sub
    Private Sub Memberhelp_Member_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        If FormUnload Then
            Me.Hide()
        End If
    End Sub
    Private Sub Memberhelp_Member_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
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
        Mskfrom.Value = gFinancialyearStart
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        lbltermination.Text = ""
        Me.Text = "Member Details"
        Optcommunication.Checked = True
        vUser = gDatabase
        txtSelection.Focus()
        fraDetails.Visible = True
        FraDependents.Visible = False
        'txt_mcode.Focus()
        cmdGetDetails.Visible = False
        lblAmount.Visible = False
    End Sub

    Private Sub Label5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label5.Click
        Me.Close()
        Memberhelp_Member.DefInstance = Nothing
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
        'SSQL1 = "CREATE TABLE " & vOutputfile1 & " (Mst_Mem_TypeMst varchar(30),Termination numeric(5) default 0,Live numeric(5) default 0)"
        'gcommand = New SqlClient.SqlCommand(SSQL1, Vconn.Myconn)
        'Vconn.openConnection()
        'gcommand.ExecuteNonQuery()
        'Vconn.closeConnection()
        'ssql = "SELECT * FROM Mst_Mem_TypeMst ORDER BY Mst_Mem_TypeMst"
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
        ssql = "SELECT * FROM Mst_Mem_TypeMst ORDER BY MEMBERTYPE"
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
            ssql = "SELECT ISNULL(V.MEMBERTYPE,'') AS MEMBERTYPE,LIVE,TERMINATION,ISNULL(T.TYPEDESC,'') AS TYPEDESC FROM  " & vOutputfile1 & "  V LEFT OUTER JOIN Mst_Mem_TypeMst T ON T.MEMBERTYPE = V.MEMBERTYPE ORDER BY V.MEMBERTYPE"
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
            ' Call txtSelection_Leave(eventSender, eventArgs)
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
    'Private Sub MyFillGrid1()
    '    Dim SQLSTRING As String
    '    lblAmount.Text = ""
    '    If OptOthers.Checked Then
    '        SQLSTRING = "SELECT ISNULL(PNAME,'') AS SUBNAME,ISNULL(PNAME,'') AS SUBCODE FROM ADDRESSSEARCH WHERE PNAME LIKE '" & (Trim(txtSelection.Text)) & "%' ORDER BY PNAME"
    '    Else
    '        If optMCode.Checked = True Then
    '            SQLSTRING = "SELECT ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(SUBCODE,'') AS SUBCODE FROM " & Trim(vUser & "") & "..SUBLEDGERLIST1 "
    '            SQLSTRING = SQLSTRING & " WHERE   SUBCODE LIKE '" & (Trim(txtSelection.Text)) & "%' "
    '            SQLSTRING = SQLSTRING & " AND ACCODE='" & Trim(gDebtors) & "' ORDER BY SUBCODE "
    '        ElseIf optAccName.Checked Then
    '            SQLSTRING = "SELECT ISNULL(SUBNAME,'') AS SUBNAME,ISNULL(SUBCODE,'') AS SUBCODE FROM " & Trim(vUser & "") & "..SUBLEDGERLIST1 "
    '            SQLSTRING = SQLSTRING & " WHERE   SUBNAME LIKE '" & (Trim(txtSelection.Text)) & "%' "
    '            SQLSTRING = SQLSTRING & " AND ACCODE='" & Trim(gDebtors) & "' ORDER BY SUBCODE "
    '        ElseIf OptCompany.Checked Then
    '            SQLSTRING = "SELECT ISNULL(MNAME,'') AS SUBNAME,ISNULL(MCODE,'') AS SUBCODE FROM " & Trim(vUser & "") & "..MEMBERMASTER WHERE UPPER(COMPANY) LIKE '" & (Trim(txtSelection.Text)) & "%' ORDER BY COMPANY,MCODE"
    '        End If
    '    End If
    '    Vconn.getDataSet(SQLSTRING, "SubledgerList1")
    '    Dim loopindex As Integer
    '    If gdataset.Tables("SubledgerList1").Rows.Count > 0 Then
    '        If grdSelectionList.DataRowCnt < gdataset.Tables("SubledgerList1").Rows.Count - 1 Then
    '            grdSelectionList.MaxRows = gdataset.Tables("SubledgerList1").Rows.Count + 3
    '        End If
    '        For loopindex = 0 To gdataset.Tables("SubledgerList1").Rows.Count - 1
    '            grdSelectionList.Col = 1
    '            grdSelectionList.Row = loopindex + 1
    '            grdSelectionList.Text = CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("Subcode"))
    '            grdSelectionList.Col = 2
    '            grdSelectionList.Row = loopindex + 1
    '            grdSelectionList.Text = CStr(gdataset.Tables("SubledgerList1").Rows(loopindex).Item("SubName"))
    '        Next
    '    Else
    '        lblAmount.Text = ""
    '        MsgBox("Details not found.", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "" & gCompanyname)
    '        txtSelection.Text = ""
    '        FormUnload = True
    '    End If
    'End Sub
    Private Sub GetOpBal()
        Dim i As Integer
        Dim MainMenu As Object
        Dim ADODB As Object
        Dim ssql As String
        Dim vReceipts, vSales As Double
        Dim vopbal As Double
        ssql = "SELECT ISNULL(CREDITDEBIT,'') AS  CREDITDEBIT,SUM(AMOUNT) AS AMT FROM " & Trim(vUser & "") & "..VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "' AND CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) < '" & Format(Mskfrom.Value, "dd-MMM-yyyy") & "' AND ACCOUNTCODE='" & Trim(gDebtors) & "'  GROUP BY CREDITDEBIT"
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
                txtReceipts.Text = Format(Val(txtReceipts.Text) + Val(vReceipts), "0.00")
            End If
            If Val(vSales) > 0 Then
                txtSales.Text = Format(Val(txtSales.Text) + Val(vSales), "0.00")
            End If
        Next loopindex
        TxtBalance.Text = ""
        If Val(txtReceipts.Text) > 0 Or Val(txtSales.Text) > 0 Then
            TxtBalance.Text = Format(Val(txtSales.Text) - Val(txtReceipts.Text), "0.00")
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
            '  YesrNo = MessageBox.Show("Do you want to View Or Print", "Total Members List", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            ' If YesrNo = vbYes Then
            OpenTextFile(vOutfile)
            'Else
            '   PrintTextFile(vOutfile)
            'End If
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
    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub
    Private Sub optMCode_Layout(ByVal sender As Object, ByVal e As System.Windows.Forms.LayoutEventArgs) Handles optMCode.Layout

    End Sub
    Private Sub Shape1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Shape1.Click

    End Sub
    Private Sub grdSelectionList_ClickEvent(ByVal sender As Object, ByVal e As AxFPUSpreadADO._DSpreadEvents_ClickEvent) Handles grdSelectionList.ClickEvent
        'If grdSelectionList.DataRowCnt > 0 Then
        '    With grdSelectionList
        '        .Col = 1
        '        .Row = .ActiveRow
        '        MemberCode = Trim(.Text)
        '        .Col = 2
        '        .Row = .ActiveRow
        '        SideLedgerName = Trim(.Text)
        '    End With
        'End If
        ''If fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 0) <> "" Then
        ''    SideLedgerName = fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 0)
        ''    MemberCode = fgrdSelectionList.get_TextMatrix(fgrdSelectionList.Row, 1)
        ''End If
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
                vSql = "SELECT PHOTOIMAGE AS PHOTOIMAGE  FROM " & Trim(vUser) & "..PHOTOADDING WHERE MCODE = '" & Trim(lblmcode.Text) & "'"
                Vconn.getDataSet(vSql, "PHOTOADDING")
                If gdataset.Tables("PHOTOADDING").Rows.Count > 0 Then
                    Vdesc = Trim(gdataset.Tables("PHOTOADDING").Rows(0).Item(0) & "")
                End If
                If Trim(Vdesc) <> "" Then
                    gPicture = Trim(Vdesc & "")
                End If
                vMemberCode = gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode")
                vMemberCode = IIf(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode")) <> "" Or Not IsDBNull(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode")), Trim(CStr(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("SubCode"))), " ")
                vBal = Val(gdataset.Tables("SUBLEDGERLIST1").Rows(0).Item("ClosingBal") & "")

                If vBal > 0 Then
                    'lblAmount.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF0000)
                    lblAmount.Text = Format(vBal, "0.00")
                Else
                    'lblAmount.ForeColor = System.Drawing.ColorTranslator.FromOle(&HFF)
                    lblAmount.Text = Format(vBal, "0.00")
                End If
            End If
            If OptPermanent.Checked = True Then
                grdSelectionList.Col = 1
                grdSelectionList.Row = ij

                ssql = "SELECT ISNULL(M.MCODE,'') AS MCODE,ISNULL(M.COMPANY,'') AS COMPANY,ISNULL(M.TERMINATION,'') AS TERMINATION,ISNULL(M.CON_MCODE,'') AS CON_MCODE,ISNULL(M.MNAME,'') AS MNAME,"
                ssql = ssql & "ISNULL(M.PADD1,'') AS PADD1,ISNULL(M.PHOTO,'') AS PHOTO,ISNULL(M.PADD2,'') AS PADD2,ISNULL(M.PADD3,'') AS PADD3,ISNULL(M.PCITY,'') AS PCITY,ISNULL(M.PSTATE,'') AS PSTATE,ISNULL(M.PPIN,'') AS PPIN,ISNULL(M.PPHONE1,'') AS PPHONE1,ISNULL(M.PPHONE2,'') AS PPHONE2,ISNULL(M.PCELL,'') AS PCELL,"
                ssql = ssql & "ISNULL(M.PEMAIL,'') AS PEMAIL,ISNULL(T.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(T.TYPEDESC,'') AS TYPEDESC FROM " & Trim(vUser) & "..MEMBERMASTER AS M LEFT OUTER JOIN  " & Trim(vUser & "") & "..Mst_Mem_TypeMst AS T ON M.MEMBERTYPECODE = T.MEMBERTYPE WHERE   MCODE ='" & Trim(grdSelectionList.Text) & "'"
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

            End If
            If Optcommunication.Checked = True Then
                grdSelectionList.Col = 1
                grdSelectionList.Row = ij

                ssql = "SELECT ISNULL(M.MCODE,'') AS MCODE,ISNULL(M.TERMINATION,'') as TERMINATION,ISNULL(M.CON_MCODE,'') as CON_MCODE,ISNULL(M.MNAME,'') AS MNAME,ISNULL(M.COMPANY,'') AS COMPANY,ISNULL(M.CADD1,'') AS CADD1,ISNULL(M.PHOTO,'') AS PHOTO,ISNULL(M.CADD2,'') as CADD2,ISNULL(M.CADD3,'') As CADD3,ISNULL(M.CCITY,'') AS CCITY,"
                ssql = ssql & "ISNULL(M.CSTATE,'') AS CSTATE,ISNULL(M.CPIN,'') AS CPIN,ISNULL(M.CPHONE1,'') AS CPHONE1,ISNULL(M.CPHONE2,'') As CPHONE2,ISNULL(M.CCELL,'') AS CCELL,ISNULL(M.CEMAIL,'') as CEMAIL,ISNULL(T.MEMBERTYPE,'') AS MEMBERTYPE,ISNULL(T.TYPEDESC,'') AS TYPEDESC FROM " & Trim(vUser & "") & "..MEMBERMASTER AS M LEFT OUTER JOIN " & Trim(vUser & "") & "..Mst_Mem_TypeMst AS T ON M.MEMBERTYPECODE = T.MEMBERTYPE WHERE   MCODE ='" & Trim(grdSelectionList.Text) & "' "
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
    Private Sub Memberhelp_Member_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        
        If e.KeyCode = Keys.F3 Then
            Dim frmSrc As New frmSearch
            frmSrc.farPoint = sSgrid
            frmSrc.ShowDialog(Me)
        End If
        If e.KeyCode = Keys.F5 Then
            Call Command1_Click(sender, e)
        End If
        If e.KeyCode = Keys.F6 Then
            Call CmdPrint_Click(sender, e)
        End If
        If e.KeyCode = Keys.F7 Then
            Call Button2_Click(sender, e)
        End If
    End Sub
    Private Sub txt_mcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_mcode.KeyDown

        If e.KeyCode = Keys.Enter Then
            If txt_mcode.Text = "" Then
                Cmd_McodeHelp_Click(sender, e)
            Else


            End If
            Mskfrom.Focus()
        End If

    End Sub
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            txt_mcode.Text = ""
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
            txtReceipts.Text = ""
            txtSales.Text = ""
            TxtBalance.Text = ""
            TxtBalance.BackColor = System.Drawing.Color.White
            Mskfrom.Value = gFinancialyearStart
            sSgrid.ClearRange(1, 1, -1, -1, True)
            sSgrid.SetActiveCell(1, 1)
            'txt_mcode.Focus()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information, gCompanyname)
        End Try
    End Sub

    Private Sub Dtp_dob_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_dob.ValueChanged

    End Sub
    Private Sub Dtp_dob_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Dtp_dob.KeyDown
        'If e.KeyCode = Keys.Enter Then
        '    Mskfrom.Focus()
        'End If
    End Sub

    Private Sub Mskto_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mskto.ValueChanged

    End Sub

    Private Sub Mskfrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mskfrom.ValueChanged

    End Sub

    Private Sub txt_mcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_mcode.TextChanged

    End Sub

    Private Sub txt_mcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_mcode.Validated
        Dim ssql As String
      
        ssql = " SELECT ISNULL(b.SUBTypedesc,'') as TypeDesc,ISNULL(A.MNAME,'') AS PNAME,ISNULL(A.CONTADD1,'') AS PADD1,ISNULL(A.CONTADD2,'') AS PADD2,ISNULL(A.CONTADD3,'') AS PADD3,"
        ssql = ssql & " ISNULL(A.CONTCITY,'') AS PCITY, ISNULL(A.CONTSTATE,'') AS PSTATE,ISNULL(A.CONTPIN,'') AS PPINCODE,"
        ssql = ssql & " ISNULL(A.CONTPHONE1,'') AS PPHONE1,ISNULL(A.CONTPHONE2,'') AS PPHONE2,0 AS PFAXNO,"
        ssql = ssql & " ISNULL(A.CONTEMAIL,'') AS PEMAIL,ISNULL(A.CONTCELL,'') AS PMOBILE  FROM Membermaster A, SUBCATEGORYMASTER B WHERE A.Mcode='" & txt_mcode.Text & "' and A.membertypecode=B.SUBTYPECODE "
        'ssql = ssql & " And dob='" & Format(Dtp_dob.Value, "yyyy/MM/dd") & "'"
        Vconn.getDataSet(ssql, "MEM")
        If gdataset.Tables("MEM").Rows.Count > 0 Then
            lblmcode.Text = txt_mcode.Text
            lblname.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("Pname") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("Pname")), Trim(gdataset.Tables("MEM").Rows(0).Item("Pname")), " ")
            lbladd1.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("padd1") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("padd1")), Trim(gdataset.Tables("MEM").Rows(0).Item("padd1")), " ")
            lbladd2.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("padd2") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("padd2")), Trim(gdataset.Tables("MEM").Rows(0).Item("padd2")), " ")
            lbladd3.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("padd3") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("padd3")), Trim(gdataset.Tables("MEM").Rows(0).Item("padd3")), " ")
            lblcity.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("pcity") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pcity")), Trim(gdataset.Tables("MEM").Rows(0).Item("pcity")), " ")
            lblstate.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("pstate") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pstate")), Trim(gdataset.Tables("MEM").Rows(0).Item("pstate")), " ")
            lblpin.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("ppincode") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("ppincode")), Trim(gdataset.Tables("MEM").Rows(0).Item("ppincode")), " ")
            lblphone1.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("pphone1") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pphone1")), Trim(gdataset.Tables("MEM").Rows(0).Item("pphone1")), " ")
            lblphone2.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("pphone2") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pphone2")), Trim(gdataset.Tables("MEM").Rows(0).Item("pphone2")), " ")
            lblcellno.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("pMobile") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pMobile")), Trim(gdataset.Tables("MEM").Rows(0).Item("pMobile")), " ") & " Fax:" & IIf(gdataset.Tables("MEM").Rows(0).Item("pMobile") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pFaxno")), Trim(gdataset.Tables("MEM").Rows(0).Item("pFaxno")), " ")
            lblEmail.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("pemail") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("pemail")), Trim(gdataset.Tables("MEM").Rows(0).Item("pemail")), " ")
            lblType.Text = IIf(gdataset.Tables("MEM").Rows(0).Item("TypeDesc") <> "" Or Not IsDBNull(gdataset.Tables("MEM").Rows(0).Item("TypeDesc")), Trim(gdataset.Tables("MEM").Rows(0).Item("TypeDesc")), " ")
        Else
            'MessageBox.Show("Please Check the member code ", MsgBoxStyle.Information, gCompanyname)
            '  MessageBox.Show(" Please Check the member code ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Dtp_dob.Focus()
            Exit Sub
        End If
        Mskfrom.Focus()
        TxtBalance.Text = ""
        txtReceipts.Text = ""
        txtSales.Text = ""
        TxtBalance.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFFF)
        sSgrid.ClearRange(1, 1, -1, -1, True)
        sSgrid.SetActiveCell(1, 1)
        'Dim SSQL As String
        'SSQL = "SELECT isnull(dob,'') as dob FROM " & Trim(vUser) & "..MEMBERMASTER AS M WHERE   MCODE ='" & Trim(txt_mcode.Text) & "'"
        'Vconn.getDataSet(SSQL, "MemberMaster")
        'If gdataset.Tables("MemberMaster").Rows.Count > 0 Then
        '    Dtp_dob.Value = Format(gdataset.Tables("MemberMaster").Rows(0).Item("dob"), "dd/MM/yyyy")
        'End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
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

            total2 = 0

           
            'ssql = "SELECT ISNULL(CREDITDEBIT,'') AS  CREDITDEBIT,SUM(AMOUNT) AS AMOUNT FROM " & Trim(vUser & "") & "..VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "' AND CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) < '" & Format(Mskfrom.Value, "dd-MMM-yyyy") & "' AND ACCOUNTCODE='" & Trim(gDebtors) & "'  GROUP BY CREDITDEBIT"
            Call GetOpBal1()
            Dim sqlstring, bildt As String
            Dim Viewer As New ReportViwer
            Dim r As New Cry_Memberledger1
            Dim txtobj1 As TextObject
            If total1 < 0 Then
                total2 = total1 / -1
            Else
                total2 = total1

            End If

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
    Private Sub GetOpBal1()
        Dim i, noofdays, month1 As Integer
        Dim MainMenu As Object
        Dim ADODB As Object
        Dim ssql, bildt As String
        Dim vReceipts, vSales As Double
        Dim vopbal, vtotal1 As Double
        total1 = 0
        If Mid(Me.Mskfrom.Text, 4, 2) = "04" Then month1 = 4 : noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.Mskfrom.Text, 4, 2) = "05" Then month1 = 5 : noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.Mskfrom.Text, 4, 2) = "06" Then month1 = 6 : noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.Mskfrom.Text, 4, 2) = "07" Then month1 = 7 : noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.Mskfrom.Text, 4, 2) = "08" Then month1 = 8 : noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.Mskfrom.Text, 4, 2) = "09" Then month1 = 9 : noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.Mskfrom.Text, 4, 2) = "10" Then month1 = 10 : noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.Mskfrom.Text, 4, 2) = "11" Then month1 = 11 : noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.Mskfrom.Text, 4, 2) = "12" Then month1 = 12 : noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4)
        If Mid(Me.Mskfrom.Text, 4, 2) = "01" Then month1 = 1 : noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4)
        If Mid(Me.Mskfrom.Text, 4, 2) = "02" Then month1 = 2 : noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4)
        If Mid(Me.Mskfrom.Text, 4, 2) = "03" Then month1 = 3 : noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4)
        ssql = "SELECT ISNULL(CREDITDEBIT,'') AS  CREDITDEBIT,SUM(AMOUNT) AS AMT FROM " & Trim(vUser & "") & "..VIEW_OUTSTANDING WHERE SLCODE = '" & Trim(vMemAcc) & "' AND CAST(CONVERT(CHAR(11),VOUCHERDATE) AS DATETIME) < '" & bildt & "' AND ACCOUNTCODE='" & Trim(gDebtors) & "'  GROUP BY CREDITDEBIT"
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

        If vopbal >= 0 Then

            'vTotal = vTotal + vopbal
            vtotal1 = vtotal1 + vopbal
            creditdebit = "DEBIT"
            total1 = vtotal1

        ElseIf vopbal <= 0 Then
            vopbal = -(vopbal)
            vtotal1 = vtotal1 - vopbal
            creditdebit = "CREDIT"
            total1 = vtotal1

        End If

    End Sub

    Private Sub Cmd_McodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_McodeHelp.Click
        Try
            Dim vform As New ListOperation
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
            M_WhereCondition = " Where Curentstatus IN('LIVE','ACTIVE') "
            vform.Field = "MCODE,MNAME"
            vform.vFormatstring = "  MEMBERSHIP NO  |                   MEMBER NAME               "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                txt_mcode.Text = Trim(vform.keyfield & "")
                'txtNBYMEMBERNAME.Text = Trim(vform.keyfield1 & "")
                Call txt_mcode_Validated(sender, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub fraDetails_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles fraDetails.Enter

    End Sub
End Class