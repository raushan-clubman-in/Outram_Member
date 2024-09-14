'Imports System.Data.SqlClient   ' needed if using "Sql" functions
Imports System.Data.OleDb
Imports System.data.SqlClient ' needed if using "OleDb" functions
Imports System.IO
Imports Microsoft.VisualBasic
Imports System.Drawing
Public Class PICTUREMANIPULATION
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim ppath, PHOTOPATH, SIGNATUREPATH, SPOUSEPATH, SPOUSESIGNATUREPATH, DEP1PATH, DEP1SIGNATUREPATH, DEP2PATH, DEP2SIGNATUREPATH As String
    Dim DataString As String
    Dim strcn As String = "Data Source=" & gserver & ";Persist Security Info=False;User ID=" & strDataSqlUsr & ";pwd=" & strDataSqlPwd & ";Initial Catalog=  " & gDatabase & ";"
    Dim ssql As String

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
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents memberphoto As System.Windows.Forms.PictureBox
    Friend WithEvents MEMBERDEP1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_mname As System.Windows.Forms.Label
    Friend WithEvents lbl_status As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_MCODE As System.Windows.Forms.TextBox
    Friend WithEvents LBLMNAME As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents MEMSTlBL As System.Windows.Forms.Label
    Friend WithEvents ADDR1LBL As System.Windows.Forms.Label
    Friend WithEvents AddrLbl2 As System.Windows.Forms.Label
    Friend WithEvents AddrLbl3 As System.Windows.Forms.Label
    Friend WithEvents LB1 As System.Windows.Forms.Label
    Friend WithEvents LBL2 As System.Windows.Forms.Label
    Friend WithEvents LBL3 As System.Windows.Forms.Label
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PICTUREMANIPULATION))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.memberphoto = New System.Windows.Forms.PictureBox
        Me.MEMBERDEP1 = New System.Windows.Forms.PictureBox
        Me.Lbl_mname = New System.Windows.Forms.Label
        Me.lbl_status = New System.Windows.Forms.Label
        Me.txt_MCODE = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.LBLMNAME = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.MEMSTlBL = New System.Windows.Forms.Label
        Me.ADDR1LBL = New System.Windows.Forms.Label
        Me.AddrLbl2 = New System.Windows.Forms.Label
        Me.AddrLbl3 = New System.Windows.Forms.Label
        Me.LB1 = New System.Windows.Forms.Label
        Me.LBL2 = New System.Windows.Forms.Label
        Me.LBL3 = New System.Windows.Forms.Label
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'memberphoto
        '
        Me.memberphoto.BackColor = System.Drawing.Color.Transparent
        Me.memberphoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.memberphoto.Location = New System.Drawing.Point(40, 96)
        Me.memberphoto.Name = "memberphoto"
        Me.memberphoto.Size = New System.Drawing.Size(168, 216)
        Me.memberphoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.memberphoto.TabIndex = 603
        Me.memberphoto.TabStop = False
        '
        'MEMBERDEP1
        '
        Me.MEMBERDEP1.BackColor = System.Drawing.Color.Transparent
        Me.MEMBERDEP1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MEMBERDEP1.Location = New System.Drawing.Point(40, 312)
        Me.MEMBERDEP1.Name = "MEMBERDEP1"
        Me.MEMBERDEP1.Size = New System.Drawing.Size(168, 72)
        Me.MEMBERDEP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MEMBERDEP1.TabIndex = 609
        Me.MEMBERDEP1.TabStop = False
        '
        'Lbl_mname
        '
        Me.Lbl_mname.AutoSize = True
        Me.Lbl_mname.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_mname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_mname.Location = New System.Drawing.Point(256, 8)
        Me.Lbl_mname.Name = "Lbl_mname"
        Me.Lbl_mname.Size = New System.Drawing.Size(0, 18)
        Me.Lbl_mname.TabIndex = 620
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.BackColor = System.Drawing.Color.Transparent
        Me.lbl_status.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.Location = New System.Drawing.Point(408, 208)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(0, 25)
        Me.lbl_status.TabIndex = 621
        '
        'txt_MCODE
        '
        Me.txt_MCODE.BackColor = System.Drawing.Color.White
        Me.txt_MCODE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_MCODE.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_MCODE.Location = New System.Drawing.Point(400, 88)
        Me.txt_MCODE.MaxLength = 10
        Me.txt_MCODE.Name = "txt_MCODE"
        Me.txt_MCODE.Size = New System.Drawing.Size(200, 29)
        Me.txt_MCODE.TabIndex = 828
        Me.txt_MCODE.Text = ""
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(224, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(160, 24)
        Me.Label12.TabIndex = 829
        Me.Label12.Text = "MEMBER   CODE :"
        '
        'LBLMNAME
        '
        Me.LBLMNAME.BackColor = System.Drawing.Color.Transparent
        Me.LBLMNAME.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLMNAME.ForeColor = System.Drawing.Color.Navy
        Me.LBLMNAME.Location = New System.Drawing.Point(408, 144)
        Me.LBLMNAME.Name = "LBLMNAME"
        Me.LBLMNAME.Size = New System.Drawing.Size(400, 32)
        Me.LBLMNAME.TabIndex = 830
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(304, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(210, 31)
        Me.Label13.TabIndex = 831
        Me.Label13.Text = "CLUB MEMBERS"
        '
        'MEMSTlBL
        '
        Me.MEMSTlBL.BackColor = System.Drawing.Color.Transparent
        Me.MEMSTlBL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MEMSTlBL.ForeColor = System.Drawing.Color.Navy
        Me.MEMSTlBL.Location = New System.Drawing.Point(408, 192)
        Me.MEMSTlBL.Name = "MEMSTlBL"
        Me.MEMSTlBL.Size = New System.Drawing.Size(400, 32)
        Me.MEMSTlBL.TabIndex = 833
        '
        'ADDR1LBL
        '
        Me.ADDR1LBL.BackColor = System.Drawing.Color.Transparent
        Me.ADDR1LBL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDR1LBL.ForeColor = System.Drawing.Color.Navy
        Me.ADDR1LBL.Location = New System.Drawing.Point(408, 240)
        Me.ADDR1LBL.Name = "ADDR1LBL"
        Me.ADDR1LBL.Size = New System.Drawing.Size(400, 32)
        Me.ADDR1LBL.TabIndex = 834
        '
        'AddrLbl2
        '
        Me.AddrLbl2.BackColor = System.Drawing.Color.Transparent
        Me.AddrLbl2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddrLbl2.ForeColor = System.Drawing.Color.Navy
        Me.AddrLbl2.Location = New System.Drawing.Point(408, 288)
        Me.AddrLbl2.Name = "AddrLbl2"
        Me.AddrLbl2.Size = New System.Drawing.Size(400, 32)
        Me.AddrLbl2.TabIndex = 835
        '
        'AddrLbl3
        '
        Me.AddrLbl3.BackColor = System.Drawing.Color.Transparent
        Me.AddrLbl3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddrLbl3.ForeColor = System.Drawing.Color.Navy
        Me.AddrLbl3.Location = New System.Drawing.Point(408, 336)
        Me.AddrLbl3.Name = "AddrLbl3"
        Me.AddrLbl3.Size = New System.Drawing.Size(400, 32)
        Me.AddrLbl3.TabIndex = 836
        '
        'LB1
        '
        Me.LB1.BackColor = System.Drawing.Color.Transparent
        Me.LB1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB1.ForeColor = System.Drawing.Color.Navy
        Me.LB1.Location = New System.Drawing.Point(224, 144)
        Me.LB1.Name = "LB1"
        Me.LB1.Size = New System.Drawing.Size(160, 32)
        Me.LB1.TabIndex = 838
        Me.LB1.Text = "MEMBER  NAME :"
        '
        'LBL2
        '
        Me.LBL2.BackColor = System.Drawing.Color.Transparent
        Me.LBL2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL2.ForeColor = System.Drawing.Color.Navy
        Me.LBL2.Location = New System.Drawing.Point(224, 192)
        Me.LBL2.Name = "LBL2"
        Me.LBL2.Size = New System.Drawing.Size(168, 32)
        Me.LBL2.TabIndex = 839
        Me.LBL2.Text = "STATUS/CATEGORY:"
        '
        'LBL3
        '
        Me.LBL3.BackColor = System.Drawing.Color.Transparent
        Me.LBL3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL3.ForeColor = System.Drawing.Color.Navy
        Me.LBL3.Location = New System.Drawing.Point(224, 232)
        Me.LBL3.Name = "LBL3"
        Me.LBL3.Size = New System.Drawing.Size(160, 32)
        Me.LBL3.TabIndex = 840
        Me.LBL3.Text = "ADDRESS  :"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.BackgroundImage = CType(resources.GetObject("CmdClear.BackgroundImage"), System.Drawing.Image)
        Me.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Location = New System.Drawing.Point(288, 440)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 841
        Me.CmdClear.Text = "Clear[F6]"
        '
        'cmdexit
        '
        Me.cmdexit.BackColor = System.Drawing.SystemColors.Menu
        Me.cmdexit.BackgroundImage = CType(resources.GetObject("cmdexit.BackgroundImage"), System.Drawing.Image)
        Me.cmdexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmdexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Location = New System.Drawing.Point(440, 440)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 842
        Me.cmdexit.Text = "Exit[F11]"
        '
        'PICTUREMANIPULATION
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(832, 502)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.LBL3)
        Me.Controls.Add(Me.LBL2)
        Me.Controls.Add(Me.LB1)
        Me.Controls.Add(Me.AddrLbl3)
        Me.Controls.Add(Me.AddrLbl2)
        Me.Controls.Add(Me.ADDR1LBL)
        Me.Controls.Add(Me.MEMSTlBL)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_MCODE)
        Me.Controls.Add(Me.LBLMNAME)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.Lbl_mname)
        Me.Controls.Add(Me.MEMBERDEP1)
        Me.Controls.Add(Me.memberphoto)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.KeyPreview = True
        Me.Name = "PICTUREMANIPULATION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CLUB MEMBERS"
        Me.ResumeLayout(False)

    End Sub

#End Region
    '''''Private Sub OlDbBlob2File(ByVal DestFilePath As String, ByVal FFIELD As Integer)
    '''''    Try
    '''''        If Trim(txt_MCode.Text) <> "" Then
    '''''            Dim PictureCol As Integer = 0
    '''''            Dim c As Integer
    '''''            Dim SSQL As String
    '''''            Dim cn As New OleDbConnection("provider=sqloledb;server=" & gserver & ";user id=" & strDataSqlUsr & ";password=" & strDataSqlPwd & ";initial catalog=" & gDatabase)
    '''''            Select Case FFIELD
    '''''                Case 1
    '''''                    SSQL = "SELECT photo FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
    '''''                Case 2
    '''''                    SSQL = "SELECT SIGNATURE FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
    '''''                Case 3
    '''''                    SSQL = "SELECT SPOUSE AS SPOUSE FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
    '''''                Case 4
    '''''                    SSQL = "SELECT SPOUSESIGNATURE AS SPOUSE FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
    '''''                Case 5
    '''''                    SSQL = "SELECT DEP1 FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
    '''''                Case 6
    '''''                    SSQL = "SELECT DEP1SIGNATURE FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
    '''''                Case 7
    '''''                    SSQL = "SELECT DEP2 FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
    '''''                Case 8
    '''''                    SSQL = "SELECT DEP2SIGNATURE FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
    '''''            End Select
    '''''            Dim cmd As New OleDbCommand(SSQL, cn)
    '''''            cn.Open()
    '''''            c = 0
    '''''            Dim dr As OleDbDataReader = cmd.ExecuteReader()
    '''''            If dr.Read = True Then
    '''''                Dim b(dr.GetBytes(PictureCol, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
    '''''                dr.GetBytes(PictureCol, 0, b, 0, b.Length)
    '''''                dr.Close()
    '''''                cn.Close()
    '''''                Dim fs As New System.IO.FileStream(DestFilePath, IO.FileMode.OpenOrCreate, IO.FileAccess.ReadWrite)
    '''''                fs.Write(b, 0, b.Length)
    '''''                fs.Close()
    '''''                Select Case FFIELD
    '''''                    Case 1
    '''''                        memberphoto.Image = New Bitmap(DestFilePath)
    '''''                        PHOTO.Checked = True
    '''''                    Case 2
    '''''                        MEMBERSIGNATURE.Image = New Bitmap(DestFilePath)
    '''''                        SIGNATURE.Checked = True
    '''''                    Case 3
    '''''                        MEMBERSPOUSE.Image = New Bitmap(DestFilePath)
    '''''                        SPOUSE.Checked = True
    '''''                    Case 4
    '''''                        MEMBERSPOUSESIGNATURE.Image = New Bitmap(DestFilePath)
    '''''                        SPOUSESIGNATURE.Checked = True
    '''''                    Case 5
    '''''                        MEMBERDEP1.Image = New Bitmap(DestFilePath)
    '''''                        DEP1PHOTO.Checked = True
    '''''                    Case 6
    '''''                        MEMBERDEP1SIGNATURE.Image = New Bitmap(DestFilePath)
    '''''                        DEP1SIGNATURE.Checked = True
    '''''                    Case 7
    '''''                        MEMBERDEP2.Image = New Bitmap(DestFilePath)
    '''''                        DEP2PHOTO.Checked = True
    '''''                    Case 8
    '''''                        MEMBERDEP2SIGNATURE.Image = New Bitmap(DestFilePath)
    '''''                        DEP2SIGNATURE.Checked = True
    '''''                End Select
    '''''                c = c + 1
    '''''            End If
    '''''            'If c = 0 Then
    '''''            '    Select Case FFIELD
    '''''            '        Case 1
    '''''            '            memberphoto.Image = New Bitmap("\\" & gserver & "\MemberPhotos\Image.Jpg")
    '''''            '            PHOTO.Focus()
    '''''            '        Case 2
    '''''            '            MEMBERSIGNATURE.Image = New Bitmap("\\" & gserver & "\MemberPhotos\Image1.Jpg")
    '''''            '            SIGNATURE.Focus()
    '''''            '        Case 3
    '''''            '            MEMBERSPOUSE.Image = New Bitmap("\\" & gserver & "\MemberPhotos\Image2.Jpg")
    '''''            '            SPOUSE.Focus()
    '''''            '        Case 4
    '''''            '            MEMBERSPOUSESIGNATURE.Image = New Bitmap("\\" & gserver & "\MemberPhotos\Image3.Jpg")
    '''''            '            MEMBERSPOUSESIGNATURE.Focus()
    '''''            '        Case 5
    '''''            '            MEMBERDEP1.Image = New Bitmap("\\" & gserver & "\MemberPhotos\Image4.Jpg")
    '''''            '            MEMBERDEP1.Focus()
    '''''            '        Case 6
    '''''            '            MEMBERDEP1SIGNATURE.Image = New Bitmap("\\" & gserver & "\MemberPhotos\Image5.Jpg")
    '''''            '            MEMBERDEP1SIGNATURE.Focus()
    '''''            '        Case 7
    '''''            '            MEMBERDEP2.Image = New Bitmap("\\" & gserver & "\MemberPhotos\Image6.Jpg")
    '''''            '            MEMBERDEP2.Focus()
    '''''            '        Case 8
    '''''            '            MEMBERDEP2SIGNATURE.Image = New Bitmap("\\" & gserver & "\MemberPhotos\Image7.Jpg")
    '''''            '            MEMBERDEP2SIGNATURE.Focus()
    '''''            '    End Select
    '''''            'End If
    '''''        End If
    '''''    Catch ex As Exception
    '''''        MsgBox("oldbblob2file " & Err.Number & Err.Description, MsgBoxStyle.OKOnly, "ERROR")
    '''''    End Try
    '''''End Sub
    Private Sub File2OleDbBlob(ByVal SourceFilePath As String, ByVal FFIELD As Integer)
        Try
            If Trim(txt_MCode.Text) <> "" Then
                Dim ssql As String
                Dim cn As New OleDbConnection("provider=sqloledb;server=" & gserver & ";user id=" & strDataSqlUsr & ";password=" & strDataSqlPwd & ";initial catalog=" & gDatabase)
                Select Case FFIELD
                    Case 1
                        ssql = "SELECT photo FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                    Case 2
                        ssql = "SELECT SIGNATURE FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                    Case 3
                        ssql = "SELECT SPOUSE FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                    Case 4
                        ssql = "SELECT SPOUSESIGNATURE FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                    Case 5
                        ssql = "SELECT DEP1 FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                    Case 6
                        ssql = "SELECT DEP1SIGNATURE FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                    Case 7
                        ssql = "SELECT DEP2 FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                    Case 8
                        ssql = "SELECT DEP2SIGNATURE FROM member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                End Select
                cn.Open()
                Dim vcmd As New OleDbCommand(ssql, cn)
                Dim vdr As OleDbDataReader = vcmd.ExecuteReader()
                If vdr.Read = False Then
                    ssql = "insert into member_photo (mcode) values('" & Trim(txt_MCode.Text) & "')"
                End If
                cn.Close()
                cn.Open()
                Dim icmd As New OleDbCommand(ssql, cn)
                icmd.ExecuteNonQuery()
                cn.Close()

                Select Case FFIELD
                    Case 1
                        ssql = "UPDATE member_photo SET photo=? WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                    Case 2
                        ssql = "UPDATE member_photo SET SIGNATURE=? WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                    Case 3
                        ssql = "UPDATE member_photo SET SPOUSE=? WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                    Case 4
                        ssql = "UPDATE member_photo SET SPOUSESIGNATURE=? WHERE mcode='" & Trim(txt_MCode.Text) & "'"

                    Case 5
                        ssql = "UPDATE member_photo SET DEP1=? WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                    Case 6
                        ssql = "UPDATE member_photo SET DEP1SIGNATURE=? WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                    Case 7
                        ssql = "UPDATE member_photo SET DEP2=? WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                    Case 8
                        ssql = "UPDATE member_photo SET DEP2SIGNATURE=? WHERE mcode='" & Trim(txt_MCode.Text) & "'"
                End Select
                Dim cmd As New OleDbCommand(ssql, cn)
                If SourceFilePath <> "" Then
                    Dim fs As New System.IO.FileStream(SourceFilePath, IO.FileMode.Open, IO.FileAccess.Read)
                    Dim b(fs.Length() - 1) As Byte
                    fs.Read(b, 0, b.Length)
                    fs.Close()
                    Dim P As New OleDbParameter("@Picture", OleDbType.LongVarBinary, b.Length, ParameterDirection.Input, False, 0, 0, Nothing, DataRowVersion.Current, b)
                    cmd.Parameters.Add(P)
                    cn.Open()
                    cmd.ExecuteNonQuery()
                End If
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox("file2oldbblob " & Err.Number & Err.Description, MsgBoxStyle.OKOnly, "ERROR")
        End Try
    End Sub
    Private Sub PICTUREMANIPULATION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Call clearall()
            txt_MCODE.Focus()
            Show()
        Catch ex As Exception
            MsgBox("PICTUREMANIPULATION_Load " & Err.Number & Err.Description, MsgBoxStyle.OKOnly, "ERROR")
        End Try
    End Sub
   
    
    Private Sub SIGNATURE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
        Catch ex As Exception
            MsgBox("SIGNATURE_Click " & Err.Number & Err.Description, MsgBoxStyle.OKOnly, "ERROR")
        End Try
    End Sub
    Private Sub SPOUSE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
        Catch ex As Exception
            MsgBox("SPOUSE_Click " & Err.Number & Err.Description, MsgBoxStyle.OKOnly, "ERROR")
        End Try
    End Sub
    Private Sub DEP1PHOTO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
        Catch ex As Exception
            MsgBox("DEP1_Click " & Err.Number & Err.Description, MsgBoxStyle.OKOnly, "ERROR")
        End Try
    End Sub
    Private Sub DEP2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Dim cn As New OleDbConnection("provider=sqloledb;server=DBS10;user id=sa;password=;initial catalog=NORTHWIND")
            Dim cn As New OleDbConnection("provider=sqloledb;server=" & gserver & ";user id=" & strDataSqlUsr & ";password=" & strDataSqlPwd & ";initial catalog=" & gDatabase)

            Dim ssql As String
            ssql = "delete member_photo WHERE mcode='" & Trim(txt_MCode.Text) & "'"
            cn.Open()
            Dim icmd As New OleDbCommand(ssql, cn)
            icmd.ExecuteNonQuery()
            cn.Close()
            txt_MCode.Text = ""
            MsgBox("Sucessfully Deleted......", MsgBoxStyle.OKOnly, "DELETE")
            Call clearall()
            txt_MCode.Focus()
            Show()
        Catch ex As Exception
            MsgBox("cmd_Delete_Click " & Err.Number & Err.Description, MsgBoxStyle.OKOnly, "ERROR")
        End Try
    End Sub
    Private Sub CMD_ADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Trim(txt_MCODE.Text) <> "" Then

                MsgBox("Sucessfully Saved......", MsgBoxStyle.OKOnly, "SAVE")
            End If
            Call clearall()
        Catch ex As Exception
            MsgBox("CMD_ADD_Click " & Err.Number & Err.Description, MsgBoxStyle.OKOnly, "ERROR")
        End Try
    End Sub
    Sub clearall()
        Try
            txt_MCODE.Text = ""
            LBLMNAME.Text = ""
            memberphoto.Image = New Bitmap(AppPath & "\IMAGE.Jpg")
            MEMBERDEP1.Image = New Bitmap(AppPath & "\IMAGE2.Jpg")
            LB1.Visible = False
            LBL2.Visible = False
            LBL3.Visible = False
            MEMSTlBL.Text = ""
            LBLMNAME.Text = ""
            ADDR1LBL.Text = ""
            AddrLbl2.Text = ""
            AddrLbl3.Text = ""

        Catch ex As Exception
            MsgBox("clearall " & Err.Number & Err.Description, MsgBoxStyle.OKOnly, "ERROR")
        End Try
    End Sub




    Private Sub DEP2SIGNATURE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub txt_MCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txt_MCODE_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_MCODE.KeyDown
        If e.KeyCode = Keys.Return Then
            Dim STRSQL As String
            STRSQL = " SELECT A.MCODE,A.MNAME,ISNULL(B.TYPEDESC,'') AS TYPEDESC ,ISNULL(A.CURENTSTATUS,'') AS CURENTSTATUS,ISNULL(A.CONTADD1,'') AS CONTADD1,ISNULL(A.CONTADD2,'') AS CONTADD2,ISNULL(A.CONTADD3,'') AS CONTADD3,ISNULL(A.CONTPIN,'') AS CONTPIN FROM MEMBERMASTER A,MEMBERTYPE B WHERE A.MEMBERTYPECODE=B.MEMBERTYPE AND ISNULL(CURENTSTATUS,'')='LIVE' AND  A.MCODE = '" & Trim(txt_MCODE.Text) & "' "
            memberphoto.Image = New Bitmap(AppPath & "\IMAGE.Jpg")
            MEMBERDEP1.Image = New Bitmap(AppPath & "\IMAGE2.Jpg")
            gconnection.getDataSet(STRSQL, "MMASTER")
            If gdataset.Tables("MMASTER").Rows.Count > 0 Then
                LB1.Visible = True
                LBL2.Visible = True
                LBL3.Visible = True
                LBLMNAME.Text = UCase(gdataset.Tables("MMASTER").Rows(0).Item("MNAME"))
                MEMSTlBL.Text = UCase(gdataset.Tables("MMASTER").Rows(0).Item("CURENTSTATUS")) & "(" & UCase(gdataset.Tables("MMASTER").Rows(0).Item("TYPEDESC")) & ")"
                ADDR1LBL.Text = UCase(gdataset.Tables("MMASTER").Rows(0).Item("CONTADD1"))
                AddrLbl2.Text = UCase(gdataset.Tables("MMASTER").Rows(0).Item("CONTADD2"))
                AddrLbl3.Text = UCase(gdataset.Tables("MMASTER").Rows(0).Item("CONTADD3")) & "-" & "-" & UCase(gdataset.Tables("MMASTER").Rows(0).Item("CONTPIN"))
                Call getphoto()
                txt_MCODE.Focus()
            Else
                txt_MCODE.Text = ""
                MEMSTlBL.Text = ""
                LBLMNAME.Text = ""
                ADDR1LBL.Text = ""
                AddrLbl2.Text = ""
                AddrLbl3.Text = ""
                LB1.Visible = False
                LBL2.Visible = False
                LBL3.Visible = False
                memberphoto.Image = New Bitmap(AppPath & "\IMAGE.Jpg")
                MEMBERDEP1.Image = New Bitmap(AppPath & "\IMAGE2.Jpg")
                MsgBox("SORRY NO MEMBERSHIP FOUND.....", MsgBoxStyle.OKOnly, "ERROR")
                txt_MCODE.Focus()
            End If
        End If
    End Sub

    Public Sub getphoto()
        If File.Exists("\\" & gserver & "\Photos\Members\" & Trim(txt_MCODE.Text) & ".Jpg") Then
            memberphoto.Image = New Bitmap("\\" & gserver & "\Photos\Members\" & Trim(txt_MCODE.Text) & ".Jpg")
        ElseIf File.Exists("\\" & gserver & "\Photos\Members\" & Trim(txt_MCODE.Text) & ".GIF") Then
            memberphoto.Image = New Bitmap("\\" & gserver & "\Photos\Members\" & Trim(txt_MCODE.Text) & ".GIF")
        ElseIf File.Exists("\\" & gserver & "\Photos\Image.Jpg") Then
            memberphoto.Image = New Bitmap("\\" & gserver & "\Photos\Image.Jpg")
        ElseIf File.Exists("\\" & gserver & "\Photos\Image.Jpeg") Then
            memberphoto.Image = New Bitmap("\\" & gserver & "\Photos\Image.Jpeg")
        End If

        If File.Exists("\\" & gserver & "\Photos\\signatures\" & Trim(txt_MCODE.Text) & ".Jpg") Then
            MEMBERDEP1.Image = New Bitmap("\\" & gserver & "\photos\signatures\" & Trim(txt_MCODE.Text) & ".Jpg")
        ElseIf File.Exists("\\" & gserver & "\Photos\signatures\" & Trim(txt_MCODE.Text) & ".GIF") Then
            MEMBERDEP1.Image = New Bitmap("\\" & gserver & "\Photos\signatures\" & Trim(txt_MCODE.Text) & ".GIF")
        ElseIf File.Exists("\\" & gserver & "\Photos\Image1.Jpg") Then
            MEMBERDEP1.Image = New Bitmap("\\" & gserver & "\Photos\Image1.Jpg")
        ElseIf File.Exists("\\" & gserver & "\Photos\Image1.Jpeg") Then
            MEMBERDEP1.Image = New Bitmap("\\" & gserver & "\Photos\Image1.Jpeg")
        End If
    End Sub

    Private Sub txt_MCODE_Invalidated(ByVal sender As Object, ByVal e As System.Windows.Forms.InvalidateEventArgs) Handles txt_MCODE.Invalidated

    End Sub

    Private Sub PICTUREMANIPULATION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub PICTUREMANIPULATION_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call CmdClear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Then
            Call cmdexit_Click(sender, e)
        End If
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            Call clearall()
            txt_MCODE.Focus()
        Catch ex As Exception
            MsgBox("CMD_CLEAR_Click " & Err.Number & Err.Description, MsgBoxStyle.OKOnly, "ERROR")
        End Try
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Try
            Me.Close()
        Catch ex As Exception
            MsgBox("CMD_ADD_Click " & Err.Number & Err.Description, MsgBoxStyle.OKOnly, "ERROR")
        End Try
    End Sub
End Class
