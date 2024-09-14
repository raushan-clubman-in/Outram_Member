Imports System.Data.SqlClient
Public Class PhotoIDdetails
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents lbl_Amount As System.Windows.Forms.Label
    Friend WithEvents lbl_Date As System.Windows.Forms.Label
    Friend WithEvents lbl_ReceiptNumber As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Amount As System.Windows.Forms.TextBox
    Friend WithEvents txt_ReceiptNumber As System.Windows.Forms.TextBox
    Friend WithEvents lbl_MemberCode As System.Windows.Forms.Label
    Friend WithEvents lbl_MemberName As System.Windows.Forms.Label
    Friend WithEvents txt_MemberName As System.Windows.Forms.TextBox
    Friend WithEvents cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents cmd_ListView As System.Windows.Forms.Button
    Friend WithEvents cmd_AddNew As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Caption As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PhotoIDdetails))
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.lbl_Amount = New System.Windows.Forms.Label
        Me.lbl_Date = New System.Windows.Forms.Label
        Me.lbl_ReceiptNumber = New System.Windows.Forms.Label
        Me.cmb_Status = New System.Windows.Forms.ComboBox
        Me.txt_Amount = New System.Windows.Forms.TextBox
        Me.txt_ReceiptNumber = New System.Windows.Forms.TextBox
        Me.lbl_MemberCode = New System.Windows.Forms.Label
        Me.lbl_MemberName = New System.Windows.Forms.Label
        Me.txt_MemberName = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmd_Exit = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmd_Clear = New System.Windows.Forms.Button
        Me.cmd_ListView = New System.Windows.Forms.Button
        Me.cmd_AddNew = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dtp_Date = New System.Windows.Forms.DateTimePicker
        Me.lbl_Caption = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.SuspendLayout()
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(448, 128)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MemberCodeHelp.TabIndex = 1
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberCode.Location = New System.Drawing.Point(280, 128)
        Me.txt_MemberCode.MaxLength = 15
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(168, 23)
        Me.txt_MemberCode.TabIndex = 0
        Me.txt_MemberCode.Text = ""
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Status.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.Location = New System.Drawing.Point(296, 328)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(49, 20)
        Me.lbl_Status.TabIndex = 333
        Me.lbl_Status.Text = "Status "
        '
        'lbl_Amount
        '
        Me.lbl_Amount.AutoSize = True
        Me.lbl_Amount.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Amount.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Amount.Location = New System.Drawing.Point(296, 288)
        Me.lbl_Amount.Name = "lbl_Amount"
        Me.lbl_Amount.Size = New System.Drawing.Size(62, 20)
        Me.lbl_Amount.TabIndex = 332
        Me.lbl_Amount.Text = "Amount "
        '
        'lbl_Date
        '
        Me.lbl_Date.AutoSize = True
        Me.lbl_Date.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Date.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Date.Location = New System.Drawing.Point(296, 256)
        Me.lbl_Date.Name = "lbl_Date"
        Me.lbl_Date.Size = New System.Drawing.Size(39, 20)
        Me.lbl_Date.TabIndex = 331
        Me.lbl_Date.Text = "Date "
        '
        'lbl_ReceiptNumber
        '
        Me.lbl_ReceiptNumber.AutoSize = True
        Me.lbl_ReceiptNumber.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ReceiptNumber.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ReceiptNumber.Location = New System.Drawing.Point(296, 224)
        Me.lbl_ReceiptNumber.Name = "lbl_ReceiptNumber"
        Me.lbl_ReceiptNumber.Size = New System.Drawing.Size(115, 20)
        Me.lbl_ReceiptNumber.TabIndex = 330
        Me.lbl_ReceiptNumber.Text = "Receipt Number "
        '
        'cmb_Status
        '
        Me.cmb_Status.Items.AddRange(New Object() {"Release For Printing", "Issued", "Card Ready"})
        Me.cmb_Status.Location = New System.Drawing.Point(464, 328)
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(184, 24)
        Me.cmb_Status.TabIndex = 6
        '
        'txt_Amount
        '
        Me.txt_Amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Amount.Location = New System.Drawing.Point(464, 288)
        Me.txt_Amount.MaxLength = 10
        Me.txt_Amount.Name = "txt_Amount"
        Me.txt_Amount.Size = New System.Drawing.Size(184, 23)
        Me.txt_Amount.TabIndex = 5
        Me.txt_Amount.Text = "0.00"
        '
        'txt_ReceiptNumber
        '
        Me.txt_ReceiptNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_ReceiptNumber.Location = New System.Drawing.Point(464, 216)
        Me.txt_ReceiptNumber.MaxLength = 10
        Me.txt_ReceiptNumber.Name = "txt_ReceiptNumber"
        Me.txt_ReceiptNumber.Size = New System.Drawing.Size(184, 23)
        Me.txt_ReceiptNumber.TabIndex = 3
        Me.txt_ReceiptNumber.Text = ""
        '
        'lbl_MemberCode
        '
        Me.lbl_MemberCode.AutoSize = True
        Me.lbl_MemberCode.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberCode.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberCode.Location = New System.Drawing.Point(168, 128)
        Me.lbl_MemberCode.Name = "lbl_MemberCode"
        Me.lbl_MemberCode.Size = New System.Drawing.Size(102, 20)
        Me.lbl_MemberCode.TabIndex = 318
        Me.lbl_MemberCode.Text = "Member Code "
        '
        'lbl_MemberName
        '
        Me.lbl_MemberName.AutoSize = True
        Me.lbl_MemberName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MemberName.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MemberName.Location = New System.Drawing.Point(488, 128)
        Me.lbl_MemberName.Name = "lbl_MemberName"
        Me.lbl_MemberName.Size = New System.Drawing.Size(106, 20)
        Me.lbl_MemberName.TabIndex = 317
        Me.lbl_MemberName.Text = "Member Name "
        '
        'txt_MemberName
        '
        Me.txt_MemberName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_MemberName.Location = New System.Drawing.Point(608, 128)
        Me.txt_MemberName.MaxLength = 35
        Me.txt_MemberName.Name = "txt_MemberName"
        Me.txt_MemberName.Size = New System.Drawing.Size(200, 23)
        Me.txt_MemberName.TabIndex = 2
        Me.txt_MemberName.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Location = New System.Drawing.Point(136, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 64)
        Me.GroupBox1.TabIndex = 337
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Location = New System.Drawing.Point(272, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 176)
        Me.GroupBox2.TabIndex = 338
        Me.GroupBox2.TabStop = False
        '
        'cmd_Exit
        '
        Me.cmd_Exit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_Exit.BackgroundImage = CType(resources.GetObject("cmd_Exit.BackgroundImage"), System.Drawing.Image)
        Me.cmd_Exit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.cmd_Exit.Location = New System.Drawing.Point(624, 424)
        Me.cmd_Exit.Name = "cmd_Exit"
        Me.cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Exit.TabIndex = 11
        Me.cmd_Exit.Text = "Exit[F11]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(128, 488)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 18)
        Me.Label1.TabIndex = 348
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
        Me.cmd_Clear.Location = New System.Drawing.Point(488, 424)
        Me.cmd_Clear.Name = "cmd_Clear"
        Me.cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Clear.TabIndex = 10
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
        Me.cmd_ListView.Location = New System.Drawing.Point(344, 424)
        Me.cmd_ListView.Name = "cmd_ListView"
        Me.cmd_ListView.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ListView.TabIndex = 8
        Me.cmd_ListView.Text = "List View [F8]"
        '
        'cmd_AddNew
        '
        Me.cmd_AddNew.BackColor = System.Drawing.SystemColors.Menu
        Me.cmd_AddNew.BackgroundImage = CType(resources.GetObject("cmd_AddNew.BackgroundImage"), System.Drawing.Image)
        Me.cmd_AddNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmd_AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_AddNew.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_AddNew.ForeColor = System.Drawing.Color.White
        Me.cmd_AddNew.Location = New System.Drawing.Point(200, 424)
        Me.cmd_AddNew.Name = "cmd_AddNew"
        Me.cmd_AddNew.Size = New System.Drawing.Size(104, 32)
        Me.cmd_AddNew.TabIndex = 7
        Me.cmd_AddNew.Text = "Add New[F5]"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(200, 432)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 30)
        Me.Label6.TabIndex = 344
        Me.Label6.Text = "Label6"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(344, 432)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 30)
        Me.Label8.TabIndex = 345
        Me.Label8.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(488, 432)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(108, 30)
        Me.Label9.TabIndex = 347
        Me.Label9.Text = "Label9"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(624, 432)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 30)
        Me.Label2.TabIndex = 349
        Me.Label2.Text = "Label2"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Location = New System.Drawing.Point(128, 400)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(720, 80)
        Me.GroupBox3.TabIndex = 350
        Me.GroupBox3.TabStop = False
        '
        'dtp_Date
        '
        Me.dtp_Date.CustomFormat = "dd-MMM-yyyy"
        Me.dtp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_Date.Location = New System.Drawing.Point(464, 256)
        Me.dtp_Date.Name = "dtp_Date"
        Me.dtp_Date.Size = New System.Drawing.Size(184, 23)
        Me.dtp_Date.TabIndex = 4
        '
        'lbl_Caption
        '
        Me.lbl_Caption.AutoSize = True
        Me.lbl_Caption.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Caption.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Caption.Location = New System.Drawing.Point(400, 40)
        Me.lbl_Caption.Name = "lbl_Caption"
        Me.lbl_Caption.Size = New System.Drawing.Size(197, 25)
        Me.lbl_Caption.TabIndex = 351
        Me.lbl_Caption.Text = "PHOTO-ID DETAILS"
        Me.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.BackgroundImage = CType(resources.GetObject("GroupBox4.BackgroundImage"), System.Drawing.Image)
        Me.GroupBox4.Location = New System.Drawing.Point(112, 80)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(768, 432)
        Me.GroupBox4.TabIndex = 352
        Me.GroupBox4.TabStop = False
        '
        'PhotoIDdetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(974, 611)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_Caption)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_MemberCode)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.lbl_Amount)
        Me.Controls.Add(Me.lbl_Date)
        Me.Controls.Add(Me.lbl_ReceiptNumber)
        Me.Controls.Add(Me.txt_Amount)
        Me.Controls.Add(Me.txt_ReceiptNumber)
        Me.Controls.Add(Me.lbl_MemberCode)
        Me.Controls.Add(Me.lbl_MemberName)
        Me.Controls.Add(Me.txt_MemberName)
        Me.Controls.Add(Me.cmd_Exit)
        Me.Controls.Add(Me.cmd_Clear)
        Me.Controls.Add(Me.cmd_ListView)
        Me.Controls.Add(Me.cmd_AddNew)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.cmb_Status)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.dtp_Date)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.Name = "PhotoIDdetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PhotoIDdetails"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim gconnection As New GlobalClass
    Dim sqlstring As String
    Dim boolchk As Boolean
    Private Sub txt_MemberCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberCode.KeyPress
        getAlphanumeric(e)
    End Sub
    Private Sub txt_MemberName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_MemberName.KeyPress
        getCharater(e)
    End Sub
    Private Sub txt_ReceiptNumber_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ReceiptNumber.KeyPress
        getAlphanumeric(e)
    End Sub
    Private Sub txt_Amount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_Amount.KeyPress
        getNumeric(e)
    End Sub
    Private Sub cmb_Status_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Status.KeyPress
        BLANK(e)
    End Sub
    Private Sub txt_MemberCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MemberCode.KeyDown
        Dim posting As DataTable
        Dim sqlstr As String
        Dim vform As New ListOperation
        Dim dr As SqlDataReader
        If e.KeyCode = Keys.Enter And txt_MemberCode.Text <> "" Then
            gSQLString = "SELECT MCODE,MNAME FROM membermaster where mcode='" & txt_MemberCode.Text & "'"
            posting = gconnection.GetValues(gSQLString)
            If posting.Rows.Count > 0 Then
                txt_MemberName.Text = posting.Rows(0).Item("mname")
                txt_MemberName.Focus()
            End If
            gconnection.closeConnection()
            sqlstring = "SELECT count(MCODE) FROM photodetails WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
            gconnection.openConnection()
            gcommand = New SqlCommand(sqlstring, gconnection.Myconn)
            gdreader = gcommand.ExecuteReader
            If gdreader.Read Then
                If gdreader(0) = 0 Then
                    cmd_AddNew.Text = "Add New[F5]"
                Else
                    cmd_AddNew.Text = "Update[F5]"
                    sqlstr = "SELECT * FROM PhotoDETAILS WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
                    gconnection.closeConnection()
                    gconnection.openConnection()
                    gcommand = New SqlCommand(sqlstr, gconnection.Myconn)
                    dr = gcommand.ExecuteReader
                    If dr.Read Then
                        txt_ReceiptNumber.Text = dr("receiptno")
                        dtp_Date.Value = Format(dr("dated"), "dd-MMM-yy")
                        txt_Amount.Text = Format(dr("amount"), "0.00")
                        cmb_Status.Text = dr("status")
                        txt_MemberCode.Enabled = False
                        cmd_AddNew.Text = "Update[F5]"
                    End If
                    dr.Close()
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
        End If
        If e.KeyCode = Keys.F4 Then
            Call cmd_MemberCodeHelp_Click(sender, e)
        End If
    End Sub
    Private Sub txt_MemberName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MemberName.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_ReceiptNumber.Focus()
        End If
    End Sub
    Private Sub txt_ReceiptNumber_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ReceiptNumber.KeyDown
        If e.KeyCode = Keys.Enter Then
            dtp_Date.Focus()
        End If
    End Sub
    Private Sub dtp_Date_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles dtp_Date.KeyDown
        If e.KeyCode = Keys.Enter Then
            txt_Amount.Focus()
        End If
    End Sub
    Private Sub txt_Amount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_Amount.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmb_Status.Focus()
        End If
    End Sub
    Private Sub cmb_Status_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_Status.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmd_AddNew.Focus()
        End If
    End Sub
    Private Sub cmd_AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_AddNew.Click
        If cmd_AddNew.Text = "Add New[F5]" Then
            '''******************************************************** Insert record into PODdetails **************************************************************'''
            Call checkValidation() '''---> CHECK VALIDATION
            gconnection.closeConnection()
            If boolchk = False Then Exit Sub
            sqlstring = "INSERT INTO  Photodetails "
            sqlstring = sqlstring & "(MCode,Mname,receiptno,dated,amount,status,UserId, AddDate)VALUES ('" & Trim(txt_MemberCode.Text) & " ' , '"
            sqlstring = sqlstring & Trim(txt_MemberName.Text) & "' , '" & Trim(txt_ReceiptNumber.Text) & "' , '" & Format(dtp_Date.Value, "dd-MMM-yy") & "' , " & Format(txt_Amount.Text) & " ,'"
            sqlstring = sqlstring & Trim(cmb_Status.Text) & "' ,'" & gUsername & "' ,'" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "')"
            gconnection.dataOperation(1, sqlstring, "MemberType")
            MessageBox.Show("Record Saved ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
        ElseIf cmd_AddNew.Text = "Update[F5]" Then
            '''******************************************************** Update record into PODdetails **************************************************************'''
            Call checkValidation() '''---> CHECK VALIDATION
            gconnection.closeConnection()
            If boolchk = False Then Exit Sub
            sqlstring = "UPDATE  Photodetails SET Mname = '"
            sqlstring = sqlstring & Trim(txt_MemberName.Text) & "', receiptno='" & Trim(txt_ReceiptNumber.Text) & "',dated='" & Format(dtp_Date.Value, "dd-MMM-yy") & "',"
            sqlstring = sqlstring & " amount = " & Trim(txt_Amount.Text) & " ,status='" & Trim(cmb_Status.Text)
            sqlstring = sqlstring & "' , USERID ='" & gUsername & "',ADDDATE='" & Format(Date.Now, "dd-MMM-yyyy hh:mm") & "'"
            sqlstring = sqlstring & " WHERE MCode = '" & txt_MemberCode.Text & "'"
            gconnection.dataOperation(2, sqlstring, "membertype")
            MessageBox.Show("Record Updated ", "Club", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cmd_Clear_Click(sender, e)
            cmd_AddNew.Text = "Add New[F5]"
        End If
    End Sub
    Private Sub cmd_ListView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_ListView.Click
        Dim FrReport As New ReportDesigner
        tables = " FROM Photodetails"
        Gheader = "PHOTO DETAILS"
        FrReport.SsGridReport.SetText(2, 1, "MCODE")
        FrReport.SsGridReport.SetText(3, 1, 10)
        FrReport.SsGridReport.SetText(2, 2, "MNAME")
        FrReport.SsGridReport.SetText(3, 2, 30)
        FrReport.SsGridReport.SetText(2, 3, "RECEIPTNO")
        FrReport.SsGridReport.SetText(3, 3, 10)
        FrReport.SsGridReport.SetText(2, 4, "DATED")
        FrReport.SsGridReport.SetText(3, 4, 8)
        FrReport.SsGridReport.SetText(2, 5, "AMOUNT")
        FrReport.SsGridReport.SetText(3, 5, 8)
        FrReport.SsGridReport.SetText(2, 6, "STATUS")
        FrReport.SsGridReport.SetText(3, 6, 15)
        FrReport.Show()
    End Sub
    Private Sub cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Clear.Click
        clearform(Me)
        txt_MemberCode.Enabled = True
        cmd_AddNew.Text = "Add New[F5]"
        txt_MemberCode.Focus()
        txt_Amount.Text = "0.00"
    End Sub
    Private Sub cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Exit.Click
        If MsgBox("Do U Want to Close this Form........", MsgBoxStyle.OKCancel + MsgBoxStyle.DefaultButton1 + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.OK Then
            Me.Close()
        Else
            txt_MemberCode.Focus()
        End If
    End Sub
    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New ListOperation
        Dim sqlstr As String
        Dim dr As SqlDataReader
        clearform(Me)
        txt_Amount.Text = "0.00"
        gconnection.closeConnection()
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
            'Call txt_MemberCode_Validated(sender, e)
        End If
        vform.Close()
        vform = Nothing
        sqlstring = "SELECT count(MCODE) FROM photodetails WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
        gconnection.closeConnection()
        gconnection.openConnection()
        gcommand = New SqlCommand(sqlstring, gconnection.Myconn)
        gdreader = gcommand.ExecuteReader
        If gdreader.Read Then
            If gdreader(0) = 0 Then
                cmd_AddNew.Text = "Add New[F5]"
            Else
                cmd_AddNew.Text = "Update[F5]"
                sqlstr = "SELECT * FROM PhotoDETAILS WHERE MCODE='" & Trim(txt_MemberCode.Text) & "' "
                gconnection.closeConnection()
                gconnection.openConnection()
                gcommand = New SqlCommand(sqlstr, gconnection.Myconn)
                dr = gcommand.ExecuteReader
                If dr.Read Then
                    txt_ReceiptNumber.Text = dr("receiptno")
                    dtp_Date.Value = Format(dr("dated"), "dd-MMM-yy")
                    txt_Amount.Text = Format(dr("amount"), "0.00")
                    cmb_Status.Text = dr("status")
                    txt_MemberCode.Enabled = False
                    cmd_AddNew.Text = "Update[F5]"
                End If
                dr.Close()
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
    Private Sub txt_Amount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_Amount.LostFocus
        txt_Amount.Text = Format(Val(txt_Amount.Text), "0.00")
    End Sub
    Private Sub PhotoIDdetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        photoIDdetailsbool = True
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        txt_Amount.Text = "0.00"
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
        Me.cmd_ListView.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.cmd_AddNew.Enabled = True
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
                    'Me.cmd_Delete.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.cmd_ListView.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub PhotoIDdetails_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        photoIDdetailsbool = False
    End Sub
    Private Sub PhotoIDdetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Call cmd_AddNew_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F6 Then
            Call cmd_Clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            Call cmd_ListView_Click(sender, e)
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
End Class
