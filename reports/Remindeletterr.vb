Imports System.Data.SqlClient
Imports System.IO
Public Class Remindeletterr
    Inherits System.Windows.Forms.Form
    Dim dAdapter As New SqlDataAdapter
    Dim da As New SqlDataAdapter
    Dim dSet, ds As New DataSet
    Dim gconnection As New GlobalClass
    Public sqlStringFinal, DispString As String
    Dim sqlString, billtype As String
    Dim count, mmcode As String
    Dim iNumber As Integer
    Dim storedPro_str As String
    Dim Fromdate, ToDate As String
    Dim postype As String
    Dim chk_month As String
    Dim subsbill, posting, madrs As New DataTable
    Dim addFltrStr, FltrStr As String
    Public TempString(2) As String
    Public selectNo As Integer
    Dim Processed_Chk(4) As Integer
    Dim totalamt, totaltax As Double
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
    Friend WithEvents GBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_disp As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbo_BillingBasis As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ChkList_month As System.Windows.Forms.CheckedListBox
    Friend WithEvents Lst_status1 As System.Windows.Forms.ListBox
    Friend WithEvents Lst_status As System.Windows.Forms.ListBox
    Friend WithEvents GBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_Print As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmd_CategoryCodeHelp As System.Windows.Forms.Button
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents Cmb_add_filter As System.Windows.Forms.ComboBox
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents cmb_Filter_By As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Remindeletterr))
        Me.GBox2 = New System.Windows.Forms.GroupBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_disp = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.cbo_BillingBasis = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.ChkList_month = New System.Windows.Forms.CheckedListBox
        Me.Lst_status1 = New System.Windows.Forms.ListBox
        Me.Lst_status = New System.Windows.Forms.ListBox
        Me.GBox1 = New System.Windows.Forms.GroupBox
        Me.Btn_cancel = New System.Windows.Forms.Button
        Me.btn_Print = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmd_CategoryCodeHelp = New System.Windows.Forms.Button
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.Cmb_add_filter = New System.Windows.Forms.ComboBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.cmb_Filter_By = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GBox1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GBox2
        '
        Me.GBox2.BackColor = System.Drawing.Color.Transparent
        Me.GBox2.Controls.Add(Me.Button2)
        Me.GBox2.Controls.Add(Me.btn_close)
        Me.GBox2.Controls.Add(Me.btn_disp)
        Me.GBox2.Location = New System.Drawing.Point(88, 568)
        Me.GBox2.Name = "GBox2"
        Me.GBox2.Size = New System.Drawing.Size(664, 56)
        Me.GBox2.TabIndex = 382
        Me.GBox2.TabStop = False
        Me.GBox2.Visible = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(264, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Print"
        '
        'btn_close
        '
        Me.btn_close.BackgroundImage = CType(resources.GetObject("btn_close.BackgroundImage"), System.Drawing.Image)
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.Location = New System.Drawing.Point(432, 16)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 32)
        Me.btn_close.TabIndex = 10
        Me.btn_close.Text = "Close"
        '
        'btn_disp
        '
        Me.btn_disp.BackgroundImage = CType(resources.GetObject("btn_disp.BackgroundImage"), System.Drawing.Image)
        Me.btn_disp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_disp.ForeColor = System.Drawing.Color.White
        Me.btn_disp.Location = New System.Drawing.Point(120, 16)
        Me.btn_disp.Name = "btn_disp"
        Me.btn_disp.Size = New System.Drawing.Size(104, 32)
        Me.btn_disp.TabIndex = 8
        Me.btn_disp.Text = "Display"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cbo_BillingBasis)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.ChkList_month)
        Me.Panel1.Controls.Add(Me.Lst_status1)
        Me.Panel1.Controls.Add(Me.Lst_status)
        Me.Panel1.Location = New System.Drawing.Point(152, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(544, 392)
        Me.Panel1.TabIndex = 383
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(220, -35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 20)
        Me.Label4.TabIndex = 366
        Me.Label4.Text = "Type of Posting"
        '
        'cbo_BillingBasis
        '
        Me.cbo_BillingBasis.BackColor = System.Drawing.Color.AntiqueWhite
        Me.cbo_BillingBasis.Items.AddRange(New Object() {"NONE"})
        Me.cbo_BillingBasis.Location = New System.Drawing.Point(111, 53)
        Me.cbo_BillingBasis.Name = "cbo_BillingBasis"
        Me.cbo_BillingBasis.Size = New System.Drawing.Size(304, 26)
        Me.cbo_BillingBasis.TabIndex = 364
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(192, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 20)
        Me.Label6.TabIndex = 367
        Me.Label6.Text = "Select the Period"
        '
        'ChkList_month
        '
        Me.ChkList_month.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ChkList_month.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkList_month.Location = New System.Drawing.Point(104, 125)
        Me.ChkList_month.Name = "ChkList_month"
        Me.ChkList_month.Size = New System.Drawing.Size(312, 232)
        Me.ChkList_month.TabIndex = 365
        '
        'Lst_status1
        '
        Me.Lst_status1.ItemHeight = 18
        Me.Lst_status1.Items.AddRange(New Object() {"1.ABSENTEE", "2.LIVE"})
        Me.Lst_status1.Location = New System.Drawing.Point(488, 224)
        Me.Lst_status1.Name = "Lst_status1"
        Me.Lst_status1.Size = New System.Drawing.Size(48, 94)
        Me.Lst_status1.TabIndex = 371
        Me.Lst_status1.Visible = False
        '
        'Lst_status
        '
        Me.Lst_status.ItemHeight = 18
        Me.Lst_status.Items.AddRange(New Object() {"1.ABSENTEE", "2.DELETED", "3.EXPIRED", "4.INACTIVE", "5.LIVE", "6.RESIGNED", "7.SURRENDERED"})
        Me.Lst_status.Location = New System.Drawing.Point(488, 96)
        Me.Lst_status.Name = "Lst_status"
        Me.Lst_status.Size = New System.Drawing.Size(112, 94)
        Me.Lst_status.TabIndex = 370
        Me.Lst_status.Visible = False
        '
        'GBox1
        '
        Me.GBox1.BackColor = System.Drawing.Color.Transparent
        Me.GBox1.Controls.Add(Me.Btn_cancel)
        Me.GBox1.Controls.Add(Me.btn_Print)
        Me.GBox1.Location = New System.Drawing.Point(96, 505)
        Me.GBox1.Name = "GBox1"
        Me.GBox1.Size = New System.Drawing.Size(664, 56)
        Me.GBox1.TabIndex = 381
        Me.GBox1.TabStop = False
        '
        'Btn_cancel
        '
        Me.Btn_cancel.BackgroundImage = CType(resources.GetObject("Btn_cancel.BackgroundImage"), System.Drawing.Image)
        Me.Btn_cancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_cancel.ForeColor = System.Drawing.Color.White
        Me.Btn_cancel.Location = New System.Drawing.Point(344, 16)
        Me.Btn_cancel.Name = "Btn_cancel"
        Me.Btn_cancel.Size = New System.Drawing.Size(104, 32)
        Me.Btn_cancel.TabIndex = 368
        Me.Btn_cancel.Text = "Cancel"
        '
        'btn_Print
        '
        Me.btn_Print.BackgroundImage = CType(resources.GetObject("btn_Print.BackgroundImage"), System.Drawing.Image)
        Me.btn_Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Print.ForeColor = System.Drawing.Color.White
        Me.btn_Print.Location = New System.Drawing.Point(224, 16)
        Me.btn_Print.Name = "btn_Print"
        Me.btn_Print.Size = New System.Drawing.Size(104, 32)
        Me.btn_Print.TabIndex = 367
        Me.btn_Print.Text = "Print"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(288, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.TabIndex = 378
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 464)
        Me.GroupBox1.TabIndex = 380
        Me.GroupBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(392, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 20)
        Me.Label5.TabIndex = 363
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.cmd_CategoryCodeHelp)
        Me.Panel2.Controls.Add(Me.chk_PrintAll)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.tbx_filter_To)
        Me.Panel2.Controls.Add(Me.tbx_Filter_From)
        Me.Panel2.Controls.Add(Me.Cmb_add_filter)
        Me.Panel2.Controls.Add(Me.chk_Filter_Field)
        Me.Panel2.Controls.Add(Me.cmb_Filter_By)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Location = New System.Drawing.Point(64, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(528, 384)
        Me.Panel2.TabIndex = 374
        Me.Panel2.Visible = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(360, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(23, 24)
        Me.Button1.TabIndex = 383
        '
        'cmd_CategoryCodeHelp
        '
        Me.cmd_CategoryCodeHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_CategoryCodeHelp.Image = CType(resources.GetObject("cmd_CategoryCodeHelp.Image"), System.Drawing.Image)
        Me.cmd_CategoryCodeHelp.Location = New System.Drawing.Point(216, 344)
        Me.cmd_CategoryCodeHelp.Name = "cmd_CategoryCodeHelp"
        Me.cmd_CategoryCodeHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_CategoryCodeHelp.TabIndex = 382
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.Transparent
        Me.chk_PrintAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_PrintAll.Location = New System.Drawing.Point(56, 96)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(168, 16)
        Me.chk_PrintAll.TabIndex = 381
        Me.chk_PrintAll.Text = "Print All Categorys"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(104, 344)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 380
        Me.Label7.Text = "From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(272, 344)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 20)
        Me.Label8.TabIndex = 379
        Me.Label8.Text = "To"
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Location = New System.Drawing.Point(296, 344)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(64, 24)
        Me.tbx_filter_To.TabIndex = 377
        Me.tbx_filter_To.Text = ""
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Location = New System.Drawing.Point(152, 344)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(64, 24)
        Me.tbx_Filter_From.TabIndex = 376
        Me.tbx_Filter_From.Text = ""
        '
        'Cmb_add_filter
        '
        Me.Cmb_add_filter.Items.AddRange(New Object() {"Contact Address ", "Permanent Address", "Residence Address", "Business Address"})
        Me.Cmb_add_filter.Location = New System.Drawing.Point(286, 62)
        Me.Cmb_add_filter.Name = "Cmb_add_filter"
        Me.Cmb_add_filter.Size = New System.Drawing.Size(168, 26)
        Me.Cmb_add_filter.TabIndex = 373
        Me.Cmb_add_filter.Text = "[select your filter]"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.White
        Me.chk_Filter_Field.Location = New System.Drawing.Point(64, 120)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(392, 213)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 375
        '
        'cmb_Filter_By
        '
        Me.cmb_Filter_By.Items.AddRange(New Object() {"Member Category", "Member Status"})
        Me.cmb_Filter_By.Location = New System.Drawing.Point(54, 62)
        Me.cmb_Filter_By.Name = "cmb_Filter_By"
        Me.cmb_Filter_By.Size = New System.Drawing.Size(168, 26)
        Me.cmb_Filter_By.TabIndex = 372
        Me.cmb_Filter_By.Text = "[select your filter]"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(56, 40)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 20)
        Me.Label9.TabIndex = 368
        Me.Label9.Text = "CATEGORY  FILITER"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(296, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 16)
        Me.Label10.TabIndex = 371
        Me.Label10.Text = "ADDRESS  FILTER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 29)
        Me.Label2.TabIndex = 379
        Me.Label2.Text = "REMINDER   LETTER"
        '
        'Remindeletterr
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 17)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(936, 702)
        Me.Controls.Add(Me.GBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Remindeletterr"
        Me.Text = "Remindeletterr"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GBox1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub Remindeletterr_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Long
        posting = Nothing
        Try
            sqlString = "select ISNULL(POSTINGCODE,'') AS POSTINGTYPE FROM postingmast group by postingcode"
            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count > 0 Then
                ChkList_month.Items.Clear()
                For i = 0 To posting.Rows.Count - 1
                    cbo_BillingBasis.Items.Add(posting.Rows(i).Item("POSTINGTYPE"))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        gconnection.closeConnection()
        cbo_BillingBasis.SelectedIndex = 0
        cbo_BillingBasis.Focus()
    End Sub
    Private Sub btn_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Print.Click
        If ChkList_month.CheckedItems.Count = 0 Then
            MsgBox("Please Select Any Subscription Type", MsgBoxStyle.Critical)
            ChkList_month.Focus()
            Exit Sub
        End If
        GBox1.Visible = False
        Panel1.Visible = False
        GBox2.Visible = True
        GBox2.Top = 554
        Panel2.Visible = True
        Cmb_add_filter.SelectedIndex = 1
        cmb_Filter_By.SelectedIndex = 1
        Call chkmonth()
        cmb_Filter_By.Focus()
    End Sub
    Private Sub cbo_BillingBasis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call fillpostingtype()
    End Sub
    Private Sub fillpostingtype()
        ChkList_month.Items.Clear()
        Dim i As Long
        posting = Nothing
        Try
            sqlString = "select isnull(postingsno,0) as postingsno, isnull(POSTINGCODE,'') AS POSTINGTYPE,ISNULL(POSTINGDESC,'') as postingdesc,isnull(postingsno,0) as postingsno "
            sqlString = sqlString & " from postingmast where isnull(postingflag,'')<>'Y' and isnull(postingcode,'')='" & Me.cbo_BillingBasis.Text & "'"
            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count > 0 Then
                ChkList_month.Items.Clear()
                For i = 0 To posting.Rows.Count - 1
                    ChkList_month.Items.Add(posting.Rows(i).Item("POSTINGSNO") & "." & posting.Rows(i).Item("POSTINGDESC"))
                Next
            Else
                ChkList_month.Items.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_BillingBasis_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub ChkList_month_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            btn_Print.Focus()
        End If
    End Sub
    Private Sub ReportScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Long
        posting = Nothing
        Try
            sqlString = "select ISNULL(POSTINGCODE,'') AS POSTINGTYPE FROM postingmast group by postingcode"
            posting = gconnection.GetValues(sqlString)
            If posting.Rows.Count > 0 Then
                ChkList_month.Items.Clear()
                For i = 0 To posting.Rows.Count - 1
                    cbo_BillingBasis.Items.Add(posting.Rows(i).Item("POSTINGTYPE"))
                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        gconnection.closeConnection()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        cbo_BillingBasis.SelectedIndex = 0
        cbo_BillingBasis.Focus()
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
        Me.btn_disp.Enabled = False
        Me.btn_Print.Enabled = False
        Me.Button2.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.btn_disp.Enabled = True
                    Me.btn_Print.Enabled = True
                    Me.Button2.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.btn_disp.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.btn_Print.Enabled = True
                    Me.Button2.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Sub btn_close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
    Private Sub Btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_cancel.Click
        Me.Close()
    End Sub
    Private Sub cmb_Filter_By_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Filter_By.SelectedIndexChanged
        Dim MEMBERTYPE As New DataTable
        Dim Fill_Chk_str As String
        Cmb_add_filter.Enabled = True
        Try
            chk_Filter_Field.Items.Clear()
            If cmb_Filter_By.Text = "Member Category" Then
                selectNo = 0
                FltrStr = "MemberTypeCode in ('"
                Fill_Chk_str = "SELECT Membertype,TypeDesc FROM MEMBERTYPE"
                MEMBERTYPE = gconnection.GetValues(Fill_Chk_str)
                Dim Itration
                For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
                    chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
                Next
            ElseIf cmb_Filter_By.Text = "Member Status" Then
                selectNo = 1
                FltrStr = "CurentStatus in('"
                chk_Filter_Field.Items.Clear()
                chk_Filter_Field.Items.AddRange(Lst_status.Items())
            End If
        Catch ex As Exception
            MsgBox("An invalided input…Please close the report filter and reopen it.")
            Exit Sub
        End Try
    End Sub
    Private Sub chk_PrintAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PrintAll.CheckedChanged
        Dim Iteration As Integer
        If chk_PrintAll.Checked = True Then
            Try
                For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                    chk_Filter_Field.SetSelected(Iteration, True)
                    chk_Filter_Field.SetItemChecked(Iteration, True)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Try
                For Iteration = 0 To (chk_Filter_Field.Items.Count - 1)
                    chk_Filter_Field.SetItemChecked(Iteration, False)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub Cmb_add_filter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_add_filter.SelectedIndexChanged
        If Trim(Cmb_add_filter.SelectedItem) = "Contact Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(contadd1,'') as add1,isnull(contadd2,'') as add2,isnull(contadd3,'') as add3,"
            sqlStringFinal = sqlStringFinal & " isnull(contcity,'') as city,isnull(contstate,'') as state,isnull(contcountry,'') as country,isnull(contpin,'') as pincode,isnull(contphone1,'') as phone1, isnull(prefix,'') as prefix FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Permanent Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(padd1,'') as add1,isnull(padd2,'') as add2,isnull(padd3,'') as add3,isnull(pcity,'') as city,isnull(pstate,'') as state,isnull(pcountry,'') as country,isnull(contpin,'') as pincode,"
            sqlStringFinal = sqlStringFinal & " isnull(contphone1,'') as phone1,isnull(prefix,'') as prefix FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Residence Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(cadd1,'') as add1,isnull(cadd2,'') as add2,isnull(cadd3,'') as add3,isnull(ccity,'') as city,isnull(cstate,'') as state,isnull(ccountry,'') as country,isnull(cpin,'') as pincode,isnull(cphone1,'') as phone1,isnull(prefix,'') as prefix  FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Business Address" Then
            sqlStringFinal = "select isnull(mcode,'') as mcode,isnull(mname,'') as mname,isnull(oadd1,'') as add1,isnull(oadd2,'') as add2,isnull(oadd3,'') as add3,isnull(ocity,'') as city,isnull(ostate,'') as state,isnull(ocountry,'') as country,isnull(opin,'') as pincode,isnull(ophone1,'') as phone1,isnull(prefix,'') as prefix  FROM membermaster where "
        End If
    End Sub
    Public Function disp_Print()
        If chk_Filter_Field.CheckedItems.Count = 0 Then
            chk_Filter_Field.Focus()
            Exit Function
        End If
        Try
            Dim sqlstring, sqlstring1 As String
            Dim CHK As Boolean
            Dim NEWMCODE, PRESENTMCODE As String
            Dim Hedd1 As String
            Dim addFilterStr2 As String
            chkfilterfield()


            sqlstring = "SELECT * FROM dbo.SUBSCRIPTION_SUMMARY_VIEW B  WHERE (ISNULL(ARREAR,0) + ISNULL(PR_ARREAR,0))<>0 "
            FinalString = sqlstring & SetQuater & "and(" & addFltrStr & ")"
            If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                FinalString = FinalString & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
            End If
            ''letter = "FIRST REMINDER LETTER"
            ''ReminderLetterObj.begin()
            ''ReminderLetterObj.buttonclick(GlobalClass.sqlconnection, FinalString, letter)






            addFltrStr = addFltrStr & ")"
            sqlstring = " select isnull(a.mcode,'') as mcode,isnull(d.mname,'') as mname,"
            sqlstring = sqlstring & "isnull(a.membertype,'') as membertype,isnull(d.CurentStatus,'') as CurentStatus,isnull(b.typedesc,'') as typedesc,isnull(a.subscode,'') as subscode,"
            sqlstring = sqlstring & "isnull(c.subsdesc,'') as subsdesc,isnull(a.subsacctin,'') as acccode,isnull(a.taxcode,'') as taxcode, "
            sqlstring = sqlstring & "isnull(a.billingbasis,'') as billingbasis,isnull(a.amount,0) as amount,isnull(a.taxamount,0) as taxamount,isnull(a.period,'') as period "
            sqlstring = sqlstring & "from subsposting a,membertype b,subscriptionmast c,membermaster d "
            sqlstring = sqlstring & "where a.mcode=d.mcode and a.membertype=b.membertype and "
            sqlstring = sqlstring & "a.subscode=c.subscode and a.mcode=d.mcode and " & chk_month & " and " & addFltrStr
            sqlstring = sqlstring & " order by mcode,membertype,subscode"
            subsbill = gconnection.GetValues(sqlstring)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Try
            Randomize()
            vOutfile = Mid("subbill" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine()
            totalamt = 0 : totaltax = 0
            If subsbill.Rows.Count > 0 Then
                Dim row As Long
                For row = 0 To subsbill.Rows.Count - 1
                    If subsbill.Rows(row).Item("mcode") <> mmcode Then
                        Filewrite.WriteLine()
                        Filewrite.WriteLine()
                        Filewrite.WriteLine()
                        Filewrite.Write(Space(1) & Mid("From:", 1, 50) & Space(50 - Len(Mid("From:", 1, 50))))
                        Filewrite.WriteLine("Date :" & Mid(Format(Date.Now, "dd/MM/yyyy"), 1, 11))

                        Filewrite.Write(Space(1) & Mid("The Secretary", 1, 50) & Space(50 - Len(Mid("The Secretary", 1, 50))))
                        Filewrite.WriteLine("Member Code:" & Mid(subsbill.Rows(row).Item("mcode"), 1, 11))

                        Filewrite.Write(Space(1) & Mid("THE CALCUTTA SWIMMING CLUB", 1, 50) & Space(50 - Len(Mid("THE CALCUTTA SWIMMING CLUB", 1, 50))))
                        Filewrite.WriteLine("Category:" & Mid(subsbill.Rows(row).Item("typedesc"), 1, 11))

                        Filewrite.Write(Space(1) & Mid("1 Strand Road, Calcutta, 700 001.", 1, 50) & Space(50 - Len(Mid("1 Strand Road, Calcutta, 700 001.", 1, 50))))
                        Filewrite.WriteLine("Due Date:" & Mid(Format(Date.Now, "dd/MM/yyyy"), 1, 11))
                        Filewrite.WriteLine()
                        Filewrite.WriteLine()
                        Filewrite.WriteLine()
                        Filewrite.WriteLine(Space(30) & Chr(14) & Chr(15) & "SUBSCRIPTION BILL" & Chr(18))
                        'sqlStringFinal = sqlStringFinal & "mcode='" & subsbill.Rows(row).Item("mcode") & "'"
                        sqlstring = sqlStringFinal & "mcode='" & subsbill.Rows(row).Item("mcode") & "'"
                        madrs = gconnection.GetValues(sqlstring)
                        If madrs.Rows.Count > 0 Then
                            Filewrite.WriteLine(Space(1) & Trim(UCase(madrs.Rows(0).Item("Prefix") & ":" & Chr(27) & "E" & madrs.Rows(0).Item("mname") & Chr(27) & "F")))
                            Filewrite.WriteLine(Space(1) & Trim(UCase(madrs.Rows(0).Item("add1"))))
                            Filewrite.WriteLine(Space(1) & Trim(UCase(madrs.Rows(0).Item("add2")) & "," & Trim(madrs.Rows(0).Item("add3"))))
                            Filewrite.WriteLine(Space(1) & Trim(UCase(madrs.Rows(0).Item("city"))))
                            Filewrite.WriteLine(Space(1) & Trim(UCase(madrs.Rows(0).Item("state")) & "," & Trim(madrs.Rows(0).Item("country"))))
                            Filewrite.WriteLine(Space(1) & Trim(UCase(madrs.Rows(0).Item("country"))))
                            Filewrite.WriteLine(Space(1) & Trim(UCase("PinCode :" & madrs.Rows(0).Item("Pincode"))))
                            Filewrite.WriteLine(Space(1) & Trim(UCase("Contact No:" & madrs.Rows(0).Item("phone1"))))
                        End If
                        Filewrite.WriteLine("------------------------------------------------------------------------------------")
                        Filewrite.WriteLine(Space(1) & "Billing Period Form:" & subsbill.Rows(row).Item("period"))
                        Filewrite.WriteLine("------------------------------------------------------------------------------------")
                    End If
                    Filewrite.Write(Space(10) & Mid(subsbill.Rows(row).Item("subsdesc"), 1, 50) & Space(50 - Len(Mid(subsbill.Rows(row).Item("subsdesc"), 1, 50))))
                    Filewrite.WriteLine(Format(subsbill.Rows(row).Item("amount"), "0.00"))
                    totalamt = totalamt + Val(subsbill.Rows(row).Item("amount"))
                    totaltax = totaltax + Val(subsbill.Rows(row).Item("taxamount"))
                    If subsbill.Rows(row).Item("mcode") <> mmcode Then
                        Filewrite.WriteLine(Space(10) & "Bill Amount" & Space(50 - Len("Bill Amount")) & Format(Val(totalamt), "0.00"))
                        Filewrite.WriteLine(Space(10) & "Tax Amount" & Space(50 - Len("Tax Amount")) & Format(Val(totaltax), "0.00"))
                        Filewrite.WriteLine("------------------------------------------------------------------------------------")
                        Filewrite.WriteLine(Space(10) & "Total Amount" & Space(50 - Len("Total Amount")) & Format(Val(totalamt + totaltax), "0.00"))
                        Filewrite.WriteLine("------------------------------------------------------------------------------------")
                        Filewrite.WriteLine("All cheques must be drawn in favour of The Club")
                        Filewrite.WriteLine("A/C Payee only .Rs. 100/- is to be added to outstation cheques as Bank Commition.")
                        Filewrite.WriteLine("Bill No, Member No and Member name should be written on reverse side of the Cheque")
                        Filewrite.WriteLine(Chr(12))
                        totalamt = 0
                        totaltax = 0
                    End If
                    mmcode = subsbill.Rows(row).Item("mcode")
                Next row
            Else
                MsgBox("There is no Transaction,Pls Check", MsgBoxStyle.Information)
                Exit Function
            End If
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call disp_Print()
    End Sub
    Private Sub chkfilterfield()
        Dim i As Long
        Try
            For i = 0 To chk_Filter_Field.CheckedItems.Count - 1
                If i = 0 Then
                    TempString = Split((chk_Filter_Field.Text), ".")
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = TempString(1)
                    addFltrStr = FltrStr & Trim(TempString(selectNo)) & "'"
                Else
                    TempString = Split((chk_Filter_Field.CheckedItems.Item(i)), ".")
                    DispString = DispString & ", " & TempString(1)
                    addFltrStr = addFltrStr & " , '" & Trim(TempString(selectNo)) & "'"
                End If
            Next i
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub chkmonth()
        Dim i As Long
        Try
            For i = 0 To ChkList_month.CheckedItems.Count - 1
                If i = 0 Then
                    'TempString = Split((ChkList_month.Text), ".")
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    DispString = TempString(1)
                    chk_month = " a.billingbasis=" & "'" & cbo_BillingBasis.Text & "'"
                    chk_month = chk_month & " and a.postingsno in(" & Trim(TempString(0))
                Else
                    TempString = Split((ChkList_month.CheckedItems.Item(i)), ".")
                    DispString = DispString & ", " & TempString(1)
                    chk_month = chk_month & " , '" & Trim(TempString(0)) & "'"
                End If
            Next i
            chk_month = chk_month & ")"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub cbo_BillingBasis_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call fillpostingtype()
    End Sub
    Private Sub cbo_BillingBasis_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub ChkList_month_KeyPress1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Asc(e.KeyChar) = Keys.Enter Then
            btn_Print.Focus()
        End If
    End Sub
    Private Sub cmb_Filter_By_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_Filter_By.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Cmb_add_filter.Focus()
        End If
    End Sub
    Private Sub Cmb_add_filter_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_add_filter.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            chk_Filter_Field.Focus()
        End If
    End Sub
    Private Sub chk_Filter_Field_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Filter_Field.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            btn_disp.Focus()
        End If
    End Sub
    Private Sub cbo_BillingBasis_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbo_BillingBasis.SelectedIndexChanged
        Call fillpostingtype()
    End Sub
    Private Sub cbo_BillingBasis_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cbo_BillingBasis.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            ChkList_month.Focus()
        End If
    End Sub
    Private Sub ChkList_month_KeyPress2(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ChkList_month.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            btn_Print.Focus()
        End If
    End Sub
End Class
