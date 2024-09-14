Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports CrystalDecisions.reportsource
Imports CrystalDecisions.shared
Imports CrystalDecisions.web
Imports CrystalDecisions.CrystalReports.Engine
Public Class AffiliatedClubList
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
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents list_ClubName As System.Windows.Forms.CheckedListBox
    Friend WithEvents chk_AllClubName As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents txtClubName As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(AffiliatedClubList))
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chk_AllClubName = New System.Windows.Forms.CheckBox
        Me.list_ClubName = New System.Windows.Forms.CheckedListBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.txtClubName = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(120, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(288, 29)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "AFFILIATED CLUB LIST"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtClubName)
        Me.GroupBox1.Controls.Add(Me.chk_AllClubName)
        Me.GroupBox1.Controls.Add(Me.list_ClubName)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 304)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'chk_AllClubName
        '
        Me.chk_AllClubName.BackColor = System.Drawing.Color.Transparent
        Me.chk_AllClubName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_AllClubName.Location = New System.Drawing.Point(80, 24)
        Me.chk_AllClubName.Name = "chk_AllClubName"
        Me.chk_AllClubName.Size = New System.Drawing.Size(168, 16)
        Me.chk_AllClubName.TabIndex = 394
        Me.chk_AllClubName.Text = "Select All Club Details"
        '
        'list_ClubName
        '
        Me.list_ClubName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_ClubName.Location = New System.Drawing.Point(80, 40)
        Me.list_ClubName.Name = "list_ClubName"
        Me.list_ClubName.Size = New System.Drawing.Size(304, 228)
        Me.list_ClubName.TabIndex = 121
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(24, 376)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 56)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.BackgroundImage = CType(resources.GetObject("CmdClear.BackgroundImage"), System.Drawing.Image)
        Me.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Location = New System.Drawing.Point(240, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(80, 32)
        Me.CmdClear.TabIndex = 5
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
        Me.cmdexit.Location = New System.Drawing.Point(360, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(72, 32)
        Me.cmdexit.TabIndex = 6
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
        Me.cmdPrint.Location = New System.Drawing.Point(128, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(80, 32)
        Me.cmdPrint.TabIndex = 16
        Me.cmdPrint.Text = "Print[F12]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdView.BackgroundImage = CType(resources.GetObject("CmdView.BackgroundImage"), System.Drawing.Image)
        Me.CmdView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Location = New System.Drawing.Point(24, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(80, 32)
        Me.CmdView.TabIndex = 3
        Me.CmdView.Text = "View[F9]"
        '
        'txtClubName
        '
        Me.txtClubName.Location = New System.Drawing.Point(80, 280)
        Me.txtClubName.Name = "txtClubName"
        Me.txtClubName.Size = New System.Drawing.Size(304, 20)
        Me.txtClubName.TabIndex = 395
        Me.txtClubName.Text = ""
        Me.txtClubName.Visible = False
        '
        'AffiliatedClubList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(512, 454)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "AffiliatedClubList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AffiliatedClubList"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim sqlstring As String
    Dim gconnection As New GlobalClass
    Private Sub AffiliatedClubList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AffiliatedClubNameLoad()
    End Sub

    Private Sub chk_AllClubName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllClubName.CheckedChanged
        Dim Iteration As Integer
        If chk_AllClubName.Checked = True Then
            Try
                For Iteration = 0 To (list_ClubName.Items.Count - 1)
                    list_ClubName.SetSelected(Iteration, True)
                    list_ClubName.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (list_ClubName.Items.Count - 1)
                    list_ClubName.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            Dim i As Integer
            chk_AllClubName.Checked = False
            For i = 0 To list_ClubName.Items.Count - 1
                list_ClubName.SetItemChecked(i, False)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        PRINTREP = True
    End Sub

    Public Sub AffiliatedClubNameLoad()
        Dim AffiliatedClub As New DataTable
        sqlstring = "Select ClubName From affiliatedclubdetails where Freeze='N'"
        AffiliatedClub = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (AffiliatedClub.Rows.Count - 1)
            list_ClubName.Items.Add(AffiliatedClub.Rows(Itration).Item("ClubName"))
        Next

    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        'txtClubName.Text = ""
        'Dim o As Object
        'For Each o In list_ClubName.CheckedItems
        '    txtClubName.Text += o.ToString() & ","
        'Next o
        'MessageBox.Show(txtClubName.Text.Substring(0, txtClubName.Text.Length - 1))

        Printoperation2()

    End Sub


    Private Sub Printoperation2()
        Dim DT As New DataTable
        Try
            txtClubName.Text = ""
            Dim o As Object
            For Each o In list_ClubName.CheckedItems
                txtClubName.Text += o.ToString() & ","
            Next o

            sqlstring = "select * from vw_affiliatedclubdetails where Freeze='N' and  clubname in  ('" & txtClubName.Text.Substring(0, txtClubName.Text.Length - 1) & "')"
            'sqlstring = "Select * From  affiliatedclubdetails where Freeze='N' and ClubName in (" & "'" & txtClubName.Text.Substring(0, txtClubName.Text.Length - 1) & "')"
            'gconnection.GetValues(sqlstring)


            Dim Viewer As New ReportViwer
            Dim a As New AFFCLUBLIST
            Viewer.ssql = sqlstring
            Viewer.Report = a
            Viewer.TableName = "vw_affiliatedclubdetails"
            Viewer.Show()
            'Dim Path As String = Application.StartupPath.Substring(0, Application.StartupPath.Length - 3)

            'Dim fullpath As String
            'fullpath = Path & "CrystalReports\AFFCLUBLIST.rpt"

            ''fullpath = Application.StartupPath & "CRY_MemberMaster.rpt"
            ''MessageBox.Show(fullpath)
            ''Exit Sub
            'Dim cryRpt As New ReportDocument
            'cryRpt.Load(fullpath)
            ''cryRpt.Load("\CrystalReports\CRY_MemberMaster.rpt")

            'Dim crParameterFieldDefinitions As ParameterFieldDefinitions
            'Dim crParameterFieldDefinition As ParameterFieldDefinition
            'Dim crParameterValues As New ParameterValues
            'Dim crParameterDiscreteValue As New ParameterDiscreteValue

            'crParameterDiscreteValue.Value = txtClubName.Text.Substring(0, txtClubName.Text.Length - 1)
            'crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields()
            'crParameterFieldDefinition = crParameterFieldDefinitions.Item("ClubName")
            'crParameterValues = crParameterFieldDefinition.CurrentValues

            'crParameterValues.Clear()
            'crParameterValues.Add(crParameterDiscreteValue)
            'crParameterFieldDefinition.ApplyCurrentValues(crParameterValues)

            'Viewer.CrystalReportViewer1.ReportSource = cryRpt
            'Viewer.CrystalReportViewer1.Refresh()
            'Viewer.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Exit Sub
    End Sub
End Class
