Imports System.Data
Imports System.IO
Imports CrystalDecisions.reportsource
Imports CrystalDecisions.shared
Imports CrystalDecisions.web
Imports CrystalDecisions.CrystalReports.Engine
Public Class MembersDetails
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
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Public WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chk_AllMemberType As System.Windows.Forms.CheckBox
    Friend WithEvents list_MemberType As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents chk_propossser As System.Windows.Forms.CheckBox
    Friend WithEvents txtMemberType As System.Windows.Forms.TextBox
    Friend WithEvents Chk_Professional As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_bloodgroup As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_gender As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MembersDetails))
        Me.btnExport = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.chk_AllMemberType = New System.Windows.Forms.CheckBox
        Me.list_MemberType = New System.Windows.Forms.CheckedListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.chk_propossser = New System.Windows.Forms.CheckBox
        Me.Chk_Professional = New System.Windows.Forms.CheckBox
        Me.Chk_bloodgroup = New System.Windows.Forms.CheckBox
        Me.txtMemberType = New System.Windows.Forms.TextBox
        Me.Chk_gender = New System.Windows.Forms.CheckBox
        Me.SuspendLayout()
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.SystemColors.Menu
        Me.btnExport.BackgroundImage = CType(resources.GetObject("btnExport.BackgroundImage"), System.Drawing.Image)
        Me.btnExport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExport.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.ForeColor = System.Drawing.Color.White
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.Location = New System.Drawing.Point(584, 600)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(104, 40)
        Me.btnExport.TabIndex = 19
        Me.btnExport.Text = "Export[F7]"
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.BackgroundImage = CType(resources.GetObject("CmdClear.BackgroundImage"), System.Drawing.Image)
        Me.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Image = CType(resources.GetObject("CmdClear.Image"), System.Drawing.Image)
        Me.CmdClear.Location = New System.Drawing.Point(456, 600)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 40)
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
        Me.cmdexit.Image = CType(resources.GetObject("cmdexit.Image"), System.Drawing.Image)
        Me.cmdexit.Location = New System.Drawing.Point(712, 600)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(96, 40)
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
        Me.cmdPrint.Image = CType(resources.GetObject("cmdPrint.Image"), System.Drawing.Image)
        Me.cmdPrint.Location = New System.Drawing.Point(328, 600)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 40)
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
        Me.CmdView.Image = CType(resources.GetObject("CmdView.Image"), System.Drawing.Image)
        Me.CmdView.Location = New System.Drawing.Point(200, 600)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 40)
        Me.CmdView.TabIndex = 3
        Me.CmdView.Text = "View[F9]"
        '
        'chk_AllMemberType
        '
        Me.chk_AllMemberType.BackColor = System.Drawing.Color.Transparent
        Me.chk_AllMemberType.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_AllMemberType.Location = New System.Drawing.Point(344, 72)
        Me.chk_AllMemberType.Name = "chk_AllMemberType"
        Me.chk_AllMemberType.Size = New System.Drawing.Size(248, 16)
        Me.chk_AllMemberType.TabIndex = 394
        Me.chk_AllMemberType.Text = "Select All Member Type"
        '
        'list_MemberType
        '
        Me.list_MemberType.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_MemberType.Location = New System.Drawing.Point(344, 96)
        Me.list_MemberType.Name = "list_MemberType"
        Me.list_MemberType.Size = New System.Drawing.Size(304, 208)
        Me.list_MemberType.TabIndex = 121
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(408, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(224, 29)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "MEMBER DETAILS"
        '
        'chk_propossser
        '
        Me.chk_propossser.BackColor = System.Drawing.Color.Transparent
        Me.chk_propossser.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_propossser.Location = New System.Drawing.Point(344, 400)
        Me.chk_propossser.Name = "chk_propossser"
        Me.chk_propossser.Size = New System.Drawing.Size(296, 24)
        Me.chk_propossser.TabIndex = 2338
        Me.chk_propossser.Text = "Members Propossers/Seconders"
        '
        'Chk_Professional
        '
        Me.Chk_Professional.BackColor = System.Drawing.Color.Transparent
        Me.Chk_Professional.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_Professional.Location = New System.Drawing.Point(344, 432)
        Me.Chk_Professional.Name = "Chk_Professional"
        Me.Chk_Professional.Size = New System.Drawing.Size(360, 24)
        Me.Chk_Professional.TabIndex = 2339
        Me.Chk_Professional.Text = "Professional/Designation Details"
        '
        'Chk_bloodgroup
        '
        Me.Chk_bloodgroup.BackColor = System.Drawing.Color.Transparent
        Me.Chk_bloodgroup.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_bloodgroup.Location = New System.Drawing.Point(344, 464)
        Me.Chk_bloodgroup.Name = "Chk_bloodgroup"
        Me.Chk_bloodgroup.Size = New System.Drawing.Size(344, 24)
        Me.Chk_bloodgroup.TabIndex = 2340
        Me.Chk_bloodgroup.Text = "Members Based on blood Group and Age"
        '
        'txtMemberType
        '
        Me.txtMemberType.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMemberType.Location = New System.Drawing.Point(344, 304)
        Me.txtMemberType.Name = "txtMemberType"
        Me.txtMemberType.Size = New System.Drawing.Size(304, 21)
        Me.txtMemberType.TabIndex = 2344
        Me.txtMemberType.Text = ""
        Me.txtMemberType.Visible = False
        '
        'Chk_gender
        '
        Me.Chk_gender.BackColor = System.Drawing.Color.Transparent
        Me.Chk_gender.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_gender.Location = New System.Drawing.Point(344, 496)
        Me.Chk_gender.Name = "Chk_gender"
        Me.Chk_gender.Size = New System.Drawing.Size(344, 24)
        Me.Chk_gender.TabIndex = 2345
        Me.Chk_gender.Text = "Members Based on Gender and Age group"
        '
        'MembersDetails
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1016, 686)
        Me.Controls.Add(Me.Chk_gender)
        Me.Controls.Add(Me.txtMemberType)
        Me.Controls.Add(Me.Chk_bloodgroup)
        Me.Controls.Add(Me.Chk_Professional)
        Me.Controls.Add(Me.chk_propossser)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.chk_AllMemberType)
        Me.Controls.Add(Me.list_MemberType)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.CmdView)
        Me.Name = "MembersDetails"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Members Details"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim txtobj1 As TextObject
    Dim gconnection As New GlobalClass
    Private Sub MembersDetails_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MemberStrengthLoad()
    End Sub
    Public Sub MemberStrengthLoad()
        Dim dt As New DataTable
        sqlstring = "Select subtypedesc From subcategorymaster"
        dt = gconnection.GetValues(sqlstring)
        Dim Itration
        For Itration = 0 To (dt.Rows.Count - 1)
            list_MemberType.Items.Add(dt.Rows(Itration).Item("subtypedesc"))
        Next

    End Sub


    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            Dim i As Integer
            chk_AllMemberType.Checked = False
            For i = 0 To list_MemberType.Items.Count - 1
                list_MemberType.SetItemChecked(i, False)
            Next
            txtMemberType.Text = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Chk_Professional.Checked = False
        Chk_bloodgroup.Checked = False
        chk_propossser.Checked = False
        Chk_gender.Checked = False
    End Sub

    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Printoperation2()
    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        If (list_MemberType.CheckedItems.Count <= 0) Then
            MessageBox.Show("Select the Member Type Items")
            Exit Sub
        End If
        Printoperation2()
    End Sub

    Private Sub Printoperation2()
        Dim DT As New DataTable
        Dim HEADING As String
        Try
            txtMemberType.Text = ""
            Dim o As Object
            For Each o In list_MemberType.CheckedItems
                txtMemberType.Text += "'" & o.ToString() & "',"
            Next o
            'sqlstring = "select * from mm_view_membermaster where Membertype in (" & (txtMemberType.Text.Substring(0, txtMemberType.Text.Length - 1)) & ")"
            If chk_propossser.Checked = True Then
                sqlstring = "select * from mm_view_membermaster where Membertype in (" & (txtMemberType.Text.Substring(0, txtMemberType.Text.Length - 1)) & ")"
                Dim Viewer As New ReportViwer
                Dim r As New Cry_Proposser
                HEADING = "PROPOSSER SECONDERS LIST"
                txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                txtobj1.Text = UCase(HEADING)
                txtobj1 = r.ReportDefinition.ReportObjects("Text14")
                txtobj1.Text = UCase(gCompanyname)
                txtobj1 = r.ReportDefinition.ReportObjects("Text15")
                txtobj1.Text = UCase(gCompanyAddress(1))
                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1.Text = UCase(gCompanyAddress(2))
                txtobj1 = r.ReportDefinition.ReportObjects("Text17")
                txtobj1.Text = UCase(gCompanyAddress(3))
                txtobj1 = r.ReportDefinition.ReportObjects("Text13")
                txtobj1.Text = UCase(gUsername)
                Viewer.ssql = sqlstring
                Viewer.Report = r
                Viewer.TableName = "mm_view_membermaster"
                Viewer.Show()
            ElseIf Chk_Professional.Checked = True Then
                sqlstring = "select * from mm_view_membermaster where Membertype in (" & (txtMemberType.Text.Substring(0, txtMemberType.Text.Length - 1)) & ")"
                Dim Viewer As New ReportViwer
                Dim r As New Cry_Professional_det
                HEADING = "PROFESSIONAL AND DESIGNATION DETAILS"
                txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                txtobj1.Text = UCase(HEADING)
                txtobj1 = r.ReportDefinition.ReportObjects("Text14")
                txtobj1.Text = UCase(gCompanyname)
                txtobj1 = r.ReportDefinition.ReportObjects("Text15")
                txtobj1.Text = UCase(gCompanyAddress(1))
                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1.Text = UCase(gCompanyAddress(2))
                txtobj1 = r.ReportDefinition.ReportObjects("Text17")
                txtobj1.Text = UCase(gCompanyAddress(3))
                txtobj1 = r.ReportDefinition.ReportObjects("Text13")
                txtobj1.Text = UCase(gUsername)
                Viewer.ssql = sqlstring
                Viewer.Report = r
                Viewer.TableName = "mm_view_membermaster"
                Viewer.Show()
            ElseIf Chk_bloodgroup.Checked = True Then
                sqlstring = "select * from MM_View_Agelimit where Membertype in (" & (txtMemberType.Text.Substring(0, txtMemberType.Text.Length - 1)) & ")"
                Dim Viewer As New ReportViwer
                Dim r As New Cry_bloodgroup_det
                HEADING = "AGE AND BLOOD GROUP DETAILS"
                txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                txtobj1.Text = UCase(HEADING)
                txtobj1 = r.ReportDefinition.ReportObjects("Text14")
                txtobj1.Text = UCase(gCompanyname)
                txtobj1 = r.ReportDefinition.ReportObjects("Text15")
                txtobj1.Text = UCase(gCompanyAddress(1))
                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1.Text = UCase(gCompanyAddress(2))
                txtobj1 = r.ReportDefinition.ReportObjects("Text17")
                txtobj1.Text = UCase(gCompanyAddress(3))
                txtobj1 = r.ReportDefinition.ReportObjects("Text13")
                txtobj1.Text = UCase(gUsername)
                Viewer.ssql = sqlstring
                Viewer.Report = r
                Viewer.TableName = "MM_View_Agelimit"
                Viewer.Show()
            ElseIf Chk_gender.Checked = True Then
                sqlstring = "select * from mm_view_membermaster where Membertype in (" & (txtMemberType.Text.Substring(0, txtMemberType.Text.Length - 1)) & ")"
                Dim Viewer As New ReportViwer
                Dim r As New Cry_Gender_detials
                HEADING = "MEMBERS GENDERS DETAILS"
                txtobj1 = r.ReportDefinition.ReportObjects("Text28")
                txtobj1.Text = UCase(HEADING)
                txtobj1 = r.ReportDefinition.ReportObjects("Text14")
                txtobj1.Text = UCase(gCompanyname)
                txtobj1 = r.ReportDefinition.ReportObjects("Text15")
                txtobj1.Text = UCase(gCompanyAddress(1))
                txtobj1 = r.ReportDefinition.ReportObjects("Text16")
                txtobj1.Text = UCase(gCompanyAddress(2))
                txtobj1 = r.ReportDefinition.ReportObjects("Text17")
                txtobj1.Text = UCase(gCompanyAddress(3))
                txtobj1 = r.ReportDefinition.ReportObjects("Text13")
                txtobj1.Text = UCase(gUsername)
                Viewer.ssql = sqlstring
                Viewer.Report = r
                Viewer.TableName = "mm_view_membermaster"
                Viewer.Show()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Exit Sub
    End Sub

    Private Sub chk_AllMemberType_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_AllMemberType.CheckedChanged
        Dim Iteration As Integer
        If chk_AllMemberType.Checked = True Then
            Try
                For Iteration = 0 To (list_MemberType.Items.Count - 1)
                    list_MemberType.SetSelected(Iteration, True)
                    list_MemberType.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (list_MemberType.Items.Count - 1)
                    list_MemberType.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        Try
            Dim _export As New EXPORT
            txtMemberType.Text = ""
            Dim o As Object
            For Each o In list_MemberType.CheckedItems
                txtMemberType.Text += "'" & o.ToString() & "',"
            Next o

            sqlstring = "select * from vw_cellingmaster where cellingcode in (" & (txtMemberType.Text.Substring(0, txtMemberType.Text.Length - 1)) & ")"
            _export.TABLENAME = "vw_cellingmaster"
            Call _export.export_excel(sqlstring)
            _export.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub MembersDetails_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Try
            If e.KeyCode = Keys.F6 Then
                If CmdClear.Enabled = True Then
                    Call CmdClear_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F9 Then
                If CmdView.Enabled = True Then
                    Call CmdView_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F12 Then
                If cmdPrint.Enabled = True Then
                    Call cmdPrint_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F7 Then
                If btnExport.Enabled = True Then
                    Call btnExport_Click(sender, e)
                    Exit Sub
                End If
            ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
                If cmdexit.Enabled = True Then
                    Call cmdexit_Click(sender, e)
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub chk_propossser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_propossser.CheckedChanged
       
    End Sub

    Private Sub Chk_Professional_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Professional.CheckedChanged
       
    End Sub

    Private Sub Chk_bloodgroup_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_bloodgroup.CheckedChanged
     
    End Sub

    Private Sub Chk_bloodgroup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_bloodgroup.Click
        Chk_Professional.Checked = False
        Chk_bloodgroup.Checked = True
        chk_propossser.Checked = False
        Chk_gender.Checked = False
    End Sub

    Private Sub Chk_Professional_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_Professional.Click
        Chk_Professional.Checked = True
        Chk_bloodgroup.Checked = False
        chk_propossser.Checked = False
        Chk_gender.Checked = False
    End Sub

    Private Sub chk_propossser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_propossser.Click
        Chk_Professional.Checked = False
        Chk_bloodgroup.Checked = False
        chk_propossser.Checked = True
        Chk_gender.Checked = False
    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Chk_gender_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_gender.CheckedChanged

    End Sub

    Private Sub Chk_gender_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Chk_gender.Click
        Chk_Professional.Checked = False
        Chk_bloodgroup.Checked = False
        chk_propossser.Checked = False
        Chk_gender.Checked = True
    End Sub
End Class
