﻿Public Class homepage
    Private Sub Btn_Patient_Click(sender As Object, e As EventArgs) Handles Btn_Patient.Click
        Patients.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Doctors_Click(sender As Object, e As EventArgs) Handles Btn_Doctors.Click
        Doctors.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Nurses_Click(sender As Object, e As EventArgs) Handles Btn_Nurses.Click
        Nurses.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Pharmacists_Click(sender As Object, e As EventArgs) Handles Btn_Pharmacists.Click
        Pharmacists.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Laboratorists_Click(sender As Object, e As EventArgs) Handles Btn_Laboratorists.Click
        Laboratorists.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Emergency_Click(sender As Object, e As EventArgs) Handles Btn_Emergency.Click
        EmergencyPatient.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_Appointment_Click(sender As Object, e As EventArgs) Handles Btn_Appointment.Click
        Appointment.Show()
        Me.Hide()
    End Sub

    Private Sub Btn_LogOut_Click(sender As Object, e As EventArgs) Handles Btn_LogOut.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class