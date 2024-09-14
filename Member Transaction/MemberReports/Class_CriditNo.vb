Imports System.Data.SqlClient
Imports System.IO
Public Class Class_CriditNo
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim pageno As Integer
    Dim pagesize As Integer
    Dim SNO As Integer = 1
    Function begin()
        apppath = Application.StartupPath
    End Function

    Function buttonclick(ByVal con As String, ByVal sqlstring As String, ByVal arraystring() As String, ByVal heading() As String)

        printdata(con, sqlstring, arraystring, heading)
    End Function
    Private Function printdata(ByVal con As String, ByVal SQLSTRING As String, ByVal arraystring() As String, ByVal heading() As String)
        Dim str()() As String
        Dim i, j As Integer
        Dim dr1 As DataRow
        Dim STR0 As String
        Dim STR1 As String
        Dim STR2 As String
        Dim STR3 As String
        Dim STR4 As String
        Dim STR5 As String
        Dim STR6 As String
        Dim STR7 As String
        Dim STR8 As String
        Dim STR9 As String
        Try
            Randomize()
            ReportTitle = "CRIDIT NUMBER LIST"
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = apppath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(vFilepath)
            HEADER(arraystring, heading)
            da = New SqlDataAdapter(SQLSTRING, con)
            da.Fill(ds, "master1")
            pagesize = 10
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            For i = 0 To ds.Tables("Master1").Rows.Count - 1
                If pagesize > 55 Then
                    'Filewrite.WriteLine(Chr(12))
                    'pagesize = 0
                    PageFoter(80)
                    HEADER(arraystring, heading)
                    Filewrite.WriteLine()
                    pagesize = 10
                End If
                'Filewrite.Write("   ")

                STR1 = (ds.Tables("master1").Rows(i).Item("mcode"))
                STR2 = (ds.Tables("master1").Rows(i).Item("mname"))
                STR3 = (ds.Tables("master1").Rows(i).Item("curentstatus"))
                STR4 = (ds.Tables("master1").Rows(i).Item("CRIDITNUMBER"))
                STR5 = Format((ds.Tables("master1").Rows(i).Item("SECURITYDEPOSIT")), "0.00")

                'Filewrite.WriteLine("{0,-5}{1,-7}{2,-28}{3,-15}{4,-10}{5,-15}", SNO, STR1, STR2, STR3, STR4, STR5)

                Filewrite.WriteLine("{0,-4}{1,-10}{2,-30}{3,-10}{4,-15}{5,1}{6,10}", "|" & SNO, "|" & STR1, "|" & STR2, "|" & STR3, "|" & STR4, "|", STR5 & "|")

                SNO = SNO + 1
                'Filewrite.WriteLine()
                pagesize = pagesize + 1
            Next
            PageFoter(80)
            Filewrite.Close()
            If PRINTREP = False Then
                OpenTextFile(vOutfile)
            Else
                PrintTextFile(vOutfile)
            End If
        Catch ex As Exception
            MsgBox("Data not found..!")
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
            pagesize = 0
            pageno = pageno + 1
            PageHeader(80, pageno)
            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & Chr(71) & Chr(14) & Chr(27) & Chr(45) & Chr(1))
            Filewrite.WriteLine("{0,-4}{1,-10}{2,-30}{3,-10}{4,-15}{5,1}{6,10}", "|SNo", "|CODE", "|NAME", "|STATUS", "|CRIDIT NO", "|", "DEPOSIT|")
            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & Chr(72) & Chr(20) & Chr(27) & Chr(45) & Chr(0))
            If PRINTREP = False Then Filewrite.WriteLine(StrDup(80, "_"))



            'Filewrite.WriteLine(Chr(27) & "F")
            'Filewrite.WriteLine(StrDup(80, "_"))

            'Filewrite.WriteLine("{}")
            'Filewrite.Write(Space((pagesize - CAPTION.Length) / 2))
            'Filewrite.WriteLine(CAPTION)
            'pagesize = pagesize + 1
            ''PRINTING THE CAPTION AND THE OTHER HEADINGS
            'Dim X As String
            'For Each X In STRHEADER
            '    If X <> "" Then
            '        Filewrite.Write(Space((pagesize - X.Length) / 2))

            '        Filewrite.WriteLine(X)
            '        pagesize = pagesize + 1

            '        Filewrite.Write(Space((pagesize - X.Length) / 2))
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
            ''PRINTNG THE COLUMN HEADING 
            'Filewrite.WriteLine()
            'pagesize = pagesize + 1
            'Filewrite.Write("   ")
            'For Each head In heading
            '    Filewrite.Write(head)
            '    Filewrite.Write(Space(15 - Len(head)))
            '    Filewrite.Write("  ")
            'Next
            'Filewrite.Write(heading(0))
            'Filewrite.Write(Space(10 - Len(heading(0))))
            'Filewrite.Write(heading(1))
            'Filewrite.Write(Space(30 - Len(heading(1))))
            'Filewrite.Write(heading(2))
            'Filewrite.Write(Space(10 - Len(heading(2))))
            'Filewrite.Write(heading(3))
            'Filewrite.Write(Space(15 - Len(heading(3))))
            'Filewrite.Write(heading(4))




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
