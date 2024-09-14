Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Friend Class Outstandinglist
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim sqlString, chk_month As String
    Dim I As Integer
    Public sqlStringFinal, DispString, membertype As String
    Dim iNumber, row, PageSize, PageNo As Integer
    Dim billno As Long
    Dim addFltrStr, FltrStr As String
    Public TempString(2), bill, catecode As String
    Dim storedPro_str As String
    Dim Fromdate, ToDate As String
    Dim postype, Vcatefile, sout, rout As String
    Dim subsummary, memd, posting As New DataTable
    Dim dr As DataRow
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim Processed_Chk(4) As Integer
#Region "Windows Form Designer generated code "
    Public Sub New()
        MyBase.New()
        If m_vb6FormDefInstance Is Nothing Then
            If m_InitializingDefInstance Then
                ' m_vb6FormDefInstance = Me
            Else
                Try
                    'For the start-up form, the first instance created is the default instance.
                    If System.Reflection.Assembly.GetExecutingAssembly.EntryPoint.DeclaringType Is Me.GetType Then
                        '        Me.m_vb6FormDefInstance()
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
    Public WithEvents txtamount As System.Windows.Forms.TextBox
    Public WithEvents cbxMonth As System.Windows.Forms.ComboBox
    Public WithEvents OPTALL As System.Windows.Forms.RadioButton
    Public WithEvents OPTSELECT As System.Windows.Forms.RadioButton
    Public WithEvents CMBTYPE As System.Windows.Forms.ComboBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Shape2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DTPASONDATE1 As System.Windows.Forms.DateTimePicker
    Public WithEvents CMDCLEAR As System.Windows.Forms.Button
    Public WithEvents CMDPRINT As System.Windows.Forms.Button
    Public WithEvents CMDEXIT As System.Windows.Forms.Button
    Public WithEvents CMDVIEW As System.Windows.Forms.Button
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents OUTSTD_LST As System.Windows.Forms.RadioButton
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents OPTSTATUS As System.Windows.Forms.RadioButton
    Friend WithEvents GRP1 As System.Windows.Forms.GroupBox
    Public WithEvents GRP_EXIT As System.Windows.Forms.Button
    Public WithEvents EXCLEXPORT As System.Windows.Forms.Button
    Friend WithEvents AxfpSpread1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents ChkDOS As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Outstandinglist))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.OPTALL = New System.Windows.Forms.RadioButton
        Me.CMBTYPE = New System.Windows.Forms.ComboBox
        Me.CMDCLEAR = New System.Windows.Forms.Button
        Me.CMDPRINT = New System.Windows.Forms.Button
        Me.CMDEXIT = New System.Windows.Forms.Button
        Me.CMDVIEW = New System.Windows.Forms.Button
        Me.cbxMonth = New System.Windows.Forms.ComboBox
        Me.OPTSELECT = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Shape2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DTPASONDATE1 = New System.Windows.Forms.DateTimePicker
        Me.Label8 = New System.Windows.Forms.Label
        Me.OUTSTD_LST = New System.Windows.Forms.RadioButton
        Me.Label9 = New System.Windows.Forms.Label
        Me.OPTSTATUS = New System.Windows.Forms.RadioButton
        Me.GRP1 = New System.Windows.Forms.GroupBox
        Me.AxfpSpread1 = New AxFPSpreadADO.AxfpSpread
        Me.GRP_EXIT = New System.Windows.Forms.Button
        Me.EXCLEXPORT = New System.Windows.Forms.Button
        Me.ChkDOS = New System.Windows.Forms.CheckBox
        Me.GRP1.SuspendLayout()
        CType(Me.AxfpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtamount
        '
        Me.txtamount.AcceptsReturn = True
        Me.txtamount.AutoSize = False
        Me.txtamount.BackColor = System.Drawing.SystemColors.Window
        Me.txtamount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtamount.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(296, 192)
        Me.txtamount.MaxLength = 0
        Me.txtamount.Name = "txtamount"
        Me.txtamount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtamount.Size = New System.Drawing.Size(88, 25)
        Me.txtamount.TabIndex = 2
        Me.txtamount.Text = ""
        Me.ToolTip1.SetToolTip(Me.txtamount, "Ending Outstanding Value")
        '
        'OPTALL
        '
        Me.OPTALL.BackColor = System.Drawing.Color.FromArgb(CType(158, Byte), CType(188, Byte), CType(185, Byte))
        Me.OPTALL.Checked = True
        Me.OPTALL.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPTALL.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPTALL.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPTALL.Location = New System.Drawing.Point(104, 240)
        Me.OPTALL.Name = "OPTALL"
        Me.OPTALL.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPTALL.Size = New System.Drawing.Size(15, 17)
        Me.OPTALL.TabIndex = 3
        Me.OPTALL.TabStop = True
        Me.OPTALL.Text = "ALL"
        Me.ToolTip1.SetToolTip(Me.OPTALL, "All type Member Wise ")
        '
        'CMBTYPE
        '
        Me.CMBTYPE.BackColor = System.Drawing.SystemColors.Window
        Me.CMBTYPE.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMBTYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBTYPE.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBTYPE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CMBTYPE.Location = New System.Drawing.Point(248, 304)
        Me.CMBTYPE.Name = "CMBTYPE"
        Me.CMBTYPE.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMBTYPE.Size = New System.Drawing.Size(177, 26)
        Me.CMBTYPE.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.CMBTYPE, "Select The Member Type")
        '
        'CMDCLEAR
        '
        Me.CMDCLEAR.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.CMDCLEAR.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMDCLEAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMDCLEAR.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDCLEAR.ForeColor = System.Drawing.Color.White
        Me.CMDCLEAR.Image = CType(resources.GetObject("CMDCLEAR.Image"), System.Drawing.Image)
        Me.CMDCLEAR.Location = New System.Drawing.Point(128, 360)
        Me.CMDCLEAR.Name = "CMDCLEAR"
        Me.CMDCLEAR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMDCLEAR.Size = New System.Drawing.Size(112, 32)
        Me.CMDCLEAR.TabIndex = 8
        Me.CMDCLEAR.Text = "&CLEAR  [F12]"
        Me.ToolTip1.SetToolTip(Me.CMDCLEAR, "To Clear the content of this form, click or Press ALT+C or press F12")
        '
        'CMDPRINT
        '
        Me.CMDPRINT.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.CMDPRINT.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMDPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMDPRINT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDPRINT.ForeColor = System.Drawing.Color.White
        Me.CMDPRINT.Image = CType(resources.GetObject("CMDPRINT.Image"), System.Drawing.Image)
        Me.CMDPRINT.Location = New System.Drawing.Point(432, 360)
        Me.CMDPRINT.Name = "CMDPRINT"
        Me.CMDPRINT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMDPRINT.Size = New System.Drawing.Size(104, 32)
        Me.CMDPRINT.TabIndex = 7
        Me.CMDPRINT.Text = "&PRINT [F10]"
        Me.ToolTip1.SetToolTip(Me.CMDPRINT, "To Print  the result in report format, click or Press ALT+P or press F9")
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.CMDEXIT.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMDEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMDEXIT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.Color.White
        Me.CMDEXIT.Image = CType(resources.GetObject("CMDEXIT.Image"), System.Drawing.Image)
        Me.CMDEXIT.Location = New System.Drawing.Point(576, 360)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMDEXIT.Size = New System.Drawing.Size(96, 32)
        Me.CMDEXIT.TabIndex = 9
        Me.CMDEXIT.Text = "&EXIT [F11]"
        Me.ToolTip1.SetToolTip(Me.CMDEXIT, "To Close this form, click or Press ALT+E or press F11")
        '
        'CMDVIEW
        '
        Me.CMDVIEW.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.CMDVIEW.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMDVIEW.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMDVIEW.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDVIEW.ForeColor = System.Drawing.Color.White
        Me.CMDVIEW.Image = CType(resources.GetObject("CMDVIEW.Image"), System.Drawing.Image)
        Me.CMDVIEW.Location = New System.Drawing.Point(280, 360)
        Me.CMDVIEW.Name = "CMDVIEW"
        Me.CMDVIEW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMDVIEW.Size = New System.Drawing.Size(112, 32)
        Me.CMDVIEW.TabIndex = 6
        Me.CMDVIEW.Text = "&VIEW  [F6]"
        Me.ToolTip1.SetToolTip(Me.CMDVIEW, "To Clear the content of this form, click or Press ALT+C or press F12")
        '
        'cbxMonth
        '
        Me.cbxMonth.BackColor = System.Drawing.SystemColors.Window
        Me.cbxMonth.Cursor = System.Windows.Forms.Cursors.Default
        Me.cbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxMonth.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMonth.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cbxMonth.Items.AddRange(New Object() {"April                                      =>04", "May                                       =>05      ", "Jun                                        =>06     ", "July                                        =>07     ", "August                                   =>08", "September                            =>09                                     =>9" & _
        "", "October                                 =>10     ", "November                              =>11     ", "December                              => 12    ", "January                                  =>01 ", "February                                 =>02  ", "March                                      =>03"})
        Me.cbxMonth.Location = New System.Drawing.Point(296, 112)
        Me.cbxMonth.Name = "cbxMonth"
        Me.cbxMonth.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbxMonth.Size = New System.Drawing.Size(144, 26)
        Me.cbxMonth.TabIndex = 0
        '
        'OPTSELECT
        '
        Me.OPTSELECT.BackColor = System.Drawing.Color.FromArgb(CType(158, Byte), CType(188, Byte), CType(185, Byte))
        Me.OPTSELECT.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPTSELECT.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPTSELECT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPTSELECT.Location = New System.Drawing.Point(216, 240)
        Me.OPTSELECT.Name = "OPTSELECT"
        Me.OPTSELECT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPTSELECT.Size = New System.Drawing.Size(15, 17)
        Me.OPTSELECT.TabIndex = 4
        Me.OPTSELECT.TabStop = True
        Me.OPTSELECT.Text = "SELECTED TYPE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(198, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(95, 22)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "AMOUNT : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(208, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(85, 22)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "MONTH : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(160, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(0, 21)
        Me.Label6.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(240, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(154, 22)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "MEMBER CATEGORY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(128, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(36, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ALL"
        '
        'Shape2
        '
        Me.Shape2.BackColor = System.Drawing.Color.Transparent
        Me.Shape2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Shape2.Location = New System.Drawing.Point(72, 104)
        Me.Shape2.Name = "Shape2"
        Me.Shape2.Size = New System.Drawing.Size(648, 240)
        Me.Shape2.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(208, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(84, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cut off Date :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(139, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(154, 22)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "CUT OFF DATE : "
        '
        'DTPASONDATE1
        '
        Me.DTPASONDATE1.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPASONDATE1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPASONDATE1.Location = New System.Drawing.Point(296, 152)
        Me.DTPASONDATE1.Name = "DTPASONDATE1"
        Me.DTPASONDATE1.Size = New System.Drawing.Size(144, 26)
        Me.DTPASONDATE1.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(480, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(174, 22)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Above 10,000 list"
        Me.Label8.Visible = False
        '
        'OUTSTD_LST
        '
        Me.OUTSTD_LST.BackColor = System.Drawing.Color.FromArgb(CType(158, Byte), CType(188, Byte), CType(185, Byte))
        Me.OUTSTD_LST.Cursor = System.Windows.Forms.Cursors.Default
        Me.OUTSTD_LST.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OUTSTD_LST.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OUTSTD_LST.Location = New System.Drawing.Point(448, 192)
        Me.OUTSTD_LST.Name = "OUTSTD_LST"
        Me.OUTSTD_LST.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OUTSTD_LST.Size = New System.Drawing.Size(15, 17)
        Me.OUTSTD_LST.TabIndex = 22
        Me.OUTSTD_LST.TabStop = True
        Me.OUTSTD_LST.Text = "SELECTED TYPE"
        Me.OUTSTD_LST.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(440, 240)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(134, 22)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "MEMBER STATUS"
        '
        'OPTSTATUS
        '
        Me.OPTSTATUS.BackColor = System.Drawing.Color.FromArgb(CType(158, Byte), CType(188, Byte), CType(185, Byte))
        Me.OPTSTATUS.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPTSTATUS.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPTSTATUS.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPTSTATUS.Location = New System.Drawing.Point(408, 240)
        Me.OPTSTATUS.Name = "OPTSTATUS"
        Me.OPTSTATUS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.OPTSTATUS.Size = New System.Drawing.Size(15, 17)
        Me.OPTSTATUS.TabIndex = 23
        Me.OPTSTATUS.TabStop = True
        Me.OPTSTATUS.Text = "SELECTED TYPE"
        '
        'GRP1
        '
        Me.GRP1.BackColor = System.Drawing.Color.Transparent
        Me.GRP1.Controls.Add(Me.AxfpSpread1)
        Me.GRP1.Controls.Add(Me.GRP_EXIT)
        Me.GRP1.Controls.Add(Me.EXCLEXPORT)
        Me.GRP1.Location = New System.Drawing.Point(64, 88)
        Me.GRP1.Name = "GRP1"
        Me.GRP1.Size = New System.Drawing.Size(656, 456)
        Me.GRP1.TabIndex = 618
        Me.GRP1.TabStop = False
        '
        'AxfpSpread1
        '
        Me.AxfpSpread1.ContainingControl = Me
        Me.AxfpSpread1.DataSource = Nothing
        Me.AxfpSpread1.Location = New System.Drawing.Point(8, 16)
        Me.AxfpSpread1.Name = "AxfpSpread1"
        Me.AxfpSpread1.OcxState = CType(resources.GetObject("AxfpSpread1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxfpSpread1.Size = New System.Drawing.Size(640, 360)
        Me.AxfpSpread1.TabIndex = 616
        '
        'GRP_EXIT
        '
        Me.GRP_EXIT.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.GRP_EXIT.Cursor = System.Windows.Forms.Cursors.Default
        Me.GRP_EXIT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GRP_EXIT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRP_EXIT.ForeColor = System.Drawing.Color.White
        Me.GRP_EXIT.Image = CType(resources.GetObject("GRP_EXIT.Image"), System.Drawing.Image)
        Me.GRP_EXIT.Location = New System.Drawing.Point(216, 392)
        Me.GRP_EXIT.Name = "GRP_EXIT"
        Me.GRP_EXIT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GRP_EXIT.Size = New System.Drawing.Size(112, 40)
        Me.GRP_EXIT.TabIndex = 618
        Me.GRP_EXIT.Text = "EXIT"
        '
        'EXCLEXPORT
        '
        Me.EXCLEXPORT.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.EXCLEXPORT.Cursor = System.Windows.Forms.Cursors.Default
        Me.EXCLEXPORT.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EXCLEXPORT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EXCLEXPORT.ForeColor = System.Drawing.Color.White
        Me.EXCLEXPORT.Image = CType(resources.GetObject("EXCLEXPORT.Image"), System.Drawing.Image)
        Me.EXCLEXPORT.Location = New System.Drawing.Point(360, 392)
        Me.EXCLEXPORT.Name = "EXCLEXPORT"
        Me.EXCLEXPORT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.EXCLEXPORT.Size = New System.Drawing.Size(112, 40)
        Me.EXCLEXPORT.TabIndex = 617
        Me.EXCLEXPORT.Text = "EXCEL EXPORT"
        '
        'ChkDOS
        '
        Me.ChkDOS.BackColor = System.Drawing.Color.Transparent
        Me.ChkDOS.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDOS.ForeColor = System.Drawing.Color.Black
        Me.ChkDOS.Location = New System.Drawing.Point(616, 288)
        Me.ChkDOS.Name = "ChkDOS"
        Me.ChkDOS.Size = New System.Drawing.Size(104, 32)
        Me.ChkDOS.TabIndex = 619
        Me.ChkDOS.Text = "DOS VIEW"
        Me.ChkDOS.Visible = False
        '
        'Outstandinglist
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(158, Byte), CType(188, Byte), CType(185, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(792, 622)
        Me.Controls.Add(Me.GRP1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.OPTALL)
        Me.Controls.Add(Me.OPTSTATUS)
        Me.Controls.Add(Me.OUTSTD_LST)
        Me.Controls.Add(Me.CMDVIEW)
        Me.Controls.Add(Me.CMDCLEAR)
        Me.Controls.Add(Me.CMDPRINT)
        Me.Controls.Add(Me.CMDEXIT)
        Me.Controls.Add(Me.DTPASONDATE1)
        Me.Controls.Add(Me.cbxMonth)
        Me.Controls.Add(Me.OPTSELECT)
        Me.Controls.Add(Me.CMBTYPE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Shape2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChkDOS)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "Outstandinglist"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OUTSTANDING REPORT"
        Me.GRP1.ResumeLayout(False)
        CType(Me.AxfpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As FRMOUTSTANDINGRPT
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FRMOUTSTANDINGRPT
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FRMOUTSTANDINGRPT
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FRMOUTSTANDINGRPT)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
    Private Sub cbxMonth_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cbxMonth.KeyPress
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = System.Windows.Forms.Keys.Return Then
            DTPASONDATE1.Focus()
        End If
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub CmdClear_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Call ClearOperation()
    End Sub
    Private Sub ClearOperation()
        DTPASONDATE1.Value = Now
        txtamount.Text = ""
        OPTALL.Checked = True
        CMBTYPE.Items.Clear()
        CMBTYPE.Visible = False
    End Sub
    Private Sub PrintOperation()
        Dim DT As New DataTable
        Dim I As Integer
        Dim gCompanyname As Object
        Dim gUserName As Object
        Dim adLockReadOnly As Object
        Dim adOpenDynamic As Object
        Dim MainMenu As Object
        Dim vSql As Object
        Dim vbilldate As Object
        Dim noofdays As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Randomize()
        Dim VOutputfile As String
        Dim VRowCount As Short
        Dim vMonthName As String
        Dim vCaption As String
        Dim vtype() As Object
        Dim VTYPE1 As String
        Dim vTotal As Double
        Dim vSubTotal As Double
        Dim vslcode As String
        Dim vMonthFrom As Short
        Dim vMonthTo As Short
        Dim vSubType As String
        Dim MemberType As String
        Dim MemberTotal As Double
        Dim vpageNo As Short
        Dim mdate As String
        Dim vsplit() As String
        Try
            If Mid(Me.cbxMonth.Text, 1, 5) = "April" Then
                month1 = 4
                noofdays = 30
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 3) = "May" Then
                month1 = 5
                noofdays = 31
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 3) = "Jun" Then
                month1 = 6
                noofdays = 30
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 4) = "July" Then
                month1 = 7
                noofdays = 31
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 6) = "August" Then
                month1 = 8
                noofdays = 31
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 9) = "September" Then
                month1 = 9
                noofdays = 30
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 7) = "October" Then
                month1 = 10
                noofdays = 31
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 8) = "November" Then
                month1 = 11
                noofdays = 30
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 8) = "December" Then
                month1 = 12
                noofdays = 31
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 7) = "January" Then
                month1 = 1
                noofdays = 31
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 8) = "February" Then
                month1 = 2
                noofdays = 28
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 5) = "March" Then
                month1 = 3
                noofdays = 31
                vbilldate = ""
            End If
            VOutputfile = Mid("Age" & CStr(Int(Rnd() * 5000)), 1, 8)
            mdate = Trim(noofdays & "/" & Mid(Me.cbxMonth.Text, 1, 3) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnding, 7, 4)) & "")
            If DateValue(mdate) > DTPASONDATE1.Value Then
                '   MsgBox("please check the CutoffDate", MsgBoxStyle.OKOnly, CStr(MsgBoxStyle.Critical))
                ' Call ClearOperation()
                'Exit Sub
            End If
            Dim dd As Date
            dd = Now()
            '  vCaption = "MEMBER OUTSTANDING DETAILS AS ON :" & IIf(month1 = Month(dd), Format(dd, "dd/MMM/yyyy"), Format(DTPASONDATE1.Value, "dd/MMM/yyyy"))
            '   vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(DTPASONDATE1.Value, "dd-MMM-yyyy") & "','" & mdate & "'"
            'DT = gconnection.ExcuteStoreProcedure(vSql)
            gconnection.GetValues(vSql)
            If Val(txtamount.Text) > 0 Then
                If OPTALL.Checked = True Then
                    If txtamount.Text = "" Then
                        ' vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal <> 0  ORDER BY MCODE"
                        vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal > 0  ORDER BY typeorder,prefix,orderno asc"
                    Else
                        vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal >= " & Format(Val(txtamount.Text), "0.00") & "  ORDER BY typeorder,prefix,orderno asc"
                    End If
                ElseIf OPTSELECT.Checked = True Then
                    If CMBTYPE.Text = "" Then MsgBox("PLS SELECT  MEMBER TYPE...", MsgBoxStyle.Information) : CmdClear_Click(CMDCLEAR, New System.EventArgs) : Exit Sub
                    vsplit = Split(CMBTYPE.Text, "=>")
                    VTYPE1 = vsplit(0)
                    If txtamount.Text = "" Then
                        vSql = "select mcode,SLname,clbal from outstandrpt_summary where TYPE='" & Trim(VTYPE1) & "' AND CLBAL > 0  ORDER BY typeorder,prefix,orderno asc"
                    Else
                        vSql = "select mcode,SLname,clbal from outstandrpt_summary where TYPE='" & Trim(VTYPE1) & "' AND CLBAL>= " & Format(Val(txtamount.Text), "0.00") & "  ORDER BY typeorder,prefix,orderno asc"
                    End If
                ElseIf OPTSTATUS.Checked = True Then
                    If CMBTYPE.Text = "" Then MsgBox("PLS SELECT  MEMBER STATUS...", MsgBoxStyle.Information) : CmdClear_Click(CMDCLEAR, New System.EventArgs) : Exit Sub
                    If txtamount.Text = "" Then
                        vSql = "select mcode,SLname,clbal from outstandrpt_summary where MCODE IN (SELECT MCODE FROM MEMBERMASTER WHERE CURENTSTATUS='" & CMBTYPE.Text & "') AND CLBAL > 0  ORDER BY typeorder,prefix,orderno asc"
                    Else
                        vSql = "select mcode,SLname,clbal from outstandrpt_summary where  MCODE IN (SELECT MCODE FROM MEMBERMASTER WHERE CURENTSTATUS='" & CMBTYPE.Text & "') AND CLBAL>= " & Format(Val(txtamount.Text), "0.00") & "  ORDER BY typeorder,prefix,orderno asc"
                    End If

                End If
            Else
                If OPTALL.Checked = True Then
                    vSql = "select mcode,SLname,clbal from outstandrpt_summary where isnull(clbal,0) >  0 ORDER BY typeorder,prefix,orderno asc"
                ElseIf OPTSELECT.Checked = True Then
                    If CMBTYPE.Text = "" Then MsgBox("PLS SELECT  MEMBER TYPE...", MsgBoxStyle.Information) : CmdClear_Click(CMDCLEAR, New System.EventArgs) : Exit Sub
                    vsplit = Split(CMBTYPE.Text, "=>")
                    VTYPE1 = vsplit(0)
                    vSql = "select mcode,SLname,clbal from outstandrpt_summary where TYPE='" & Trim(VTYPE1) & "'  and isnull(clbal,0) > 0  ORDER BY typeorder,prefix,orderno asc "

                ElseIf OPTSTATUS.Checked = True Then
                    If CMBTYPE.Text = "" Then MsgBox("PLS SELECT  MEMBER STATUS...", MsgBoxStyle.Information) : CmdClear_Click(CMDCLEAR, New System.EventArgs) : Exit Sub
                    If txtamount.Text = "" Then
                        vSql = "select mcode,SLname,clbal from outstandrpt_summary where MCODE IN (SELECT MCODE FROM MEMBERMASTER WHERE CURENTSTATUS='" & CMBTYPE.Text & "') AND CLBAL >0  ORDER BY typeorder,prefix,orderno asc"
                    Else
                        vSql = "select mcode,SLname,clbal from outstandrpt_summary where  MCODE IN (SELECT MCODE FROM MEMBERMASTER WHERE CURENTSTATUS='" & CMBTYPE.Text & "')   and isnull(clbal,0) > 0  ORDER BY typeorder,prefix,orderno asc"
                    End If
                End If

            End If
            DT = gconnection.GetValues(vSql)
            vpageNo = 1
            Randomize()
            vOutfile = Mid("remlt" & (Rnd() * 650000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            Filewrite.WriteLine("Member Oustanding Reports as on :" & Trim(mdate) & Space(10) & "Page No:" & Trim(CStr(vpageNo)))
            Filewrite.WriteLine(New String("-", 80))
            Filewrite.WriteLine("|Sno   |Mcode     |               Mname                    |      Amount |")
            Filewrite.WriteLine(New String("-", 80))
            If DT.Rows.Count > 0 Then
                Dim sno As Long
                sno = 0
                For I = 0 To DT.Rows.Count - 1
                    sno = sno + 1
                    Filewrite.Write("|" & Space(6 - Len(Mid(sno, 1, 5))) & Mid(sno, 1, 5) & " |")
                    Filewrite.Write(Mid(Trim(DT.Rows(I).Item("Mcode") & ""), 1, 10) & Space(10 - Len(Mid(Trim(DT.Rows(I).Item("Mcode") & ""), 1, 10))) & "|")
                    Filewrite.Write(Mid(Trim(DT.Rows(I).Item("SLname") & ""), 1, 30) & Space(40 - Len(Mid(Trim(DT.Rows(I).Item("SLname") & ""), 1, 30))) & "|")
                    Filewrite.WriteLine(Space(13 - Len(Format(Val(DT.Rows(I).Item("CLBAL") & ""), "0.00"))) & Format(Val(DT.Rows(I).Item("CLBAL") & ""), "0.00") & "|")
                    vSubTotal = Val(CStr(vSubTotal)) + Val(DT.Rows(I).Item("CLBAL") & "")
                    VRowCount = VRowCount + 1
                    If Val(CStr(VRowCount)) > 55 Then
                        vpageNo = vpageNo + 1
                        Filewrite.WriteLine(New String("-", 80) & Chr(12))
                        Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                        Filewrite.WriteLine("Member Oustanding Reports as on :" & Trim(mdate) & Space(10) & "Page No:" & Trim(CStr(vpageNo)))
                        Filewrite.WriteLine(New String("-", 80))
                        Filewrite.WriteLine("|Sno   |Mcode     |               Mname                    |      Amount |")
                        Filewrite.WriteLine(New String("-", 80))
                        VRowCount = 1
                    End If
                Next
                Filewrite.WriteLine(New String("-", 80))
                Filewrite.WriteLine(Space(40) & "Total     " & Space(11) & Space(13 - Len(Format(Val(CStr(vSubTotal)), "0.00"))) & Format(Val(CStr(vSubTotal)), "0.00"))
                Filewrite.WriteLine(New String("-", 80))
                vSubTotal = 0
            End If
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Exit Sub
    End Sub
    Private Sub OPTSELECT_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OPTSELECT.Click
        If OPTSELECT.Checked Then
            CMBTYPE.Visible = True
            CMBTYPE.Items.Clear()
            Dim strsql As String
            Dim DT As DataTable
            strsql = "SELECT  MEMBERTYPE + '=>' + TYPEDESC AS MTYPE FROM MEMBERTYPE ORDER BY MEMBERTYPE"
            DT = gconnection.GetValues(strsql)
            If DT.Rows.Count - 1 Then
                For I = 0 To DT.Rows.Count - 1
                    CMBTYPE.Items.Add(CStr(DT.Rows(I).Item("MTYPE")))
                Next
            End If
        End If
    End Sub
    Private Sub OPTALL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OPTALL.Click
        If OPTALL.Checked Then
            CMBTYPE.Visible = False
        End If
    End Sub
    Private Sub FRMOUTSTANDINGRPT_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            Call ClearOperation()
        End If
        If e.KeyCode = Keys.F9 Then
            Call CmdView_Click(CMDVIEW, New System.EventArgs)
        End If
        If e.KeyCode = Keys.F10 Then
            Call CmdPrint_Click(CMDPRINT, New System.EventArgs)
        End If
        If e.KeyCode = Keys.F11 Then
            Call CmdExit_Click(CMDEXIT, New System.EventArgs)
        End If
        If e.KeyCode = Keys.Escape Then
            If MsgBoxResult.OK = MsgBox("Close This Form", MsgBoxStyle.OKCancel + MsgBoxStyle.Information, Me.Text) Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub FRMOUTSTANDINGRPT_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GRP1.Visible = False
        AxfpSpread1.Visible = False
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        DTPASONDATE1.Value = Now
    End Sub
    Private Sub DTPASONDATE1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DTPASONDATE1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtamount.Focus()
        End If
    End Sub

    Private Sub FRMOUTSTANDINGRPT_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave

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
        Me.CMDVIEW.Enabled = False
        Me.CMDPRINT.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CMDVIEW.Enabled = True
                    Me.CMDPRINT.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.CMDVIEW.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.CMDPRINT.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub CMDVIEW_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDVIEW.Click
        PRINTREP = False
        If ChkDOS.Checked = True Then
            If OUTSTD_LST.Checked = True Then
                Call PRINTOUTSTANDOPERATION()
            Else
                Call PrintOperation()
            End If
        Else

            Call MEMBERLISTEXCEL()
        End If


    End Sub

    Public Sub MEMBERLISTEXCEL()
        Dim DT As New DataTable
        Dim I As Integer
        Dim gCompanyname As Object
        Dim gUserName As Object
        Dim adLockReadOnly As Object
        Dim adOpenDynamic As Object
        Dim MainMenu As Object
        Dim vSql As Object
        Dim vbilldate As Object
        Dim noofdays As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Randomize()
        Dim VOutputfile As String
        Dim VRowCount As Short
        Dim vMonthName As String
        Dim vCaption As String
        Dim vtype() As Object
        Dim VTYPE1 As String
        Dim vTotal As Double
        Dim vSubTotal As Double
        Dim vslcode As String
        Dim vMonthFrom As Short
        Dim vMonthTo As Short
        Dim vSubType As String
        Dim MemberType As String
        Dim MemberTotal As Double
        Dim vpageNo As Short
        Dim mdate As String
        Dim vsplit() As String
        If Mid(Me.cbxMonth.Text, 1, 5) = "April" Then
            month1 = 4
            noofdays = 30
            vbilldate = ""
        End If
        If Mid(Me.cbxMonth.Text, 1, 3) = "May" Then
            month1 = 5
            noofdays = 31
            vbilldate = ""
        End If
        If Mid(Me.cbxMonth.Text, 1, 3) = "Jun" Then
            month1 = 6
            noofdays = 30
            vbilldate = ""
        End If
        If Mid(Me.cbxMonth.Text, 1, 4) = "July" Then
            month1 = 7
            noofdays = 31
            vbilldate = ""
        End If
        If Mid(Me.cbxMonth.Text, 1, 6) = "August" Then
            month1 = 8
            noofdays = 31
            vbilldate = ""
        End If
        If Mid(Me.cbxMonth.Text, 1, 9) = "September" Then
            month1 = 9
            noofdays = 30
            vbilldate = ""
        End If
        If Mid(Me.cbxMonth.Text, 1, 7) = "October" Then
            month1 = 10
            noofdays = 31
            vbilldate = ""
        End If
        If Mid(Me.cbxMonth.Text, 1, 8) = "November" Then
            month1 = 11
            noofdays = 30
            vbilldate = ""
        End If
        If Mid(Me.cbxMonth.Text, 1, 8) = "December" Then
            month1 = 12
            noofdays = 31
            vbilldate = ""
        End If
        If Mid(Me.cbxMonth.Text, 1, 7) = "January" Then
            month1 = 1
            noofdays = 31
            vbilldate = ""
        End If
        If Mid(Me.cbxMonth.Text, 1, 8) = "February" Then
            month1 = 2
            noofdays = 28
            vbilldate = ""
        End If
        If Mid(Me.cbxMonth.Text, 1, 5) = "March" Then
            month1 = 3
            noofdays = 31
            vbilldate = ""
        End If
        VOutputfile = Mid("Age" & CStr(Int(Rnd() * 5000)), 1, 8)
        mdate = Trim(noofdays & "/" & Mid(Me.cbxMonth.Text, 1, 3) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnding, 7, 4)) & "")
        If DateValue(mdate) > DTPASONDATE1.Value Then
            '   MsgBox("please check the CutoffDate", MsgBoxStyle.OKOnly, CStr(MsgBoxStyle.Critical))
            ' Call ClearOperation()
            'Exit Sub
        End If
        Dim dd As Date
        dd = Now()
        vCaption = "MEMBER OUTSTANDING DETAILS AS ON :" & IIf(month1 = Month(dd), Format(dd, "dd/MMM/yyyy"), Format(DTPASONDATE1.Value, "dd/MMM/yyyy"))
        vSql = "EXEC TP_OUTSTANDING_SUMMARY  " & "'" & Format(DTPASONDATE1.Value, "dd-MMM-yyyy") & "','" & mdate & "'"
        'DT = gconnection.ExcuteStoreProcedure(vSql)
        gconnection.GetValues(vSql)
        If Val(txtamount.Text) > 0 Then
            If OPTALL.Checked = True Then
                If txtamount.Text = "" Then
                    vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal > 0  ORDER BY typeorder,prefix,orderno asc"
                Else
                    vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal >= " & Format(Val(txtamount.Text), "0.00") & "  ORDER BY typeorder,prefix,orderno asc"
                End If
            ElseIf OPTSELECT.Checked = True Then
                If CMBTYPE.Text = "" Then MsgBox("PLS SELECT  MEMBER TYPE...", MsgBoxStyle.Information) : CmdClear_Click(CMDCLEAR, New System.EventArgs) : Exit Sub
                vsplit = Split(CMBTYPE.Text, "=>")
                VTYPE1 = vsplit(0)
                If txtamount.Text = "" Then
                    vSql = "select mcode,SLname,clbal from outstandrpt_summary where TYPE='" & Trim(VTYPE1) & "' AND CLBAL >0  ORDER BY typeorder,prefix,orderno asc"
                Else
                    vSql = "select mcode,SLname,clbal from outstandrpt_summary where TYPE='" & Trim(VTYPE1) & "' AND CLBAL>= " & Format(Val(txtamount.Text), "0.00") & "  ORDER BY typeorder,prefix,orderno asc"
                End If
            ElseIf OPTSTATUS.Checked = True Then
                If CMBTYPE.Text = "" Then MsgBox("PLS SELECT  MEMBER STATUS...", MsgBoxStyle.Information) : CmdClear_Click(CMDCLEAR, New System.EventArgs) : Exit Sub
                If txtamount.Text = "" Then
                    vSql = "select mcode,SLname,clbal from outstandrpt_summary where MCODE IN (SELECT MCODE FROM MEMBERMASTER WHERE CURENTSTATUS='" & CMBTYPE.Text & "') AND CLBAL >0  ORDER BY typeorder,prefix,orderno asc"
                Else
                    vSql = "select mcode,SLname,clbal from outstandrpt_summary where  MCODE IN (SELECT MCODE FROM MEMBERMASTER WHERE CURENTSTATUS='" & CMBTYPE.Text & "') AND CLBAL>= " & Format(Val(txtamount.Text), "0.00") & "  ORDER BY typeorder,prefix,orderno asc"
                End If

            End If
        Else
            If OPTALL.Checked = True Then
                vSql = "select mcode,SLname,clbal from outstandrpt_summary where isnull(clbal,0)  > 0 ORDER BY typeorder,prefix,orderno asc"
            ElseIf OPTSELECT.Checked = True Then
                If CMBTYPE.Text = "" Then MsgBox("PLS SELECT  MEMBER TYPE...", MsgBoxStyle.Information) : CmdClear_Click(CMDCLEAR, New System.EventArgs) : Exit Sub
                vsplit = Split(CMBTYPE.Text, "=>")
                VTYPE1 = vsplit(0)
                vSql = "select mcode,SLname,clbal from outstandrpt_summary where TYPE='" & Trim(VTYPE1) & "'  and isnull(clbal,0) > 0  ORDER BY typeorder,prefix,orderno asc "

            ElseIf OPTSTATUS.Checked = True Then
                If CMBTYPE.Text = "" Then MsgBox("PLS SELECT  MEMBER STATUS...", MsgBoxStyle.Information) : CmdClear_Click(CMDCLEAR, New System.EventArgs) : Exit Sub
                If txtamount.Text = "" Then
                    vSql = "select mcode,SLname,clbal from outstandrpt_summary where MCODE IN (SELECT MCODE FROM MEMBERMASTER WHERE CURENTSTATUS='" & CMBTYPE.Text & "') AND CLBAL >0  ORDER BY typeorder,prefix,orderno asc"
                Else
                    vSql = "select mcode,SLname,clbal from outstandrpt_summary where  MCODE IN (SELECT MCODE FROM MEMBERMASTER WHERE CURENTSTATUS='" & CMBTYPE.Text & "')   and isnull(clbal,0) > 0  ORDER BY typeorder,prefix,orderno asc"
                End If
            End If

        End If
        Dim j As Integer
        j = 0
        GRP1.Visible = True
        AxfpSpread1.Visible = True
        AxfpSpread1.ClearRange(1, 1, -1, -1, True)
        gconnection.getDataSet(vSql, "SALEREGISTERSUMMARY")
        If gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count > 0 Then
            For I = 1 To gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count
                AxfpSpread1.SetText(1, I, UCase(CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mcode"))) & "")
                AxfpSpread1.SetText(2, I, UCase(CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("SLname"))) & "")
                AxfpSpread1.SetText(3, I, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("clbal")) & "")
                j = j + 1
            Next I
        Else
            MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
    End Sub

    Private Sub PRINTOUTSTANDOPERATION()
        Dim DT As New DataTable
        Dim I As Integer
        Dim gCompanyname As Object
        Dim gUserName As Object
        Dim adLockReadOnly As Object
        Dim adOpenDynamic As Object
        Dim MainMenu As Object
        Dim vSql As Object
        Dim vbilldate As Object
        Dim noofdays As Object
        Dim month1 As Object
        Dim Loopindex As Object
        Randomize()
        Dim VOutputfile As String
        Dim VRowCount As Short
        Dim vMonthName As String
        Dim vCaption As String
        Dim vtype() As Object
        Dim VTYPE1 As String
        Dim vTotal As Double
        Dim vSubTotal As Double
        Dim vslcode As String
        Dim vMonthFrom As Short
        Dim vMonthTo As Short
        Dim vSubType As String
        Dim MemberType As String
        Dim MemberTotal As Double
        Dim vpageNo As Short
        Dim mdate As String
        Dim vsplit() As String
        Try
            If Mid(Me.cbxMonth.Text, 1, 5) = "April" Then
                month1 = 4
                noofdays = 30
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 3) = "May" Then
                month1 = 5
                noofdays = 31
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 3) = "Jun" Then
                month1 = 6
                noofdays = 30
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 4) = "July" Then
                month1 = 7
                noofdays = 31
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 6) = "August" Then
                month1 = 8
                noofdays = 31
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 9) = "September" Then
                month1 = 9
                noofdays = 30
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 7) = "October" Then
                month1 = 10
                noofdays = 31
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 8) = "November" Then
                month1 = 11
                noofdays = 30
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 8) = "December" Then
                month1 = 12
                noofdays = 31
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 7) = "January" Then
                month1 = 1
                noofdays = 31
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 8) = "February" Then
                month1 = 2
                noofdays = 28
                vbilldate = ""
            End If
            If Mid(Me.cbxMonth.Text, 1, 5) = "March" Then
                month1 = 3
                noofdays = 31
                vbilldate = ""
            End If
            VOutputfile = Mid("Age" & CStr(Int(Rnd() * 5000)), 1, 8)
            mdate = Trim(noofdays & "/" & Mid(Me.cbxMonth.Text, 1, 3) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnding, 7, 4)) & "")
            If DateValue(mdate) > DTPASONDATE1.Value Then
                '   MsgBox("please check the CutoffDate", MsgBoxStyle.OKOnly, CStr(MsgBoxStyle.Critical))
                ' Call ClearOperation()
                'Exit Sub
            End If
            Dim dd As Date
            dd = Now()
            vCaption = "MEMBER OUTSTANDING DETAILS AS ON :" & IIf(month1 = Month(dd), Format(dd, "dd/MMM/yyyy"), Format(DTPASONDATE1.Value, "dd/MMM/yyyy"))
            vSql = "EXEC TP_OUTSTANDING_SUMMARY_list  '" & mdate & "'"
            'DT = gconnection.ExcuteStoreProcedure(vSql)
            gconnection.GetValues(vSql)
            'If Val(txtamount.Text) > 0 Then
            '    If OPTALL.Checked = True Then
            '        If txtamount.Text = "" Then
            '            vSql = "select mcode,SLname,clbal from outstandrpt_summary_list where clbal <> 0  ORDER BY MCODE"
            '        Else
            '            vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal >= " & Format(Val(txtamount.Text), "0.00") & "  ORDER BY MCODE"
            '        End If
            '    Else
            '        If CMBTYPE.Text = "" Then MsgBox("PLS SELECT  MEMBER TYPE...", MsgBoxStyle.Information) : CmdClear_Click(CMDCLEAR, New System.EventArgs) : Exit Sub
            '        vsplit = Split(CMBTYPE.Text, "=>")
            '        VTYPE1 = vsplit(0)
            '        If txtamount.Text = "" Then
            '            vSql = "select mcode,SLname,clbal from outstandrpt_summary where TYPE='" & Trim(VTYPE1) & "' AND CLBAL<>0  ORDER BY MCODE"
            '        Else
            '            vSql = "select mcode,SLname,clbal from outstandrpt_summary where TYPE='" & Trim(VTYPE1) & "' AND CLBAL>= " & Format(Val(txtamount.Text), "0.00") & "  ORDER BY MCODE"
            '        End If
            '    End If
            'Else
            '    If OPTALL.Checked = True Then
            vSql = "select mcode,SLname,OpAmountbal,PayAmount,receiptAmt,Closingbal from outstandrpt_summary_list where Closingbal >= 10000 and type not in('AFC') ORDER BY typeorder,prefix,orderno asc"

            '    Else
            '        If CMBTYPE.Text = "" Then MsgBox("PLS SELECT  MEMBER TYPE...", MsgBoxStyle.Information) : CmdClear_Click(CMDCLEAR, New System.EventArgs) : Exit Sub
            '        vsplit = Split(CMBTYPE.Text, "=>")
            '        VTYPE1 = vsplit(0)
            '        vSql = "select mcode,SLname,clbal from outstandrpt_summary where TYPE='" & Trim(VTYPE1) & "'  and isnull(clbal,0) <> 0  ORDER BY MCODE "
            '    End If
            'End If
            DT = gconnection.GetValues(vSql)
            vpageNo = 1
            Randomize()
            vOutfile = Mid("remlt" & (Rnd() * 650000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            Filewrite.Write("Member Oustanding Reports as on :" & Trim(mdate) & Space(10) & "Page No:" & Trim(CStr(vpageNo)))
            Filewrite.WriteLine(Space(23) & "As On  :" & Format(Now, "dd/MMM/yyyy"))
            Filewrite.WriteLine(New String("-", 105))
            Filewrite.WriteLine("|Sno    |Mcode     |Mname                       |OUTSTANDING AS | USAGE AFTER |RECEIPT AFTER|      Amount |")
            Filewrite.Write(Space(48) & "|ON")
            Filewrite.Write("" & Space(12 - Len(Mid(mdate, 1, 12))) & Mid(mdate, 1, 12))
            Filewrite.Write(" |" & Space(12 - Len(Mid(mdate, 1, 12))) & Mid(mdate, 1, 12))
            Filewrite.WriteLine(" |" & Space(12 - Len(Mid(mdate, 1, 12))) & Mid(mdate, 1, 12) & " |")
            Filewrite.WriteLine(New String("-", 105))
            If DT.Rows.Count > 0 Then
                Dim sno As Long
                sno = 0
                For I = 0 To DT.Rows.Count - 1
                    sno = sno + 1
                    Filewrite.Write("|" & Space(6 - Len(Mid(sno, 1, 5))) & Mid(sno, 1, 5) & " |")
                    Filewrite.Write(Mid(Trim(DT.Rows(I).Item("Mcode") & ""), 1, 10) & Space(10 - Len(Mid(Trim(DT.Rows(I).Item("Mcode") & ""), 1, 10))) & "|")
                    Filewrite.Write(Mid(Trim(DT.Rows(I).Item("SLname") & ""), 1, 20) & Space(28 - Len(Mid(Trim(DT.Rows(I).Item("SLname") & ""), 1, 20))) & "|")
                    Filewrite.Write(Space(15 - Len(Format(Val(DT.Rows(I).Item("OpAmountbal") & ""), "0.00"))) & Format(Val(DT.Rows(I).Item("OpAmountbal") & ""), "0.00") & "|")
                    Filewrite.Write(Space(13 - Len(Format(Val(DT.Rows(I).Item("PayAmount") & ""), "0.00"))) & Format(Val(DT.Rows(I).Item("PayAmount") & ""), "0.00") & "|")
                    Filewrite.Write(Space(13 - Len(Format(Val(DT.Rows(I).Item("receiptAmt") & ""), "0.00"))) & Format(Val(DT.Rows(I).Item("receiptAmt") & ""), "0.00") & "|")
                    Filewrite.WriteLine(Space(13 - Len(Format(Val(DT.Rows(I).Item("Closingbal") & ""), "0.00"))) & Format(Val(DT.Rows(I).Item("Closingbal") & ""), "0.00") & "|")
                    vSubTotal = Val(CStr(vSubTotal)) + Val(DT.Rows(I).Item("Closingbal") & "")
                    VRowCount = VRowCount + 1
                    If Val(CStr(VRowCount)) > 35 Then
                        vpageNo = vpageNo + 1
                        Filewrite.WriteLine(New String("-", 105) & Chr(12))
                        Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                        Filewrite.WriteLine("Member 10,000 Oustanding Reports as on :" & Trim(mdate) & Space(10) & "Page No:" & Trim(CStr(vpageNo)))
                        Filewrite.WriteLine(New String("-", 105))
                        Filewrite.WriteLine("|Sno    |Mcode     |Mname                       |OUTSTANDING AS | USAGE AFTER |RECEIPT AFTER|      Amount |")
                        Filewrite.Write(Space(48) & "|ON")
                        Filewrite.Write("" & Space(12 - Len(Mid(mdate, 1, 12))) & Mid(mdate, 1, 12))
                        Filewrite.Write(" |" & Space(12 - Len(Mid(mdate, 1, 12))) & Mid(mdate, 1, 12))
                        Filewrite.WriteLine(" |" & Space(12 - Len(Mid(mdate, 1, 12))) & Mid(mdate, 1, 12) & " |")
                        Filewrite.WriteLine(New String("-", 105))
                        VRowCount = 1
                    End If
                Next
                Filewrite.WriteLine(New String("-", 105))
                Filewrite.WriteLine(Space(72) & "Total     " & Space(11) & Space(13 - Len(Format(Val(CStr(vSubTotal)), "0.00"))) & Format(Val(CStr(vSubTotal)), "0.00"))
                Filewrite.WriteLine(New String("-", 105))
                vSubTotal = 0
            End If
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Exit Sub
    End Sub



    Private Sub CMDPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPRINT.Click
        PRINTREP = True
        Call PrintOperation()
    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Me.Close()
    End Sub


    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub CMBTYPE_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMBTYPE.SelectedIndexChanged

    End Sub

    Private Sub OPTSELECT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPTSELECT.CheckedChanged

    End Sub

    Private Sub OPTSTATUS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OPTSTATUS.CheckedChanged

    End Sub

    Private Sub OPTSTATUS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles OPTSTATUS.Click
        If OPTSTATUS.Checked Then
            CMBTYPE.Visible = True
            CMBTYPE.Items.Clear()
            Dim strsql As String
            Dim DT As DataTable
            strsql = "SELECT  DISTINCT CURENTSTATUS FROM MEMBERMASTER "
            DT = gconnection.GetValues(strsql)
            If DT.Rows.Count - 1 Then
                For I = 0 To DT.Rows.Count - 1
                    CMBTYPE.Items.Add(CStr(DT.Rows(I).Item("CURENTSTATUS")))
                Next
            End If
        End If
    End Sub

    Private Sub GRP1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRP1.Enter

    End Sub

    Private Sub GRP_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRP_EXIT.Click
        GRP1.Visible = False
        AxfpSpread1.Visible = False
        AxfpSpread1.ClearRange(1, 1, -1, -1, True)
    End Sub

    Private Sub EXCLEXPORT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EXCLEXPORT.Click
        Try
            If AxfpSpread1.Visible = True Then
                Call ExportTo(AxfpSpread1)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub AxfpSpread1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles AxfpSpread1.Advance

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
