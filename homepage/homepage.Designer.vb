<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Btn_Emergency = New System.Windows.Forms.Button()
        Me.Btn_LogOut = New System.Windows.Forms.Button()
        Me.Btn_Appointment = New System.Windows.Forms.Button()
        Me.Btn_Laboratorists = New System.Windows.Forms.Button()
        Me.Btn_Pharmacists = New System.Windows.Forms.Button()
        Me.Btn_Nurses = New System.Windows.Forms.Button()
        Me.Btn_Doctors = New System.Windows.Forms.Button()
        Me.Btn_Patient = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Btn_Emergency)
        Me.Panel2.Controls.Add(Me.Btn_LogOut)
        Me.Panel2.Controls.Add(Me.Btn_Appointment)
        Me.Panel2.Controls.Add(Me.Btn_Laboratorists)
        Me.Panel2.Controls.Add(Me.Btn_Pharmacists)
        Me.Panel2.Controls.Add(Me.Btn_Nurses)
        Me.Panel2.Controls.Add(Me.Btn_Doctors)
        Me.Panel2.Controls.Add(Me.Btn_Patient)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(223, 733)
        Me.Panel2.TabIndex = 1
        '
        'Btn_Emergency
        '
        Me.Btn_Emergency.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Emergency.Location = New System.Drawing.Point(32, 432)
        Me.Btn_Emergency.Name = "Btn_Emergency"
        Me.Btn_Emergency.Size = New System.Drawing.Size(159, 38)
        Me.Btn_Emergency.TabIndex = 7
        Me.Btn_Emergency.Text = "Emergency Patients"
        Me.Btn_Emergency.UseVisualStyleBackColor = True
        '
        'Btn_LogOut
        '
        Me.Btn_LogOut.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_LogOut.Location = New System.Drawing.Point(32, 673)
        Me.Btn_LogOut.Name = "Btn_LogOut"
        Me.Btn_LogOut.Size = New System.Drawing.Size(159, 38)
        Me.Btn_LogOut.TabIndex = 6
        Me.Btn_LogOut.Text = "Log Out"
        Me.Btn_LogOut.UseVisualStyleBackColor = True
        '
        'Btn_Appointment
        '
        Me.Btn_Appointment.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Appointment.Location = New System.Drawing.Point(32, 486)
        Me.Btn_Appointment.Name = "Btn_Appointment"
        Me.Btn_Appointment.Size = New System.Drawing.Size(159, 38)
        Me.Btn_Appointment.TabIndex = 5
        Me.Btn_Appointment.Text = "Appointments"
        Me.Btn_Appointment.UseVisualStyleBackColor = True
        '
        'Btn_Laboratorists
        '
        Me.Btn_Laboratorists.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Laboratorists.Location = New System.Drawing.Point(32, 378)
        Me.Btn_Laboratorists.Name = "Btn_Laboratorists"
        Me.Btn_Laboratorists.Size = New System.Drawing.Size(159, 38)
        Me.Btn_Laboratorists.TabIndex = 4
        Me.Btn_Laboratorists.Text = "Laboratorists"
        Me.Btn_Laboratorists.UseVisualStyleBackColor = True
        '
        'Btn_Pharmacists
        '
        Me.Btn_Pharmacists.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Pharmacists.Location = New System.Drawing.Point(32, 323)
        Me.Btn_Pharmacists.Name = "Btn_Pharmacists"
        Me.Btn_Pharmacists.Size = New System.Drawing.Size(159, 38)
        Me.Btn_Pharmacists.TabIndex = 3
        Me.Btn_Pharmacists.Text = "Pharmacists"
        Me.Btn_Pharmacists.UseVisualStyleBackColor = True
        '
        'Btn_Nurses
        '
        Me.Btn_Nurses.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Nurses.Location = New System.Drawing.Point(32, 270)
        Me.Btn_Nurses.Name = "Btn_Nurses"
        Me.Btn_Nurses.Size = New System.Drawing.Size(159, 38)
        Me.Btn_Nurses.TabIndex = 2
        Me.Btn_Nurses.Text = "Nurses"
        Me.Btn_Nurses.UseVisualStyleBackColor = True
        '
        'Btn_Doctors
        '
        Me.Btn_Doctors.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Doctors.Location = New System.Drawing.Point(32, 216)
        Me.Btn_Doctors.Name = "Btn_Doctors"
        Me.Btn_Doctors.Size = New System.Drawing.Size(159, 38)
        Me.Btn_Doctors.TabIndex = 1
        Me.Btn_Doctors.Text = "Doctors"
        Me.Btn_Doctors.UseVisualStyleBackColor = True
        '
        'Btn_Patient
        '
        Me.Btn_Patient.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.Btn_Patient.Location = New System.Drawing.Point(32, 162)
        Me.Btn_Patient.Name = "Btn_Patient"
        Me.Btn_Patient.Size = New System.Drawing.Size(159, 38)
        Me.Btn_Patient.TabIndex = 0
        Me.Btn_Patient.Text = "Patients"
        Me.Btn_Patient.UseVisualStyleBackColor = True
        '
        'homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1442, 733)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "homepage"
        Me.Text = "homepage"
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Btn_Appointment As Button
    Friend WithEvents Btn_Laboratorists As Button
    Friend WithEvents Btn_Pharmacists As Button
    Friend WithEvents Btn_Nurses As Button
    Friend WithEvents Btn_Doctors As Button
    Friend WithEvents Btn_Patient As Button
    Friend WithEvents Btn_Emergency As Button
    Friend WithEvents Btn_LogOut As Button
End Class
