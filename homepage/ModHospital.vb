Imports System.Data.OleDb

Module ModHospital
    Public dbcon As New OleDbConnection
    Public Sub PConnectDB()
        dbcon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=E:\BCA 6TH SEM\Hospital System\hospital.mdb"
        dbcon.Open()
    End Sub

    Public Sub PDisconnectDB()
        If dbcon.State = ConnectionState.Open Then
            dbcon.Close()
            ' MsgBox("closed") 
        End If
    End Sub
End Module
