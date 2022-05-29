<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button1_login = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxpassword = New System.Windows.Forms.TextBox()
        Me.TextBoxusername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb_ForgotPassword = New System.Windows.Forms.Label()
        Me.btn_emergency = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.ForeColor = System.Drawing.Color.Black
        Me.CheckBox1.Location = New System.Drawing.Point(282, 465)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(152, 22)
        Me.CheckBox1.TabIndex = 16
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'Button1_login
        '
        Me.Button1_login.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Button1_login.Font = New System.Drawing.Font("Calibri", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1_login.ForeColor = System.Drawing.Color.White
        Me.Button1_login.Location = New System.Drawing.Point(207, 529)
        Me.Button1_login.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1_login.Name = "Button1_login"
        Me.Button1_login.Size = New System.Drawing.Size(198, 61)
        Me.Button1_login.TabIndex = 14
        Me.Button1_login.Text = "Login"
        Me.Button1_login.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(162, 188)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(367, 65)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ADP HOSPITAL"
        '
        'TextBoxpassword
        '
        Me.TextBoxpassword.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxpassword.Location = New System.Drawing.Point(282, 408)
        Me.TextBoxpassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxpassword.Name = "TextBoxpassword"
        Me.TextBoxpassword.Size = New System.Drawing.Size(367, 37)
        Me.TextBoxpassword.TabIndex = 13
        Me.TextBoxpassword.UseSystemPasswordChar = True
        '
        'TextBoxusername
        '
        Me.TextBoxusername.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBoxusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxusername.Location = New System.Drawing.Point(282, 345)
        Me.TextBoxusername.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBoxusername.Name = "TextBoxusername"
        Me.TextBoxusername.Size = New System.Drawing.Size(367, 37)
        Me.TextBoxusername.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(240, 263)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 54)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "WELCOME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(59, 408)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 41)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(59, 341)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(172, 41)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Username:"
        '
        'lb_ForgotPassword
        '
        Me.lb_ForgotPassword.AutoSize = True
        Me.lb_ForgotPassword.BackColor = System.Drawing.Color.Transparent
        Me.lb_ForgotPassword.Font = New System.Drawing.Font("Calibri", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ForgotPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.lb_ForgotPassword.Location = New System.Drawing.Point(507, 464)
        Me.lb_ForgotPassword.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lb_ForgotPassword.Name = "lb_ForgotPassword"
        Me.lb_ForgotPassword.Size = New System.Drawing.Size(173, 23)
        Me.lb_ForgotPassword.TabIndex = 21
        Me.lb_ForgotPassword.Text = "FORGOT PASSWORD"
        '
        'btn_emergency
        '
        Me.btn_emergency.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(133, Byte), Integer), CType(CType(133, Byte), Integer))
        Me.btn_emergency.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emergency.ForeColor = System.Drawing.Color.White
        Me.btn_emergency.Location = New System.Drawing.Point(120, 598)
        Me.btn_emergency.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_emergency.Name = "btn_emergency"
        Me.btn_emergency.Size = New System.Drawing.Size(377, 62)
        Me.btn_emergency.TabIndex = 22
        Me.btn_emergency.Text = "EMERGENCY DETAILS"
        Me.btn_emergency.UseVisualStyleBackColor = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.homepage.My.Resources.Resources.login_2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1362, 694)
        Me.Controls.Add(Me.btn_emergency)
        Me.Controls.Add(Me.lb_ForgotPassword)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1_login)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBoxpassword)
        Me.Controls.Add(Me.TextBoxusername)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button1_login As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxpassword As TextBox
    Friend WithEvents TextBoxusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lb_ForgotPassword As Label
    Friend WithEvents btn_emergency As Button
End Class
