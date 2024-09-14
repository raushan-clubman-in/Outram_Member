Imports System.Data.SqlClient
Imports System.IO
Public Class CorporateMemberListReport
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim pageno As Integer = 1
    Dim pagesize As Integer
    Function buttonclick(ByVal con As String, ByVal sqlstring As String, ByVal arraystring() As String, ByVal heading1() As String, ByVal heading2() As String)
        'HEADER(arraystring, heading1, HEADING2)
        printdata(con, sqlstring, arraystring, heading1, heading2)
    End Function
    Private Function printdata(ByVal con As String, ByVal sqlstring As String, ByVal arraystring() As String, ByVal heading1() As String, ByVal heading2() As String)
        Dim str()() As String
        Dim i, j As Integer
        Dim cnt As Integer
        Dim dr1 As DataRow
        Dim dr2 As DataRow
        Dim STRARRAY(20) As String
        Dim corpname As String = ""
        Try
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = apppath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(vFilepath)
            da = New SqlDataAdapter(sqlstring, con)
            da.Fill(ds, "master1")
           
            pagesize = 0
            'Filewrite.WriteLine("")  
            HEADER(arraystring, heading1, heading2)
            For i = 0 To ds.Tables("Master1").Rows.Count - 1
                If pagesize > 55 Then
                    pagesize = 0
                    PageFoter(80)
                    HEADER(arraystring, heading1, heading2)
                    'PageHeader 80,PA
                    'Filewrite.WriteLine(Chr(12))

                End If
                'Filewrite.WriteLine()

                If corpname <> ds.Tables("master1").Rows(i).Item("cmcorporatename") Then

                    corpname = ds.Tables("master1").Rows(i).Item("cmcorporatename")
                    Filewrite.WriteLine()
                    'pagesize = pagesize + 1
                    'Filewrite.Write("   ")
                    STRARRAY(1) = Trim(ds.Tables("master1").Rows(i).Item("cmcorporatename")) & "( " & ds.Tables("master1").Rows(i).Item("CMCorporatecode") & " )"
                    STRARRAY(2) = Trim(ds.Tables("master1").Rows(i).Item("cmbilling"))
                    STRARRAY(3) = Trim(Format(ds.Tables("master1").Rows(i).Item("membershipfrom"), "dd-MMM-yy") & " to " & Format(ds.Tables("master1").Rows(i).Item("membershipto"), "dd-MMM-yy"))
                    STRARRAY(4) = Trim(ds.Tables("master1").Rows(i).Item("cmaddress1"))
                    STRARRAY(5) = Trim(ds.Tables("master1").Rows(i).Item("cmaddress2"))
                    STRARRAY(6) = Trim(ds.Tables("master1").Rows(i).Item("cmaddress3"))
                    STRARRAY(7) = Trim(ds.Tables("master1").Rows(i).Item("cmcity"))
                    STRARRAY(8) = Trim(ds.Tables("master1").Rows(i).Item("cmstate"))


                    Filewrite.WriteLine("{0,-35}{1,-15}{2,-25}", STRARRAY(1), STRARRAY(2), STRARRAY(3))
                    Filewrite.WriteLine(StrDup(35, "_"))
                    Filewrite.Write(IIf(STRARRAY(4) <> "", STRARRAY(4), ""), STRARRAY(4))
                    Filewrite.Write(IIf(STRARRAY(5) <> "", "  " & STRARRAY(5), ""))
                    Filewrite.WriteLine("")
                    Filewrite.Write(IIf(STRARRAY(6) <> "", STRARRAY(6), ""), STRARRAY(6))
                    Filewrite.Write(IIf(STRARRAY(7) <> "", "  " & STRARRAY(7), ""))
                    Filewrite.Write(IIf(STRARRAY(8) <> "", "  " & STRARRAY(8), ""))
                    Filewrite.WriteLine("")
                    Filewrite.WriteLine(StrDup(35, "_"))

                    'Filewrite.Write(ds.Tables("master1").Rows(i).Item("cmcorporatename"))
                    'Filewrite.Write(Space(40 - Len(ds.Tables("master1").Rows(i).Item("cmcorporatename"))))
                    'Filewrite.Write(ds.Tables("master1").Rows(i).Item("cmbilling"))
                    'Filewrite.Write(Space(15 - Len(ds.Tables("master1").Rows(i).Item("cmbilling"))))
                    'Filewrite.Write("(")
                    'Filewrite.Write(Format(ds.Tables("master1").Rows(i).Item("membershipfrom"), "dd-MMM-yy"))
                    'Filewrite.Write("  to  ")
                    'Filewrite.Write(Format(ds.Tables("master1").Rows(i).Item("membershipto"), "dd-MMM-yy"))
                    'Filewrite.Write(")")
                    'Filewrite.WriteLine()
                    'Filewrite.WriteLine()
                    'pagesize = pagesize + 2
                    'Filewrite.Write("   ")
                    'Filewrite.Write(ds.Tables("master1").Rows(i).Item("cmaddress1"))
                    'Filewrite.Write(",  ")
                    'Filewrite.Write(ds.Tables("master1").Rows(i).Item("cmaddress2"))
                    'Filewrite.WriteLine()
                    'pagesize = pagesize + 1
                    'Filewrite.Write("   ")
                    'Filewrite.Write(ds.Tables("master1").Rows(i).Item("cmaddress3"))
                    'Filewrite.Write(",  ")
                    'Filewrite.Write(ds.Tables("master1").Rows(i).Item("cmcity"))
                    'Filewrite.Write(",  ")
                    'Filewrite.Write(ds.Tables("master1").Rows(i).Item("cmstate"))
                    'Filewrite.WriteLine()
                    'Filewrite.WriteLine()
                    pagesize = pagesize + 6
                End If
                pagesize = pagesize + 1
                STRARRAY(9) = ds.Tables("master1").Rows(i).Item("mcode")
                STRARRAY(10) = ds.Tables("master1").Rows(i).Item("mname")
                STRARRAY(12) = ds.Tables("master1").Rows(i).Item("currentstatus")
                ' Filewrite.WriteLine("")
                Filewrite.WriteLine("{0,-15}{1,-35}{2,-10}{3,-20}", STRARRAY(9), STRARRAY(10), "", STRARRAY(12))
                'Filewrite.Write("   ")
                'Filewrite.Write(ds.Tables("master1").Rows(i).Item("mcode"))
                'Filewrite.Write(Space(25 - Len(ds.Tables("master1").Rows(i).Item("mcode"))))
                'Filewrite.Write(ds.Tables("master1").Rows(i).Item("mname"))
                'Filewrite.Write(Space(35 - Len(ds.Tables("master1").Rows(i).Item("mname"))))
                'Filewrite.Write(ds.Tables("master1").Rows(i).Item("corporatecode"))
                'Filewrite.Write(Space(25 - Len(ds.Tables("master1").Rows(i).Item("corporatecode"))))
                'Filewrite.Write(ds.Tables("master1").Rows(i).Item("currentstatus"))
            Next
            PageFoter(80)
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

    Private Function HEADER(ByVal STRHEADER() As String, ByVal heading1() As String, ByVal heading2() As String)
        Dim CAPTION As String = "THE CALCUTTA SWIMMING CLUB"
        Dim I, COLUMNCOUNT As Integer
        Dim CHECKEDITEMSNO As Integer
        Dim head As String
        pagesize = 0
        'counts the colummns in the checkbox and assign page size 
        Try
            'pagesize = 80
            'Filewrite.Write(Space((pagesize - CAPTION.Length) / 2))
            'Filewrite.WriteLine(CAPTION)
            PageHeader(80, pageno)
            pageno = pageno + 1
            'pagesize = pagesize + 1
            'PRINTING THE CAPTION AND THE OTHER HEADINGS
            ''Dim X As String
            ''For Each X In STRHEADER
            ''    If X <> "" Then
            ''        Filewrite.Write(Space((pagesize - X.Length) / 2))

            ''        Filewrite.WriteLine(X)
            ''        pagesize = pagesize + 1

            ''        Filewrite.Write(Space((pagesize - X.Length) / 2))
            ''        For I = 1 To X.Length - 1
            ''            Filewrite.Write("=")
            ''        Next
            ''        Filewrite.WriteLine()
            ''        pagesize = pagesize + 1
            ''    End If
            ''Next
            '  Filewrite.WriteLine()
            'pagesize = pagesize + 1
            ' Filewrite.Write("   ")
            'Filewrite.Write(Format(Today.Now, "dd-MM-yyyy"))
            'Filewrite.Write(Space(50))
            'Filewrite.Write("PAGE NO = ")
            'Filewrite.Write(" ")
            'Filewrite.Write(pageno)

            'Filewrite.WriteLine()
            'pagesize = pagesize + 1

            'Filewrite.Write("   ")

            'Filewrite.Write(StrDup(80, "-"))

            ''PRINTNG THE COLUMN HEADING 
            'If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & Chr(71) & Chr(14) & Chr(27) & Chr(45) & Chr(1))
            Filewrite.WriteLine("{0,-35}{1,-15}{2,-25}", "COMPANY NAME & ADDRESS", "BILLING BASIS", "PERIOD (FROM DATE - TO DATE)")
            Filewrite.WriteLine("{0,-15}{1,-35}{2,-10}{3,-20}", "MEMBER CODE", "MEMBER NAME", "", "STATUS")
            'If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & Chr(72) & Chr(20) & Chr(27) & Chr(45) & Chr(0))
            Filewrite.WriteLine(StrDup(80, "_"))
            'Filewrite.WriteLine()
            'pagesize = pagesize + 1
            'Filewrite.Write("   ")
            'Filewrite.Write(heading1(0))
            'Filewrite.Write(Space(40 - Len(heading1(0))))
            'Filewrite.Write(heading1(1))
            'Filewrite.Write(Space(15 - Len(heading1(1))))
            'Filewrite.Write(heading1(2))
            'Filewrite.WriteLine()
            'Filewrite.WriteLine()
            'pagesize = pagesize + 2
            'Filewrite.Write("   ")
            'For Each head In heading2
            '    Filewrite.Write(Trim(head))
            '    Filewrite.Write(Space(10))
            '    Filewrite.Write("  ")
            'Next
            'Filewrite.WriteLine()
            'pagesize = pagesize + 1
            'Filewrite.Write("   ")
            'For I = 0 To 83
            '    Filewrite.Write("-")
            'Next
            pagesize = pagesize + 10
        Catch ex As Exception
            Exit Function
        End Try
    End Function

End Class
