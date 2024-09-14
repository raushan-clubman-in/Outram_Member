Public Class ReportFilter
    Inherits System.Windows.Forms.Form
    Dim gconnection As New globalClass
    Dim globalclass As New globalclass
    Dim addFltrStr, FltrStr As String
    Public TempString(2) As String
    Public selectNo As Integer
    Public sqlStringFinal, DispString As String
    Dim count As String
    Dim ReminderListObj As New ReminderList
    Dim ReminderLetterObj As New ReminderLetter
    Dim letter As String
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
    Friend WithEvents chk_Filter_Field As System.Windows.Forms.CheckedListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_Filter_By As System.Windows.Forms.ComboBox
    Friend WithEvents btn_disp As System.Windows.Forms.Button
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents Lst_status As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cmb_add_filter As System.Windows.Forms.ComboBox
    Friend WithEvents tbx_Filter_From As System.Windows.Forms.TextBox
    Friend WithEvents tbx_filter_To As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents Lst_status1 As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DLabel As System.Windows.Forms.Label
    Friend WithEvents chk_PrintAll As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ReportFilter))
        Me.cmb_Filter_By = New System.Windows.Forms.ComboBox
        Me.chk_Filter_Field = New System.Windows.Forms.CheckedListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_disp = New System.Windows.Forms.Button
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_print = New System.Windows.Forms.Button
        Me.Lst_status = New System.Windows.Forms.ListBox
        Me.Cmb_add_filter = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.tbx_Filter_From = New System.Windows.Forms.TextBox
        Me.tbx_filter_To = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Lst_status1 = New System.Windows.Forms.ListBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DLabel = New System.Windows.Forms.Label
        Me.chk_PrintAll = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_Filter_By
        '
        Me.cmb_Filter_By.Items.AddRange(New Object() {"Member Category", "Member Status"})
        Me.cmb_Filter_By.Location = New System.Drawing.Point(56, 56)
        Me.cmb_Filter_By.Name = "cmb_Filter_By"
        Me.cmb_Filter_By.Size = New System.Drawing.Size(168, 21)
        Me.cmb_Filter_By.TabIndex = 0
        Me.cmb_Filter_By.Text = "[select your filter]"
        '
        'chk_Filter_Field
        '
        Me.chk_Filter_Field.BackColor = System.Drawing.Color.FromArgb(CType(192, Byte), CType(192, Byte), CType(255, Byte))
        Me.chk_Filter_Field.Location = New System.Drawing.Point(56, 112)
        Me.chk_Filter_Field.Name = "chk_Filter_Field"
        Me.chk_Filter_Field.Size = New System.Drawing.Size(408, 169)
        Me.chk_Filter_Field.Sorted = True
        Me.chk_Filter_Field.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(56, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Category Filter"
        '
        'btn_disp
        '
        Me.btn_disp.BackgroundImage = CType(resources.GetObject("btn_disp.BackgroundImage"), System.Drawing.Image)
        Me.btn_disp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_disp.ForeColor = System.Drawing.Color.White
        Me.btn_disp.Location = New System.Drawing.Point(40, 344)
        Me.btn_disp.Name = "btn_disp"
        Me.btn_disp.Size = New System.Drawing.Size(104, 32)
        Me.btn_disp.TabIndex = 5
        Me.btn_disp.Text = "Display"
        '
        'btn_close
        '
        Me.btn_close.BackgroundImage = CType(resources.GetObject("btn_close.BackgroundImage"), System.Drawing.Image)
        Me.btn_close.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.ForeColor = System.Drawing.Color.White
        Me.btn_close.Location = New System.Drawing.Point(368, 344)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 32)
        Me.btn_close.TabIndex = 7
        Me.btn_close.Text = "Close"
        '
        'btn_print
        '
        Me.btn_print.BackgroundImage = CType(resources.GetObject("btn_print.BackgroundImage"), System.Drawing.Image)
        Me.btn_print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.ForeColor = System.Drawing.Color.White
        Me.btn_print.Location = New System.Drawing.Point(200, 344)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(104, 32)
        Me.btn_print.TabIndex = 6
        Me.btn_print.Text = "Print"
        '
        'Lst_status
        '
        Me.Lst_status.Items.AddRange(New Object() {"1.ABSENTEE", "2.DELETED", "3.EXPIRED", "4.INACTIVE", "5.LIVE", "6.RESIGNED", "7.SURRENDERED"})
        Me.Lst_status.Location = New System.Drawing.Point(472, 120)
        Me.Lst_status.Name = "Lst_status"
        Me.Lst_status.Size = New System.Drawing.Size(112, 108)
        Me.Lst_status.TabIndex = 7
        Me.Lst_status.Visible = False
        '
        'Cmb_add_filter
        '
        Me.Cmb_add_filter.Items.AddRange(New Object() {"Contact Address ", "Permanent Address", "Residence Address", "Business Address"})
        Me.Cmb_add_filter.Location = New System.Drawing.Point(288, 56)
        Me.Cmb_add_filter.Name = "Cmb_add_filter"
        Me.Cmb_add_filter.Size = New System.Drawing.Size(168, 21)
        Me.Cmb_add_filter.TabIndex = 1
        Me.Cmb_add_filter.Text = "[select your filter]"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(288, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Adress Filter"
        '
        'tbx_Filter_From
        '
        Me.tbx_Filter_From.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Filter_From.Location = New System.Drawing.Point(120, 304)
        Me.tbx_Filter_From.Name = "tbx_Filter_From"
        Me.tbx_Filter_From.Size = New System.Drawing.Size(64, 20)
        Me.tbx_Filter_From.TabIndex = 3
        Me.tbx_Filter_From.Text = ""
        '
        'tbx_filter_To
        '
        Me.tbx_filter_To.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_filter_To.Location = New System.Drawing.Point(240, 304)
        Me.tbx_filter_To.Name = "tbx_filter_To"
        Me.tbx_filter_To.Size = New System.Drawing.Size(64, 20)
        Me.tbx_filter_To.TabIndex = 4
        Me.tbx_filter_To.Text = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label4.Location = New System.Drawing.Point(200, 312)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "To"
        '
        'Lst_status1
        '
        Me.Lst_status1.Items.AddRange(New Object() {"1.ABSENTEE", "2.LIVE"})
        Me.Lst_status1.Location = New System.Drawing.Point(472, 248)
        Me.Lst_status1.Name = "Lst_status1"
        Me.Lst_status1.Size = New System.Drawing.Size(48, 95)
        Me.Lst_status1.TabIndex = 13
        Me.Lst_status1.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.DodgerBlue
        Me.Label5.Location = New System.Drawing.Point(64, 312)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 16)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "From"
        '
        'DLabel
        '
        Me.DLabel.BackColor = System.Drawing.Color.DodgerBlue
        Me.DLabel.Location = New System.Drawing.Point(64, 288)
        Me.DLabel.Name = "DLabel"
        Me.DLabel.Size = New System.Drawing.Size(128, 16)
        Me.DLabel.TabIndex = 15
        '
        'chk_PrintAll
        '
        Me.chk_PrintAll.BackColor = System.Drawing.Color.DodgerBlue
        Me.chk_PrintAll.Location = New System.Drawing.Point(56, 88)
        Me.chk_PrintAll.Name = "chk_PrintAll"
        Me.chk_PrintAll.Size = New System.Drawing.Size(168, 16)
        Me.chk_PrintAll.TabIndex = 16
        Me.chk_PrintAll.Text = "Print All Categorys"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 384)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(-124, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(712, 8)
        Me.Label2.TabIndex = 356
        '
        'ReportFilter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(544, 413)
        Me.Controls.Add(Me.chk_PrintAll)
        Me.Controls.Add(Me.DLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Lst_status1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbx_filter_To)
        Me.Controls.Add(Me.tbx_Filter_From)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Cmb_add_filter)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_disp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk_Filter_Field)
        Me.Controls.Add(Me.cmb_Filter_By)
        Me.Controls.Add(Me.Lst_status)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ReportFilter"
        Me.Text = "ReportFilter"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
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
                MEMBERTYPE = globalclass.GetValues(Fill_Chk_str)
                Dim Itration
                For Itration = 0 To (MEMBERTYPE.Rows.Count - 1)
                    chk_Filter_Field.Items.Add(MEMBERTYPE.Rows(Itration).Item("Membertype") & "." & MEMBERTYPE.Rows(Itration).Item("TypeDesc"))
                Next
            ElseIf cmb_Filter_By.Text = "Member Status" Then
                selectNo = 1
                If RepSqlStr = "Locker Number List" Or RepSqlStr = "Subscription Bill" Then
                    FltrStr = "CurentStatus='"
                    chk_Filter_Field.Items.Clear()
                    chk_Filter_Field.Items.AddRange(Lst_status1.Items())
                Else
                    FltrStr = "CurentStatus='"
                    chk_Filter_Field.Items.Clear()
                    chk_Filter_Field.Items.AddRange(Lst_status.Items())
                End If
            End If
            If RepSqlStr = "Locker Number List" Or RepSqlStr = "Member Status List" Or RepSqlStr = "Absentee List" Or RepSqlStr = "Credit AC Number" Or RepSqlStr = "Special Absentee List" Or RepSqlStr = "Subscription Bill" Or RepSqlStr = "First Reminder Letter" Or RepSqlStr = "Second Reminder Letter" Or RepSqlStr = "Posting Reminder Letter" Or RepSqlStr = "First Reminder List" Or RepSqlStr = "Second Reminder List" Or RepSqlStr = "Posting Reminder List" Then
                chk_Filter_Field.Enabled = True
            Else
                chk_Filter_Field.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("An invalided input…Please close the report filter and reopen it.")
            Exit Sub
        End Try
    End Sub
    Private Sub btn_disp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_disp.Click
        PRINTREP = False
        disp_Print()
    End Sub
    Public Function disp_Print()
        Try
            Dim sqlstring, sqlstring1 As String
            Dim AddressListReport As New AddressListReport
            Dim NamewiseListReport As New NamewiseListReport
            Dim MemberStatusListReport As New MemberStatusListReport
            Dim AddressStickerReport As New AddressStickerReport
            Dim Hedd1 As String
            Dim addFilterStr2 As String
            sqlstring = ""
            sqlstring = sqlStringFinal & addFltrStr
            'MsgBox(sqlstring)
            If RepSqlStr = "AddressList" Then
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
                End If
                'Dim sqlstring As String = "select mcode,mname,contadd1,contadd2,contadd3,contcity,contstate,contcountry,contpin,contphone1 FROM membermaster"
                Hedd1 = " ADDRESS LIST OF " & DispString & " MMEMBERS"
                ReportTitle = "ADDRESS LIST OF " & DispString & " MMEMBERS"
                Dim arraystring() As String = {"", Hedd1, "", ""}
                Dim heading() As String = {"M CODE", "MEMBERNAME / ADDRESS"}
                sqlstring = sqlstring & " ORDER BY MCODE"
                AddressListReport.begin()
                AddressListReport.buttonclick(globalclass.sqlconnection, sqlstring, arraystring, heading, Cmb_add_filter.Text)
            ElseIf RepSqlStr = "Surname Wise List" Then
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    sqlstring = sqlstring & " AND SURNAME BETWEEN '" & tbx_Filter_From.Text & "%' AND '" & tbx_filter_To.Text & "%'"
                    'MsgBox(sqlstring)
                End If
                'Dim sqlstring As String = "select mcode,mname,contadd1,contadd2,contadd3,contcity,contstate,contcountry,contpin,contphone1 FROM membermaster"
                HEDDING1 = " SURNAME WISE ADDRESS LIST OF " & TempString((1)) & " MMEMBERS"
                Dim arraystring() As String = {"", Hedd1, "", ""}
                Dim heading() As String = {"", ""}
                NamewiseListReport.begin()
                NamewiseListReport.buttonclick(globalclass.sqlconnection, sqlstring, arraystring, heading)
            ElseIf RepSqlStr = "Address Sticker List" Then
                'Dim MemberStatusListReport As New MemberStatusListReport
                'sqlstring = "select  mcode,mname,curentstatus,statusdatefrom,statusdateto FROM membermaster where " & addFltrStr
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "%'"
                    'MsgBox(sqlstring)
                End If
                'sqlstring = "select mcode,mname,contadd1,contadd2,contadd3,contcity,contstate,contcountry,contpin,contphone1 FROM membermaster order by mname"
                AddressStickerReport.begin()
                AddressStickerReport.buttonclick(globalclass.sqlconnection, sqlstring)
            ElseIf RepSqlStr = "Member Status List" Then
                'Dim MemberStatusListReport As New MemberStatusListReport
                sqlstring = "select  mcode,mname,curentstatus,statusdatefrom,statusdateto FROM membermaster where " & addFltrStr
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
                    'MsgBox(sqlstring)
                End If
                Hedd1 = " MEMBER STATUS LIST OF " & TempString((1)) & " MMEMBERS"
                ReportTitle = "MEMBER STATUS LIST OF MMEMBERS"
                Dim arraystring() As String = {"", Hedd1, "", ""}
                Dim heading() As String = {"MCODE", "MEMBER NAME", "STATUS", "FROM DATE", "TO DATE"}
                sqlstring = sqlstring & " ORDER BY MCODE"
                MemberStatusListReport.begin()
                MemberStatusListReport.buttonclick(globalclass.sqlconnection, sqlstring, arraystring, heading)
            ElseIf RepSqlStr = "Absentee List" Then
                'Dim MemberStatusListReport As New MemberStatusListReport
                sqlstring = "select  mcode,mname,curentstatus,statusdatefrom,statusdateto FROM membermaster where curentstatus = 'Absentee' and " & addFltrStr
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
                    'MsgBox(sqlstring)
                End If
                Hedd1 = " MEMBER ABSENTEE LIST OF " & TempString((1)) & " MMEMBERS"
                ReportTitle = "MEMBER ABSENTEE LIST OF  MMEMBERS"
                Dim arraystring() As String = {"", Hedd1, "", ""}
                Dim heading() As String = {"MCODE", "MEMBER NAME", "STATUS", "FROM DATE", "TO DATE"}
                sqlstring = sqlstring & " ORDER BY MCODE"
                MemberStatusListReport.begin()
                MemberStatusListReport.buttonclick(globalclass.sqlconnection, sqlstring, arraystring, heading)
            ElseIf RepSqlStr = "Locker Number List" Then
                Dim arraystring() As String
                Dim heading() As String
                'If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                'sqlstring = sqlstring & " AND MCODE BETWEEN 'A%' AND 'G%'"
                'MsgBox(sqlstring)
                'End If
                '''''''''Class_LocarNo
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
                    'MsgBox(sqlstring)
                End If
                If cmb_Filter_By.Text = "Member Category" Then
                    FinalString = "select MCODE,MNAME,CurentStatus,HPLocker,GDRLocker,LDRLocker from membermaster where (hplocker <> '' or gdrlocker <> '' or ldrlocker <> '' ) AND ( CURENTSTATUS = 'Live'or CURENTSTATUS = 'Absentee' ) and " & " (" & addFltrStr & " )"
                ElseIf cmb_Filter_By.Text = "Member Status" Then
                    FinalString = "select MCODE,MNAME,CurentStatus,HPLocker,GDRLocker,LDRLocker from membermaster where (hplocker <> '' or gdrlocker <> '' or ldrlocker <> '' )and " & " (" & addFltrStr & " )"
                End If
                Dim obj As New Class_LocarNo
                obj.begin()
                obj.buttonclick(globalclass.sqlconnection, FinalString, arraystring, heading)

            ElseIf RepSqlStr = "Credit AC Number" Then
                Dim arraystring() As String
                Dim heading() As String
                ' If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                'sqlstring = sqlstring & " AND MCODE BETWEEN 'A%' AND 'G%'"
                'MsgBox(sqlstring)
                'End If
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "%' AND '" & tbx_filter_To.Text & "%'"
                    'MsgBox(sqlstring)
                End If
                If cmb_Filter_By.Text = "Member Category" Then
                    FinalString = "select MCODE,MNAME,CurentStatus,criditNumber,SecurityDeposit from membermaster where (criditnumber <> '' )and( CURENTSTATUS = 'Live'or CURENTSTATUS = 'Absentee' ) and " & " " & addFltrStr
                ElseIf cmb_Filter_By.Text = "Member Status" Then
                    FinalString = "select MCODE,MNAME,CurentStatus,criditNumber,SecurityDeposit from membermaster where (criditnumber <> '' ) and " & " " & addFltrStr
                End If
                Dim obj As New Class_CriditNo
                obj.begin()
                obj.buttonclick(globalclass.sqlconnection, FinalString, arraystring, heading)
            ElseIf RepSqlStr = "Special Absentee List" Then
                Dim SPECIALABSENTEELISTREPORT As New SpecialAbsenteeListReport
                ReportTitle = "SPECIAL ABSENTEE LIST"
                sqlstring = "select * FROM specialabsentee WHERE NEWSTATUS = 'ABSENTEE' AND " & addFltrStr
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    sqlstring = sqlstring & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
                    MsgBox(sqlstring)
                End If
                Dim arraystring() As String = {"", "SPECIAL ABSENTEE LIST", "", ""}
                Dim heading() As String = {"M NAME", "FROM ", " TO"}
                SPECIALABSENTEELISTREPORT.begin()
                SPECIALABSENTEELISTREPORT.buttonclick(globalclass.sqlconnection, sqlstring, arraystring, heading)
            ElseIf RepSqlStr = "First Reminder Letter" Then
                'sqlstring = "SELECT * FROM dbo.SUBSCRIPTION_SUMMARY_VIEW B  WHERE (ISNULL(ARREAR,0) + ISNULL(PR_ARREAR,0))<>0 "
                ''sqlstring = "SELECT * FROM dbo.SUBSCRIPTION_SUMMARY_VIEW B  WHERE (ISNULL(ARREAR,0))<>0 "
                ''FinalString = sqlstring & SetQuater & "and(" & addFltrStr & ")"
                sqlstring = "SELECT * FROM dbo.SUBSCRIPTION_SUMMARY_VIEW B  WHERE (ISNULL(ARREAR,0))<>0 and (B.QUTERDATE = '1\7\2006 TO 30\9\2006')"
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    FinalString = FinalString & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
                End If
                letter = "FIRST REMINDER LETTER"
                ReminderLetterObj.begin()
                ReminderLetterObj.buttonclick(globalclass.sqlconnection, sqlstring, letter)
                'ReminderLetterObj.buttonclick(globalclass.sqlconnection, FinalString, letter)
            ElseIf RepSqlStr = "Second Reminder Letter" Then
                sqlstring = "SELECT * FROM dbo.SUBSCRIPTION_SUMMARY_VIEW B  "
                FinalString = sqlstring & SetQuater & "and(" & addFltrStr & ")"
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    FinalString = FinalString & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "%' AND '" & tbx_filter_To.Text & "%'"
                End If
                letter = "Second Reminder Letter"
                ReminderLetterObj.begin()
                ReminderLetterObj.buttonclick(globalclass.sqlconnection, FinalString, letter)
            ElseIf RepSqlStr = "Posting Reminder Letter" Then
                sqlstring = "SELECT * FROM dbo.SUBSCRIPTION_SUMMARY_VIEW B  WHERE (ISNULL(ARREAR,0) + ISNULL(PR_ARREAR,0))<>0 "
                FinalString = sqlstring & SetQuater & "and (" & addFltrStr & ")"
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    FinalString = FinalString & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
                End If
                letter = "Posting Of Reminder Letter"
                ReminderLetterObj.begin()
                ReminderLetterObj.buttonclick(globalclass.sqlconnection, FinalString, letter)
            ElseIf RepSqlStr = "First Reminder List" Then
                sqlstring = "SELECT * FROM dbo.SUBSCRIPTION_SUMMARY_VIEW B WHERE (ISNULL(ARREAR,0) + ISNULL(PR_ARREAR,0))<>0 "

                FinalString = sqlstring & SetQuater & "and(" & addFltrStr & ")"

                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    FinalString = FinalString & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"

                End If

                Dim arraystring() As String = {"", " FIRST REMINDER LIST ", "", ""}
                Dim heading() As String = {"M CODE", "M Name", "Bill No", "Due Date", "Amount"}
                ReminderListObj.begin()
                ReminderListObj.buttonclick(globalclass.sqlconnection, FinalString, arraystring, heading)
            ElseIf RepSqlStr = "Second Reminder List" Then
                sqlstring = "SELECT * FROM dbo.SUBSCRIPTION_SUMMARY_VIEW WHERE (ISNULL(ARREAR,0) + ISNULL(PR_ARREAR,0))<>0 "
                FinalString = sqlstring & SetQuater & "and(" & addFltrStr & ")"
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    FinalString = FinalString & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
                    'MsgBox(sqlstring)
                End If
                Dim arraystring() As String = {"", " Second Reminder List ", "", ""}
                Dim heading() As String = {"M CODE", "M Name", "Bill No", "Due Date", "Amount"}
                ReminderListObj.begin()
                ReminderListObj.buttonclick(globalclass.sqlconnection, FinalString, arraystring, heading)

            ElseIf RepSqlStr = "Posting Reminder List" Then

                sqlstring = "SELECT * FROM dbo.SUBSCRIPTION_SUMMARY_VIEW  WHERE (ISNULL(ARREAR,0) + ISNULL(PR_ARREAR,0))<>0 "
                FinalString = sqlstring & SetQuater & "and(" & addFltrStr & ")"

                ''sqlstring = "select * FROM specialabsentee WHERE NEWSTATUS = 'ABSENTEE' AND " & addFltrStr
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    FinalString = FinalString & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
                    'MsgBox(sqlstring)
                End If
                Dim arraystring() As String = {"", " Posting Reminder List ", "", ""}
                Dim heading() As String = {"M CODE", "M Name", "Bill No", "Due Date", "Amount"}
                ReminderListObj.begin()
                ReminderListObj.buttonclick(globalclass.sqlconnection, FinalString, arraystring, heading)

            ElseIf RepSqlStr = "Subscription Bill" Then

                Dim SPECIALABSENTEELISTREPORT As New SpecialAbsenteeListReport
                ' ####################code to be modified
                sqlstring = "SELECT  DISTINCT B.Prefix,B.MNAME, B.CONTADD1, "
                sqlstring = sqlstring & " B.CONTADD2, B.CONTADD3, "
                sqlstring = sqlstring & " B.CONTCITY, B.CONTPIN, "
                sqlstring = sqlstring & " B.CONTSTATE, B.VRNO, B.DUEDATE, "
                sqlstring = sqlstring & " B.MCODE, B.TypeDesc, "
                sqlstring = sqlstring & " B.QUTERDATE, A.SubsDesc, A.Total as Amount, "
                sqlstring = sqlstring & " B.TOTAL AS TotalAmount,"
                sqlstring = sqlstring & " ISNULL(B.ARREAR,0) AS ARREAR,"
                sqlstring = sqlstring & " ISNULL(B.TAXTOTAL,0) AS TAXTOTAL"
                'sqlstring = sqlstring & " isnull((SELECT SUM(REALVALUE-ISNULL(ADJUSTED,0)) FROM OUTSTANDING WHERE  SLCODE=B.MCODE),0) AS Arrear "
                sqlstring = sqlstring & " FROM SUBSCRIPTION_POSTING_VIEW A ,  dbo.SUBSCRIPTION_SUMMARY_VIEW B"
                sqlstring = sqlstring & " WHERE A.SUBCD = B.MCODE AND A.CHALANO = B.VRNO "
                'FOR CORPORATE SUBSCRIPTION
                '*********************************************************************************
                If CORPORATE_TRUE = True Then
                    sqlstring = "SELECT   'The 'AS Prefix,B.MNAME, B.CONTADD1, "
                    sqlstring = sqlstring & " B.CONTADD2, B.CONTADD3, "
                    sqlstring = sqlstring & " B.CONTCITY, B.CONTPIN, "
                    sqlstring = sqlstring & " B.CONTSTATE, B.VRNO, B.DUEDATE, "
                    sqlstring = sqlstring & " B.MCODE, B.TypeDesc, "
                    sqlstring = sqlstring & " B.QUTERDATE, A.SubsDesc, A.Total as Amount, "
                    sqlstring = sqlstring & " B.TOTAL AS TotalAmount,"
                    sqlstring = sqlstring & " ISNULL(B.ARREAR,0) AS ARREAR,"
                    sqlstring = sqlstring & " ISNULL(B.TAXTOTAL,0) AS TAXTOTAL"
                    'sqlstring = sqlstring & " isnull((SELECT SUM(REALVALUE-ISNULL(ADJUSTED,0)) FROM OUTSTANDING WHERE  SLCODE=B.MCODE),0) AS Arrear "
                    sqlstring = sqlstring & " FROM SUBSCRIPTION_POSTING_VIEW A ,  dbo.SUBSCRIPTION_CORPORATE_VIEW B"
                    sqlstring = sqlstring & " WHERE .A.SUBCD = B.MCODE "
                    '************************************************************************************
                End If
                FinalString = sqlstring & SetQuater & "and(" & addFltrStr & ")"
                ''sqlstring = "select * FROM specialabsentee WHERE NEWSTATUS = 'ABSENTEE' AND " & addFltrStr
                If tbx_Filter_From.Text <> "" And tbx_filter_To.Text <> "" Then
                    FinalString = FinalString & " AND MCODE BETWEEN '" & tbx_Filter_From.Text & "' AND '" & tbx_filter_To.Text & "'"
                    'MsgBox(sqlstring)
                End If
                Dim SubscriptionBillingReport As New SubscriptionBillingReport
                Dim arraystring() As String = {"1,Strand Road", "Kolkatta - 700001", " SUBSCRIPTION BILL ", "", ""}
                Dim heading() As String = {"M CODE", "M Name", "Bill No", "Due Date", "Amount"}
                SubscriptionBillingReport.begin()
                SubscriptionBillingReport.buttonclick(globalclass.sqlconnection, FinalString, arraystring, heading)
            End If
            'Me.Hide()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Sub chk_Filter_Field_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles chk_Filter_Field.ItemCheck
        If count = 0 Then
            TempString = Split((chk_Filter_Field.Text), ".")
            DispString = TempString(1)
            If Trim(TempString(0)) = "0013" Then
                CORPORATE_TRUE = True
            Else
                CORPORATE_TRUE = False
            End If
            addFltrStr = FltrStr & Trim(TempString(selectNo)) & "'"
            'MsgBox(addFltrStr)
            'chk_Filter_Field.Enabled = False
        Else
            TempString = Split((chk_Filter_Field.Text), ".")
            DispString = DispString & ", " & TempString(1)
            addFltrStr = addFltrStr & " , '" & Trim(TempString(selectNo)) & "'"
        End If
        tbx_Filter_From.Enabled = True
        tbx_filter_To.Enabled = True
        btn_disp.Enabled = True
        btn_print.Enabled = True
        count = count + 1
    End Sub
    Private Sub cmb_Filter_By_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Filter_By.Validated

    End Sub
    Private Sub btn_cls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_close.Click
        Cmb_add_filter.Enabled = False
        chk_Filter_Field.Enabled = False
        tbx_Filter_From.Enabled = False
        tbx_filter_To.Enabled = False
        Me.Hide()
    End Sub
    Private Sub ReportFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        count = 0
        If RepSqlStr = "AddressList" Or RepSqlStr = "Surname Wise List" Or RepSqlStr = "Address Sticker List" Then
            Cmb_add_filter.Visible = True
            Label3.Visible = True
        Else
            Cmb_add_filter.Visible = False
            Label3.Visible = False
        End If
        Cmb_add_filter.Enabled = False
        chk_Filter_Field.Enabled = False
        tbx_Filter_From.Enabled = False
        tbx_filter_To.Enabled = False
        btn_disp.Enabled = False
        btn_print.Enabled = False
    End Sub
    Private Sub Cmb_add_filter_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_add_filter.SelectedIndexChanged
        chk_Filter_Field.Enabled = True
        If Trim(Cmb_add_filter.SelectedItem) = "Contact Address" Then
            sqlStringFinal = "select mcode,mname,contadd1,contadd2,contadd3,contcity,contstate,contcountry,contpin,contphone1,prefix FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Permanent Address" Then
            sqlStringFinal = "select mcode,mname,padd1,padd2,padd3,pcity,pstate,pcountry,contpin,contphone1,prefix FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Residence Address" Then
            sqlStringFinal = "select mcode,mname,cadd1,cadd2,cadd3,ccity,cstate,ccountry,cpin,cphone1,prefix FROM membermaster where "
        ElseIf Trim(Cmb_add_filter.SelectedItem) = "Business Address" Then
            sqlStringFinal = "select mcode,mname,oadd1,oadd2,oadd3,ocity,ostate,ocountry,opin,ophone1,prefix FROM membermaster where "
        End If
    End Sub
    Private Sub cmb_Filter_By_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_Filter_By.KeyDown
        If RepSqlStr = "Locker Number List" Or RepSqlStr = "Member Status List" Then
            If e.KeyCode = Keys.Enter Then
                chk_Filter_Field.Focus()
            End If
        Else
            If e.KeyCode = Keys.Enter Then
                Cmb_add_filter.Focus()
            End If
        End If
    End Sub

    Private Sub Cmb_add_filter_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Cmb_add_filter.KeyDown
        If e.KeyCode = Keys.Enter Then
            chk_Filter_Field.Focus()
        End If
    End Sub

    Private Sub chk_Filter_Field_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles chk_Filter_Field.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbx_Filter_From.Focus()
        End If
    End Sub
    Private Sub tbx_Filter_From_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_Filter_From.KeyDown
        If e.KeyCode = Keys.Enter Then
            tbx_filter_To.Focus()
        End If
    End Sub
    Private Sub tbx_filter_To_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_filter_To.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_disp.Focus()
        End If
    End Sub

    Private Sub btn_disp_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_disp.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_print.Focus()
        End If
    End Sub

    Private Sub btn_print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_print.Click
        PRINTREP = True
        disp_Print()
    End Sub

    Private Sub btn_print_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles btn_print.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_close.Focus()
        End If
    End Sub

    Private Sub tbx_Filter_From_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Filter_From.KeyPress
        getAlphanumeric(e)
    End Sub

    Private Sub tbx_filter_To_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_filter_To.KeyPress
        getAlphanumeric(e)
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
        End If
        addFltrStr = addFltrStr & " )"
    End Sub

    Private Sub chk_Filter_Field_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Filter_Field.Validated
        addFltrStr = addFltrStr & " )"
    End Sub
End Class
