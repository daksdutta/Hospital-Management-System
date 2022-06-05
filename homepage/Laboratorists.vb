Imports System.Data.OleDb
Public Class Laboratorists
    Dim cmd As OleDbCommand
    Dim con As OleDbConnection
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet
    Dim t1 As DataTable

    Private Sub Laboratorists_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call PDisconnectDB()
    End Sub

    Private Sub Laboratorists_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PConnectDB()
        Dim sSql1 As String
        sSql1 = "select * from tbLaboratorists"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbLaboratorists")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
        btnUpdate.Enabled = True
        btnAdd.Enabled = True
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtId.Text = " "
        txtName.Text = " "
        txtDob.Text = " "
        txtjoiningdate.Text = " "
        cbGender.Text = " "
        txtMobile.Text = " "
        txtAddress.Text = " "
        txtCity.Text = " "
        txtPin.Text = " "
        cbState.Text = " "
        txtHouseNumber.Text = " "
    End Sub

    Private Sub bt_dob_Click(sender As Object, e As EventArgs) Handles bt_dob.Click
        txtDob.Text = Format(AppointmentDatePicker.Value, "dd-MM-yyyy")
    End Sub

    Private Sub bt_dojoining_Click(sender As Object, e As EventArgs) Handles bt_dojoining.Click
        txtjoiningdate.Text = Format(AppointmentDatePicker.Value, "dd-MM-yyyy")
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ans As Integer
        ans = MsgBox("Do you want to Insert ?", vbQuestion + vbYesNo, "Insertion")
        If ans = vbYes Then
            Dim sSql As String
            sSql = "insert into tbLaboratorists (LaboratoristName,LaboratoristGender,DateofJoining,DateofBirth,HouseNumber,State,City,Address,Pincode,PhoneNumber) 
                values('" & txtName.Text & "',
                       '" & cbGender.Text & "',
                        #" & txtDob.Text & "#,
                       #" & txtjoiningdate.Text & "#,
                       '" & txtHouseNumber.Text & "',
                       '" & cbState.Text & "',
                       '" & txtCity.Text & "',
                       '" & txtAddress.Text & "',
                        " & txtPin.Text & ", 
                        " & txtMobile.Text & ")"

            MsgBox("Item added")
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        End If
        'to show changes in grid view
        Dim sSql1 As String
        sSql1 = "select * from tbLaboratorists"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbLaboratorists")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        t1 = ds.Tables(0)
        If t1.Rows.Count = 0 Then Exit Sub
        If DataGridView1.CurrentRow.Index >= t1.Rows.Count Then Exit Sub
        Dim myrow As DataRow = t1.Rows(DataGridView1.CurrentRow.Index)
        txtId.Text = myrow("ID")
        txtName.Text = myrow("LaboratoristName")
        cbGender.Text = myrow("LaboratoristGender")
        txtDob.Text = myrow("DateofBirth")
        txtjoiningdate.Text = myrow("DateofJoining")
        txtHouseNumber.Text = myrow("HouseNumber")
        cbState.Text = myrow("State")
        txtCity.Text = myrow("City")
        txtAddress.Text = myrow("Address")
        txtPin.Text = myrow("Pincode")
        txtMobile.Text = myrow("PhoneNumber")
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to Update ?", vbQuestion + vbYesNo, "Updation")
        If ans = vbYes Then
            Dim sSql As String
            sSql = "update tbLaboratorists set LaboratoristName= '" & txtName.Text & "',
                                          LaboratoristGender = '" & cbGender.Text & "',
                                          DateofBirth = #" & txtDob.Text & "#,
                                          DateofJoining = #" & txtjoiningdate.Text & "#,
                                          HouseNumber = '" & txtHouseNumber.Text & "',
                                          Address = '" & cbState.Text & "',
                                          City = '" & txtCity.Text & "',
                                          State = '" & txtAddress.Text & "',
                                          Pincode = " & txtPin.Text & ", 
                                          PhoneNumber = " & txtMobile.Text & "
                                          where ID =" & txtId.Text
            MsgBox("Item Updated")
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        End If
        'to show changes in grid view
        Dim sSql1 As String
        sSql1 = "select * from tbLaboratorists"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbLaboratorists")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to delete ?", vbQuestion + vbYesNo, "Deletion")
        If ans = vbYes Then
            Dim sSql As String
            sSql = "Delete from tbLaboratorists where ID =" & txtId.Text
            MsgBox("Item Deleted")
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        End If
        'to show changes in grid view
        Dim sSql1 As String
        sSql1 = "select * from tbLaboratorists"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbLaboratorists")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sSql As String
        sSql = "Select * from tbLaboratorists where LaboratoristName like '" & txtName_Search.Text & "%'"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql, dbcon)
        adp.Fill(ds, "tbLaboratorists")
        DataGridView1.DataSource = ds.Tables("tbLaboratorists")
        DataGridView1.Columns(0).ReadOnly = True
        MessageBox.Show("Done")

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        homepage.Show()
        Me.Hide()
    End Sub


End Class