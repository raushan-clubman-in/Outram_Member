Imports System.Data
Imports System.Data.SqlClient
Imports System.io
Public Class rem1
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim selectoption As Boolean
    Dim Vrowid As Integer
    Dim vtype As String
    Dim SSQL As String
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim FltrStr, TempString(2), DispString, addFltrStr As String
    Dim sqlStringFinal, sqlstring As String
    Public selectNo As Integer
    Dim AddStr1(10), AddStr2(10) As String
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
    Public WithEvents fraletter As System.Windows.Forms.GroupBox
    Public WithEvents optthird As System.Windows.Forms.RadioButton
    Public WithEvents optsecond As System.Windows.Forms.RadioButton
    Public WithEvents optfirst As System.Windows.Forms.RadioButton
    Friend WithEvents ssgrid1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents CmdDel As System.Windows.Forms.Button
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rem1))
        Me.fraletter = New System.Windows.Forms.GroupBox
        Me.optthird = New System.Windows.Forms.RadioButton
        Me.optsecond = New System.Windows.Forms.RadioButton
        Me.optfirst = New System.Windows.Forms.RadioButton
        Me.ssgrid1 = New AxFPSpreadADO.AxfpSpread
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdExit = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.CmdDel = New System.Windows.Forms.Button
        Me.CmdSave = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.fraletter.SuspendLayout()
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'fraletter
        '
        Me.fraletter.BackColor = System.Drawing.Color.Transparent
        Me.fraletter.Controls.Add(Me.optthird)
        Me.fraletter.Controls.Add(Me.optsecond)
        Me.fraletter.Controls.Add(Me.optfirst)
        Me.fraletter.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fraletter.ForeColor = System.Drawing.SystemColors.WindowText
        Me.fraletter.Location = New System.Drawing.Point(232, 64)
        Me.fraletter.Name = "fraletter"
        Me.fraletter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fraletter.Size = New System.Drawing.Size(312, 43)
        Me.fraletter.TabIndex = 2
        Me.fraletter.TabStop = False
        Me.fraletter.Text = "LETTER NO."
        '
        'optthird
        '
        Me.optthird.BackColor = System.Drawing.Color.Transparent
        Me.optthird.Cursor = System.Windows.Forms.Cursors.Default
        Me.optthird.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optthird.ForeColor = System.Drawing.SystemColors.MenuText
        Me.optthird.Location = New System.Drawing.Point(212, 18)
        Me.optthird.Name = "optthird"
        Me.optthird.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optthird.Size = New System.Drawing.Size(84, 17)
        Me.optthird.TabIndex = 4
        Me.optthird.TabStop = True
        Me.optthird.Text = "Third time"
        '
        'optsecond
        '
        Me.optsecond.BackColor = System.Drawing.Color.Transparent
        Me.optsecond.Cursor = System.Windows.Forms.Cursors.Default
        Me.optsecond.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optsecond.ForeColor = System.Drawing.SystemColors.MenuText
        Me.optsecond.Location = New System.Drawing.Point(96, 17)
        Me.optsecond.Name = "optsecond"
        Me.optsecond.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optsecond.Size = New System.Drawing.Size(101, 17)
        Me.optsecond.TabIndex = 3
        Me.optsecond.TabStop = True
        Me.optsecond.Text = "Second time"
        '
        'optfirst
        '
        Me.optfirst.BackColor = System.Drawing.Color.Transparent
        Me.optfirst.Checked = True
        Me.optfirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.optfirst.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optfirst.ForeColor = System.Drawing.SystemColors.MenuText
        Me.optfirst.Location = New System.Drawing.Point(2, 18)
        Me.optfirst.Name = "optfirst"
        Me.optfirst.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optfirst.Size = New System.Drawing.Size(86, 17)
        Me.optfirst.TabIndex = 2
        Me.optfirst.TabStop = True
        Me.optfirst.Text = "First time"
        '
        'ssgrid1
        '
        Me.ssgrid1.DataSource = Nothing
        Me.ssgrid1.Location = New System.Drawing.Point(16, 128)
        Me.ssgrid1.Name = "ssgrid1"
        Me.ssgrid1.OcxState = CType(resources.GetObject("ssgrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid1.Size = New System.Drawing.Size(744, 376)
        Me.ssgrid1.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdExit)
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.Controls.Add(Me.CmdDel)
        Me.GroupBox2.Controls.Add(Me.CmdSave)
        Me.GroupBox2.Location = New System.Drawing.Point(64, 520)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 56)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'CmdExit
        '
        Me.CmdExit.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.ForeColor = System.Drawing.Color.White
        Me.CmdExit.Image = CType(resources.GetObject("CmdExit.Image"), System.Drawing.Image)
        Me.CmdExit.Location = New System.Drawing.Point(512, 14)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(104, 32)
        Me.CmdExit.TabIndex = 35
        Me.CmdExit.Text = "Exit[F11]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(391, 14)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 34
        Me.CmdClear.Text = "Clear[F6]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(143, 14)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 32
        Me.CmdView.Text = "List View [F9]"
        '
        'CmdDel
        '
        Me.CmdDel.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdDel.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDel.ForeColor = System.Drawing.Color.White
        Me.CmdDel.Image = CType(resources.GetObject("CmdDel.Image"), System.Drawing.Image)
        Me.CmdDel.Location = New System.Drawing.Point(271, 14)
        Me.CmdDel.Name = "CmdDel"
        Me.CmdDel.Size = New System.Drawing.Size(104, 32)
        Me.CmdDel.TabIndex = 33
        Me.CmdDel.Text = "Freeze[F7]"
        '
        'CmdSave
        '
        Me.CmdSave.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSave.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSave.ForeColor = System.Drawing.Color.White
        Me.CmdSave.Image = CType(resources.GetObject("CmdSave.Image"), System.Drawing.Image)
        Me.CmdSave.Location = New System.Drawing.Point(16, 14)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(104, 32)
        Me.CmdSave.TabIndex = 31
        Me.CmdSave.Text = "Add New[F7]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(200, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(399, 35)
        Me.Label2.TabIndex = 387
        Me.Label2.Text = "REMINDER LETTER MASTER"
        '
        'rem1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(776, 598)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ssgrid1)
        Me.Controls.Add(Me.fraletter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "rem1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reminder Letter Master"
        Me.fraletter.ResumeLayout(False)
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub rem1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ssgrid1.ClearRange(1, 1, -1, -1, True)
        Call FillMatter()
        ssgrid1.Focus()
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
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='MEMBER' AND MODULENAME LIKE '" & Trim(GmoduleName) & "'"
        gconnection.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.CmdSave.Enabled = False
        Me.CmdDel.Enabled = False
        Me.CmdView.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdSave.Enabled = True
                    Me.CmdDel.Enabled = True
                    Me.CmdView.Enabled = True
                    Exit Sub
                End If
                If UCase(Mid(Me.CmdSave.Text, 1, 1)) = "A" Then
                    If Right(x) = "S" Then
                        Me.CmdSave.Enabled = True
                    End If
                Else
                    If Right(x) = "M" Then
                        Me.CmdSave.Enabled = True
                    End If
                End If
                If Right(x) = "D" Then
                    Me.CmdDel.Enabled = True
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                End If
            Next
        End If
    End Sub

    Function FillMatter()
        Dim MainMenu As Object
        Dim ADODB As Object
        Dim Loopindex As Integer
        Dim vtype As String
        Dim i As Integer
        Dim bill As New DataTable
        Dim bill1 As New DataTable
        Dim dt As New DataTable
        If optfirst.Checked = True Then
            vtype = "FIRST"
        ElseIf optsecond.Checked = True Then
            vtype = "SECOND"
        Else
            vtype = "THIRD"
        End If
        Dim TNAME As String
        TNAME = "MESSAGE"
        sqlstring = "Select * from TerminateLetter where Doctype='" & Trim(vtype) & "' and Trantype='HEADER' order by slno"
        bill = gconnection.GetValues(sqlstring)
        If bill.Rows.Count > 0 Then
            Loopindex = 0
            ssgrid1.ClearRange(1, 1, -1, -1, True)
            ssgrid1.Focus()
            For i = 0 To bill.Rows.Count - 1
                Loopindex = Loopindex + 1
                ssgrid1.SetText(1, Loopindex, bill.Rows(i).Item("MESSAGE"))
            Next
            CmdDel.Enabled = True
        End If
    End Function
    Private Sub DeleteOperation()
        Dim MainMenu As Object
        If optfirst.Checked = True Then
            vtype = "FIRST"
        ElseIf optsecond.Checked = True Then
            vtype = "SECOND"
        Else
            vtype = "THIRD"
        End If
        Dim vAns As String
        vAns = CStr(MsgBox("Do you want to Delete", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.DefaultButton2, Me.Text))
        If vAns = CStr(MsgBoxResult.No) Then
            Exit Sub
        End If
        SSQL = "Delete from TerminateLetter where Doctype='" & Trim(vtype) & "'"
        gconnection.dataOperation(1, SSQL, "MemberType")
        MsgBox("Record Deleted Successfully", MsgBoxStyle.Information, Me.Text)
        Call ClearOperation()
        Exit Sub
    End Sub
    Private Sub CmdDel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call DeleteOperation()
    End Sub
    Private Sub CmdClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ClearOperation()
    End Sub

    Private Sub rem1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F12 Then
            Call ClearOperation()
        End If
        If e.KeyCode = Keys.F7 Then
            Call AddOperation()
        End If
        If e.KeyCode = Keys.F11 Then
            Me.Close()
        End If
    End Sub
    Private Sub ClearOperation()
        ssgrid1.ClearRange(1, 1, ssgrid1.MaxCols, ssgrid1.MaxRows, True)
        CmdDel.Enabled = False
    End Sub
    Private Sub AddOperation()
        Dim MainMenu As Object
        Dim Loopindex As Integer
        Dim SSQL As String
        Dim Vdesc As Object
        Dim vtype As String
        If ssgrid1.DataRowCnt = 0 Then
            MsgBox("Grid Details cannot be Blank", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If
        If optfirst.Checked = True Then
            vtype = "FIRST"
        ElseIf optsecond.Checked = True Then
            vtype = "SECOND"
        Else
            vtype = "THIRD"
        End If
        SSQL = "Delete from TerminateLetter where Doctype='" & Trim(vtype) & "'"
        dt = gconnection.GetValues(SSQL)
        For Loopindex = 1 To ssgrid1.DataRowCnt
            Vdesc = Nothing
            ssgrid1.GetText(1, Loopindex, Vdesc)
            SSQL = "Insert into TerminateLetter(doctype,Trantype,Slno,Message) values("
            SSQL = SSQL & " '" & vtype & "','HEADER'," & Loopindex & ",'" & Vdesc & "')"
            gconnection.dataOperation(1, SSQL, "MemberType")
        Next Loopindex
        MessageBox.Show("Record Saved ", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Information)
        Exit Sub
    End Sub
    Private Sub optfirst_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optfirst.Click
        If optfirst.Checked Then
            ssgrid1.ClearRange(1, 1, -1, -1, True)
            Call FillMatter()
        End If
    End Sub
    Private Sub optsecond_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optsecond.Click
        If optsecond.Checked Then
            ssgrid1.ClearRange(1, 1, -1, -1, True)
            Call FillMatter()
        End If
    End Sub

    Private Sub optthird_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optthird.Click
        If optthird.Checked Then
            ssgrid1.ClearRange(1, 1, -1, -1, True)
            Call FillMatter()
        End If
    End Sub

    Private Sub ssgrid1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid1.KeyDownEvent
        If e.keyCode = Keys.Enter Then
            With ssgrid1
                .Row = .ActiveRow
                .Col = 1
                ssgrid1.SetActiveCell(1, ssgrid1.ActiveRow + 1)
            End With
        End If
        If e.keyCode = Keys.F3 Then
            ssgrid1.Row = ssgrid1.ActiveRow
            ssgrid1.Action = 5
        End If
        If e.keyCode = Keys.F4 Then
            ssgrid1.Row = ssgrid1.ActiveRow
            ssgrid1.Action = 7
        End If
    End Sub

    Private Sub CmdSave_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        Call AddOperation()
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        ClearOperation()
    End Sub

    Private Sub CmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdExit.Click
        Me.Close()
    End Sub

    Private Sub CmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDel.Click
        DeleteOperation()
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Dim FrReport As New ReportDesigner
        tables = "FROM TERMINATELETTER"
        Gheader = "REMINDER LETTER"
        FrReport.SsGridReport.SetText(2, 1, "MESSAGE")
        FrReport.SsGridReport.SetText(3, 1, 79)
        FrReport.Show()
    End Sub
End Class
