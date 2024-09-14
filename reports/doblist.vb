Imports System.Data
Imports System.Data.SqlClient
Imports System.io
Public Class doblist
    Inherits System.Windows.Forms.Form
    Dim gconnection As New GlobalClass
    Public pageno, pagesize As Integer
    Dim vconn As New GlobalClass
    Dim boolchk As Boolean
    Dim dr As DataRow

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
    Friend WithEvents Lbl_Year As System.Windows.Forms.Label
    Friend WithEvents Cmb_FromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Heading As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(doblist))
        Me.Lbl_Year = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Cmd_Exit = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Clear = New System.Windows.Forms.Button
        Me.Cmb_FromDate = New System.Windows.Forms.DateTimePicker
        Me.lbl_Heading = New System.Windows.Forms.Label
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_Year
        '
        Me.Lbl_Year.BackColor = System.Drawing.Color.Transparent
        Me.Lbl_Year.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Year.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Lbl_Year.Location = New System.Drawing.Point(104, 91)
        Me.Lbl_Year.Name = "Lbl_Year"
        Me.Lbl_Year.Size = New System.Drawing.Size(192, 24)
        Me.Lbl_Year.TabIndex = 1
        Me.Lbl_Year.Text = "D.O.B.  MONTH : "
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Cmd_Exit)
        Me.GroupBox4.Controls.Add(Me.Cmd_Print)
        Me.GroupBox4.Controls.Add(Me.Cmd_View)
        Me.GroupBox4.Controls.Add(Me.Cmd_Clear)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 144)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(552, 56)
        Me.GroupBox4.TabIndex = 445
        Me.GroupBox4.TabStop = False
        '
        'Cmd_Exit
        '
        Me.Cmd_Exit.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Exit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Exit.ForeColor = System.Drawing.Color.White
        Me.Cmd_Exit.Image = CType(resources.GetObject("Cmd_Exit.Image"), System.Drawing.Image)
        Me.Cmd_Exit.Location = New System.Drawing.Point(424, 16)
        Me.Cmd_Exit.Name = "Cmd_Exit"
        Me.Cmd_Exit.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Exit.TabIndex = 7
        Me.Cmd_Exit.Text = "Exit[F11]"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Print.BackgroundImage = CType(resources.GetObject("Cmd_Print.BackgroundImage"), System.Drawing.Image)
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Print.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(288, 16)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Print.TabIndex = 6
        Me.Cmd_Print.Text = " Print [F8]"
        '
        'Cmd_View
        '
        Me.Cmd_View.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_View.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(152, 16)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_View.TabIndex = 5
        Me.Cmd_View.Text = "View [F9]"
        '
        'Cmd_Clear
        '
        Me.Cmd_Clear.BackColor = System.Drawing.Color.ForestGreen
        Me.Cmd_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Cmd_Clear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Clear.ForeColor = System.Drawing.Color.White
        Me.Cmd_Clear.Image = CType(resources.GetObject("Cmd_Clear.Image"), System.Drawing.Image)
        Me.Cmd_Clear.Location = New System.Drawing.Point(16, 16)
        Me.Cmd_Clear.Name = "Cmd_Clear"
        Me.Cmd_Clear.Size = New System.Drawing.Size(104, 32)
        Me.Cmd_Clear.TabIndex = 4
        Me.Cmd_Clear.Text = "Clear[F6]"
        '
        'Cmb_FromDate
        '
        Me.Cmb_FromDate.CustomFormat = "MMM"
        Me.Cmb_FromDate.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmb_FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Cmb_FromDate.Location = New System.Drawing.Point(312, 87)
        Me.Cmb_FromDate.MaxDate = New Date(2031, 1, 1, 0, 0, 0, 0)
        Me.Cmb_FromDate.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Cmb_FromDate.Name = "Cmb_FromDate"
        Me.Cmb_FromDate.Size = New System.Drawing.Size(120, 37)
        Me.Cmb_FromDate.TabIndex = 446
        Me.Cmb_FromDate.Value = New Date(2009, 6, 19, 0, 0, 0, 0)
        '
        'lbl_Heading
        '
        Me.lbl_Heading.AutoSize = True
        Me.lbl_Heading.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Heading.Font = New System.Drawing.Font("Times New Roman", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Heading.ForeColor = System.Drawing.Color.LavenderBlush
        Me.lbl_Heading.Location = New System.Drawing.Point(160, 24)
        Me.lbl_Heading.Name = "lbl_Heading"
        Me.lbl_Heading.Size = New System.Drawing.Size(259, 31)
        Me.lbl_Heading.TabIndex = 447
        Me.lbl_Heading.Text = "DOB LIST REGISTER"
        '
        'doblist
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(576, 222)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_Heading)
        Me.Controls.Add(Me.Cmb_FromDate)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Lbl_Year)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "doblist"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dependent List Register"
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        gPrint = False
        Call ViewDeptRegister()
    End Sub

    Private Sub Cmd_Exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Exit.Click
        Me.Close()
    End Sub

    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        gPrint = True
        Call ViewDeptRegister()
    End Sub

    Private Sub ViewDeptRegister()
        Dim i As Integer
        Dim appcode As String
        Try
            Dim sqlstring As String
            appcode = Month(Cmb_FromDate.Value)
            sqlstring = "SELECT DOB,MCODE,MNAME FROM MEMBERMASTER WHERE MONTH(DOB) = " & appcode & " ORDER BY DAY(DOB)"
            Dim pageheading() As String = {"DOB LIST FOR THE MONTH OF "}
            Call ReportsDetails(sqlstring, pageheading, Cmb_FromDate.Value, Cmb_FromDate.Value)
        Catch ex As Exception
            MessageBox.Show(ex.Message & ex.Source, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
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
    End Sub

    Private Sub doblist_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Show()
        Me.Cmb_FromDate.Focus()
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
    Public Function ReportsDetails(ByVal SQLSTRING As String, ByVal PAGEHEADER() As String, ByVal FROMDATE As Date, ByVal TODATE As Date)
        Dim I, J, C, MEMBERS As Integer
        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("DEP" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            Dim sqlstr
            pageno = 1
            Filewrite.Write(Chr(15))
            Call PrintHeader(PAGEHEADER, FROMDATE, TODATE)
            gconnection.getDataSet(SQLSTRING, "MR_VW_ADMISSION")
            pagesize = 0
            If gdataset.Tables("MR_VW_ADMISSION").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                For Each dr In gdataset.Tables("MR_VW_ADMISSION").Rows
                    If pagesize > 56 Then
                        Filewrite.Write(StrDup(90, "="))
                        Filewrite.Write(Chr(12))
                        pageno = pageno + 1
                        Call PrintHeader(PAGEHEADER, FROMDATE, TODATE)
                    End If
                    C = C + 1
                    Dim opstr As String
                    opstr = "|" & Mid(Trim(CStr(dr("DOB"))), 1, 12) & Space(12 - Len(Mid(Trim(CStr(dr("DOB"))), 1, 12))) & "" & "|"
                    opstr = opstr & Mid(Trim(CStr(dr("MCODE"))), 1, 12) & Space(12 - Len(Mid(Trim(CStr(dr("MCODE"))), 1, 12))) & "" & "|"
                    opstr = opstr & Mid(Trim(CStr(dr("MNAME"))), 1, 25) & Space(25 - Len(Mid(Trim(CStr(dr("MNAME"))), 1, 25))) & "" & "|"
                    'opstr = opstr & Mid(Trim(CStr(dr("CHILD_DOB"))), 1, 17) & Space(17 - Len(Mid(Trim(CStr(dr("CHILD_DOB"))), 1, 17))) & "" & "|"
                    'opstr = opstr & Mid(Trim(CStr(dr("AGE"))), 1, 5) & Space(5 - Len(Mid(Trim(CStr(dr("AGE"))), 1, 5))) & "" & "|"
                    Filewrite.WriteLine(opstr)
                    opstr = ""
                    pagesize = pagesize + 1
                Next dr
                Filewrite.WriteLine(StrDup(90, "="))
                pagesize = pagesize + 5
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Function PrintHeader(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
        Dim I As Integer
        pagesize = 0
        '''*********************************************** PRINT REPORTS HEADING  *********************************'''
        Try
            Filewrite.Write(Chr(18))
            Filewrite.WriteLine("{0,48}{1,20}{2,15}", "", "PRINTED ON :", Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine(Chr(27) & "E" & MyCompanyName & Chr(27) & "F")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-5}{1,-11}{2,-25}{3,-20}{4,-19}", Mid(Address1, 1, 30) & Space(5), " ", Mid(Trim(HEADING(0)), 1, 32), Space(1) & Cmb_FromDate.Text, " " & " " & " " & " ")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-5}{1,-11}{2,-25}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 25))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,75}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(90, "="))
            pagesize = pagesize + 1
            Filewrite.WriteLine("|DOB    	 |MCODE       |MNAME                    |")
            Filewrite.WriteLine(StrDup(90, "="))
            pagesize = pagesize + 4
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class