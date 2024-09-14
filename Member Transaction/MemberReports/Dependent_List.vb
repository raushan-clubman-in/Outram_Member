Imports System.data.sqlclient
Imports System.io
Public Class dRegister
    Public pageno, pagesize As Integer
    Dim gconnection As New GlobalClass
    Dim dr As DataRow
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
            'Filewrite.Write(StrDup(150, "="))
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
                    ' Filewrite.WriteLine("SNO : " & Mid(Format(C), 1, 6) & Space(6 - Len(Mid(Format(C), 1, 6))) & "")
                    Dim opstr As String
                    opstr = "|" & Mid(Trim(CStr(dr("MEM_CODE"))), 1, 12) & Space(12 - Len(Mid(Trim(CStr(dr("MEM_CODE"))), 1, 12))) & "" & "|"
                    opstr = opstr & Mid(Trim(CStr(dr("CHILD_NM"))), 1, 28) & Space(30 - Len(Mid(Trim(CStr(dr("CHILD_NM"))), 1, 30))) & "" & "|"
                    opstr = opstr & Mid(Trim(CStr(dr("RELATION"))), 1, 20) & Space(20 - Len(Mid(Trim(CStr(dr("RELATION"))), 1, 20))) & "" & "|"
                    opstr = opstr & Mid(Trim(CStr(dr("CHILD_DOB"))), 1, 17) & Space(17 - Len(Mid(Trim(CStr(dr("CHILD_DOB"))), 1, 17))) & "" & "|"
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
            Filewrite.WriteLine("{0,-5}{1,-11}{2,-25}{3,-20}{4,-19}", Mid(Address1, 1, 30) & Space(5), " ", Mid(Trim(HEADING(0)), 1, 32), Space(1) & DatePart(DateInterval.Year, MSKFROMDATE, FirstDayOfWeek.Sunday), " " & " " & " " & " ")
            pagesize = pagesize + 1
            Filewrite.WriteLine("{0,-5}{1,-11}{2,-25}", Mid(Address2, 1, 30), " ", Mid(StrDup(Len(Trim(HEADING(0))), "-"), 1, 18))
            pagesize = pagesize + 1
            'Filewrite.WriteLine("{0,60}{1,-8}", " ", "DEPENDENT (AGE-16) LIST")
            'Filewrite.WriteLine("                                           FOR THE PERIOD OF " & Format(MSKFROMDATE, "MMM dd,yyyy") & " " & "To" & " " & Format(MSKTODATE, "MMM dd,yyyy"))
            'pagesize = pagesize + 1
            Filewrite.WriteLine("{0,75}{1,-10}", " ", "PAGE : " & pageno)
            pagesize = pagesize + 1
            Filewrite.WriteLine(StrDup(90, "="))
            pagesize = pagesize + 1
            Filewrite.WriteLine("| MCODE	 |  DEPENDENT NAME              |RELATIONSHIP	     |  DOB            | ")
            'Filewrite.WriteLine("| MCODE	 |  DEPENDENT NAME              |RELATIONSHIP	     |  DOB            | AGE |")
            Filewrite.WriteLine(StrDup(90, "="))
            pagesize = pagesize + 4
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class