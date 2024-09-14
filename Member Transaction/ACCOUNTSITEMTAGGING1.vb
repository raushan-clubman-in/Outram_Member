Public Class ACCOUNTSITEMTAGGING1

    Inherits System.Windows.Forms.Form
    Dim Vconn As New GlobalClass
    Dim SQLSTRING As String
    Friend WithEvents SSMatching As AxFPSpreadADO.AxfpSpread
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ssgrid1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents cmd_update As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ACCOUNTSITEMTAGGING1))
        Me.ssgrid1 = New AxFPSpreadADO.AxfpSpread
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.cmd_update = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ssgrid1
        '
        Me.ssgrid1.DataSource = Nothing
        Me.ssgrid1.Location = New System.Drawing.Point(160, 88)
        Me.ssgrid1.Name = "ssgrid1"
        Me.ssgrid1.OcxState = CType(resources.GetObject("ssgrid1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ssgrid1.Size = New System.Drawing.Size(504, 392)
        Me.ssgrid1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(120, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Clear"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(120, 8)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 32)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "View"
        Me.Button2.Visible = False
        '
        'cmd_update
        '
        Me.cmd_update.BackgroundImage = CType(resources.GetObject("cmd_update.BackgroundImage"), System.Drawing.Image)
        Me.cmd_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmd_update.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_update.ForeColor = System.Drawing.Color.White
        Me.cmd_update.Location = New System.Drawing.Point(224, 8)
        Me.cmd_update.Name = "cmd_update"
        Me.cmd_update.Size = New System.Drawing.Size(88, 32)
        Me.cmd_update.TabIndex = 1
        Me.cmd_update.Text = "Update"
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(336, 8)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(88, 32)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = "Exit"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.cmd_update)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(144, 488)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(520, 56)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(320, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "MONTH BILL TAGGING"
        '
        'ACCOUNTSITEMTAGGING1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 670)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ssgrid1)
        Me.Name = "ACCOUNTSITEMTAGGING1"
        Me.Text = "MONTH BILL TAGGING"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ssgrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ACCOUNTSITEMTAGGING1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i, j As Integer
        SQLSTRING = "select NAME,DESCRIPTION,isnull(ORDER_NO,0) as ORDERNO  from OUTSTANDESIGN  order by ORDER_NO "
        Vconn.getDataSet(SQLSTRING, "acctag")
        If gdataset.Tables("acctag").Rows.Count > 0 Then
            For i = 0 To gdataset.Tables("acctag").Rows.Count - 1
                j = i + 1
                With ssgrid1
                    .Row = j
                    .Col = 1
                    .Text = gdataset.Tables("acctag").Rows(i).Item("NAME")
                    .Col = 2
                    .Text = gdataset.Tables("acctag").Rows(i).Item("DESCRIPTION")
                    .Col = 4
                    .Text = gdataset.Tables("acctag").Rows(i).Item("ORDERNO")
                  
                End With
                ssgrid1.MaxRows = ssgrid1.MaxRows + 1
            Next
        End If
    End Sub
    Private Sub SSMatching_DblClick(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_DblClickEvent) Handles SSMatching.DblClick



    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub ssgrid1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles ssgrid1.Advance

    End Sub

    'Private Sub ssgrid1_DblClick(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_DblClickEvent) Handles ssgrid1.DblClick
    '    Dim ssql As String
    '    Dim itemcode, itemdesc As String

    '    With ssgrid1
    '        .Col = 1
    '        .Row = .ActiveRow
    '        itemcode = .Text
    '        .Col = 2
    '        .Row = .ActiveRow
    '        itemdesc = .Text
    '    End With
    '    SQLSTRING = "select a.itemcode,a.itemdesc ,isnull(a.salesacctin,'') as accode,isnull(b.acdesc,'') as acdesc  from itemmaster a left outer join accountsglaccountmaster b on a.salesacctin=b.accode where isnull(a.freeze,'')<>'Y' and isnull(b.freezeflag,'')<>'Y' order by b.acdesc,a.itemcode "
    '    Vconn.getDataSet(SQLSTRING, "acctag")

    '    If gdataset.Tables("acctag").Rows.Count = 0 Then
    '        Exit Sub
    '    End If
    '    If gdataset.Tables("acctag").Rows.Count > 1 Then
    '        Exit Sub
    '    End If
    'End Sub

    Private Sub ssgrid1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles ssgrid1.KeyDownEvent
        With ssgrid1
            If .ActiveCol = 1 Then
                .Row = .ActiveRow
                If .Text = "" Then
                    Call FillMenu()
                End If
            End If
            'If .Col = 4 Then
            '    .Row = .ActiveRow
            '    If .Text = "" Then
            '        Call FillMenu()
            '    End If
            'End If
        End With
    End Sub
    Private Sub FillMenu()
        Dim vform As New ListOperation
        Dim ssql As String
        '''******************************************************** $ FILL THE ITEMCODE,ITEMDESC INTO SSGRID ********** 
        gSQLString = "select GROUPCODE,GROUPDESC from ACCOUNT_TAGGING "
        'gSQLString = gSQLString & "UNION ALL select SUBSCODE AS GROUPCODE ,SUBSDESC AS GROUPDESC FROM subscriptionmast "

        'gSQLString = "SELECT DISTINCT I.ITEMCODE,I.ITEMDESC,I.BASERATESTD,I.ITEMTYPECODE,TL.TAXCODE,TL.TAXPERCENTAGE, ISNULL(TL.ACCOUNTCODE,'') "
        'gSQLString = gSQLString & " AS ACCOUNTCODE,ISNULL(I.GROUPCODE,'') AS GROUPCODE,ISNULL(I.OPENFACILITY,'') AS OPENFACILITY,ISNULL(I.SALESACCTIN,'') AS SALESACCTIN FROM VIEW_ITEMMASTER AS I INNER "
        'gSQLString = gSQLString & " JOIN TAXITEMLINK AS TL ON TL.ITEMTYPECODE = I.ITEMTYPECODE "
        If Trim(Search) = " " Then
            M_WhereCondition = " "
        Else
            M_WhereCondition = " WHERE (GROUPCODE LIKE '%" & Search & "%' OR GROUPDESC LIKE '%" & Search & "%') "
        End If
        vform.Field = "GROUPCODE,GROUPDESC"
        vform.vFormatstring = "GROUPCODE     |GROUPDESC                        "
        vform.vCaption = "GROUP CODE HELP"
        vform.KeyPos = 0
        vform.KeyPos1 = 1

        vform.ShowDialog(Me)
        If Trim(vform.keyfield & "") <> "" Then
            With ssgrid1
                '.Col = 1
                '.Row = .ActiveRow
                '.Text = vform.keyfield
                .Col = 1
                .Row = .ActiveRow
                .Text = vform.keyfield
                .Col = 2
                .Row = .ActiveRow
                .Text = vform.keyfield1

            End With
        Else
            ssgrid1.SetActiveCell(0, ssgrid1.ActiveRow)
            Exit Sub
        End If
    End Sub


    Private Sub cmd_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_update.Click
        Dim i, COUNT As Integer
        Dim itemcd, DESC, ssql As String
        If ssgrid1.DataRowCnt <= 0 Then
            MsgBox("NO RECORD TO SAVE")
            Exit Sub
        End If
        ssql = "delete from OUTSTANDESIGN"
        Vconn.dataOperation(6, ssql, "item")

        With ssgrid1
            For i = 0 To ssgrid1.DataRowCnt - 1
                .Row = i + 1
                .Col = 1
                itemcd = .Text
                .Col = 2
                DESC = .Text
                .Col = 4
                COUNT = Val(.Text)
                ssql = "INSERT INTO OUTSTANDESIGN VALUES('" & itemcd & "','" & DESC & "'," & COUNT & ")"
                Vconn.dataOperation(6, ssql, "item")

            Next
        End With
        MessageBox.Show("Record Saved Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ssgrid1.ClearRange(1, 1, ssgrid1.DataColCnt, ssgrid1.DataRowCnt, False)
        Call ACCOUNTSITEMTAGGING1_Load(sender, e)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
