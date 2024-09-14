Imports System.Data.SqlClient
Imports System.IO
Public Class REMINDERNEW
    Inherits System.Windows.Forms.Form
    Dim ssql As String
    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim vtype, vtypedesc, vremcode, vfdate, vtdate, vasdate, vrcount As String
    Dim vsplit() As String
    Dim i, j
    Dim valdata As Boolean
    Dim gconnection As New GlobalClass
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
    Friend WithEvents cmd_MCodeToHelp As System.Windows.Forms.Button
    Friend WithEvents cmd_MCodefromHelp As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents CmdView As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chbreminder As System.Windows.Forms.CheckedListBox
    Friend WithEvents RBTREMINDERLETTER As System.Windows.Forms.RadioButton
    Friend WithEvents RBTREMINDERSUMMARY As System.Windows.Forms.RadioButton
    Friend WithEvents TXTMCODETO As System.Windows.Forms.TextBox
    Friend WithEvents TXTMCODEFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(REMINDERNEW))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.chbreminder = New System.Windows.Forms.CheckedListBox
        Me.RBTREMINDERLETTER = New System.Windows.Forms.RadioButton
        Me.RBTREMINDERSUMMARY = New System.Windows.Forms.RadioButton
        Me.cmd_MCodeToHelp = New System.Windows.Forms.Button
        Me.cmd_MCodefromHelp = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.CmdView = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TXTMCODETO = New System.Windows.Forms.TextBox
        Me.TXTMCODEFrom = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.chbreminder)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(856, 408)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(560, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MCODE,     MTYPE   REM.CODE     ,  FROMDATE , TODATE  ,  ASDATE  , REM. LTNO"
        '
        'chbreminder
        '
        Me.chbreminder.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbreminder.Location = New System.Drawing.Point(8, 48)
        Me.chbreminder.Name = "chbreminder"
        Me.chbreminder.Size = New System.Drawing.Size(840, 340)
        Me.chbreminder.TabIndex = 0
        '
        'RBTREMINDERLETTER
        '
        Me.RBTREMINDERLETTER.BackColor = System.Drawing.Color.Transparent
        Me.RBTREMINDERLETTER.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTREMINDERLETTER.Location = New System.Drawing.Point(296, 489)
        Me.RBTREMINDERLETTER.Name = "RBTREMINDERLETTER"
        Me.RBTREMINDERLETTER.Size = New System.Drawing.Size(160, 16)
        Me.RBTREMINDERLETTER.TabIndex = 1
        Me.RBTREMINDERLETTER.Text = "Reminder Letter"
        '
        'RBTREMINDERSUMMARY
        '
        Me.RBTREMINDERSUMMARY.BackColor = System.Drawing.Color.Transparent
        Me.RBTREMINDERSUMMARY.Checked = True
        Me.RBTREMINDERSUMMARY.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RBTREMINDERSUMMARY.Location = New System.Drawing.Point(480, 487)
        Me.RBTREMINDERSUMMARY.Name = "RBTREMINDERSUMMARY"
        Me.RBTREMINDERSUMMARY.Size = New System.Drawing.Size(224, 24)
        Me.RBTREMINDERSUMMARY.TabIndex = 2
        Me.RBTREMINDERSUMMARY.TabStop = True
        Me.RBTREMINDERSUMMARY.Text = "Reminder Summary"
        '
        'cmd_MCodeToHelp
        '
        Me.cmd_MCodeToHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodeToHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodeToHelp.Image = CType(resources.GetObject("cmd_MCodeToHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodeToHelp.Location = New System.Drawing.Point(528, 528)
        Me.cmd_MCodeToHelp.Name = "cmd_MCodeToHelp"
        Me.cmd_MCodeToHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodeToHelp.TabIndex = 417
        '
        'cmd_MCodefromHelp
        '
        Me.cmd_MCodefromHelp.BackColor = System.Drawing.Color.Transparent
        Me.cmd_MCodefromHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_MCodefromHelp.Image = CType(resources.GetObject("cmd_MCodefromHelp.Image"), System.Drawing.Image)
        Me.cmd_MCodefromHelp.Location = New System.Drawing.Point(400, 528)
        Me.cmd_MCodefromHelp.Name = "cmd_MCodefromHelp"
        Me.cmd_MCodefromHelp.Size = New System.Drawing.Size(23, 24)
        Me.cmd_MCodefromHelp.TabIndex = 416
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.CmdClear)
        Me.GroupBox2.Controls.Add(Me.cmdexit)
        Me.GroupBox2.Controls.Add(Me.cmdPrint)
        Me.GroupBox2.Controls.Add(Me.CmdView)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(168, 568)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(528, 56)
        Me.GroupBox2.TabIndex = 418
        Me.GroupBox2.TabStop = False
        '
        'CmdClear
        '
        Me.CmdClear.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdClear.BackgroundImage = CType(resources.GetObject("CmdClear.BackgroundImage"), System.Drawing.Image)
        Me.CmdClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.ForeColor = System.Drawing.Color.White
        Me.CmdClear.Location = New System.Drawing.Point(264, 16)
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
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.White
        Me.cmdexit.Location = New System.Drawing.Point(392, 16)
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
        Me.cmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdPrint.ForeColor = System.Drawing.Color.White
        Me.cmdPrint.Location = New System.Drawing.Point(144, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(104, 32)
        Me.cmdPrint.TabIndex = 6
        Me.cmdPrint.Text = "Print[F12]"
        '
        'CmdView
        '
        Me.CmdView.BackColor = System.Drawing.SystemColors.Menu
        Me.CmdView.BackgroundImage = CType(resources.GetObject("CmdView.BackgroundImage"), System.Drawing.Image)
        Me.CmdView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CmdView.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CmdView.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdView.ForeColor = System.Drawing.Color.White
        Me.CmdView.Location = New System.Drawing.Point(24, 16)
        Me.CmdView.Name = "CmdView"
        Me.CmdView.Size = New System.Drawing.Size(104, 32)
        Me.CmdView.TabIndex = 5
        Me.CmdView.Text = "View[F9]"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(288, 528)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 415
        Me.Label7.Text = "From"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(440, 528)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 20)
        Me.Label8.TabIndex = 414
        Me.Label8.Text = "To"
        '
        'TXTMCODETO
        '
        Me.TXTMCODETO.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.TXTMCODETO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMCODETO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMCODETO.Location = New System.Drawing.Point(464, 528)
        Me.TXTMCODETO.Name = "TXTMCODETO"
        Me.TXTMCODETO.Size = New System.Drawing.Size(64, 24)
        Me.TXTMCODETO.TabIndex = 413
        Me.TXTMCODETO.Text = ""
        '
        'TXTMCODEFrom
        '
        Me.TXTMCODEFrom.BackColor = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.TXTMCODEFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TXTMCODEFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTMCODEFrom.Location = New System.Drawing.Point(336, 528)
        Me.TXTMCODEFrom.Name = "TXTMCODEFrom"
        Me.TXTMCODEFrom.Size = New System.Drawing.Size(64, 24)
        Me.TXTMCODEFrom.TabIndex = 412
        Me.TXTMCODEFrom.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(360, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(235, 29)
        Me.Label2.TabIndex = 419
        Me.Label2.Text = "REMINDER LETTER"
        '
        'REMINDERNEW
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(944, 670)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmd_MCodeToHelp)
        Me.Controls.Add(Me.cmd_MCodefromHelp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTMCODETO)
        Me.Controls.Add(Me.TXTMCODEFrom)
        Me.Controls.Add(Me.RBTREMINDERSUMMARY)
        Me.Controls.Add(Me.RBTREMINDERLETTER)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Blue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "REMINDERNEW"
        Me.Text = "REMINDERNEW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub REMINDERNEW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gUserCategory <> "S" Then
            Call GetRights()
        End If
        Call REMDETAILS()
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
        Me.cmdPrint.Enabled = False
        Me.CmdView.Enabled = False
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
                End If
                If Right(x) = "P" Then
                    Me.cmdPrint.Enabled = True
                End If
            Next
        End If
    End Sub
    Private Function REMDETAILS()
        Try
            ssql = "  Select a.*,b.typedesc from reminderhistory a, membertype b where a.membertypecode=b.Membertype "
            dt = Nothing
            dt = gconnection.GetValues(ssql)
            If dt.Rows.Count > 0 Then
                chbreminder.Items.Clear()
                For i = 0 To dt.Rows.Count - 1
                    chbreminder.Items.Add(Trim(dt.Rows(i).Item("membertypecode")) & "=>" & Trim(dt.Rows(i).Item("typedesc")) & "=>" & Trim(dt.Rows(i).Item("remindercode")) & "=>" & Format(dt.Rows(i).Item("fromdate"), "dd/MMM/yyyy") & "=>" & Format(dt.Rows(i).Item("todate"), "dd/MMM/yyyy") & "=>" & Format(dt.Rows(i).Item("asnodate"), "dd/MMM/yyyy") & "=>" & Trim(dt.Rows(i).Item("remindercount")))
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
    End Function
    Private Sub cmd_MCodeToHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodeToHelp.Click
        Dim vform As New ListOperation
        Dim SQLSTR, sqlstr1 As String
        Dim DR, dr1 As SqlDataReader
        Dim STR As String
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        listop = ""
        'clearform(Me)
        gSQLString = "SELECT MCODE,MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "  Member Code  | Member Name                           "
        vform.vCaption = "Member Master Help"
        vform.KeyPos = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TXTMCODETO.Text = Trim(vform.keyfield & "")
            CmdView.Select()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub cmd_MCodefromHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_MCodefromHelp.Click
        Dim vform As New ListOperation
        Dim SQLSTR, sqlstr1 As String
        Dim DR, dr1 As SqlDataReader
        Dim STR As String
        Dim ds As New DataSet
        Dim da As New SqlDataAdapter
        listop = ""
        clearform(Me)
        gSQLString = "SELECT MCODE,MNAME FROM membermaster"
        M_WhereCondition = " "
        vform.Field = "MCODE,MNAME"
        vform.vFormatstring = "  Member Code  | Member Name                           "
        vform.vCaption = "Member Master Help"
        vform.KeyPos = 0
        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            TXTMCODEFrom.Text = Trim(vform.keyfield & "")
            CmdView.Select()
        End If
        vform.Close()
        vform = Nothing
    End Sub
    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        'Me.Hide()
    End Sub
    Private Sub CmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClear.Click
        chbreminder.Items.Clear()
    End Sub
    Private Function getdetails()
        valdata = False
        Try
            If chbreminder.Items.Count >= 0 Then
                j = 0
                For i = 0 To chbreminder.Items.Count - 1
                    If chbreminder.GetItemChecked(i) = True Then
                        vsplit = Split(chbreminder.Items(i), "=>")
                        If j = 0 Then
                            vtype = vsplit(0)
                            vtypedesc = vsplit(1)
                            vremcode = vsplit(2)
                            vfdate = vsplit(3)
                            vtdate = vsplit(4)
                            vasdate = vsplit(5)
                            vrcount = vsplit(6)
                        Else
                            vtype = vtype & "','" & vsplit(0)
                            vtypedesc = vtypedesc & "','" & vsplit(1)
                            vremcode = vremcode & "','" & vsplit(2)
                            vfdate = vfdate & "','" & vsplit(3)
                            vtdate = vtdate & "','" & vsplit(4)
                            vasdate = vasdate & "','" & vsplit(5)
                            vrcount = vrcount & "','" & vsplit(6)
                        End If
                        j = j + 1
                    End If
                Next i
            Else
                MessageBox.Show("Select the Reminder Format", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Function
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        valdata = True
    End Function
    Private Sub CmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdView.Click
        PRINTREP = False
        If RBTREMINDERLETTER.Checked = True Then
            Call details()
        Else
            Call SUMMARY()
        End If
    End Sub
    Private Function SUMMARY()
        Dim sno As Integer
        Dim lettertype As String
        Call getdetails()
        Dim totbillamount, totadjamount, totbalamount, totaddamount, addamt
        Dim pagebillamount, pageadjamount, pagebalamount, pageaddamount
        Dim pageno, pagesize
        If vrcount = 1 Then
            lettertype = "Subscription First Reminder Letter For :"
            addamt = 0
        ElseIf vrcount = 2 Then
            addamt = 100
            lettertype = "Subscription second Reminder Letter For :"
        ElseIf vrcount = 3 Then
            lettertype = "Subscription Third Reminder Letter For :"
            addamt = 0
        End If
        If valdata = False Then Exit Function
        Try
            ssql = "select a.mcode,a.mname,b.voucherno,b.voucherdate,b.amount,b.adjustedamount as adjamount,(b.amount-b.adjustedamount) as balamount from matching  b, membermaster a  where a.mcode=b.slcode and a.membertypecode in('" & vtype & "')"
            ssql = ssql & " and  b.Voucherdate>='" & vfdate & "' and b.voucherdate<='" & vtdate & "' and b.avoucherdate='" & vasdate & "' and slcode between '" & TXTMCODEFrom.Text & "' and  '" & TXTMCODETO.Text & "'"
            dt = Nothing
            dt = gconnection.GetValues(ssql)
            pageno = 1
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine()
            pagesize = 5
            Filewrite.WriteLine(Chr(15) & Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
            Filewrite.WriteLine(Chr(27) + "E" & Trim(lettertype) & Trim(vtypedesc) & Chr(27) + "F" & Space(30) & "Page No:" & Trim(CStr(pageno)))
            Filewrite.WriteLine("Period From " & vfdate & " To " & vtdate)
            Filewrite.WriteLine("Reminder Date: " & vasdate)
            Filewrite.WriteLine(StrDup(110, "-"))
            Filewrite.WriteLine(Space(1) & "Sno Mbr No.  Name                       Bill No            Date       BillAmt   AdjAmt    addamt   BalAmt")
            Filewrite.WriteLine(StrDup(110, "-"))
            pagesize = 5
            If dt.Rows.Count > 0 Then
                sno = 1
                For i = 0 To dt.Rows.Count - 1
                    If pagesize > 60 Then
                        sno = 1
                        Filewrite.WriteLine(StrDup(110, "-"))
                        ssql = Space(70) & Space(8 - Len(Mid(Format(Val(totbillamount), "0.00"), 1, 8))) & Mid(Format(Val(totbillamount), "0.00"), 1, 8)
                        ssql = ssql & Space(1) & Space(8 - Len(Mid(Format(Val(pageadjamount), "0.00"), 1, 8))) & Mid(Format(Val(pageadjamount), "0.00"), 1, 8)
                        ssql = ssql & Space(1) & Space(8 - Len(Mid(Format(Val(pageaddamount), "0.00"), 1, 8))) & Mid(Format(Val(pageaddamount), "0.00"), 1, 8)
                        ssql = ssql & Space(1) & Space(8 - Len(Mid(Format(Val(pagebalamount), "0.00"), 1, 8))) & Mid(Format(Val(pagebalamount), "0.00"), 1, 8)
                        Filewrite.WriteLine(ssql)
                        Filewrite.WriteLine(StrDup(110, "-") & Chr(12))
                        pagebillamount = 0
                        pageadjamount = 0
                        pagebalamount = 0
                        Filewrite.WriteLine(Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Trim(lettertype) & Trim(vtypedesc) & Chr(27) + "F" & Space(30) & "Page No:" & Trim(CStr(pageno)))
                        Filewrite.WriteLine("Period From " & vfdate & " To " & vtdate)
                        Filewrite.WriteLine("Reminder Date: " & vasdate)
                        Filewrite.WriteLine(StrDup(110, "-"))
                        Filewrite.WriteLine(Space(1) & "Mbr No.  Name                       Bill No            Date       BillAmt   AdjAmt    BalAmt")
                        Filewrite.WriteLine(StrDup(110, "-"))
                        pagesize = 7
                    End If
                    ssql = Space(1) & Mid(sno, 1, 4) & Space(4 - Len(Mid(sno, 1, 4))) & Mid(dt.Rows(i).Item("mcode"), 1, 7) & Space(7 - Len(Mid(dt.Rows(i).Item("mcode"), 1, 7))) & Mid(dt.Rows(i).Item("mname"), 1, 30) & Space(1) & Space(30 - Len(Mid(dt.Rows(i).Item("mname"), 1, 30))) & Mid(dt.Rows(i).Item("voucherno"), 1, 16) & Space(16 - Len(Mid(dt.Rows(i).Item("voucherno"), 1, 16))) & Mid(dt.Rows(i).Item("voucherdate"), 1, 10) & Space(10 - Len(Mid(dt.Rows(i).Item("voucherdate"), 1, 10))) & Space(1) & Space(8 - Len(Mid(Format(Val(dt.Rows(i).Item("amount")), "0.00"), 1, 8))) & Mid(Format(Val(dt.Rows(i).Item("amount")), "0.00"), 1, 8)
                    ssql = ssql & Space(1) & Space(8 - Len(Mid(Format(Val(dt.Rows(i).Item("adjamount")), "0.00"), 1, 8))) & Mid(Format(Val(dt.Rows(i).Item("adjamount")), "0.00"), 1, 8)
                    ssql = ssql & Space(1) & Space(8 - Len(Mid(Format(Val(addamt), "0.00"), 1, 8))) & Mid(Format(Val(addamt), "0.00"), 1, 8)
                    ssql = ssql & Space(1) & Space(8 - Len(Mid(Format(Val(dt.Rows(i).Item("balamount") + addamt), "0.00"), 1, 8))) & Mid(Format(Val(dt.Rows(i).Item("balamount") + addamt), "0.00"), 1, 8)
                    Filewrite.WriteLine(ssql)
                    pagesize = pagesize + 1
                    pagebillamount = pagebillamount + Val(dt.Rows(i).Item("amount"))
                    pageadjamount = pageadjamount + Val(dt.Rows(i).Item("adjamount"))
                    pagebalamount = pagebalamount + Val(dt.Rows(i).Item("balamount")) + addamt
                    pageaddamount = pageaddamount + addamt

                    totbillamount = totbillamount + Val(dt.Rows(i).Item("amount"))
                    totadjamount = totadjamount + Val(dt.Rows(i).Item("adjamount"))
                    totbalamount = totbalamount + Val(dt.Rows(i).Item("balamount")) + addamt
                    totaddamount = totaddamount + addamt
                    sno = sno + 1
                Next
                If pagesize <= 60 Then
                    Filewrite.WriteLine(StrDup(110, "-"))
                    ssql = Space(70) & Space(8 - Len(Mid(Format(Val(pagebillamount), "0.00"), 1, 8))) & Mid(Format(Val(pagebillamount), "0.00"), 1, 8)
                    ssql = ssql & Space(1) & Space(8 - Len(Mid(Format(Val(pageadjamount), "0.00"), 1, 8))) & Mid(Format(Val(pageadjamount), "0.00"), 1, 8)
                    ssql = ssql & Space(1) & Space(8 - Len(Mid(Format(Val(pageaddamount), "0.00"), 1, 8))) & Mid(Format(Val(pageaddamount), "0.00"), 1, 8)
                    ssql = ssql & Space(1) & Space(8 - Len(Mid(Format(Val(pagebalamount), "0.00"), 1, 8))) & Mid(Format(Val(pagebalamount), "0.00"), 1, 8)
                    Filewrite.WriteLine(ssql)
                    Filewrite.WriteLine(StrDup(110, "-"))
                    pagebillamount = 0
                    pageadjamount = 0
                    pagebalamount = 0
                End If
                ssql = Space(70) & Space(8 - Len(Mid(Format(Val(totbillamount), "0.00"), 1, 8))) & Mid(Format(Val(totbillamount), "0.00"), 1, 8)
                ssql = ssql & Space(1) & Space(8 - Len(Mid(Format(Val(totadjamount), "0.00"), 1, 8))) & Mid(Format(Val(totadjamount), "0.00"), 1, 8)
                ssql = ssql & Space(1) & Space(8 - Len(Mid(Format(Val(totaddamount), "0.00"), 1, 8))) & Mid(Format(Val(totaddamount), "0.00"), 1, 8)
                ssql = ssql & Space(1) & Space(8 - Len(Mid(Format(Val(totbalamount), "0.00"), 1, 8))) & Mid(Format(Val(totbalamount), "0.00"), 1, 8)
                Filewrite.WriteLine(ssql)
                Filewrite.WriteLine(StrDup(110, "-") & Chr(12))
            End If
            Filewrite.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        If PRINTREP = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile(vOutfile)
        End If
    End Function
    Private Function details()
        Dim sno As Integer
        Dim lettertype, vhead, samt() As String
        Call getdetails()
        Dim totbillamount, totadjamount, totbalamount, totaddamount, addamt
        Dim pagebillamount, pageadjamount, pagebalamount, pageaddamount, netbal
        Dim pageno, pagesize
        Try
            Call getdetails()
            If vrcount = 1 Then
                lettertype = "Subscription First Reminder Letter For :"
                addamt = 0
                vhead = "FIRST"
            ElseIf vrcount = 2 Then
                addamt = 100
                vhead = "SECOND"
                lettertype = "Subscription second Reminder Letter For :"
            ElseIf vrcount = 3 Then
                lettertype = "Subscription Third Reminder Letter For :"
                addamt = 0
                vhead = "THIRD"
            End If
            If valdata = False Then Exit Function
            ssql = "select a.mcode,a.mname,A.MID,isnull(A.contadd1,'') AS ADD1,ISNULL(A.CONTADD2,'') AS ADD2,ISNULL(A.CONTADD3,'') AS ADD3,ISNULL(A.CONTCITY,'') AS CITY,ISNULL(A.CONTSTATE,'') AS STATE,ISNULL(A.CONTCOUNTRY,'') AS COUNTRY,ISNULL(A.CONTPIN,'') AS PINCODE,ISNULL(A.CONTPHONE1,'') AS PHONE1,ISNULL(A.CONTPHONE2,'') AS PHONE2,ISNULL(A.CONTCELL,'') AS CELLNO,b.voucherno,b.voucherdate,b.amount,b.adjustedamount as adjamount,(b.amount-b.adjustedamount) as balamount from matching  b, membermaster a  where a.mcode=b.slcode and a.membertypecode in('" & vtype & "')"
            ssql = ssql & " and  b.Voucherdate>='" & vfdate & "' and b.voucherdate<='" & vtdate & "' and b.avoucherdate='" & vasdate & "' and slcode between '" & TXTMCODEFrom.Text & "' and  '" & TXTMCODETO.Text & "'"
            dt = Nothing
            dt = gconnection.GetValues(ssql)
            pageno = 1
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            Filewrite.WriteLine()
            pagesize = 5
            If dt.Rows.Count > 0 Then
                sno = 1
                For i = 0 To dt.Rows.Count - 1
                    If vrcount = 1 Then
                        Filewrite.WriteLine(Chr(18) & "From :")
                        Filewrite.WriteLine(Chr(27) + "E" & "The SECRETARY" & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(0), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(0), 1, 30))) & Space(25) & "Date      :" & vasdate & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(1), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(1), 1, 30))) & Space(25) & "Member No :" & dt.Rows(i).Item("mcode") & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(2), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(2), 1, 30))) & Space(25) & "Category  :" & vtypedesc & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(3), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(3), 1, 30))) & Chr(27) + "F")
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "FIRST REMINDER" & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "--------------" & Chr(27) + "F")
                        For j = 0 To 3
                            Filewrite.WriteLine("")
                        Next
                        Filewrite.WriteLine("TO,")
                        Filewrite.WriteLine(dt.Rows(i).Item("MID") & Space(1) & dt.Rows(i).Item("MNAME"))
                        Filewrite.WriteLine(dt.Rows(i).Item("add1"))
                        Filewrite.WriteLine(dt.Rows(i).Item("add2"))
                        Filewrite.WriteLine(dt.Rows(i).Item("add3"))
                        Filewrite.WriteLine(dt.Rows(i).Item("city") & " " & dt.Rows(i).Item("pincode"))
                        Filewrite.WriteLine(dt.Rows(i).Item("state") & Space(1) & dt.Rows(i).Item("COUNTRY"))
                        Filewrite.WriteLine("Tel.No :" & dt.Rows(i).Item("phone1") & Space(1) & dt.Rows(i).Item("phone2"))
                        For j = 0 To 5
                            Filewrite.WriteLine("")
                        Next
                        ssql = "select * From terminateletter where doctype='" & vhead & "' order by slno"
                        dt1 = Nothing
                        dt1 = gconnection.GetValues(ssql)
                        If dt1.Rows.Count > 0 Then
                            For j = 0 To dt1.Rows.Count - 1
                                If j + 1 = dt1.Rows.Count Then
                                    Filewrite.WriteLine(dt1.Rows(j).Item("message") & Space(1) & vfdate & " To " & vtdate)
                                Else
                                    Filewrite.WriteLine(dt1.Rows(j).Item("message"))
                                End If
                            Next
                            Filewrite.WriteLine("as per Bill No :" & Chr(27) & "E" & Trim(dt.Rows(i).Item("voucherno")) & " Bill Amount Rs." & Format(dt.Rows(i).Item("amount"), "0.00" & "  Paid Amount "))
                            Filewrite.WriteLine("Rs." & Format(dt.Rows(i).Item("adjamount"), "0.00") & " Due Amount Rs." & Format(dt.Rows(i).Item("balamount"), "0.00") & " is due from :" & vasdate & Chr(27) & "F")
                            For j = 0 To 5
                                Filewrite.WriteLine("")
                            Next
                            Filewrite.WriteLine(Space(40) & "For The CALCUTTA SWIMMING CLUB")
                            For j = 0 To 5
                                Filewrite.WriteLine("")
                            Next
                            Filewrite.WriteLine(Space(40) & "      SECRETARY")
                            Filewrite.WriteLine("")
                            Filewrite.WriteLine(StrDup(80, "-"))
                            Filewrite.WriteLine(Chr(27) + "E" & "If you have already paid please ignore this reminder." & Chr(27) + "F")
                            Filewrite.WriteLine(Chr(12))
                        End If
                    End If
                    If vrcount = 2 Then
                        'second letter
                        Filewrite.WriteLine(Chr(18) & "From :")
                        Filewrite.WriteLine("The SECRETARY")
                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(0), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(0), 1, 30))) & Space(25) & "Date      :" & vasdate & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(1), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(1), 1, 30))) & Space(25) & "Member No :" & dt.Rows(i).Item("mcode") & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(2), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(2), 1, 30))) & Space(25) & "Category  :" & vtypedesc & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(3), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(3), 1, 30))) & Chr(27) + "F")
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "SECOND REMINDER" & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "--------------" & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Space(15) & "Sub: Payment of subscription for the Month:" & Mid(Trim(vfdate), 4, 3) & "-" & Mid(Trim(vfdate), 8, 4) & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Space(15) & "Re : Bill No. :" & dt.Rows(i).Item("voucherno") & " Dated :" & vfdate & Chr(27) + "F")
                        For j = 0 To 3
                            Filewrite.WriteLine("")
                        Next
                        Filewrite.WriteLine("TO,")
                        Filewrite.WriteLine(dt.Rows(i).Item("MID") & Space(1) & dt.Rows(i).Item("MNAME"))
                        Filewrite.WriteLine(dt.Rows(i).Item("add1"))
                        Filewrite.WriteLine(dt.Rows(i).Item("add2"))
                        Filewrite.WriteLine(dt.Rows(i).Item("add3"))
                        Filewrite.WriteLine(dt.Rows(i).Item("city") & " " & dt.Rows(i).Item("pincode"))
                        Filewrite.WriteLine(dt.Rows(i).Item("state") & Space(1) & dt.Rows(i).Item("COUNTRY"))
                        Filewrite.WriteLine("Tel.No :" & dt.Rows(i).Item("phone1") & Space(1) & dt.Rows(i).Item("phone2"))
                        For j = 0 To 5
                            Filewrite.WriteLine("")
                        Next
                        ssql = "select * From terminateletter where doctype='" & vhead & "' order by slno"
                        dt1 = Nothing
                        dt1 = gconnection.GetValues(ssql)
                        If dt1.Rows.Count > 0 Then
                            For j = 0 To dt1.Rows.Count - 1
                                If InStr(CStr(dt1.Rows(j).Item("message")), "(DATE)") Then
                                    samt = Split(CStr(dt1.Rows(j).Item("message")), "(DATE)")
                                    ssql = Trim(samt(0)) & " " & Trim(vasdate) & " " & Trim(samt(1))
                                    Filewrite.WriteLine(ssql)
                                Else
                                    Filewrite.WriteLine(dt1.Rows(j).Item("message"))
                                End If
                            Next
                        End If
                        Filewrite.WriteLine(StrDup(80, "-"))
                        Filewrite.WriteLine(Chr(27) + "E" & "Bill No:" & Trim(dt.Rows(i).Item("voucherno")) & Space(5) & "Bill Period :" & Trim(vfdate) & Space(2) & "To" & Space(2) & Trim(vtdate) & Chr(27) + "F")
                        Filewrite.WriteLine(Space(10) & "................................................................")
                        ssql = "select isnull(slcode,'') as mocde,isnull(sldesc,'') as slname,isnull(accountcode,'') as accode,isnull(accountcodedesc,'') accdesc,isnull(description,'') as desc1,isnull(amount,0) as amount from journalentry where isnull(void,'')<>'Y' and creditdebit='DEBIT' and voucherdate<='" & vasdate & "' and slcode='" & dt.Rows(i).Item("mcode") & "'"
                        dt1 = Nothing
                        dt1 = gconnection.GetValues(ssql)
                        netbal = 0
                        If dt1.Rows.Count > 0 Then
                            For j = 0 To dt1.Rows.Count - 1
                                Filewrite.WriteLine(Space(10) & Mid(Trim(dt1.Rows(j).Item("desc1")), 1, 30) & Space(Len(Mid(Trim(dt1.Rows(j).Item("desc1")), 1, 30))) & Space(8 - Len(Format(dt1.Rows(j).Item("amount"), "0.00"))) & Format(dt1.Rows(j).Item("amount"), "0.00"))
                                netbal = netbal + Val(dt1.Rows(j).Item("amount"))
                            Next
                        End If
                        Filewrite.WriteLine(Space(10) & Mid(Trim("ADMINISTRATIVE CHARGES"), 1, 30) & Space(4) & Space(30 - Len(Mid(Trim("ADMINISTRATIVE CHARGES"), 1, 30))) & Space(8 - Len(Mid(Format(addamt, "0.00"), 1, 8))) & Mid(Format(addamt, "0.00"), 1, 8))
                        netbal = netbal + addamt
                        Filewrite.WriteLine(Space(40) & "-----------------")
                        Filewrite.WriteLine(Space(10) & "Total" & Space(29) & Space(8 - Len(Mid(Format(netbal, "0.00"), 1, 8))) & Mid(Format(netbal, "0.00"), 1, 8))
                        Filewrite.WriteLine(Space(40) & "-----------------")
                        netbal = netbal + addamt
                        Filewrite.WriteLine(Space(10) & "................................................................")
                        Filewrite.WriteLine(StrDup(80, "-") & Chr(12))
                    End If
                    If vrcount = 3 Then
                        'THIRD letter
                        Filewrite.WriteLine(Chr(18) & "From :")
                        Filewrite.WriteLine("The SECRETARY")
                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(0), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(0), 1, 30))) & Space(25) & "Date      :" & vasdate & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(1), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(1), 1, 30))) & Space(25) & "Member No :" & dt.Rows(i).Item("mcode") & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(2), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(2), 1, 30))) & Space(25) & "Category  :" & vtypedesc & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Mid(gCompanyAddress(3), 1, 30) & Space(30 - Len(Mid(gCompanyAddress(3), 1, 30))) & Chr(27) + "F")
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "POSTING LETTER" & Chr(27) + "F")
                        Filewrite.WriteLine(Chr(27) + "E" & Space(30) & "--------------" & Chr(27) + "F")
                        For j = 0 To 3
                            Filewrite.WriteLine("")
                        Next
                        Filewrite.WriteLine("TO,")
                        Filewrite.WriteLine(dt.Rows(i).Item("MID") & Space(1) & dt.Rows(i).Item("MNAME"))
                        Filewrite.WriteLine(dt.Rows(i).Item("add1"))
                        Filewrite.WriteLine(dt.Rows(i).Item("add2"))
                        Filewrite.WriteLine(dt.Rows(i).Item("add3"))
                        Filewrite.WriteLine(dt.Rows(i).Item("city") & " " & dt.Rows(i).Item("pincode"))
                        Filewrite.WriteLine(dt.Rows(i).Item("state") & Space(1) & dt.Rows(i).Item("COUNTRY"))
                        Filewrite.WriteLine("Tel.No :" & dt.Rows(i).Item("phone1") & Space(1) & dt.Rows(i).Item("phone2"))
                        For j = 0 To 5
                            Filewrite.WriteLine("")
                        Next
                        ssql = "select * From terminateletter where doctype='" & vhead & "' order by slno"
                        dt1 = Nothing
                        dt1 = gconnection.GetValues(ssql)
                        If dt1.Rows.Count > 0 Then
                            For j = 0 To dt1.Rows.Count - 1
                                If InStr(CStr(dt1.Rows(j).Item("message")), "(DATE)") Then
                                    samt = Split(CStr(dt1.Rows(j).Item("message")), "(DATE)")
                                    ssql = Trim(samt(0)) & " " & Trim(vasdate) & " " & Trim(samt(1))
                                    Filewrite.WriteLine(ssql)
                                Else
                                    Filewrite.WriteLine(dt1.Rows(j).Item("message"))
                                End If
                            Next
                        End If
                        Filewrite.WriteLine(StrDup(80, "-") & Chr(12))
                    End If
                Next i
            End If
            Filewrite.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End Try
        'If InStr(CStr(dt1.Rows(j).Item("message")), "(SAMT)") Then
        '    samt = Split(CStr(dt1.Rows(j).Item("message")), "(SAMT)")
        '    ssql = Space(2) & samt(0) & " Rs." & Format(dt.Rows(i).Item("ClosingBalance"), "0.00") & " " & samt(1)
        '    Filewrite.WriteLine(ssql)
        '    psize = psize + 1
        'Else
        '    Filewrite.WriteLine(Space(2) & dt1.Rows(j).Item("message") & "")
        '    psize = psize + 1
        'End If
        If PRINTREP = False Then
            OpenTextFile(vOutfile)
        Else
            PrintTextFile(vOutfile)
        End If
    End Function
    Private Sub cmdexit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdexit.Click
        Me.Hide()
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        PRINTREP = True
        If RBTREMINDERLETTER.Checked = True Then
            Call details()
        Else
            Call SUMMARY()
        End If
    End Sub
    Private Sub TXTMCODEFrom_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTMCODEFrom.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call cmd_MCodefromHelp_Click(sender, e)
            TXTMCODETO.Focus()
        End If
    End Sub
    Private Sub TXTMCODEFrom_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTMCODEFrom.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_MCodefromHelp_Click(sender, e)
            TXTMCODETO.Focus()
        End If
    End Sub
    Private Sub TXTMCODETO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTMCODETO.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call cmd_MCodeToHelp_Click(sender, e)
            CmdView.Focus()
        End If
    End Sub
    Private Sub TXTMCODETO_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TXTMCODETO.KeyDown
        If e.KeyCode = Keys.F4 Then
            Call cmd_MCodeToHelp_Click(sender, e)
            CmdView.Focus()
        End If
    End Sub
End Class
