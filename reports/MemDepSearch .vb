Imports System.IO
Imports System.Data.SqlClient
Public Class TableWiseItemList
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnview As System.Windows.Forms.Button
    Friend WithEvents dtp_KOTdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBL_MCODE As System.Windows.Forms.Label
    Friend WithEvents LBL_MNAME As System.Windows.Forms.Label
    Friend WithEvents txt_TableNo As System.Windows.Forms.TextBox
    Friend WithEvents SSGRID As AxFPSpreadADO.AxfpSpread
    Friend WithEvents srch_by As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_clear As System.Windows.Forms.Button
    Public WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TableWiseItemList))
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnview = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.dtp_KOTdate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.LBL_MCODE = New System.Windows.Forms.Label
        Me.LBL_MNAME = New System.Windows.Forms.Label
        Me.txt_TableNo = New System.Windows.Forms.TextBox
        Me.SSGRID = New AxFPSpreadADO.AxfpSpread
        Me.srch_by = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmd_clear = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        CType(Me.SSGRID, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(40, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(160, 32)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Enter Search Content :"
        '
        'btnview
        '
        Me.btnview.BackgroundImage = CType(resources.GetObject("btnview.BackgroundImage"), System.Drawing.Image)
        Me.btnview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnview.Location = New System.Drawing.Point(480, 136)
        Me.btnview.Name = "btnview"
        Me.btnview.Size = New System.Drawing.Size(80, 32)
        Me.btnview.TabIndex = 13
        Me.btnview.Text = "View[F7]"
        '
        'btnExit
        '
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(656, 136)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 32)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit[F11]"
        '
        'dtp_KOTdate
        '
        Me.dtp_KOTdate.CustomFormat = "dd/MM/yyyy"
        Me.dtp_KOTdate.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_KOTdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_KOTdate.Location = New System.Drawing.Point(24, 56)
        Me.dtp_KOTdate.Name = "dtp_KOTdate"
        Me.dtp_KOTdate.Size = New System.Drawing.Size(144, 26)
        Me.dtp_KOTdate.TabIndex = 15
        Me.dtp_KOTdate.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "DATE    :"
        Me.Label1.Visible = False
        '
        'LBL_MCODE
        '
        Me.LBL_MCODE.BackColor = System.Drawing.Color.Transparent
        Me.LBL_MCODE.ForeColor = System.Drawing.Color.Red
        Me.LBL_MCODE.Location = New System.Drawing.Point(584, 88)
        Me.LBL_MCODE.Name = "LBL_MCODE"
        Me.LBL_MCODE.Size = New System.Drawing.Size(120, 32)
        Me.LBL_MCODE.TabIndex = 17
        Me.LBL_MCODE.Visible = False
        '
        'LBL_MNAME
        '
        Me.LBL_MNAME.BackColor = System.Drawing.Color.Transparent
        Me.LBL_MNAME.ForeColor = System.Drawing.Color.Red
        Me.LBL_MNAME.Location = New System.Drawing.Point(584, 24)
        Me.LBL_MNAME.Name = "LBL_MNAME"
        Me.LBL_MNAME.Size = New System.Drawing.Size(240, 32)
        Me.LBL_MNAME.TabIndex = 18
        Me.LBL_MNAME.Visible = False
        '
        'txt_TableNo
        '
        Me.txt_TableNo.BackColor = System.Drawing.Color.White
        Me.txt_TableNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_TableNo.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_TableNo.Location = New System.Drawing.Point(232, 136)
        Me.txt_TableNo.MaxLength = 50
        Me.txt_TableNo.Name = "txt_TableNo"
        Me.txt_TableNo.Size = New System.Drawing.Size(216, 29)
        Me.txt_TableNo.TabIndex = 42
        Me.txt_TableNo.Text = ""
        '
        'SSGRID
        '
        Me.SSGRID.DataSource = Nothing
        Me.SSGRID.Location = New System.Drawing.Point(16, 184)
        Me.SSGRID.Name = "SSGRID"
        Me.SSGRID.OcxState = CType(resources.GetObject("SSGRID.OcxState"), System.Windows.Forms.AxHost.State)
        Me.SSGRID.Size = New System.Drawing.Size(752, 424)
        Me.SSGRID.TabIndex = 615
        '
        'srch_by
        '
        Me.srch_by.Items.AddRange(New Object() {"Member Name", "Spouse Name", "Dependent Name", "Address", "Place\City"})
        Me.srch_by.Location = New System.Drawing.Point(232, 88)
        Me.srch_by.Name = "srch_by"
        Me.srch_by.Size = New System.Drawing.Size(216, 24)
        Me.srch_by.TabIndex = 617
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(112, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 24)
        Me.Label2.TabIndex = 616
        Me.Label2.Text = "Search By  :"
        '
        'cmd_clear
        '
        Me.cmd_clear.BackgroundImage = CType(resources.GetObject("cmd_clear.BackgroundImage"), System.Drawing.Image)
        Me.cmd_clear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clear.Location = New System.Drawing.Point(568, 136)
        Me.cmd_clear.Name = "cmd_clear"
        Me.cmd_clear.Size = New System.Drawing.Size(80, 32)
        Me.cmd_clear.TabIndex = 618
        Me.cmd_clear.Text = "Clear[F6]"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(304, 8)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(230, 31)
        Me.Label13.TabIndex = 833
        Me.Label13.Text = "MEMBER SEARCH"
        '
        'TableWiseItemList
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(7, 15)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 630)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txt_TableNo)
        Me.Controls.Add(Me.cmd_clear)
        Me.Controls.Add(Me.srch_by)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SSGRID)
        Me.Controls.Add(Me.LBL_MNAME)
        Me.Controls.Add(Me.LBL_MCODE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtp_KOTdate)
        Me.Controls.Add(Me.btnview)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Name = "TableWiseItemList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MemberSearch"
        CType(Me.SSGRID, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim vconn As New GlobalClass
    Dim strSql, SSql(1) As String
    Dim sqlCmd As New SqlCommand
    Dim sqlCon As New SqlConnection
    Dim gconnection As New GlobalClass
    Dim pageno, pagesize As Integer
    'Dim gconnection As New GlobalClass
    Dim dr As DataRow




    Private Sub itemwisesaleregister()
        Dim i As Integer
        Dim posdesc(), groupcode(), itemcode(), sqlstring As String
        Dim POSDESC2(), GROUPDESC2(), code(), CODEPOS() As String
        Dim sqlstringCancel As String


        sqlstring = " SELECT K.mcode,k.tableno,k.mname,k.Kotdetails,d.Kotdate,d.itemcode,d.itemdesc,d.qty,d.rate,d.amount FROM Kot_Hdr k inner join kot_det d on d.kotdetails=k.kotdetails"
        sqlstring = sqlstring & " WHERE k.tableno ='" & Trim(Me.txt_TableNo.Text) & "' AND  k.Billstatus='PO' And isnull(k.DELFLAG,'') <> 'Y' And ISNULL(k.Manualbillstatus,'')<> 'Y'  "
        sqlstring = sqlstring & " and CAST(Convert(varchar(11),k.KOTDATE,6) AS DATETIME)= '" & Format(dtp_KOTdate.Value, "dd-MMM-yyyy") & "' "
        ' sqlstring = sqlstring & " '" & Format(mskFromDate.Value, "dd/MMM/yyyy") & "' AND ' " & Format(mskToDate.Value, "dd/MMM/yyyy") & "'"


        sqlstring = sqlstring & " ORDER BY k.Kotdetails"
        Dim heading() As String = {"SALES REGISTER-DEPARTMENTWISE", "ALL"}
        'Dim objSaleregistersummary As New rptSaleregistersummary
        Call Detailsection(sqlstring)
        'objSaleregistersummary.Detailsection_DEPT(sqlstring, heading, mskFromDate.Value, mskToDate.Value)

    End Sub

    Private Sub btnview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnview.Click
        SSGRID.ClearRange(1, 1, -1, -1, True)
        If srch_by.Text = "Member Name" Then
            Call MemberNameSearch()
        ElseIf srch_by.Text = "Spouse Name" Then
            Call SpouseNameSearch()
        ElseIf srch_by.Text = "Dependent Name" Then
            Call dependentNameSearch()
        ElseIf srch_by.Text = "Society No" Then
            Call SocietyNoSearch()
        ElseIf srch_by.Text = "Plot No" Then
            Call PlotNoSearch()
        ElseIf srch_by.Text = "Address" Then
            Call addressSearch()
        ElseIf srch_by.Text = "Place\City" Then
            Call PlaceCitySearch()
        End If
    End Sub



    Private Sub MemberNameSearch()
        Dim i, j As Integer
        Dim posdesc(), groupcode(), itemcode(), sqlstring As String
        Dim POSDESC2(), GROUPDESC2(), code(), CODEPOS() As String
        Dim sqlstringCancel As String
        sqlstring = "select msorderno,mcode,mname,Membertypecode,curentstatus,ISNULL(CONTADD1,'') AS CONTADD1,ISNULL(CONTADD2,'') AS CONTADD2,ISNULL(CONTADD3,'') AS CONTADD3,ISNULL(CONTCITY,'') AS CONTCITY,ISNULL(CONTPHONE1,'') AS CONTPHONE1 from membermaster  where  mname like '%" & Trim(Me.txt_TableNo.Text) & "%'"
        sqlstring = sqlstring & " ORDER BY msorderno"
        gconnection.getDataSet(sqlstring, "SALEREGISTERSUMMARY")
        If gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count > 0 Then
            SSGRID.Row = 0
            SSGRID.Col = 3
            SSGRID.Text = "CATEGORY"
            SSGRID.Col = 4
            SSGRID.Text = "STATUS"
            SSGRID.Col = 5
            SSGRID.Text = "ADDRESS1"
            SSGRID.Col = 6
            SSGRID.Text = "ADDRESS2"
            SSGRID.Col = 7
            SSGRID.Text = "ADDRESS3"
            SSGRID.Col = 8
            SSGRID.Text = "CITY"
            SSGRID.Col = 9
            SSGRID.Text = "PHONE"
            For i = 1 To gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count
                SSGRID.SetText(1, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mcode")) & "")
                SSGRID.SetText(2, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mname")) & "")
                SSGRID.SetText(3, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("membertypecode")) & "")
                SSGRID.SetText(4, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("curentstatus")) & "")
                SSGRID.SetText(5, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd1")) & "")
                SSGRID.SetText(6, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd2")) & "")
                SSGRID.SetText(7, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd3")) & "")
                SSGRID.SetText(8, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contCITY")) & "")
                SSGRID.SetText(9, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contphone1")) & "")
                j = j + 1
            Next i
        Else
            MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
    End Sub

    Private Sub PlotNoSearch()
        Dim i, j As Integer
        Dim posdesc(), groupcode(), itemcode(), sqlstring As String
        Dim POSDESC2(), GROUPDESC2(), code(), CODEPOS() As String
        Dim sqlstringCancel As String

        sqlstring = "select msorderno,mcode,mname,Membertypecode,curentstatus,PlotNo,ISNULL(CONTADD1,'') AS CONTADD1,ISNULL(CONTADD2,'') AS CONTADD2,ISNULL(CONTADD3,'') AS CONTADD3,ISNULL(CONTCITY,'') AS CONTCITY,ISNULL(CONTPHONE1,'') AS CONTPHONE1 from membermaster  where curentstatus  in ('LIVE','INACTIVE') and  PlotNo like '%" & Trim(Me.txt_TableNo.Text) & "%'"
        sqlstring = sqlstring & " ORDER BY msorderno"
        gconnection.getDataSet(sqlstring, "SALEREGISTERSUMMARY")
        If gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count > 0 Then
            SSGRID.Row = 0
            SSGRID.Col = 3
            SSGRID.Text = "PLOT NO"
            SSGRID.Col = 4
            SSGRID.Text = "ADDRESS1"
            SSGRID.Col = 5
            SSGRID.Text = "ADDRESS2"
            SSGRID.Col = 6
            SSGRID.Text = "ADDRESS3"
            SSGRID.Col = 7
            SSGRID.Text = "CITY"
            SSGRID.Col = 8
            SSGRID.Text = "PHONE"
            ''SSGRID.Col = 4
            ''SSGRID.Text = "STATUS"
            For i = 1 To gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count
                SSGRID.SetText(1, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mcode")) & "")
                SSGRID.SetText(2, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mname")) & "")
                SSGRID.SetText(3, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("PlotNo")) & "")
                SSGRID.SetText(4, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd1")) & "")
                SSGRID.SetText(5, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd2")) & "")
                SSGRID.SetText(6, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd3")) & "")
                SSGRID.SetText(7, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contCITY")) & "")
                SSGRID.SetText(8, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contphone1")) & "")
                'SSGRID.SetText(4, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("curentstatus")) & "")
                j = j + 1
            Next i
        Else
            MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
    End Sub

    Private Sub addressSearch()
        Dim i, j As Integer
        Dim posdesc(), groupcode(), itemcode(), sqlstring As String
        Dim POSDESC2(), GROUPDESC2(), code(), CODEPOS() As String
        Dim sqlstringCancel As String
        sqlstring = "select msorderno,mcode,mname,Membertypecode,curentstatus,ISNULL(CONTADD1,'') AS CONTADD1,ISNULL(CONTADD2,'') AS CONTADD2,ISNULL(CONTADD3,'') AS CONTADD3,ISNULL(CONTCITY,'') AS CONTCITY,ISNULL(CONTPHONE1,'') AS CONTPHONE1 from membermaster  where  contadd1+contadd2+contadd3  like '%" & Trim(Me.txt_TableNo.Text) & "%'"
        sqlstring = sqlstring & " ORDER BY msorderno"
        gconnection.getDataSet(sqlstring, "SALEREGISTERSUMMARY")
        If gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count > 0 Then
            SSGRID.Row = 0
            SSGRID.Col = 8
            SSGRID.Text = "CATEGORY"
            SSGRID.Col = 3
            SSGRID.Text = "ADDRESS1"
            SSGRID.Col = 4
            SSGRID.Text = "ADDRESS2"
            SSGRID.Col = 5
            SSGRID.Text = "ADDRESS3"
            SSGRID.Col = 6
            SSGRID.Text = "CITY"
            SSGRID.Col = 7
            SSGRID.Text = "PHONE"
            For i = 1 To gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count
                SSGRID.SetText(1, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mcode")) & "")
                SSGRID.SetText(2, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mname")) & "")
                SSGRID.SetText(8, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("membertypecode")) & "")
                SSGRID.SetText(3, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd1")) & "")
                SSGRID.SetText(4, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd2")) & "")
                SSGRID.SetText(5, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd3")) & "")
                SSGRID.SetText(6, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contCITY")) & "")
                SSGRID.SetText(7, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contphone1")) & "")
                j = j + 1
            Next i
        Else
            MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
    End Sub



    Private Sub PlaceCitySearch()
        Dim i, j As Integer
        Dim posdesc(), groupcode(), itemcode(), sqlstring As String
        Dim POSDESC2(), GROUPDESC2(), code(), CODEPOS() As String
        Dim sqlstringCancel As String
        sqlstring = "select msorderno,mcode,mname,Membertypecode,curentstatus,ISNULL(CONTADD1,'') AS CONTADD1,ISNULL(CONTADD2,'') AS CONTADD2,ISNULL(CONTADD3,'') AS CONTADD3,ISNULL(CONTCITY,'') AS CONTCITY,ISNULL(CONTPHONE1,'') AS CONTPHONE1 from membermaster  where  (contcity   like '%" & Trim(Me.txt_TableNo.Text) & "%') or (contadd3   like '%" & Trim(Me.txt_TableNo.Text) & "%') "
        sqlstring = sqlstring & " ORDER BY msorderno"
        gconnection.getDataSet(sqlstring, "SALEREGISTERSUMMARY")
        If gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count > 0 Then
            SSGRID.Row = 0
            SSGRID.Col = 8
            SSGRID.Text = "CATEGORY"
            SSGRID.Col = 3
            SSGRID.Text = "ADDRESS1"
            SSGRID.Col = 4
            SSGRID.Text = "ADDRESS2"
            SSGRID.Col = 5
            SSGRID.Text = "ADDRESS3"
            SSGRID.Col = 6
            SSGRID.Text = "CITY"
            SSGRID.Col = 7
            SSGRID.Text = "PHONE"
            For i = 1 To gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count
                SSGRID.SetText(1, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mcode")) & "")
                SSGRID.SetText(2, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mname")) & "")
                SSGRID.SetText(8, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("membertypecode")) & "")
                SSGRID.SetText(3, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd1")) & "")
                SSGRID.SetText(4, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd2")) & "")
                SSGRID.SetText(5, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd3")) & "")
                SSGRID.SetText(6, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contCITY")) & "")
                SSGRID.SetText(7, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contphone1")) & "")
                j = j + 1
            Next i
        Else
            MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
    End Sub


    Private Sub SocietyNoSearch()
        Dim i, j As Integer
        Dim posdesc(), groupcode(), itemcode(), sqlstring As String
        Dim POSDESC2(), GROUPDESC2(), code(), CODEPOS() As String
        Dim sqlstringCancel As String

        sqlstring = "select msorderno,mcode,mname,Membertypecode,curentstatus,SocietyNo,ISNULL(CONTADD1,'') AS CONTADD1,ISNULL(CONTADD2,'') AS CONTADD2,ISNULL(CONTADD3,'') AS CONTADD3,ISNULL(CONTCITY,'') AS CONTCITY,ISNULL(CONTPHONE1,'') AS CONTPHONE1 from membermaster  where curentstatus  in ('LIVE','INACTIVE') and  SocietyNo like '%" & Trim(Me.txt_TableNo.Text) & "%'"
        sqlstring = sqlstring & " ORDER BY msorderno"
        gconnection.getDataSet(sqlstring, "SALEREGISTERSUMMARY")
        If gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count > 0 Then
            SSGRID.Row = 0
            SSGRID.Col = 3
            SSGRID.Text = "SOCIETY NO"
            'SSGRID.Col = 4
            'SSGRID.Text = "STATUS"
            For i = 1 To gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count
                SSGRID.SetText(1, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mcode")) & "")
                SSGRID.SetText(2, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mname")) & "")
                SSGRID.SetText(3, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("societyNo")) & "")
                SSGRID.SetText(4, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd1")) & "")
                SSGRID.SetText(5, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd2")) & "")
                SSGRID.SetText(6, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd3")) & "")
                SSGRID.SetText(7, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contCITY")) & "")
                SSGRID.SetText(8, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contphone1")) & "")

                'SSGRID.SetText(4, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("curentstatus")) & "")
                j = j + 1
            Next i
        Else
            MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
    End Sub
    Private Sub SpouseNameSearch()
        Dim i, j As Integer
        Dim posdesc(), groupcode(), itemcode(), sqlstring As String
        Dim POSDESC2(), GROUPDESC2(), code(), CODEPOS() As String
        Dim sqlstringCancel As String
        sqlstring = "select msorderno,mcode,mname,Spouse,ISNULL(CONTADD1,'') AS CONTADD1,ISNULL(CONTADD2,'') AS CONTADD2,ISNULL(CONTADD3,'') AS CONTADD3,ISNULL(CONTCITY,'') AS CONTCITY,ISNULL(CONTPHONE1,'') AS CONTPHONE1 from membermaster  where  Spouse like '%" & Trim(Me.txt_TableNo.Text) & "%'"
        sqlstring = sqlstring & " ORDER BY msorderno"
        Dim heading() As String = {"SALES REGISTER-DEPARTMENTWISE", "ALL"}
        gconnection.getDataSet(sqlstring, "SALEREGISTERSUMMARY")
        If gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count > 0 Then
            SSGRID.Row = 0
            SSGRID.Col = 3
            SSGRID.Text = "SPOUSE NAME"
            SSGRID.Col = 4
            SSGRID.Text = "ADDRESS1"
            SSGRID.Col = 5
            SSGRID.Text = "ADDRESS2"
            SSGRID.Col = 6
            SSGRID.Text = "ADDRESS3"
            SSGRID.Col = 7
            SSGRID.Text = "CITY"
            SSGRID.Col = 8
            SSGRID.Text = "PHONE"
            For i = 1 To gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count
                SSGRID.SetText(1, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mcode")) & "")
                SSGRID.SetText(2, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mname")) & "")
                SSGRID.SetText(3, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("Spouse")) & "")
                SSGRID.SetText(4, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd1")) & "")
                SSGRID.SetText(5, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd2")) & "")
                SSGRID.SetText(6, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd3")) & "")
                SSGRID.SetText(7, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contCITY")) & "")
                SSGRID.SetText(8, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contphone1")) & "")

                j = j + 1
            Next i
        Else
            MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If


    End Sub
    Private Sub dependentNameSearch()
        Dim i, j As Integer
        Dim posdesc(), groupcode(), itemcode(), sqlstring As String
        Dim POSDESC2(), GROUPDESC2(), code(), CODEPOS() As String
        Dim sqlstringCancel As String

        sqlstring = "select m.msorderno as msorderno ,m.mcode as mcode ,m.mname as mname,isnull(a.child_nm,'')  as childname,ISNULL(CONTADD1,'') AS CONTADD1,ISNULL(CONTADD2,'') AS CONTADD2,ISNULL(CONTADD3,'') AS CONTADD3,ISNULL(CONTCITY,'') AS CONTCITY,ISNULL(CONTPHONE1,'') AS CONTPHONE1 from membermaster m,memdet  a where m.mcode=a.mem_code and isnull(a.type0,'')='CHLD' and a.child_nm  like '%" & Trim(Me.txt_TableNo.Text) & "%'"
        sqlstring = sqlstring & " ORDER BY msorderno"
        'Dim heading() As String = {"SALES REGISTER-DEPARTMENTWISE", "ALL"}
        gconnection.getDataSet(sqlstring, "SALEREGISTERSUMMARY")
        If gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count > 0 Then

            SSGRID.Row = 0
            SSGRID.Col = 3
            SSGRID.Text = "DEPENDENT NAME"
            SSGRID.Col = 4
            SSGRID.Text = "ADDRESS1"
            SSGRID.Col = 5
            SSGRID.Text = "ADDRESS2"
            SSGRID.Col = 6
            SSGRID.Text = "ADDRESS3"
            SSGRID.Col = 7
            SSGRID.Text = "CITY"
            SSGRID.Col = 8
            SSGRID.Text = "PHONE"
            For i = 1 To gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count
                SSGRID.SetText(1, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mcode")) & "")
                SSGRID.SetText(2, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("mname")) & "")
                SSGRID.SetText(3, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("childname")) & "")
                SSGRID.SetText(4, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd1")) & "")
                SSGRID.SetText(5, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd2")) & "")
                SSGRID.SetText(6, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contadd3")) & "")
                SSGRID.SetText(7, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contCITY")) & "")
                SSGRID.SetText(8, i, CStr(gdataset.Tables("SALEREGISTERSUMMARY").Rows(j).Item("contphone1")) & "")

                j = j + 1
            Next i
        Else
            MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
            Exit Sub
        End If
    End Sub


    Public Function Detailsection(ByVal SQLSTRING As String)
        Dim i As Integer = 1
        Dim j As Integer
        Dim boolitem, boolgrouptotal As Boolean
        Dim SSQL, Itemdesc, Itemcode, Uom As String
        Dim GrandQty, TotalAmount, TotalQty, TotalRate, GrandAmount, PTOTALAMOUNT, PGRANDAMOUNT As Double
        Dim GROUPDESC As String
        Dim dblGRQTY, dblGRAMOUNT As Double

        Try
            Call Randomize()
            AppPath = Application.StartupPath
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            printfile = VFilePath
            pageno = 1
            Filewrite.Write(Chr(15))

            Filewrite.Write(Chr(15))
            Filewrite.WriteLine(Space(20) & "PRINTED ON : " & Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine(Space(20) & Mid(MyCompanyName, 1, 40), " ")
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.WriteLine(StrDup(85, "="))
            pagesize = pagesize + 1
            Filewrite.WriteLine("KOT DETAILS        ITEM CODE     ITEM DESCRIPTION     QUANTITY    RATE       AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(85, "="))

            gconnection.getDataSet(SQLSTRING, "SALEREGISTERSUMMARY")
            If gdataset.Tables("SALEREGISTERSUMMARY").Rows.Count > 0 Then
                Filewrite.WriteLine()
                pagesize = pagesize + 1
                Filewrite.Write("TABLE NO :")
                Filewrite.WriteLine(Mid(UCase(Mid(gdataset.Tables("SALEREGISTERSUMMARY").Rows(0).Item("tableno"), 1, 7)), 1, 10))
                Filewrite.Write("MCODE :")
                Filewrite.WriteLine(Mid(UCase(Mid(gdataset.Tables("SALEREGISTERSUMMARY").Rows(0).Item("mcode"), 1, 7)), 1, 10), ":", Space(1) & Mid(CStr(Mid(gdataset.Tables("SALEREGISTERSUMMARY").Rows(0).Item("mname"), 1, 30)), 1, 30))
                For Each dr In gdataset.Tables("SALEREGISTERSUMMARY").Rows
                    'Filewrite.WriteLine(Mid(UCase(Mid(Trim(dr("tableno")), 1, 7)), 1, 10))
                    'Filewrite.WriteLine(Mid(UCase(Mid(Trim(dr("MCODE")), 1, 7)), 1, 10), ":", Space(1) & Mid(CStr(Mid(Trim(dr("Mname")), 1, 30)), 1, 30))
                    If GROUPDESC <> dr("KOTDETAILS") Then
                        Filewrite.WriteLine("{0,-6}", Mid(CStr(dr("KOTDETAILS")), 1, 20))
                        pagesize = pagesize + 1
                        GROUPDESC = dr("KOTDETAILS")
                    End If
                    If Itemcode <> dr("ITEMCODE") Then
                        Filewrite.Write(Space(20) & "{0,-7}", Mid(Trim(dr("ITEMCODE")), 1, 7))
                        Filewrite.Write(Space(5) & "{0,-20}", Mid(Trim(dr("ITEMDESC")), 1, 20))
                    Else
                        Filewrite.Write("{0,-10}", " ")
                        Filewrite.Write("{0,-27}", " ")
                    End If
                    'Filewrite.Write("{0,-5}", Mid(Trim(dr("SERVICELOCATION")), 1, 5))

                    'TotalAmount = Val(dr("AMOUNT"))  'Val(dr("QTY")) * Val(dr("RATE"))
                    Filewrite.Write(Space(3) & "{0,5}", Mid(Format(Val(dr("QTY")), "0.00"), 1, 5))
                    Filewrite.Write("{0,10}", Mid(Format(Val(dr("RATE")), "0.00"), 1, 10))
                    Filewrite.WriteLine("{0,13}", Mid(Format(Val(dr("amount")), "0.00"), 1, 13))
                    pagesize = pagesize + 1
                    'GrandAmount = GrandAmount + Val(TotalAmount)
                    'GrandQty = GrandQty + Val(dr("QTY"))

                    'dblGRQTY = dblGRQTY + Val(dr("QTY"))
                    'dblGRAMOUNT = dblGRAMOUNT + Val(TotalAmount)
                    'i = i + 1
                    Itemcode = dr("ITEMCODE")
                    GROUPDESC = dr("kotdetails")
                Next
                'Filewrite.WriteLine(StrDup(79, "="))
                'pagesize = pagesize + 1
                'Filewrite.WriteLine(Mid(UCase(GROUPDESC), 1, 20) & Space(20 - Len(Mid(UCase(GROUPDESC), 1, 20))) & "  Total =====>" & Space(8) & Space(10 - Len(Mid(Format(Val(dblGRQTY), "0.00"), 1, 10))) & Mid(Format(Val(dblGRQTY), "0.00"), 1, 10) & Space(11) & Space(12 - Len(Mid(Format(Val(dblGRAMOUNT), "0.00"), 1, 12))) & Mid(Format(Val(dblGRAMOUNT), "0.00"), 1, 12))
                'pagesize = pagesize + 1
                'Filewrite.WriteLine(StrDup(79, "="))
                'pagesize = pagesize + 1
                'Filewrite.WriteLine(Space(20) & "  Grand Total =====>" & Space(2) & Space(10 - Len(Mid(Format(Val(GrandQty), "0.00"), 1, 10))) & Mid(Format(Val(GrandQty), "0.00"), 1, 10) & Space(11) & Space(12 - Len(Mid(Format(Val(GrandAmount), "0.00"), 1, 12))) & Mid(Format(Val(GrandAmount), "0.00"), 1, 12))
                'pagesize = pagesize + 1
                'Filewrite.WriteLine(StrDup(79, "="))
                'pagesize = pagesize + 1
            Else
                MessageBox.Show("NO RECORD TO DISPLAY", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Exit Function
            End If
            Filewrite.Write(Chr(12))
            Filewrite.Close()
            gPrint = False

            If gPrint = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile1(VFilePath)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Function PrintHeader(ByVal HEADING() As String, ByVal MSKFROMDATE As Date, ByVal MSKTODATE As Date)
        Dim I As Integer
        pagesize = 0
        Try
            Filewrite.Write(Chr(15))
            Filewrite.WriteLine("{0,55}{1,20}{2,30}{3,25}", "", HEADING(1), " ", "PRINTED ON : " & Format(Now, "dd/MM/yyyy"))
            pagesize = pagesize + 1
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,85}{2,20}", Mid(MyCompanyName, 1, 30), " ", "ACCOUNTING PERIOD")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}{3,-25}{4,-24}", Mid(Address1, 1, 30), " ", Mid(Trim(HEADING(0)), 1, 30), " ", "01-04-" & gFinancalyearStart & " TO 31-03-" & gFinancialYearEnd)
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-30}{1,-26}{2,-30}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 30))
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,124}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.Write("{0,-30}{1,87}{2,16}", Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"), " ", "AMOUNT IN RUPEES")
            Filewrite.WriteLine(Chr(18))
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "="))
            pagesize = pagesize + 1
            Filewrite.WriteLine("ITEM CODE ITEM DESCRIPTION                   QUANTITY      RATE       AMOUNT")
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(79, "="))
            pagesize = pagesize + 1
        Catch ex As Exception
            Exit Function
        End Try
    End Function


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        GmoduleName = ""
        Me.Close()
    End Sub


    Private Sub txt_TableNo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_TableNo.KeyPress
        Dim strstring As String
        Dim I As Integer
        If Asc(e.KeyChar) = 13 Then
            Try

                If Trim(txt_TableNo.Text) <> "" Then
                    If Trim(txt_TableNo.Text) <> "" Then
                        strstring = "SELECT TABLENO,MCODE,MNAME FROM Kot_Hdr WHERE tableno='" & Trim(txt_TableNo.Text) & "' AND   "
                        strstring = strstring & "Billstatus='PO' And isnull(DELFLAG,'') <> 'Y' And ISNULL(Manualbillstatus,'')<> 'Y' AND CAST(Convert(varchar(11),KOTDATE,6) AS DATETIME) = '" & Format(CDate(dtp_KOTdate.Value), "yyyy-MM-dd") & "' "
                        '                    strstring = "SELECT isnull(poscode,'') as poscode,isnull(posdesc,'') as posname FROM POSMASTER WHERE POSCODE='" & Trim(txt_ServerCode.Text) & "'AND ISNULL(Freeze,'')<>'Y'"
                        gconnection.getDataSet(strstring, "LOCmaster")
                        If gdataset.Tables("LOCmaster").Rows.Count > 0 Then

                            LBL_MCODE.Text = gdataset.Tables("Locmaster").Rows(0).Item("MCODE")
                            LBL_MNAME.Text = gdataset.Tables("Locmaster").Rows(0).Item("MNAME")
                        Else
                            txt_TableNo.Text = ""
                            LBL_MCODE.Text = ""
                            LBL_MNAME.Text = ""
                        End If
                    Else

                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(" Check the error :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Exit Sub
            End Try
        End If
    End Sub

    Private Sub txt_TableNo_BackColorChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_TableNo.BackColorChanged

    End Sub

    Private Sub LBL_MCODE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBL_MCODE.Click

    End Sub

    Private Sub TableWiseItemList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SSGRID.ClearRange(1, 1, -1, -1, True)
    End Sub



    Private Sub TableWiseItemList_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub TableWiseItemList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F6 Then
            Call cmd_clear_Click(sender, e)
            Exit Sub
        ElseIf e.KeyCode = Keys.F7 Then
            Call btnview_Click(sender, e)
        ElseIf e.KeyCode = Keys.F11 Or e.KeyCode = Keys.Escape Then
            Call btnExit_Click(sender, e)
            Exit Sub
        End If

    End Sub

    Private Sub cmd_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_clear.Click
        SSGRID.ClearRange(1, 1, -1, -1, True)
        txt_TableNo.Text = ""
    End Sub
End Class