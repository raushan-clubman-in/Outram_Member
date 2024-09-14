Imports System.Data.SqlClient
Imports System.IO
Public Class SpecialAbsenteeListReport
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim pageno As Integer
    Dim pagesize As Integer
    Function begin()
        apppath = Application.StartupPath
    End Function

    Function buttonclick(ByVal con As String, ByVal sqlstring As String, ByVal arraystring() As String, ByVal heading() As String)
        ' HEADER(arraystring, heading)
        printdata(con, sqlstring, arraystring, heading)
    End Function
    Private Function printdata(ByVal con As String, ByVal SQLSTRING As String, ByVal arraystring() As String, ByVal heading() As String)
        Dim str As String
        Dim i, j As Integer
        Dim dr As DataRow
        Dim LP As Integer = 8
        Dim sno As Integer = 0
        Dim PrintStr(20), fromDt, toDt As String
        Try
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = apppath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(vFilepath)
            HEADER(arraystring, heading)
            SQLSTRING = SQLSTRING & " ORDER BY MCODE,EFFECTIVEFROM DESC"
            da = New SqlDataAdapter(SQLSTRING, con)
            da.Fill(ds, "master1")
            Filewrite.WriteLine()
            pagesize = 15
            For Each dr In ds.Tables("Master1").Rows
                If pagesize > 80 Then
                    pagesize = 15
                    PageFoter(80)
                    'Filewrite.WriteLine(Chr(12))
                    HEADER(arraystring, heading)
                Else
                    If str <> dr("mcode") And LP >= 8 Then
                        Filewrite.WriteLine(StrDup(80, "-"))
                        pagesize = pagesize + 1
                        sno = sno + 1
                        ' Filewrite.WriteLine("{0,5}{1,30}{2,15}{3,15}", sno, Trim(dr("MCODE")) & ": " & Trim(dr("MNAME")), "From", "To")
                        PrintStr(0) = sno
                        PrintStr(1) = Trim(dr("MCODE"))
                        PrintStr(2) = Trim(dr("MNAME"))
                        PrintStr(3) = Trim(dr("CONTADD1"))
                        PrintStr(4) = Trim(dr("CONTADD2"))
                        PrintStr(5) = Trim(dr("CONTADD3"))
                        PrintStr(6) = Trim(dr("CONTSTATE")) & "PIN:" & Trim(dr("CONTPIN"))
                        str = dr("mcode")
                        'Filewrite.Write("   ")
                        'Filewrite.Write(Trim(dr("MCODE")))
                        'Filewrite.Write("   ")
                        'Filewrite.WriteLine(Trim(dr("MNAME")))
                        'pagesize = pagesize + 1
                        'Filewrite.Write("   ")
                        'Filewrite.Write(Trim(dr("CONTSTATE")))
                        'Filewrite.Write(",  ")
                        'Filewrite.Write(Trim(dr("CONTPIN")))
                        'Filewrite.Write(Space(55 - Len((dr("contstate") + ",  " + dr("contpin")))))
                        pagesize = pagesize + 5
                        Filewrite.WriteLine("{0,-5}{1,-45}{2,-15}{3,-15}", PrintStr(0), PrintStr(1) & ": " & PrintStr(2), "", "")
                        LP = 3
                    Else
                        'Filewrite.Write(Space(58))
                    End If

                    If (IsDBNull(dr("EFFECTIVEFROM"))) = False Then
                        fromDt = Format(dr("EFFECTIVEFROM"))
                    Else
                        fromDt = ""
                    End If
                    If (IsDBNull(dr("EFFECTIVETO"))) = False Then
                        toDt = Format(dr("EFFECTIVETO"))
                    Else
                        toDt = ""
                    End If
                    'toDt = Format(dr("EFFECTIVETO"))

                    Filewrite.WriteLine("{0,-5}{1,-45}{2,-15}{3,-15}", "", PrintStr(LP), fromDt, toDt)

                    LP = LP + 1
                    'Filewrite.Write(Format(dr("EFFECTIVEFROM"), "dd-MMM-yy"))
                    'Filewrite.Write(Space(5))
                    'Filewrite.Write(Format(dr("EFFECTIVETO"), "dd-MMM-yy"))
                    'Filewrite.WriteLine()
                    pagesize = pagesize + 1
                End If


            Next

            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Function HEADER(ByVal STRHEADER() As String, ByVal heading() As String)
        Dim CAPTION As String = "THE CALCUTTA SWIMMING CLUB"
        Dim I, COLUMNCOUNT As Integer
        Dim CHECKEDITEMSNO As Integer
        Dim head As String
        pagesize = 0
        'counts the colummns in the checkbox and assign page size 
        Try
            pageno = pageno + 1
            PageHeader(80, pageno)

            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & Chr(71) & Chr(14) & Chr(27) & Chr(45) & Chr(1))
            Filewrite.WriteLine("{0,-5}{1,-45}{2,-15}{3,-15}", "SNo", "Name and Address", "From", "To")
            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & Chr(72) & Chr(20) & Chr(27) & Chr(45) & Chr(0))
            If PRINTREP = False Then Filewrite.WriteLine(StrDup(80, "_"))

            'Filewrite.Write(Space((80 - CAPTION.Length) / 2))
            'Filewrite.WriteLine(CAPTION)
            'pagesize = pagesize + 1
            'PRINTING THE CAPTION AND THE OTHER HEADINGS
            'Dim X As String
            'For Each X In STRHEADER
            '    If X <> "" Then
            '        Filewrite.Write(Space((80 - X.Length) / 2))

            '        Filewrite.WriteLine(X)
            '        pagesize = pagesize + 1

            '        Filewrite.Write(Space((80 - X.Length) / 2))
            '        For I = 1 To X.Length - 1
            '            Filewrite.Write("=")
            '        Next
            '        Filewrite.WriteLine()
            '        pagesize = pagesize + 1
            '    End If
            'Next
            'Filewrite.WriteLine()
            'pagesize = pagesize + 1
            'Filewrite.Write("   ")
            'Filewrite.Write("Date : ")
            'Filewrite.Write(Format(Today.Now, "dd-MM-yyyy"))
            'Filewrite.Write(Space(50))
            'Filewrite.Write("PAGE NO : ")
            'pageno = pageno + 1
            'Filewrite.Write(" ")
            'Filewrite.Write(pageno)

            'Filewrite.WriteLine()
            'pagesize = pagesize + 1

            'Filewrite.Write("   ")
            'For I = 0 To 80
            '    Filewrite.Write("-")
            'Next
            '''PRINTNG THE COLUMN HEADING 
            'Filewrite.WriteLine()
            'pagesize = pagesize + 1
            'Filewrite.Write("   ")

            'Filewrite.Write(heading(0))
            'Filewrite.Write(Space(32 - Len(head)))
            'Filewrite.Write("ABSENTEE --->>")
            'Filewrite.Write(Space(5))
            'Filewrite.Write(heading(1))
            'Filewrite.Write(Space(10 - Len(head)))
            'Filewrite.Write(heading(2))
            'Filewrite.Write(Space(10 - Len(head)))

            'Filewrite.WriteLine()
            'pagesize = pagesize + 1
            'Filewrite.Write("   ")
            'For I = 0 To 80
            '    Filewrite.Write("-")
            'Next
        Catch ex As Exception
            Exit Function
        End Try
    End Function



End Class
