Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException
Public Class PODdetails
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_ListView As System.Windows.Forms.Button
    Friend WithEvents cmd_AddNew As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Caption As System.Windows.Forms.Label
    Friend WithEvents lbl_MemberAddress As System.Windows.Forms.Label
    Friend WithEvents lbl_MemberCode As System.Windows.Forms.Label
    Friend WithEvents lbl_MemberName As System.Windows.Forms.Label
    Friend WithEvents txt_MemberName As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents lbl_Remarks As System.Windows.Forms.Label
    Friend WithEvents lbl_Designation As System.Windows.Forms.Label
    Friend WithEvents lbl_ReceivedBy As System.Windows.Forms.Label
    Friend WithEvents lbl_Through As System.Windows.Forms.Label
    Friend WithEvents lbl_CouponNumber As System.Windows.Forms.Label
    Friend WithEvents lbl_Dated As System.Windows.Forms.Label
    Friend WithEvents lbl_Amount As System.Windows.Forms.Label
    Friend WithEvents dtp_Dated As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_Amount As System.Windows.Forms.TextBox
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents txt_Designation As System.Windows.Forms.TextBox
    Friend WithEvents txt_ReceivedBy As System.Windows.Forms.TextBox
    Friend WithEvents txt_Through As System.Windows.Forms.TextBox
    Friend WithEvents txt_CouponNumber As System.Windows.Forms.TextBox
    Friend WithEvents grp_POD1 As System.Windows.Forms.GroupBox
    Friend WithEvents grp_POD2 As System.Windows.Forms.GroupBox
    Friend WithEvents grp_POD3 As System.Windows.Forms.GroupBox
    Friend WithEvents grp_POD5 As System.Windows.Forms.GroupBox
    Friend WithEvents grp_POD4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_MemberAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_MemberAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_MemberAddress3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_Membercity As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MemberAddress2 As System.Windows.Forms.Label
    Friend WithEvents lbl_MemberAddress1 As System.Windows.Forms.Label
    Friend WithEvents lbl_MemberAddress3 As System.Windows.Forms.Label
    Friend WithEvents lbl_MemberCity As System.Windows.Forms.Label
    Friend WithEvents lbl_MemeberState As System.Windows.Forms.Label
    Friend WithEvents txt_MemberState As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents cmd_CouponHelp As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_Appdt_c As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Appdt_c As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PODdetails))
        Me.lbl_Remarks = New System.Windows.Forms.Label
        Me.lbl_Designation = New System.Windows.Forms.Label
        Me.lbl_ReceivedBy = New System.Windows.Forms.Label
        Me.lbl_Through = New System.Windows.Forms.Label
        Me.lbl_CouponNumber = New System.Windows.Forms.Label
        Me.lbl_Dated = New System.Windows.Forms.Label
        Me.lbl_Amount = New System.Windows.Forms.Label
        Me.dtp_Dated = New System.Windows.Forms.DateTimePicker
        Me.txt_Amount = New System.Windows.Forms.TextBox
        Me.txt_Remarks = New System.Windows.Forms.TextBox
        Me.txt_Designation = New System.Windows.Forms.TextBox
        Me.txt_ReceivedBy = New System.Windows.Forms.TextBox
        Me.txt_Through = New System.Windows.Forms.TextBox
        Me.txt_CouponNumber = New System.Windows.Forms.TextBox
        Me.lbl_MemberAddress = New System.Windows.Forms.Label
        Me.lbl_MemberCode = New System.Windows.Forms.Label
        Me.lbl_MemberName = New System.Windows.Forms.Label
        Me.txt_MemberName = New System.Windows.Forms.TextBox
        Me.grp_POD1 = New System.Windows.Forms.GroupBox
        Me.cmd_AddNew = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.grp_POD2 = New System.Windows.Forms.GroupBox
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.grp_POD3 = New System.Windows.Forms.GroupBox
        Me.lbl_MemeberState = New System.Windows.Forms.Label
        Me.lbl_MemberCity = New System.Windows.Forms.Label
        Me.lbl_MemberAddress3 = New System.Windows.Forms.Label
        Me.lbl_MemberAddress1 = New System.Windows.Forms.Label
        Me.lbl_MemberAddress2 = New System.Windows.Forms.Label
        Me.txt_MemberState = New System.Windows.Forms.TextBox
        Me.txt_Membercity = New System.Windows.Forms.TextBox
        Me.txt_MemberAddress3 = New System.Windows.Forms.TextBox
        Me.txt_MemberAddress2 = New System.Windows.Forms.TextBox
        Me.txt_MemberAddress1 = New System.Windows.Forms.TextBox
        Me.grp_POD5 = New System.Windows.Forms.GroupBox
        Me.cmb_Appdt_c = New System.Windows.Forms.ComboBox
        Me.btn_Appdt_c = New System.Windows.Forms.Button
        Me.grp_POD4 = New System.Windows.Forms.GroupBox
        Me.cmd_CouponHelp = New System.Windows.Forms.Button
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_ListView = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_Caption = New System.Windows.Forms.Label
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmd_Delete = New System.Windows.Forms.Button
        Me.grp_POD1.SuspendLayout()
        Me.grp_POD2.SuspendLayout()
        Me.grp_POD3.SuspendLayout()
        Me.grp_POD5.SuspendLayout()
        Me.grp_POD4.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Remarks
        '
        Me.lbl_Remarks.AutoSize = True
        Me.lbl_Remarks.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Remarks.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Remarks.Location = New System.Drawing.Point(515, 301)
        Me.lbl_Remarks.Name = "lbl_Remarks"
        Me.lbl_Remarks.Size = New System.Drawing.Size(75, 21)
        Me.lbl_Remarks.TabIndex = 28
        Me.lbl_Remarks.Text = "Remarks "
        '
        'lbl_Designation
        '
        Me.lbl_Designation.AutoSize = True
        Me.lbl_Designation.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Designation.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Designation.Location = New System.Drawing.Point(512, 272)
        Me.lbl_Designation.Name = "lbl_Designation"
        Me.lbl_Designation.Size = New System.Drawing.Size(98, 21)
        Me.lbl_Designation.TabIndex = 27
        Me.lbl_Designation.Text = "Designation "
        '
        'lbl_ReceivedBy
        '
        Me.lbl_ReceivedBy.AutoSize = True
        Me.lbl_ReceivedBy.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ReceivedBy.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ReceivedBy.Location = New System.Drawing.Point(512, 240)
        Me.lbl_ReceivedBy.Name = "lbl_ReceivedBy"
        Me.lbl_ReceivedBy.Size = New System.Drawing.Size(102, 21)
        Me.lbl_ReceivedBy.TabIndex = 26
        Me.lbl_ReceivedBy.Text = "Received By "
        '
        'lbl_Through
        '
        Me.lbl_Through.AutoSize = True
        Me.lbl_Through.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Through.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Through.Location = New System.Drawing.Point(40, 72)
        Me.lbl_Through.Name = "lbl_Through"
        Me.lbl_Through.Size = New System.Drawing.Size(72, 21)
        Me.lbl_Through.TabIndex = 25
        Me.lbl_Through.Text = "Through "
        '
        'lbl_CouponNumber
        '
        Me.lbl_CouponNumber.AutoSize = True
        Me.lbl_CouponNumber.BackColor = System.Drawing.Color.Transparent
        Me.lbl_CouponNumber.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CouponNumber.Location = New System.Drawing.Point(512, 176)
        Me.lbl_CouponNumber.Name = "lbl_CouponNumber"
        Me.lbl_CouponNumber.Size = New System.Drawing.Size(131, 21)
        Me.lbl_CouponNumber.TabIndex = 24
        Me.lbl_CouponNumber.Text = "Coupon Number "
        '
        'lbl_Dated
        '
        Me.lbl_Dated.AutoSize = True
        Me.lbl_Dated.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Dated.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Dated.Location = New System.Drawing.Point(520, 368)
        Me.lbl_Dated.Name = "lbl_Dated"
        Me.lbl_Dated.Size = New System.Drawing.Size(58, 21)
        Me.lbl_Dated.TabIndex = 31
        Me.lbl_Dated.Text = "Dated :"
        '
        'lbl_Amount
        '
        Me.lbl_Amount.AutoSize = True
        Me.lbl_Amount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Amount.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Amount.Location = New System.Drawing.Point(160, 368)
        Me.lbl_Amount.Name = "lbl_Amount"
        Me.lbl_Amount.Size = New System.Drawing.Size(73, 21)
        Me.lbl_Amount.TabIndex = 30
        Me.lbl_Amount.Text = "Amount :"
        '
        'dtp_Dated
        '
        Me.dtp_Dated.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_Dated.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Dated.Location = New System.Drawing.Point(656, 368)
        Me.dtp_Dated.Name = "dtp_Dated"
        Me.dtp_Dated.Size = New System.Drawing.Size(176, 23)
        Me.dtp_Dated.TabIndex = 10
        '
        'txt_Amount
        '
        Me.txt_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Amount.Location = New System.Drawing.Point(240, 368)
        Me.txt_Amount.MaxLength = 10
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.Size = New System.Drawing.Size(184, 23)
        Me.txt_Amount.TabIndex = 9
        Me.txt_Amount.Text = ""
        '
        'txt_Remarks
        '
        Me.txt_Remarks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Remarks.Location = New System.Drawing.Point(656, 304)
        Me.txt_Remarks.MaxLength = 50
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(192, 23)
        Me.txt_Remarks.TabIndex = 8
        Me.txt_Remarks.Text = ""
        '
        'txt_Designation
        '
        Me.txt_Designation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Designation.Location = New System.Drawing.Point(656, 272)
        Me.txt_Designation.MaxLength = 35
        Me.txt_Designation.Name = "txt_Designation"
        Me.txt_Designation.Size = New System.Drawing.Size(192, 23)
        Me.txt_Designation.TabIndex = 7
        Me.txt_Designation.Text = ""
        '
        'txt_ReceivedBy
        '
        Me.txt_ReceivedBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ReceivedBy.Location = New System.Drawing.Point(656, 240)
        Me.txt_ReceivedBy.MaxLength = 35
        Me.txt_ReceivedBy.Name = "txt_ReceivedBy"
        Me.txt_ReceivedBy.Size = New System.Drawing.Size(192, 23)
        Me.txt_ReceivedBy.TabIndex = 6
        Me.txt_ReceivedBy.Text = ""
        '
        'txt_Through
        '
        Me.txt_Through.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Through.Location = New System.Drawing.Point(656, 208)
        Me.txt_Through.MaxLength = 20
        Me.txt_Through.Name = "txt_Through"
        Me.txt_Through.Size = New System.Drawing.Size(192, 23)
        Me.txt_Through.TabIndex = 5
        Me.txt_Through.Text = ""
        '
        'txt_CouponNumber
        '
        Me.txt_CouponNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_CouponNumber.Location = New System.Drawing.Point(185, 37)
        Me.txt_CouponNumber.MaxLength = 20
        Me.txt_CouponNumber.Name = "txt_CouponNumber"
        Me.txt_CouponNumber.Size = New System.Drawing.Size(192, 23)
        Me.txt_CouponNumber.TabIndex = 4
        Me.txt_CouponNumber.Text = ""
        '
        'lbl_MemberAddress
        '
        Me.lbl_MemberAddress.AutoSize = True
        Me.lbl_MemberAddress.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberAddress.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberAddress.Location = New System.Drawing.Point(144, 152)
        Me.lbl_MemberAddress.Name = "lbl_MemberAddress"
        Me.lbl_MemberAddress.Size = New System.Drawing.Size(135, 21)
        Me.lbl_MemberAddress.TabIndex = 22
        Me.lbl_MemberAddress.Text = "Member Address "
        '
        'lbl_MemberCode
        '
        Me.lbl_MemberCode.AutoSize = True
        Me.lbl_MemberCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberCode.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberCode.Location = New System.Drawing.Point(144, 88)
        Me.lbl_MemberCode.Name = "lbl_MemberCode"
        Me.lbl_MemberCode.Size = New System.Drawing.Size(112, 21)
        Me.lbl_MemberCode.TabIndex = 19
        Me.lbl_MemberCode.Text = "Member Code "
        '
        'lbl_MemberName
        '
        Me.lbl_MemberName.AutoSize = True
        Me.lbl_MemberName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberName.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberName.Location = New System.Drawing.Point(512, 96)
        Me.lbl_MemberName.Name = "lbl_MemberName"
        Me.lbl_MemberName.Size = New System.Drawing.Size(115, 21)
        Me.lbl_MemberName.TabIndex = 20
        Me.lbl_MemberName.Text = "Member Name "
        '
        'txt_MemberName
        '
        Me.txt_MemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberName.Location = New System.Drawing.Point(656, 88)
        Me.txt_MemberName.MaxLength = 35
        Me.txt_MemberName.Name = "txt_MemberName"
        Me.txt_MemberName.Size = New System.Drawing.Size(192, 23)
        Me.txt_MemberName.TabIndex = 2
        Me.txt_MemberName.Text = ""
        '
        'grp_POD1
        '
        Me.grp_POD1.BackgroundImage = CType(resources.GetObject("grp_POD1.BackgroundImage"), System.Drawing.Image)
        Me.grp_POD1.Controls.Add(Me.cmd_AddNew)
        Me.grp_POD1.Controls.Add(Me.Label6)
        Me.grp_POD1.Controls.Add(Me.Label3)
        Me.grp_POD1.Location = New System.Drawing.Point(104, 56)
        Me.grp_POD1.Name = "grp_POD1"
        Me.grp_POD1.Size = New System.Drawing.Size(816, 472)
        Me.grp_POD1.TabIndex = 16
        Me.grp_POD1.TabStop = False
        '
        'cmd_AddNew
        '
        Me.cmd_AddNew.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_AddNew.BackgroundImage = CType(resources.GetObject("cmd_AddNew.BackgroundImage"), System.Drawing.Image)
        Me.cmd_AddNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_AddNew.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AddNew.ForeColor = System.Drawing.Color.White
        Me.cmd_AddNew.Location = New System.Drawing.Point(66, 384)
        Me.cmd_AddNew.Name = "cmd_AddNew"
        Me.cmd_AddNew.Size = New System.Drawing.Size(104, 32)
        Me.cmd_AddNew.TabIndex = 11
        Me.cmd_AddNew.Text = "Add New[F5]"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(65, 392)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 30)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Label6"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(96, 295)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(712, 8)
        Me.Label3.TabIndex = 355
        '
        'grp_POD2
        '
        Me.grp_POD2.BackColor = System.Drawing.Color.Transparent
        Me.grp_POD2.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.grp_POD2.Location = New System.Drawing.Point(128, 72)
        Me.grp_POD2.Name = "grp_POD2"
        Me.grp_POD2.Size = New System.Drawing.Size(784, 56)
        Me.grp_POD2.TabIndex = 18
        Me.grp_POD2.TabStop = False
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(312, 16)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MemberCodeHelp.TabIndex = 1
        '
        'grp_POD3
        '
        Me.grp_POD3.BackColor = System.Drawing.Color.Transparent
        Me.grp_POD3.Controls.Add(Me.lbl_MemeberState)
        Me.grp_POD3.Controls.Add(Me.lbl_MemberCity)
        Me.grp_POD3.Controls.Add(Me.lbl_MemberAddress3)
        Me.grp_POD3.Controls.Add(Me.lbl_MemberAddress1)
        Me.grp_POD3.Controls.Add(Me.lbl_MemberAddress2)
        Me.grp_POD3.Controls.Add(Me.txt_MemberState)
        Me.grp_POD3.Controls.Add(Me.txt_Membercity)
        Me.grp_POD3.Controls.Add(Me.txt_MemberAddress3)
        Me.grp_POD3.Controls.Add(Me.txt_MemberAddress2)
        Me.grp_POD3.Controls.Add(Me.txt_MemberAddress1)
        Me.grp_POD3.Location = New System.Drawing.Point(128, 136)
        Me.grp_POD3.Name = "grp_POD3"
        Me.grp_POD3.Size = New System.Drawing.Size(328, 200)
        Me.grp_POD3.TabIndex = 21
        Me.grp_POD3.TabStop = False
        '
        'lbl_MemeberState
        '
        Me.lbl_MemeberState.AutoSize = True
        Me.lbl_MemeberState.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemeberState.Location = New System.Drawing.Point(32, 168)
        Me.lbl_MemeberState.Name = "lbl_MemeberState"
        Me.lbl_MemeberState.Size = New System.Drawing.Size(48, 21)
        Me.lbl_MemeberState.TabIndex = 12
        Me.lbl_MemeberState.Text = "State "
        '
        'lbl_MemberCity
        '
        Me.lbl_MemberCity.AutoSize = True
        Me.lbl_MemberCity.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberCity.Location = New System.Drawing.Point(32, 136)
        Me.lbl_MemberCity.Name = "lbl_MemberCity"
        Me.lbl_MemberCity.Size = New System.Drawing.Size(39, 21)
        Me.lbl_MemberCity.TabIndex = 11
        Me.lbl_MemberCity.Text = "City "
        '
        'lbl_MemberAddress3
        '
        Me.lbl_MemberAddress3.AutoSize = True
        Me.lbl_MemberAddress3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberAddress3.Location = New System.Drawing.Point(32, 104)
        Me.lbl_MemberAddress3.Name = "lbl_MemberAddress3"
        Me.lbl_MemberAddress3.Size = New System.Drawing.Size(80, 21)
        Me.lbl_MemberAddress3.TabIndex = 10
        Me.lbl_MemberAddress3.Text = "Address3 "
        '
        'lbl_MemberAddress1
        '
        Me.lbl_MemberAddress1.AutoSize = True
        Me.lbl_MemberAddress1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberAddress1.Location = New System.Drawing.Point(32, 40)
        Me.lbl_MemberAddress1.Name = "lbl_MemberAddress1"
        Me.lbl_MemberAddress1.Size = New System.Drawing.Size(80, 21)
        Me.lbl_MemberAddress1.TabIndex = 9
        Me.lbl_MemberAddress1.Text = "Address1 "
        '
        'lbl_MemberAddress2
        '
        Me.lbl_MemberAddress2.AutoSize = True
        Me.lbl_MemberAddress2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberAddress2.Location = New System.Drawing.Point(32, 72)
        Me.lbl_MemberAddress2.Name = "lbl_MemberAddress2"
        Me.lbl_MemberAddress2.Size = New System.Drawing.Size(80, 21)
        Me.lbl_MemberAddress2.TabIndex = 8
        Me.lbl_MemberAddress2.Text = "Address2 "
        '
        'txt_MemberState
        '
        Me.txt_MemberState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberState.Enabled = False
        Me.txt_MemberState.Location = New System.Drawing.Point(112, 168)
        Me.txt_MemberState.MaxLength = 50
        Me.txt_MemberState.Multiline = True
        Me.txt_MemberState.Name = "txt_MemberState"
        Me.txt_MemberState.Size = New System.Drawing.Size(184, 24)
        Me.txt_MemberState.TabIndex = 7
        Me.txt_MemberState.Text = ""
        '
        'txt_Membercity
        '
        Me.txt_Membercity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Membercity.Enabled = False
        Me.txt_Membercity.Location = New System.Drawing.Point(112, 136)
        Me.txt_Membercity.MaxLength = 50
        Me.txt_Membercity.Multiline = True
        Me.txt_Membercity.Name = "txt_Membercity"
        Me.txt_Membercity.Size = New System.Drawing.Size(184, 24)
        Me.txt_Membercity.TabIndex = 6
        Me.txt_Membercity.Text = ""
        '
        'txt_MemberAddress3
        '
        Me.txt_MemberAddress3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberAddress3.Enabled = False
        Me.txt_MemberAddress3.Location = New System.Drawing.Point(112, 104)
        Me.txt_MemberAddress3.MaxLength = 50
        Me.txt_MemberAddress3.Multiline = True
        Me.txt_MemberAddress3.Name = "txt_MemberAddress3"
        Me.txt_MemberAddress3.Size = New System.Drawing.Size(184, 24)
        Me.txt_MemberAddress3.TabIndex = 5
        Me.txt_MemberAddress3.Text = ""
        '
        'txt_MemberAddress2
        '
        Me.txt_MemberAddress2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberAddress2.Enabled = False
        Me.txt_MemberAddress2.Location = New System.Drawing.Point(112, 72)
        Me.txt_MemberAddress2.MaxLength = 50
        Me.txt_MemberAddress2.Multiline = True
        Me.txt_MemberAddress2.Name = "txt_MemberAddress2"
        Me.txt_MemberAddress2.Size = New System.Drawing.Size(184, 24)
        Me.txt_MemberAddress2.TabIndex = 4
        Me.txt_MemberAddress2.Text = ""
        '
        'txt_MemberAddress1
        '
        Me.txt_MemberAddress1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberAddress1.Enabled = False
        Me.txt_MemberAddress1.Location = New System.Drawing.Point(112, 40)
        Me.txt_MemberAddress1.MaxLength = 50
        Me.txt_MemberAddress1.Multiline = True
        Me.txt_MemberAddress1.Name = "txt_MemberAddress1"
        Me.txt_MemberAddress1.Size = New System.Drawing.Size(184, 24)
        Me.txt_MemberAddress1.TabIndex = 3
        Me.txt_MemberAddress1.Text = ""
        '
        'grp_POD5
        '
        Me.grp_POD5.BackColor = System.Drawing.Color.Transparent
        Me.grp_POD5.Controls.Add(Me.cmb_Appdt_c)
        Me.grp_POD5.Controls.Add(Me.btn_Appdt_c)
        Me.grp_POD5.Location = New System.Drawing.Point(128, 351)
        Me.grp_POD5.Name = "grp_POD5"
        Me.grp_POD5.Size = New System.Drawing.Size(784, 56)
        Me.grp_POD5.TabIndex = 29
        Me.grp_POD5.TabStop = False
        '
        'cmb_Appdt_c
        '
        Me.cmb_Appdt_c.Location = New System.Drawing.Point(536, 16)
        Me.cmb_Appdt_c.Name = "cmb_Appdt_c"
        Me.cmb_Appdt_c.Size = New System.Drawing.Size(168, 24)
        Me.cmb_Appdt_c.TabIndex = 10
        Me.cmb_Appdt_c.Text = "No Date Is Required"
        Me.cmb_Appdt_c.Visible = False
        '
        'btn_Appdt_c
        '
        Me.btn_Appdt_c.Location = New System.Drawing.Point(704, 19)
        Me.btn_Appdt_c.Name = "btn_Appdt_c"
        Me.btn_Appdt_c.Size = New System.Drawing.Size(16, 20)
        Me.btn_Appdt_c.TabIndex = 9
        Me.btn_Appdt_c.Text = "C"
        Me.btn_Appdt_c.Visible = False
        '
        'grp_POD4
        '
        Me.grp_POD4.BackColor = System.Drawing.Color.Transparent
        Me.grp_POD4.Controls.Add(Me.cmd_CouponHelp)
        Me.grp_POD4.Controls.Add(Me.txt_CouponNumber)
        Me.grp_POD4.Controls.Add(Me.lbl_Through)
        Me.grp_POD4.Location = New System.Drawing.Point(472, 136)
        Me.grp_POD4.Name = "grp_POD4"
        Me.grp_POD4.Size = New System.Drawing.Size(440, 200)
        Me.grp_POD4.TabIndex = 23
        Me.grp_POD4.TabStop = False
        '
        'cmd_CouponHelp
        '
        Me.cmd_CouponHelp.Image = CType(resources.GetObject("cmd_CouponHelp.Image"), System.Drawing.Image)
        Me.cmd_CouponHelp.Location = New System.Drawing.Point(378, 38)
        Me.cmd_CouponHelp.Name = "cmd_CouponHelp"
        Me.cmd_CouponHelp.Size = New System.Drawing.Size(23, 20)
        Me.cmd_CouponHelp.TabIndex = 38
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Exit.BackgroundImage = CType(resources.GetObject("cmd_Exit.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.cmd_Exit.Location = New System.Drawing.Point(720, 440)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 15
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(112, 496)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Press [F4] For Help"
        '
        'cmd_Clear
        '
        Me.cmd_Clear.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Clear.BackgroundImage = CType(resources.GetObject("cmd_Clear.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.cmd_Clear.Location = New System.Drawing.Point(584, 440)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 14
        Me.cmd_Clear.Text = "Clear[F6]"
        '
        'cmd_ListView
        '
        Me.cmd_ListView.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_ListView.BackgroundImage = CType(resources.GetObject("cmd_ListView.BackgroundImage"), System.Drawing.Image)
        Me.cmd_ListView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_ListView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ListView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ListView.ForeColor = System.Drawing.Color.White
        Me.cmd_ListView.Location = New System.Drawing.Point(296, 440)
        Me.cmd_ListView.Name = "cmd_ListView"
        Me.cmd_ListView.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ListView.TabIndex = 12
        Me.cmd_ListView.Text = "List View [F8]"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(296, 448)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 30)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(584, 448)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 30)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Label9"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(720, 448)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 30)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Label2"
        '
        'lbl_Caption
        '
        Me.lbl_Caption.AutoSize = True
        Me.lbl_Caption.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Caption.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Caption.Location = New System.Drawing.Point(408, 24)
        Me.lbl_Caption.Name = "lbl_Caption"
        Me.lbl_Caption.Size = New System.Drawing.Size(175, 31)
        Me.lbl_Caption.TabIndex = 17
        Me.lbl_Caption.Text = "POD DETAILS"
        Me.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberCode.Location = New System.Drawing.Point(248, 88)
        Me.txt_MemberCode.MaxLength = 15
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(192, 23)
        Me.txt_MemberCode.TabIndex = 0
        Me.txt_MemberCode.Text = ""
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(440, 448)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 30)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Label7"
        '
        'cmd_Delete
        '
        Me.cmd_Delete.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Delete.BackgroundImage = CType(resources.GetObject("cmd_Delete.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Delete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Delete.ForeColor = System.Drawing.Color.White
        Me.cmd_Delete.Location = New System.Drawing.Point(440, 440)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Delete.TabIndex = 13
        Me.cmd_Delete.Text = "Delete[F7]"
        '
        'PODdetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_MemberCode)
        Me.Controls.Add(Me.lbl_Caption)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_Remarks)
        Me.Controls.Add(Me.lbl_Designation)
        Me.Controls.Add(Me.lbl_ReceivedBy)
        Me.Controls.Add(Me.lbl_CouponNumber)
        Me.Controls.Add(Me.lbl_Dated)
        Me.Controls.Add(Me.lbl_Amount)
        Me.Controls.Add(Me.txt_Amount)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.txt_Designation)
        Me.Controls.Add(Me.txt_ReceivedBy)
        Me.Controls.Add(Me.txt_Through)
        Me.Controls.Add(Me.lbl_MemberAddress)
        Me.Controls.Add(Me.lbl_MemberCode)
        Me.Controls.Add(Me.lbl_MemberName)
        Me.Controls.Add(Me.txt_MemberName)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_ListView)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtp_Dated)
        Me.Controls.Add(Me.grp_POD2)
        Me.Controls.Add(Me.grp_POD4)
        Me.Controls.Add(Me.grp_POD3)
        Me.Controls.Add(Me.grp_POD5)
        Me.Controls.Add(Me.grp_POD1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "PODdetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "POD DETAILS"
        Me.grp_POD1.ResumeLayout(False)
        Me.grp_POD2.ResumeLayout(False)
        Me.grp_POD3.ResumeLayout(False)
        Me.grp_POD5.ResumeLayout(False)
        Me.grp_POD4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim boolchk As Boolean
    Dim SqlString As String
    Dim gconnection As New globalClass
    Private Sub txt_MemberCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MemberCode.KeyDown
        If e.KeyCode = Keys.Enter And Trim(txt_MemberCode.Text) <> "" Then
            Dim vform As New ListOperation
            Dim SQLSTR, sqlstr1 As String
            Dim DR, dr1 As SqlDataReader
            Dim posting As DataTable
            Dim STR As String
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter
            gSQLString = "SELECT MCODE,MNAME FROM membermaster where mcode='" & txt_MemberCode.Text & "'"
            posting = gconnection.GetValues(gSQLString)
            If posting.Rows.Count > 0 Then
                txt_MemberName.Text = posting.Rows(0).Item("mname")
                txt_MemberName.Focus()
            End If
            gconnection.closeConnection()
            SqlString = "SELECT count(MCODE) FROM PODDETAILS WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
            gconnection.openConnection()
            gcommand = New SqlCommand(SqlString, gconnection.Myconn)
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) = 0 Then
                    cmd_AddNew.Text = "Add New[F5]"
                    'sqlstr1 = "select contadd1,contadd2,contadd3,contcity,contstate,contcountry,contpin,contphone1, contcell,contemail from membermaster where mcode = '" & txt_MemberCode.Text & "'"
                    sqlstr1 = "select ISNULL(contadd1,'') AS contadd1,ISNULL(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contcity,'') as contcity, isnull(contstate,'') as contstate,isnull(contcountry,'') as contcountry,isnull(contpin,'') as contpin,isnull(contphone1,'') as contphone1, isnull(contcell,'') as contcell,isnull(contemail,'') as contemail from membermaster where mcode = '" & txt_MemberCode.Text & "'"
                    gconnection.closeConnection()
                    gconnection.openConnection()
                    gcommand = New SqlCommand(sqlstr1, gconnection.Myconn)
                    dr1 = gcommand.ExecuteReader
                    If dr1.Read Then
                        txt_MemberAddress1.Text = dr1("CONTADD1")
                        txt_MemberAddress2.Text = dr1("CONTADD2")
                        txt_MemberAddress3.Text = dr1("CONTADD3")
                        txt_Membercity.Text = dr1("CONTCITY")
                        txt_MemberState.Text = dr1("CONTSTATE")
                    End If
                    dr1.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                Else
                    'sqlstr1 = "select contadd1,contadd2,contadd3,contcity,contstate,contcountry,contpin,contphone1, contcell,contemail from membermaster where mcode = '" & txt_MemberCode.Text & "'"
                    gconnection.closeConnection()
                    sqlstr1 = "select ISNULL(contadd1,'') AS contadd1,ISNULL(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contcity,'') as contcity, isnull(contstate,'') as contstate,isnull(contcountry,'') as contcountry,isnull(contpin,'') as contpin,isnull(contphone1,'') as contphone1, isnull(contcell,'') as contcell,isnull(contemail,'') as contemail from membermaster where mcode = '" & txt_MemberCode.Text & "'"
                    gconnection.openConnection()
                    gcommand = New SqlCommand(sqlstr1, gconnection.Myconn)
                    ''If Not dr1.IsClosed Then
                    ''    dr1.Close()
                    ''End If
                    dr1 = gcommand.ExecuteReader
                    If dr1.Read Then
                        txt_MemberAddress1.Text = dr1("CONTADD1")
                        txt_MemberAddress2.Text = dr1("CONTADD2")
                        txt_MemberAddress3.Text = dr1("CONTADD3")
                        txt_Membercity.Text = dr1("CONTCITY")
                        txt_MemberState.Text = dr1("CONTSTATE")
                    End If
                    dr1.Close()
                    gcommand.Dispose()
                    gconnection.closeConnection()
                End If
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            Else
                gdreader.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
            txt_MemberName.Focus()
        Else
            Call cmd_MemberCodeHelp_Click(sender, e)
        End If
        If e.KeyCode = Keys.F4 Then
            Call cmd_MemberCodeHelp_Click(sender, e)
        End If
    End Sub
    Private Sub txt_MemberName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MemberName.KeyDown
        If e.KeyCode = Keys.Enter Then
            'txt_MemberAddress.Focus()
        End If
    End Sub
    Private Sub txt_MemberAddress_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MemberAddress1.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_CouponNumber.Focus()
        End If
    End Sub
    Private Sub txt_CouponNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_CouponNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Through.Focus()
        End If
        If e.KeyCode = Keys.F4 Then
            cmd_CouponHelp_Click(sender, e)
        End If
    End Sub
    Private Sub txt_Through_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Through.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ReceivedBy.Focus()
        End If
    End Sub
    Private Sub txt_ReceivedBy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ReceivedBy.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Designation.Focus()
        End If
    End Sub
    Private Sub txt_Designation_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Designation.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Remarks.Focus()
        End If
    End Sub
    Private Sub txt_Remarks_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Remarks.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Amount.Focus()
        End If
    End Sub
    Private Sub txt_Amount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Amount.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_Dated.Focus()
        End If
    End Sub
    Private Sub dtp_Dated_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Dated.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd_AddNew.Focus()
        End If
    End Sub
    Private Sub txt_Amount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Amount.LostFocus
        txt_Amount.Text = Format(Val(txt_Amount.Text), "0.00")
    End Sub
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
            Me.Close()
        Else
            txt_MemberCode.Focus()
        End If
    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        clearform(Me)
        Me.txt_MemberCode.Enabled = True
        Me.txt_CouponNumber.Enabled = True
        Me.txt_MemberCode.Focus()
        txt_MemberAddress1.Text = ""
        txt_MemberAddress2.Text = ""
        txt_MemberAddress3.Text = ""
        txt_Membercity.Text = ""
        txt_MemberState.Text = ""
        txt_CouponNumber.Text = ""
        txt_MemberCode.Focus()
        Me.cmd_AddNew.Text = "Add New[F5]"
    End Sub
    Private Sub txt_MemberCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberCode.KeyPress
        getAlphanumeric(e)
    End Sub
    Private Sub txt_MemberName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberName.KeyPress
        getCharater(e)
        If Asc(e.KeyChar) = Keys.Enter Then
            txt_CouponNumber.Focus()
        End If
    End Sub
    Private Sub txt_MemberAddress_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberAddress1.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub txt_CouponNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_CouponNumber.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub txt_Through_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Through.KeyPress
        getCharater(e)
    End Sub
    Private Sub txt_ReceivedBy_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ReceivedBy.KeyPress
        getCharater(e)
    End Sub
    Private Sub txt_Designation_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Designation.KeyPress
        getCharater(e)
    End Sub
    Private Sub txt_Remarks_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Remarks.KeyPress
        getAlphanumeric(e)
    End Sub
    Private Sub txt_Amount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Amount.KeyPress
        getNumeric(e)
    End Sub
    Private Sub cmd_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AddNew.Click
        Dim address As String
        Dim dt As New DataTable
        'address = txt_MemberAddress1.Text & " " & txt_MemberAddress2.Text & " " & txt_MemberAddress3.Text & " " & txt_Membercity.Text
        address = txt_MemberAddress1.Text
        Try
            If cmd_AddNew.Text = "Add New[F5]" Then
                '''******************************************************** Insert record into PODdetails **************************************************************'''
                Call checkValidation() '''---> CHECK VALIDATION
                gconnection.closeConnection()
                If boolchk = False Then Exit Sub
                SqlString = "INSERT INTO  PODdetails "
                SqlString = SqlString & "(MCode,Mname,Maddress,Couponno,Through,Receivedby,Designation,Remarks,Amount,Dated,UserId, AddDate)VALUES ('" & Trim(txt_MemberCode.Text) & " ' , '"
                SqlString = SqlString & Trim(txt_MemberName.Text) & "' , '" & Trim(address) & "' , '" & Trim(txt_CouponNumber.Text) & "' , '" & Trim(txt_Through.Text) & " ','" & Trim(txt_ReceivedBy.Text) & " ','"
                SqlString = SqlString & Trim(txt_Designation.Text) & " ','" & Trim(txt_Remarks.Text) & " '," & Val(txt_Amount.Text) & " ,'" & Format(dtp_Dated.Value, "dd-MMM-yy") & "','" & gUsername & "' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
                gconnection.dataOperation(1, SqlString, "MemberType")
                'dt = gconnection.ExcuteStoreProcedure(SqlString)
                MessageBox.Show("Record Saved ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)
            ElseIf cmd_AddNew.Text = "Update[F5]" Then
                '''******************************************************** Update record into PODdetails **************************************************************'''
                Call checkValidation() '''---> CHECK VALIDATION
                gconnection.closeConnection()
                If boolchk = False Then Exit Sub
                SqlString = "UPDATE  PODdetails SET Mname = '"
                SqlString = SqlString & Trim(txt_MemberName.Text) & "',Maddress ='" & Trim(address) & "' ,Couponno='" & Trim(txt_CouponNumber.Text) & "',Through='" & Trim(txt_Through.Text) & "',"
                SqlString = SqlString & " Receivedby = '" & Trim(txt_ReceivedBy.Text) & " ',Designation='" & Trim(txt_Designation.Text) & " ',Remarks='" & Trim(txt_Remarks.Text) & " ',Amount=" & Val(txt_Amount.Text) & ","
                SqlString = SqlString & " USERID ='" & gUsername & "',ADDDATE='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
                SqlString = SqlString & " WHERE MCode = '" & txt_MemberCode.Text & "'"
                gconnection.dataOperation(2, SqlString, "membertype")
                'dt = gconnection.ExcuteStoreProcedure(SqlString)
                MessageBox.Show("Record Updated ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cmd_Clear_Click(sender, e)
                cmd_AddNew.Text = "Add New[F5]"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub
    Public Sub checkValidation()
        boolchk = False
        '''********** Check Member Code is blank
        If txt_MemberCode.Text = "" Then
            MessageBox.Show(" Member Code can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_MemberCode.Focus()
            Exit Sub
        End If
        '''********** Check Member Name is blank
        If txt_MemberName.Text = "" Then
            MessageBox.Show(" Member Name can't be blank ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_MemberName.Focus()
            Exit Sub
        End If

        boolchk = True
    End Sub

    Private Sub PODdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PODdetailsbool = True
        If gUserCategory <> "S" Then
            Call GetRights()
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
        Me.cmd_AddNew.Enabled = False
        Me.cmd_Delete.Enabled = False
        Me.cmd_ListView.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmd_AddNew.Enabled = True
                    Me.cmd_Delete.Enabled = True
                    Me.cmd_ListView.Enabled = True
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
                    Me.cmd_ListView.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub PODdetails_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        PODdetailsbool = False
    End Sub
    Private Sub cmd_ListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ListView.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM PODdetails"
        Gheader = "POD DETAILS"
        FrReport.SsGridReport.SetText(2, 1, "MCODE")
        FrReport.SsGridReport.SetText(3, 1, 15)
        FrReport.SsGridReport.SetText(2, 2, "MNAME")
        FrReport.SsGridReport.SetText(3, 2, 50)
        FrReport.SsGridReport.SetText(2, 3, "MADDRESS")
        FrReport.SsGridReport.SetText(3, 3, 35)
        FrReport.SsGridReport.SetText(2, 4, "COUPONNO")
        FrReport.SsGridReport.SetText(3, 4, 20)
        FrReport.SsGridReport.SetText(2, 5, "THROUGH")
        FrReport.SsGridReport.SetText(3, 5, 20)
        FrReport.SsGridReport.SetText(2, 6, "RECEIVEDBY")
        FrReport.SsGridReport.SetText(3, 6, 35)
        FrReport.SsGridReport.SetText(2, 7, "DESIGNATION")
        FrReport.SsGridReport.SetText(3, 7, 50)
        FrReport.SsGridReport.SetText(2, 8, "REMARKS")
        FrReport.SsGridReport.SetText(3, 8, 50)
        FrReport.SsGridReport.SetText(2, 9, "AMOUNT")
        FrReport.SsGridReport.SetText(3, 9, 8)
        FrReport.Show()
    End Sub
    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
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
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            txt_MemberCode.Text = Trim(vform.keyfield & "")
            txt_MemberName.Text = Trim(vform.keyfield1)
        End If
        vform.Close()
        vform = Nothing
        gconnection.closeConnection()
        SqlString = "SELECT count(MCODE) FROM PODDETAILS WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
        gconnection.openConnection()
        gcommand = New SqlCommand(SqlString, gconnection.Myconn)
        gdreader = gcommand.ExecuteReader
        If gdreader.Read Then
            If gdreader(0) = 0 Then
                cmd_AddNew.Text = "Add New[F5]"
                sqlstr1 = "select ISNULL(contadd1,'') AS contadd1,ISNULL(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contcity,'') as contcity, isnull(contstate,'') as contstate,isnull(contcountry,'') as contcountry,isnull(contpin,'') as contpin,isnull(contphone1,'') as contphone1, isnull(contcell,'') as contcell,isnull(contemail,'') as contemail from membermaster where mcode = '" & txt_MemberCode.Text & "'"
                gconnection.closeConnection()
                gconnection.openConnection()
                gcommand = New SqlCommand(sqlstr1, gconnection.Myconn)
                dr1 = gcommand.ExecuteReader
                If dr1.Read Then
                    txt_MemberAddress1.Text = dr1("CONTADD1")
                    txt_MemberAddress2.Text = dr1("CONTADD2")
                    txt_MemberAddress3.Text = dr1("CONTADD3")
                    txt_Membercity.Text = dr1("CONTCITY")
                    txt_MemberState.Text = dr1("CONTSTATE")
                End If
                dr1.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            Else
                gconnection.closeConnection()
                'sqlstr1 = "select contadd1,contadd2,contadd3,contcity,contstate,contcountry,contpin,contphone1, contcell,contemail from membermaster where mcode = '" & txt_MemberCode.Text & "'"
                sqlstr1 = "select ISNULL(contadd1,'') AS contadd1,ISNULL(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contcity,'') as contcity, isnull(contstate,'') as contstate,isnull(contcountry,'') as contcountry,isnull(contpin,'') as contpin,isnull(contphone1,'') as contphone1, isnull(contcell,'') as contcell,isnull(contemail,'') as contemail from membermaster where mcode = '" & txt_MemberCode.Text & "'"
                gconnection.openConnection()
                gcommand = New SqlCommand(sqlstr1, gconnection.Myconn)
                ''If Not dr1.IsClosed Then
                ''    dr1.Close()
                ''End If
                dr1 = gcommand.ExecuteReader
                If dr1.Read Then
                    txt_MemberAddress1.Text = dr1("CONTADD1")
                    txt_MemberAddress2.Text = dr1("CONTADD2")
                    txt_MemberAddress3.Text = dr1("CONTADD3")
                    txt_Membercity.Text = dr1("CONTCITY")
                    txt_MemberState.Text = dr1("CONTSTATE")
                End If
                dr1.Close()
                gcommand.Dispose()
                gconnection.closeConnection()
            End If
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        Else
            gdreader.Close()
            gcommand.Dispose()
            gconnection.closeConnection()
        End If
    End Sub
    Private Sub cmd_CouponHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_CouponHelp.Click
        Dim vform As New ListOperation
        Dim SQLSTR As String
        Dim DR As SqlDataReader
        Dim STR As String
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        listop = txt_MemberCode.Text & "'"
        gSQLString = "SELECT mcode,couponno FROM poddetails"
        M_WhereCondition = " "
        vform.Field = "MCODE,couponno"
        vform.vFormatstring = "  Member Code  | Coupon No                           "
        vform.vCaption = "Member Master Help"
        vform.KeyPos = 0
        vform.KeyPos1 = 1
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            'txt_MemberCode.Text = Trim(vform.keyfield & "")
            txt_CouponNumber.Text = Trim(vform.keyfield1)
        End If
        vform.Close()
        vform = Nothing
        SQLSTR = "select * from poddetails where mcode = '" & txt_MemberCode.Text & "' and couponno = '" & txt_CouponNumber.Text & "'"
        gconnection.closeConnection()
        gconnection.openConnection()
        gcommand = New SqlCommand(SQLSTR, gconnection.Myconn)
        DR = gcommand.ExecuteReader
        If DR.Read Then
            txt_Through.Text = DR("through")
            txt_ReceivedBy.Text = DR("receivedby")
            txt_Designation.Text = DR("designation")
            txt_Remarks.Text = DR("remarks")
            txt_Amount.Text = Format(DR("amount"), "0.00")
            If Format(DR("dated"), "dd-MMM-yyyy") = "01-Jan-1900" Then
                btn_Appdt_c.Text = "C"
                btn_Appdt_c_FUN()
            Else
                Me.dtp_Dated.Value = Format(DR("dated"), "dd-MMM-yyyy")
            End If
            'dtp_Dated.Value = Format(DR("dated"), "dd-MMM-yyyy")
            cmd_AddNew.Text = "Update[F5]"
            txt_CouponNumber.Enabled = False
        End If
        DR.Close()
        gcommand.Dispose()
        gconnection.closeConnection()
    End Sub
    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Delete.Click
        Call checkValidation()
        SqlString = "delete from poddetails where mcode = '" & txt_MemberCode.Text & "' and  couponno = '" & txt_CouponNumber.Text & "'"
        gconnection.dataOperation(6, SqlString, "MemberType")
        MessageBox.Show("Record deleted", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clearform(Me)
        txt_MemberAddress1.Text = ""
        txt_MemberAddress2.Text = ""
        txt_MemberAddress3.Text = ""
        txt_Membercity.Text = ""
        txt_MemberState.Text = ""
    End Sub
    Private Sub txt_CouponNumber_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_CouponNumber.LostFocus
        Dim dr As SqlDataReader
        Dim cmd As New SqlCommand
        If cmd_AddNew.Text = "Add New[F5]" Then
            SqlString = "select * from poddetails where mcode = '" & txt_MemberCode.Text & "'"
            gconnection.openConnection()
            cmd = New SqlCommand(SqlString, gconnection.Myconn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                Do
                    If dr("couponno") = txt_CouponNumber.Text Then
                        txt_Through.Text = dr("through")
                        txt_ReceivedBy.Text = dr("receivedby")
                        txt_Designation.Text = dr("designation")
                        txt_Remarks.Text = dr("remarks")
                        txt_Amount.Text = Format(dr("amount"), "0.00")
                        dtp_Dated.Value = Format(dr("dated"), "dd-MMM-yy")
                        txt_CouponNumber.Enabled = False
                        cmd_AddNew.Text = "Update[F5]"
                        Exit Sub
                    End If
                Loop Until Not dr.Read
                dr.Close()
                cmd.Dispose()
                gconnection.closeConnection()
            End If
        End If
    End Sub
    Private Sub PODdetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call cmd_AddNew_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call cmd_Clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            Call cmd_ListView_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F7 Then
            Call cmd_Delete_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call cmd_Exit_Click(sender, e)
            Exit Sub
        End If
    End Sub
    Private Sub txt_MemberCode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_MemberCode.Validated
        Dim strsql As String
        Dim codeTable As New DataTable
        If txt_MemberCode.Text <> "" Then
            strsql = " SELECT *  FROM Membermaster WHERE mcode='" & Me.txt_MemberCode.Text & "'"
            codeTable = gconnection.GetValues(strsql)
            If codeTable.Rows.Count <= 0 Then
                txt_MemberCode.Focus()
            End If
        End If
    End Sub
    Private Sub txt_MemberCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt_MemberCode.TextChanged

    End Sub
    Public Function btn_Appdt_c_FUN()
        If btn_Appdt_c.Text = "C" Then
            cmb_Appdt_c.Visible = True
            dtp_Dated.Visible = False
            btn_Appdt_c.Text = "E"
            'Appdt_c_VAL = ""
        ElseIf btn_Appdt_c.Text = "E" Then
            'Appdt_c_VAL = ""
            cmb_Appdt_c.Visible = False
            dtp_Dated.Visible = True
            btn_Appdt_c.Text = "C"
            'Appdt_c_VAL = Format(dtp_DateApplication.Value, "dd-MMM-yy")
        End If
    End Function
    Private Sub btn_Appdt_c_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Appdt_c.Click
        '        btn_Appdt_c_FUN()
    End Sub
End Class
