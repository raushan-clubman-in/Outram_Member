Public Class frmSmartCard
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_MemberCode As System.Windows.Forms.TextBox
    Friend WithEvents txt_MName As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Address As System.Windows.Forms.TextBox
    Friend WithEvents Com_Dependent As System.Windows.Forms.ComboBox
    Friend WithEvents txt_Category As System.Windows.Forms.TextBox
    Friend WithEvents txt_Remarks As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Amount As System.Windows.Forms.TextBox
    Friend WithEvents Txt_Status As System.Windows.Forms.TextBox
    Friend WithEvents txt_valiedUpTo As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MemberCodeHelp As System.Windows.Forms.Button
    Friend WithEvents Btn_Add As System.Windows.Forms.Button
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSmartCard))
        Me.txt_MemberCode = New System.Windows.Forms.TextBox
        Me.txt_MName = New System.Windows.Forms.TextBox
        Me.Txt_Address = New System.Windows.Forms.TextBox
        Me.Com_Dependent = New System.Windows.Forms.ComboBox
        Me.txt_Category = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_Remarks = New System.Windows.Forms.TextBox
        Me.Txt_Amount = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Txt_Status = New System.Windows.Forms.TextBox
        Me.txt_valiedUpTo = New System.Windows.Forms.TextBox
        Me.cmd_MemberCodeHelp = New System.Windows.Forms.Button
        Me.Btn_Add = New System.Windows.Forms.Button
        Me.btn_Close = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'txt_MemberCode
        '
        Me.txt_MemberCode.Location = New System.Drawing.Point(160, 56)
        Me.txt_MemberCode.Name = "txt_MemberCode"
        Me.txt_MemberCode.Size = New System.Drawing.Size(192, 20)
        Me.txt_MemberCode.TabIndex = 0
        Me.txt_MemberCode.Text = ""
        '
        'txt_MName
        '
        Me.txt_MName.Location = New System.Drawing.Point(544, 56)
        Me.txt_MName.Name = "txt_MName"
        Me.txt_MName.Size = New System.Drawing.Size(272, 20)
        Me.txt_MName.TabIndex = 1
        Me.txt_MName.Text = ""
        '
        'Txt_Address
        '
        Me.Txt_Address.Location = New System.Drawing.Point(160, 128)
        Me.Txt_Address.Multiline = True
        Me.Txt_Address.Name = "Txt_Address"
        Me.Txt_Address.Size = New System.Drawing.Size(352, 152)
        Me.Txt_Address.TabIndex = 2
        Me.Txt_Address.Text = ""
        '
        'Com_Dependent
        '
        Me.Com_Dependent.Location = New System.Drawing.Point(544, 96)
        Me.Com_Dependent.Name = "Com_Dependent"
        Me.Com_Dependent.Size = New System.Drawing.Size(272, 21)
        Me.Com_Dependent.TabIndex = 3
        '
        'txt_Category
        '
        Me.txt_Category.Location = New System.Drawing.Point(160, 296)
        Me.txt_Category.Name = "txt_Category"
        Me.txt_Category.Size = New System.Drawing.Size(160, 20)
        Me.txt_Category.TabIndex = 4
        Me.txt_Category.Text = ""
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(48, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Member code"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(432, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Dependent Name"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(56, 360)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Valied Up To"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(56, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Member Status"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(56, 296)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Member Category"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label6.Location = New System.Drawing.Point(48, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Permanent Address"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label7.Location = New System.Drawing.Point(436, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Member Name"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(32, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(808, 368)
        Me.Label8.TabIndex = 14
        '
        'txt_Remarks
        '
        Me.txt_Remarks.Location = New System.Drawing.Point(168, 472)
        Me.txt_Remarks.Name = "txt_Remarks"
        Me.txt_Remarks.Size = New System.Drawing.Size(552, 20)
        Me.txt_Remarks.TabIndex = 15
        Me.txt_Remarks.Text = ""
        '
        'Txt_Amount
        '
        Me.Txt_Amount.Location = New System.Drawing.Point(168, 432)
        Me.Txt_Amount.Name = "Txt_Amount"
        Me.Txt_Amount.Size = New System.Drawing.Size(160, 20)
        Me.Txt_Amount.TabIndex = 16
        Me.Txt_Amount.Text = ""
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label9.Location = New System.Drawing.Point(72, 440)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Amount Charged"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label10.Location = New System.Drawing.Point(72, 472)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Remarks"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(32, 416)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(808, 104)
        Me.Label11.TabIndex = 19
        '
        'Txt_Status
        '
        Me.Txt_Status.Location = New System.Drawing.Point(160, 328)
        Me.Txt_Status.Name = "Txt_Status"
        Me.Txt_Status.Size = New System.Drawing.Size(160, 20)
        Me.Txt_Status.TabIndex = 20
        Me.Txt_Status.Text = ""
        '
        'txt_valiedUpTo
        '
        Me.txt_valiedUpTo.Location = New System.Drawing.Point(160, 360)
        Me.txt_valiedUpTo.Name = "txt_valiedUpTo"
        Me.txt_valiedUpTo.Size = New System.Drawing.Size(160, 20)
        Me.txt_valiedUpTo.TabIndex = 21
        Me.txt_valiedUpTo.Text = ""
        '
        'cmd_MemberCodeHelp
        '
        Me.cmd_MemberCodeHelp.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.cmd_MemberCodeHelp.Image = CType(resources.GetObject("cmd_MemberCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_MemberCodeHelp.Location = New System.Drawing.Point(368, 56)
        Me.cmd_MemberCodeHelp.Name = "cmd_MemberCodeHelp"
        Me.cmd_MemberCodeHelp.Size = New System.Drawing.Size(24, 20)
        Me.cmd_MemberCodeHelp.TabIndex = 22
        '
        'Btn_Add
        '
        Me.Btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btn_Add.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add.ForeColor = System.Drawing.Color.White
        Me.Btn_Add.Image = CType(resources.GetObject("Btn_Add.Image"), System.Drawing.Image)
        Me.Btn_Add.Location = New System.Drawing.Point(88, 560)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(104, 32)
        Me.Btn_Add.TabIndex = 23
        Me.Btn_Add.Text = "Add"
        '
        'btn_Close
        '
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Close.ForeColor = System.Drawing.Color.White
        Me.btn_Close.Image = CType(resources.GetObject("btn_Close.Image"), System.Drawing.Image)
        Me.btn_Close.Location = New System.Drawing.Point(688, 552)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(104, 32)
        Me.btn_Close.TabIndex = 24
        Me.btn_Close.Text = "Close"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Red
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Location = New System.Drawing.Point(32, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(808, 8)
        Me.Label12.TabIndex = 73
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Red
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Location = New System.Drawing.Point(32, 408)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(808, 8)
        Me.Label13.TabIndex = 74
        '
        'frmSmartCard
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(872, 597)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.cmd_MemberCodeHelp)
        Me.Controls.Add(Me.txt_valiedUpTo)
        Me.Controls.Add(Me.Txt_Status)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Txt_Amount)
        Me.Controls.Add(Me.txt_Remarks)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_Category)
        Me.Controls.Add(Me.Com_Dependent)
        Me.Controls.Add(Me.Txt_Address)
        Me.Controls.Add(Me.txt_MName)
        Me.Controls.Add(Me.txt_MemberCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label11)
        Me.Name = "frmSmartCard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Smart Card ..."
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub cmd_MemberCodeHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MemberCodeHelp.Click
        Dim vform As New ListOperation
        Try

            gSQLString = "select * FROM membermaster_view"
            M_WhereCondition = " "
            vform.Field = "MCODE,MNAME"
            vform.vFormatstring = "  Member Code  | Member Name                           "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.KeyPos2 = 2
            vform.Keypos3 = 3
            vform.keypos4 = 4
            vform.Keypos5 = 5
            vform.Keypos6 = 6
            vform.Keypos7 = 7
            vform.Keypos8 = 8
            vform.keypos9 = 9
            vform.Keypos10 = 10
            vform.Keypos11 = 11
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                '    txt_MemberCode.Text = Trim(vform.keyfield & "")
                '    txt_MemberCode.Select()
                '    txt_MemberCode_Validated(sender, e)
                txt_MemberCode.Text = Trim(vform.keyfield & "")
                txt_MName.Text = Trim(vform.keyfield1)
                Txt_Address.Text = Trim(vform.keyfield2) & "," & vbCrLf & Trim(vform.keyfield3) & "," & vbCrLf & Trim(vform.keyfield4) & "," & vbCrLf & Trim(vform.keyfield5) & "," & vbCrLf & Trim(vform.keyfield6)
                txt_Category.Text = Trim(vform.keyfield7)
                Txt_Status.Text = Trim(vform.keyfield8)
                Com_Dependent.Items.Add(Trim(vform.keyfield9))
                Com_Dependent.Items.Add(Trim(vform.keyfield10))
                Com_Dependent.Items.Add(Trim(vform.keyfield11))
            End If
            'vform.Hide()
            vform.Close()
            vform = Nothing
            'cmd_AddNew.Text = "Update[F5]"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Add.Click
        Dim FilePath As String
        Dim OFile As System.IO.File
        Dim OWrite As System.IO.StreamWriter
        Try

            FilePath = Application.StartupPath & "\New.txt"
        OWrite = OFile.CreateText(FilePath)
        OWrite.WriteLine("Date:" & Date.Now)
        OWrite.WriteLine("Member Code:" & txt_MemberCode.Text)
        OWrite.WriteLine("Member Name:" & txt_MName.Text)
        OWrite.WriteLine("Dependent Name:" & Com_Dependent.Text)
            OWrite.Close()
        txt_MemberCode.Text = ""
        txt_MName.Text = ""
        Com_Dependent.Text = ""
        Txt_Address.Text = ""
        txt_Category.Text = ""
        Txt_Status.Text = ""
        txt_valiedUpTo.Text = ""
        Txt_Amount.Text = ""
        txt_Remarks.Text = ""
        'Shell("start " & FilePath)
            'MsgBox(Application.StartupPath)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub btn_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Close.Click
        Me.Hide()
    End Sub

    Private Sub frmSmartCard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
    End Sub
    Private Sub GetRights()
        'Dim i, j, k, x As Integer
        'Dim vmain, vsmod, vssmod As Long
        'Dim ssql, SQLSTRING As String
        'Dim M1 As New MainMenu
        'Dim chstr As String
        'SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='MEMBER' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        'gconnection.getDataSet(SQLSTRING, "USER")
        'If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
        '    For i = 0 To gdataset.Tables("USER").Rows.Count - 1
        '        With gdataset.Tables("USER").Rows(i)
        '            chstr = abcdMINUS(.Item("RIGHTS"))
        '        End With
        '    Next
        'End If
        ''Me.cmd_AddNew.Enabled = False
        ''Me.cmd_Delete.Enabled = False
        ''Me.cmd_ListView.Enabled = False
        ''A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        'If Len(chstr) > 0 Then
        '    Dim Right() As Char
        '    Right = chstr.ToCharArray
        '    For x = 0 To Right.Length - 1
        '        If Right(x) = "A" Then
        '            'Me.cmd_AddNew.Enabled = True
        '            'Me.cmd_Delete.Enabled = True
        '            'Me.cmd_ListView.Enabled = True
        '            Exit Sub
        '        End If
        '        If UCase(Mid(Me.cmd_AddNew.Text, 1, 1)) = "A" Then
        '            If Right(x) = "S" Then
        '                Me.cmd_AddNew.Enabled = True
        '            End If
        '        Else
        '            If Right(x) = "M" Then
        '                Me.cmd_AddNew.Enabled = True
        '            End If
        '        End If
        '        If Right(x) = "D" Then
        '            Me.cmd_Delete.Enabled = True
        '        End If
        '        If Right(x) = "V" Then
        '            Me.cmd_ListView.Enabled = True
        '        End If
        '    Next
        'End If
    End Sub
End Class
