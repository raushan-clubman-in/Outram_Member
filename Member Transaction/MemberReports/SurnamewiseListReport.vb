Imports System.Data.SqlClient
Imports System.IO
Public Class NamewiseListReport
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim pageno As Integer
    Dim pagesize As Integer
    Function begin()
        apppath = Application.StartupPath
    End Function

    Function buttonclick(ByVal con As String, ByVal sqlstring As String, ByVal arraystring() As String, ByVal heading() As String)
        'HEADER(arraystring, heading)
        printdata(con, sqlstring, arraystring, heading)
    End Function
    Private Function printdata(ByVal con As String, ByVal sqlstring As String, ByVal arraystring() As String, ByVal heading() As String)
        Dim str()() As String
        Dim i, j As Integer
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
            pageno = 1
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = apppath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(vFilepath)
            sqlstring = sqlstring & " ORDER BY SURNAME,MCODE"
            da = New SqlDataAdapter(sqlstring, con)
            da.Fill(ds, "master1")
            ReportTitle = Trim(HEDDING1)
            'HEADER(arraystring, heading)
            'Filewrite.Write(Space(25))
            'Filewrite.WriteLine(HEDDING1)
            pagesize = pagesize + 10
            PageHeader(80, pageno)
            'pageno = pageno + 1

            pagesize = pagesize + 2
            For i = 0 To ds.Tables("Master1").Rows.Count - 2
                If pagesize > 55 Then
                    PageFoter(80)
                    '        Filewrite.WriteLine(Chr(12))
                    pageno = pageno + 1
                    PageHeader(80, pageno)
                    pagesize = 10
                End If

                dr1 = ds.Tables("Master1").NewRow
                dr2 = ds.Tables("Master1").NewRow
                dr1 = ds.Tables("master1").Rows(i)
                dr2 = ds.Tables("master1").Rows(i + 1)
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

                Filewrite.WriteLine("{0,-40}{1,-40}", dr1(0) & ": " & dr1(1), dr2(0) & ": " & dr2(1))
                Filewrite.WriteLine("{0,-40}{1,-40}", dr1(2), dr2(2))
                Filewrite.WriteLine("{0,-40}{1,-40}", dr1(3), dr2(3))
                Filewrite.WriteLine("{0,-40}{1,-40}", dr1(4), dr2(4))
                Filewrite.WriteLine("{0,-40}{1,-40}", dr1(5) & "" & dr1(6), dr2(5) & "" & dr2(6))
                Filewrite.WriteLine("{0,-40}{1,-40}", dr1(7) & "" & dr1(8), dr2(7) & "" & dr2(8))
                Filewrite.WriteLine("{0,-40}{1,-40}", dr1(9), dr2(9))

                Filewrite.WriteLine(StrDup(80, "_"))
                
                pagesize = pagesize + 8
                STR0 = ""
                STR1 = ""
                STR2 = ""
                STR3 = ""
                STR4 = ""
                STR5 = ""
                STR6 = ""
                STR7 = ""
                STR8 = ""
                STR9 = ""

                i = i + 1
            Next i
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
  End Class
