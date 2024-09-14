Imports System.IO
Imports System.Data.SqlClient
Public Class ReportDesigner
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
    Friend WithEvents SsGridReport As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Cmd_View As System.Windows.Forms.Button
    Friend WithEvents Cmd_Print As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ReportDesigner))
        Me.SsGridReport = New AxFPSpreadADO.AxfpSpread
        Me.Label1 = New System.Windows.Forms.Label
        Me.Cmd_View = New System.Windows.Forms.Button
        Me.Cmd_Print = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.SsGridReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SsGridReport
        '
        Me.SsGridReport.DataSource = Nothing
        Me.SsGridReport.Location = New System.Drawing.Point(144, 64)
        Me.SsGridReport.Name = "SsGridReport"
        Me.SsGridReport.OcxState = CType(resources.GetObject("SsGridReport.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SsGridReport.Size = New System.Drawing.Size(512, 248)
        Me.SsGridReport.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(272, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "REPORT DESIGNER"
        '
        'Cmd_View
        '
        Me.Cmd_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_View.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_View.ForeColor = System.Drawing.Color.White
        Me.Cmd_View.Image = CType(resources.GetObject("Cmd_View.Image"), System.Drawing.Image)
        Me.Cmd_View.Location = New System.Drawing.Point(224, 328)
        Me.Cmd_View.Name = "Cmd_View"
        Me.Cmd_View.Size = New System.Drawing.Size(96, 32)
        Me.Cmd_View.TabIndex = 2
        Me.Cmd_View.Text = "Generate View"
        '
        'Cmd_Print
        '
        Me.Cmd_Print.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cmd_Print.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Print.ForeColor = System.Drawing.Color.White
        Me.Cmd_Print.Image = CType(resources.GetObject("Cmd_Print.Image"), System.Drawing.Image)
        Me.Cmd_Print.Location = New System.Drawing.Point(352, 328)
        Me.Cmd_Print.Name = "Cmd_Print"
        Me.Cmd_Print.Size = New System.Drawing.Size(103, 32)
        Me.Cmd_Print.TabIndex = 3
        Me.Cmd_Print.Text = "Give Print"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(496, 328)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 32)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Exit"
        '
        'ReportDesigner
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(798, 382)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Cmd_Print)
        Me.Controls.Add(Me.Cmd_View)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SsGridReport)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ReportDesigner"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Designer (Design And Developed By Database Software,Chennai)"
        CType(Me.SsGridReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim vconn As New GlobalClass
    Dim colomns As String
    Dim sizes As String
    Private Sub Cmd_View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_View.Click
        Dim chk As Boolean
        Dim getcheck As Object
        Dim i, j, cnt, totsize As Integer
        Dim col, tab, size, ssql, caption, Order, PRE, NEWS, DESC, COU, STA, CIT As String
        PRE = "PREVIOUS STATUS"
        NEWS = "NEW STATUS"
        DESC = "DESCRIPTION"
        COU = "COUNTRY"
        STA = "STATE"
        CIT = "CITY"
        i = 1
        j = 1
        cnt = 0
        For i = 1 To Me.SsGridReport.DataRowCnt
            SsGridReport.Col = 1
            SsGridReport.Row = i
            getcheck = SsGridReport.Text
            If Val(getcheck) = 1 Then
                If colomns = "" Then
                    SsGridReport.Col = 2
                    SsGridReport.Row = i
                    col = SsGridReport.Text
                    SsGridReport.Col = 3
                    SsGridReport.Row = i
                    size = SsGridReport.Text
                    totsize = totsize + Val(SsGridReport.Text)
                    SsGridReport.Col = 4
                    SsGridReport.Row = i
                    If Trim(SsGridReport.Text) = "" Then
                        If col = "Membertype" And Gheader = "MEMBER CATEGORY MASTER" Then
                            caption = "Category Code"
                        ElseIf col = "CMCorporateCode" And Gheader = "CORPORATE MASTER" Then
                            caption = "Corporate Code"
                        Else
                            caption = col
                        End If

                    Else
                            caption = SsGridReport.Text
                        End If
                        SsGridReport.Col = 5
                        SsGridReport.Row = i
                        If Val(SsGridReport.Text) <> 0 Then
                            Order = SsGridReport.Text
                        End If
                        colomns = colomns & col
                        col = ""
                        cnt = cnt + 1
                    Else
                    SsGridReport.Col = 2
                    SsGridReport.Row = i
                    col = SsGridReport.Text
                    colomns = colomns & "," & col
                    SsGridReport.Col = 3
                    SsGridReport.Row = i
                    totsize = totsize + Val(SsGridReport.Text)
                    size = size & "," & SsGridReport.Text
                    SsGridReport.Col = 4
                    SsGridReport.Row = i
                    If Trim(SsGridReport.Text) = "" Then

                        If col = "PRESENTSTATUS" And Gheader = "STATUS CONVERSION LIST" Then
                            caption = caption & "," & PRE
                        ElseIf Gheader = "STATUS CONVERSION LIST" And col = "MNAME" Then
                            caption = caption & ",NAME"
                        ElseIf col = "NEWSTATUS" And Gheader = "STATUS CONVERSION LIST" Then
                            caption = caption & "," & NEWS
                        ElseIf col = "NAME" And Gheader = "MARITAL STATUS MASTER VIEW" Then
                            caption = caption & "," & DESC
                        ElseIf col = "NAME" And Gheader = "SALUTATION MASTER VIEW" Then
                            caption = caption & "," & DESC
                        ElseIf col = "NAME" And Gheader = "STATUS MASTER VIEW" Then
                            caption = caption & "," & DESC
                        ElseIf col = "NAME" And Gheader = "RELIGION MASTER VIEW" Then
                            caption = caption & "," & DESC
                        ElseIf col = "NAME" And Gheader = "DESIGNATION MASTER VIEW" Then
                            caption = caption & "," & DESC
                        ElseIf col = "NAME" And (Gheader = "PROFESSIONAL MASTER VIEW" Or Gheader = "REASON MASTER VIEW") Then
                            caption = caption & "," & DESC
                        ElseIf col = "NAME" And Gheader = "COUNTRY MASTER VIEW" Then
                            caption = caption & "," & COU
                        ElseIf col = "NAME" And Gheader = "STATE MASTER VIEW" Then
                            caption = caption & "," & STA
                        ElseIf col = "NAME" And Gheader = "CITY MASTER VIEW" Then
                            caption = caption & "," & CIT
                        ElseIf col = "Membertype" And Gheader = "MEMBER CATEGORY MASTER" Then
                            caption = caption & ",Category Code"
                            'caption = caption & "," & col
                        ElseIf col = "TypeDesc" And Gheader = "MEMBER CATEGORY MASTER" Then
                            caption = caption & ",Category Name"
                        ElseIf Gheader = "CORPORATE MASTER" And col = "CMCorporateCode" Then
                            caption = caption & ",CorporateCode"
                        ElseIf Gheader = "CORPORATE MASTER" And col = "CMCorporateName" Then
                            caption = caption & ",CorporateName"
                        ElseIf Gheader = "CORPORATE MASTER" And col = "MemberShipFrom" Then
                            caption = caption & ",From Date"
                        ElseIf Gheader = "CORPORATE MASTER" And col = "MemberShipTo" Then
                            caption = caption & ",To Date"
                        ElseIf Gheader = "CORPORATE MASTER" And col = "CurrentStatus" Then
                            caption = caption & ",Status"
                        ElseIf Gheader = "CORPORATE MASTER" And col = "CMNomembers" Then
                            caption = caption & ",No_of_Members"
                        ElseIf Gheader = "CORPORATE MASTER" And col = "CMAddress1" Then
                            caption = caption & ",Address1"
                        ElseIf Gheader = "CORPORATE MASTER" And col = "CMAddress2" Then
                            caption = caption & ",Address2"
                        ElseIf Gheader = "CORPORATE MASTER" And col = "CMAddress3" Then
                            caption = caption & ",Address3"
                        ElseIf Gheader = "CORPORATE MASTER" And col = "CMCountry" Then
                            caption = caption & ",Country"
                        ElseIf Gheader = "CORPORATE MASTER" And col = "CMCity" Then
                            caption = caption & ",City"
                        ElseIf Gheader = "CORPORATE MASTER" And col = "CMState" Then
                            caption = caption & ",State"
                        ElseIf Gheader = "CORPORATE MASTER" And col = "CMPin" Then
                            caption = caption & ",Pin Code"
                        Else
                            caption = caption & "," & col
                        End If
                    Else
                        caption = caption & "," & SsGridReport.Text
                    End If


                    'End If
                    'SsGridReport.Col = 5
                    'SsGridReport.Row = i
                    'If Val(SsGridReport.Text) <> 0 Then
                    '    Order = Order & "," & SsGridReport.Text
                    'End If
                    'col = ""
                    cnt = cnt + 1
                End If
            End If
            getcheck = ""
        Next i
        If colomns = "" Then
            'MsgBox("No Fields Has Been Selected")
            Exit Sub
        End If
        If tables = "" Then Exit Sub
        ssql = " Select " & colomns & " " & tables
        'MsgBox(size)
        'MsgBox(ssql)
        colomns = ""
        gPrint = False
        PrintOperation(ssql, size, caption, totsize, cnt, Order)
    End Sub
    Sub PrintOperation(ByVal sql As String, ByVal size As String, ByVal caption As String, ByVal totsize As Integer, ByVal cnt As Integer, ByVal Order As String)
        Randomize()
        Dim rowj As Integer
        Dim ssql As String
        Dim vCaption As String
        Dim Loopindex, i As Integer
        Dim vPath As String
        Dim str As String
        Dim Fsize() As String
        Dim Forder() As String
        Dim vFilepath As String
        Dim Filewrite As StreamWriter
        Dim vOutfile, vheader, vline As String
        Dim vpagenumber As Long
        Dim Vrowcount As Long
        Dim in1 As Integer
        Dim CountItem As Integer
        Dim Fo As Integer
        Try
            vpagenumber = 1
            If Directory.Exists(AppPath & "\Reports") = True Then
            Else
                Directory.CreateDirectory(AppPath & "Reports")
            End If
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = AppPath & "\Reports\" & vOutfile & ".txt"
            If Trim(Order) <> "" Then
                Forder = Order.Split(",")
                Forder.Sort(Forder)
                Order = ""
            End If
            vconn.getDataSet(sql, "ReportTable")
            If gdataset.Tables("ReportTable").Rows.Count > 0 Then
                Filewrite = File.AppendText(vFilepath)
                vline = "----"
                For i = 1 To totsize
                    vline = vline & "-"
                Next
                For rowj = 0 To gdataset.Tables("ReportTable").Rows.Count - 1
                    If Vrowcount = 0 Then
                        If totsize > 80 Then
                            Filewrite.Write(Chr(15))
                        Else
                            Filewrite.Write(Chr(18))
                        End If
                        'vheader = Chr(14) & Chr(15) & Space((totsize / 2) - (Len(gCompanyname) / 2)) & gCompanyname
                        vheader = Chr(27) + "E" & gCompanyAddress(0) & Chr(27) + "F"
                        'Filewrite.WriteLine(vheader)
                        'vheader = Space((totsize / 2) - (Len(Gheader) / 2)) & Gheader
                        Filewrite.WriteLine(vheader)
                        Filewrite.WriteLine(Gheader)
                        If Val(totsize) > 21 Then
                            ssql = "Date: " & Format(Now, "dd/MM/yyyy")
                        Else
                            ssql = "Date: " & Format(Now, "dd/MM/yyyy")
                        End If
                        If Val(totsize) > 21 Then
                            ssql = ssql & Space(totsize - 35) & "Page Number: " & vpagenumber
                        Else
                            ssql = ssql & Space(totsize - 35) & "Page Number: " & vpagenumber
                        End If
                        Filewrite.WriteLine(ssql)
                        Filewrite.WriteLine(vline)
                        ssql = "||"
                        Dim arr() As String
                        arr = caption.Split(",")
                        ssql = ""
                        Fsize = size.Split(",")
                        For in1 = 0 To arr.Length - 1
                            ssql = ssql & Mid(Trim(arr(in1) & ""), 1, Val(Fsize(in1))) & Space(Val(Fsize(in1) + 1) - Len(Mid(Trim(arr(in1) & ""), 1, Val(Fsize(in1)))))
                        Next
                        Filewrite.WriteLine(ssql)
                        Filewrite.WriteLine(vline)
                        Vrowcount = 8
                    End If
                    With gdataset.Tables("ReportTable").Rows(rowj)
                        ssql = ""
                        While CountItem <= cnt - 1
                            'If Val((.Item(CountItem))) = 0 Then
                            ssql = ssql & Mid(Trim(.Item(CountItem) & ""), 1, Val(Fsize(CountItem))) & Space(Val(Fsize(CountItem) + 1) - Len(Mid(Trim(.Item(CountItem) & ""), 1, Val(Fsize(CountItem)))))
                            'Else
                            'ssql = ssql & Space(Val(Fsize(CountItem) + 1) - Len(Mid(Trim(.Item(CountItem) & ""), 1, Val(Fsize(CountItem))))) & Mid(Trim(.Item(CountItem) & ""), 1, Val(Fsize(CountItem)))
                            'End If
                            CountItem = CountItem + 1
                        End While
                        Filewrite.WriteLine(ssql)
                        ssql = ""
                        CountItem = 0
                        Vrowcount = Vrowcount + 1

                    End With
                    If Vrowcount > 55 Then
                        Filewrite.WriteLine(vline)
                        Filewrite.WriteLine("User Name: " & gUsername & Space(35) & "Date :" & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
                        Vrowcount = 0
                        vpagenumber = Val(vpagenumber) + 1
                    End If
                Next
                Filewrite.WriteLine(vline)
                Filewrite.WriteLine("User Name: " & gUsername & Space(30) & "Date :" & Format(Date.Now, "dd/MM/yyyy") & Chr(12))
                'Filewrite.WriteLine("The Software Is Designed And Developed By DATABASE SOFTWARE,Chennai")
                'Filewrite.WriteLine("To Know Abt DBS Pls Mail at :- info@databasesoftware.in")
                Filewrite.Close()
                If gPrint = True Then
                    PrintTextFile(vOutfile)
                Else
                    OpenTextFile(vOutfile)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Address1)
            Exit Sub
        End Try
    End Sub
    Private Sub Cmd_Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Print.Click
        Dim chk As Boolean
        Dim getcheck As Object
        Dim i, j, cnt, totsize As Integer
        Dim col, tab, size, ssql, caption, Order As String
        i = 1
        j = 1
        cnt = 0
        For i = 1 To Me.SsGridReport.DataRowCnt
            SsGridReport.Col = 1
            SsGridReport.Row = i
            getcheck = SsGridReport.Text
            If Val(getcheck) = 1 Then
                If colomns = "" Then
                    SsGridReport.Col = 2
                    SsGridReport.Row = i
                    col = SsGridReport.Text
                    SsGridReport.Col = 3
                    SsGridReport.Row = i
                    size = SsGridReport.Text
                    totsize = totsize + Val(SsGridReport.Text)
                    SsGridReport.Col = 4
                    SsGridReport.Row = i
                    If Trim(SsGridReport.Text) = "" Then
                        caption = col
                    Else
                        caption = SsGridReport.Text
                    End If
                    SsGridReport.Col = 5
                    SsGridReport.Row = i
                    If Val(SsGridReport.Text) <> 0 Then
                        Order = SsGridReport.Text
                    End If
                    colomns = colomns & col
                    col = ""
                    cnt = cnt + 1
                Else
                    SsGridReport.Col = 2
                    SsGridReport.Row = i
                    col = SsGridReport.Text
                    colomns = colomns & "," & col
                    SsGridReport.Col = 3
                    SsGridReport.Row = i
                    totsize = totsize + Val(SsGridReport.Text)
                    size = size & "," & SsGridReport.Text
                    SsGridReport.Col = 4
                    SsGridReport.Row = i
                    If Trim(SsGridReport.Text) = "" Then
                        caption = caption & "," & col
                    Else
                        caption = caption & "," & SsGridReport.Text
                    End If
                    'SsGridReport.Col = 5
                    'SsGridReport.Row = i
                    'If Val(SsGridReport.Text) <> 0 Then
                    '    Order = Order & "," & SsGridReport.Text
                    'End If
                    'col = ""
                    cnt = cnt + 1
                End If
            End If
            getcheck = ""
        Next i
        If colomns = "" Then
            'MsgBox("No Fields Has Been Selected")
            Exit Sub
        End If
        If tables = "" Then Exit Sub
        ssql = " Select " & colomns & " " & tables
        'MsgBox(size)
        'MsgBox(ssql)
        colomns = ""
        gPrint = False
        PrintOperation(ssql, size, caption, totsize, cnt, Order)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ReportDesigner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SsGridReport_KeyDown(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles SsGridReport.KeyDownEvent
        Dim I As Integer
        Try
            If e.keyCode = 13 Then
                With SsGridReport
                    If .ActiveCol = 1 Then
                        .SetActiveCell(1, .ActiveRow + 1)
                    End If
                End With
            ElseIf e.keyCode = Keys.F2 Then
                With SsGridReport
                    For I = 0 To Me.SsGridReport.DataRowCnt
                        'For I = 0 To Me.DataRowCnt
                        .Col = 1
                        .SetText(1, I, 1)
                    Next
                End With
            ElseIf e.keyCode = Keys.F3 Then
                With SsGridReport
                    For I = 0 To Me.SsGridReport.DataRowCnt
                        .Col = 1
                        .SetText(1, I, 0)
                    Next
                End With
            End If

        Catch ex As Exception
        End Try
        'Dim I As Integer
        '    SELECT_GRID = SsGridReport
        'Try
        '    If e.keyCode = 13 Then
        '        With SsGridReport
        '            If .ActiveCol = 3 Then
        '                .SetActiveCell(3, .ActiveRow + 1)
        '            End If
        '        End With
        '    ElseIf e.keyCode = Keys.F2 Then
        '        With SsGridReport
        '            For I = 1 To .DataRowCnt
        '                .Col = 3
        '                .SetText(3, I, 1)
        '            Next
        '        End With
        '    End If
        'Catch ex As Exception
        '    'End Try
    End Sub

    Private Sub SsGridReport_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles SsGridReport.Advance

    End Sub
End Class
