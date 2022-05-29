Imports System.Data.OleDb

Public Class Nurses
    Dim cmd As OleDbCommand
    Dim con As OleDbConnection
    Dim adp As OleDbDataAdapter
    Dim ds As New DataSet
    Dim t1 As DataTable

    Private Sub Nurses_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Call PDisconnectDB()
    End Sub

    Private Sub Nurses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call PConnectDB()
        Dim sSql1 As String
        sSql1 = "select * from tbNurses"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbNurses")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
        btnUpdate.Enabled = True
        btnAdd.Enabled = True
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
        txtHouseNumber.Text = myrow("HouseNumber")
        txtState.Text = myrow("State")
        txtCity.Text = myrow("City")
        txtAddress.Text = myrow("Address")
        txtPin.Text = myrow("Pincode")
        txtMobile.Text = myrow("PhoneNumber")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim ans As Integer
        ans = MsgBox("Do you want to Insert ?", vbQuestion + vbYesNo, "Insertion")
        If ans = vbYes Then
            Dim sSql As String
            sSql = "insert into tbNurses (Name,Gender,DateofBirth,HouseNumber,State,City,Address,Pincode,PhoneNumber) 
                values('" & txtName.Text & "',
                       '" & txtGender.Text & "',
                        #" & txtDob.Text & "#,
                       '" & txtHouseNumber.Text & "',
                       '" & txtState.Text & "',
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
        sSql1 = "select * from tbNurses"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbNurses")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to Update ?", vbQuestion + vbYesNo, "Updation")
        If ans = vbYes Then
            Dim sSql As String
            sSql = "update tbNurses set Name= '" & txtName.Text & "',
                                          Gender = '" & txtGender.Text & "',
                                          DateofBirth = #" & txtDob.Text & "#,
                                          HouseNumber = '" & txtHouseNumber.Text & "',
                                          Address = '" & txtState.Text & "',
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
        sSql1 = "select * from tbNurses"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbNurses")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim ans As Integer
        ans = MsgBox("Are you sure you want to delete ?", vbQuestion + vbYesNo, "Deletion")
        If ans = vbYes Then
            Dim sSql As String
            sSql = "Delete from tbNurses  where ID =" & txtId.Text
            MsgBox("Item Deleted")
            cmd = New OleDbCommand(sSql, dbcon)
            cmd.ExecuteNonQuery()
        End If
        'to show changes in grid view
        Dim sSql1 As String
        sSql1 = "select * from tbNurses"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql1, dbcon)
        adp.Fill(ds, "tbNurses")
        DataGridView1.DataSource = ds.Tables(0)
        DataGridView1.Columns(0).ReadOnly = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtId.Text = " "
        txtName.Text = " "
        txtDob.Text = " "
        txtGender.Text = " "
        txtMobile.Text = " "
        txtAddress.Text = " "
        txtCity.Text = " "
        txtPin.Text = " "
        txtState.Text = " "
        txtHouseNumber.Text = " "
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sSql As String
        sSql = "Select * from tbNurses where Name like '" & txtName_Search.Text & "%'"
        ds.Clear()
        adp = New OleDbDataAdapter(sSql, dbcon)
        adp.Fill(ds, "tbNurses")
        DataGridView1.DataSource = ds.Tables("tbNurses")
        DataGridView1.Columns(0).ReadOnly = True
        MessageBox.Show("Done")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        homepage.Show()
        Me.Hide()

    End Sub
End Class