Imports System.Data.OleDb

Public Class Appointment
    Dim cmd As OleDbCommand
    Dim con As OleDbConnection
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet
    Dim t1 As DataTable

    Private Sub Appointment_Closed(sender As Object, e As EventArgs) Handles MyBase.Closed
        Call PDisconnectDB()
    End Sub

    Private Sub Appointment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PConnectDB()
        Dim sSql1 As String
        sSql1 = "select * from tbAppointment"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbAppointment")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
        btnUpdate.Enabled = True
        btnAdd.Enabled = True
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ans As Integer
        ans = MsgBox("Do you want to Insert ?", vbQuestion + vbYesNo, "Insertion")
        If ans = vbYes Then
            Dim sSql As String
            sSql = "insert into tbAppointment (Name,Gender,DateofBirth,DoctorName,DoctorDepartment,Time,Date,PhoneNumber) 
                values('" & txtName.Text & "',
                       '" & txtGender.Text & "',
                        #" & txtDob.Text & "#,
                       '" & txtDoctorName.Text & "',
                       '" & txtDocDept.Text & "',
                       " & txtTime.Text & ",
                       #" & txtDate.Text & "#,
                        " & txtMobile.Text & ")"

            MsgBox("Item added")
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        End If
        'to show changes in grid view
        Dim sSql1 As String
        sSql1 = "select * from tbAppointment"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbAppointment")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If DataGridView1.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myrow As DataRow = t1.Rows(DataGridView1.CurrentRow.Index)
        txtId.Text = myrow("ID")
        txtName.Text = myrow("Name")
        txtGender.Text = myrow("Gender")
        txtDob.Text = myrow("DateofBirth")
        txtMobile.Text = myrow("PhoneNumber")
        txtDoctorName.Text = myrow("DoctorName")
        txtDocDept.Text = myrow("DoctorDepartment")
        txtTime.Text = myrow("Time")
        txtDate.Text = myrow("Date")
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to Update ?", vbQuestion + vbYesNo, "Updation")
        If ans = vbYes Then
            Dim sSql As String
            sSql = "update tbAppointment set Name= '" & txtName.Text & "',
                                          Gender = '" & txtGender.Text & "',
                                          DateofBirth = #" & txtDob.Text & "#,
                                          DoctorName = '" & txtDoctorName.Text & "',
                                          DoctorDepartment = '" & txtDocDept.Text & "',
                                          Time = " & txtTime.Text & ",
                                          Date = #" & txtDate.Text & "#,
                                          PhoneNumber = " & txtMobile.Text & "
                                          where ID =" & txtId.Text
            MsgBox("Item Updated")
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        End If
        'to show changes in grid view
        Dim sSql1 As String
        sSql1 = "select * from tbAppointment"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbAppointment")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to delete ?", vbQuestion + vbYesNo, "Deletion")
        If ans = vbYes Then
            Dim sSql As String
            sSql = "Delete from tbAppointment where ID = " & txtId.Text
            MsgBox("Item Deleted")
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        End If
        'to show changes in grid view
        Dim sSql1 As String
        sSql1 = "select * from tbAppointment"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbAppointment")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtId.Text = " "
        txtName.Text = " "
        txtDob.Text = " "
        txtGender.Text = " "
        txtMobile.Text = " "
        txtDoctorName.Text = " "
        txtDocDept.Text = " "
        txtTime.Text = " "
        txtDate.Text = " "
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sSql As String
        sSql = "Select * from tbAppointment where Name like '" & txtName_Search.Text & "%'"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql, dbcon)
        adp.Fill(ds, "tbAppointment")
        DataGridView1.DataSource = ds.Tables("tbAppointment")
        DataGridView1.Columns(0).ReadOnly = True
        MessageBox.Show("Done")
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        homepage.Show()
        Me.Hide()
    End Sub

End Class