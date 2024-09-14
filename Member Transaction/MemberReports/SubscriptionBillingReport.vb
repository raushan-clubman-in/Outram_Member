Imports System.Data.SqlClient
Imports System.IO
Public Class SubscriptionBillingReport
    Dim da As New SqlDataAdapter
    Dim ds As New DataSet
    Dim PAGESIZE As Integer
    Dim PAGENO As Integer
    Dim ReminderStr(10) As String
    Dim RemStr(40) As String
    Dim RemVal, TempTot As Integer
    Dim TempVals(10) As Double
    Dim lp As Integer = 1
    Function begin()
        AppPath = Application.StartupPath
    End Function
    Function buttonclick(ByVal con As String, ByVal sqlstring As String, ByVal arraystring() As String, ByVal heading() As String)
        printdata_1(con, sqlstring, arraystring, heading)
    End Function
    Public Function Round(ByVal nValue As Double, ByVal nDigits As Integer) As Double
        Round = Int(nValue * (10 ^ nDigits) + 0.5) / (10 ^ nDigits)
    End Function
    Private Function printdata_1(ByVal con As String, ByVal SQLSTRING As String, ByVal arraystring() As String, ByVal heading() As String)
        Dim dr As DataRow
        Dim CHK As Boolean
        Dim NEWMCODE, PRESENTMCODE As String
        CompanyName = "THE CALCUTTA SWIMMING CLUB"
        CompanyAddress = "1 Strand Road, Calcutta, 700 001"
        ReportTitle = "SUBSCRIPTION BILL"
        Try
            Randomize()
            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)
            da = New SqlDataAdapter(SQLSTRING, con)
            da.Fill(ds, "master1")
            Filewrite.WriteLine()
            NEWMCODE = "" : PRESENTMCODE = ""
            If PRINTREP = True Then RemVal = 4 Else RemVal = 0
            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "@")
            If PRINTREP = True Then Filewrite.WriteLine(Chr(27) & "A" & Chr(11))
            For Each dr In ds.Tables("Master1").Rows
                PRESENTMCODE = Trim(dr("MCode"))
                If NEWMCODE <> PRESENTMCODE Then
                    NEWMCODE = PRESENTMCODE
                    If CHK = True Then
                        RemStr(14) = "Bill Total:"
                        RemStr(15) = Format(TempVals(1), "0.00")

                        RemStr(16) = IIf(PRINTREP = True, Chr(27) & "E" & "Add Arrear Amount:" & Chr(27) & "F", "Add Arrear Amount::")
                        RemStr(17) = Format(TempVals(2), "0.00")

                        RemStr(18) = "Tax Amount:"
                        RemStr(19) = Format(TempVals(3), "0.00")

                        RemStr(20) = "Round Off(+/-):"
                        RemStr(21) = Format(TempVals(5), "0.00")

                        RemStr(22) = IIf(PRINTREP = True, Chr(27) & "E" & "Net Due Amount:" & Chr(27) & "F", "Net Due Amount:")
                        RemStr(23) = IIf(PRINTREP = True, Chr(27) & "E" & Format(TempVals(4), "0.00") & Chr(27) & "F", Format(TempVals(4), "0.00"))

                        RemStr(24) = IIf(PRINTREP = True, Chr(27) & "E" & "Total mount:" & Chr(27) & "F", "Total Amount:")
                        RemStr(25) = IIf(PRINTREP = True, Chr(27) & "E" & Format(TempTot, "0.00") & Chr(27) & "F", Format(TempTot, "0.00"))

                        Filewrite.WriteLine("{0,-9}{1,-40}{2,20}{3,10}{4,1}", "|", RemStr(14), RemStr(15), "", Space(RemVal) & Space(RemVal) & "|")
                        If TempVals(2) <> 0 Then Filewrite.WriteLine("{0,-9}{1,-40}{2,20}{3,10}{4,1}", "|", RemStr(16), RemStr(17), "", Space(RemVal) & Space(RemVal) & "|")
                        If TempVals(3) <> 0 Then Filewrite.WriteLine("{0,-9}{1,-40}{2,20}{3,10}{4,1}", "|", RemStr(18), RemStr(19), "", Space(RemVal) & Space(RemVal) & "|")
                        If TempVals(5) <> 0 Then Filewrite.WriteLine("{0,-9}{1,-40}{2,20}{3,10}{4,1}", "|", RemStr(20), RemStr(21), "", Space(RemVal) & Space(RemVal) & "|")
                        Filewrite.WriteLine("{0,-9}{1,-40}{2,20}{3,10}{4,1}", "|", RemStr(22), RemStr(23), "", Space(RemVal) & Space(RemVal) & "|")
                        Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")
                        Filewrite.WriteLine("{0,-9}{1,-40}{2,20}{3,10}{4,1}", "|", RemStr(24), RemStr(25), "", Space(RemVal) & Space(RemVal) & "|")
                        Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")

                        ReminderStr(1) = "All cheques must be drawn in favour of The Club"
                        ReminderStr(2) = "A/C Payee only .Rs. 100/- is to be added to outstation cheques as Bank Commition."
                        ReminderStr(3) = "Bill No, Member No and Member name should be written on reverse side of the Cheque"

                        RemStr(26) = ReminderStr(1)
                        RemStr(27) = ReminderStr(2)
                        RemStr(28) = IIf(PRINTREP = True, Chr(27) & "E" & ReminderStr(3) & Chr(27) & "F", ReminderStr(3))

                        Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "", RemStr(26), "")
                        Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "", RemStr(27), "")
                        Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "", RemStr(28), "")
                        Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "", StrDup(78, "~"), "")

                    End If

                    RemStr(0) = IIf(PRINTREP = True, (Chr(27) & "E" & "From:" & Chr(27) & "F"), "From:")
                    RemStr(1) = IIf(PRINTREP = True, (Chr(27) & "E" & "The Secretary" & Chr(27) & "F"), "The Secretary")
                    RemStr(2) = IIf(PRINTREP = True, (Chr(27) & "E" & CompanyName & Chr(27) & "F"), CompanyName)
                    RemStr(3) = IIf(PRINTREP = True, (Chr(27) & "E" & CompanyAddress & Chr(27) & "F"), CompanyAddress)

                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "", StrDup(78, "_"), "")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(0), "", "Date:" & Format(Date.Today, "dd-MMM-yy"), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(1), "", "Member Code:" & Trim(dr("MCode")), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(2), "", "Category:" & Trim(dr("TYPEDESC")), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(3), "", "Due Date:" & Trim(dr("DUEDATE")), Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", "", "", "", "|")

                    RemStr(4) = IIf(PRINTREP = True, Chr(27) & "E" & ReportTitle & Chr(27) & "F", ReportTitle)
                    RemStr(5) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(dr("PREFIX")) & " " & Trim(dr("MNAME")) & Chr(27) & "F", Trim(dr("PREFIX")) & " " & Trim(dr("MNAME")))
                    RemStr(6) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(dr("CONTADD1")) & Chr(27) & "F", Trim(dr("CONTADD1")))
                    RemStr(7) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(dr("CONTADD2")) & Chr(27) & "F", Trim(dr("CONTADD2")))
                    RemStr(8) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(dr("CONTADD3")) & Chr(27) & "F", Trim(dr("CONTADD3")))
                    RemStr(9) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(dr("CONTCITY")) & " " & Trim(dr("CONTSTATE")) & Chr(27) & "F", Trim(dr("CONTCITY")) & " " & Trim(dr("CONTSTATE")))
                    RemStr(10) = IIf(PRINTREP = True, Chr(27) & "E" & "PIN: " & Trim(dr("CONTPIN")) & Chr(27) & "F", "PIN: " & Trim(dr("CONTPIN")))

                    Filewrite.WriteLine("{0,1}{1,30}{2,-28}{3,-20}{4,1}", "|", "", RemStr(4), "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,30}{2,-28}{3,-20}{4,1}", "|", "", StrDup(Len(ReportTitle), "~"), "", "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(5), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(6), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(7), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(8), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(9), "", "", Space(RemVal) & "|")
                    Filewrite.WriteLine("{0,1}{1,-40}{2,18}{3,-20}{4,1}", "|", RemStr(10), "", "", Space(RemVal) & "|")

                    RemStr(11) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(dr("QUTERDATE")) & Chr(27) & "F", Trim(dr("QUTERDATE")))

                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")
                    Filewrite.WriteLine("{0,1}{1,-45}{2,18}{3,-15}{4,1}", "|", "Billing Period From: " & RemStr(11), "", "", "|")
                    Filewrite.WriteLine("{0,-1}{1,-78}{2,-1}", "|", StrDup(78, "_"), "|")

                    TempVals(1) = Trim(dr("TotalAmount"))
                    TempVals(2) = Trim(dr("Arrear"))
                    TempVals(3) = Trim(dr("TaxTotal"))

                    TempVals(4) = TempVals(1) + TempVals(2) + TempVals(3)
                    TempTot = TempVals(4)
                    TempVals(5) = TempVals(4) - TempTot


                    CHK = True

                End If
                'Filewrite.WriteLine("{0,10}{1,-30}{2,20:C}", "", dr("SubsDesc"), dr("amount"))

                RemStr(12) = IIf(PRINTREP = True, Chr(27) & "E" & Trim(dr("SubsDesc")) & ":" & Chr(27) & "F", Trim(dr("SubsDesc")) & ":")
                RemStr(13) = IIf(PRINTREP = True, Chr(27) & "E" & Format(Val(dr("amount")), "0.00") & Chr(27) & "F", Format(Val(dr("amount")), "0.00"))
                Filewrite.WriteLine("{0,-9}{1,-40}{2,20}{3,10}{4,1}", "|", RemStr(12), RemStr(13), "", Space(RemVal) & Space(RemVal) & "|")
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
    Private Function printdata(ByVal con As String, ByVal SQLSTRING As String, ByVal arraystring() As String, ByVal heading() As String)
        Dim str()() As String
        Dim i, j As Integer
        Dim name, Printline As String
        Dim bool As Boolean
        Dim dr As DataRow
        Dim arrearAmount As Double
        Dim GrandTotal As Integer
        Dim Total As Double
        Dim RoundOff As Double
        Dim TOTALAMT As Double
        Try
            Randomize()

            vOutfile = Mid("Ste" & (Rnd() * 800000), 1, 8)
            VFilePath = AppPath & "\Reports\" & vOutfile & ".txt"
            Filewrite = File.AppendText(VFilePath)

            HEADER(con, SQLSTRING, arraystring, heading)

            da = New SqlDataAdapter(SQLSTRING, con)
            da.Fill(ds, "master1")
            Filewrite.WriteLine()
            PAGESIZE = PAGESIZE + 1
            i = 0

            For Each dr In ds.Tables("Master1").Rows

                ''If PAGESIZE > 55 Then
                ''Filewrite.WriteLine(Chr(12))
                ''PAGESIZE = 0
                ''HEADER(globalClass.sqlconnection, SQLSTRING, arraystring, heading)
                ''Filewrite.WriteLine()
                ''PAGESIZE = PAGESIZE + 1
                ''End If

                If name <> dr("mname") Then

                    name = dr("mname")
                    If bool = True Then

                        ' MODIFIED BY SRINIVAS*******************************************************************************************

                        ' RoundOff = (dr("totalamount") + arrearAmount)) - Round((dr("totalamount") + arrearAmount)), 0)
                        '''If dr("totalamount") > dr("arrear") Then
                        '''    arrearAmount = dr("arrear")
                        '''Else
                        '''    arrearAmount = (dr("arrear") - dr("totalamount"))
                        '''End If
                        '***MODIFIED DUE TO CHANGES MADE IN STORED PROCEDURES


                        arrearAmount = 0

                        arrearAmount = dr("arrear")

                        Total = dr("totalamount") + arrearAmount
                        GrandTotal = Total
                        RoundOff = GrandTotal - Total


                        Filewrite.WriteLine("")

                        Filewrite.WriteLine("{0,1}{1,10}{2,-30}{3,20}", " ", "BILL AMOUNT Rs.", dr("totalamount"))
                        Filewrite.WriteLine("{0,1}{1,10}{2,-30}{3,20}", " ", "ADD ARREAR AMOUNT", arrearAmount)
                        Filewrite.WriteLine("{0,1}{1,10}{2,-30}{3,20}", " ", "TAX AMOUNT", dr("TAXtotal"))
                        Filewrite.WriteLine("{0,1}{1,10}{2,-30}{3,20}", " ", "ROUND OFF(+/-)", Round(RoundOff, 2))
                        Filewrite.WriteLine("{{0,1}{1,10}{2,-30}{3,20}", " ", " ", "______________")
                        Filewrite.WriteLine("{0,1}{1,10}{2,-30}{3,20}", " ", "NET DUE AMOUNT", dr("totalamount") + arrearAmount)
                        Filewrite.WriteLine("{0,1}{1,10}{2,-30}{3,20}", " ", " ", "______________")
                        Filewrite.WriteLine("{0,1}{1,10}{2,-30}{3,20}", " ", "TOTAL AMOUNT", dr("totalamount") + arrearAmount)

                        Filewrite.WriteLine("{0,10}{1,-30}{2,40}", " ", "", "Secretary")
                        Filewrite.WriteLine("=========================================================================================================")
                        Filewrite.WriteLine("All cheques must be drawn in favour of The Club")
                        Filewrite.WriteLine("A/C Payee only .Rs. 100/- is to be added to outstation cheques as Bank Commition.")
                        Filewrite.WriteLine("Bill No, Member No and Member name should be written on reverse side of the Cheque")
                        Filewrite.WriteLine("=========================================================================================================")
                        Filewrite.WriteLine()

                        '*************************************************************************************************************

                        'Filewrite.Write(Space(10) & "billamount")
                        'Filewrite.Write(Space(37 - (Len(Space(10)) + Len("BILLAMOUNT"))))
                        'Filewrite.WriteLine(dr("totalamount"))

                        'Filewrite.Write(Space(10) & "Add arrear amount ")
                        'Filewrite.Write(Space(37 - (Len(Space(10)) + Len("Add arrear amount "))))
                        'Filewrite.WriteLine(dr("arrear"))

                        'Filewrite.Write(Space(10) & "net amount")
                        'Filewrite.Write(Space(37 - (Len(Space(10)) + Len("net amount"))))
                        'Filewrite.WriteLine(dr("totalamount") + dr("arrear"))

                        'Filewrite.Write(Space(10) & "net due amount")
                        'Filewrite.Write(Space(37 - (Len(Space(10)) + Len("net due amount"))))
                        'Filewrite.WriteLine(dr("totalamount") + dr("arrear"))
                        'Filewrite.WriteLine()
                        'Filewrite.WriteLine()
                        'HEADER(con, SQLSTRING, arraystring, heading)

                    End If

                    i = i + 1
                    'modified by srinivas n
                    '*********************************************************************************************************************
                    Filewrite.WriteLine("{0,1}{1,10}{2,-50}{3,-40}", " ", "NAME : " & dr("prefix") & dr("mname"), "           Bill No : " & dr("vrno"))
                    Filewrite.WriteLine("{0,10}{1,-50}{2,-40}", " ", "       " & dr("contadd1"), "           Duedate : " & dr("duedate"))
                    Filewrite.WriteLine("{0,10}{1,-50}{2,-40}", " ", "       " & dr("contadd2"), "           Member Code  : " & dr("mcode"))
                    Filewrite.WriteLine("{0,10}{1,-50}{2,-40}", " ", "       " & dr("contadd3"), "           Type : " & dr("typedesc"))
                    Filewrite.WriteLine("{0,17}{1,-50}", " ", dr("contcity"))
                    Filewrite.WriteLine("{0,17}{1,-50}", " ", dr("contpin") & ", " & dr("contstate"))

                    '**********************************************************************************************************************

                    'Filewrite.Write("   Name : " & dr("prefix") & dr("mname"))
                    'Filewrite.Write(Space(50 - (Len("   Name : ") + Len(dr("prefix")) + Len(dr("mname")))))
                    'Filewrite.WriteLine("Bill No : " & dr("vrno"))


                    'Filewrite.Write(Space(10) & dr("contadd1"))
                    'Filewrite.Write(Space(50 - (Len(Space(10)) + Len(dr("contadd1")))))
                    'Filewrite.WriteLine("Duedate : " & dr("duedate"))


                    'Filewrite.Write(Space(10) & dr("contadd2"))
                    'Filewrite.Write(Space(50 - (Len(Space(10)) + Len(dr("contadd2")))))
                    'Filewrite.WriteLine("Member Code  : " & dr("mcode"))

                    'Filewrite.Write(Space(10) & dr("contadd3"))
                    'Filewrite.Write(Space(50 - (Len(Space(10)) + Len(dr("contadd3")))))
                    'Filewrite.WriteLine("Type : " & dr("typedesc"))

                    'Filewrite.WriteLine(Space(10) & dr("contcity"))

                    'Filewrite.WriteLine(Space(10) & dr("contpin") & ", " & dr("contstate"))
                    Filewrite.WriteLine()

                    'Filewrite.Write("   ")
                    Filewrite.WriteLine("{0,10}{1,-15}{2,-20}", " ", "Billing Period From :", dr("quterdate"))
                    'Filewrite.WriteLine("Billing Period From :   " & dr("quterdate"))

                    Filewrite.WriteLine()

                End If
                'modified by srinivas n
                '*******************************************************************************************
                Filewrite.WriteLine("{0,10}{1,-30}{2,20:C}", "", dr("SubsDesc"), dr("amount"))
                'TOTALAMT = TOTALAMT + dr("amount")
                '*******************************************************************************************
                'Filewrite.Write(Space(10) & dr("SubsDesc"))
                'SubsDesc()
                'Filewrite.Write(Space(37 - (Len(Space(10)) + Len(dr("SubsDesc")))))

                'Filewrite.Write(Format(dr("amount"), "0.00"))
                'Filewrite.Write(Space(15 - Format(dr("amount"), "0.00").Length))
                'Filewrite.WriteLine()
                i = i + 1
                bool = True
            Next
            If bool = True Then

                'Filewrite.Write(Space(10) & "billamount")
                'Filewrite.Write(Space(37 - (Len(Space(10)) + Len("BILLAMOUNT"))))
                'Filewrite.WriteLine(dr("totalamount"))

                'Filewrite.Write(Space(10) & "Add arrear amount ")
                'Filewrite.Write(Space(37 - (Len(Space(10)) + Len("Add arrear amount "))))
                'Filewrite.WriteLine(dr("arrear"))

                'Filewrite.Write(Space(10) & "net amount")
                'Filewrite.Write(Space(37 - (Len(Space(10)) + Len("net amount"))))
                'Filewrite.WriteLine(dr("totalamount") + dr("arrear"))

                'Filewrite.Write(Space(10) & "net due amount")
                'Filewrite.Write(Space(37 - (Len(Space(10)) + Len("net due amount"))))
                'Filewrite.WriteLine(dr("totalamount") + dr("arrear"))
                ' modified by srinivas n
                '******************************************************************************************
                arrearAmount = 0
                arrearAmount = dr("arrear")
                Total = dr("totalamount") + arrearAmount
                GrandTotal = Total
                RoundOff = GrandTotal - Total

                Filewrite.WriteLine("{0,10}{1,-30}{2,20:C}", " ", "BILL AMOUNT", dr("totalamount"))
                Filewrite.WriteLine("{0,10}{1,-30}{2,20:C}", " ", "ADD ARREAR AMOUNT", arrearAmount)
                Filewrite.WriteLine("{0,10}{1,-30}{2,20:C}", " ", "TAX AMOUNT", dr("TAXtotal"))
                Filewrite.WriteLine("{0,10}{1,-30}{2,20:C}", " ", "ROUND OFF(+/-)", Round(RoundOff, 2))
                Filewrite.WriteLine("{0,10}{1,-30}{2,20}", " ", " ", "______________")
                Filewrite.WriteLine("{0,10}{1,-30}{2,20:C}", " ", "NET DUE AMOUNT", dr("totalamount") + arrearAmount)
                Filewrite.WriteLine("{0,10}{1,-30}{2,20}", " ", " ", "______________")
                Filewrite.WriteLine("{0,10}{1,-30}{2,20:C}", " ", "TOTAL AMOUNT", dr("totalamount") + arrearAmount)
                Filewrite.WriteLine()
                Filewrite.WriteLine("{0,10}{1,-30}{2,40}", " ", "", "Secretary")
                Filewrite.WriteLine("=========================================================================================================")
                Filewrite.WriteLine("All cheques must be drawn in favour of The Club")
                Filewrite.WriteLine("A/C Payee only .Rs. 100/- is to be added to outstation cheques as Bank Commition.")
                Filewrite.WriteLine("Bill No, Member No and Member name should be written on reverse side of the Cheque")
                Filewrite.WriteLine("=========================================================================================================")
                Filewrite.WriteLine()
                '********************************************************************************************
            End If
            Filewrite.WriteLine()
            Filewrite.WriteLine()
            Filewrite.WriteLine()
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
        PAGESIZE = 0
        'counts the colummns in the checkbox and assign page size 
        Try
            Filewrite.Write(Space((80 - CAPTION.Length) / 2))
            Filewrite.WriteLine(CAPTION)
            PAGESIZE = PAGESIZE + 1
            'PRINTING THE CAPTION AND THE OTHER HEADINGS
            Dim X As String
            For Each X In STRHEADER
                If X <> "" Then
                    Filewrite.Write(Space((80 - X.Length) / 2))

                    Filewrite.WriteLine(X)
                    PAGESIZE = PAGESIZE + 1
                End If
            Next
            Filewrite.WriteLine()
            PAGESIZE = PAGESIZE + 1

        Catch ex As Exception
            Exit Function
        End Try
    End Function
End Class
