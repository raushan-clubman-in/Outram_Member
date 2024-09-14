Imports System.Data.SqlClient
Imports System.IO
Public Class SummaryRep
    Dim dAdapter As New SqlDataAdapter
    Dim dSet As New DataSet
    Public Function btn_Print(ByVal SQLSTRING As String, ByVal Con As String)
        ' by srinivas **************************************************************************
        Dim FilePath, Apath As String
        Dim OFile As System.IO.File
        Dim OWrite As System.IO.StreamWriter
        Dim DispVar(10) As String
        Dim LoopCur As Integer
        Try
            dAdapter = New SqlDataAdapter(SQLSTRING, Con)
            dAdapter.Fill(dSet, "master1")
            Apath = Application.StartupPath
            FilePath = Apath & "\Reports\SummaryRep.txt"
            OWrite = OFile.CreateText(FilePath)
            OWrite.WriteLine("{0,-15}{1,-30}{2,-30}{3,-15}{4,-25}{5,-20}{6,15}{7,-15}", "MEMBER CODE", "MEMBER NAME", _
            "MEMBER CATEGORY", "STATUS", "QUATEREDATE", "VOUCHAR NUMBER", "AMOUNT  ", "DUE DATE")
            OWrite.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------")
            For LoopCur = 0 To dSet.Tables("Master1").Rows.Count - 1
                DispVar(1) = dSet.Tables("master1").Rows(LoopCur).Item("mcode")
                DispVar(2) = dSet.Tables("master1").Rows(LoopCur).Item("mname")
                DispVar(3) = dSet.Tables("master1").Rows(LoopCur).Item("TYPEDESC")
                DispVar(4) = dSet.Tables("master1").Rows(LoopCur).Item("CURENTSTATUS")
                DispVar(5) = dSet.Tables("master1").Rows(LoopCur).Item("QUTERDATE")
                DispVar(6) = dSet.Tables("master1").Rows(LoopCur).Item("VRNO")
                DispVar(7) = dSet.Tables("master1").Rows(LoopCur).Item("TOTAL") & ".00 "
                DispVar(8) = dSet.Tables("master1").Rows(LoopCur).Item("DUEDATE")

                OWrite.WriteLine("{0,-15}{1,-30}{2,-30}{3,-15}{4,-25}{5,-20}{6,15}{7,-15}", DispVar(1), DispVar(2), DispVar(3), DispVar(4), _
                DispVar(5), DispVar(6), DispVar(7), DispVar(8))
            Next
            OWrite.Close()
            Shell(Apath & "\wordpad.exe " & FilePath, AppWinStyle.MaximizedFocus)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
End Class
