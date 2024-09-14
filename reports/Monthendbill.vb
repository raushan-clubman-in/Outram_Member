
Imports System.Data.SqlClient
Public Class Monthendbill
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
    Friend WithEvents grp_monthbill As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Rnd_Summary As System.Windows.Forms.RadioButton
    Friend WithEvents Rnd_Details As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CbxMonth As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxmonth1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Wait As System.Windows.Forms.Label
    Friend WithEvents Lbl_category As System.Windows.Forms.Label
    Friend WithEvents CBO_CATEGORY As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Monthendbill))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Rnd_Summary = New System.Windows.Forms.RadioButton
        Me.Rnd_Details = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.CbxMonth = New System.Windows.Forms.DateTimePicker
        Me.cbxmonth1 = New System.Windows.Forms.DateTimePicker
        Me.Lbl_category = New System.Windows.Forms.Label
        Me.CBO_CATEGORY = New System.Windows.Forms.ComboBox
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(368, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 35)
        Me.Label1.TabIndex = 427
        Me.Label1.Text = "MONTH END BILL"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(272, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 24)
        Me.Label2.TabIndex = 428
        Me.Label2.Text = "LIST FROM"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Rnd_Summary)
        Me.GroupBox4.Controls.Add(Me.Rnd_Details)
        Me.GroupBox4.Location = New System.Drawing.Point(296, 280)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(328, 48)
        Me.GroupBox4.TabIndex = 603
        Me.GroupBox4.TabStop = False
        '
        'Rnd_Summary
        '
        Me.Rnd_Summary.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_Summary.Checked = True
        Me.Rnd_Summary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Summary.Location = New System.Drawing.Point(48, 16)
        Me.Rnd_Summary.Name = "Rnd_Summary"
        Me.Rnd_Summary.TabIndex = 595
        Me.Rnd_Summary.TabStop = True
        Me.Rnd_Summary.Text = "Summary"
        '
        'Rnd_Details
        '
        Me.Rnd_Details.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_Details.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_Details.Location = New System.Drawing.Point(184, 16)
        Me.Rnd_Details.Name = "Rnd_Details"
        Me.Rnd_Details.Size = New System.Drawing.Size(80, 24)
        Me.Rnd_Details.TabIndex = 594
        Me.Rnd_Details.Text = "Details"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(96, 392)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 56)
        Me.GroupBox2.TabIndex = 604
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
        Me.CmdClear.Location = New System.Drawing.Point(56, 16)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(104, 32)
        Me.CmdClear.TabIndex = 7
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
        Me.cmdexit.Location = New System.Drawing.Point(600, 16)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(104, 32)
        Me.cmdexit.TabIndex = 8
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
        Me.cmdPrint.Location = New System.Drawing.Point(432, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 6
        Me.cmdPrint.Text = "Print[F9]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdView.BackgroundImage = CType(resources.GetObject("CmdView.BackgroundImage"), System.Drawing.Image)
        Me.CmdView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Location = New System.Drawing.Point(240, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 5
        Me.CmdView.Text = "View[F8]"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(520, 176)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 605
        Me.Label3.Text = "TO"
        '
        'CbxMonth
        '
        Me.CbxMonth.CalendarMonthBackground = System.Drawing.Color.White
        Me.CbxMonth.CustomFormat = "MMMMM"
        Me.CbxMonth.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxMonth.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.CbxMonth.Location = New System.Drawing.Point(392, 176)
        Me.CbxMonth.Name = "CbxMonth"
        Me.CbxMonth.Size = New System.Drawing.Size(112, 26)
        Me.CbxMonth.TabIndex = 606
        '
        'cbxmonth1
        '
        Me.cbxmonth1.CalendarMonthBackground = System.Drawing.Color.White
        Me.cbxmonth1.CustomFormat = "MMMMM"
        Me.cbxmonth1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxmonth1.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.cbxmonth1.Location = New System.Drawing.Point(592, 176)
        Me.cbxmonth1.Name = "cbxmonth1"
        Me.cbxmonth1.Size = New System.Drawing.Size(112, 26)
        Me.cbxmonth1.TabIndex = 607
        '
        'Lbl_category
        '
        Me.Lbl_category.AutoSize = True
        Me.Lbl_category.Font = New System.Drawing.Font("Courier New", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_category.ForeColor = System.Drawing.Color.Black
        Me.Lbl_category.Location = New System.Drawing.Point(272, 232)
        Me.Lbl_category.Name = "Lbl_category"
        Me.Lbl_category.Size = New System.Drawing.Size(124, 25)
        Me.Lbl_category.TabIndex = 608
        Me.Lbl_category.Text = "CATEGORY :"
        '
        'CBO_CATEGORY
        '
        Me.CBO_CATEGORY.BackColor = System.Drawing.Color.Wheat
        Me.CBO_CATEGORY.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBO_CATEGORY.Items.AddRange(New Object() {"BAR", "CANTEEN", "FACILITY"})
        Me.CBO_CATEGORY.Location = New System.Drawing.Point(400, 232)
        Me.CBO_CATEGORY.Name = "CBO_CATEGORY"
        Me.CBO_CATEGORY.Size = New System.Drawing.Size(128, 27)
        Me.CBO_CATEGORY.TabIndex = 609
        '
        'Monthendbill
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(920, 542)
        Me.Controls.Add(Me.CBO_CATEGORY)
        Me.Controls.Add(Me.Lbl_category)
        Me.Controls.Add(Me.cbxmonth1)
        Me.Controls.Add(Me.CbxMonth)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Monthendbill"
        Me.Text = "Monthendbill"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim sqlstring As String
    Dim chkbool As Boolean
    Dim vconn As New GlobalClass
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        Dim vSql, vSql1 As Object
        Checkdaterangevalidate(CbxMonth.Value, cbxmonth1.Value)
        If chkdatevalidate = False Then Exit Sub
       
        Try

       
        Dim Viewer As New ReportViwer
            Dim r1 As New RPT_monthbilldetail
            Dim r2 As New RPt_monthbillsummary
        If Rnd_Details.Checked = True Then
                vSql1 = "Select remarks,MCODE,AMOUNT from monthenddetail"
            vSql1 = vSql1 & " WHERE CAST(convert(varchar(11),Billdate,6) as DATETIME) BETWEEN   "
            vSql1 = vSql1 & "'" & Format(CbxMonth.Value, "dd-MMM-yyyy") & "'  AND ' " & Format(cbxmonth1.Value, "dd-MMM-yyyy") & "'"
            vSql1 = vSql1 & " ORDER by MCODE"

            Viewer.ssql = vSql1
            Viewer.Report = r1
                Viewer.TableName = "monthenddetail"

                Dim duedate2 As CrystalDecisions.CrystalReports.Engine.TextObject
                duedate2 = r1.ReportDefinition.ReportObjects("Text10")
                duedate2.Text = Format(CbxMonth.Value, "dd/MM/yyyy")
                Dim duedate1 As CrystalDecisions.CrystalReports.Engine.TextObject
                duedate1 = r1.ReportDefinition.ReportObjects("Text12")
                duedate1.Text = Format(cbxmonth1.Value, "dd/MM/yyyy")
                Viewer.Show()
            Else

                vSql1 = "Select MCODE,sum(AMOUNT),count(*),CATEGORY from monthenddetail"
                vSql1 = vSql1 & " WHERE CAST(convert(varchar(11),Billdate,6) as DATETIME) BETWEEN   "
                vSql1 = vSql1 & "'" & Format(CbxMonth.Value, "dd-MMM-yyyy") & "'  AND ' " & Format(cbxmonth1.Value, "dd-MMM-yyyy") & "' AND CATEGORY=  '" & CBO_CATEGORY.Text & "'"
                vSql1 = vSql1 & " Group by mcode order by Mcode"
                Viewer.ssql = vSql1
                Viewer.Report = r2
                Viewer.TableName = "monthenddetail"


                Dim duedate2 As CrystalDecisions.CrystalReports.Engine.TextObject
                duedate2 = r1.ReportDefinition.ReportObjects("Text10")
                duedate2.Text = Format(CbxMonth.Value, "dd/MM/yyyy")
                Dim duedate1 As CrystalDecisions.CrystalReports.Engine.TextObject
                duedate1 = r1.ReportDefinition.ReportObjects("Text12")
                duedate1.Text = Format(cbxmonth1.Value, "dd/MM/yyyy")
                Viewer.Show()

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Exit Sub

    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.ProgressBar1.Value > 0 And Me.ProgressBar1.Value < 100 Then
            Me.ProgressBar1.Value += 1
            Me.lbl_Wait.Text = Me.ProgressBar1.Value & "%"
        Else
            Me.Timer1.Enabled = False
            Me.ProgressBar1.Value = 0

            Call viewmonthlybill()

        End If
    End Sub
    Private Sub viewmonthlybill()

    End Sub

    Private Sub Monthendbill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CbxMonth.Value = Now.Today
        cbxmonth1.Value = Now.Today
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
        SQLSTRING = "SELECT * FROM useradmin WHERE USERNAME = '" & Trim(gUsername) & "' AND MAINGROUP='POS' AND MODULENAME LIKE '" & Trim(GmoduleName) & "%'"
        vconn.getDataSet(SQLSTRING, "USER")
        If gdataset.Tables("USER").Rows.Count - 1 >= 0 Then
            For i = 0 To gdataset.Tables("USER").Rows.Count - 1
                With gdataset.Tables("USER").Rows(i)
                    chstr = abcdMINUS(.Item("RIGHTS"))
                End With
            Next
        End If
        Me.CmdView.Enabled = False
        Me.cmdPrint.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.CmdView.Enabled = True
                    Me.cmdPrint.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.CmdView.Enabled = True
                    Me.cmdPrint.Enabled = True
                End If
            Next
        End If
    End Sub
End Class
