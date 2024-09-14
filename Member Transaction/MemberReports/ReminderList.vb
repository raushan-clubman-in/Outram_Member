Imports System.Data.SqlClient
Imports System.IO
Public Class ReminderList
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim pageno As Integer
    Dim pagesize As Integer
    Dim GLOBALCLASS As New globalClass
    Function begin()
        apppath = Application.StartupPath
    End Function

    Function buttonclick(ByVal con As String, ByVal sqlstring As String, ByVal arraystring() As String, ByVal heading() As String)
        printdata(con, sqlstring, arraystring, heading)
    End Function
    Private Function printdata(ByVal con As String, ByVal SQLSTRING As String, ByVal arraystring() As String, ByVal heading() As String)
        Dim str()() As String
        Dim i, j, SNO As Integer
        Dim dr As DataRow

        Try
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            vFilepath = apppath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(vFilepath)

            HEADER(GLOBALCLASS.sqlconnection, SQLSTRING, arraystring, heading)
            da = New SqlDataAdapter(SQLSTRING, con)
            da.Fill(ds, "master1")
            Filewrite.WriteLine()
            pagesize = pagesize + 1
            SNO = 1
            For Each dr In ds.Tables("Master1").Rows
                If pagesize > 55 Then
                    'Filewrite.WriteLine(Chr(12))
                    pagesize = 0
                    PageFoter(80)
                    HEADER(GLOBALCLASS.sqlconnection, SQLSTRING, arraystring, heading)
                    'Filewrite.WriteLine()
                    pagesize = 10

                End If
                Filewrite.WriteLine("{0,5}{1,10}{2,30}{3,25}{4,10}", SNO, Trim(dr("MCODE")), Trim(dr("MNAME")), Trim(dr("DUEDATE")), Trim(Format(dr("ARREAR") + dr("PR_ARREAR"), "0.00")))
                SNO = SNO + 1
                pagesize = pagesize + 1
                'Filewrite.Write("   ")
                'Filewrite.Write(Trim(dr("MCODE")))
                'Filewrite.Write(Space(8 - Len(Trim(dr("MCODE")))))
                'Filewrite.Write(Trim(dr("MNAME")))
                'Filewrite.Write(Space(30 - Len(Trim(dr("MNAME")))))
                'Filewrite.Write(Trim(dr("VRNO")))
                'Filewrite.Write(Space(20 - Len(Trim(dr("VRNO")))))
                'Filewrite.Write(Trim(dr("DUEDATE")))
                'Filewrite.Write(Space(15 - Len(Trim(dr("DUEDATE")))))
                'Filewrite.WriteLine(Trim(Format(dr("ARREAR"), "0.00")))
                'pagesize = pagesize + 1
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
    Private Function HEADER(ByVal con As String, ByVal sqlstring As String, ByVal STRHEADER() As String, ByVal heading() As String)
        Dim CAPTION As String = "THE CALCUTTA SWIMMING CLUB"
        Dim I, COLUMNCOUNT As Integer
        Dim CHECKEDITEMSNO As Integer
        Dim head As String
        pagesize = 0
        'counts the colummns in the checkbox and assign page size 
        Try
            'Filewrite.Write(Space((80 - CAPTION.Length) / 2))
            'Filewrite.WriteLine(CAPTION)
            pagesize = pagesize + 1
            PageHeader(80, pageno)


            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & Chr(71) & Chr(14) & Chr(27) & Chr(45) & Chr(1))
            Filewrite.WriteLine("{0,-5}{1,-7}{2,-28}{3,-15}{4,-10}{5,-15}", "SNo", "CODE", "NAME", "STATUS", "FROM", "TO")
            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & Chr(72) & Chr(20) & Chr(27) & Chr(45) & Chr(0))
            If PRINTREP = False Then Filewrite.WriteLine(StrDup(80, "_"))


        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
