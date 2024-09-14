Imports System.Text.RegularExpressions
Imports System.IO
Imports System
Module globalFunction
    Public RepSqlStr As String
    Public FinalString As String
    Public SetQuater, VRDate As String
    Public HEDDING1 As String
    Dim regexp As Regex
    Public boolexp As Boolean = False
    Public boolexp2 As Boolean = False
    Dim gconnection As New GlobalClass
    Public Function PageHeader(ByVal PageLenght As Integer, ByVal PAGE As Integer)
        Dim str, T As String
        CompanyName = "MADRAS CLUB"
        CompanyAddress = "8, ADYAR CLUB GATE ROAD, MADRAS, 600 028"
        If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "@")
        If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "A" & Chr(11))
        Filewrite.WriteLine(StrDup(PageLenght, "*"))
        If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "E")
        Filewrite.WriteLine("{0,-80}", CompanyName)
        If PRINTREP = True Then Filewrite.Write(Chr(27) & "F")
        Filewrite.WriteLine("{0,-80}", CompanyAddress)
        'Filewrite.WriteLine("{0,-80}", StrDup(Len(CompanyAddress), "_"))
        If PRINTREP = True Then Filewrite.Write(Chr(27) & "E")
        Filewrite.WriteLine("{0,-80}", "Report: " & ReportTitle)
        If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "F")
        str = "{0,-20}{1," & (PageLenght - 40) & "}"
        Filewrite.WriteLine(str, "Printed On: " & Date.Now, "Page Number:" & PAGE)
        Filewrite.WriteLine(StrDup(PageLenght, "*"))
    End Function
    Public Function PageFoter(ByVal PageLenght As Integer)
        Dim objWMI As New clsWmi
        Dim str As String
        Filewrite.WriteLine(Chr(18))
        Filewrite.WriteLine(StrDup(PageLenght, "_"))
        str = "{0,-20}{1,-20}{2," & (PageLenght - 40) & "}"
        If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "E")
        Filewrite.WriteLine(str, "User Name: " & gUsername, "Computer Name: " & objWMI.ComputerName, "(DATAASE SOFTWARE)")
        If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "F")
        If PRINTREP = True Then Filewrite.Write(Chr(12))

    End Function

    Public Function GetPrinter()

        AppPath = Application.StartupPath
        Dim ServerConn As New OleDb.OleDbConnection
        Dim servercmd As New OleDb.OleDbDataAdapter
        Dim getserver As New DataSet
        Dim sql, ssql, compName, PrinName As String
        sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
        sql = sql & AppPath & "\DBS_KEY.MDB"
        ServerConn.ConnectionString = sql
        Try
            ServerConn.Open()
            ssql = "SELECT * FROM PrinterSetup"
            servercmd = New OleDb.OleDbDataAdapter(ssql, ServerConn)
            servercmd.Fill(getserver)
            If getserver.Tables(0).Rows.Count > 0 Then
                If IsDBNull(getserver.Tables(0).Rows(0).Item(0)) = False Then
                    compName = getserver.Tables(0).Rows(0).Item(0)
                    PrinName = getserver.Tables(0).Rows(0).Item(1)
                    If Trim(compName) = "" Or Trim(PrinName) = "" Then
                        Printername = ">>PRN"
                    Else
                        Printername = "\\" & compName & "\" & PrinName
                    End If

                    'gDatabase = getserver.Tables(0).Rows(0).Item(1)
                Else
                    Printername = ">>PRN"
                End If
            Else
                MessageBox.Show("Failed to connect to data source")
                'Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source")
            MsgBox(ex.Message)
        Finally
            ServerConn.Close()
        End Try
    End Function
    Public Function GetServe()
        AppPath = Application.StartupPath
        Dim ServerConn As New OleDb.OleDbConnection
        Dim servercmd As New OleDb.OleDbDataAdapter
        Dim getserver As New DataSet
        Dim sql, ssql As String
        sql = "Provider=Microsoft.Jet.OLEDB.4.0;Data source="
        sql = sql & AppPath & "\DBS_KEY.MDB"
        ServerConn.ConnectionString = sql
        Try
            ServerConn.Open()
            ssql = "SELECT SERVER,USERNAME,PASSWORD,PRODUCTKEY,PHOTOPATH FROM DBSKEY"
            servercmd = New OleDb.OleDbDataAdapter(ssql, ServerConn)
            servercmd.Fill(getserver)
            If getserver.Tables(0).Rows.Count > 0 Then
                ServerName = getserver.Tables(0).Rows(0).Item(0)
                SQL_UserName = Trim(getserver.Tables(0).Rows(0).Item(1) & "")
                SQL_Password = Trim(getserver.Tables(0).Rows(0).Item(2) & "")
                Productkey = Trim(getserver.Tables(0).Rows(0).Item(3) & "")
                gPhotoPath = Trim(getserver.Tables(0).Rows(0).Item(4) & "")
            Else
                MessageBox.Show("Failed to connect to data source")
                'Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to connect to data source")
            MsgBox(ex.Message)
        Finally
            ServerConn.Close()
        End Try
        'sqlconnection = "Data Source=PROGRAM;User ID=sa;Initial Catalog= " & ServerName
        'Dim OBJ As globalClass
        'OBJ.sqlconnection = "Data Source=PROGRAM;User ID=sa;Initial Catalog= " & ServerName

        'sqlconnection = "Data Source=PROGRAM;User ID=sa;Initial Catalog= " & ServerName
        GetPrinter()
    End Function
    Public Sub getNumeric(ByVal a As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(a.KeyChar)
            Case 65 To 127
                a.Handled = True
            Case 33 To 38
                a.Handled = True
            Case 40 To 44
                a.Handled = True
            Case 58 To 64
                a.Handled = True
        End Select
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getAlphanumeric
    'Input Type:KeyPressEventArgs
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getAlphanumeric(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        'MessageBox.Show(Asc(b.KeyChar))
        Select Case Asc(b.KeyChar)
            Case 33 To 47
                b.Handled = True
            Case 58 To 64
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 123 To 135
                b.Handled = True
            
        End Select
    End Sub
    Public Sub getAlphanumeric1(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        'MessageBox.Show(Asc(b.KeyChar))
        Select Case Asc(b.KeyChar)
            Case 33 To 45
                b.Handled = True
            Case 58 To 64
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 123 To 135
                b.Handled = True
            Case 47
                b.Handled = True

        End Select
    End Sub

    'This Function Blocks Single Quote
    'Because SQL Server doesn't allow single quote
    Public Sub Block_Singlequote(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(b.KeyChar)
            Case 33 To 64
                b.Handled = True
            Case 39
                b.Handled = True 'Blocked single quote
        End Select
    End Sub

    Public Sub BLANK(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        If Asc(b.KeyChar) > 0 And Asc(b.KeyChar) < 225 Then
            b.Handled = True
        End If
    End Sub

    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Charater
    'Function Name:getCharater
    'Input Type:KeyPressEventArgs
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getCharater(ByVal b As System.Windows.Forms.KeyPressEventArgs)
        Select Case Asc(b.KeyChar)
            Case 33 To 64
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 91 To 96
                b.Handled = True
            Case 123 To 135
                b.Handled = True
        End Select
    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getEmail
    'Input Type:Textbox
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Function getEmail(ByVal txtbox As System.Windows.Forms.TextBox) As String
        Dim emailstatus As String
        If regexp.IsMatch(txtbox.Text, "^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$") Then
            emailstatus = "T"
            txtbox.ForeColor = Color.Blue
            Return emailstatus
        Else
            MsgBox(" E-mail Id field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            emailstatus = "F"
            Return emailstatus
            Exit Function
        End If
    End Function
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getPincode
    'Input Type:Textbox
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getPincode(ByVal txtbox As System.Windows.Forms.TextBox)
        Dim boolexp As Boolean = False
        If regexp.IsMatch(txtbox.Text, "^\d{5}(-\d{4})?$") Then
            boolexp = True
            txtbox.ForeColor = Color.Blue
        Else
            MsgBox(" Pincode field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            boolexp = False
        End If

    End Sub
    '*************************************************************************
    'Purpose:To Validate , Data-entry at End-User.It only allows Alpha-Numeric
    'Function Name:getPhoneno
    'Input Type:Textbox
    'Returm Type:Nothing
    'Auther:Avinash
    'Date:30/08/2006
    '*************************************************************************
    Public Sub getPhoneno(ByVal txtbox As System.Windows.Forms.TextBox)
        If regexp.IsMatch(txtbox.Text, "^((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}$") Then
            boolexp = True
            txtbox.ForeColor = Color.Blue
        Else
            MsgBox(" Phoneno field is not in correct format", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, " Validating Phoneno ")
            txtbox.ForeColor = Color.Red
            txtbox.Select()
            boolexp = False
        End If
    End Sub
    '************************************************************
    'Purpose: To Clear all the textBox control,within a group Box
    'Function Name: clearPanel
    'Input Type: panel 
    'Return Type:Nothing
    'Author:Avinash
    'Date:30/08/2006
    '************************************************************
    Public Sub clearform(ByVal frm As System.Windows.Forms.Form)
        Dim ctrl As New Control
        For Each ctrl In frm.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            If TypeOf ctrl Is ComboBox Then
                ctrl.Text = ""

            End If
            If TypeOf ctrl Is CheckBox Then
                ctrl.Text = ""
            End If
            'If TypeOf ctrl Is DateTimePicker Then
            '    ctrl.Text = "01/JAN/1900"
            'End If
        Next ctrl
    End Sub

    Public Sub OpenTextFile(ByVal VOutputfile As String)
        If Dir(AppPath & "\Reports\" & Trim(VOutputfile & "") & ".txt") <> "" Then
            If Dir(AppPath & "\Wordpad.exe") <> "" Then
                Shell(AppPath & "\Wordpad.exe " & AppPath & "\Reports\" & VOutputfile & ".txt", vbMaximizedFocus)
            Else
                MsgBox("Wordpad.exe not found", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            MsgBox(VOutputfile & "  File not found", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub
    Public Sub PrintTextFile(ByVal VOutputfile As String)
        Dim Filewrite As StreamWriter
        If Dir(AppPath & "\Reports\" & Trim(VOutputfile & "") & ".txt") <> "" Then
            Filewrite = File.AppendText(AppPath & "\Reports\" & VOutputfile & ".bat")
            'Filewrite.WriteLine("Type " & AppPath & "\Reports\" & VOutputfile & ".txt >prn")
            Filewrite.WriteLine("Type " & AppPath & "\Reports\" & VOutputfile & ".txt > " & Printername)
            Filewrite.Close()
            Call Shell(AppPath & "\Reports\" & VOutputfile & ".bat", vbHide)
        Else
            MessageBox.Show(VOutputfile & " Not Found in your System", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
    End Sub
    Public Sub OpenTextFileXML(ByVal VOutputfile As String)
        If Dir(AppPath & "\Reports\" & Trim(VOutputfile & "") & ".XML") <> "" Then
            If Dir(AppPath & "\IEXPLORE.exe") <> "" Then
                Shell(AppPath & "\IEXPLORE.exe " & AppPath & "\Reports\" & VOutputfile & ".XML", vbMaximizedFocus)
            Else
                MsgBox("IEXPLORE.exe not found", MsgBoxStyle.Critical)
                Exit Sub
            End If
        Else
            MsgBox(VOutputfile & "  File not found", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub

    Public Sub PrintTextFile1(ByVal VOutputfile As String)
        Dim Filewrite As StreamWriter
        If Dir(AppPath & "\Reports\" & Trim(VOutputfile & "") & ".txt") <> "" Then
            Filewrite = File.AppendText(AppPath & "\Reports\" & VOutputfile & ".bat")
            '            Filewrite.WriteLine("Type " & AppPath & "\Reports\" & VOutputfile & ".txt " & Printername)
            Filewrite.WriteLine("Type " & AppPath & "\Reports\" & VOutputfile & ".txt>PRN ")
            Filewrite.Close()
            Call Shell(AppPath & "\Reports\" & VOutputfile & ".bat", vbHide)
        Else
            MsgBox(VOutputfile & " File not found", MsgBoxStyle.Critical)
            Exit Sub
        End If
    End Sub

    Public Function GetPassword(ByVal vUser As String) As String
        Dim Vdesc, vPass As String
        Dim vAsc, Loopindex As Long
        Vdesc = ""
        For Loopindex = 1 To Len(vUser)
            Vdesc = Mid(vUser, Loopindex, 1)
            vAsc = Asc(Vdesc) + 150
            vPass = Trim(vPass) & Chr(vAsc)
        Next Loopindex
        Return vPass
    End Function
    Public Function ExportTo(ByVal ssgrid As AxFPSpreadADO.AxfpSpread)
        Try
            Dim X As Boolean
            Dim vpath As String
            Dim vLog As String
            Dim strpath As String
            vpath = Application.StartupPath & "\Reports\Monprtn"
            vLog = Application.StartupPath & "\Reports\Monprtn.Txt"
            X = ssgrid.ExportRangeToTextFile(0, 0, ssgrid.Col2, ssgrid.Row2, Application.StartupPath & "\Reports\One.txt", "", ",", vbCrLf, FPSpreadADO.ExportRangeToTextFileConstants.ExportRangeToTextFileCreateNewFile, Application.StartupPath & "\Reports\One.log")
            With ssgrid
                If Dir(vpath & ".Xls") <> "" Then
                    Kill(vpath & ".Xls")
                End If
                X = .ExportToExcel(vpath & ".Xls", "", "")
                strpath = strexcelpath & " " & vpath & ".xls"
                Call Shell(strpath, AppWinStyle.NormalFocus)
            End With
        Catch ex As Exception
            MessageBox.Show("Before Opening New EXCEL Sheet Close Previous EXCEL sheet", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    ' Function for conversion of a Indian Rupees into words
    '   Parameter - accept a Currency
    '   Returns the number in words format
    '   You can use this function in Excel, VBA, VB6,.NET
    '====================================================

    '****************************************************
    ' Code Created by 

    '****************************************************

    ' Conversion for hundreds
    '*****************************************
    Private Function ConvertHundreds(ByVal MyNumber)
        Dim Result As String

        ' Exit if there is nothing to convert.
        If Val(MyNumber) = 0 Then Exit Function

        ' Append leading zeros to number.
        MyNumber = Right("000" & MyNumber, 3)

        ' Do we have a hundreds place digit to convert?
        If Left(MyNumber, 1) <> "0" Then
            Result = ConvertDigit(Left(MyNumber, 1)) & " Hundreds "
        End If

        ' Do we have a tens place digit to convert?
        If Mid(MyNumber, 2, 1) <> "0" Then
            Result = Result & ConvertTens(Mid(MyNumber, 2))
        Else
            ' If not, then convert the ones place digit.
            Result = Result & ConvertDigit(Mid(MyNumber, 3))
        End If

        ConvertHundreds = Trim(Result)
    End Function

    ' Conversion for tens
    '*****************************************
    Private Function ConvertTens(ByVal MyTens)
        Dim Result As String

        ' Is value between 10 and 19?
        If Val(Left(MyTens, 1)) = 1 Then
            Select Case Val(MyTens)
                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eighteen"
                Case 19 : Result = "Nineteen"
                Case Else
            End Select
        Else
            ' .. otherwise it's between 20 and 99.
            Select Case Val(Left(MyTens, 1))
                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else
            End Select

            ' Convert ones place digit.
            Result = Result & ConvertDigit(Right(MyTens, 1))
        End If

        ConvertTens = Result
    End Function

    Private Function ConvertDigit(ByVal MyDigit)
        Select Case Val(MyDigit)
            Case 1 : ConvertDigit = "One"
            Case 2 : ConvertDigit = "Two"
            Case 3 : ConvertDigit = "Three"
            Case 4 : ConvertDigit = "Four"
            Case 5 : ConvertDigit = "Five"
            Case 6 : ConvertDigit = "Six"
            Case 7 : ConvertDigit = "Seven"
            Case 8 : ConvertDigit = "Eight"
            Case 9 : ConvertDigit = "Nine"
            Case Else : ConvertDigit = ""
        End Select
    End Function

    Public Function abcdMINUS(ByVal vString As String) As String
        Dim vDesc As String
        Dim vAsc As Long
        Dim vDes As String
        Dim vDt As String
        Dim Loopindex As Long
        vDesc = vString
        For Loopindex = 1 To Len(vDesc)
            vDes = Trim(Mid(vDesc, Loopindex, 1) & "")
            vAsc = Asc(vDes) - 150
            If vDt = "" Then
                vDt = Chr(vAsc)
            Else
                vDt = vDt & Chr(vAsc)
            End If
        Next Loopindex
        abcdMINUS = vDt
    End Function
    Public Function abcdADD(ByVal vString As String) As String
        Dim vDesc As String
        Dim vAsc As Long
        Dim vDes As String
        Dim vDt As String
        Dim Loopindex As Long
        vDesc = vString
        For Loopindex = 1 To Len(vDesc)
            vDes = Trim(Mid(vDesc, Loopindex, 1) & "")
            vAsc = Asc(vDes) + 150
            If vDt = "" Then
                vDt = Chr(vAsc)
            Else
                vDt = vDt & Chr(vAsc)
            End If
        Next Loopindex
        abcdADD = vDt
    End Function

    Public Function Checkdaterangevalidate(ByVal Startdate As Date, ByVal Enddate As Date) As Boolean
        chkdatevalidate = True
        If DateDiff(DateInterval.Day, Startdate, Enddate) < 0 Then
            MessageBox.Show("From Date cannot be greater than To Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            chkdatevalidate = False
            Exit Function
        End If
        Return chkdatevalidate
    End Function
    Public Function ERPExpiry()
        Dim sqlstring As String
        Dim vDes As String
        Dim expdate As Date

        sqlstring = "SELECT isnull(expirydate,dateadd(day,1,getdate())) as expirydate,Convert(char,Comp,103) as Comp FROM MASTER..CLUBMASTER WHERE  DATAFILE = '" & gDatabase & "' and (isnull(expirydate,'')<>'' or isnull(comp,'')<>'')"
        gconnection.getCompanyinfo(sqlstring, "ExpiryDate")
        If gdataset.Tables("ExpiryDate").Rows.Count > 0 Then
            'FOR KOT Table

            vDes = abcdMINUS(Trim(gdataset.Tables("ExpiryDate").Rows(0).Item("comp") & ""))
            If IsDate(vDes) = True Then
                expdate = DateValue(vDes)
            Else
                expdate = Format(gdataset.Tables("ExpiryDate").Rows(0).Item("ExpiryDate"), "dd/MMM/yyyy")
            End If

            sqlstring = "select * from " & gDatabase & "..kot_hdr where cast(convert(varchar(11),kotdate,106) as datetime)>dateadd(day,-7,'" & Format(expdate, "dd/MMM/yyyy") & "')"
            gconnection.getCompanyinfo(sqlstring, "ExpiryDate1")
            If gdataset.Tables("ExpiryDate1").Rows.Count > 0 Then
                MsgBox("CLUBMAN ERP License Expiry/Due Date is " & Format(expdate, "dd/MM/yyyy") & ", So Kindly Renew the license On or Before Due Date")
                sqlstring = "select * from " & gDatabase & "..kot_hdr where cast(convert(varchar(11),kotdate,106) as datetime)>'" & Format(expdate, "dd/MMM/yyyy") & "'"
                gconnection.getCompanyinfo(sqlstring, "ExpiryDate1")
                If gdataset.Tables("ExpiryDate1").Rows.Count > 0 Then
                    MsgBox("Sorry..CLUBMAN ERP License Expired on " & Format(expdate, "dd/MM/yyyy") & ", Please Contact - Email:info@databasesoftware.in/sandeep@databasesoftware.in ; Phone:044-24328158 ; Mobile:91-9380732461 for further Assistance")
                    End
                End If
            End If

            'JOURNAL Table
            sqlstring = "select * from " & gDatabase & "..journalentry where cast(convert(varchar(11),voucherdate,106) as datetime)>dateadd(day,-7,'" & Format(expdate, "dd/MMM/yyyy") & "')"
            gconnection.getCompanyinfo(sqlstring, "ExpiryDate1")
            If gdataset.Tables("ExpiryDate1").Rows.Count > 0 Then
                MsgBox("CLUBMAN ERP License Expiry/Due Date is " & Format(expdate, "dd/MM/yyyy") & ", So Kindly Renew the license On or Before Due Date")
                sqlstring = "select * from " & gDatabase & "..journalentry where cast(convert(varchar(11),voucherdate,106) as datetime)>'" & Format(expdate, "dd/MMM/yyyy") & "'"
                gconnection.getCompanyinfo(sqlstring, "ExpiryDate1")
                If gdataset.Tables("ExpiryDate1").Rows.Count > 0 Then
                    MsgBox("Sorry...CLUBMAN ERP License Expired on " & Format(expdate, "dd/MM/yyyy") & ", Please Contact - Email:info@databasesoftware.in/sandeep@databasesoftware.in ; Phone:044-24328158 ; Mobile:91-9380732461 for further Assistance")
                    End
                End If
            End If
        End If
    End Function
    Public Function PostingDatevalidate(ByVal Startdate As Date) As Boolean
        Try
            If (DateValue(Format(Startdate, "dd/MM/yyyy")) > DateValue(Format(SYSDATE, "dd/MM/yyyy"))) Then
                MessageBox.Show("Date cannot be greater than Current Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Return False
                Exit Function
            End If
            'If CDate(Format(Startdate, "dd/MMM/yyyy")) > CDate(Format(gFinancialyearEnding, "dd/MMM/yyyy")) Then
            '    MsgBox("Date Should be within Financial Year Date.......", MsgBoxStyle.OKOnly, "Date Validation")
            '    Return False
            '    Exit Function
            'End If
            'If (DateValue(Format(Startdate, "dd/MM/yyyy")) < DateValue(Format(gFinancialyearStart, "dd/MM/yyyy"))) Then
            '    MsgBox("Date Should be within Financial Year Date.......", MsgBoxStyle.OKOnly, "Date Validation")
            '    Return False
            '    Exit Function
            'End If
            Return True
        Catch ex As Exception
        End Try
    End Function
    Public Function Checkdaterangevalidate12(ByVal Startdate As Date, ByVal Enddate As Date) As Boolean
        Try
            chkdatevalidate = False
            If (DateValue(Format(Enddate, "dd/MM/yyyy")) > DateValue(Format(SYSDATE, "dd/MM/yyyy"))) Then
                MessageBox.Show("To Date cannot be greater than Current Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Function
            End If

            If (DateValue(Format(Startdate, "dd/MM/yyyy")) > DateValue(Format(SYSDATE, "dd/MM/yyyy"))) Then
                MessageBox.Show("From Date cannot be greater than Current Date", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Function
            End If

            If CDate(Format(Startdate, "dd/MMM/yyyy")) > CDate(Format(gFinancialyearEnding, "dd/MMM/yyyy")) Then
                MsgBox("From Date Should be within Financial Year Date.......", MsgBoxStyle.OKOnly, "Date Validation")
                Exit Function
            End If

            If (DateValue(Format(Startdate, "dd/MM/yyyy")) < DateValue(Format(gFinancialyearStart, "dd/MM/yyyy"))) Then
                MsgBox("From Date Should be within Financial Year Date.......", MsgBoxStyle.OKOnly, "Date Validation")
                Exit Function
            End If


            If CDate(Format(Enddate, "dd/MMM/yyyy")) > CDate(Format(gFinancialyearEnding, "dd/MMM/yyyy")) Then
                MsgBox("To Date Should be within Financial Year Date.......", MsgBoxStyle.OKOnly, "Date Validation")
                Exit Function
            End If

            If CDate(Format(Enddate, "dd/MMM/yyyy")) < CDate(Format(gFinancialyearStart, "dd/MMM/yyyy")) Then
                MsgBox("To Date Should be within Financial Year Date.......", MsgBoxStyle.OKOnly, "Date Validation")
                Exit Function
            End If
            Return chkdatevalidate = True
        Catch ex As Exception
        End Try
    End Function
    Function RupeesToWord(ByVal MyNumber)
        Dim Temp
        Dim Rupees, Paisa As String
        Dim DecimalPlace, iCount
        Dim Hundreds, Words As String
        Dim place(9) As String
        place(0) = " Thousand "
        place(2) = " Lakh "
        place(4) = " Crore "
        place(6) = " Arab "
        place(8) = " Kharab "
        On Error Resume Next
        ' Convert MyNumber to a string, trimming extra spaces.
        MyNumber = Trim(Str(MyNumber))

        ' Find decimal place.
        DecimalPlace = InStr(MyNumber, ".")

        ' If we find decimal place...
        If DecimalPlace > 0 Then
            ' Convert Paisa
            Temp = Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2)
            Paisa = " and " & ConvertTens(Temp) & " Paisa"

            ' Strip off paisa from remainder to convert.
            MyNumber = Trim(Left(MyNumber, DecimalPlace - 1))
        End If

        '===============================================================
        Dim TM As String  ' If MyNumber between Rs.1 To 99 Only.
        TM = Right(MyNumber, 2)

        If Len(MyNumber) > 0 And Len(MyNumber) <= 2 Then
            If Len(TM) = 1 Then
                Words = ConvertDigit(TM)
                RupeesToWord = "Rupees " & Words & Paisa & " Only"

                Exit Function

            Else
                If Len(TM) = 2 Then
                    Words = ConvertTens(TM)
                    RupeesToWord = "Rupees " & Words & Paisa & " Only"
                    Exit Function

                End If
            End If
        End If
        '===============================================================


        ' Convert last 3 digits of MyNumber to ruppees in word.
        Hundreds = ConvertHundreds(Right(MyNumber, 3))
        ' Strip off last three digits
        MyNumber = Left(MyNumber, Len(MyNumber) - 3)

        iCount = 0
        Do While MyNumber <> ""
            'Strip last two digits
            Temp = Right(MyNumber, 2)
            If Len(MyNumber) = 1 Then


                If Trim(Words) = "Thousand" Or _
                Trim(Words) = "Lakh  Thousand" Or _
                Trim(Words) = "Lakh" Or _
                Trim(Words) = "Crore" Or _
                Trim(Words) = "Crore  Lakh  Thousand" Or _
                Trim(Words) = "Arab  Crore  Lakh  Thousand" Or _
                Trim(Words) = "Arab" Or _
                Trim(Words) = "Kharab  Arab  Crore  Lakh  Thousand" Or _
                Trim(Words) = "Kharab" Then

                    Words = ConvertDigit(Temp) & place(iCount)
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                Else

                    Words = ConvertDigit(Temp) & place(iCount) & Words
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                End If
            Else

                If Trim(Words) = "Thousand" Or _
                   Trim(Words) = "Lakh  Thousand" Or _
                   Trim(Words) = "Lakh" Or _
                   Trim(Words) = "Crore" Or _
                   Trim(Words) = "Crore  Lakh  Thousand" Or _
                   Trim(Words) = "Arab  Crore  Lakh  Thousand" Or _
                   Trim(Words) = "Arab" Then


                    Words = ConvertTens(Temp) & place(iCount)


                    MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                Else

                    '=================================================================
                    ' if only Lakh, Crore, Arab, Kharab

                    If Trim(ConvertTens(Temp) & place(iCount)) = "Lakh" Or _
                       Trim(ConvertTens(Temp) & place(iCount)) = "Crore" Or _
                       Trim(ConvertTens(Temp) & place(iCount)) = "Arab" Then

                        Words = Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    Else
                        Words = ConvertTens(Temp) & place(iCount) & Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    End If

                End If
            End If

            iCount = iCount + 2
        Loop

        RupeesToWord = "Rupees " & Words & Hundreds & Paisa & " Only"
    End Function

    Function RupeesToWordASCA(ByVal MyNumber)
        Dim Temp
        Dim Rupees, Paisa As String
        Dim DecimalPlace, iCount
        Dim Hundreds, Words As String
        Dim place(9) As String
        place(0) = " Thousand "
        place(2) = " Lakh "
        place(4) = " Crore "
        place(6) = " Arab "
        place(8) = " Kharab "
        On Error Resume Next
        ' Convert MyNumber to a string, trimming extra spaces.
        MyNumber = Trim(Str(MyNumber))

        ' Find decimal place.
        DecimalPlace = InStr(MyNumber, ".")

        ' If we find decimal place...
        If DecimalPlace > 0 Then
            ' Convert Paisa
            Temp = Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2)
            Paisa = " and " & ConvertTens(Temp) & " Paisa"

            ' Strip off paisa from remainder to convert.
            MyNumber = Trim(Left(MyNumber, DecimalPlace - 1))
        End If

        '===============================================================
        Dim TM As String  ' If MyNumber between Rs.1 To 99 Only.
        TM = Right(MyNumber, 2)

        If Len(MyNumber) > 0 And Len(MyNumber) <= 2 Then
            If Len(TM) = 1 Then
                Words = ConvertDigit(TM)
                RupeesToWordASCA = Words & Paisa & " Only"

                Exit Function

            Else
                If Len(TM) = 2 Then
                    Words = ConvertTens(TM)
                    RupeesToWordASCA = Words & Paisa & " Only"
                    Exit Function

                End If
            End If
        End If
        '===============================================================


        ' Convert last 3 digits of MyNumber to ruppees in word.
        Hundreds = ConvertHundreds(Right(MyNumber, 3))
        ' Strip off last three digits
        MyNumber = Left(MyNumber, Len(MyNumber) - 3)

        iCount = 0
        Do While MyNumber <> ""
            'Strip last two digits
            Temp = Right(MyNumber, 2)
            If Len(MyNumber) = 1 Then


                If Trim(Words) = "Thousand" Or _
                Trim(Words) = "Lakh  Thousand" Or _
                Trim(Words) = "Lakh" Or _
                Trim(Words) = "Crore" Or _
                Trim(Words) = "Crore  Lakh  Thousand" Or _
                Trim(Words) = "Arab  Crore  Lakh  Thousand" Or _
                Trim(Words) = "Arab" Or _
                Trim(Words) = "Kharab  Arab  Crore  Lakh  Thousand" Or _
                Trim(Words) = "Kharab" Then

                    Words = ConvertDigit(Temp) & place(iCount)
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                Else

                    Words = ConvertDigit(Temp) & place(iCount) & Words
                    MyNumber = Left(MyNumber, Len(MyNumber) - 1)

                End If
            Else

                If Trim(Words) = "Thousand" Or _
                   Trim(Words) = "Lakh  Thousand" Or _
                   Trim(Words) = "Lakh" Or _
                   Trim(Words) = "Crore" Or _
                   Trim(Words) = "Crore  Lakh  Thousand" Or _
                   Trim(Words) = "Arab  Crore  Lakh  Thousand" Or _
                   Trim(Words) = "Arab" Then


                    Words = ConvertTens(Temp) & place(iCount)


                    MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                Else

                    '=================================================================
                    ' if only Lakh, Crore, Arab, Kharab

                    If Trim(ConvertTens(Temp) & place(iCount)) = "Lakh" Or _
                       Trim(ConvertTens(Temp) & place(iCount)) = "Crore" Or _
                       Trim(ConvertTens(Temp) & place(iCount)) = "Arab" Then

                        Words = Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    Else
                        Words = ConvertTens(Temp) & place(iCount) & Words
                        MyNumber = Left(MyNumber, Len(MyNumber) - 2)
                    End If

                End If
            End If

            iCount = iCount + 2
        Loop

        RupeesToWordASCA = Words & Hundreds & Paisa & " Only"
    End Function
    Public Function GreateDateCheck(ByVal Vdate As String) As Boolean
        GreateDateCheck = True
        Dim StartDate As String
        Dim EndDate As String
        StartDate = "01-APR-" & gFinancalyearStart
        EndDate = "31-MAR-" & gFinancialYearEnd
        If CDate(Vdate) <= CDate(Now) Then
            GreateDateCheck = True
        Else
            GreateDateCheck = False
        End If
    End Function
End Module
