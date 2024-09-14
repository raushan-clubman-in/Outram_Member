Imports System.Data
Imports System.Data.SqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class dependentListRegister
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Dim vconn As New GlobalClass
    Dim boolchk As Boolean
    Dim txtobj1 As TextObject
    Dim Iteration, I, J As Integer
    Dim sqlstring As String
    Dim dt As DataTable

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
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Cmd_Exit As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Clear As System.Windows.Forms.Button
    Friend WithEvents Cmb_FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    Friend WithEvents year As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_Tomname As System.Windows.Forms.TextBox
    Friend WithEvents txt_mname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Chk_SelectALLDep As System.Windows.Forms.CheckBox
    Friend WithEvents CHK_DEPENDET As System.Windows.Forms.CheckedListBox
    Friend WithEvents txt_dependent As System.Windows.Forms.TextBox
    Friend WithEvents Rnd_BELOVE As System.Windows.Forms.RadioButton
    Friend WithEvents RND_ABOVE As System.Windows.Forms.RadioButton
    Friend WithEvents RND_ALL As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(dependentListRegister))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmb_FromDate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.year = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_Tomname = New System.Windows.Forms.TextBox
        Me.txt_mname = New System.Windows.Forms.TextBox
        Me.Chk_SelectALLDep = New System.Windows.Forms.CheckBox
        Me.CHK_DEPENDET = New System.Windows.Forms.CheckedListBox
        Me.txt_dependent = New System.Windows.Forms.TextBox
        Me.Rnd_BELOVE = New System.Windows.Forms.RadioButton
        Me.RND_ABOVE = New System.Windows.Forms.RadioButton
        Me.RND_ALL = New System.Windows.Forms.RadioButton
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox4.Controls.Add(Me.Cmd_Print)
        Me.GroupBox4.Controls.Add(Me.Cmd_View)
        Me.GroupBox4.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox4.Location = New System.Drawing.Point(128, 472)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(552, 56)
        Me.GroupBox4.TabIndex = 445
        Me.GroupBox4.TabStop = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(384, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 7
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Print.BackgroundImage = CType(resources.GetObject("Cmd_Print.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(272, 16)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 6
        Me.Cmd_Print.Text = " Print [F8]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(160, 16)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 5
        Me.Cmd_View.Text = "View [F9]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.Transparent
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(48, 16)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 4
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmb_FromDate
        '
        Me.Cmb_FromDate.CustomFormat = "dd/MM/yyyy"
        Me.Cmb_FromDate.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cmb_FromDate.Location = New System.Drawing.Point(640, 104)
        Me.Cmb_FromDate.MaxDate = New Date(2031, 1, 1, 0, 0, 0, 0)
        Me.Cmb_FromDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Cmb_FromDate.Name = "Cmb_FromDate"
        Me.Cmb_FromDate.Size = New System.Drawing.Size(128, 21)
        Me.Cmb_FromDate.TabIndex = 446
        Me.Cmb_FromDate.Value = New Date(2011, 6, 19, 0, 0, 0, 0)
        Me.Cmb_FromDate.Visible = False
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.Color.Black
        Me.lbl_Heading.Location = New System.Drawing.Point(240, 16)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(348, 29)
        Me.lbl_Heading.TabIndex = 447
        Me.lbl_Heading.Text = "DEPENDENT LIST REGISTER"
        '
        'year
        '
        Me.year.BackColor = System.Drawing.Color.Transparent
        Me.year.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.year.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.year.Location = New System.Drawing.Point(640, 80)
        Me.year.Name = "year"
        Me.year.Size = New System.Drawing.Size(128, 16)
        Me.year.TabIndex = 394
        Me.year.Text = "DEP_DOBWISE"
        Me.year.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 17)
        Me.Label7.TabIndex = 632
        Me.Label7.Text = "From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(448, 392)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 18)
        Me.Label8.TabIndex = 631
        Me.Label8.Text = "To"
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_filter_To.Location = New System.Drawing.Point(480, 392)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(80, 21)
        Me.tbx_filter_To.TabIndex = 630
        Me.tbx_filter_To.Text = ""
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Filter_From.Location = New System.Drawing.Point(280, 392)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(80, 21)
        Me.tbx_Filter_From.TabIndex = 629
        Me.tbx_Filter_From.Text = ""
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(560, 392)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 634
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(240, 16)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 633
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmd_MCodefromHelp)
        Me.GroupBox1.Location = New System.Drawing.Point(128, 376)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 88)
        Me.GroupBox1.TabIndex = 635
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 16)
        Me.Label2.TabIndex = 637
        Me.Label2.Text = "Member Name"
        '
        'txt_Tomname
        '
        Me.txt_Tomname.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_Tomname.Location = New System.Drawing.Point(480, 432)
        Me.txt_Tomname.Name = "txt_Tomname"
        Me.txt_Tomname.Size = New System.Drawing.Size(168, 22)
        Me.txt_Tomname.TabIndex = 639
        Me.txt_Tomname.Text = ""
        '
        'txt_mname
        '
        Me.txt_mname.Font = New System.Drawing.Font("Courier New", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mname.Location = New System.Drawing.Point(280, 432)
        Me.txt_mname.Name = "txt_mname"
        Me.txt_mname.Size = New System.Drawing.Size(168, 22)
        Me.txt_mname.TabIndex = 638
        Me.txt_mname.Text = ""
        '
        'Chk_SelectALLDep
        '
        Me.Chk_SelectALLDep.BackColor = System.Drawing.Color.Transparent
        Me.Chk_SelectALLDep.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chk_SelectALLDep.Location = New System.Drawing.Point(312, 120)
        Me.Chk_SelectALLDep.Name = "Chk_SelectALLDep"
        Me.Chk_SelectALLDep.Size = New System.Drawing.Size(112, 24)
        Me.Chk_SelectALLDep.TabIndex = 643
        Me.Chk_SelectALLDep.Text = "SELECT ALL"
        '
        'CHK_DEPENDET
        '
        Me.CHK_DEPENDET.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_DEPENDET.Items.AddRange(New Object() {"Son", "Daughter", "Father", "Mother", "Others"})
        Me.CHK_DEPENDET.Location = New System.Drawing.Point(312, 144)
        Me.CHK_DEPENDET.Name = "CHK_DEPENDET"
        Me.CHK_DEPENDET.Size = New System.Drawing.Size(216, 174)
        Me.CHK_DEPENDET.TabIndex = 642
        '
        'txt_dependent
        '
        Me.txt_dependent.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dependent.Location = New System.Drawing.Point(312, 320)
        Me.txt_dependent.Name = "txt_dependent"
        Me.txt_dependent.Size = New System.Drawing.Size(176, 21)
        Me.txt_dependent.TabIndex = 663
        Me.txt_dependent.Text = ""
        Me.txt_dependent.Visible = False
        '
        'Rnd_BELOVE
        '
        Me.Rnd_BELOVE.BackColor = System.Drawing.Color.Transparent
        Me.Rnd_BELOVE.Checked = True
        Me.Rnd_BELOVE.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rnd_BELOVE.Location = New System.Drawing.Point(392, 352)
        Me.Rnd_BELOVE.Name = "Rnd_BELOVE"
        Me.Rnd_BELOVE.Size = New System.Drawing.Size(248, 24)
        Me.Rnd_BELOVE.TabIndex = 664
        Me.Rnd_BELOVE.TabStop = True
        Me.Rnd_BELOVE.Text = "QUALIFIED AGED DEPENDENT"
        '
        'RND_ABOVE
        '
        Me.RND_ABOVE.BackColor = System.Drawing.Color.Transparent
        Me.RND_ABOVE.Checked = True
        Me.RND_ABOVE.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RND_ABOVE.Location = New System.Drawing.Point(136, 352)
        Me.RND_ABOVE.Name = "RND_ABOVE"
        Me.RND_ABOVE.Size = New System.Drawing.Size(240, 24)
        Me.RND_ABOVE.TabIndex = 665
        Me.RND_ABOVE.TabStop = True
        Me.RND_ABOVE.Text = "OVEER AGED  DEPENDENT"
        '
        'RND_ALL
        '
        Me.RND_ALL.BackColor = System.Drawing.Color.Transparent
        Me.RND_ALL.Checked = True
        Me.RND_ALL.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RND_ALL.Location = New System.Drawing.Point(648, 352)
        Me.RND_ALL.Name = "RND_ALL"
        Me.RND_ALL.Size = New System.Drawing.Size(64, 24)
        Me.RND_ALL.TabIndex = 666
        Me.RND_ALL.TabStop = True
        Me.RND_ALL.Text = "ALL"
        '
        'dependentListRegister
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(768, 590)
        Me.Controls.Add(Me.RND_ALL)
        Me.Controls.Add(Me.RND_ABOVE)
        Me.Controls.Add(Me.Rnd_BELOVE)
        Me.Controls.Add(Me.txt_dependent)
        Me.Controls.Add(Me.txt_Tomname)
        Me.Controls.Add(Me.txt_mname)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbx_filter_To)
        Me.Controls.Add(Me.tbx_Filter_From)
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.Chk_SelectALLDep)
        Me.Controls.Add(Me.cmd_MCodeToHelp)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CHK_DEPENDET)
        Me.Controls.Add(Me.year)
        Me.Controls.Add(Me.Cmb_FromDate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "dependentListRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dependent List Register"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        gPrint = False
        If RND_ABOVE.Checked = True Then
            Call Print_Dependent_above()
        ElseIf Rnd_BELOVE.Checked = True Then
            Call Print_Dependent_below()
        Else
            Call ViewDeptRegister1()
        End If
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        gPrint = True
        Call ViewDeptRegister1()
    End Sub

    Private Sub ViewDeptRegister()
        Dim i As Integer
        Dim appcode As String
        Try
            Dim sqlstring As String
            appcode = DatePart(DateInterval.Year, Cmb_FromDate.Value, FirstDayOfWeek.Sunday)
            sqlstring = sqlstring & " SELECT MEM_CODE,CHILD_NM,RELATION,ISNULL(CHILD_DOB,'') AS CHILD_DOB FROM MEMDET WHERE  relation <> 'SPOUSE' "
            If year.Checked = True Then
                sqlstring = sqlstring & " AND DATEPART(YYYY, CHILD_DOB) = '" & appcode & "' and type0 = 'chld' "
            Else
                sqlstring = sqlstring & "  and type0 = 'chld' "
            End If
            sqlstring = sqlstring & " order by mem_code"
            Dim pageheading() As String = {"DEPENDENT LIST FOR THE YEAR OF "}
            Dim ObjDatewisesaleregisterdetails As New dRegister
            ObjDatewisesaleregisterdetails.ReportsDetails(sqlstring, pageheading, Cmb_FromDate.Value, Cmb_FromDate.Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
    End Sub

    Private Sub ViewDeptRegister1()
        Try
            Dim sqlstring As String
            sqlstring = "SELECT * FROM VW_DEPENDENCY_DETAILS"
            Dim o As Object
            txt_dependent.Text = ""
            For Each o In CHK_DEPENDET.CheckedItems
                txt_dependent.Text += "'" & o.ToString() & "',"
            Next o
            If (txt_dependent.Text <> "") Then
                sqlstring = sqlstring & " where RELATION in (" & txt_dependent.Text.Substring(0, txt_dependent.Text.Length - 1) & ")"
            End If
            If year.Checked = True Then
                sqlstring = sqlstring & " and CHILD_DOB = Convert(datetime,'" & Cmb_FromDate.Text & "',103) "
            End If

            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                sqlstring = sqlstring & " and MEM_CODE between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If
            sqlstring = sqlstring & " ORDER BY MEM_CODE ASC"
            Dim Viewer As New ReportViwer
            Dim r As New Cry_DependentList
            Viewer.ssql = sqlstring
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text11")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gCompanyAddress(3))
            Viewer.Report = r
            Viewer.TableName = "VW_DEPENDENCY_DETAILS"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Print_Dependent_above()
        Try
            Dim sqlstring As String
            sqlstring = "SELECT * FROM MM_Dependent_above"
            Dim o As Object
            txt_dependent.Text = ""
            For Each o In CHK_DEPENDET.CheckedItems
                txt_dependent.Text += "'" & o.ToString() & "',"
            Next o
            If (txt_dependent.Text <> "") Then
                sqlstring = sqlstring & " where RELATION in (" & txt_dependent.Text.Substring(0, txt_dependent.Text.Length - 1) & ")"
            End If

            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                sqlstring = sqlstring & " and MEM_CODE between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If
            sqlstring = sqlstring & " ORDER BY MEM_CODE ASC"
            Dim Viewer As New ReportViwer
            Dim r As New Cry_Dependency_Above
            Viewer.ssql = sqlstring
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text11")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gCompanyAddress(3))
            Viewer.Report = r
            Viewer.TableName = "MM_Dependent_above"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub Print_Dependent_below()
        Try
            Dim sqlstring As String
            sqlstring = "SELECT * FROM MM_Dependent_below"
            Dim o As Object
            txt_dependent.Text = ""
            For Each o In CHK_DEPENDET.CheckedItems
                txt_dependent.Text += "'" & o.ToString() & "',"
            Next o
            If (txt_dependent.Text <> "") Then
                sqlstring = sqlstring & " where RELATION in (" & txt_dependent.Text.Substring(0, txt_dependent.Text.Length - 1) & ")"
            End If
            If year.Checked = True Then
                sqlstring = sqlstring & " and CHILD_DOB = Convert(datetime,'" & Cmb_FromDate.Text & "',103) "
            End If

            If (tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "") Then
                sqlstring = sqlstring & " and MEM_CODE between '" & tbx_Filter_From.Text & "' and '" & tbx_filter_To.Text & "'"
            End If
            sqlstring = sqlstring & " ORDER BY MEM_CODE ASC"
            Dim Viewer As New ReportViwer
            Dim r As New Cry_Dependency_below
            Viewer.ssql = sqlstring
            txtobj1 = r.ReportDefinition.ReportObjects("Text9")
            txtobj1.Text = UCase(gCompanyname)
            txtobj1 = r.ReportDefinition.ReportObjects("Text10")
            txtobj1.Text = UCase(gCompanyAddress(1))
            txtobj1 = r.ReportDefinition.ReportObjects("Text11")
            txtobj1.Text = UCase(gCompanyAddress(2))
            txtobj1 = r.ReportDefinition.ReportObjects("Text13")
            txtobj1.Text = UCase(gCompanyAddress(3))
            Viewer.Report = r
            Viewer.TableName = "MM_Dependent_below"
            Viewer.Show()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Private Sub D2_Register_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim i As Integer
        If e.KeyCode = Keys.F6 Then
            Call Cmd_Clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F8 Then
            Call Cmd_Print_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F9 Then
            Call Cmd_View_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F11 Then
            Call Cmd_Exit_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.Escape Then
            Call Cmd_Exit_Click(sender, e)
            Exit Sub
        ElseIf e.Alt = True And e.KeyCode = Keys.T Then
            'Me.Year1.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub Cmb_FromDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Cmb_FromDate.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Me.Cmd_View.Focus()
        End If
    End Sub

    Private Sub Cmd_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Clear.Click
        Me.Cmb_FromDate.Text = Now.Today
        ' If e.Keys = Keys.Enter Then
        tbx_Filter_From.Text = ""
        tbx_filter_To.Text = ""
        'End If
    End Sub

    Private Sub dependentListRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load_dependent()
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Show()
        Me.Cmb_FromDate.Focus()
        Rnd_BELOVE.Checked = False
        RND_ALL.Checked = False
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
        Me.Cmd_Print.Enabled = False
        Me.Cmd_View.Enabled = False
        'A-All,S-Save,M-Modify,C-Cancel,D-Delete,V-View,P-Print
        If Len(chstr) > 0 Then
            Dim Right() As Char
            Right = chstr.ToCharArray
            For x = 0 To Right.Length - 1
                If Right(x) = "A" Then
                    Me.Cmd_View.Enabled = True
                    Me.Cmd_Print.Enabled = True
                    Exit Sub
                End If
                If Right(x) = "V" Then
                    Me.Cmd_View.Enabled = True
                End If
                If Right(x) = "P" Then
                    Me.Cmd_Print.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cmd_MCodefromHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodefromHelp.Click
        Try
            Dim vform As New ListOperation
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
            M_WhereCondition = " "
            vform.Field = "MCODE,MNAME"
            vform.vFormatstring = "  Member Code  | Member Name                           "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                tbx_Filter_From.Text = Trim(vform.keyfield & "")
                Call tbx_Filter_From_Validated(sender, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub cmd_MCodeToHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodeToHelp.Click
        Try
            Dim vform As New ListOperation
            gSQLString = "SELECT ISNULL(MCODE,'') AS MCODE,ISNULL(MNAME,'') AS MNAME FROM membermaster"
            M_WhereCondition = " "
            vform.Field = "MCODE,MNAME"
            vform.vFormatstring = "  Member Code  | Member Name                           "
            vform.vCaption = "Member Master Help"
            vform.KeyPos = 0
            vform.KeyPos1 = 1
            vform.ShowDialog(Me)
            If Trim(vform.keyfield & "") <> "" Then
                tbx_filter_To.Text = Trim(vform.keyfield & "")
                Call tbx_filter_To_Validated(sender, e)
            End If
            vform.Close()
            vform = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, gCompanyname)
        End Try
    End Sub

    Private Sub tbx_Filter_From_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Filter_From.TextChanged

    End Sub

    Private Sub tbx_Filter_From_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_Filter_From.KeyDown
        If tbx_Filter_From.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                cmd_MCodefromHelp_Click(sender, e)
            End If
        End If
        'tbx_filter_To.Focus()

    End Sub

    Private Sub tbx_filter_To_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_filter_To.TextChanged

    End Sub

    Private Sub tbx_filter_To_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_filter_To.KeyDown
        If tbx_filter_To.Text = "" Then
            If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.F4 Then
                cmd_MCodeToHelp_Click(sender, e)
            End If
        End If
    End Sub

    Private Sub year_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles year.CheckedChanged

    End Sub

    Private Sub tbx_Filter_From_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_Filter_From.Validated
        Try
            If Trim(tbx_Filter_From.Text) <> "" Then
                gSQLString = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(tbx_Filter_From.Text) & "'"
                gconnection.getDataSet(gSQLString, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    tbx_Filter_From.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    txt_mname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
                    Cmd_View.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tbx_Filter_From_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Filter_From.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(tbx_Filter_From.Text) = "" Then
                Call cmd_MCodefromHelp_Click(sender, e)
            Else
                tbx_Filter_From_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub tbx_filter_To_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbx_filter_To.Validated
        Try
            If Trim(tbx_filter_To.Text) <> "" Then
                gSQLString = "SELECT MCODE,MNAME FROM MEMBERMASTER WHERE MCODE='" & Trim(tbx_filter_To.Text) & "'"
                gconnection.getDataSet(gSQLString, "MEMBER")
                If gdataset.Tables("MEMBER").Rows.Count > 0 Then
                    tbx_filter_To.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MCODE"))
                    txt_Tomname.Text = Trim(gdataset.Tables("MEMBER").Rows(0).Item("MNAME"))
                    Cmd_View.Focus()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub tbx_filter_To_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_filter_To.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If Trim(tbx_Filter_From.Text) = "" Then
                Call cmd_MCodeToHelp_Click(sender, e)
            Else
                tbx_filter_To_Validated(sender, e)
            End If
        End If
    End Sub

    Private Sub Chk_SelectALLDep_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_SelectALLDep.CheckedChanged
        Try
            If Chk_SelectALLDep.Checked = True Then
                For Iteration = 0 To (CHK_DEPENDET.Items.Count - 1)
                    CHK_DEPENDET.SetSelected(Iteration, True)
                    CHK_DEPENDET.SetItemChecked(Iteration, True)
                Next
            Else
                For Iteration = 0 To (CHK_DEPENDET.Items.Count - 1)
                    CHK_DEPENDET.SetItemChecked(Iteration, False)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Load_dependent()
        Dim i, Iteration As Integer
        sqlstring = "select distinct isnull(RELATION,'')as RELATION from MEMDET where isnull(RELATION,'')<>'' "
        dt = gconnection.GetValues(sqlstring)
        For Iteration = 0 To (dt.Rows.Count - 1)
            CHK_DEPENDET.Items.Add(dt.Rows(Iteration).Item("RELATION"))
        Next

    End Sub
    Public Sub GETMEMBERLIST()
        'Try
        '    Dim DT As New DataTable
        '    CHKLIST_SELECT.Items.Clear()
        '    sqlstring = " Select isnull(Mcode,'') as Mcode,isnull(Mname,'') as Mname From MemberMaster order by mcode,mname asc"
        '    DT = gconnection.GetValues(sqlstring)
        '    If DT.Rows.Count > 0 Then
        '        For Iteration = 0 To (DT.Rows.Count - 1)
        '            CHKLIST_SELECT.Items.Add(DT.Rows(Iteration).Item("Mname"))
        '            'CHKLIST_SELECT.Items.Add(DT.Rows(Iteration).Item("Mcode") & "." & DT.Rows(Iteration).Item("Mname"))
        '        Next
        '    Else
        '        CHKLIST_SELECT.Items.Clear()
        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message)
        'End Try
    End Sub

    Private Sub RND_ABOVE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RND_ABOVE.CheckedChanged

    End Sub

    Private Sub RND_ABOVE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RND_ABOVE.Click
        Rnd_BELOVE.Checked = False
        RND_ALL.Checked = False
    End Sub

    Private Sub CHK_DEPENDET_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHK_DEPENDET.SelectedIndexChanged

    End Sub

    Private Sub Rnd_BELOVE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rnd_BELOVE.CheckedChanged

    End Sub

    Private Sub Rnd_BELOVE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Rnd_BELOVE.Click
        RND_ABOVE.Checked = False
        RND_ALL.Checked = False
    End Sub

    Private Sub RND_ALL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RND_ALL.CheckedChanged

    End Sub

    Private Sub RND_ALL_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RND_ALL.Click
        Rnd_BELOVE.Checked = False
        RND_ABOVE.Checked = False
    End Sub
End Class