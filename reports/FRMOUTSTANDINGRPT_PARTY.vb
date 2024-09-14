Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Friend Class FRMOUTSTANDINGRPT_PARTY
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
    Public WithEvents txtamount As System.Windows.Forms.TextBox
    Public WithEvents OPTALL As System.Windows.Forms.RadioButton
    Public WithEvents OPTSELECT As System.Windows.Forms.RadioButton
    Public WithEvents CMBTYPE As System.Windows.Forms.ComboBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Shape1 As System.Windows.Forms.Label
    Public WithEvents Shape2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DTPASONDATE1 As System.Windows.Forms.DateTimePicker
    Public WithEvents CMDCLEAR As System.Windows.Forms.Button
    Public WithEvents CMDPRINT As System.Windows.Forms.Button
    Public WithEvents CMDEXIT As System.Windows.Forms.Button
    Public WithEvents CMDVIEW As System.Windows.Forms.Button
    Friend WithEvents cbxMonth As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRMOUTSTANDINGRPT_PARTY))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtamount = New System.Windows.Forms.TextBox
        Me.OPTALL = New System.Windows.Forms.RadioButton
        Me.CMBTYPE = New System.Windows.Forms.ComboBox
        Me.CMDCLEAR = New System.Windows.Forms.Button
        Me.CMDPRINT = New System.Windows.Forms.Button
        Me.CMDEXIT = New System.Windows.Forms.Button
        Me.CMDVIEW = New System.Windows.Forms.Button
        Me.OPTSELECT = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Shape1 = New System.Windows.Forms.Label
        Me.Shape2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.DTPASONDATE1 = New System.Windows.Forms.DateTimePicker
        Me.cbxMonth = New System.Windows.Forms.DateTimePicker
        Me.SuspendLayout()
        '
        'txtamount
        '
        Me.txtamount.AcceptsReturn = True
        Me.txtamount.AutoSize = False
        Me.txtamount.BackColor = System.Drawing.SystemColors.Window
        Me.txtamount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtamount.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtamount.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(0, Byte), CType(0, Byte))
        Me.txtamount.Location = New System.Drawing.Point(296, 168)
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
        Me.OPTALL.Location = New System.Drawing.Point(208, 240)
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
        Me.CMBTYPE.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMBTYPE.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CMBTYPE.Location = New System.Drawing.Point(248, 280)
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
        Me.CMDCLEAR.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDCLEAR.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CMDCLEAR.Location = New System.Drawing.Point(64, 360)
        Me.CMDCLEAR.Name = "CMDCLEAR"
        Me.CMDCLEAR.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMDCLEAR.Size = New System.Drawing.Size(112, 36)
        Me.CMDCLEAR.TabIndex = 8
        Me.CMDCLEAR.Text = "&CLEAR  [F12]"
        Me.ToolTip1.SetToolTip(Me.CMDCLEAR, "To Clear the content of this form, click or Press ALT+C or press F12")
        '
        'CMDPRINT
        '
        Me.CMDPRINT.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.CMDPRINT.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMDPRINT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDPRINT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CMDPRINT.Location = New System.Drawing.Point(368, 360)
        Me.CMDPRINT.Name = "CMDPRINT"
        Me.CMDPRINT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMDPRINT.Size = New System.Drawing.Size(104, 36)
        Me.CMDPRINT.TabIndex = 7
        Me.CMDPRINT.Text = "&PRINT [F10]"
        Me.ToolTip1.SetToolTip(Me.CMDPRINT, "To Print  the result in report format, click or Press ALT+P or press F9")
        '
        'CMDEXIT
        '
        Me.CMDEXIT.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.CMDEXIT.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMDEXIT.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDEXIT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CMDEXIT.Location = New System.Drawing.Point(512, 360)
        Me.CMDEXIT.Name = "CMDEXIT"
        Me.CMDEXIT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMDEXIT.Size = New System.Drawing.Size(96, 36)
        Me.CMDEXIT.TabIndex = 9
        Me.CMDEXIT.Text = "&EXIT [F11]"
        Me.ToolTip1.SetToolTip(Me.CMDEXIT, "To Close this form, click or Press ALT+E or press F11")
        '
        'CMDVIEW
        '
        Me.CMDVIEW.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(192, Byte))
        Me.CMDVIEW.Cursor = System.Windows.Forms.Cursors.Default
        Me.CMDVIEW.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDVIEW.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CMDVIEW.Location = New System.Drawing.Point(216, 360)
        Me.CMDVIEW.Name = "CMDVIEW"
        Me.CMDVIEW.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CMDVIEW.Size = New System.Drawing.Size(112, 36)
        Me.CMDVIEW.TabIndex = 6
        Me.CMDVIEW.Text = "&VIEW  [F6]"
        Me.ToolTip1.SetToolTip(Me.CMDVIEW, "To Clear the content of this form, click or Press ALT+C or press F12")
        '
        'OPTSELECT
        '
        Me.OPTSELECT.BackColor = System.Drawing.Color.FromArgb(CType(158, Byte), CType(188, Byte), CType(185, Byte))
        Me.OPTSELECT.Cursor = System.Windows.Forms.Cursors.Default
        Me.OPTSELECT.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OPTSELECT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.OPTSELECT.Location = New System.Drawing.Point(280, 240)
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
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(192, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(87, 21)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "AMOUNT : "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(208, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(76, 21)
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
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(312, 240)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(133, 21)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "SELECTED TYPE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(232, 240)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(36, 21)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "ALL"
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.Color.Transparent
        Me.Shape1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Shape1.Location = New System.Drawing.Point(32, 352)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(608, 56)
        Me.Shape1.TabIndex = 17
        '
        'Shape2
        '
        Me.Shape2.BackColor = System.Drawing.Color.Transparent
        Me.Shape2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Shape2.Location = New System.Drawing.Point(88, 72)
        Me.Shape2.Name = "Shape2"
        Me.Shape2.Size = New System.Drawing.Size(472, 256)
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(96, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(490, 35)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "PARTY  OUTSTANDING  SUMMARY "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(152, 136)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(133, 21)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "CUT OFF DATE : "
        '
        'DTPASONDATE1
        '
        Me.DTPASONDATE1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTPASONDATE1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DTPASONDATE1.Location = New System.Drawing.Point(296, 128)
        Me.DTPASONDATE1.Name = "DTPASONDATE1"
        Me.DTPASONDATE1.Size = New System.Drawing.Size(144, 25)
        Me.DTPASONDATE1.TabIndex = 1
        '
        'cbxMonth
        '
        Me.cbxMonth.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.cbxMonth.Location = New System.Drawing.Point(296, 96)
        Me.cbxMonth.Name = "cbxMonth"
        Me.cbxMonth.Size = New System.Drawing.Size(144, 25)
        Me.cbxMonth.TabIndex = 21
        '
        'FRMOUTSTANDINGRPT_PARTY
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(158, Byte), CType(188, Byte), CType(185, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(680, 446)
        Me.Controls.Add(Me.cbxMonth)
        Me.Controls.Add(Me.CMDVIEW)
        Me.Controls.Add(Me.CMDCLEAR)
        Me.Controls.Add(Me.CMDPRINT)
        Me.Controls.Add(Me.CMDEXIT)
        Me.Controls.Add(Me.DTPASONDATE1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.OPTALL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.OPTSELECT)
        Me.Controls.Add(Me.CMBTYPE)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Shape1)
        Me.Controls.Add(Me.Shape2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Location = New System.Drawing.Point(4, 30)
        Me.Name = "FRMOUTSTANDINGRPT_PARTY"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PARTY  OUTSTANDING REPORT"
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support "
    Private Shared m_vb6FormDefInstance As FRMOUTSTANDINGRPT_PARTY
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As FRMOUTSTANDINGRPT_PARTY
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New FRMOUTSTANDINGRPT_PARTY
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As FRMOUTSTANDINGRPT_PARTY)
            m_vb6FormDefInstance = Value
        End Set
    End Property
#End Region
    Private Sub cbxMonth_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
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
            'If Mid(Me.cbxMonth.Text, 1, 5) = "April" Then
            '    month1 = 4
            '    noofdays = 30
            '    vbilldate = ""
            'End If
            'If Mid(Me.cbxMonth.Text, 1, 3) = "May" Then
            '    month1 = 5
            '    noofdays = 31
            '    vbilldate = ""
            'End If
            'If Mid(Me.cbxMonth.Text, 1, 3) = "Jun" Then
            '    month1 = 6
            '    noofdays = 30
            '    vbilldate = ""
            'End If
            'If Mid(Me.cbxMonth.Text, 1, 4) = "July" Then
            '    month1 = 7
            '    noofdays = 31
            '    vbilldate = ""
            'End If
            'If Mid(Me.cbxMonth.Text, 1, 6) = "August" Then
            '    month1 = 8
            '    noofdays = 31
            '    vbilldate = ""
            'End If
            'If Mid(Me.cbxMonth.Text, 1, 9) = "September" Then
            '    month1 = 9
            '    noofdays = 30
            '    vbilldate = ""
            'End If
            'If Mid(Me.cbxMonth.Text, 1, 7) = "October" Then
            '    month1 = 10
            '    noofdays = 31
            '    vbilldate = ""
            'End If
            'If Mid(Me.cbxMonth.Text, 1, 8) = "November" Then
            '    month1 = 11
            '    noofdays = 30
            '    vbilldate = ""
            'End If
            'If Mid(Me.cbxMonth.Text, 1, 8) = "December" Then
            '    month1 = 12
            '    noofdays = 31
            '    vbilldate = ""
            'End If
            'If Mid(Me.cbxMonth.Text, 1, 7) = "January" Then
            '    month1 = 1
            '    noofdays = 31
            '    vbilldate = ""
            'End If
            'If Mid(Me.cbxMonth.Text, 1, 8) = "February" Then
            '    month1 = 2
            '    noofdays = 28
            '    vbilldate = ""
            'End If
            'If Mid(Me.cbxMonth.Text, 1, 5) = "March" Then
            '    month1 = 3
            '    noofdays = 31
            '    vbilldate = ""
            'End If
            VOutputfile = Mid("Age" & CStr(Int(Rnd() * 5000)), 1, 8)
            'mdate = Trim(noofdays & "/" & Mid(Me.cbxMonth.Text, 1, 3) & "/" & IIf(month1 > 3, Mid(gFinancialyearStart, 7, 4), Mid(gFinancialyearEnding, 7, 4)) & "")
            'If DateValue(mdate) > DTPASONDATE1.Value Then
            '    '   MsgBox("please check the CutoffDate", MsgBoxStyle.OKOnly, CStr(MsgBoxStyle.Critical))
            '    ' Call ClearOperation()
            '    'Exit Sub
            'End If
            Dim dd As Date
            dd = Now()
            vCaption = "PARTY OUTSTANDING DETAILS AS ON :" & IIf(Month(cbxMonth.Value) = Month(dd), Format(dd, "dd/MMM/yyyy"), Format(DTPASONDATE1.Value, "dd/MMM/yyyy"))
            vSql = " EXEC TP_OUTSTANDING_SUMMARY_PARTY " & "'" & Format(DTPASONDATE1.Value, "dd-MMM-yyyy") & "','" & Format(cbxMonth.Value, "dd-MMM-yyyy") & "'"
            'DT = gconnection.ExcuteStoreProcedure(vSql)
            gconnection.GetValues(vSql)
            If Val(txtamount.Text) > 0 Then
                If OPTALL.Checked = True Then
                    If txtamount.Text = "" Then
                        vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal <> 0  ORDER BY MCODE"
                    Else
                        vSql = "select mcode,SLname,clbal from outstandrpt_summary where clbal >= " & Format(Val(txtamount.Text), "0.00") & "  ORDER BY MCODE"
                    End If
                Else
                    If CMBTYPE.Text = "" Then MsgBox("PLS SELECT  MEMBER TYPE...", MsgBoxStyle.Information) : CmdClear_Click(CMDCLEAR, New System.EventArgs) : Exit Sub
                    vsplit = Split(CMBTYPE.Text, "=>")
                    VTYPE1 = vsplit(0)
                    If txtamount.Text = "" Then
                        vSql = "select mcode,SLname,clbal from outstandrpt_summary where TYPE='" & Trim(VTYPE1) & "' AND CLBAL<>0  ORDER BY MCODE"
                    Else
                        vSql = "select mcode,SLname,clbal from outstandrpt_summary where TYPE='" & Trim(VTYPE1) & "' AND CLBAL>= " & Format(Val(txtamount.Text), "0.00") & "  ORDER BY MCODE"
                    End If
                End If
            Else
                If OPTALL.Checked = True Then
                    vSql = "select mcode,SLname,clbal from outstandrpt_summary where isnull(clbal,0) <> 0 ORDER BY MCODE"
                Else
                    If CMBTYPE.Text = "" Then MsgBox("PLS SELECT  MEMBER TYPE...", MsgBoxStyle.Information) : CmdClear_Click(CMDCLEAR, New System.EventArgs) : Exit Sub
                    vsplit = Split(CMBTYPE.Text, "=>")
                    VTYPE1 = vsplit(0)
                    vSql = "select mcode,SLname,clbal from outstandrpt_summary where TYPE='" & Trim(VTYPE1) & "'  and isnull(clbal,0) <> 0  ORDER BY MCODE "
                End If
            End If

            DT = gconnection.GetValues(vSql)
            vpageNo = 1
            Randomize()
            vOutfile = Mid("remlt" & (Rnd() * 650000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            Filewrite.WriteLine("Party Oustanding Reports as on :" & Trim(mdate) & Space(10) & "Page No:" & Trim(CStr(vpageNo)))
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
                        Filewrite.WriteLine("Party Oustanding Reports as on :" & Trim(mdate) & Space(10) & "Page No:" & Trim(CStr(vpageNo)))
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
    Private Sub FRMOUTSTANDINGRPT_PARTY_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            Call ClearOperation()
        End If
        If e.KeyCode = Keys.F9 Then
            Call CMDVIEW_Click(CMDVIEW, New System.EventArgs)
        End If
        If e.KeyCode = Keys.F10 Then
            Call CMDPRINT_Click(CMDPRINT, New System.EventArgs)
        End If
        If e.KeyCode = Keys.F11 Then
            Call CMDEXIT_Click(CMDEXIT, New System.EventArgs)
        End If
        If e.KeyCode = Keys.Escape Then
            If MsgBoxResult.OK = MsgBox("Close This Form", MsgBoxStyle.OKCancel + MsgBoxStyle.Information, Me.Text) Then
                Me.Close()
            End If
        End If
    End Sub
    Private Sub FRMOUTSTANDINGRPT_PARTY_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub FRMOUTSTANDINGRPT_PARTY_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Leave

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
        Call PrintOperation()
    End Sub

    Private Sub CMDPRINT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDPRINT.Click
        PRINTREP = True
        Call PrintOperation()
    End Sub

    Private Sub CMDEXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDEXIT.Click
        Me.Close()
    End Sub
End Class