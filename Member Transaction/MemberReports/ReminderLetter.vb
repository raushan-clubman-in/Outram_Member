Imports System.Data.SqlClient
Imports System.IO
Public Class ReminderLetter
    Dim da, da1 As New SqlDataAdapter
    Dim ds, ds1 As New DataSet
    Dim i, J As Integer
    Dim DR As DataRow
    Dim ReminderStr(10) As String
    Dim RemStr(20) As String
    Dim RemVal As Integer
    Dim lp As Integer = 1
    Function begin()
        AppPath = Application.StartupPath
    End Function
    Function buttonclick(ByVal con As String, ByVal sqlstring As String, ByVal letter As String)
        If ReportTitle = "First Reminder Letter" Then
            printdata_R1(con, sqlstring, letter)
        ElseIf ReportTitle = "Second Reminder Letter" Then
            printdata_R2(con, sqlstring, letter)
        ElseIf ReportTitle = "Posting Reminder Letter" Then
            printdata_Rp(con, sqlstring, letter)
        End If
    End Function
    Private Function printdata_Rp(ByVal con As String, ByVal SQLSTRING As String, ByVal letter As String)
        CompanyName = "THE CALCUTTA SWIMMING CLUB"
        CompanyAddress = "1 Strand Road, Calcutta, 700 001"
        Try
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            If PRINTREP = True Then RemVal = 4 Else RemVal = 0
            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "@")
            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "A" & Chr(11))
            da = New SqlDataAdapter(SQLSTRING, con)
            da.Fill(ds, "master1")
            If ds.Tables("Master1").Rows.Count <> 0 Then
                For Each DR In ds.Tables("Master1").Rows
                    If lp = 3 Then
                        Filewrite.WriteLine(Chr(12))
                        lp = 0
                    End If
                    RemStr(0) = IIf(PRINTREP = True, (Chr(27) & "E" & "From:" & Chr(27) & "F"), "From:")
                    RemStr(1) = IIf(PRINTREP = True, (Chr(27) & "E" & "The Secretary" & Chr(27) & "F"), "The Secretary")
                    RemStr(2) = IIf(PRINTREP = True, (Chr(27) & "E" & CompanyName & Chr(27) & "F"), CompanyName)
                    RemStr(3) = IIf(PRINTREP = True, (Chr(27) & "E" & CompanyAddress & Chr(27) & "F"), CompanyAddress)

                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "", StrDup(78, "_"), "")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(0), "", "Date:" & Format(Date.Today, "dd-MMM-yy"), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(1), "", "Member Code:" & Trim(DR("MCode")), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(2), "", "Category:" & Trim(DR("TYPEDESC")), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(3), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", "", "", "", "|")

                    RemStr(4) = IIf(PRINTREP = True, Chr(27) & "E" & ReportTitle & Chr(27) & "F", ReportTitle)
                    RemStr(5) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("PREFIX")) & " " & Trim(DR("MNAME")) & Chr(27) & "F", Trim(DR("PREFIX")) & " " & Trim(DR("MNAME")))
                    RemStr(6) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("CONTADD1")) & Chr(27) & "F", Trim(DR("CONTADD1")))
                    RemStr(7) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("CONTADD2")) & Chr(27) & "F", Trim(DR("CONTADD2")))
                    RemStr(8) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("CONTADD3")) & Chr(27) & "F", Trim(DR("CONTADD3")))
                    RemStr(9) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("CONTCITY")) & " " & Trim(DR("CONTSTATE")) & Chr(27) & "F", Trim(DR("CONTCITY")) & " " & Trim(DR("CONTSTATE")))
                    RemStr(10) = IIf(PRINTREP = True, Chr(27) & "E" & "PIN: " & Trim(DR("CONTPIN")) & Chr(27) & "F", "PIN: " & Trim(DR("CONTPIN")))

                    Filewrite.WriteLine("{0,1}{1,30}{2,-28}{3,-20}{4,1}", "|", "", RemStr(4), "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,30}{2,-28}{3,-20}{4,1}", "|", "", StrDup(Len(ReportTitle), "~"), "", "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(5), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(6), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(7), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(8), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(9), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(10), "", "", Space(RemVal) & "|")

                    'If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "F")
                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", "Dear Sir/Madam:", "", "", "|")

                    RemStr(11) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("QUTERDATE")) & Chr(27) & "F", Trim(DR("QUTERDATE")))
                    RemStr(12) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("VRNO")) & Chr(27) & "F", Trim(DR("VRNO")))
                    'RemStr(13) = IIf(PRINTREP = True, Chr(27) & "E" & Math.Ceiling(Trim(DR("ARREAR"))) & ".00" & Chr(27) & "F", Math.Ceiling(Trim(DR("ARREAR")))) & ".00"
                    'RemStr(14) = IIf(PRINTREP = True, Chr(27) & "E" & Format(Trim(DR("ARREAR")), "0.00") & Chr(27) & "F", Format(Trim(DR("ARREAR")), "0.00"))
                    'RemStr(15) = Format(Math.Ceiling(Trim(DR("ARREAR")) - Trim(DR("ARREAR"))), "0.00")

                    '    Filewrite.WriteLine("Your name has been posted on the Club Notis Board under rule 19 for")
                    '    Filewrite.WriteLine("non pay ment of subscription for the quater ending For quarter period " & Trim(DR("QUTERDATE")))

                    ReminderStr(0) = "Your name has been posted on the Club Notis Board under rule 19 for"
                    ReminderStr(1) = "non pay ment of subscription for the quater ending For quarter period "
                    ReminderStr(2) = Trim(DR("QUTERDATE"))

                    Filewrite.WriteLine("{0,-10}{1,-69}{2,1}", "|", ReminderStr(0), "|")
                    Filewrite.WriteLine("{0,-10}{1,-69}{2,1}", "|", ReminderStr(1), "|")
                    Filewrite.WriteLine("{0,-10}{1,-69}{2,1}", "|", ReminderStr(2), "|")


                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", " ", "|")
                    RemStr(16) = IIf(PRINTREP = True, Chr(27) & "E" & CompanyName & Chr(27) & "F", CompanyName)
                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", "For " & RemStr(16), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", " ", "|")
                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", " ", "|")
                    RemStr(17) = IIf(PRINTREP = True, Chr(27) & "E" & "SECERETARY " & Chr(27) & "F", "SECERETARY ")
                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")
                    RemStr(18) = IIf(PRINTREP = True, Chr(27) & "E" & ReminderStr(9) & Chr(27) & "F", ReminderStr(9))
                    Filewrite.WriteLine("{0,-10}{1,-69}{2,-1}", "|", RemStr(18), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")
                    '-----
                Next
                Filewrite.Close()
                If PRINTREP = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile(vOutfile)
                End If
            Else
                MsgBox("NO DETAILS AVAILABEL")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Function printdata_R2(ByVal con As String, ByVal SQLSTRING As String, ByVal letter As String)


        CompanyName = "THE CALCUTTA SWIMMING CLUB"
        CompanyAddress = "1 Strand Road, Calcutta, 700 001"

        Try
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)

            If PRINTREP = True Then RemVal = 4 Else RemVal = 0
            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "@")
            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "A" & Chr(11))


            da = New SqlDataAdapter(SQLSTRING, con)
            da.Fill(ds, "master1")
            If ds.Tables("Master1").Rows.Count <> 0 Then
                For Each DR In ds.Tables("Master1").Rows

                    RemStr(0) = IIf(PRINTREP = True, (Chr(27) & "E" & "From:" & Chr(27) & "F"), "From:")
                    RemStr(1) = IIf(PRINTREP = True, (Chr(27) & "E" & "The Secretary" & Chr(27) & "F"), "The Secretary")
                    RemStr(2) = IIf(PRINTREP = True, (Chr(27) & "E" & CompanyName & Chr(27) & "F"), CompanyName)
                    RemStr(3) = IIf(PRINTREP = True, (Chr(27) & "E" & CompanyAddress & Chr(27) & "F"), CompanyAddress)

                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "", StrDup(78, "_"), "")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(0), "", "Date:" & Format(Date.Today, "dd-MMM-yy"), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(1), "", "Member Code:" & Trim(DR("MCode")), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(2), "", "Category:" & Trim(DR("TYPEDESC")), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(3), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", "", "", "", "|")

                    RemStr(4) = IIf(PRINTREP = True, Chr(27) & "E" & ReportTitle & Chr(27) & "F", ReportTitle)
                    RemStr(5) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("PREFIX")) & " " & Trim(DR("MNAME")) & Chr(27) & "F", Trim(DR("PREFIX")) & " " & Trim(DR("MNAME")))
                    RemStr(6) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("CONTADD1")) & Chr(27) & "F", Trim(DR("CONTADD1")))
                    RemStr(7) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("CONTADD2")) & Chr(27) & "F", Trim(DR("CONTADD2")))
                    RemStr(8) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("CONTADD3")) & Chr(27) & "F", Trim(DR("CONTADD3")))
                    RemStr(9) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("CONTCITY")) & " " & Trim(DR("CONTSTATE")) & Chr(27) & "F", Trim(DR("CONTCITY")) & " " & Trim(DR("CONTSTATE")))
                    RemStr(10) = IIf(PRINTREP = True, Chr(27) & "E" & "PIN: " & Trim(DR("CONTPIN")) & Chr(27) & "F", "PIN: " & Trim(DR("CONTPIN")))

                    Filewrite.WriteLine("{0,1}{1,30}{2,-28}{3,-20}{4,1}", "|", "", RemStr(4), "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,30}{2,-28}{3,-20}{4,1}", "|", "", StrDup(Len(ReportTitle), "~"), "", "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(5), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(6), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(7), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(8), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(9), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(10), "", "", Space(RemVal) & "|")

                    'If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "F")
                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", "Dear Sir/Madam:", "", "", "|")

                    RemStr(11) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("QUTERDATE")) & Chr(27) & "F", Trim(DR("QUTERDATE")))
                    RemStr(12) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("VRNO")) & Chr(27) & "F", Trim(DR("VRNO")))

                    RemStr(13) = IIf(PRINTREP = True, Chr(27) & "E" & Math.Ceiling(Trim(DR("ARREAR")) + Trim(DR("PR_ARREAR"))) & ".00" & Chr(27) & "F", Math.Ceiling(Trim(DR("ARREAR") + Trim(DR("PR_ARREAR"))))) & ".00"
                    RemStr(14) = IIf(PRINTREP = True, Chr(27) & "E" & Format(Trim(DR("ARREAR") + Trim(DR("PR_ARREAR"))), "0.00") & Chr(27) & "F", Format(Trim(DR("ARREAR")) + Trim(DR("PR_ARREAR")), "0.00"))
                    RemStr(15) = Format(Math.Ceiling(Trim(DR("ARREAR")) + Trim(DR("PR_ARREAR")) - Trim(DR("ARREAR"))), "0.00")

                    ReminderStr(0) = "Further to our First Reminder dated ##/##/#### for the payment of above "
                    ReminderStr(1) = "referred bill, it has been noted from  the  club  records that the same "
                    ReminderStr(2) = "has still remained unpaid."
                    ReminderStr(3) = "I would like  to  draw your attention to rule 19 of the club. Kindly, "
                    ReminderStr(4) = "arrange to clear the above dues within 7 days, after which date, your "
                    ReminderStr(5) = "name will be posted on club Notice Board for non payment."
                    ReminderStr(6) = "Please ignore this reminder  in case the payment has been made in the "
                    ReminderStr(7) = "meanwhile.    "
                    ReminderStr(9) = "If you have already paid, please ignore this reminder."

                    Filewrite.WriteLine("{0,-5}{1,-74}{2,1}", "|", ReminderStr(0), "|")
                    Filewrite.WriteLine("{0,-5}{1,-74}{2,1}", "|", ReminderStr(1), "|")
                    Filewrite.WriteLine("{0,-5}{1,-74}{2,1}", "|", ReminderStr(2), "|")
                    Filewrite.WriteLine("{0,-5}{1,-74}{2,1}", "|", ReminderStr(3), "|")
                    Filewrite.WriteLine("{0,-5}{1,-74}{2,1}", "|", ReminderStr(4), "|")
                    Filewrite.WriteLine("{0,-5}{1,-74}{2,1}", "|", ReminderStr(5), "|")
                    Filewrite.WriteLine("{0,-5}{1,-74}{2,1}", "|", ReminderStr(6), "|")
                    Filewrite.WriteLine("{0,-5}{1,-74}{2,1}", "|", ReminderStr(7), "|")


                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", " ", "|")
                    RemStr(16) = IIf(PRINTREP = True, Chr(27) & "E" & CompanyName & Chr(27) & "F", CompanyName)
                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", "For " & RemStr(16), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", " ", "|")
                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", " ", "|")
                    RemStr(17) = IIf(PRINTREP = True, Chr(27) & "E" & "SECERETARY " & Chr(27) & "F", "SECERETARY ")
                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", RemStr(17), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")
                    '-----
                    Filewrite.WriteLine("{0,1}{1,-40}{2,8}{3,-30}{4,1}", "|", "Bill No:" & RemStr(12), "", "Period" & RemStr(11), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", " ", "|")
                    Filewrite.WriteLine("{0,-10}{1,-40}{2,9}{3,-20}{4,1}", "|", "Subscription:", "", "", "|")
                    Filewrite.WriteLine("{0,-10}{1,-40}{2,9}{3,-20}{4,1}", "|", "Service Tax:", "", "", "|")
                    Filewrite.WriteLine("{0,-10}{1,-40}{2,9}{3,-20}{4,1}", "|", "Administrative Charges:", "", "", "|")
                    Filewrite.WriteLine("{0,-10}{1,-40}{2,9}{3,-20}{4,1}", "|", "Administrative Charges:", "", "", "|")

                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")
                    RemStr(18) = IIf(PRINTREP = True, Chr(27) & "E" & ReminderStr(9) & Chr(27) & "F", ReminderStr(9))
                    Filewrite.WriteLine("{0,-10}{1,-69}{2,-1}", "|", RemStr(18), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")

                    Filewrite.WriteLine(Chr(12))

                Next


                Filewrite.Close()
                If PRINTREP = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile(vOutfile)
                End If
            Else
                MsgBox("NO DETAILS AVAILABEL")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
    Private Function printdata_R1(ByVal con As String, ByVal SQLSTRING As String, ByVal letter As String)
        CompanyName = "THE CALCUTTA SWIMMING CLUB"
        CompanyAddress = "1 Strand Road, Calcutta, 700 001"
        Try
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            If PRINTREP = True Then RemVal = 4 Else RemVal = 0
            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "@")
            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "A" & Chr(11))
            da = New SqlDataAdapter(SQLSTRING, con)
            da.Fill(ds, "master1")
            If ds.Tables("Master1").Rows.Count <> 0 Then
                For Each DR In ds.Tables("Master1").Rows
                    If lp = 3 Then
                        Filewrite.WriteLine(Chr(12))
                        lp = 0
                    End If
                    lp = lp + 1
                    RemStr(0) = IIf(PRINTREP = True, (Chr(27) & "E" & "From:" & Chr(27) & "F"), "From:")
                    RemStr(1) = IIf(PRINTREP = True, (Chr(27) & "E" & "The Secretary" & Chr(27) & "F"), "The Secretary")
                    RemStr(2) = IIf(PRINTREP = True, (Chr(27) & "E" & CompanyName & Chr(27) & "F"), CompanyName)
                    RemStr(3) = IIf(PRINTREP = True, (Chr(27) & "E" & CompanyAddress & Chr(27) & "F"), CompanyAddress)
                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "", StrDup(78, "_"), "")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(0), "", "Date:" & Format(Date.Today, "dd-MMM-yy"), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(1), "", "Member Code:" & Trim(DR("MCode")), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(2), "", "Category:" & Trim(DR("TYPEDESC")), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(3), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", "", "", "", "|")



                    RemStr(4) = IIf(PRINTREP = True, Chr(27) & "E" & ReportTitle & Chr(27) & "F", ReportTitle)
                    RemStr(5) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("PREFIX")) & " " & Trim(DR("MNAME")) & Chr(27) & "F", Trim(DR("PREFIX")) & " " & Trim(DR("MNAME")))
                    RemStr(6) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("CONTADD1")) & Chr(27) & "F", Trim(DR("CONTADD1")))
                    RemStr(7) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("CONTADD2")) & Chr(27) & "F", Trim(DR("CONTADD2")))
                    RemStr(8) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("CONTADD3")) & Chr(27) & "F", Trim(DR("CONTADD3")))
                    RemStr(9) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("CONTCITY")) & " " & Trim(DR("CONTSTATE")) & Chr(27) & "F", Trim(DR("CONTCITY")) & " " & Trim(DR("CONTSTATE")))
                    RemStr(10) = IIf(PRINTREP = True, Chr(27) & "E" & "PIN: " & Trim(DR("CONTPIN")) & Chr(27) & "F", "PIN: " & Trim(DR("CONTPIN")))

                    Filewrite.WriteLine("{0,1}{1,30}{2,-28}{3,-20}{4,1}", "|", "", RemStr(4), "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,30}{2,-28}{3,-20}{4,1}", "|", "", StrDup(Len(ReportTitle), "~"), "", "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(5), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(6), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(7), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(8), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(9), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(10), "", "", Space(RemVal) & "|")

                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", "Dear Sir/Madam:", "", "", "|")

                    RemStr(11) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("QUTERDATE")) & Chr(27) & "F", Trim(DR("QUTERDATE")))
                    RemStr(12) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(DR("VRNO")) & Chr(27) & "F", Trim(DR("VRNO")))

                    RemStr(13) = IIf(PRINTREP = True, Chr(27) & "E" & Math.Ceiling(Trim(DR("ARREAR")) + Trim(DR("PR_ARREAR"))) & ".00" & Chr(27) & "F", Math.Ceiling(Trim(DR("ARREAR") + Trim(DR("PR_ARREAR"))))) & ".00"
                    RemStr(14) = IIf(PRINTREP = True, Chr(27) & "E" & Format(Val(DR("ARREAR") + Val(DR("PR_ARREAR"))), "0.00") & Chr(27) & "F", Format(Val(DR("ARREAR")) + Val(DR("PR_ARREAR")), "0.00"))
                    RemStr(15) = Format(Math.Ceiling(Val(DR("ARREAR")) + Val(DR("PR_ARREAR"))) - (Val(DR("ARREAR")) + Val(DR("PR_ARREAR"))), "0.00")

                    ReminderStr(0) = "Arrear of Sunscription Bill for the period " & RemStr(11)
                    ReminderStr(1) = "as per Bill Number: " & RemStr(12) & " of Rs." & RemStr(13)
                    ReminderStr(2) = "Less excess balance adjusted: " & RemStr(15) & " Net Due: " & RemStr(14)

                    ReminderStr(9) = "If you have already paid, please ignore this reminder."

                    Filewrite.WriteLine("{0,-10}{1,-69}{2,1}", "|", ReminderStr(0), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,-10}{1,-69}{2,1}", "|", ReminderStr(1), Space(RemVal) & Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,-10}{1,-69}{2,1}", "|", ReminderStr(2), Space(RemVal) & "|")


                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", " ", "|")
                    RemStr(16) = IIf(PRINTREP = True, Chr(27) & "E" & CompanyName & Chr(27) & "F", CompanyName)
                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", "For " & RemStr(16), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", " ", "|")
                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", " ", "|")
                    RemStr(17) = IIf(PRINTREP = True, Chr(27) & "E" & "SECERETARY " & Chr(27) & "F", "SECERETARY ")
                    Filewrite.WriteLine("{0,1}{1,78}{2,1}", "|", RemStr(17), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")
                    RemStr(18) = IIf(PRINTREP = True, Chr(27) & "E" & ReminderStr(9) & Chr(27) & "F", ReminderStr(9))
                    Filewrite.WriteLine("{0,-10}{1,-69}{2,-1}", "|", RemStr(18), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")

                    Filewrite.WriteLine("")
                    Filewrite.WriteLine("")
                    If PRINTREP = True Then
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine("")
                        Filewrite.WriteLine("")
                    End If

                    '                  Dim x As String = "srinivas"
                    '                 Dim xx() As Char
                    'xx = x.ToCharArray()

                    '  Filewrite.WriteLine(StrDup(80, "_"))
                    'Filewrite.WriteLine("{0,-30}{1,30}{2,-20}", "From", "", "Date:")
                    'Filewrite.WriteLine(Chr(27) & "E")
                    'Filewrite.WriteLine("{0,-30}{1,30}{2,-20}", "From", "test", "Date:")

                    'Filewrite.WriteLine()
                    'Filewrite.Write("   ")
                    'Filewrite.Write("Date :")
                    'Filewrite.WriteLine(Format(Date.Today, "dd-MMM-yy"))
                    'Filewrite.Write("   ")
                    'Filewrite.Write("Club")
                    'Filewrite.Write(Space(20))
                    'Filewrite.Write("Category = ")
                    'Filewrite.WriteLine(Trim(DR("TYPEDESC")))

                    'Filewrite.Write("   ")
                    'Filewrite.WriteLine("P.O Box No.753")
                    'Filewrite.Write("   ")
                    'Filewrite.WriteLine("Kolkatta-700001")
                    'Filewrite.WriteLine()
                    'Filewrite.WriteLine()

                    'Filewrite.WriteLine(Space(30) & letter)
                    'Filewrite.WriteLine()
                    'Filewrite.WriteLine()

                    'Filewrite.Write("   ")
                    'Filewrite.WriteLine("To")
                    'Filewrite.Write("   ")
                    'Filewrite.WriteLine(Trim(DR("PREFIX")))
                    'Filewrite.Write("   ")
                    'Filewrite.WriteLine(Trim(DR("MNAME")))
                    'Filewrite.Write("   ")
                    'Filewrite.WriteLine(Trim(DR("CONTADD1")))
                    'Filewrite.Write("   ")
                    'If Trim(DR("CONTADD2")) <> "" Then
                    '    Filewrite.WriteLine(Trim(DR("CONTADD2")))
                    '    Filewrite.Write("   ")
                    'End If
                    'If Trim(DR("CONTADD3")) <> "" Then
                    '    Filewrite.WriteLine(Trim(DR("CONTADD3")))
                    '    Filewrite.Write("   ")
                    'End If
                    'Filewrite.WriteLine(Trim(DR("CONTCITY")))
                    'Filewrite.Write("   ")
                    'Filewrite.WriteLine(Trim(DR("CONTPIN")) & ", " & Trim(DR("CONTSTATE")))

                    'Filewrite.WriteLine()
                    'Filewrite.Write("   ")
                    'Filewrite.WriteLine("Dear Sir /Madam :")
                    'Filewrite.WriteLine()
                    'Filewrite.Write("      ")
                    'If letter = "Posting Of Reminder Leter" Then
                    '    Filewrite.WriteLine("Your name has been posted on the Club Notis Board under rule 19 for")
                    '    Filewrite.WriteLine("non pay ment of subscription for the quater ending For quarter period " & Trim(DR("QUTERDATE")))
                    '    Filewrite.Write("      ")
                    'Else
                    '    Filewrite.WriteLine("Ariers of subscription bill for the period " & Trim(DR("QUTERDATE")))
                    '    Filewrite.Write("      ")

                    '    Filewrite.Write("as per Bill No" & Trim(DR("VRNO")) & " of Rs.")
                    'If letter = "FIRST REMINDER LETTER" Then
                    '        Filewrite.WriteLine(Trim(DR("ARREAR")))
                    'Else
                    '        Filewrite.WriteLine(Trim(DR("ARREAR") + 100))
                    'End If
                    '    Filewrite.WriteLine(Trim(DR("ARREAR")))
                    '    Filewrite.Write("      ")
                    '    Filewrite.WriteLine("is due from " & Trim(DR("DUEDATE")))
                    '    Filewrite.WriteLine()
                    '    Filewrite.WriteLine(Space(50) & " for The Culcutta Swimming club")
                    '    Filewrite.WriteLine()
                    '    Filewrite.WriteLine()
                    '    Filewrite.WriteLine()
                    '    Filewrite.WriteLine(Space(70) & "secretary")
                    'End If
                    'For J = 0 To 80
                    '    Filewrite.Write("-")
                    'Next
                    'Filewrite.WriteLine()
                    'Filewrite.WriteLine(Space(15) & "if you have already paid, please ignore this reminder")
                    'Filewrite.WriteLine(Chr(12))
                Next
                Filewrite.Close()
                If PRINTREP = False Then
                    OpenTextFile(vOutfile)
                Else
                    PrintTextFile(vOutfile)
                End If
            Else
                MsgBox("NO DETAILS AVAILABEL")
            End If
        Catch ex As Exception
            MsgBox(ex.Message & ex.Source & ex.ToString)
            Exit Function
        End Try
    End Function
End Class
