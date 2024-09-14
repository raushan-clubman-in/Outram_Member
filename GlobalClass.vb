Imports System.Data
Imports System.IO
Imports System.data.SqlClient
Imports Microsoft.VisualBasic
Public Class GlobalClass
    Public MdiParentObj As Object
    Public connect As New sqlconnection
    Dim Ds As DataSet
    Dim Da As New SqlDataAdapter
    Public sqlconnection, sqlconnection1, VCONN As String
    Public Myconn As New sqlconnection
    Public farPoint As AxFPSpreadADO.AxfpSpread
    Dim MyTrans As SqlTransaction
    Dim Cmd As New SqlCommand
    Dim DataString As String
    Dim ssql As String
    Dim strcn As String = "Data Source=" & gserver & ";Persist Security Info=False;User ID= '" & SQL_UserName & "' ;Pwd= '" & SQL_Password & "'; Initial Catalog= " & gDatabase & ";"
    Public Enum genum
        Add = 1
        Update = 2
        Freeze = 3
        unFreeze = 4
        View = 5
        Delete = 6
    End Enum
    Function getvalue(ByVal QryString As String)
        Dim objVariable As Object
        Try
            If Myconn.State <> ConnectionState.Open Then
                openConnection()
            End If
            Cmd.CommandTimeout = 99999999
            Cmd.Connection = Myconn
            Cmd.CommandText = QryString
            Cmd.CommandType = CommandType.Text
            objVariable = Cmd.ExecuteScalar()
            Myconn.Close()
            Return objVariable
        Catch ex As Exception
            MessageBox.Show("Error in Retriveing records : " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        Finally
            Myconn.Close()
        End Try
    End Function
    Public Function getDataSet(ByVal strSQL As String, ByVal Tabname As String)
        Dim dt As New DataTable
        Try
            If Myconn.State <> ConnectionState.Open Then
                openConnection()
            End If
            gadapter = New SqlDataAdapter(strSQL, Myconn)
            gadapter.SelectCommand.CommandTimeout = 99999999
            gadapter.Fill(dt)
            dt.TableName = Tabname
            If gdataset.Tables.Contains(Tabname) = True Then
                gdataset.Tables.Remove(Tabname)
            End If
            gdataset.Tables.Add(dt)
        Catch ex As Exception
            MessageBox.Show("Error in retrieving records :" & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        Finally
            closeConnection()
        End Try
    End Function
    Public Function getCompanyinfo(ByVal strSQL As String, ByVal Tabname As String)
        Dim dt As New DataTable
        Try
            Call GetfrontConnection()
            gadapter = New SqlDataAdapter(strSQL, Myconn)
            gadapter.Fill(dt)
            gadapter.SelectCommand.CommandTimeout = 99999999
            dt.TableName = Tabname
            If gdataset.Tables.Contains(Tabname) = True Then
                gdataset.Tables.Remove(Tabname)
            End If
            gdataset.Tables.Add(dt)
        Catch ex As Exception
            MessageBox.Show("Error in Retriveing Data as " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        Finally
            closeConnection()
        End Try
    End Function
    Public Function MoreTrans(ByVal str() As String)
        Dim i As Integer
        Try
            If Myconn.State <> ConnectionState.Open Then
                openConnection()
            End If
            MyTrans = Myconn.BeginTransaction()
            Cmd.CommandTimeout = 999999999
            Cmd.Transaction = MyTrans
            Cmd.Connection = Myconn
            For i = 0 To str.Length - 1
                If str(i) Is Nothing = False Then
                    Cmd.CommandText = str(i)
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()
                End If
            Next i
            MyTrans.Commit()
            MessageBox.Show("Transaction Completed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Myconn.Close()
        Catch ex As Exception
            MyTrans.Rollback()
            Myconn.Close()
            MessageBox.Show("Error in Retriveing Data as " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    Public Sub dataOperation(ByVal genum As Integer, ByVal ssql As String, Optional ByVal Tabname As String = "MyTable")
        Try
            If Myconn.State <> ConnectionState.Open Then
                openConnection()
            End If
            gtrans = Myconn.BeginTransaction
            Select Case genum
                '''****************************** $ Insert record into Database $ **************************'''
            Case 1
                    gcommand = New SqlCommand(ssql, Myconn)
                    gcommand.Transaction = gtrans
                    gcommand.CommandTimeout = 99999999
                    gcommand.ExecuteNonQuery()
                    gtrans.Commit()
                    'MessageBox.Show("Record Saved Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '''**************************** $ Update record into Database $ *************************'''
                Case 2
                    gcommand = New SqlCommand(ssql, Myconn)
                    gcommand.Transaction = gtrans
                    gcommand.CommandTimeout = 99999999
                    gcommand.ExecuteNonQuery()
                    gtrans.Commit()
                    'MessageBox.Show("Record Updated Successfully ", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '''**************************** $ Freeze record into Database $ **************************'''
                Case 3
                    gcommand = New SqlCommand(ssql, Myconn)
                    gcommand.Transaction = gtrans
                    gcommand.CommandTimeout = 99999999
                    gcommand.ExecuteNonQuery()
                    gtrans.Commit()
                    'MessageBox.Show("Record Freezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    '''***************************** $ UnFreezed record into Database $ ************************'''
                Case 4
                    gcommand = New SqlCommand(ssql, Myconn)
                    gcommand.Transaction = gtrans
                    gcommand.CommandTimeout = 99999999
                    gcommand.ExecuteNonQuery()
                    gtrans.Commit()
                    'MessageBox.Show("Record Unfreezed Successfully", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Case 5
                    '****************************** $ Always Give Full Select Statement without Any Condition $ *******'''
                    gadapter = New SqlDataAdapter(ssql, Myconn)
                    If gdataset.Tables.Contains(Tabname) = True Then
                        gdataset.Tables.Remove(Tabname)
                    End If
                    gadapter.SelectCommand.CommandTimeout = 99999999
                    gadapter.Fill(gdataset.Tables(Tabname))
                    gtrans.Commit()
                Case 6
                    gcommand = New SqlCommand(ssql, Myconn)
                    gcommand.Transaction = gtrans
                    gcommand.CommandTimeout = 99999999
                    gcommand.ExecuteNonQuery()
                    gtrans.Commit()
            End Select
        Catch ex As Exception
            gtrans.Rollback()
            MessageBox.Show("Error in Retriveing Data as " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Finally
            closeConnection()
        End Try
    End Sub
    Public Sub openConnection()
        Try
            If Trim(gserver & "") <> "" Then
                sqlconnection = "Data Source=" & gserver & ";Persist Security Info=False;User ID= '" & SQL_UserName & "' ;Pwd= '" & SQL_Password & "'; Initial Catalog= " & gDatabase & ";"
                'sqlconnection = "Data Source=" & gserver & ";Persist Security Info=False;User ID= '" & SQL_UserName & "' ;Pwd= '" & SQL_Password & "'; Initial Catalog= RSI1112;"

                'sqlconnection = "Data Source=" & gserver & ";Persist Security Info=False;User ID= '" & SQL_UserName & "' ;Pwd=; Initial Catalog= " & gDatabase & ";"
            Else
                sqlconnection = "Data Source= (local);Persist Security Info=False;User ID='" & SQL_UserName & "' ;Pwd= '" & SQL_Password & "';Initial Catalog= " & gDatabase & ";"
            End If
            Call closeConnection()
            Myconn.ConnectionString = sqlconnection
            Myconn.Open()
        Catch ex As Exception
            MessageBox.Show("!! Warning !!Your system is not connected with SERVER", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub GetfrontConnection()
        Try
            If Trim(gserver & "") <> "" Then
                sqlconnection1 = "Data Source=" & gserver & ";Persist Security Info=False;User ID='" & SQL_UserName & "' ;Pwd= '" & SQL_Password & "';Initial Catalog= MASTER;"
                'sqlconnection1 = "Data Source=" & gserver & ";Persist Security Info=False;User ID='" & SQL_UserName & "' ;Pwd=;Initial Catalog= MASTER;"
            Else
                sqlconnection1 = "Data Source= (local);Persist Security Info=False;User ID='" & SQL_UserName & "' ;Pwd= '" & SQL_Password & "'; Initial Catalog= MASTER;"
            End If
            Call closeConnection()
            Myconn.ConnectionString = sqlconnection1
            Myconn.Open()
        Catch ex As Exception
            MessageBox.Show("!! Warning !!Your system is not connected with SERVER", MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Sub
        End Try
    End Sub
    Public Sub closeConnection()
        If Myconn.State = ConnectionState.Open Then
            Myconn.Close()
        End If
    End Sub
    Public Function GetValues(ByVal ssql As String) As DataTable
        Dim Dt As New DataTable
        Dim Sqladapter As New SqlDataAdapter(ssql, Myconn)
        Try
            If Myconn.State <> ConnectionState.Open Then
                openConnection()
            End If
            Sqladapter.SelectCommand.CommandTimeout = 99999999
            Sqladapter.Fill(Dt)
            Return Dt
        Catch ex As Exception
            MessageBox.Show("Error in Retriveing Data as " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        Finally
            closeConnection()
        End Try
    End Function
    Public Function ExcuteStoreProcedure(ByVal qry As String)
        Dim i As Integer
        Myconn.ConnectionString = sqlconnection
        Try
            If Myconn.State <> ConnectionState.Open Then
                openConnection()
            End If
            MyTrans = Myconn.BeginTransaction()
            Cmd.CommandTimeout = 99999999
            Cmd.Transaction = MyTrans
            Cmd.Connection = Myconn
            Cmd.CommandText = qry
            Cmd.CommandType = CommandType.Text
            Cmd.ExecuteNonQuery()
            MyTrans.Commit()
            Myconn.Close()
        Catch ex As Exception
            MyTrans.Rollback()
            Myconn.Close()
            MessageBox.Show("Error in Retriveing Data as " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    Public Function MoreTrans1(ByVal str() As String)
        Dim i As Integer
        Try
            If Myconn.State <> ConnectionState.Open Then
                openConnection()
            End If
            MyTrans = Myconn.BeginTransaction()
            Cmd.CommandTimeout = 99999999
            Cmd.Transaction = MyTrans
            Cmd.Connection = Myconn
            For i = 0 To str.Length - 1
                If str(i) Is Nothing = False Then
                    Cmd.CommandText = str(i)
                    Cmd.CommandType = CommandType.Text
                    Cmd.ExecuteNonQuery()
                End If
            Next i
            MyTrans.Commit()
            Myconn.Close()
        Catch ex As Exception
            MyTrans.Rollback()
            Myconn.Close()
            MessageBox.Show("Error in Retriveing Data as " & ex.Message, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Function
        End Try
    End Function
    Function getdata(ByVal qry As String, ByVal qrytab As String)
        Dim datatb As New DataSet
        If Myconn.State <> ConnectionState.Open Then
            openConnection()
        End If
        Dim daa As New SqlDataAdapter(qry, Myconn)
        daa.SelectCommand.CommandTimeout = 99999999
        daa.Fill(datatb, qrytab)
        Myconn.Close()
        Return datatb
    End Function
    Public Function Getconnection() As String
        Try
            sqlconnection = " Data Source =" & gserver & ";Persist Security Info=False;User ID='" & SQL_UserName & "' ;Pwd= '" & SQL_Password & "';Initial Catalog=" & gDatabase & ";"
            'sqlconnection = "Data Source=" & gserver & ";Persist Security Info=False;User ID=sa; Initial Catalog= " & gDatabase & ";"
            Return sqlconnection
        Catch ex As Exception
            MessageBox.Show("!! Warning !!Your system is not connected with SERVER, Bcoz " & ex.Message.ToString, MyCompanyName, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Exit Function
        End Try
    End Function
    Public Function FileInfo(ByVal MyFilePath As String)
        If File.Exists(MyFilePath) Then
            Dim MyFile As New FileInfo(MyFilePath)
            Filepath = MyFilePath
            FileSize = MyFile.Length
            dtCreationDate = MyFile.CreationTime
            dtLastAccessTime = MyFile.LastAccessTime
            dtLastWriteTime = MyFile.LastWriteTime
        End If
    End Function
    Public Function chkMonthClose(ByVal dtDate As DateTimePicker, ByVal intMsgYesNo As Int16) As Boolean
        chkMonthClose = True
        strSqlString = "SELECT ISNULL(GLOBALCLOSE,'') AS GLOBALCLOSE FROM MONTHCLOSE WHERE MONTHNO = MONTH('" & Format(dtDate.Value, "dd-MMM-yyyy") & "') "
        getDataSet(strSqlString, "MONTHCLOSE")
        If gdataset.Tables("MONTHCLOSE").Rows.Count > 0 Then
            If Trim(gdataset.Tables("MONTHCLOSE").Rows(0).Item("GLOBALCLOSE")) = "Y" Then
                If intMsgYesNo = 1 Then
                    MessageBox.Show("For This Month Transaction is Closed....", gCompanyname, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                End If
                chkMonthClose = False
                dtDate.Focus()
            End If
        End If
    End Function
    Public Function AddBillMatching(ByVal vVoucherNo As String, ByVal vVoucherType As String, ByVal vVoucherCategory As String, ByVal vVoucherDate As Date, ByVal vAccountcode As String, ByVal vSubcode As String, ByVal vAmount As Double, ByVal RVoucherno As String, ByVal RVoucherDate As Date, ByVal RVoucherType As String, ByVal RAdjustedAmount As Double, ByVal RvoucherCategory As String, ByVal RowId As Double, ByVal PrevAmt As Double, ByVal GridRowno As Integer, ByVal Refno As String, ByVal RefDt As Date, ByVal Refamt As Double, ByVal Batchno As Long, ByVal RAmount As Double) As String()
        Dim Vsql(4) As String
        If Val(RAdjustedAmount) > 0 Then
            'Vsql(0) = "Update Outstanding Set Avoucherno='" & RVoucherno & "',AvoucherType='" & RVoucherType & "',GridRowNo=" & GridRowno & ",Adjusted=(isnull(Adjusted,0) - " & PrevAmt & " ) + " & RAdjustedAmount & " where voucherno ='" & vVoucherNo & "' And Vouchertype='" & vVoucherType & "' And VoucherCAtegory='" & vVoucherCategory & "' and slcode='" & vSubcode & "' AND RowId=" & RowId
            Vsql(0) = "Update Outstanding Set Avoucherno='" & RVoucherno & "',AvoucherType='" & RVoucherType & "',GridRowNo=" & GridRowno & ",Adjusted=(isnull(Adjusted,0) - " & 0 & " ) + " & RAdjustedAmount & " where voucherno ='" & vVoucherNo & "' And Vouchertype='" & vVoucherType & "' and slcode='" & vSubcode & "' AND RowId=" & RowId

            'Vsql(0) = "Update Outstanding Set Avoucherno='" & RVoucherno & "',AvoucherType='" & RVoucherType & "',GridRowNo=" & GridRowno & ",Adjusted=(isnull(Adjusted,0) - " & 0 & " ) + " & RAdjustedAmount & " where voucherno ='" & vVoucherNo & "' And Vouchertype='" & vVoucherType & "' And VoucherCAtegory='" & vVoucherCategory & "' and slcode='" & vSubcode & "' AND RowId=" & RowId

            Vsql(1) = "Insert into MATCHING(VoucherNo,VoucherType,VoucherCategory,VoucherDate,"
            Vsql(1) = Vsql(1) & " AccountCode,SlCode,Amount,AvoucherNo,AvoucherDate,AvOucherType,"
            Vsql(1) = Vsql(1) & " AdjustedAmount,AvoucherCategory,OutRowId,GridRowNo,Ref_no,Ref_Dt,Ref_amt,Flag,AvoucherAmt,Batchno) values("
            Vsql(1) = Vsql(1) & "'" & Trim(vVoucherNo) & "',"
            Vsql(1) = Vsql(1) & "'" & Trim(vVoucherType) & "',"
            Vsql(1) = Vsql(1) & "'" & Trim(vVoucherCategory) & "',"
            Vsql(1) = Vsql(1) & "'" & Format(vVoucherDate, "dd-MMM-yyyy") & "',"
            Vsql(1) = Vsql(1) & "'" & Trim(vAccountcode) & "',"
            Vsql(1) = Vsql(1) & "'" & Trim(vSubcode) & "',"
            Vsql(1) = Vsql(1) & Format(Val(vAmount), "0.00") & ","
            Vsql(1) = Vsql(1) & "'" & Trim(RVoucherno) & "',"
            Vsql(1) = Vsql(1) & "'" & Format(RVoucherDate, "dd-MMM-yyyy") & "',"
            Vsql(1) = Vsql(1) & "'" & Trim(RVoucherType) & "',"
            Vsql(1) = Vsql(1) & Format(Val(RAdjustedAmount), "0.00") & ","
            Vsql(1) = Vsql(1) & "'" & Trim(RvoucherCategory) & "'," & RowId & "," & GridRowno & ","
            Vsql(1) = Vsql(1) & "'" & Trim(Refno) & "',"
            Vsql(1) = Vsql(1) & "'" & Format(RefDt, "dd-MMM-yyyy") & "',"
            Vsql(1) = Vsql(1) & Format(Val(Refamt), "0.00") & ",'P',"
            Vsql(1) = Vsql(1) & Format(Val(RAmount), "0.00") & ","
            Vsql(1) = Vsql(1) & " " & Val(Batchno) & ")"
        End If

        '''Vsql(2) = "Insert into MATCHING(VoucherNo,VoucherType,VoucherCategory,VoucherDate,"
        '''Vsql(2) = Vsql(2) & " AccountCode,SlCode,Amount,AvoucherNo,AvoucherDate,AvOucherType,"
        '''Vsql(2) = Vsql(2) & " AdjustedAmount,AvoucherCategory,OutRowId,GridRowNo,Ref_no,Ref_Dt,Ref_amt,Flag,AvoucherAmt,BatchNo) values("
        '''Vsql(2) = Vsql(2) & "'" & Trim(RVoucherno) & "',"
        '''Vsql(2) = Vsql(2) & "'" & Trim(RVoucherType) & "',"
        '''Vsql(2) = Vsql(2) & "'" & Trim(RvoucherCategory) & "',"
        '''Vsql(2) = Vsql(2) & "'" & Format(RVoucherDate, "dd-MMM-yyyy") & "',"
        '''Vsql(2) = Vsql(2) & "'" & Trim(vAccountcode) & "',"
        '''Vsql(2) = Vsql(2) & "'" & Trim(vSubcode) & "',"
        '''Vsql(2) = Vsql(2) & Format(Val(RAmount), "0.00") & ","
        '''Vsql(2) = Vsql(2) & "'" & Trim(vVoucherNo) & "',"
        '''Vsql(2) = Vsql(2) & "'" & Format(vVoucherDate, "dd-MMM-yyyy") & "',"
        '''Vsql(2) = Vsql(2) & "'" & Trim(vVoucherType) & "',"
        '''Vsql(2) = Vsql(2) & Format(Val(RAdjustedAmount), "0.00") & ","
        '''Vsql(2) = Vsql(2) & "'" & Trim(vVoucherCategory) & "'," & RowId & "," & GridRowno & ","
        '''Vsql(2) = Vsql(2) & "'" & Trim(RVoucherno) & "',"
        '''Vsql(2) = Vsql(2) & "'" & Format(RVoucherDate, "dd-MMM-yyyy") & "',"
        '''Vsql(2) = Vsql(2) & Format(Val(RAmount), "0.00") & ",'S',"
        '''Vsql(2) = Vsql(2) & Format(Val(vAmount), "0.00") & ","
        '''Vsql(2) = Vsql(2) & " " & Val(Batchno) & ")"


        '''Vsql(3) = "Update Outstanding Set Avoucherno='" & vVoucherNo & "',AvoucherType='" & vVoucherType & "',GridRowNo=" & GridRowno & " where Batchno=" & Batchno & "  and slcode='" & Trim(vSubcode) & "' and Accountcode='" & vAccountcode & "'"

        Return Vsql

    End Function
    Public Sub GetMatchingDetails(ByVal AVoucherno As String, ByVal AvoucherType As String, ByVal Rowno As Integer, ByVal accountcode As String, ByVal Slcode As String)
        Dim vsql As String
        Dim MatchGridCount As Long
        Dim TableName As String
        Dim DT As New DataTable
        TableName = Trim(accountcode) & Trim("*") & Trim(Slcode) & Trim("*") & Trim(Rowno)
        vsql = "Select '" & Trim(TableName) & "' As TableName, VoucherNo,VoucherType,AdjustedAmount,AccountCode,Amount,OutRowId,0,VoucherDate,AdjustedAmount,0,GridRowNo,Ref_no,Ref_Dt,Ref_Amt,AvoucherAmt From Matching m Where "
        vsql = vsql & " m.accountCode='" & accountcode & "' AND "
        vsql = vsql & " m.SLcode='" & Trim(Slcode) & "' and "
        vsql = vsql & " m.AvoucherNo='" & AVoucherno & "'" & " And m.AvoucherType='" & AvoucherType & "' and M.GridRowNo=" & Rowno
        DT = GetValues(vsql)

        For MatchGridCount = 0 To DT.Rows.Count - 1
            DT.Rows(MatchGridCount).Item(10) = MatchGridCount + 1 'Storing Here The Match Grid Count
        Next MatchGridCount
        DT.TableName = TableName
        If gMatch.Tables.Contains(TableName) = True Then
            gMatch.Tables.Remove(TableName)
            gMatch.Tables.Add(DT)
        Else
            gMatch.Tables.Add(DT)
        End If
    End Sub
    Public Function GetMatching(ByVal VoucherNo As String, ByVal VoucherType As String) As DataTable
        Dim ssql As String
        ssql = "Select AvoucherNo,AVoucherDate,AvoucherType,AdjustedAmount From Matching Where VoucherNo='" & VoucherNo & "' And Isnull(AdjustedAmount,0) > 0 and VoucherType='" & Trim(VoucherType) & "' Order By AvoucherDate "
        If Myconn.State <> ConnectionState.Open Then
            openConnection()
        End If
        Dim Dt As New DataTable
        Dim adp As New SqlClient.SqlDataAdapter(ssql, Myconn)
        adp.SelectCommand.CommandTimeout = 99999999
        adp.Fill(Dt)
        Try
            Return Dt
        Catch ex As Exception
            Dim str As String = ex.Message
            MsgBox(str, Application.ProductName, MessageBoxButtons.OK + MsgBoxStyle.Critical)
            Return Nothing
        Finally
            closeConnection()
        End Try
    End Function
    Public Function setfous(ByVal keyascii As Integer, ByVal ctrl As Control)
        If keyascii = 13 Then
            ctrl.Focus()
        End If
    End Function
    Public Function setAsTypeMode()
        With farPoint
            For intI = 1 To 500
                For intJ = 2 To 4
                    .Row = intI
                    .Col = intJ
                    .CellType = FPSpreadADO.CellTypeConstants.CellTypeEdit
                Next
                .Col = 5
                .CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber
            Next
        End With
    End Function

    Public Function getAccountsCostCenter(ByVal strAcctCC As String)
        Dim SQLSTRING As String
        Dim VCONN As New GlobalClass

        If gBoolCostCenter = False Then
            SQLSTRING = "SELECT 'NIL' AS CATEGORY"
            VCONN.getDataSet(SQLSTRING, "ACCOUNTSGLMASTERFOR_CC")
            Exit Function
        End If

        SQLSTRING = "SELECT ACCODE, ACDESC, ISNULL(CATEGORY,'') AS CATEGORY FROM ACCOUNTSGLACCOUNTMASTER WHERE ACCODE = '" & Trim(strAcctCC) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y' and Actype Not In('CASH','BANK')"
        VCONN.getDataSet(SQLSTRING, "ACCOUNTSGLMASTERFOR_CC")
        If gdataset.Tables("ACCOUNTSGLMASTERFOR_CC").Rows.Count = 0 Then
            SQLSTRING = "SELECT ACCODE, ACDESC, ISNULL(CATEGORY,'') AS CATEGORY FROM ACCOUNTSGLACCOUNTMASTER WHERE ACDESC = '" & Trim(strAcctCC) & "' AND ISNULL(FREEZEFLAG,'N') <> 'Y'  and Actype Not In('CASH','BANK') "
            VCONN.getDataSet(SQLSTRING, "ACCOUNTSGLMASTERFOR_CC")
        End If
    End Function
    Public Function GetAccountMatching(ByVal VoucherNo As String, ByVal VoucherType As String, ByVal VoucherCategory As String, ByVal AccountCode As String, ByVal AccountDesc As String, ByVal SlCode As String, ByVal SlDesc As String, ByVal Amount As Double, ByVal AvoucherNo As String, ByVal AvoucherType As String, ByVal AdjAmt As Double) As String
        Dim Ssql As String
        Ssql = "Insert Into MatchingAccountCode(VoucherNo,VoucherType,VoucherCategory,AvoucherNo,AvoucherType,AvoucherCategory,AccountCode,AccountCodeDesc,SlCode,SubCodeDesc,Amount,AdjustedAmount) Values ("
        Ssql = Ssql & "'" & VoucherNo & "',"
        Ssql = Ssql & "'" & VoucherType & "',"
        Ssql = Ssql & "'" & VoucherCategory & "',"
        Ssql = Ssql & "'" & AvoucherNo & "',"
        Ssql = Ssql & "'" & AvoucherType & "',"
        Ssql = Ssql & "'" & AvoucherType & "',"
        Ssql = Ssql & "'" & AccountCode & "',"
        Ssql = Ssql & "'" & AccountDesc & "',"
        Ssql = Ssql & "'" & SlCode & "',"
        Ssql = Ssql & "'" & SlDesc & "',"
        Ssql = Ssql & "'" & Amount & "',"
        Ssql = Ssql & "'" & AdjAmt & "')"
        Return Ssql
    End Function
    Public Sub printheader(ByVal col As Integer, ByVal vcaption As String)
        'Filewrite.WriteLine(Space((col - 26) / 2) & Chr(14) & Chr(15) & "THE CALCUTTA SWIMMING CLUB ")
        'Filewrite.WriteLine(Space((col - 14) / 2) & Chr(14) & Chr(15) & "1,STRAND ROAD")
        'Filewrite.WriteLine(Space((col - 14) / 2) & Chr(14) & Chr(15) & "KOLKATA-700001" & Chr(18))
        'Filewrite.WriteLine(Space((col - Len(gMAINCompanyname)) / 2) & Chr(14) & Chr(15) & gMAINCompanyname & Chr(18))
        'Filewrite.WriteLine(Space((col - Len(Trim(gCompanyAddress(0)))) / 2) & Chr(14) & Chr(15) & gCompanyAddress(0) & Chr(18))
        'Filewrite.WriteLine(Space((col - Len(Trim(gCompanyAddress(1)))) / 2) & Chr(14) & Chr(15) & gCompanyAddress(1) & Chr(18))
        Filewrite.WriteLine(Chr(14) & Chr(15) & gMAINCompanyname & Chr(18))
        Filewrite.WriteLine(Chr(14) & Chr(15) & gCompanyAddress(0) & Chr(18))
        Filewrite.WriteLine(Chr(14) & Chr(15) & gCompanyAddress(1) & Chr(18))
        Filewrite.WriteLine()
        Filewrite.WriteLine(Chr(15))
        Filewrite.WriteLine(vcaption)
        vrowcnt = 6
    End Sub
    Public Function setAsReadable()
        With farPoint
            For intI = 1 To 500
                For intJ = 2 To 5
                    .Row = intI
                    .Col = intJ
                    .CellType = FPSpreadADO.CellTypeConstants.CellTypeStaticText
                Next
            Next
        End With
    End Function
    Public Sub printFOOTER()
        'Filewrite.WriteLine(Space((col - 26) / 2) & Chr(14) & Chr(15) & "THE CALCUTTA SWIMMING CLUB ")
        'Filewrite.WriteLine(Space((col - 14) / 2) & Chr(14) & Chr(15) & "1,STRAND ROAD")
        'Filewrite.WriteLine(Space((col - 14) / 2) & Chr(14) & Chr(15) & "KOLKATA-700001" & Chr(18))
        Filewrite.WriteLine("USER :- " & gUsername)
        '  Filewrite.WriteLine("DATETIME :-" & Now.Today)

        vrowcnt = 2
    End Sub
    Public Function SaveCLUBFoto(ByVal FilePath As String, ByVal Cardid As String)
        Try


            '##### IN CASE NO PHOTO SELECTED ##### 
            If Trim(FilePath) = "" Then
                Exit Function
            End If
            '##### ##### ##### ##### ##### ##### #

            Dim cn As New SqlConnection(strcn)
            Dim cmd As New SqlCommand("update accountsSetUp set ClubLogo " & _
                " = @memimage", cn)

            Dim fsPhotoFile As New FileStream(FilePath, FileMode.Open, FileAccess.Read)
            Dim bytMEMimage(fsPhotoFile.Length() - 1) As Byte
            fsPhotoFile.Read(bytMEMimage, 0, bytMEMimage.Length)
            fsPhotoFile.Close()
            Dim prm As New SqlParameter("@memimage", SqlDbType.VarBinary, _
                bytMEMimage.Length, ParameterDirection.Input, False, _
                0, 0, Nothing, DataRowVersion.Current, bytMEMimage)
            cmd.Parameters.Add(prm)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
   
End Class

