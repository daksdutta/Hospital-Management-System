Imports System.Data.OleDb

Public Class ChangePassword
    Dim read As String
    Dim datafile As String
    Dim dr As OleDbDataReader
    Dim cmd As OleDbCommand
    Dim dbcon As New OleDbConnection

    Private Sub btn_changepassword_Click(sender As Object, e As EventArgs) Handles btn_changepassword.Click
        'dbcon = New OleDbConnection
        dbcon.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\Hospital-Management-System\hospital.mdb"
        dbcon.Open()

        Dim sql1 As String
        If (txtnewpassword.Text = "" And txtconfirmpassword.Text = "") Then
            MessageBox.Show("All Information Required")
        ElseIf (txtnewpassword.Text <> txtconfirmpassword.Text) Then
            MessageBox.Show("New password and Confirm Password didn't match")
        Else
            sql1 = "update tbLogin set Password='" & txtnewpassword.Text & "' where Name='" & txtUsername.Text & "'"


            'MessageBox.Show(sql1)
            cmd = New OleDbCommand(sql1, dbcon)
            cmd.ExecuteNonQuery()

            MessageBox.Show("record update")
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

End Class
