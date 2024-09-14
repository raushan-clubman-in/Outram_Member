Imports System.Data.SqlClient
Public Class CorpSubscriptionPosting
    Inherits System.Windows.Forms.Form
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
    Friend WithEvents ChkList_month As System.Windows.Forms.CheckedListBox
    Friend WithEvents Btn_ok As System.Windows.Forms.Button
    Friend WithEvents Btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_Revert As System.Windows.Forms.Button
    Friend WithEvents dtp_year As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdesc As System.Windows.Forms.TextBox
    Friend WithEvents cbo_BillingBasis As System.Windows.Forms.ComboBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents cancel As System.Windows.Forms.Button
    Friend WithEvents process As System.Windows.Forms.Button
    Friend WithEvents SSGRID1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents subsamount As System.Windows.Forms.TextBox
    Friend WithEvents totalamount As System.Windows.Forms.TextBox
    Friend WithEvents taxamount As System.Windows.Forms.TextBox
    Friend WithEvents SSGRID2 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents export As System.Windows.Forms.Button
    Friend WithEvents ltax As System.Windows.Forms.Label
    Friend WithEvents ltotal As System.Windows.Forms.Label
    Friend WithEvents lsubs As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CorpSubscriptionPosting))
        Me.ChkList_month = New System.Windows.Forms.CheckedListBox
        Me.Btn_ok = New System.Windows.Forms.Button
        Me.Btn_close = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp_year = New System.Windows.Forms.DateTimePicker
        Me.btn_Revert = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbo_BillingBasis = New System.Windows.Forms.ComboBox
        Me.txtdesc = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.export = New System.Windows.Forms.Button
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.process = New System.Windows.Forms.Button
        Me.cancel = New System.Windows.Forms.Button
        Me.subsamount = New System.Windows.Forms.TextBox
        Me.totalamount = New System.Windows.Forms.TextBox
        Me.ltax = New System.Windows.Forms.Label
        Me.ltotal = New System.Windows.Forms.Label
        Me.SSGRID1 = New AxFPSpreadADO.AxfpSpread
        Me.lsubs = New System.Windows.Forms.Label
        Me.taxamount = New System.Windows.Forms.TextBox
        Me.SSGRID2 = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSGRID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSGRID2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ChkList_month
        '
        Me.ChkList_month.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ChkList_month.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkList_month.Location = New System.Drawing.Point(320, 100)
        Me.ChkList_month.Name = "ChkList_month"
        Me.ChkList_month.Size = New System.Drawing.Size(312, 224)
        Me.ChkList_month.TabIndex = 2
        '
        'Btn_ok
        '
        Me.Btn_ok.BackgroundImage = CType(resources.GetObject("Btn_ok.BackgroundImage"), System.Drawing.Image)
        Me.Btn_ok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_ok.ForeColor = System.Drawing.Color.White
        Me.Btn_ok.Location = New System.Drawing.Point(96, 16)
        Me.Btn_ok.Name = "Btn_ok"
        Me.Btn_ok.Size = New System.Drawing.Size(104, 32)
        Me.Btn_ok.TabIndex = 4
        Me.Btn_ok.Text = "Post [F5]"
        '
        'Btn_close
        '
        Me.Btn_close.BackgroundImage = CType(resources.GetObject("Btn_close.BackgroundImage"), System.Drawing.Image)
        Me.Btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_close.ForeColor = System.Drawing.Color.White
        Me.Btn_close.Location = New System.Drawing.Point(336, 16)
        Me.Btn_close.Name = "Btn_close"
        Me.Btn_close.Size = New System.Drawing.Size(104, 32)
        Me.Btn_close.TabIndex = 6
        Me.Btn_close.Text = "Exit [F11]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 19)
        Me.Label1.TabIndex = 358
        Me.Label1.Text = "POSTING DATE"
        '
        'dtp_year
        '
        Me.dtp_year.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp_year.CustomFormat = "yyyy"
        Me.dtp_year.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_year.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtp_year.Location = New System.Drawing.Point(352, 24)
        Me.dtp_year.Name = "dtp_year"
        Me.dtp_year.Size = New System.Drawing.Size(104, 24)
        Me.dtp_year.TabIndex = 0
        '
        'btn_Revert
        '
        Me.btn_Revert.BackgroundImage = CType(resources.GetObject("btn_Revert.BackgroundImage"), System.Drawing.Image)
        Me.btn_Revert.Enabled = False
        Me.btn_Revert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Revert.ForeColor = System.Drawing.Color.White
        Me.btn_Revert.Location = New System.Drawing.Point(216, 16)
        Me.btn_Revert.Name = "btn_Revert"
        Me.btn_Revert.Size = New System.Drawing.Size(104, 32)
        Me.btn_Revert.TabIndex = 5
        Me.btn_Revert.Text = "Revert [F6]"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(328, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(384, 23)
        Me.Label2.TabIndex = 359
        Me.Label2.Text = "CORP SUBSCRIPTION POSTING"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.dtp_year)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.txtdesc)
        Me.GroupBox1.Location = New System.Drawing.Point(200, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(688, 432)
        Me.GroupBox1.TabIndex = 360
        Me.GroupBox1.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(512, 32)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(112, 16)
        Me.CheckBox1.TabIndex = 366
        Me.CheckBox1.Text = "Auto Adjust"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(400, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 363
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(83, 401)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 20)
        Me.Label3.TabIndex = 360
        Me.Label3.Text = "DESCRIPTION"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.chk_Filter_Field)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.cbo_BillingBasis)
        Me.GroupBox3.Controls.Add(Me.ChkList_month)
        Me.GroupBox3.Location = New System.Drawing.Point(24, 56)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(648, 344)
        Me.GroupBox3.TabIndex = 364
        Me.GroupBox3.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(88, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(97, 20)
        Me.Label9.TabIndex = 389
        Me.Label9.Text = "CATEGORY "
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.AntiqueWhite
        Me.chk_Filter_Field.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(8, 72)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(296, 244)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 386
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(440, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 20)
        Me.Label4.TabIndex = 362
        Me.Label4.Text = "Type of Posting"
        '
        'cbo_BillingBasis
        '
        Me.cbo_BillingBasis.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_BillingBasis.Items.AddRange(New Object() {"NONE"})
        Me.cbo_BillingBasis.Location = New System.Drawing.Point(320, 72)
        Me.cbo_BillingBasis.Name = "cbo_BillingBasis"
        Me.cbo_BillingBasis.Size = New System.Drawing.Size(312, 24)
        Me.cbo_BillingBasis.TabIndex = 1
        '
        'txtdesc
        '
        Me.txtdesc.Location = New System.Drawing.Point(208, 403)
        Me.txtdesc.MaxLength = 50
        Me.txtdesc.Name = "txtdesc"
        Me.txtdesc.Size = New System.Drawing.Size(392, 23)
        Me.txtdesc.TabIndex = 3
        Me.txtdesc.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Btn_ok)
        Me.GroupBox2.Controls.Add(Me.Btn_close)
        Me.GroupBox2.Controls.Add(Me.btn_Revert)
        Me.GroupBox2.Controls.Add(Me.export)
        Me.GroupBox2.Location = New System.Drawing.Point(200, 600)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(688, 56)
        Me.GroupBox2.TabIndex = 361
        Me.GroupBox2.TabStop = False
        '
        'export
        '
        Me.export.BackgroundImage = CType(resources.GetObject("export.BackgroundImage"), System.Drawing.Image)
        Me.export.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.export.ForeColor = System.Drawing.Color.White
        Me.export.Location = New System.Drawing.Point(584, 16)
        Me.export.Name = "export"
        Me.export.Size = New System.Drawing.Size(96, 32)
        Me.export.TabIndex = 6
        Me.export.Text = "To Excel [F12]"
        '
        'ssGrid
        '
        Me.ssGrid.ContainingControl = Me
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(10, 10)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(896, 504)
        Me.ssGrid.TabIndex = 380
        Me.ssGrid.Visible = False
        '
        'process
        '
        Me.process.BackgroundImage = CType(resources.GetObject("process.BackgroundImage"), System.Drawing.Image)
        Me.process.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.process.ForeColor = System.Drawing.Color.White
        Me.process.Location = New System.Drawing.Point(40, 504)
        Me.process.Name = "process"
        Me.process.Size = New System.Drawing.Size(104, 32)
        Me.process.TabIndex = 381
        Me.process.Text = "Process [F4]"
        Me.process.Visible = False
        '
        'cancel
        '
        Me.cancel.BackgroundImage = CType(resources.GetObject("cancel.BackgroundImage"), System.Drawing.Image)
        Me.cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancel.ForeColor = System.Drawing.Color.White
        Me.cancel.Location = New System.Drawing.Point(152, 504)
        Me.cancel.Name = "cancel"
        Me.cancel.Size = New System.Drawing.Size(104, 32)
        Me.cancel.TabIndex = 382
        Me.cancel.Text = "Cancel"
        Me.cancel.Visible = False
        '
        'subsamount
        '
        Me.subsamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subsamount.Location = New System.Drawing.Point(872, 512)
        Me.subsamount.MaxLength = 15
        Me.subsamount.Name = "subsamount"
        Me.subsamount.ReadOnly = True
        Me.subsamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.subsamount.Size = New System.Drawing.Size(120, 26)
        Me.subsamount.TabIndex = 384
        Me.subsamount.Text = ""
        Me.subsamount.Visible = False
        '
        'totalamount
        '
        Me.totalamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalamount.Location = New System.Drawing.Point(872, 568)
        Me.totalamount.MaxLength = 15
        Me.totalamount.Name = "totalamount"
        Me.totalamount.ReadOnly = True
        Me.totalamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.totalamount.Size = New System.Drawing.Size(120, 26)
        Me.totalamount.TabIndex = 384
        Me.totalamount.Text = ""
        Me.totalamount.Visible = False
        '
        'ltax
        '
        Me.ltax.AutoSize = True
        Me.ltax.BackColor = System.Drawing.Color.Transparent
        Me.ltax.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltax.Location = New System.Drawing.Point(744, 542)
        Me.ltax.Name = "ltax"
        Me.ltax.Size = New System.Drawing.Size(90, 20)
        Me.ltax.TabIndex = 360
        Me.ltax.Text = "Tax Amount"
        Me.ltax.Visible = False
        '
        'ltotal
        '
        Me.ltotal.AutoSize = True
        Me.ltotal.BackColor = System.Drawing.Color.Transparent
        Me.ltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltotal.Location = New System.Drawing.Point(736, 569)
        Me.ltotal.Name = "ltotal"
        Me.ltotal.Size = New System.Drawing.Size(99, 20)
        Me.ltotal.TabIndex = 360
        Me.ltotal.Text = "Total Amount"
        Me.ltotal.Visible = False
        '
        'SSGRID1
        '
        Me.SSGRID1.ContainingControl = Me
        Me.SSGRID1.DataSource = Nothing
        Me.SSGRID1.Location = New System.Drawing.Point(48, 171)
        Me.SSGRID1.Name = "SSGRID1"
        Me.SSGRID1.OcxState = CType(resources.GetObject("SSGRID1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRID1.Size = New System.Drawing.Size(920, 344)
        Me.SSGRID1.TabIndex = 385
        '
        'lsubs
        '
        Me.lsubs.AutoSize = True
        Me.lsubs.BackColor = System.Drawing.Color.Transparent
        Me.lsubs.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsubs.Location = New System.Drawing.Point(736, 512)
        Me.lsubs.Name = "lsubs"
        Me.lsubs.Size = New System.Drawing.Size(99, 20)
        Me.lsubs.TabIndex = 360
        Me.lsubs.Text = "Subs Amount"
        Me.lsubs.Visible = False
        '
        'taxamount
        '
        Me.taxamount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.taxamount.Location = New System.Drawing.Point(872, 544)
        Me.taxamount.MaxLength = 15
        Me.taxamount.Name = "taxamount"
        Me.taxamount.ReadOnly = True
        Me.taxamount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.taxamount.Size = New System.Drawing.Size(120, 26)
        Me.taxamount.TabIndex = 384
        Me.taxamount.Text = ""
        Me.taxamount.Visible = False
        '
        'SSGRID2
        '
        Me.SSGRID2.DataSource = Nothing
        Me.SSGRID2.Location = New System.Drawing.Point(0, 32)
        Me.SSGRID2.Name = "SSGRID2"
        Me.SSGRID2.OcxState = CType(resources.GetObject("SSGRID2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRID2.Size = New System.Drawing.Size(1008, 472)
        Me.SSGRID2.TabIndex = 385
        Me.SSGRID2.Visible = False
        '
        'CorpSubscriptionPosting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1008, 686)
        Me.Controls.Add(Me.SSGRID2)
        Me.Controls.Add(Me.subsamount)
        Me.Controls.Add(Me.totalamount)
        Me.Controls.Add(Me.ltax)
        Me.Controls.Add(Me.ltotal)
        Me.Controls.Add(Me.lsubs)
        Me.Controls.Add(Me.taxamount)
        Me.Controls.Add(Me.process)
        Me.Controls.Add(Me.cancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "CorpSubscriptionPosting"
        Me.Text = "CORPORATE SUBSCRIPTION POSTING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSGRID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSGRID2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Dim sqlString, chk_month As String
    Public sqlStringFinal, DispString, membertype As String
    Dim iNumber, row As Integer
    Dim billno As Long
    Public TempString(2), bill, catecode As String
    Dim storedPro_str As String
    Dim Fromdate, ToDate As String
    Dim postype, Vcatefile, sout, rout As String
    Dim posting, posting1 As New DataTable
    Dim dr As DataRow
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    'Dim processed As Integer
    Dim Processed_Chk(4) As Integer
    Private Sub CorpSubscriptionPosting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Long
        posting = Nothing
        Try
            sqlString = "select ISNULL(POSTINGCODE,'') AS POSTINGTYPE FROM postingmast group by postingcode"
            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count > 0 Then
                ChkList_month.Items.Clear()
                For i = 0 To posting.Rows.Count - 1
                    cbo_BillingBasis.Items.Add(posting.Rows(i).Item("POSTINGTYPE"))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        gconnection.closeConnection()
        dtp_year.Focus()
        cbo_BillingBasis.SelectedIndex = 0
        sqlString = "SELECT Membertype,TypeDesc FROM MEMBERTYPE"
        posting = gconnection.GetValues(sqlString)
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        If posting.Rows.Count > 1 Then
            For i = 0 To (posting.Rows.Count - 1)
                chk_Filter_Field.Items.Add(posting.Rows(i).Item("Membertype") & "." & posting.Rows(i).Item("TypeDesc"))
            Next
        End If
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
        Me.Btn_ok.Enabled = False
        Me.process.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Btn_ok.Enabled = True
                    Me.process.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.process.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.process.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.process.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    'Me.cmd_Delete.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Btn_ok.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub Btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_close.Click
        If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
            Me.Close()
        Else
            dtp_year.Focus()
        End If
    End Sub
    Private Sub Btn_ok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ok.Click
        Randomize()
        Dim i As Long
        posting = Nothing
        Vcatefile = Mid("SUBS" & CStr(Int(Rnd() * 5000)), 1, 8)
        'sout = Mid("SUS" & CStr(Int(Rnd() * 5000)), 1, 8)
        'rout = Mid("REV" & CStr(Int(Rnd() * 5000)), 1, 8)
        Try
            Me.Cursor = Cursors.WaitCursor
            sqlString = "select * From sysobjects where type='U' and name='" & Vcatefile & "'"
            gconnection.getDataSet(sqlString, "Temp")

            If gdataset.Tables("Temp").Rows.Count > 0 Then
                sqlString = "Drop table " & Vcatefile
                gconnection.dataOperation(6, sqlString, "Temp")
            Else
                sqlString = " select membertype into  " & Vcatefile & " from membertype where 1<0 "
                gconnection.dataOperation(6, sqlString, "Temp")
            End If
            catecode = ""
            For i = 0 To chk_Filter_Field.Items.Count - 1
                If chk_Filter_Field.GetItemChecked(i) = True Then
                    TempString = Split(chk_Filter_Field.Items.Item(i), ".")
                    sqlString = "insert into " & Vcatefile & "(membertype) values('" & TempString(0) & "')"
                    If catecode = "" Then
                        catecode = "membertype in ('" & TempString(0)
                    Else
                        catecode = catecode & "','" & TempString(0)
                    End If
                    posting = gconnection.GetValues(sqlString)
                End If
            Next i
            catecode = catecode & "')"
            If chk_Filter_Field.CheckedItems.Count = 0 Then
                MsgBox("Please Select Category", MsgBoxStyle.Critical, "THE CALCUTTA SWIMMING CLUB")
                chk_Filter_Field.Focus()
                Exit Sub
            End If
            If ChkList_month.CheckedItems.Count = 0 Then
                MsgBox("Please Select Posting Type", MsgBoxStyle.Critical, "THE CALCUTTA SWIMMING CLUB")
                ChkList_month.Focus()
                Exit Sub
            End If

            If txtdesc.Text = "" Then
                MsgBox("Description Cannot Be Blank", MsgBoxStyle.Critical, "THE CALCUTTA SWIMMING CLUB")
                txtdesc.Focus()
                Exit Sub
            End If

            'Call chkmonth()
            If ChkList_month.CheckedItems.Count > 0 Then
                TempString = Split((ChkList_month.CheckedItems.Item(0)), ".")
                chk_month = "'" & cbo_BillingBasis.Text & "'," & Trim(TempString(0))
            End If

            sqlString = "select isnull(period,'') as period from postingmast "
            sqlString = sqlString & " where postingcode= '" & Trim(cbo_BillingBasis.Text) & "'"
            sqlString = sqlString & " and postingsno=" & Trim(TempString(0))
            posting = gconnection.GetValues(sqlString)

            sqlString = "Exec  tp_subscriptionviewcorp '" & Format(dtp_year.Value, "dd/MMM/yyyy") & "','" & Trim(cbo_BillingBasis.Text) & "','" & TempString(0) & "',"
            'sqlString = "Exec tp_subscriptionpost '" & Format(dtp_year.Value, "dd/MMM/yyyy") & "','" & Trim(cbo_BillingBasis.Text) & "','" & TempString(0) & "',"
            sqlString = sqlString & "'" & txtdesc.Text & "','" & posting.Rows(0).Item("period") & "','" & Vcatefile & "'"
            posting = gconnection.GetValues(sqlString)

            sqlString = "select  ISNULL(max(cast(substring(voucherno,6,5) as int)),0)+1  as maxno from journalentry "
            sqlString = sqlString & " where substring(voucherno,1,3)='SUB'"

            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count > 0 Then
                billno = Val(posting.Rows(0).Item("maxno"))
            Else
                billno = 0
            End If
            sqlString = "select isnull(mcode,'') as mcode,sum(isnull(amount,0)) as subsamount,sum(isnull(taxamount,0)) as taxamount,isnull(period,'') as period,isnull(subsdesc,'TEST') as subsdesc,isnull(subcd,'') as subcd"
            sqlString = sqlString & " from subsposting where postingsno=" & TempString(0) & " and postingcode='" & Trim(cbo_BillingBasis.Text) & "'"
            sqlString = sqlString & " and isnull(postingflag,'')<> 'Y' AND " & catecode & " group by mcode,subsacctin,taxcode,period,subsdesc,subcd order by subcd,mcode"
            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count > 1 Then
                SSGRID2.Visible = True
                process.Visible = True
                cancel.Visible = True
                taxamount.Visible = True
                subsamount.Visible = True
                totalamount.Visible = True
                ltax.Visible = True
                lsubs.Visible = True
                ltotal.Visible = True
                taxamount.Text = ""
                subsamount.Text = ""
                totalamount.Text = ""
                SSGRID2.ClearRange(1, 1, -1, -1, True)
                SSGRID2.Row = 1
                SSGRID2.Col = 1
                SSGRID2.SetActiveCell(1, 1)
                SSGRID2.Row = 1
                SSGRID2.Col = 1
                SSGRID2.Text = "BillNo"
                SSGRID2.Col = 2
                SSGRID2.Text = "BillDate"
                SSGRID2.Col = 3
                SSGRID2.Text = "Mcode"
                SSGRID2.Col = 4
                SSGRID2.Text = "Mname"
                SSGRID2.Col = 5
                SSGRID2.Text = "Period"
                SSGRID2.Col = 6
                SSGRID2.Text = "Subsdesc"
                SSGRID2.Col = 7
                SSGRID2.Text = "SubsAmount"
                SSGRID2.Col = 10
                SSGRID2.Text = "TaxAmount"
                SSGRID2.Col = 11
                SSGRID2.Text = "TotalAmount"
                SSGRID2.Col = 12
                SSGRID2.Text = "balance"

                SSGRID2.Row = 2
                SSGRID2.Col = 1
                SSGRID2.SetActiveCell(1, 2)
                SSGRID2.MaxRows = posting.Rows.Count + 20
                Dim mcode, c
                Dim balance As Double
                mcode = ""
                For row = 0 To posting.Rows.Count - 1
                    c = c + 1
                    With SSGRID2
                        bill = "SBIL/" & Mid(Year(dtp_year.Value), 3, 2) & Format(Month(dtp_year.Value), "00") & "/" & Trim(posting.Rows(row).Item("MCODE"))

                        If mcode <> posting.Rows(row).Item("mcode") Then
                            c = c + 1
                        End If

                        .Row = c

                        .Col = 1
                        .Text = bill

                        .Col = 2
                        .Text = Format(dtp_year.Value, "dd/MMM/yyyy")

                        .Col = 3
                        .Text = posting.Rows(row).Item("mcode")

                        .Col = 4
                        sqlString = "select isnull(cmcorporatename,'') as mname  from corporatemaster where cmcorporatecode='" & posting.Rows(row).Item("mcode") & "'"
                        posting1 = gconnection.GetValues(sqlString)
                        If posting1.Rows.Count > 0 Then
                            .Text = posting1.Rows(0).Item("mname")
                        End If

                        .Col = 5
                        .Text = posting.Rows(row).Item("period")

                        .Col = 6
                        .Text = posting.Rows(row).Item("subsdesc")

                        .Col = 7
                        .Text = posting.Rows(row).Item("subsamount")
                        If Val(posting.Rows(row).Item("subsamount")) > 0 Then
                            subsamount.Text = Format(Val(subsamount.Text) + Val(posting.Rows(row).Item("subsamount")), "0.00")
                        End If

                        .Col = 10
                        If posting.Rows(row).Item("taxamount") > 0 Then
                            .Text = posting.Rows(row).Item("taxamount")
                        Else
                            .Text = ""
                        End If
                        If Val(posting.Rows(row).Item("taxamount")) > 0 Then
                            taxamount.Text = Format(Val(taxamount.Text) + Val(posting.Rows(row).Item("taxamount")), "0.00")
                        End If

                        .Col = 11
                        .Text = Format(Val(posting.Rows(row).Item("taxamount") + posting.Rows(row).Item("subsamount")), "0.00")
                        If Val(posting.Rows(row).Item("subsamount")) > 0 Or Val(posting.Rows(row).Item("taxamount")) > 0 Then
                            totalamount.Text = Format(Val(totalamount.Text) + Format(Val(posting.Rows(row).Item("taxamount") + posting.Rows(row).Item("subsamount")), "0.00"), "0.00")
                        End If
                        '                        balance = balance + Val(posting.Rows(row).Item("subsamount")) + Val(posting.Rows(row).Item("taxamount"))

                        If mcode <> posting.Rows(row).Item("mcode") And mcode <> "" Then
                            .Row = c - 1
                            .Col = 12
                            .Text = Format(Val(balance), "0.00")
                            balance = 0
                        End If
                        If Val(posting.Rows(row).Item("subsamount")) > 0 Or Val(posting.Rows(row).Item("taxamount")) > 0 Then
                            balance = balance + Val(posting.Rows(row).Item("subsamount")) + Val(posting.Rows(row).Item("taxamount"))
                        End If
                        mcode = posting.Rows(row).Item("mcode")
                    End With
                Next row
                Me.Cursor = Cursors.Default
            Else
                Me.Cursor = Cursors.Default
                MsgBox("No Record Pls Check...", MsgBoxStyle.OKOnly)
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_Revert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Revert.Click
        Try
            Select Case iNumber
                'April (1st April to 30th June)
                'July (1st July to 30th September)
                'October (1st October to 31st December)
                'January (1st January to 31st March)
            Case 0
                    Fromdate = "1-Apr-" & dtp_year.Value.Year
                    ToDate = "30-Jun-" & dtp_year.Value.Year
                Case 1
                    Fromdate = "1-Jul-" & dtp_year.Value.Year
                    ToDate = "30-Sep-" & dtp_year.Value.Year
                Case 2
                    Fromdate = "1-Octr-" & dtp_year.Value.Year
                    ToDate = "30-Dec-" & dtp_year.Value.Year
                Case 3
                    Fromdate = "1-Jan-" & dtp_year.Value.Year
                    ToDate = "30-Mar-" & dtp_year.Value.Year
            End Select
            'sqlString = "insert into posting_validation (quarter,yearof,processed,dateofprocess)values(" & iNumber & "," & Date.Now.Year & " ,'Y'," & Date.Now.Date & ")"
            sqlString = "DELETE FROM posting_validation WHERE " & iNumber & " = 0 AND YEAROF = '" & dtp_year.Value.Year & "'"
            gconnection.dataOperation(1, sqlString, "MemberType")
            Me.Hide()
            ChkList_month.Enabled = True
            Dim nwindConn As SqlConnection = New SqlConnection("Data Source=ServerName;Integrated Security=SSPI;" & _
                                                   "Initial Catalog=" & ServerName)
            Dim PostingCMD As SqlCommand = New SqlCommand("CSC_SUBPOSTING_REVERT", nwindConn)
            PostingCMD.CommandType = CommandType.StoredProcedure

            Dim myParm1 As SqlParameter = PostingCMD.Parameters.Add("@startmonth", SqlDbType.DateTime)
            myParm1.Value = Fromdate

            Dim myParm2 As SqlParameter = PostingCMD.Parameters.Add("@endmonth", SqlDbType.DateTime)
            myParm2.Value = ToDate

            Dim myParm3 As SqlParameter = PostingCMD.Parameters.Add("@CHALLNDATE", SqlDbType.DateTime)
            myParm3.Value = Fromdate

            Dim myParm4 As SqlParameter = PostingCMD.Parameters.Add("@FYEAR", SqlDbType.VarChar)
            myParm4.Value = dtp_year.Value.Year

            nwindConn.Open()
            PostingCMD.ExecuteNonQuery()
            nwindConn.Close()

            MsgBox("REVERTING OF POSTING IS DONE...")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub dtp_year_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_year.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Focus()
        End If
    End Sub
    Private Sub btn_Revert_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles btn_Revert.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
        End If
    End Sub
    Private Sub ChkList_month_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChkList_month.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtdesc.Focus()
        End If
    End Sub
    Private Sub txtdesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdesc.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Btn_ok.Focus()
        End If
    End Sub
    Private Sub ChkList_type_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub fillpostingtype()
        ChkList_month.Items.Clear()
        Dim i As Long
        posting = Nothing
        Try
            sqlString = "select isnull(postingsno,0) as postingsno, isnull(POSTINGCODE,'') AS POSTINGTYPE,ISNULL(POSTINGDESC,'') as postingdesc,isnull(postingsno,0) as postingsno "
            sqlString = sqlString & " from postingmast where  isnull(postingcode,'')='" & Me.cbo_BillingBasis.Text & "'"
            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count > 0 Then
                ChkList_month.Items.Clear()
                For i = 0 To posting.Rows.Count - 1
                    ChkList_month.Items.Add(posting.Rows(i).Item("POSTINGSNO") & "." & posting.Rows(i).Item("POSTINGDESC"))
                Next
            Else
                ChkList_month.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_BillingBasis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_BillingBasis.SelectedIndexChanged
        Call fillpostingtype()
    End Sub
    Private Sub cbo_BillingBasis_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cbo_BillingBasis.KeyDown
        If e.KeyCode = Keys.Enter Then
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub dtp_year_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_year.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbo_BillingBasis.Focus()
        End If
    End Sub
    Private Sub chkmonth()
        Dim i As Long
        Try
            If ChkList_month.CheckedItems.Count > 0 Then
                TempString = Split((ChkList_month.CheckedItems.Item(0)), ".")
                'DispString = TempString(1)
                chk_month = "'" & cbo_BillingBasis.Text & "','" & Trim(TempString(0)) & "')"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub chk_Filter_Field_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Filter_Field.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            cbo_BillingBasis.Focus()
        End If
    End Sub
    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        SSGRID2.ClearRange(1, 1, -1, -1, True)
        SSGRID2.Visible = False
        ssGrid.Visible = False
        process.Visible = False
        cancel.Visible = False
        taxamount.Visible = False
        subsamount.Visible = False
        totalamount.Visible = False
        dtp_year.Focus()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles process.Click
        Me.Cursor = Cursors.WaitCursor

        sqlString = "Exec tp_subscriptionpostcorp '" & Format(dtp_year.Value, "dd/MMM/yyyy") & "','" & Trim(cbo_BillingBasis.Text) & "','" & TempString(0) & "',"
        sqlString = sqlString & "'" & txtdesc.Text & "','" & posting.Rows(0).Item("period") & "','" & gFinancalyearStart & "','" & gFinancialYearEnd & "'"
        posting = gconnection.GetValues(sqlString)

        'If CheckBox1.Checked = True Then
        '    If MsgBox("Auto Matching Adjsutment......", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1, "Confirmation") = vbOK Then
        '        sqlString = "Exec tp_Auto_matching1_CSC '01/Apr/1994','" & Format(dtp_year.Value, "dd/MMM/yyyy") & "'"
        '        posting = gconnection.GetValues(sqlString)
        '    End If
        'End If

        sqlString = "Update postingmast set postingflag='Y', postingdate='" & Format(dtp_year.Value, "dd/MMM/yyyy") & "'," & "userid='" & gUsername & "'"
        sqlString = sqlString & " where postingsno='" & TempString(0) & "' and postingcode='" & Trim(cbo_BillingBasis.Text) & "'"
        posting = gconnection.GetValues(sqlString)

        sqlString = "update subsposting set postingflag='Y' "
        sqlString = sqlString & " where postingsno=" & TempString(0) & " and postingcode='" & Trim(cbo_BillingBasis.Text) & "'"
        sqlString = sqlString & " and isnull(postingflag,'')<> 'Y' AND " & catecode
        posting = gconnection.GetValues(sqlString)

        MessageBox.Show("Subscription Posting Completed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Call cancel_Click(sender, e)
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub export_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles export.Click
        Try
            If SSGRID2.Visible = True Then
                Call ExportTo(SSGRID2)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Private Sub CorpSubscriptionPosting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call Btn_ok_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call btn_Revert_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.Escape Or e.KeyCode = Keys.F11 Then
            Call Btn_close_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F12 Then
            Call export_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F4 And SSGRID2.Visible = True Then
            Call Button1_Click(sender, e)
            Exit Sub
        End If
    End Sub
End Class
