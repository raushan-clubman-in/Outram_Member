Public Class frmReports
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
    Public WithEvents Label208 As System.Windows.Forms.Label
    Friend WithEvents cmd_ListView As System.Windows.Forms.Button
    Friend WithEvents cmd_Delete As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chk_Reports As System.Windows.Forms.CheckedListBox
    Friend WithEvents lbl_Caption As System.Windows.Forms.Label
    Friend WithEvents cmd_Display As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lbl_Caption = New System.Windows.Forms.Label
        Me.chk_Reports = New System.Windows.Forms.CheckedListBox
        Me.Label208 = New System.Windows.Forms.Label
        Me.cmd_ListView = New System.Windows.Forms.Button
        Me.cmd_Delete = New System.Windows.Forms.Button
        Me.cmd_Display = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_Caption
        '
        Me.lbl_Caption.BackColor = System.Drawing.Color.Blue
        Me.lbl_Caption.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Caption.ForeColor = System.Drawing.Color.White
        Me.lbl_Caption.Location = New System.Drawing.Point(24, 32)
        Me.lbl_Caption.Name = "lbl_Caption"
        Me.lbl_Caption.Size = New System.Drawing.Size(408, 24)
        Me.lbl_Caption.TabIndex = 62
        Me.lbl_Caption.Text = "Select Feelds To Be Displayed On Report"
        Me.lbl_Caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chk_Reports
        '
        Me.chk_Reports.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.chk_Reports.Location = New System.Drawing.Point(24, 64)
        Me.chk_Reports.Name = "chk_Reports"
        Me.chk_Reports.Size = New System.Drawing.Size(408, 199)
        Me.chk_Reports.TabIndex = 60
        Me.chk_Reports.Visible = False
        '
        'Label208
        '
        Me.Label208.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label208.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label208.Location = New System.Drawing.Point(8, 8)
        Me.Label208.Name = "Label208"
        Me.Label208.Size = New System.Drawing.Size(440, 288)
        Me.Label208.TabIndex = 63
        '
        'cmd_ListView
        '
        Me.cmd_ListView.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmd_ListView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_ListView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ListView.Location = New System.Drawing.Point(168, 328)
        Me.cmd_ListView.Name = "cmd_ListView"
        Me.cmd_ListView.Size = New System.Drawing.Size(104, 32)
        Me.cmd_ListView.TabIndex = 74
        Me.cmd_ListView.Text = "Print"
        '
        'cmd_Delete
        '
        Me.cmd_Delete.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmd_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Delete.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Delete.Location = New System.Drawing.Point(312, 328)
        Me.cmd_Delete.Name = "cmd_Delete"
        Me.cmd_Delete.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Delete.TabIndex = 75
        Me.cmd_Delete.Text = "Close"
        '
        'cmd_Display
        '
        Me.cmd_Display.BackColor = System.Drawing.Color.LightSkyBlue
        Me.cmd_Display.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_Display.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_Display.Location = New System.Drawing.Point(24, 328)
        Me.cmd_Display.Name = "cmd_Display"
        Me.cmd_Display.Size = New System.Drawing.Size(104, 32)
        Me.cmd_Display.TabIndex = 73
        Me.cmd_Display.Text = "Display"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(24, 336)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 30)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(312, 336)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 30)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Label7"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(168, 336)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 30)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Label8"
        '
        'frmReports
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(456, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmd_ListView)
        Me.Controls.Add(Me.cmd_Delete)
        Me.Controls.Add(Me.cmd_Display)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lbl_Caption)
        Me.Controls.Add(Me.chk_Reports)
        Me.Controls.Add(Me.Label208)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmReports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmReports"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim strSQL As String
    Dim strtable As String
    Dim gconnnection As New globalClass
    Private Sub frmReports_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Select Case menustatus
            Case "L"
                lbl_Caption.Text = "Select fields to be displayed on Locker List Report"
                strtable = "membermaster"
                chk_Reports.Items.Clear()
                chk_Reports.Items.Add("Member Code", True)
                chk_Reports.Items.Add("Member Name", True)
                chk_Reports.Items.Add("Status", True)
                chk_Reports.Items.Add("H/P Locker", True)
                chk_Reports.Items.Add("GDR Locker", True)
                chk_Reports.Items.Add("LDR Locker", True)
            Case "C"
                lbl_Caption.Text = "Select fields to be displayed on Credit AC List Report"
                strtable = "membermaster"
                chk_Reports.Items.Clear()
                chk_Reports.Items.Add("Member Code", True)
                chk_Reports.Items.Add("Member Name", True)
                chk_Reports.Items.Add("Status", True)
                chk_Reports.Items.Add("Credit No", True)
                chk_Reports.Items.Add("Deposit", True)
        End Select
    End Sub

    Private Sub cmd_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Delete.Click
        Me.Close()
    End Sub
    Public Function clickMe()
        Select Case menustatus
            Case "L"
                lbl_Caption.Text = "Select fields to be displayed on Locker List Report"
                strtable = "membermaster"
                chk_Reports.Items.Clear()
                chk_Reports.Items.Add("Member Code", True)
                chk_Reports.Items.Add("Member Name", True)
                chk_Reports.Items.Add("Status", True)
                chk_Reports.Items.Add("H/P Locker", True)
                chk_Reports.Items.Add("GDR Locker", True)
                chk_Reports.Items.Add("LDR Locker", True)
            Case "C"
                lbl_Caption.Text = "Select fields to be displayed on Credit AC List Report"
                strtable = "membermaster"
                chk_Reports.Items.Clear()
                chk_Reports.Items.Add("Member Code", True)
                chk_Reports.Items.Add("Member Name", True)
                chk_Reports.Items.Add("Status", True)
                chk_Reports.Items.Add("Credit No", True)
                chk_Reports.Items.Add("Deposit", True)
        End Select
        '''****************** This is a substitute for cmd_Display_Click to acess directly from memu
        Dim serialreport As New SerialReport("", "", "", "")

        serialreport.BEGIN()
        serialreport.BUTTONCLICK(chk_Reports, strtable)

    End Function

    Private Sub cmd_Display_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_Display.Click
        Dim serialreport As New SerialReport("", "", "", "")
        serialreport.BEGIN()
        serialreport.BUTTONCLICK(chk_Reports, strtable)
    End Sub

End Class
