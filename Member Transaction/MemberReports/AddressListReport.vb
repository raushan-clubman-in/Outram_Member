Imports System.Data.SqlClient
Imports System.IO
Public Class AddressListReport
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim pageno As Integer
    Dim pagesize As Integer
    Function begin()
        apppath = Application.StartupPath
    End Function

    Function buttonclick(ByVal con As String, ByVal sqlstring As String, ByVal arraystring() As String, ByVal heading() As String, ByVal add As String)
        printdata(con, sqlstring, arraystring, heading, add)
    End Function
    Private Function printdata(ByVal con As String, ByVal SQLSTRING As String, ByVal arraystring() As String, ByVal heading() As String, ByVal add As String)
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
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = apppath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(vFilepath)
            HEADER(arraystring, heading)

            da = New SqlDataAdapter(SQLSTRING, con)
            da.Fill(ds, "master1")
            'Filewrite.WriteLine("{0,100}", "    Calcutta Swiming Club  ")
            'Filewrite.WriteLine("{0,100}", " Member List Address Report")
            'Filewrite.WriteLine("{0,100}", " --------------------------")
            'Filewrite.WriteLine("{0,80}", Date.Now)
            'Filewrite.WriteLine("---------------------------------------------------------------------------------------------------------------------")
            'Filewrite.WriteLine("{0,-35}{1,-25}", "   MEMBERCODE", "MEMBERNAME AND ADDRESS")
            'Filewrite.WriteLine("---------------------------------------------------------------------------------------------------------------------")
            Filewrite.WriteLine()

            For i = 0 To ds.Tables("Master1").Rows.Count - 1

                dr1 = ds.Tables("Master1").NewRow
                dr1 = ds.Tables("master1").Rows(i)

                'print dr1 and dr2
                STR0 = dr1(0)
                STR1 = dr1(1)
                STR2 = dr1(2)
                STR3 = dr1(3)
                STR4 = dr1(4)
                STR5 = dr1(5)
                STR6 = dr1(6)
                STR7 = dr1(7)
                STR8 = dr1(8)
                STR9 = dr1(9)
                If pagesize > 55 Then
                    PageFoter(80)
                    HEADER(arraystring, heading)
                    Filewrite.WriteLine()

                End If
                'STR0 = Mid(STR0, 1, 20) & Space(25 - STR0.Length()) & Space(25 - Len(dr1("prefix"))) & Mid(Trim(dr1("prefix")), 1, 25) & dr1(1)
                'Filewrite.Write("   ")
                Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", STR0, "", Trim(dr1("prefix")) & " " & STR1)
                If Trim(STR2) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR2) : pagesize = pagesize + 1
                If Trim(STR3) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR3) : pagesize = pagesize + 1
                If Trim(STR5) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR5) : pagesize = pagesize + 1
                If Trim(STR6) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR6) : pagesize = pagesize + 1
                If Trim(STR7) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR7) : pagesize = pagesize + 1
                If Trim(STR8) <> "" And Trim(STR9) <> "" Then Filewrite.WriteLine("{0,-10}{1,25}{2,-25}", " ", " ", STR8 & STR9) : pagesize = pagesize + 1
                Filewrite.WriteLine("--------------------------------------------------------------------------")
                Filewrite.WriteLine(" ")
                pagesize = pagesize + 5
                'Filewrite.WriteLine("{0,20}{1,-10}{2,-25}", " ", Trim(dr1("prefix")), STR1)
                'Filewrite.WriteLine("{0,20}{1,-10}{2,-25}", " ", Trim(dr1("prefix")), STR1)

                'Filewrite.WriteLine(STR0)

                'Filewrite.Write("   ")
                'Filewrite.Write(add & Space(16) & STR2)
                'Filewrite.WriteLine()
                'Filewrite.Write(Space(35) & STR3 & ", " & STR4)
                'Filewrite.WriteLine()
                'Filewrite.Write(Space(35) & STR5 & ", " & STR6)
                'Filewrite.WriteLine()
                'Filewrite.Write(Space(35) & STR7)
                'Filewrite.WriteLine()
                'Filewrite.Write(Space(35) & STR8 & ", " & STR9)
                'Filewrite.WriteLine()
                'Filewrite.WriteLine()
                'pagesize = pagesize + 9
                STR0 = ""
                STR1 = ""
                STR2 = ""
                STR3 = ""
                STR4 = ""
                STR5 = ""
                STR6 = ""
                STR7 = ""
                STR8 = ""
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
            pageno = pageno + 1

            PageHeader(80, pageno)

            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & Chr(71) & Chr(14) & Chr(27) & Chr(45) & Chr(1))
            Filewrite.WriteLine("{0,-35}{1,-25}", "Member Code", "Member Name and Address")
            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & Chr(72) & Chr(20) & Chr(27) & Chr(45) & Chr(0))


            If PRINTREP = False Then Filewrite.WriteLine(StrDup(80, "_"))
            'Filewrite.Write(Space((80 - CAPTION.Length) / 2))
            'Filewrite.WriteLine(CAPTION)
            'pagesize = pagesize + 1
            'PRINTING THE CAPTION AND THE OTHER HEADINGS
            'Dim X As String
            'For Each X In STRHEADER
            'If X <> "" Then
            ' Filewrite.Write(Space((80 - X.Length) / 2))

            'Filewrite.WriteLine(X)
            'pagesize = pagesize + 1

            'Filewrite.Write(Space((80 - X.Length) / 2))
            'For I = 1 To X.Length - 1
            'Filewrite.Write("=")
            'Next
            'Filewrite.WriteLine()
            ' pagesize = pagesize + 1
            'End If
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
            'Filewrite.Write("-")
            'Next
            ''PRINTNG THE COLUMN HEADING 
            'Filewrite.WriteLine()
            'pagesize = pagesize + 1
            'Filewrite.Write("   ")
            'For Each head In heading
            'Filewrite.Write(head)
            'Filewrite.Write(Space(35 - Len(head)))
            'Filewrite.Write("  ")
            'Next
            'Filewrite.WriteLine()
            'pagesize = pagesize + 1
            'Filewrite.Write("   ")
            'For I = 0 To 80
            'Filewrite.Write("-")
            'Next
        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class

