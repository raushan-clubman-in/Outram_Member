Imports System.Data.SqlClient
Imports System.IO
Public Class AddressStickerReport
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim pagesize As Integer = 0
    Dim AddStr1(10), AddStr2(10) As String
    Function begin()
        apppath = Application.StartupPath
    End Function

    Function buttonclick(ByVal con As String, ByVal sqlstring As String)
        printdata(con, sqlstring)
    End Function
    Private Function printdata(ByVal con As String, ByVal sqlstring As String)
        Dim str()() As String
        Dim i, j, lp, lpNext1, lpNext2 As Integer
        Dim count As Integer = 0
        Dim cnt As Integer
        Dim dr1 As DataRow
        Dim dr2 As DataRow
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
            da = New SqlDataAdapter(sqlstring, con)
            da.Fill(ds, "master1")
            pagesize = 0

            'Filewrite.WriteLine()
            'pagesize = pagesize + 1

            For i = 0 To ds.Tables("Master1").Rows.Count - 2
                dr1 = ds.Tables("Master1").NewRow
                dr2 = ds.Tables("Master1").NewRow
                dr1 = ds.Tables("master1").Rows(i)
                dr2 = ds.Tables("master1").Rows(i + 1)
                'print dr1 and dr2
                lpNext1 = 0
                lpNext2 = 0

                For lp = 0 To 10
                    If Trim(dr1(lp)) <> "" Then
                        AddStr1(lpNext1) = Trim(dr1(lp))
                        lpNext1 = lpNext1 + 1
                    End If

                    If Trim(dr2(lp)) <> "" Then
                        AddStr2(lpNext2) = Trim(dr2(lp))
                        lpNext2 = lpNext2 + 1
                    End If

                Next

                Filewrite.WriteLine("{0,-40}{1,-40}", AddStr1(10) & " " & AddStr1(1) & " [" & AddStr1(0) & "]", AddStr1(10) & " " & AddStr1(1) & " [" & AddStr1(0) & "]")

                Filewrite.WriteLine("{0,-40}{1,-40}", AddStr1(2), AddStr2(2))
                Filewrite.WriteLine("{0,-40}{1,-40}", AddStr1(3), AddStr2(3))
                Filewrite.WriteLine("{0,-40}{1,-40}", AddStr1(4), AddStr2(4))

                Filewrite.WriteLine("{0,-40}{1,-40}", AddStr1(5) & " " & AddStr1(6), AddStr1(5) & " " & AddStr1(6))
                Filewrite.WriteLine("{0,-40}{1,-40}", AddStr1(7) & " " & AddStr1(8) & " " & AddStr1(9), AddStr1(7) & " " & AddStr1(8) & " " & AddStr1(9))
                If PRINTREP = False Then Filewrite.WriteLine(StrDup(80, "-"))
                If PRINTREP = True Then Filewrite.WriteLine("")
                If PRINTREP = True Then Filewrite.WriteLine("")
                'Filewrite.Write("{0,-40}{1,-40}", "", "")

                'STR0 = dr1(0)
                'STR1 = dr1(1)
                'STR2 = dr1(2)
                'STR3 = dr1(3)
                'STR4 = dr1(4)
                'STR5 = dr1(5)
                'STR6 = dr1(6)
                'STR7 = dr1(7)
                'STR8 = dr1(8)
                'STR0 = STR0 & " : " & STR1
                'STR0 = Mid(STR0, 1, Len(STR0)) & Space(50 - STR0.Length()) & dr2(0)
                'STR0 = STR0 & " : " & dr2(1)
                'STR2 = Mid(STR2, 1, Len(STR2)) & Space(50 - STR2.Length()) & dr2(2)
                'STR3 = STR3 & ","
                'STR3 = Mid(STR3, 1, Len(STR3)) & Space(50 - STR3.Length()) & dr2(3) & ","
                'STR4 = STR4 & ","
                'STR4 = Mid(STR4, 1, Len(STR4)) & Space(50 - STR4.Length()) & dr2(4) & ","
                'STR5 = STR5 & ", " & STR6
                'STR5 = Mid(STR5, 1, Len(STR5)) & Space(50 - STR5.Length()) & dr2(5)
                'STR5 = STR5 & ", " & dr2(6)
                'STR7 = STR7 & ", " & dr2(8)
                'STR7 = Mid(STR7, 1, Len(STR7)) & Space(50 - STR7.Length()) & dr2(7)
                'STR7 = STR7 & ", " & dr2(8)

                'If pagesize > 68 Then
                '    'For j = 0 To 80
                '    '    Filewrite.Write("-")
                '    'Next
                '    Filewrite.Write(Chr(12))
                '    pagesize = 0
                '    count = 0
                '    'pagesize = pagesize + 1
                'End If
                'If count = 3 Then
                '    count = 0
                '    Filewrite.WriteLine()
                '    pagesize = pagesize + 1
                'End If
                'Filewrite.WriteLine(STR0)
                'Filewrite.WriteLine(STR2)
                'Filewrite.WriteLine(STR3)
                'Filewrite.WriteLine(STR4)
                'Filewrite.WriteLine(STR5)
                'Filewrite.WriteLine(STR7)
                'Filewrite.WriteLine()
                'Filewrite.WriteLine()
                'Filewrite.WriteLine()
                'Filewrite.WriteLine()
                'pagesize = pagesize + 10
                'STR0 = ""
                'STR1 = ""
                'STR2 = ""
                'STR3 = ""
                'STR4 = ""
                'STR5 = ""
                'STR6 = ""
                'STR7 = ""
                'STR8 = ""
                'STR9 = ""
                'i = i + 1
                'count = count + 1
            Next i
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
End Class


