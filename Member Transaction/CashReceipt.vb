Imports System.Data.SqlClient
Public Class CashReceipt
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
    Friend WithEvents GrpBill As System.Windows.Forms.GroupBox
    Friend WithEvents FraGrid As System.Windows.Forms.GroupBox
    Friend WithEvents ssGrid As AxFPSpreadADO.AxfpSpread
    Friend WithEvents cmd_CRNoHelp As System.Windows.Forms.Button
    Friend WithEvents txt_CRNo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_CRNo As System.Windows.Forms.Label
    Friend WithEvents lbl_CRdate As System.Windows.Forms.Label
    Friend WithEvents lbl_TotalAmount As System.Windows.Forms.Label
    Friend WithEvents txt_TotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents lbl_TotalReceived As System.Windows.Forms.Label
    Friend WithEvents txt_TotalReceived As System.Windows.Forms.TextBox
    Friend WithEvents dtp_CRdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents txt_CashTime As System.Windows.Forms.TextBox
    Friend WithEvents KOT_Timer As System.Windows.Forms.Timer
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents Cmd_AddNew As System.Windows.Forms.Button
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_CashReceipt As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txt_Noofdocument As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Document As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CashReceipt))
        Me.GrpBill = New System.Windows.Forms.GroupBox
        Me.cmd_CRNoHelp = New System.Windows.Forms.Button
        Me.txt_CRNo = New System.Windows.Forms.TextBox
        Me.lbl_CRNo = New System.Windows.Forms.Label
        Me.lbl_CRdate = New System.Windows.Forms.Label
        Me.FraGrid = New System.Windows.Forms.GroupBox
        Me.ssGrid = New AxFPSpreadADO.AxfpSpread
        Me.lbl_TotalAmount = New System.Windows.Forms.Label
        Me.txt_TotalAmount = New System.Windows.Forms.TextBox
        Me.lbl_TotalReceived = New System.Windows.Forms.Label
        Me.txt_TotalReceived = New System.Windows.Forms.TextBox
        Me.dtp_CRdate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.txt_CashTime = New System.Windows.Forms.TextBox
        Me.KOT_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Delete = New System.Windows.Forms.Button
        Me.Cmd_AddNew = New System.Windows.Forms.Button
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_CashReceipt = New System.Windows.Forms.Label
        Me.Txt_Noofdocument = New System.Windows.Forms.TextBox
        Me.lbl_Document = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.FraGrid.SuspendLayout()
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpBill
        '
        Me.GrpBill.BackColor = System.Drawing.Color.Transparent
        Me.GrpBill.Location = New System.Drawing.Point(552, 64)
        Me.GrpBill.Name = "GrpBill"
        Me.GrpBill.Size = New System.Drawing.Size(424, 88)
        Me.GrpBill.TabIndex = 10
        Me.GrpBill.TabStop = False
        '
        'cmd_CRNoHelp
        '
        Me.cmd_CRNoHelp.Image = CType(resources.GetObject("cmd_CRNoHelp.Image"), System.Drawing.Image)
        Me.cmd_CRNoHelp.Location = New System.Drawing.Point(928, 80)
        Me.cmd_CRNoHelp.Name = "cmd_CRNoHelp"
        Me.cmd_CRNoHelp.Size = New System.Drawing.Size(23, 32)
        Me.cmd_CRNoHelp.TabIndex = 9
        '
        'txt_CRNo
        '
        Me.txt_CRNo.BackColor = System.Drawing.Color.Wheat
        Me.txt_CRNo.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CRNo.ForeColor = System.Drawing.Color.Blue
        Me.txt_CRNo.Location = New System.Drawing.Point(712, 80)
        Me.txt_CRNo.Name = "txt_CRNo"
        Me.txt_CRNo.Size = New System.Drawing.Size(216, 32)
        Me.txt_CRNo.TabIndex = 8
        Me.txt_CRNo.Text = ""
        '
        'lbl_CRNo
        '
        Me.lbl_CRNo.AutoSize = True
        Me.lbl_CRNo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CRNo.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_CRNo.Location = New System.Drawing.Point(576, 80)
        Me.lbl_CRNo.Name = "lbl_CRNo"
        Me.lbl_CRNo.Size = New System.Drawing.Size(113, 25)
        Me.lbl_CRNo.TabIndex = 11
        Me.lbl_CRNo.Text = "CRO NO. :"
        '
        'lbl_CRdate
        '
        Me.lbl_CRdate.AutoSize = True
        Me.lbl_CRdate.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CRdate.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_CRdate.Location = New System.Drawing.Point(568, 120)
        Me.lbl_CRdate.Name = "lbl_CRdate"
        Me.lbl_CRdate.Size = New System.Drawing.Size(124, 25)
        Me.lbl_CRdate.TabIndex = 12
        Me.lbl_CRdate.Text = "CRO DATE :"
        '
        'FraGrid
        '
        Me.FraGrid.BackColor = System.Drawing.Color.Transparent
        Me.FraGrid.Controls.Add(Me.ssGrid)
        Me.FraGrid.Location = New System.Drawing.Point(40, 152)
        Me.FraGrid.Name = "FraGrid"
        Me.FraGrid.Size = New System.Drawing.Size(936, 368)
        Me.FraGrid.TabIndex = 1
        Me.FraGrid.TabStop = False
        '
        'ssGrid
        '
        Me.ssGrid.ContainingControl = Me
        Me.ssGrid.DataSource = Nothing
        Me.ssGrid.Location = New System.Drawing.Point(8, 16)
        Me.ssGrid.Name = "ssGrid"
        Me.ssGrid.OcxState = CType(resources.GetObject("ssGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssGrid.Size = New System.Drawing.Size(920, 344)
        Me.ssGrid.TabIndex = 0
        '
        'lbl_TotalAmount
        '
        Me.lbl_TotalAmount.AutoSize = True
        Me.lbl_TotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TotalAmount.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_TotalAmount.Location = New System.Drawing.Point(592, 528)
        Me.lbl_TotalAmount.Name = "lbl_TotalAmount"
        Me.lbl_TotalAmount.Size = New System.Drawing.Size(171, 25)
        Me.lbl_TotalAmount.TabIndex = 14
        Me.lbl_TotalAmount.Text = "TOTAL AMOUNT :"
        '
        'txt_TotalAmount
        '
        Me.txt_TotalAmount.BackColor = System.Drawing.Color.Wheat
        Me.txt_TotalAmount.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalAmount.Location = New System.Drawing.Point(792, 528)
        Me.txt_TotalAmount.Name = "txt_TotalAmount"
        Me.txt_TotalAmount.Size = New System.Drawing.Size(184, 31)
        Me.txt_TotalAmount.TabIndex = 16
        Me.txt_TotalAmount.Text = ""
        '
        'lbl_TotalReceived
        '
        Me.lbl_TotalReceived.AutoSize = True
        Me.lbl_TotalReceived.BackColor = System.Drawing.Color.Transparent
        Me.lbl_TotalReceived.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_TotalReceived.Location = New System.Drawing.Point(568, 568)
        Me.lbl_TotalReceived.Name = "lbl_TotalReceived"
        Me.lbl_TotalReceived.Size = New System.Drawing.Size(195, 25)
        Me.lbl_TotalReceived.TabIndex = 15
        Me.lbl_TotalReceived.Text = "TOTAL RECEIVED :"
        '
        'txt_TotalReceived
        '
        Me.txt_TotalReceived.BackColor = System.Drawing.Color.Wheat
        Me.txt_TotalReceived.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TotalReceived.Location = New System.Drawing.Point(792, 568)
        Me.txt_TotalReceived.Name = "txt_TotalReceived"
        Me.txt_TotalReceived.Size = New System.Drawing.Size(184, 31)
        Me.txt_TotalReceived.TabIndex = 17
        Me.txt_TotalReceived.Text = ""
        '
        'dtp_CRdate
        '
        Me.dtp_CRdate.CustomFormat = "dd-MM-yyyy"
        Me.dtp_CRdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_CRdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_CRdate.Location = New System.Drawing.Point(712, 120)
        Me.dtp_CRdate.Name = "dtp_CRdate"
        Me.dtp_CRdate.Size = New System.Drawing.Size(136, 26)
        Me.dtp_CRdate.TabIndex = 0
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Status.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Status.Location = New System.Drawing.Point(120, 120)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(0, 25)
        Me.lbl_Status.TabIndex = 32
        Me.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_CashTime
        '
        Me.txt_CashTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CashTime.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_CashTime.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_CashTime.Location = New System.Drawing.Point(848, 120)
        Me.txt_CashTime.Name = "txt_CashTime"
        Me.txt_CashTime.ReadOnly = True
        Me.txt_CashTime.Size = New System.Drawing.Size(104, 26)
        Me.txt_CashTime.TabIndex = 33
        Me.txt_CashTime.Text = ""
        '
        'KOT_Timer
        '
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(640, 616)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 362
        Me.Cmd_Print.Text = "Print[F10]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(144, 616)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 361
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(512, 616)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 359
        Me.Cmd_View.Text = " View[F9]"
        '
        'Cmd_Delete
        '
        Me.Cmd_Delete.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Delete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Delete.ForeColor = System.Drawing.Color.White
        Me.Cmd_Delete.Image = CType(resources.GetObject("Cmd_Delete.Image"), System.Drawing.Image)
        Me.Cmd_Delete.Location = New System.Drawing.Point(392, 616)
        Me.Cmd_Delete.Name = "Cmd_Delete"
        Me.Cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Delete.TabIndex = 360
        Me.Cmd_Delete.Text = "Delete[F8]"
        '
        'Cmd_AddNew
        '
        Me.Cmd_AddNew.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_AddNew.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_AddNew.ForeColor = System.Drawing.Color.White
        Me.Cmd_AddNew.Image = CType(resources.GetObject("Cmd_AddNew.Image"), System.Drawing.Image)
        Me.Cmd_AddNew.Location = New System.Drawing.Point(264, 616)
        Me.Cmd_AddNew.Name = "Cmd_AddNew"
        Me.Cmd_AddNew.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_AddNew.TabIndex = 358
        Me.Cmd_AddNew.Text = "Add [F7]"
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(760, 616)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 357
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(128, 600)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(752, 56)
        Me.GroupBox2.TabIndex = 356
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(56, 664)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(896, 16)
        Me.Label2.TabIndex = 355
        Me.Label2.Text = "F4-->Help  F2-->Kot No   F3-->Delete Item  Alt+P--> Payment Mode   Alt+M--> Membe" & _
        "r Code  Alt+S--> Server Code Alt+G-->Focus on Grid"
        '
        'lbl_CashReceipt
        '
        Me.lbl_CashReceipt.AutoSize = True
        Me.lbl_CashReceipt.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CashReceipt.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CashReceipt.ForeColor = System.Drawing.Color.Black
        Me.lbl_CashReceipt.Location = New System.Drawing.Point(368, 16)
        Me.lbl_CashReceipt.Name = "lbl_CashReceipt"
        Me.lbl_CashReceipt.Size = New System.Drawing.Size(216, 35)
        Me.lbl_CashReceipt.TabIndex = 363
        Me.lbl_CashReceipt.Text = "C.R.O RECEIPT"
        Me.lbl_CashReceipt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Txt_Noofdocument
        '
        Me.Txt_Noofdocument.BackColor = System.Drawing.Color.Wheat
        Me.Txt_Noofdocument.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Noofdocument.Location = New System.Drawing.Point(344, 526)
        Me.Txt_Noofdocument.Name = "Txt_Noofdocument"
        Me.Txt_Noofdocument.ReadOnly = True
        Me.Txt_Noofdocument.Size = New System.Drawing.Size(96, 31)
        Me.Txt_Noofdocument.TabIndex = 365
        Me.Txt_Noofdocument.Text = ""
        Me.Txt_Noofdocument.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbl_Document
        '
        Me.lbl_Document.AutoSize = True
        Me.lbl_Document.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Document.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_Document.Location = New System.Drawing.Point(128, 528)
        Me.lbl_Document.Name = "lbl_Document"
        Me.lbl_Document.Size = New System.Drawing.Size(207, 25)
        Me.lbl_Document.TabIndex = 364
        Me.lbl_Document.Text = "NO. OF DOCUMENT :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(152, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 25)
        Me.Label3.TabIndex = 366
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CashReceipt
        '
        Me.AutoScale = False
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(238, Byte), CType(249, Byte), CType(232, Byte))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1026, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Txt_Noofdocument)
        Me.Controls.Add(Me.lbl_Document)
        Me.Controls.Add(Me.lbl_CashReceipt)
        Me.Controls.Add(Me.txt_CashTime)
        Me.Controls.Add(Me.txt_TotalReceived)
        Me.Controls.Add(Me.lbl_TotalReceived)
        Me.Controls.Add(Me.txt_TotalAmount)
        Me.Controls.Add(Me.lbl_TotalAmount)
        Me.Controls.Add(Me.lbl_CRNo)
        Me.Controls.Add(Me.lbl_CRdate)
        Me.Controls.Add(Me.txt_CRNo)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_Clear)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Cmd_Delete)
        Me.Controls.Add(Me.Cmd_AddNew)
        Me.Controls.Add(Me.Cmd_Exit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.dtp_CRdate)
        Me.Controls.Add(Me.FraGrid)
        Me.Controls.Add(Me.cmd_CRNoHelp)
        Me.Controls.Add(Me.GrpBill)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "CashReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CASH RECEIPT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.FraGrid.ResumeLayout(False)
        CType(Me.ssGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Public receiptno() As String
    Public chkbool As Boolean
    Public receiptstatus As String
    Dim gconnection As New GlobalClass
    Private Sub CashReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Call clearform(Me)
        'Call autogenerate()
        'Call ShowBillno()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txt_TotalAmount.ReadOnly = True
        txt_TotalReceived.ReadOnly = True
        KOT_Timer.Enabled = True
        KOT_Timer.Interval = 100
        Cmd_AddNew.Text = "Add [F7]"
        dtp_CRdate.Focus()
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
        Me.cmd_AddNew.Enabled = False
        Me.cmd_Delete.Enabled = False
        Me.Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmd_AddNew.Enabled = True
                    Me.cmd_Delete.Enabled = True
                    Me.Cmd_View.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.cmd_AddNew.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.cmd_AddNew.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.cmd_AddNew.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.cmd_Delete.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        'ssGrid.ClearRange(1, 1, -1, -1, True)
        'ssGrid.SetActiveCell(1, 1)
        'Call clearform(Me)
        'Call autogenerate()
        'Call ShowBillno()
        'txt_CRNo.ReadOnly = False
        'Me.Cmd_AddNew.Enabled = True
        'Cmd_AddNew.Text = "Add [F7]"
        'dtp_CRdate.Focus()
    End Sub

    Private Function GetKotNos() As String
        Dim i As Integer
        Dim sql, Check As String
        For i = 1 To ssGrid.DataRowCnt
            Check = ""
            ssGrid.Row = i
            ssGrid.Col = 3
            Check = ssGrid.Text
            If Val(Check) = 1 Then
                ssGrid.Col = 1
                If Trim(sql) = "" Then
                    sql = "'" & Trim(ssGrid.Text) & "'"
                Else
                    sql = sql & ",'" & Trim(ssGrid.Text) & "'"
                End If
            End If
        Next
        Return sql
    End Function
    Private Sub Cmd_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_AddNew.Click
        Dim sqlstring, Varchk, Billno, Update(0) As String
        Dim Billamount, Amtreceived, Adjamount, Newbillamount As Double
        Dim boolchk As Boolean
        Dim i As Integer
        Try
            Call checkvalidate() '''---> Check Validation
            If chkbool = False Then Exit Sub
            If Cmd_AddNew.Text = "Add [F7]" Then
                receiptno = Split(Trim(txt_CRNo.Text), "/")
                For i = 1 To ssGrid.DataRowCnt
                    ssGrid.Col = 3
                    ssGrid.Row = i
                    Varchk = ""
                    Varchk = ssGrid.Text
                    If Val(Varchk & "") = 1 Then
                        ssGrid.Col = 5
                        ssGrid.Row = i
                        If Val(ssGrid.Text) = 0 Then
                            '''************************************* UPDATE TABLE BILL_HDR ************************************'''
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = "UPDATE Bill_hdr SET crostatus = 'Y' WHERE Billdetails='" & Trim(ssGrid.Text) & "'"
                            If boolchk = True Then
                                ReDim Preserve Update(Update.Length)
                                Update(Update.Length - 1) = sqlstring
                            Else
                                Update(0) = sqlstring
                                boolchk = True
                            End If
                            '''************************************* INSERT INTO Receipt_details *********************************'''
                            sqlstring = "INSERT INTO Receipt_details(Crono,Crodate,Billno,Billdate,Billamount,Amtreceived,Balanceamt,Servercode,Servername,MR_flag,Userid,Userdatetime) "
                            sqlstring = sqlstring & "VALUES ('" & Trim(txt_CRNo.Text) & "','" & Format(CDate(dtp_CRdate.Value), "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                            ssGrid.Col = 2
                            sqlstring = sqlstring & ",'" & Format(CDate(ssGrid.Text), "dd-MMM-yyyy") & "'"
                            ssGrid.Col = 4
                            Billamount = Val(ssGrid.Text)
                            sqlstring = sqlstring & "," & Format(Val(Billamount), "0.00") & ""
                            ssGrid.Col = 6
                            Amtreceived = Val(ssGrid.Text)
                            sqlstring = sqlstring & "," & Format(Val(Amtreceived), "0.00") & ""
                            sqlstring = sqlstring & "," & Format(Val(Billamount) - Val(Amtreceived), "0.00") & ""
                            ssGrid.Col = 7
                            sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                            ssGrid.Col = 8
                            sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                            sqlstring = sqlstring & ",'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                            ReDim Preserve Update(Update.Length)
                            Update(Update.Length - 1) = sqlstring
                            '''************************************* Complete Insert Receipt_Details *****************************'''
                        Else
                            '''************************************* UPDATE TABLE BILL_HDR ************************************'''
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = "UPDATE Bill_hdr SET crostatus = 'Y' WHERE Billdetails='" & Trim(ssGrid.Text) & "'"
                            If boolchk = True Then
                                ReDim Preserve Update(Update.Length)
                                Update(Update.Length - 1) = sqlstring
                            Else
                                Update(0) = sqlstring
                                boolchk = True
                            End If
                            '''************************************* INSERT INTO Receipt_details *********************************'''
                            sqlstring = "INSERT INTO Receipt_details(Crono,Crodate,Billno,Billdate,Billamount,Amtreceived,Balanceamt,Servercode,Servername,MR_flag,Userid,Userdatetime) "
                            sqlstring = sqlstring & "VALUES ('" & Trim(txt_CRNo.Text) & "','" & Format(CDate(dtp_CRdate.Value), "dd-MMM-yyyy hh:mm:ss") & "'"
                            ssGrid.Row = i
                            ssGrid.Col = 1
                            sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                            ssGrid.Col = 2
                            sqlstring = sqlstring & ",'" & Format(CDate(ssGrid.Text), "dd-MMM-yyyy") & "'"
                            ssGrid.Col = 4
                            Billamount = Val(ssGrid.Text)
                            ssGrid.Col = 5
                            Adjamount = Val(ssGrid.Text)
                            Newbillamount = Val(Billamount) - Val(Adjamount)
                            sqlstring = sqlstring & "," & Format(Val(Newbillamount), "0.00") & ""
                            ssGrid.Col = 6
                            Amtreceived = Val(ssGrid.Text)
                            sqlstring = sqlstring & "," & Format(Val(Amtreceived), "0.00") & ""
                            sqlstring = sqlstring & "," & Format(Val(Newbillamount) - Val(Amtreceived), "0.00") & ""
                            ssGrid.Col = 7
                            sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                            ssGrid.Col = 8
                            sqlstring = sqlstring & ",'" & Trim(ssGrid.Text) & "'"
                            sqlstring = sqlstring & ",'N','" & Trim(gUsername) & "','" & Format(Now, "dd-MMM-yyyy hh:mm:ss") & "')"
                            ReDim Preserve Update(Update.Length)
                            Update(Update.Length - 1) = sqlstring
                            '''************************************* Complete Insert Receipt_Details *****************************'''
                        End If
                    End If
                Next i
                Billno = GetKotNos()
                sqlstring = "UPDATE Kot_Hdr SET CroStatus='Y' WHERE KotDetails IN (SELECT KotDetails FROM Kot_Det WHERE BillDetails IN(" & Billno & "))"
                ReDim Preserve Update(Update.Length)
                Update(Update.Length - 1) = sqlstring
                gconnection.MoreTrans(Update)
                Call Cmd_Clear_Click(sender, e)
            End If
        Catch ex As Exception
            MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub Cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Delete.Click

    End Sub

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click

    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click

    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub cmd_CRNoHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_CRNoHelp.Click
        '    'Dim vform As New ListOperattion1
        '    gSQLString = "SELECT DISTINCT CRONO,Convert(varchar, CRODATE,100) AS CRODATE FROM RECEIPT_DETAILS "
        '    M_WhereCondition = "WHERE SUBSTRING(CRONO,1,3) IN ('CRO')"
        '    vform.Field = " CRONO,CRODATE "
        '    vform.vFormatstring = "                    CRONO                               |                      CRODATE               |"
        '    vform.vCaption = "RECEIPT DETAILS HELP"
        '    vform.KeyPos = 0
        '    vform.ShowDialog(Me)
        '    If Trim(vform.keyfield & "") <> "" Then
        '        txt_CRNo.Text = Trim(vform.keyfield & "")
        '        Call txt_CRNo_Validated(sender, e)
        '    End If
        '    vform.Close()
        '    vform = Nothing
        'End Sub
        'Private Sub autogenerate()
        '    Dim sqlstring, financalyear As String
        '    Try
        '        financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
        '        sqlstring = "SELECT MAX(SUBSTRING(Crono,6,5)) FROM Receipt_details WHERE SUBSTRING(CRONO,1,3) IN ('CRO')"
        '        gconnection.openConnection()
        '        gcommand = New SqlCommand(sqlstring, gconnection.Myconn)
        '        gdreader = gcommand.ExecuteReader
        '        If gdreader.Read Then
        '            If gdreader(0) Is System.DBNull.Value Then
        '                txt_CRNo.Text = "CRO /00001/" & financalyear
        '                gdreader.Close()
        '                gcommand.Dispose()
        '                gconnection.closeConnection()
        '            Else
        '                txt_CRNo.Text = "CRO /" & Format(gdreader(0) + 1, "00000") & "/" & financalyear
        '                gdreader.Close()
        '                gcommand.Dispose()
        '                gconnection.closeConnection()
        '            End If
        '        Else
        '            txt_CRNo.Text = "CRO /00001/" & financalyear
        '            gdreader.Close()
        '            gcommand.Dispose()
        '            gconnection.closeConnection()
        '        End If
        '    Catch ex As Exception
        '        MessageBox.Show("Error While opening :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '        Exit Sub
        '    Finally
        '        gdreader.Close()
        '        gcommand.Dispose()
        '        gconnection.closeConnection()
        '    End Try
    End Sub

    Private Sub ShowBillno()
        Dim sqlstring, financalyear As String
        Try
            financalyear = Mid(gFinancalyearStart, 3, 4) & "-" & Mid(gFinancialYearEnd, 3, 4)
            sqlstring = "SELECT MAX(SUBSTRING(Crono,6,5)) FROM Receipt_details WHERE SUBSTRING(CRONO,1,3) IN ('CRO')"
            gconnection.openConnection()
            gcommand = New SqlCommand(sqlstring, gconnection.Myconn)
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) Is DBNull.Value Then
                    lbl_Status.Visible = True
                    lbl_Status.Text = "FIRST RECEIPT NO :"
                Else
                    lbl_Status.Visible = True
                    lbl_Status.Text = "LAST RECEIPT NO :" & "CRO /" & Format(Val(gdreader(0)), "00000") & "/" & financalyear
                End If
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            Else
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
        Catch ex As Exception
            MessageBox.Show("Check The Error:" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub CashReceipt_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F2 Then
            txt_CRNo.Text = ""
            txt_CRNo.Focus()
        ElseIf e.KeyCode = Keys.F7 Then
            Call Cmd_AddNew_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            Call Cmd_Delete_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            Call Cmd_View_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F10 Then
            Call Cmd_Print_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(sender, e)
            Exit Sub
        End If
    End Sub

    Private Sub txt_CRNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CRNo.Validated
        Dim j, i As Integer
        Dim vString, sqlstring As String
        Dim vTypeseqno As Double
        Dim vGroupseqno As Double
        Dim dt As New DataTable
        Try
            If Trim(txt_CRNo.Text) <> "" Then
                '''************************************************* BILL_HDR ********************************************************************'''
                sqlstring = "SELECT * FROM Receipt_details WHERE  Crono='" & Trim(txt_CRNo.Text) & "'"
                ssGrid.ClearRange(1, 1, -1, -1, True)
                gconnection.getDataSet(sqlstring, "Receipt_details")
                '''************************************************* SELECT record from BILL_hdr *********************************************''''                
                If gdataset.Tables("Receipt_details").Rows.Count > 0 Then
                    KOT_Timer.Enabled = False
                    txt_CRNo.Text = Trim(gdataset.Tables("Receipt_details").Rows(0).Item("crono") & "")
                    dtp_CRdate.Value = Format(CDate(gdataset.Tables("Receipt_details").Rows(0).Item("crodate")), "dd-MMM-yyyy")
                    txt_CashTime.Text = Format(CDate(gdataset.Tables("Receipt_details").Rows(0).Item("crodate")), "hh:mm:ss")
                    'txt_TotalReceived.Text = Format(Val(gdataset.Tables("Receipt_details").Rows(0).Item("") & ""), "0.00")
                    'txt_TotalAmount.Text = Format(Val(gdataset.Tables("Receipt_details").Rows(0).Item("ReceiptAmount") & ""), "0.00")
                    For i = 1 To gdataset.Tables("Receipt_details").Rows.Count
                        ssGrid.SetText(1, i, Trim(gdataset.Tables("Receipt_details").Rows(j).Item("Billno")) & "")
                        ssGrid.SetText(2, i, CDate(gdataset.Tables("Receipt_details").Rows(j).Item("Billdate")))
                        ssGrid.SetText(3, i, 1)
                        ssGrid.SetText(4, i, Format(Val(gdataset.Tables("Receipt_details").Rows(j).Item("Billamount")), "0.00"))
                        ssGrid.SetText(5, i, Format(Val(gdataset.Tables("Receipt_details").Rows(j).Item("Balanceamt")), "0.00"))
                        ssGrid.SetText(6, i, Format(Val(gdataset.Tables("Receipt_details").Rows(j).Item("Amtreceived")), "0.00"))
                        ssGrid.SetText(7, i, CStr(gdataset.Tables("Receipt_details").Rows(j).Item("ServerCode")))
                        ssGrid.SetText(8, i, CStr(gdataset.Tables("Receipt_details").Rows(j).Item("ServerName")))
                        j = j + 1
                    Next i
                    Me.txt_CRNo.ReadOnly = True
                    Me.Cmd_AddNew.Enabled = False
                    Cmd_AddNew.Text = "Update[F7]"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid Billno :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        Finally
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End Try
    End Sub
    Private Sub checkvalidate()
        Dim i As Integer
        chkbool = False
        '''**************************************** Check Payment Mode can't be blank *******************************************''
        If Trim(txt_CRNo.Text) = "" Then
            MessageBox.Show("Payment Mode Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_CRNo.Focus()
            Exit Sub
        End If
        '''**************************************** Check Total Amount can't be blank *******************************************''
        If Val(txt_TotalAmount.Text) = 0 Then
            MessageBox.Show("Total Amount Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_TotalAmount.Focus()
            Exit Sub
        End If
        '''**************************************** Check Received Amount can't be blank *******************************************''
        If Val(txt_TotalReceived.Text) = 0 Then
            MessageBox.Show("Total Received Can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            txt_TotalReceived.Focus()
            Exit Sub
        End If
        '''********************************************* Check ssgrid value can't be blank ********************************************'''
        'With ssGrid
        '    For i = 1 To ssGrid.DataRowCnt
        '        .Row = i
        '        .Col = 1
        '        If Trim(.Text) = "" Then
        '            MessageBox.Show("Bill No. can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '            .SetActiveCell(1, ssGrid.ActiveRow)
        '            .Focus()
        '            Exit Sub
        '        End If
        '        .Col = 2
        '        If Trim(.Text) = "" Then
        '            MessageBox.Show("Bill Date can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '            .SetActiveCell(2, ssGrid.ActiveRow)
        '            .Focus()
        '            Exit Sub
        '        End If
        '        .Col = 3
        '        If Trim(.Text) = "" Then
        '            MessageBox.Show("Bill Amount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '            .SetActiveCell(3, ssGrid.ActiveRow)
        '            .Focus()
        '            Exit Sub
        '        End If
        '        .Col = 4
        '        If Trim(.Text) = "" Then
        '            MessageBox.Show("Received Amount can't be blank", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '            .SetActiveCell(4, ssGrid.ActiveRow)
        '            .Focus()
        '            Exit Sub
        '        End If
        '    Next i
        'End With
        '''************************************************ Total amount must be equal to Received amount ***********************************''
        'If Val(txt_TotalAmount.Text) <> Val(txt_TotalReceived.Text) Then
        '    MessageBox.Show("Total amount must be equal to Received amount", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        '    ssGrid.Focus()
        '    ssGrid.SetActiveCell(5, 1)
        '    Exit Sub
        'End If

        chkbool = True
    End Sub

    Private Sub KOT_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KOT_Timer.Tick
        txt_CashTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub txt_CRNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CRNo.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(txt_CRNo.Text) = "" Then
                Call Cmd_Clear_Click(sender, e)
            Else
                dtp_CRdate.Focus()
            End If
        End If
    End Sub

    Private Sub ssGrid_LeaveCell(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_LeaveCellEvent) Handles ssGrid.LeaveCell
        If ssGrid.ActiveCol = 1 Then
            ssGrid.Col = 1
            ssGrid.Row = ssGrid.ActiveRow
            If Trim(ssGrid.Text) <> "" Then
                ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                Exit Sub
            End If
        ElseIf ssGrid.ActiveCol = 2 Then
            ssGrid.Col = 2
            ssGrid.Row = ssGrid.ActiveRow
            If Trim(ssGrid.Text) <> "" Then
                ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                Exit Sub
            End If
        ElseIf ssGrid.ActiveCol = 3 Then
            ssGrid.Col = 3
            ssGrid.Row = ssGrid.ActiveRow
            If ssGrid.Text <> "" Then
                Call Calculate()
                ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                Exit Sub
            End If
        ElseIf ssGrid.ActiveCol = 4 Then
            ssGrid.Col = 4
            ssGrid.Row = ssGrid.ActiveRow
            If ssGrid.Text <> "" Then
                Call Calculate()
                ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
            End If
        ElseIf ssGrid.ActiveCol = 5 Then
            ssGrid.Col = 6
            ssGrid.Row = ssGrid.ActiveRow
            If ssGrid.Text <> "" Then
                Call Calculate()
                ssGrid.SetActiveCell(6, ssGrid.ActiveRow)
            End If
        ElseIf ssGrid.ActiveCol = 6 Then
            ssGrid.Col = 6
            ssGrid.Row = ssGrid.ActiveRow
            If ssGrid.Text <> "" Then
                Call Calculate()
            End If
        End If
        Dim i
        For i = 1 To ssGrid.DataRowCnt
            Dim amt1 As Double = 0.0
            Dim amt2 As Double = 0.0
            Dim result As Double = 0.0
            ssGrid.Row = i
            ssGrid.Col = 4
            If ssGrid.Value <> "" Then
                amt1 = ssGrid.Value
            Else
                amt1 = 0
            End If
            ssGrid.Col = 6
            If ssGrid.Value <> "" Then
                amt2 = ssGrid.Value
            Else
                amt2 = 0
            End If
            If amt1 <> 0 And amt2 <> 0 Then
                result = amt2 - amt1
            Else
                result = 0
            End If
            ssGrid.SetText(5, i, result)
        Next
    End Sub

    Private Sub ssGrid_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssGrid.KeyDownEvent
        If e.keyCode = Keys.Enter Then
            If ssGrid.ActiveCol = 1 Then
                ssGrid.SetActiveCell(2, ssGrid.ActiveRow)
                Exit Sub
            ElseIf ssGrid.ActiveCol = 2 Then
                ssGrid.SetActiveCell(2, ssGrid.ActiveRow)
                Exit Sub
            ElseIf ssGrid.ActiveCol = 3 Then
                Call Calculate()
                ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                Exit Sub
            ElseIf ssGrid.ActiveCol = 4 Then
                ssGrid.SetActiveCell(4, ssGrid.ActiveRow)
                Exit Sub
            ElseIf ssGrid.ActiveCol = 5 Then
                Call Calculate()
                ssGrid.SetActiveCell(5, ssGrid.ActiveRow)
                Exit Sub
            ElseIf ssGrid.ActiveCol = 6 Then
                Call Calculate()
                ssGrid.SetActiveCell(2, ssGrid.ActiveRow + 1)
                Exit Sub
            End If
        End If
    End Sub
    Private Sub Calculate()
        Dim total, amtreceived As Double
        Dim i, Docno As Integer
        If ssGrid.ActiveCol = 3 Or ssGrid.ActiveCol = 5 Or ssGrid.ActiveCol = 6 Then
            Me.txt_TotalReceived.Text = 0
            Me.Txt_Noofdocument.Text = 0
            For i = 1 To ssGrid.DataRowCnt
                ssGrid.Col = 3
                ssGrid.Row = i
                If ssGrid.Text = "1" Then

                    ssGrid.Col = 6
                    ssGrid.Row = i
                    amtreceived = ssGrid.Text

                    Me.txt_TotalReceived.Text = Format(Val(Me.txt_TotalReceived.Text) + Val(amtreceived), "0.00")
                    Docno = Docno + 1
                    Me.Txt_Noofdocument.Text = Format(Val(Docno), "0")
                End If
            Next i
            i = i - 1
        End If
    End Sub

    Private Sub dtp_CRdate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_CRdate.KeyPress
        Dim billdate As Date
        Dim sqlstring As String
        Dim Billamount, Amtreceived, receiveamount As Double
        Dim i, j As Integer
        Try
            If Asc(e.KeyChar) = 13 Then
                sqlstring = "SELECT Billdetails,BillDate,isnull(Totalamount,0) as totalamount,Scode,Sname FROM Bill_Hdr "
                sqlstring = sqlstring & "WHERE CAST(Convert(varchar(11),BillDate,6) AS DATETIME) = '" & Format(CDate(dtp_CRdate.Value), "yyyy-MM-dd") & "' "
                sqlstring = sqlstring & " AND Isnull(Crostatus,'N')='N' AND PAYMENTMODE  = 'CASH'"
                gconnection.getDataSet(sqlstring, "Bills")
                If gdataset.Tables("Bills").Rows.Count > 0 Then
                    For i = 1 To gdataset.Tables("Bills").Rows.Count
                        ssGrid.SetText(1, i, Trim(gdataset.Tables("Bills").Rows(j).Item("Billdetails")) & "")
                        ssGrid.SetText(2, i, Format(CDate(gdataset.Tables("Bills").Rows(j).Item("billdate")), "dd-MMM-yyyy"))
                        ssGrid.SetText(3, i, 1)
                        ssGrid.SetText(4, i, Format(Val(gdataset.Tables("Bills").Rows(j).Item("Totalamount")), "0.00"))
                        ssGrid.SetText(5, i, "0.00")
                        ssGrid.SetText(6, i, Format(Val(gdataset.Tables("Bills").Rows(j).Item("Totalamount")), "0.00"))
                        ssGrid.SetText(7, i, Trim(gdataset.Tables("Bills").Rows(j).Item("Scode")))
                        ssGrid.SetText(8, i, Trim(gdataset.Tables("Bills").Rows(j).Item("Sname")))
                        Billamount = Billamount + Val(gdataset.Tables("Bills").Rows(j).Item("Totalamount"))
                        ssGrid.Col = 6
                        ssGrid.Row = i
                        Amtreceived = Amtreceived + Val(ssGrid.Text())
                        j = j + 1
                        Txt_Noofdocument.Text = Val(gdataset.Tables("Bills").Rows.Count)
                    Next i
                    sqlstring = "SELECT billno,billdate,billamount,amtreceived,(billamount - amtreceived) as balanceamt,servercode,servername "
                    sqlstring = sqlstring & "FROM Receipt_details WHERE CAST(Convert(varchar(11),BILLDATE,6) AS DATETIME)  ='" & Format(CDate(dtp_CRdate.Value), "yyyy-MM-dd") & "' AND Balanceamt > 0"
                    gconnection.getDataSet(sqlstring, "Receipt_details")
                    If gdataset.Tables("Receipt_details").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("Receipt_details").Rows.Count
                            ssGrid.SetText(1, i, Trim(gdataset.Tables("Receipt_details").Rows(j).Item("billno")) & "")
                            ssGrid.SetText(2, i, Format(CDate(gdataset.Tables("Bills").Rows(j).Item("billdate")), "dd-MMM-yyyy"))
                            ssGrid.SetText(3, i, 1)
                            ssGrid.SetText(4, i, Format(Val(gdataset.Tables("Receipt_details").Rows(j).Item("billamount")), "0.00"))
                            ssGrid.SetText(5, i, Format(Val(gdataset.Tables("Receipt_details").Rows(j).Item("amtreceived")), "0.00"))
                            ssGrid.SetText(6, i, Format(Val(gdataset.Tables("Receipt_details").Rows(j).Item("balanceamt")), "0.00"))
                            ssGrid.SetText(7, i, Trim(gdataset.Tables("Receipt_details").Rows(j).Item("servercode")))
                            ssGrid.SetText(8, i, Trim(gdataset.Tables("Receipt_details").Rows(j).Item("servername")))
                            Billamount = Billamount + Val(gdataset.Tables("Receipt_details").Rows(j).Item("billamount"))
                            ssGrid.Col = 6
                            ssGrid.Row = i
                            Amtreceived = Amtreceived + Val(ssGrid.Text())
                            j = j + 1
                        Next i
                    End If
                    Txt_Noofdocument.Text = Val(gdataset.Tables("Bills").Rows.Count) + Val(gdataset.Tables("Receipt_details").Rows.Count)
                Else
                    sqlstring = "SELECT billno,billdate,billamount,amtreceived,(billamount - amtreceived) as balanceamt,servercode,servername "
                    sqlstring = sqlstring & "FROM Receipt_details WHERE CAST(Convert(varchar(11),BILLDATE,6) AS DATETIME)  ='" & Format(CDate(dtp_CRdate.Value), "yyyy-MM-dd") & "' AND Balanceamt > 0"
                    gconnection.getDataSet(sqlstring, "Receipt_details")
                    If gdataset.Tables("Receipt_details").Rows.Count > 0 Then
                        For i = 1 To gdataset.Tables("Receipt_details").Rows.Count
                            ssGrid.SetText(1, i, Trim(gdataset.Tables("Receipt_details").Rows(j).Item("billno")) & "")
                            ssGrid.SetText(2, i, Format(CDate(gdataset.Tables("Bills").Rows(j).Item("billdate")), "dd-MMM-yyyy"))
                            ssGrid.SetText(3, i, 1)
                            ssGrid.SetText(4, i, Format(Val(gdataset.Tables("Receipt_details").Rows(j).Item("billamount")), "0.00"))
                            ssGrid.SetText(5, i, Format(Val(gdataset.Tables("Receipt_details").Rows(j).Item("amtreceived")), "0.00"))
                            ssGrid.SetText(6, i, Format(Val(gdataset.Tables("Receipt_details").Rows(j).Item("balanceamt")), "0.00"))
                            ssGrid.SetText(7, i, Trim(gdataset.Tables("Receipt_details").Rows(j).Item("servercode")))
                            ssGrid.SetText(8, i, Trim(gdataset.Tables("Receipt_details").Rows(j).Item("servername")))
                            Billamount = Billamount + Val(gdataset.Tables("Receipt_details").Rows(j).Item("billamount"))
                            ssGrid.Col = 6
                            ssGrid.Row = i
                            Amtreceived = Amtreceived + Val(ssGrid.Text())
                            j = j + 1
                        Next i
                        Txt_Noofdocument.Text = Val(gdataset.Tables("Bills").Rows.Count) + Val(gdataset.Tables("Receipt_details").Rows.Count)
                    Else
                        MessageBox.Show("!! Oops !! There is no bill available on Specified date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                        dtp_CRdate.Focus()
                        Exit Sub
                    End If
                End If
                txt_TotalAmount.Text = Format(Val(Billamount), "0.00")
                txt_TotalReceived.Text = Format(Val(Amtreceived), "0.00")
                ssGrid.SetActiveCell(3, ssGrid.ActiveRow)
                ssGrid.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("Check the error : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub

    Private Sub ssGrid_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssGrid.Advance

    End Sub

    Private Sub txt_CRNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_CRNo.TextChanged

    End Sub

    Private Sub ssGrid_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles ssGrid.LostFocus

    End Sub

    Private Sub dtp_CRdate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_CRdate.ValueChanged

    End Sub
End Class
