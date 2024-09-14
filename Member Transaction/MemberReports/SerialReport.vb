Imports System.Data.SqlClient
Imports System.IO
Public Class SerialReport
    Dim x As String
    Dim ht As New Hashtable
    Dim datahashtable As New Hashtable
    Dim ds As New DataSet
    Dim da As New SqlDataAdapter
    Dim LINECOUNT As Integer = 0
    Dim con As New SqlConnection("Data Source=ServerName;User ID=sa;Initial Catalog=" & ServerName)
    Dim sqlstring As String
    Dim PAGESIZE As Integer
    Dim pageno As Integer = 0
    Dim arraystring(4) As String
    Public Sub New(ByVal X As String, ByVal Y As String, ByVal Z As String, ByVal A As String)
        arraystring(0) = X
        arraystring(1) = Y
        arraystring(2) = Z
        arraystring(3) = A
    End Sub
    Function BEGIN()
        ht.Add("Member Code", "MCODE")
        ht.Add("Member Name", "MNAME")
        ht.Add("Status", "CurentStatus")
        ht.Add("H/P Locker", "HPLocker")
        ht.Add("GDR Locker", "GDRLocker")
        ht.Add("LDR Locker", "LDRLocker")
        ht.Add("Occupation", "OCCUPATION")
        ht.Add("BankAcNo", "BANKACNO")
        ht.Add("Banker", "BANKER")
        ht.Add("Hobbies", "HOBBIES")
        ht.Add("OtherInfo", "OTHERINFO")
        ht.Add("Credit No", "criditNumber")
        ht.Add("Deposit", "SecurityDeposit")


        'hashtable for the size of the column
        datahashtable.Add("Member Code", 15)
        datahashtable.Add("Member Name", 20)
        datahashtable.Add("Status", 10)
        datahashtable.Add("Occupation", 15)
        datahashtable.Add("Hobbies", 15)
        datahashtable.Add("OtherInfo", 15)
        datahashtable.Add("H/P Locker", 15)
        datahashtable.Add("GDR Locker", 15)
        datahashtable.Add("LDR Locker", 15)
        datahashtable.Add("BankAcNo", 10)
        datahashtable.Add("Banker", 10)
        datahashtable.Add("Credit No", 10)
        datahashtable.Add("Deposit", 15)


        'datahashtable.Add("billing", 4)
        'datahashtable.Add("corcode", 4)

        'datahashtable.Add("name", 15)
        'datahashtable.Add("city", 15)
        'datahashtable.Add("state", 15)
        'datahashtable.Add("country", 15)
        'datahashtable.Add("pincode", 10)
        'datahashtable.Add("phno", 15)
        'datahashtable.Add("email", 30)
        'datahashtable.Add("mobile", 12)
        'datahashtable.Add("fax", 10)
        'datahashtable.Add("fromdate", 10)
        'datahashtable.Add("todate", 10)

        'datahashtable.Add("date1", 10)
        'datahashtable.Add("remarks", 20)
        apppath = Application.StartupPath
    End Function

    Function BUTTONCLICK(ByVal CHKBOX As CheckedListBox, ByVal tablename As String)
        rowsdata(arraystring, CHKBOX, tablename)
    End Function

    Private Function rowsdata(ByVal arraystring() As String, ByVal CHKBOX As CheckedListBox, ByVal tablename As String)
        Dim HTENUM As IDictionaryEnumerator = ht.GetEnumerator
        Dim dataht As IDictionaryEnumerator = datahashtable.GetEnumerator
        Dim dt As New DataTable
        Dim I, COLUMNCOUNT As Integer
        Dim drow As DataRow
        Dim dcol As DataColumn
        Try
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = apppath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(vFilepath)
            COLUMNCOUNT = CHKBOX.CheckedItems.Count()
            If COLUMNCOUNT > 9 Then
                MessageBox.Show("CANT PRINT MORE THAN 9 COLUMNS")
                For I = 0 To CHKBOX.Items.Count - 1
                    CHKBOX.SetItemCheckState(I, CheckState.Checked)
                Next
                CHKBOX.Focus()
                Exit Function
            End If
            HEADER(arraystring, CHKBOX)
            printdata(CHKBOX, tablename)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Private Function printdata(ByVal CHKBOX As CheckedListBox, ByVal tablename As String)
        Dim chk As Object
        Dim x As Integer
        Dim drow As DataRow
        Dim ds As New DataSet
        Dim dcol As DataColumn
        Dim str, str1 As String
        Dim arr1(10) As String
        Dim arr2(10) As Integer
        Dim spaces, n As Integer
        Dim len1 As Integer
        Dim HTENUM As IDictionaryEnumerator = ht.GetEnumerator
        Dim dataht As IDictionaryEnumerator = datahashtable.GetEnumerator
        Dim i As Integer = 0
        Dim j As Integer = 0
        Try
            For Each chk In CHKBOX.CheckedItems
                While HTENUM.MoveNext
                    If chk = HTENUM.Key Then
                        arr1(i) = CStr(HTENUM.Value)
                        i = i + 1
                    End If
                End While
                HTENUM.Reset()
                While dataht.MoveNext
                    If chk = dataht.Key Then
                        arr2(j) = CInt(dataht.Value)
                        j = j + 1
                    End If
                End While
                dataht.Reset()
            Next
            sqlstring = "select "
            For x = 0 To i - 1
                sqlstring = sqlstring & arr1(x) & ","
            Next
            sqlstring = FinalString
            '"select MCODE,MNAME,CurentStatus,HPLocker,GDRLocker,LDRLocker from membermaster where hplocker <> '' or gdrlocker <> '' or ldrlocker <> ''"
            'sqlstring = Mid(sqlstring, 1, sqlstring.Length - 1) & " from " & tablename
            'MsgBox(sqlstring)

            'If CHKBOX.CheckedItems.Count = 0 Then
            'MsgBox("NO ITEMS SELECTED")

            'Else
                da = New SqlDataAdapter(sqlstring, con)
                da.Fill(ds, "master1")

                Dim ssql, ssql1 As String
                Filewrite.WriteLine()
                LINECOUNT = LINECOUNT + 1

                For Each drow In ds.Tables("master1").Rows
                    j = 0
                    Filewrite.WriteLine()
                    LINECOUNT = LINECOUNT + 1
                    For Each dcol In ds.Tables("MASTER1").Columns

                        If Len(drow(dcol.ToString())) > Convert.ToInt32(arr2(j)) Then
                            ssql = Mid(drow(dcol.ToString()), 1, arr2(j))
                        Else
                            ssql = Mid(drow(dcol.ToString()), 1, arr2(j)) & Space(arr2(j) - Len(drow(dcol)))
                        End If
                        ssql1 = ssql1 & ssql & "  "
                        ssql = ""
                        j = j + 1
                    Next
                    Filewrite.Write("   ")
                    If LINECOUNT > 50 Then
                        LINECOUNT = 0
                        Filewrite.WriteLine()
                        LINECOUNT = LINECOUNT + 1

                        Filewrite.Write("   ")
                        For i = 0 To PAGESIZE
                            Filewrite.Write("-")
                        Next
                        Filewrite.WriteLine(Chr(12))
                        HEADER(arraystring, CHKBOX)
                        Filewrite.WriteLine()
                        Filewrite.Write("   ")
                    End If
                    Filewrite.WriteLine(ssql1)
                    LINECOUNT = LINECOUNT + 1
                    ssql1 = ""
                Next


                Filewrite.Close()
                OpenTextFile(vOutfile)
            'End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Function HEADER(ByVal STRHEADER() As String, ByVal CHKBOX As CheckedListBox)
        Dim CAPTION As String = "THE CALCUTTA SWIMMING CLUB"
        Dim I As Integer
        Dim columncount As Integer = 0
        Dim CHECKEDITEMSNO As Integer
        Dim CHK As Object

        Dim HTENUM As IDictionaryEnumerator = ht.GetEnumerator
        Dim dataht As IDictionaryEnumerator = datahashtable.GetEnumerator
        'counts the colummns in the checkbox and assign page size 
        columncount = CHKBOX.CheckedItems.Count()
        Try
            If columncount > 4 Then
                'PRINT IN 130 CHARS
                PAGESIZE = 130
                Filewrite.Write(Space(Convert.ToInt32((PAGESIZE - CAPTION.Length) / 2)))
                Filewrite.WriteLine(CAPTION)
                LINECOUNT = LINECOUNT + 1
                'PRINTING THE CAPTION AND THE OTHER HEADINGS
                Dim X As String
                For Each X In STRHEADER
                    If X <> "" Then
                        Filewrite.Write(Space((PAGESIZE - X.Length) / 2))
                        Filewrite.WriteLine(X)
                        LINECOUNT = LINECOUNT + 1
                        Filewrite.Write(Space((PAGESIZE - X.Length) / 2))
                        For I = 1 To X.Length - 1
                            Filewrite.Write("=")
                        Next
                        Filewrite.WriteLine()
                        LINECOUNT = LINECOUNT + 1
                    End If
                Next
                Filewrite.WriteLine()
                LINECOUNT = LINECOUNT + 1
                Filewrite.Write("   ")
                Filewrite.Write("Date : ")
                Filewrite.Write(Format(Today.Now, "dd-MM-yyyy"))
                If PAGESIZE = 80 Then
                    Filewrite.Write(Space(50))
                Else
                    Filewrite.Write(Space(100))
                End If
                Filewrite.Write("PAGE NO : ")
                pageno = pageno + 1
                Filewrite.Write(" ")
                Filewrite.Write(pageno)

                Filewrite.WriteLine()
                LINECOUNT = LINECOUNT + 1

                Filewrite.Write("   ")
                For I = 0 To PAGESIZE
                    Filewrite.Write("-")
                Next
                'PRINTNG THE COLUMN HEADING 
                Filewrite.WriteLine()
                LINECOUNT = LINECOUNT + 1
                Filewrite.Write("   ")
                For Each CHK In CHKBOX.CheckedItems
                    While dataht.MoveNext
                        If CHK = dataht.Key Then
                            Filewrite.Write(dataht.Key)
                            Filewrite.Write(Space(dataht.Value - Len(dataht.Key)))
                            Filewrite.Write("  ")
                        End If
                    End While
                    dataht.Reset()
                Next
                Filewrite.WriteLine()
                LINECOUNT = LINECOUNT + 1
                Filewrite.Write("   ")
                For I = 0 To PAGESIZE
                    Filewrite.Write("-")
                Next
            Else
                'PRINT IN 80 CHAR
                PAGESIZE = 80
                Filewrite.Write(Space((PAGESIZE - CAPTION.Length) / 2))
                Filewrite.WriteLine(CAPTION)
                LINECOUNT = LINECOUNT + 1
                'PRINTING THE CAPTION AND THE OTHER HEADINGS
                Dim X As String
                For Each X In STRHEADER
                    If X <> "" Then
                        Filewrite.Write(Space((PAGESIZE - X.Length) / 2))

                        Filewrite.WriteLine(X)
                        LINECOUNT = LINECOUNT + 1

                        Filewrite.Write(Space((PAGESIZE - X.Length) / 2))
                        For I = 1 To X.Length - 1
                            Filewrite.Write("=")
                        Next
                        Filewrite.WriteLine()
                        LINECOUNT = LINECOUNT + 1
                    End If
                Next
                Filewrite.WriteLine()
                LINECOUNT = LINECOUNT + 1
                Filewrite.Write("   ")
                Filewrite.Write("Date : ")
                Filewrite.Write(Format(Today.Now, "dd-MM-yyyy"))
                If PAGESIZE = 80 Then
                    Filewrite.Write(Space(50))
                Else
                    Filewrite.Write(Space(100))
                End If
                Filewrite.Write("PAGE NO = ")
                pageno = pageno + 1
                Filewrite.Write(" ")
                Filewrite.Write(pageno)

                Filewrite.WriteLine()
                LINECOUNT = LINECOUNT + 1

                Filewrite.Write("   ")
                For I = 0 To PAGESIZE
                    Filewrite.Write("-")
                Next
                ''PRINTNG THE COLUMN HEADING 
                Filewrite.WriteLine()
                LINECOUNT = LINECOUNT + 1
                Filewrite.Write("   ")
                For Each CHK In CHKBOX.CheckedItems
                    While dataht.MoveNext
                        If CHK = dataht.Key Then
                            Filewrite.Write(dataht.Key)
                            Filewrite.Write(Space(CInt(dataht.Value) - CInt((dataht.Key).Length)))
                            Filewrite.Write("  ")
                        End If
                    End While
                    dataht.Reset()
                Next
                Filewrite.WriteLine()
                LINECOUNT = LINECOUNT + 1
                Filewrite.Write("   ")
                For I = 0 To PAGESIZE
                    Filewrite.Write("-")
                Next
            End If
        Catch ex As Exception
            Exit Function
        End Try
    End Function

End Class


