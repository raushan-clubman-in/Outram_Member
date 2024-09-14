Imports System.IO
Imports System.IO.File
Imports System.Drawing.Printing
Imports System.Drawing.Font
Imports System.Drawing.Brushes
Public Class ID_Card_Print
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents lblEmail As System.Windows.Forms.Label
    Public WithEvents lblmcode As System.Windows.Forms.Label
    Public WithEvents lblCompany As System.Windows.Forms.Label
    Public WithEvents lblname As System.Windows.Forms.Label
    Public WithEvents lbladd3 As System.Windows.Forms.Label
    Public WithEvents lblType As System.Windows.Forms.Label
    Public WithEvents lbladd1 As System.Windows.Forms.Label
    Public WithEvents lbladd2 As System.Windows.Forms.Label
    Public WithEvents lblcity As System.Windows.Forms.Label
    Public WithEvents lblstate As System.Windows.Forms.Label
    Public WithEvents lblpin As System.Windows.Forms.Label
    Public WithEvents lblphone1 As System.Windows.Forms.Label
    Public WithEvents lblphone2 As System.Windows.Forms.Label
    Public WithEvents lblcellno As System.Windows.Forms.Label
    Public WithEvents PImage As System.Windows.Forms.PictureBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Txt_Mcode As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents lbldoj As System.Windows.Forms.Label
    Public WithEvents lbldoe As System.Windows.Forms.Label
    Friend WithEvents btnPrintWithDialog As System.Windows.Forms.Button
    Friend WithEvents btnPrintPreview As System.Windows.Forms.Button
    Friend WithEvents dlgPrintPreview As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents dlgPrint As System.Windows.Forms.PrintDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ID_Card_Print))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.lbldoj = New System.Windows.Forms.Label
        Me.lbldoe = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.PImage = New System.Windows.Forms.PictureBox
        Me.lblEmail = New System.Windows.Forms.Label
        Me.lblmcode = New System.Windows.Forms.Label
        Me.lblCompany = New System.Windows.Forms.Label
        Me.lblname = New System.Windows.Forms.Label
        Me.lbladd3 = New System.Windows.Forms.Label
        Me.lblType = New System.Windows.Forms.Label
        Me.lbladd1 = New System.Windows.Forms.Label
        Me.lbladd2 = New System.Windows.Forms.Label
        Me.lblcity = New System.Windows.Forms.Label
        Me.lblstate = New System.Windows.Forms.Label
        Me.lblpin = New System.Windows.Forms.Label
        Me.lblphone1 = New System.Windows.Forms.Label
        Me.lblphone2 = New System.Windows.Forms.Label
        Me.lblcellno = New System.Windows.Forms.Label
        Me.Txt_Mcode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.btnPrintWithDialog = New System.Windows.Forms.Button
        Me.btnPrintPreview = New System.Windows.Forms.Button
        Me.dlgPrintPreview = New System.Windows.Forms.PrintPreviewDialog
        Me.dlgPrint = New System.Windows.Forms.PrintDialog
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.lbldoj)
        Me.GroupBox2.Controls.Add(Me.lbldoe)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.PImage)
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
        Me.GroupBox2.Location = New System.Drawing.Point(40, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(648, 376)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Maroon
        Me.Label16.Location = New System.Drawing.Point(464, 240)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(51, 21)
        Me.Label16.TabIndex = 70
        Me.Label16.Text = "DOJ : "
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Maroon
        Me.Label17.Location = New System.Drawing.Point(464, 264)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(53, 21)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "DOE : "
        '
        'lbldoj
        '
        Me.lbldoj.AutoSize = True
        Me.lbldoj.BackColor = System.Drawing.Color.Transparent
        Me.lbldoj.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbldoj.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldoj.ForeColor = System.Drawing.Color.Crimson
        Me.lbldoj.Location = New System.Drawing.Point(520, 240)
        Me.lbldoj.Name = "lbldoj"
        Me.lbldoj.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldoj.Size = New System.Drawing.Size(62, 21)
        Me.lbldoj.TabIndex = 68
        Me.lbldoj.Text = "lblAdd1"
        '
        'lbldoe
        '
        Me.lbldoe.AutoSize = True
        Me.lbldoe.BackColor = System.Drawing.Color.Transparent
        Me.lbldoe.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbldoe.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldoe.ForeColor = System.Drawing.Color.Crimson
        Me.lbldoe.Location = New System.Drawing.Point(520, 264)
        Me.lbldoe.Name = "lbldoe"
        Me.lbldoe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldoe.Size = New System.Drawing.Size(62, 21)
        Me.lbldoe.TabIndex = 67
        Me.lbldoe.Text = "lblAdd2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(51, 344)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(67, 21)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "EMAIL : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(35, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(85, 21)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "M. CODE : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(23, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(94, 21)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "COMPANY :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(55, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(60, 21)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "NAME :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Maroon
        Me.Label6.Location = New System.Drawing.Point(15, 178)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(103, 21)
        Me.Label6.TabIndex = 66
        Me.Label6.Text = "ADDRESS 3 :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Maroon
        Me.Label7.Location = New System.Drawing.Point(17, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(102, 21)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "CATEGORY :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(14, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(103, 21)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "ADDRESS 1 :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Maroon
        Me.Label9.Location = New System.Drawing.Point(15, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(103, 21)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "ADDRESS 2 :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Maroon
        Me.Label10.Location = New System.Drawing.Point(62, 199)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(50, 21)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "CITY :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Maroon
        Me.Label11.Location = New System.Drawing.Point(48, 222)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(70, 21)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "STATE : "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Maroon
        Me.Label12.Location = New System.Drawing.Point(24, 246)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(90, 21)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "PIN CODE :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Maroon
        Me.Label13.Location = New System.Drawing.Point(31, 268)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(87, 21)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "PHONE 1 : "
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Maroon
        Me.Label14.Location = New System.Drawing.Point(32, 291)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(87, 21)
        Me.Label14.TabIndex = 57
        Me.Label14.Text = "PHONE 2 : "
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Maroon
        Me.Label15.Location = New System.Drawing.Point(32, 318)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(83, 21)
        Me.Label15.TabIndex = 56
        Me.Label15.Text = "CELL NO :"
        '
        'PImage
        '
        Me.PImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PImage.Cursor = System.Windows.Forms.Cursors.Default
        Me.PImage.Location = New System.Drawing.Point(480, 16)
        Me.PImage.Name = "PImage"
        Me.PImage.Size = New System.Drawing.Size(152, 160)
        Me.PImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PImage.TabIndex = 52
        Me.PImage.TabStop = False
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.ForeColor = System.Drawing.Color.Crimson
        Me.lblEmail.Location = New System.Drawing.Point(136, 344)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblEmail.Size = New System.Drawing.Size(65, 21)
        Me.lblEmail.TabIndex = 27
        Me.lblEmail.Text = "lblEmail"
        '
        'lblmcode
        '
        Me.lblmcode.AutoSize = True
        Me.lblmcode.BackColor = System.Drawing.Color.Transparent
        Me.lblmcode.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblmcode.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmcode.ForeColor = System.Drawing.Color.Crimson
        Me.lblmcode.Location = New System.Drawing.Point(136, 48)
        Me.lblmcode.Name = "lblmcode"
        Me.lblmcode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblmcode.Size = New System.Drawing.Size(73, 21)
        Me.lblmcode.TabIndex = 26
        Me.lblmcode.Text = "lblmcode"
        '
        'lblCompany
        '
        Me.lblCompany.AutoSize = True
        Me.lblCompany.BackColor = System.Drawing.Color.Transparent
        Me.lblCompany.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblCompany.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompany.ForeColor = System.Drawing.Color.Crimson
        Me.lblCompany.Location = New System.Drawing.Point(136, 77)
        Me.lblCompany.Name = "lblCompany"
        Me.lblCompany.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblCompany.Size = New System.Drawing.Size(134, 21)
        Me.lblCompany.TabIndex = 24
        Me.lblCompany.Text = "lblCompanyname"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.BackColor = System.Drawing.Color.Transparent
        Me.lblname.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblname.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.ForeColor = System.Drawing.Color.Crimson
        Me.lblname.Location = New System.Drawing.Point(136, 107)
        Me.lblname.Name = "lblname"
        Me.lblname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblname.Size = New System.Drawing.Size(64, 21)
        Me.lblname.TabIndex = 36
        Me.lblname.Text = "lblname"
        '
        'lbladd3
        '
        Me.lbladd3.AutoSize = True
        Me.lbladd3.BackColor = System.Drawing.Color.Transparent
        Me.lbladd3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbladd3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd3.ForeColor = System.Drawing.Color.Crimson
        Me.lbladd3.Location = New System.Drawing.Point(136, 178)
        Me.lbladd3.Name = "lbladd3"
        Me.lbladd3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbladd3.Size = New System.Drawing.Size(62, 21)
        Me.lbladd3.TabIndex = 49
        Me.lbladd3.Text = "lblAdd3"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.BackColor = System.Drawing.Color.Transparent
        Me.lblType.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblType.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.ForeColor = System.Drawing.Color.Crimson
        Me.lblType.Location = New System.Drawing.Point(136, 21)
        Me.lblType.Name = "lblType"
        Me.lblType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblType.Size = New System.Drawing.Size(55, 21)
        Me.lblType.TabIndex = 37
        Me.lblType.Text = "lbltype"
        '
        'lbladd1
        '
        Me.lbladd1.AutoSize = True
        Me.lbladd1.BackColor = System.Drawing.Color.Transparent
        Me.lbladd1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbladd1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd1.ForeColor = System.Drawing.Color.Crimson
        Me.lbladd1.Location = New System.Drawing.Point(136, 132)
        Me.lbladd1.Name = "lbladd1"
        Me.lbladd1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbladd1.Size = New System.Drawing.Size(62, 21)
        Me.lbladd1.TabIndex = 35
        Me.lbladd1.Text = "lblAdd1"
        '
        'lbladd2
        '
        Me.lbladd2.AutoSize = True
        Me.lbladd2.BackColor = System.Drawing.Color.Transparent
        Me.lbladd2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbladd2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbladd2.ForeColor = System.Drawing.Color.Crimson
        Me.lbladd2.Location = New System.Drawing.Point(136, 156)
        Me.lbladd2.Name = "lbladd2"
        Me.lbladd2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbladd2.Size = New System.Drawing.Size(62, 21)
        Me.lbladd2.TabIndex = 34
        Me.lbladd2.Text = "lblAdd2"
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.BackColor = System.Drawing.Color.Transparent
        Me.lblcity.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcity.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcity.ForeColor = System.Drawing.Color.Crimson
        Me.lblcity.Location = New System.Drawing.Point(136, 199)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcity.Size = New System.Drawing.Size(50, 21)
        Me.lblcity.TabIndex = 33
        Me.lblcity.Text = "lblcity"
        '
        'lblstate
        '
        Me.lblstate.AutoSize = True
        Me.lblstate.BackColor = System.Drawing.Color.Transparent
        Me.lblstate.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblstate.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstate.ForeColor = System.Drawing.Color.Crimson
        Me.lblstate.Location = New System.Drawing.Point(136, 222)
        Me.lblstate.Name = "lblstate"
        Me.lblstate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblstate.Size = New System.Drawing.Size(60, 21)
        Me.lblstate.TabIndex = 32
        Me.lblstate.Text = "lblstate"
        '
        'lblpin
        '
        Me.lblpin.AutoSize = True
        Me.lblpin.BackColor = System.Drawing.Color.Transparent
        Me.lblpin.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblpin.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpin.ForeColor = System.Drawing.Color.Crimson
        Me.lblpin.Location = New System.Drawing.Point(136, 246)
        Me.lblpin.Name = "lblpin"
        Me.lblpin.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblpin.Size = New System.Drawing.Size(47, 21)
        Me.lblpin.TabIndex = 31
        Me.lblpin.Text = "lblpin"
        '
        'lblphone1
        '
        Me.lblphone1.AutoSize = True
        Me.lblphone1.BackColor = System.Drawing.Color.Transparent
        Me.lblphone1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblphone1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone1.ForeColor = System.Drawing.Color.Crimson
        Me.lblphone1.Location = New System.Drawing.Point(136, 268)
        Me.lblphone1.Name = "lblphone1"
        Me.lblphone1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblphone1.Size = New System.Drawing.Size(78, 21)
        Me.lblphone1.TabIndex = 30
        Me.lblphone1.Text = "lblphone1"
        '
        'lblphone2
        '
        Me.lblphone2.AutoSize = True
        Me.lblphone2.BackColor = System.Drawing.Color.Transparent
        Me.lblphone2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblphone2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblphone2.ForeColor = System.Drawing.Color.Crimson
        Me.lblphone2.Location = New System.Drawing.Point(136, 291)
        Me.lblphone2.Name = "lblphone2"
        Me.lblphone2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblphone2.Size = New System.Drawing.Size(78, 21)
        Me.lblphone2.TabIndex = 29
        Me.lblphone2.Text = "lblphone2"
        '
        'lblcellno
        '
        Me.lblcellno.AutoSize = True
        Me.lblcellno.BackColor = System.Drawing.Color.Transparent
        Me.lblcellno.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblcellno.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcellno.ForeColor = System.Drawing.Color.Crimson
        Me.lblcellno.Location = New System.Drawing.Point(136, 318)
        Me.lblcellno.Name = "lblcellno"
        Me.lblcellno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcellno.Size = New System.Drawing.Size(71, 21)
        Me.lblcellno.TabIndex = 28
        Me.lblcellno.Text = "lblCellno"
        '
        'Txt_Mcode
        '
        Me.Txt_Mcode.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Mcode.Location = New System.Drawing.Point(376, 11)
        Me.Txt_Mcode.Name = "Txt_Mcode"
        Me.Txt_Mcode.TabIndex = 56
        Me.Txt_Mcode.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(64, Byte), CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(232, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(141, 22)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "MEMBER CODE :"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CmdClear)
        Me.GroupBox1.Controls.Add(Me.cmdexit)
        Me.GroupBox1.Controls.Add(Me.cmdPrint)
        Me.GroupBox1.Location = New System.Drawing.Point(176, 432)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 64)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.BackgroundImage = CType(resources.GetObject("CmdClear.BackgroundImage"), System.Drawing.Image)
        Me.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Location = New System.Drawing.Point(20, 17)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 62
        Me.CmdClear.Text = "Clear[F6]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdexit.BackgroundImage = CType(resources.GetObject("cmdexit.BackgroundImage"), System.Drawing.Image)
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Location = New System.Drawing.Point(257, 17)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 63
        Me.cmdexit.Text = "Exit[F11]"
        '
        'cmdPrint
        '
        Me.cmdPrint.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdPrint.BackgroundImage = CType(resources.GetObject("cmdPrint.BackgroundImage"), System.Drawing.Image)
        Me.cmdPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdPrint.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdPrint.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Location = New System.Drawing.Point(140, 17)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 61
        Me.cmdPrint.Text = "Print[F9]"
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(480, 8)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(24, 32)
        Me.cmd_MemberCodeHelp.TabIndex = 62
        '
        'btnPrintWithDialog
        '
        Me.btnPrintWithDialog.Location = New System.Drawing.Point(752, 200)
        Me.btnPrintWithDialog.Name = "btnPrintWithDialog"
        Me.btnPrintWithDialog.Size = New System.Drawing.Size(96, 23)
        Me.btnPrintWithDialog.TabIndex = 64
        Me.btnPrintWithDialog.Text = "Print w/Dialog"
        '
        'btnPrintPreview
        '
        Me.btnPrintPreview.Location = New System.Drawing.Point(752, 160)
        Me.btnPrintPreview.Name = "btnPrintPreview"
        Me.btnPrintPreview.Size = New System.Drawing.Size(96, 23)
        Me.btnPrintPreview.TabIndex = 63
        Me.btnPrintPreview.Text = "Print Preview"
        '
        'dlgPrintPreview
        '
        Me.dlgPrintPreview.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.dlgPrintPreview.ClientSize = New System.Drawing.Size(400, 300)
        Me.dlgPrintPreview.Enabled = True
        Me.dlgPrintPreview.Icon = CType(resources.GetObject("dlgPrintPreview.Icon"), System.Drawing.Icon)
        Me.dlgPrintPreview.Location = New System.Drawing.Point(132, 174)
        Me.dlgPrintPreview.MinimumSize = New System.Drawing.Size(375, 250)
        Me.dlgPrintPreview.Name = "dlgPrintPreview"
        Me.dlgPrintPreview.TransparencyKey = System.Drawing.Color.Empty
        Me.dlgPrintPreview.Visible = False
        '
        'ID_Card_Print
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(912, 502)
        Me.Controls.Add(Me.btnPrintWithDialog)
        Me.Controls.Add(Me.btnPrintPreview)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_Mcode)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "ID_Card_Print"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IDENTITY CARD PRINT"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Private Sub Txt_Mcode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txt_Mcode.TextChanged

    End Sub
   
    Private Sub Txt_Mcode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Txt_Mcode.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_MemberCodeHelp_Click(sender, e)
        End If
    End Sub
   
    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New ListOperation
        Try
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM MEMBERMASTER"
            M_WhereCondition = " "
            vform.Field = "MCODE,MNAME"
            vform.vFormatstring = "  Member Code  | Member Name                           "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                Txt_Mcode.Text = Trim(vform.keyfield & "")
                Txt_Mcode.Select()
                Txt_Mcode_Validated(sender, e)
            End If
            vform.Close()
            vform = Nothing
            'cmd_AddNew.Text = "Update[F5]"
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub Txt_Mcode_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Txt_Mcode.Validated
        Dim StrSQL As String
        Dim codeTable As New DataTable
        If Txt_Mcode.Text <> "" Then
            StrSQL = " SELECT isnull(dob,'') as dob,isnull(membertypecode,'') as membertypecode, "
            StrSQL = StrSQL & " isnull(MCODE,'') as MCODE,isnull(contadd1,'') as contadd1,isnull(contadd2,'') as contadd2,isnull(contadd3,'') as contadd3,isnull(contcity,'') as contcity,"
            StrSQL = StrSQL & " isnull(COMPANY,'') as COMPANY,isnull(DOJ,'') as DOJ,isnull(MEMBERSHIPTO,'') as MEMBERSHIPTO,isnull(CONTSTATE,'') as CONTSTATE,isnull(MNAME,'') as MNAME,isnull(contCITY,'') as contCITY,isnull(contpin,'') as contpin,isnull(contemail,'') as contemail,isnull(contphone1,'') as contphone1,isnull(contphone2,'') as contphone2,isnull(contcell,'') as contcell,isnull(contemail,'') as contemail "
            StrSQL = StrSQL & " FROM Membermaster WHERE mcode='" & Me.Txt_Mcode.Text & "'"
            codeTable = gconnection.GetValues(StrSQL)
            If codeTable.Rows.Count > 0 Then
                lblType.Text = UCase(codeTable.Rows(0).Item("MEMBERTYPECODE"))
                lblmcode.Text = UCase(codeTable.Rows(0).Item("MCODE"))
                lblCompany.Text = UCase(codeTable.Rows(0).Item("COMPANY"))
                lblname.Text = UCase(codeTable.Rows(0).Item("MNAME"))
                lbladd1.Text = UCase(codeTable.Rows(0).Item("CONTADD1"))
                lbladd2.Text = UCase(codeTable.Rows(0).Item("CONTADD2"))
                lbladd3.Text = UCase(codeTable.Rows(0).Item("CONTADD3"))
                lblcity.Text = UCase(codeTable.Rows(0).Item("CONTCITY"))
                lblstate.Text = UCase(codeTable.Rows(0).Item("CONTSTATE"))
                lblpin.Text = UCase(codeTable.Rows(0).Item("CONTPIN"))
                lblphone1.Text = UCase(codeTable.Rows(0).Item("CONTPHONE1"))
                lblphone2.Text = UCase(codeTable.Rows(0).Item("CONTPHONE2"))
                lblcellno.Text = UCase(codeTable.Rows(0).Item("CONTCELL"))
                lbldoj.Text = codeTable.Rows(0).Item("DOJ")
                lbldoe.Text = codeTable.Rows(0).Item("MEMBERSHIPTO")
                lblEmail.Text = codeTable.Rows(0).Item("CONTEMAIL")
                If File.Exists("\\" & gserver & "\Photos\" & Trim(Txt_Mcode.Text) & ".Jpg") Then
                    PImage.Image = New Bitmap("\\" & gserver & "\Photos\" & Trim(Txt_Mcode.Text) & ".Jpg")
                ElseIf File.Exists("\\" & gserver & "\Photos\" & Trim(Txt_Mcode.Text) & ".GIF") Then
                    PImage.Image = New Bitmap("\\" & gserver & "\Photos\" & Trim(Txt_Mcode.Text) & ".GIF")
                ElseIf File.Exists("\\" & gserver & "\Photos\Image.Jpg") Then
                    PImage.Image = New Bitmap("\\" & gserver & "\Photos\Image.Jpg")
                End If
            End If
        End If
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        lblType.Text = ""
        lblmcode.Text = ""
        lblCompany.Text = ""
        lblname.Text = ""
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
        lbldoj.Text = ""
        lbldoe.Text = ""
        Txt_Mcode.Text = ""
        PImage.Image = New Bitmap("\\" & gserver & "\Photos\Image.Jpg")
        Show()
        Txt_Mcode.Focus()
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub ID_Card_Print_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call CmdClear_Click(sender, e)
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
        Me.cmdPrint.Enabled = False
        ' Me.CmdView.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    'Me.CmdView.Enabled = True
                    Me.cmdPrint.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    'Me.CmdView.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.cmdPrint.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub Txt_Mcode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt_Mcode.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If Txt_Mcode.Text <> "" Then
                Call Txt_Mcode_Validated(sender, e)
            Else
                Txt_Mcode.Focus()
            End If

        End If
    End Sub

    Private Sub ID_Card_Print_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F11 Then
            Call cmdexit_Click(sender, e)
        End If
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If Txt_Mcode.Text = "" Then
            MsgBox("Member Code Can't Be Blank", vbInformation)
            Exit Sub
        Else
            ' Make a PrintDocument object.
            Dim print_document As PrintDocument = PreparePrintDocument()

            ' Print immediately.
            print_document.Print()
        End If
    End Sub

    ' Display a print preview.
    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click
        ' Make a PrintDocument and attach it to 
        ' the PrintPreview dialog.
        dlgPrintPreview.Document = PreparePrintDocument()

        ' Preview.
        dlgPrintPreview.WindowState = FormWindowState.Maximized
        dlgPrintPreview.ShowDialog()
    End Sub

    ' Print with the print dialog.
    Private Sub btnPrintWithDialog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintWithDialog.Click
        ' Make a PrintDocument and attach it to 
        ' the Print dialog.
        dlgPrint.Document = PreparePrintDocument()

        ' Display the print dialog.
        dlgPrint.ShowDialog()
    End Sub



    ' Make and return a PrintDocument object that's ready
    ' to print the paragraphs.
    Private Function PreparePrintDocument() As PrintDocument
        ' Make the PrintDocument object.
        Dim print_document As New PrintDocument

        ' Install the PrintPage event handler.
        AddHandler print_document.PrintPage, AddressOf Print_PrintPage

        ' Return the object.
        Return print_document
    End Function

    ' Print the next page.
    Private Sub Print_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'Draw a rectangle at the margins.
        'e.Graphics.DrawRectangle(Pens.Black, e.MarginBounds)


        ' Draw a thick, dashed ellipse.
        ''Dim dotted_pen As New Pen(Color.Black, 5)
        ''dotted_pen.DashStyle = Drawing2D.DashStyle.Dash
        ''e.Graphics.DrawEllipse(dotted_pen, e.MarginBounds)
        ''dotted_pen.Dispose()

        ' Draw a thick diamond.
        ''Dim x0 As Integer = e.MarginBounds.X
        ''Dim y0 As Integer = e.MarginBounds.Y
        ''Dim wid As Integer = e.MarginBounds.Width
        ''Dim hgt As Integer = e.MarginBounds.Height
        ''Dim pts() As Point = { _
        ''New Point(x0, y0 + hgt \ 2), _
        ''New Point(x0 + wid \ 2, y0), _
        ''New Point(x0 + wid, y0 + hgt \ 2), _
        ''New Point(x0 + wid \ 2, y0 + hgt) _
        ''}
        ''e.Graphics.DrawPolygon(New Pen(Color.Black, 5), pts)

        e.Graphics.DrawRectangle(Pens.Brown, 20, 10, 610, 370)

        Dim f As Font = New Font(Font.Bold, 10)
        Dim myBrush As New SolidBrush(Color.Violet)
        e.Graphics.DrawString("MEMBER CODE : " & Txt_Mcode.Text, f, myBrush, 30, 20)
        e.Graphics.DrawString("MEMBER NAME : " & lblname.Text, f, myBrush, 30, 50)
        e.Graphics.DrawString("ADDRESS-1   : " & lbladd1.Text, f, myBrush, 30, 80)
        e.Graphics.DrawString("ADDRESS-2   : " & lbladd2.Text, f, myBrush, 30, 110)
        e.Graphics.DrawString("ADDRESS-3   : " & lbladd3.Text, f, myBrush, 30, 140)
        e.Graphics.DrawString("CITY        : " & lblcity.Text & Space(2) & "STATE       : " & lblstate.Text, f, myBrush, 30, 170)
        'e.Graphics.DrawString("STATE       : " & lblstate.Text, f, myBrush, 30, 200)
        e.Graphics.DrawString("PIN CODE    : " & lblpin.Text, f, myBrush, 30, 200)
        e.Graphics.DrawString("PHONE NOS.  : " & lblphone1.Text & ", " & lblphone2.Text & Space(2) & "MOBILE NO.  : " & lblcellno.Text, f, myBrush, 30, 230)
        'e.Graphics.DrawString("MOBILE NO.  : " & lblcellno.Text, f, myBrush, 30, 280)
        e.Graphics.DrawString("E-MAIL      : " & lblEmail.Text, f, myBrush, 30, 260)
        e.Graphics.DrawString("D.O.J.      : " & lbldoj.Text & Space(2) & "D.O.E.      : " & lbldoe.Text, f, myBrush, 30, 290)
        'e.Graphics.DrawString("D.O.E.      : " & lbldoe.Text, f, myBrush, 30, 360)
        e.Graphics.DrawString("AUTHORIZED SIGNATORY ", f, myBrush, 430, 340)
        e.Graphics.DrawImage(PImage.Image, 500, 20)
        ' There are no more pages.
        e.HasMorePages = False


        '''Write to text file with the Stream Writer Class

        ''Dim sWriter As IO.StreamWriter = New IO.StreamWriter("c:\newTextFile.txt")



        '''This is pretty much easy to understand. No explanation

        ''sWriter.WriteLine("Hi")

        ''sWriter.WriteLine("Testing out this code")

        ''sWriter.WriteLine("Hopefully this code will work")

        ''sWriter.WriteLine("Lets flush the stream and see")

        '''Put the data inside the text file

        ''sWriter.Flush()





    End Sub

    Private Sub PrintPreviewControl1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class