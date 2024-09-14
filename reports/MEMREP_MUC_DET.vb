Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Collections
Imports System.ComponentModel
Imports System.ComponentModel.Design
Imports System.IO
Imports CrystalDecisions.reportsource
Imports CrystalDecisions.shared
Imports CrystalDecisions.web
Public Class MEMREP_MUC_DET
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim Iteration, I, J As Integer
    Dim STR_STATUS, STR_TYPE, STR_OPCTION As String
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
    Friend WithEvents GrpBox As System.Windows.Forms.GroupBox
    Friend WithEvents CmdExport As System.Windows.Forms.Button
    Friend WithEvents cmdGExit As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chklist_Membername As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CHK_MEMBERCATEGORY As System.Windows.Forms.CheckBox
    Friend WithEvents ChKLIST_Memberstatus As System.Windows.Forms.CheckedListBox
    Friend WithEvents CHK_STATUS As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_SELECT As System.Windows.Forms.CheckBox
    Friend WithEvents CHKLIST_SELECT As System.Windows.Forms.CheckedListBox
    Friend WithEvents LAB_OPCTION As System.Windows.Forms.Label
    Friend WithEvents RDB_SUB_SUMMARY As System.Windows.Forms.RadioButton
    Friend WithEvents RDB_SUB_DETAIL As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CHKLIST_SUBSCRIPTIONMAST As System.Windows.Forms.CheckedListBox
    Friend WithEvents CHK_SUBSCRIPTION As System.Windows.Forms.CheckBox
    Friend WithEvents RDB_MEMBER_LIST_SUBS As System.Windows.Forms.RadioButton
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents RDB_Facility_List As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MEMREP_MUC_DET))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RDB_Facility_List = New System.Windows.Forms.RadioButton
        Me.RDB_MEMBER_LIST_SUBS = New System.Windows.Forms.RadioButton
        Me.RDB_SUB_SUMMARY = New System.Windows.Forms.RadioButton
        Me.RDB_SUB_DETAIL = New System.Windows.Forms.RadioButton
        Me.GrpBox = New System.Windows.Forms.GroupBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdExport = New System.Windows.Forms.Button
        Me.cmdGExit = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.CHK_MEMBERCATEGORY = New System.Windows.Forms.CheckBox
        Me.chklist_Membername = New System.Windows.Forms.CheckedListBox
        Me.ChKLIST_Memberstatus = New System.Windows.Forms.CheckedListBox
        Me.CHK_STATUS = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.LAB_OPCTION = New System.Windows.Forms.Label
        Me.CHK_SELECT = New System.Windows.Forms.CheckBox
        Me.CHKLIST_SELECT = New System.Windows.Forms.CheckedListBox
        Me.CHKLIST_SUBSCRIPTIONMAST = New System.Windows.Forms.CheckedListBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CHK_SUBSCRIPTION = New System.Windows.Forms.CheckBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1.SuspendLayout()
        Me.GrpBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RDB_Facility_List)
        Me.GroupBox1.Controls.Add(Me.RDB_MEMBER_LIST_SUBS)
        Me.GroupBox1.Controls.Add(Me.RDB_SUB_SUMMARY)
        Me.GroupBox1.Controls.Add(Me.RDB_SUB_DETAIL)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 496)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(928, 40)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'RDB_Facility_List
        '
        Me.RDB_Facility_List.AllowDrop = True
        Me.RDB_Facility_List.BackColor = System.Drawing.Color.Transparent
        Me.RDB_Facility_List.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RDB_Facility_List.Location = New System.Drawing.Point(720, 12)
        Me.RDB_Facility_List.Name = "RDB_Facility_List"
        Me.RDB_Facility_List.Size = New System.Drawing.Size(200, 24)
        Me.RDB_Facility_List.TabIndex = 434
        Me.RDB_Facility_List.Text = "Facility Wise  Member"
        '
        'RDB_MEMBER_LIST_SUBS
        '
        Me.RDB_MEMBER_LIST_SUBS.AllowDrop = True
        Me.RDB_MEMBER_LIST_SUBS.BackColor = System.Drawing.Color.Transparent
        Me.RDB_MEMBER_LIST_SUBS.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RDB_MEMBER_LIST_SUBS.Location = New System.Drawing.Point(520, 12)
        Me.RDB_MEMBER_LIST_SUBS.Name = "RDB_MEMBER_LIST_SUBS"
        Me.RDB_MEMBER_LIST_SUBS.Size = New System.Drawing.Size(168, 24)
        Me.RDB_MEMBER_LIST_SUBS.TabIndex = 433
        Me.RDB_MEMBER_LIST_SUBS.Text = "Facility Det"
        '
        'RDB_SUB_SUMMARY
        '
        Me.RDB_SUB_SUMMARY.AllowDrop = True
        Me.RDB_SUB_SUMMARY.Checked = True
        Me.RDB_SUB_SUMMARY.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RDB_SUB_SUMMARY.Location = New System.Drawing.Point(64, 13)
        Me.RDB_SUB_SUMMARY.Name = "RDB_SUB_SUMMARY"
        Me.RDB_SUB_SUMMARY.Size = New System.Drawing.Size(136, 24)
        Me.RDB_SUB_SUMMARY.TabIndex = 0
        Me.RDB_SUB_SUMMARY.TabStop = True
        Me.RDB_SUB_SUMMARY.Text = "SUMMARY"
        '
        'RDB_SUB_DETAIL
        '
        Me.RDB_SUB_DETAIL.AllowDrop = True
        Me.RDB_SUB_DETAIL.BackColor = System.Drawing.Color.Transparent
        Me.RDB_SUB_DETAIL.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RDB_SUB_DETAIL.Location = New System.Drawing.Point(240, 13)
        Me.RDB_SUB_DETAIL.Name = "RDB_SUB_DETAIL"
        Me.RDB_SUB_DETAIL.Size = New System.Drawing.Size(216, 24)
        Me.RDB_SUB_DETAIL.TabIndex = 432
        Me.RDB_SUB_DETAIL.Text = "Summary Member  Wise"
        '
        'GrpBox
        '
        Me.GrpBox.BackColor = System.Drawing.Color.Transparent
        Me.GrpBox.Controls.Add(Me.CmdClear)
        Me.GrpBox.Controls.Add(Me.CmdExport)
        Me.GrpBox.Controls.Add(Me.cmdGExit)
        Me.GrpBox.Controls.Add(Me.CmdView)
        Me.GrpBox.Location = New System.Drawing.Point(344, 544)
        Me.GrpBox.Name = "GrpBox"
        Me.GrpBox.Size = New System.Drawing.Size(432, 56)
        Me.GrpBox.TabIndex = 3
        Me.GrpBox.TabStop = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.CmdClear.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdClear.Location = New System.Drawing.Point(32, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(74, 32)
        Me.CmdClear.TabIndex = 4
        Me.CmdClear.Text = "Clear [F6]"
        '
        'CmdExport
        '
        Me.CmdExport.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.CmdExport.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdExport.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdExport.Location = New System.Drawing.Point(224, 16)
        Me.CmdExport.Name = "CmdExport"
        Me.CmdExport.Size = New System.Drawing.Size(78, 32)
        Me.CmdExport.TabIndex = 2
        Me.CmdExport.Text = "Export"
        '
        'cmdGExit
        '
        Me.cmdGExit.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.cmdGExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdGExit.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmdGExit.Location = New System.Drawing.Point(320, 16)
        Me.cmdGExit.Name = "cmdGExit"
        Me.cmdGExit.Size = New System.Drawing.Size(78, 32)
        Me.cmdGExit.TabIndex = 3
        Me.cmdGExit.Text = "Exit [F11]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.Color.FromArgb(CType(141, Byte), CType(154, Byte), CType(156, Byte))
        Me.CmdView.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdView.Location = New System.Drawing.Point(128, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(77, 32)
        Me.CmdView.TabIndex = 0
        Me.CmdView.Text = "View [F9]"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Maroon
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(528, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(232, 24)
        Me.Label4.TabIndex = 424
        Me.Label4.Text = "Member List"
        '
        'CHK_MEMBERCATEGORY
        '
        Me.CHK_MEMBERCATEGORY.BackColor = System.Drawing.Color.Transparent
        Me.CHK_MEMBERCATEGORY.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_MEMBERCATEGORY.Location = New System.Drawing.Point(528, 131)
        Me.CHK_MEMBERCATEGORY.Name = "CHK_MEMBERCATEGORY"
        Me.CHK_MEMBERCATEGORY.Size = New System.Drawing.Size(141, 24)
        Me.CHK_MEMBERCATEGORY.TabIndex = 423
        Me.CHK_MEMBERCATEGORY.Text = "SELECT ALL"
        '
        'chklist_Membername
        '
        Me.chklist_Membername.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.chklist_Membername.Location = New System.Drawing.Point(528, 179)
        Me.chklist_Membername.Name = "chklist_Membername"
        Me.chklist_Membername.Size = New System.Drawing.Size(232, 319)
        Me.chklist_Membername.TabIndex = 422
        '
        'ChKLIST_Memberstatus
        '
        Me.ChKLIST_Memberstatus.BackColor = System.Drawing.Color.White
        Me.ChKLIST_Memberstatus.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChKLIST_Memberstatus.Items.AddRange(New Object() {"1.ABSENTEE", "2.DELETED", "3.EXPIRED", "4.INACTIVE", "5.LIVE", "6.RESIGNED", "7.SURRENDERED"})
        Me.ChKLIST_Memberstatus.Location = New System.Drawing.Point(768, 176)
        Me.ChKLIST_Memberstatus.Name = "ChKLIST_Memberstatus"
        Me.ChKLIST_Memberstatus.Size = New System.Drawing.Size(224, 319)
        Me.ChKLIST_Memberstatus.Sorted = True
        Me.ChKLIST_Memberstatus.TabIndex = 425
        '
        'CHK_STATUS
        '
        Me.CHK_STATUS.BackColor = System.Drawing.Color.Transparent
        Me.CHK_STATUS.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_STATUS.Location = New System.Drawing.Point(768, 131)
        Me.CHK_STATUS.Name = "CHK_STATUS"
        Me.CHK_STATUS.Size = New System.Drawing.Size(164, 23)
        Me.CHK_STATUS.TabIndex = 426
        Me.CHK_STATUS.Text = "Select All Status"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Maroon
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(768, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 24)
        Me.Label1.TabIndex = 427
        Me.Label1.Text = "Member Status"
        '
        'LAB_OPCTION
        '
        Me.LAB_OPCTION.BackColor = System.Drawing.Color.Maroon
        Me.LAB_OPCTION.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAB_OPCTION.ForeColor = System.Drawing.Color.White
        Me.LAB_OPCTION.Location = New System.Drawing.Point(272, 152)
        Me.LAB_OPCTION.Name = "LAB_OPCTION"
        Me.LAB_OPCTION.Size = New System.Drawing.Size(240, 24)
        Me.LAB_OPCTION.TabIndex = 431
        Me.LAB_OPCTION.Text = "MEMBER LIST"
        '
        'CHK_SELECT
        '
        Me.CHK_SELECT.BackColor = System.Drawing.Color.Transparent
        Me.CHK_SELECT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_SELECT.Location = New System.Drawing.Point(272, 130)
        Me.CHK_SELECT.Name = "CHK_SELECT"
        Me.CHK_SELECT.Size = New System.Drawing.Size(141, 24)
        Me.CHK_SELECT.TabIndex = 430
        Me.CHK_SELECT.Text = "SELECT ALL"
        '
        'CHKLIST_SELECT
        '
        Me.CHKLIST_SELECT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CHKLIST_SELECT.Location = New System.Drawing.Point(272, 176)
        Me.CHKLIST_SELECT.Name = "CHKLIST_SELECT"
        Me.CHKLIST_SELECT.Size = New System.Drawing.Size(240, 319)
        Me.CHKLIST_SELECT.TabIndex = 429
        '
        'CHKLIST_SUBSCRIPTIONMAST
        '
        Me.CHKLIST_SUBSCRIPTIONMAST.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.CHKLIST_SUBSCRIPTIONMAST.Location = New System.Drawing.Point(48, 175)
        Me.CHKLIST_SUBSCRIPTIONMAST.Name = "CHKLIST_SUBSCRIPTIONMAST"
        Me.CHKLIST_SUBSCRIPTIONMAST.Size = New System.Drawing.Size(216, 319)
        Me.CHKLIST_SUBSCRIPTIONMAST.TabIndex = 432
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Maroon
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(50, 151)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 24)
        Me.Label2.TabIndex = 433
        Me.Label2.Text = "SUBSCRIPTION  TYPE"
        '
        'CHK_SUBSCRIPTION
        '
        Me.CHK_SUBSCRIPTION.BackColor = System.Drawing.Color.Transparent
        Me.CHK_SUBSCRIPTION.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_SUBSCRIPTION.Location = New System.Drawing.Point(56, 127)
        Me.CHK_SUBSCRIPTION.Name = "CHK_SUBSCRIPTION"
        Me.CHK_SUBSCRIPTION.Size = New System.Drawing.Size(141, 24)
        Me.CHK_SUBSCRIPTION.TabIndex = 434
        Me.CHK_SUBSCRIPTION.Text = "SELECT ALL"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(368, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 20)
        Me.Label10.TabIndex = 437
        Me.Label10.Text = "MUC MONTH OF"
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.CbxMonth.Location = New System.Drawing.Point(576, 72)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(112, 26)
        Me.CbxMonth.TabIndex = 436
        '
        'MEMREP_MUC_DET
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(982, 628)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbxMonth)
        Me.Controls.Add(Me.CHK_SUBSCRIPTION)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CHKLIST_SUBSCRIPTIONMAST)
        Me.Controls.Add(Me.LAB_OPCTION)
        Me.Controls.Add(Me.CHK_SELECT)
        Me.Controls.Add(Me.CHKLIST_SELECT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CHK_STATUS)
        Me.Controls.Add(Me.ChKLIST_Memberstatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CHK_MEMBERCATEGORY)
        Me.Controls.Add(Me.chklist_Membername)
        Me.Controls.Add(Me.GrpBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.KeyPreview = True
        Me.Name = "MEMREP_MUC_DET"
        Me.Text = " MEMREP_SUBSCRIPTION_DET"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GrpBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim ssql As String
    Private Sub MEMREP_MUC_DET_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SYS_DATE_TIME()
            MemberType_Load()
            Member_Master_Load()
            Subscription_Master_Load()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        Try
            CHK_MEMBERCATEGORY.Checked = False
            CHK_STATUS.Checked = False
            CHK_SELECT.Checked = False
            CHK_SUBSCRIPTION.Checked = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CHK_MEMBERCATEGORY_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_MEMBERCATEGORY.CheckedChanged
        Try
            If CHK_MEMBERCATEGORY.Checked = True Then
                For Iteration = 0 To (chklist_Membername.Items.Count - 1)
                    chklist_Membername.SetSelected(Iteration, True)
                    chklist_Membername.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (chklist_Membername.Items.Count - 1)
                    chklist_Membername.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub CHK_STATUS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_STATUS.CheckedChanged
        Try
            If CHK_STATUS.Checked = True Then
                For Iteration = 0 To (ChKLIST_Memberstatus.Items.Count - 1)
                    ChKLIST_Memberstatus.SetSelected(Iteration, True)
                    ChKLIST_Memberstatus.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (ChKLIST_Memberstatus.Items.Count - 1)
                    ChKLIST_Memberstatus.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub MemberType_Load()
        Try
            Dim DT As New DataTable
            chklist_Membername.Items.Clear()
            ssql = " Select isnull(Membertype,'') as Membertype,isnull(typedesc,'') as Typedesc From Membertype "
            DT = gconnection.GetValues(ssql)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    chklist_Membername.Items.Add(DT.Rows(Iteration).Item("typedesc") & Space(70) & "." & DT.Rows(Iteration).Item("memberType"))
                Next
            Else
                chklist_Membername.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Member_Master_Load()
        Try
            Dim DT As New DataTable
            CHKLIST_SELECT.Items.Clear()
            ssql = " Select isnull(Mcode,'') as Mcode,isnull(Mname,'') as Mname From MemberMaster "
            DT = gconnection.GetValues(ssql)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    CHKLIST_SELECT.Items.Add(DT.Rows(Iteration).Item("Mcode") & "." & DT.Rows(Iteration).Item("Mname"))
                Next
            Else
                CHKLIST_SELECT.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Subscription_Master_Load()
        Try
            Dim DT As New DataTable
            CHKLIST_SUBSCRIPTIONMAST.Items.Clear()
            ssql = " SELECT ISNULL(SUBSCODE,'') AS SUBSCODE,ISNULL(SUBSDESC,'') AS SUBSDESC FROM SUBSCRIPTIONMAST "
            DT = gconnection.GetValues(ssql)
            If DT.Rows.Count > 0 Then
                For Iteration = 0 To (DT.Rows.Count - 1)
                    CHKLIST_SUBSCRIPTIONMAST.Items.Add(DT.Rows(Iteration).Item("SUBSCODE") & "." & DT.Rows(Iteration).Item("SUBSDESC"))
                Next
            Else
                CHKLIST_SUBSCRIPTIONMAST.Items.Clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub cmdGExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGExit.Click
        Me.Hide()
    End Sub
    Private Function MeValidate() As Boolean
        Try
            MeValidate = True
            Dim MTYPECODE(0) As String

            If chklist_Membername.CheckedItems.Count > 0 Then
                For I = 0 To chklist_Membername.CheckedItems.Count - 1
                    MTYPECODE = Split(chklist_Membername.CheckedItems(I), ".")
                    STR_TYPE = STR_TYPE & " '" & Trim(MTYPECODE(0)) & "', "
                Next
                STR_TYPE = Mid(STR_TYPE, 1, Len(STR_TYPE) - 2)
                'STR_TYPE = STR_TYPE & ")"
            Else
                MsgBox("Please Select The Member Type ", vbInformation)
                MeValidate = False
                Exit Function
            End If

            If ChKLIST_Memberstatus.CheckedItems.Count > 0 Then
                For I = 0 To ChKLIST_Memberstatus.CheckedItems.Count - 1
                    MTYPECODE = Split(ChKLIST_Memberstatus.CheckedItems(I), ".")
                    STR_STATUS = STR_STATUS & " '" & Trim(MTYPECODE(1)) & "', "
                Next
                STR_STATUS = Mid(STR_STATUS, 1, Len(STR_STATUS) - 2)
            Else
                MsgBox("Please Select The Member Status Name", vbInformation)
                MeValidate = False
                Exit Function
            End If
            If CHKLIST_SELECT.CheckedItems.Count > 0 Then
                For I = 0 To CHKLIST_SELECT.CheckedItems.Count - 1
                    MTYPECODE = Split(CHKLIST_SELECT.CheckedItems(I), ".")
                    STR_OPCTION = STR_OPCTION & " '" & Trim(MTYPECODE(0)) & "', "
                Next
                STR_OPCTION = Mid(STR_OPCTION, 1, Len(STR_OPCTION) - 2)
            Else
                MsgBox("Please Select The Member(S)", vbInformation)
                Exit Function
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Try
            Dim sqlstring, bildt, mthyar As String
            Dim MONTH1, Noofdays As Integer
            Dim Viewer As New ReportViwer
            Dim txtobj1 As TextObject
            Dim txtobj2 As TextObject
            Dim txtobj3 As TextObject
            Dim txtobj4 As TextObject
            Dim txtobj5 As TextObject
            STR_OPCTION = ""
            STR_STATUS = ""
            STR_TYPE = ""
            If MeValidate() = False Then Exit Sub

            If Mid(Me.CbxMonth.Text, 1, 5) = "April" Then MONTH1 = 4 : Noofdays = 30 : bildt = "01/apr/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "May" Then MONTH1 = 5 : Noofdays = 31 : bildt = "01/may/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 3) = "Jun" Then MONTH1 = 6 : Noofdays = 30 : bildt = "01/jun/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 4) = "July" Then MONTH1 = 7 : Noofdays = 31 : bildt = "01/jul/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 6) = "August" Then MONTH1 = 8 : Noofdays = 31 : bildt = "01/aug/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 9) = "September" Then MONTH1 = 9 : Noofdays = 30 : bildt = "01/sep/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "October" Then MONTH1 = 10 : Noofdays = 31 : bildt = "01/oct/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "November" Then MONTH1 = 11 : Noofdays = 30 : bildt = "01/nov/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "December" Then MONTH1 = 12 : Noofdays = 31 : bildt = "01/dec/" & Mid(gFinancialyearStart, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 7) = "January" Then MONTH1 = 1 : Noofdays = 31 : bildt = "01/jan/" & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 8) = "February" Then MONTH1 = 2 : Noofdays = 28 : bildt = "01/feb/" & Mid(gFinancialYearEnd, 7, 4)
            If Mid(Me.CbxMonth.Text, 1, 5) = "March" Then MONTH1 = 3 : Noofdays = 31 : bildt = "01/mar/" & Mid(gFinancialYearEnd, 7, 4)
            If RDB_SUB_SUMMARY.Checked = True Then
                Dim r As New Cry_SUBS_SUMMARY
                mthyar = "SUBSCRIPTION SUMMARY FOR THE MONTH OF :"
                mthyar = mthyar & UCase(Mid(Me.CbxMonth.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
                sqlstring = " SELECT SUBSCODE,SUBSDESC,ISNULL(SUM(SUBAMOUNT),0) AS SUBAMOUNT,ISNULL(SUM(TAXAMOUNT),0) AS TAXAMOUNT FROM VIEW_SUBS_SUMMARY "
                sqlstring = sqlstring & " WHERE  MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ") "
                sqlstring = sqlstring & " AND MCODE IN(" & STR_OPCTION & ") AND MONTH(BILLDATE)=" & MONTH1
                sqlstring = sqlstring & " GROUP BY SUBSCODE,SUBSDESC "
                txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                txtobj2 = r.ReportDefinition.ReportObjects("Text6")
                txtobj3 = r.ReportDefinition.ReportObjects("Text18")
                txtobj4 = r.ReportDefinition.ReportObjects("Text16")
                txtobj5 = r.ReportDefinition.ReportObjects("Text2")

                Call Viewer.GetDetails1(sqlstring, "VIEW_SUBS_SUMMARY", r)
            ElseIf RDB_SUB_DETAIL.Checked = True Then
                mthyar = "SUBSCRIPTION SUMMARY FOR THE MONTH OF :"
                mthyar = mthyar & UCase(Mid(Me.CbxMonth.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
                Dim r As New Cry_Subs_Details
                sqlstring = " SELECT MCODE,MEM_NAME,ISNULL(SUM(SUBAMOUNT),0) AS  SUBAMOUNT,ISNULL(SUM(FLTAMOUNT),0) AS  FLTAMOUNT,ISNULL(SUM(MINAMOUNT),0) AS MINAMOUNT,ISNULL(SUM(TAXAMOUNT),0) AS TAXAMOUNT  FROM VIEW_MEM_REP_SUBS_FLT_MUM "
                sqlstring = sqlstring & " WHERE  MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ") "
                sqlstring = sqlstring & " AND MCODE IN(" & STR_OPCTION & ") AND MONTH(BILLDATE)=" & MONTH1
                sqlstring = sqlstring & " GROUP BY MCODE,MEM_NAME "
                txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                txtobj2 = r.ReportDefinition.ReportObjects("Text6")
                txtobj3 = r.ReportDefinition.ReportObjects("Text18")
                txtobj4 = r.ReportDefinition.ReportObjects("Text16")
                txtobj5 = r.ReportDefinition.ReportObjects("Text2")
                Call Viewer.GetDetails1(sqlstring, "VIEW_MEM_REP_SUBS_FLT_MUM", r)

            ElseIf RDB_MEMBER_LIST_SUBS.Checked = True Then
                Dim r As New Cry_Subscription_Det
                mthyar = " SUBSCRIPTION DETAILS FOR THE MONTH OF :"
                mthyar = mthyar & UCase(Mid(Me.CbxMonth.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
                sqlstring = " SELECT MCODE,MEM_NAME,SUBSDESC,ISNULL(SUM(SUBAMOUNT),0) AS SUBAMOUNT,ISNULL(SUM(ISNULL(TAXAMOUNT,0)),0) AS TAXAMOUNT FROM VIEW_SUBS_SUMMARY "
                sqlstring = sqlstring & " WHERE  MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ") "
                sqlstring = sqlstring & " AND MCODE IN(" & STR_OPCTION & ") AND MONTH(BILLDATE)=" & MONTH1
                sqlstring = sqlstring & " GROUP BY MCODE,MEM_NAME,SUBSDESC "
                txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                txtobj2 = r.ReportDefinition.ReportObjects("Text6")
                txtobj3 = r.ReportDefinition.ReportObjects("Text18")
                txtobj4 = r.ReportDefinition.ReportObjects("Text16")
                txtobj5 = r.ReportDefinition.ReportObjects("Text2")
                Call Viewer.GetDetails1(sqlstring, "VIEW_SUBS_SUMMARY", r)

            ElseIf RDB_Facility_List.Checked = True Then
                Dim r As New Cry_Facilit_mem_List
                mthyar = "FACILITY DETAILS FOR THE MONTH OF :"
                mthyar = mthyar & UCase(Mid(Me.CbxMonth.Text, 1, 3)) & "-" & IIf(MONTH1 > 3, Mid(gFinancalyearStart, 7, 4), Mid(gFinancialYearEnd, 7, 4))
                sqlstring = " select MCODE,DNAME,SUBSDESC  FROM VIEW_FACILITY_LIST "
                sqlstring = sqlstring & " WHERE  MEMBERTYPE IN(" & STR_TYPE & ") AND CURRENTSTATUS IN(" & STR_STATUS & ") "
                sqlstring = sqlstring & " AND MCODE IN(" & STR_OPCTION & ") AND MONTH(BILLDATE)=" & MONTH1 & " AND YEAR(BILLDATE)= " & Year(CbxMonth.Value)
                txtobj1 = r.ReportDefinition.ReportObjects("Text1")
                txtobj2 = r.ReportDefinition.ReportObjects("Text6")
                txtobj3 = r.ReportDefinition.ReportObjects("Text18")
                txtobj4 = r.ReportDefinition.ReportObjects("Text16")
                txtobj5 = r.ReportDefinition.ReportObjects("Text2")
                Call Viewer.GetDetails1(sqlstring, "VIEW_FACILITY_LIST", r)
            End If
            txtobj1.Text = UCase(gCompanyname)
            txtobj2.Text = Format(sysdate, "dd/MM/yyyy")
            txtobj3.Text = Mid(gFinancialyearStart, 7, 4) & " - " & Mid(gFinancialYearEnd, 7, 4)
            txtobj4.Text = UCase(gUsername)
            txtobj5.Text = mthyar
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub CHK_SELECT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_SELECT.CheckedChanged
        Try
            If CHK_SELECT.Checked = True Then
                For Iteration = 0 To (CHKLIST_SELECT.Items.Count - 1)
                    CHKLIST_SELECT.SetSelected(Iteration, True)
                    CHKLIST_SELECT.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (CHKLIST_SELECT.Items.Count - 1)
                    CHKLIST_SELECT.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub SYS_DATE_TIME()
        Dim sqlstring As String
        Try
            sqlstring = "SELECT SERVERDATE,SERVERTIME FROM VIEW_SERVER_DATETIME "
            gconnection.getDataSet(sqlstring, "SERVERDATE")
            If gdataset.Tables("SERVERDATE").Rows.Count > 0 Then
                sysdate = Format(gdataset.Tables("SERVERDATE").Rows(0).Item("SERVERDATE"), "dd/MM/yyyy")
            End If
        Catch ex As Exception
            MessageBox.Show("Enter a valid datetime :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Private Sub CHK_SUBSCRIPTION_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_SUBSCRIPTION.CheckedChanged
        Try
            If CHK_SUBSCRIPTION.Checked = True Then
                For Iteration = 0 To (CHKLIST_SUBSCRIPTIONMAST.Items.Count - 1)
                    CHKLIST_SUBSCRIPTIONMAST.SetSelected(Iteration, True)
                    CHKLIST_SUBSCRIPTIONMAST.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (CHKLIST_SUBSCRIPTIONMAST.Items.Count - 1)
                    CHKLIST_SUBSCRIPTIONMAST.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CHKLIST_SUBSCRIPTIONMAST_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKLIST_SUBSCRIPTIONMAST.SelectedIndexChanged

    End Sub

    Private Sub RDB_Facility_List_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDB_Facility_List.CheckedChanged

    End Sub

    Private Sub RDB_MEMBER_LIST_SUBS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RDB_MEMBER_LIST_SUBS.CheckedChanged

    End Sub
End Class
