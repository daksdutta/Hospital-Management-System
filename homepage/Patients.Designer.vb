<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patients
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.txtHouseNumber = New System.Windows.Forms.TextBox()
        Me.txtDob = New System.Windows.Forms.TextBox()
        Me.txtMobile = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPin = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName_Search = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRoomNo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.bt_dojoining = New System.Windows.Forms.Button()
        Me.AppointmentDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.bt_dob = New System.Windows.Forms.Button()
        Me.cbState = New System.Windows.Forms.ComboBox()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.btnSearch.Location = New System.Drawing.Point(829, 587)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(117, 37)
        Me.btnSearch.TabIndex = 60
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtId
        '
        Me.txtId.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtId.Location = New System.Drawing.Point(251, 87)
        Me.txtId.Margin = New System.Windows.Forms.Padding(4)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(200, 32)
        Me.txtId.TabIndex = 61
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(63, 95)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 24)
        Me.Label14.TabIndex = 59
        Me.Label14.Text = "ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(62, 641)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1219, 110)
        Me.DataGridView1.TabIndex = 58
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnClear)
        Me.Panel1.Controls.Add(Me.BtnAdd)
        Me.Panel1.Controls.Add(Me.BtnExit)
        Me.Panel1.Controls.Add(Me.BtnUpdate)
        Me.Panel1.Controls.Add(Me.BtnDelete)
        Me.Panel1.Location = New System.Drawing.Point(62, 485)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(796, 69)
        Me.Panel1.TabIndex = 57
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnClear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.ForeColor = System.Drawing.Color.White
        Me.BtnClear.Location = New System.Drawing.Point(483, 12)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(113, 47)
        Me.BtnClear.TabIndex = 30
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnAdd.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.ForeColor = System.Drawing.Color.White
        Me.BtnAdd.Location = New System.Drawing.Point(33, 12)
        Me.BtnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(120, 47)
        Me.BtnAdd.TabIndex = 25
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(628, 12)
        Me.BtnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(107, 47)
        Me.BtnExit.TabIndex = 29
        Me.BtnExit.Text = "Exit"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnUpdate
        '
        Me.BtnUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnUpdate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.ForeColor = System.Drawing.Color.White
        Me.BtnUpdate.Location = New System.Drawing.Point(184, 12)
        Me.BtnUpdate.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(113, 47)
        Me.BtnUpdate.TabIndex = 26
        Me.BtnUpdate.Text = "Update"
        Me.BtnUpdate.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.BtnDelete.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.White
        Me.BtnDelete.Location = New System.Drawing.Point(328, 12)
        Me.BtnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(116, 47)
        Me.BtnDelete.TabIndex = 27
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'txtHouseNumber
        '
        Me.txtHouseNumber.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtHouseNumber.Location = New System.Drawing.Point(689, 87)
        Me.txtHouseNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtHouseNumber.Name = "txtHouseNumber"
        Me.txtHouseNumber.Size = New System.Drawing.Size(200, 32)
        Me.txtHouseNumber.TabIndex = 56
        '
        'txtDob
        '
        Me.txtDob.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDob.Location = New System.Drawing.Point(251, 298)
        Me.txtDob.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDob.Name = "txtDob"
        Me.txtDob.Size = New System.Drawing.Size(200, 32)
        Me.txtDob.TabIndex = 54
        '
        'txtMobile
        '
        Me.txtMobile.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtMobile.Location = New System.Drawing.Point(689, 358)
        Me.txtMobile.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMobile.Name = "txtMobile"
        Me.txtMobile.Size = New System.Drawing.Size(200, 32)
        Me.txtMobile.TabIndex = 53
        '
        'txtAddress
        '
        Me.txtAddress.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtAddress.Location = New System.Drawing.Point(689, 243)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(200, 32)
        Me.txtAddress.TabIndex = 52
        '
        'txtPin
        '
        Me.txtPin.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPin.Location = New System.Drawing.Point(689, 301)
        Me.txtPin.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPin.Name = "txtPin"
        Me.txtPin.Size = New System.Drawing.Size(200, 32)
        Me.txtPin.TabIndex = 51
        '
        'txtCity
        '
        Me.txtCity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtCity.Location = New System.Drawing.Point(689, 194)
        Me.txtCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(200, 32)
        Me.txtCity.TabIndex = 50
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtName.Location = New System.Drawing.Point(252, 139)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(200, 32)
        Me.txtName.TabIndex = 46
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(508, 95)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(136, 24)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "House Number"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(508, 147)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 24)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "State"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(63, 309)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 24)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Date of Birth"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(503, 361)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 24)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Mobile"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(64, 202)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 24)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(503, 306)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 24)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Pincode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(505, 202)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 24)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "City"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(505, 251)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 24)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Address "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 147)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 24)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(282, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 45)
        Me.Label1.TabIndex = 34
        '
        'txtName_Search
        '
        Me.txtName_Search.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtName_Search.Location = New System.Drawing.Point(611, 590)
        Me.txtName_Search.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName_Search.Name = "txtName_Search"
        Me.txtName_Search.Size = New System.Drawing.Size(200, 32)
        Me.txtName_Search.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(409, 590)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 35)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Name"
        '
        'txtRoomNo
        '
        Me.txtRoomNo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtRoomNo.Location = New System.Drawing.Point(251, 243)
        Me.txtRoomNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRoomNo.Name = "txtRoomNo"
        Me.txtRoomNo.Size = New System.Drawing.Size(200, 32)
        Me.txtRoomNo.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(63, 251)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 24)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Room No."
        '
        'txtDate
        '
        Me.txtDate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDate.Location = New System.Drawing.Point(251, 353)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(200, 32)
        Me.txtDate.TabIndex = 67
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(64, 361)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 24)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "Date"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(247, 9)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(381, 54)
        Me.Label15.TabIndex = 146
        Me.Label15.Text = "PATIENTS  DETAILS"
        '
        'bt_dojoining
        '
        Me.bt_dojoining.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.bt_dojoining.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_dojoining.ForeColor = System.Drawing.Color.White
        Me.bt_dojoining.Location = New System.Drawing.Point(358, 427)
        Me.bt_dojoining.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_dojoining.Name = "bt_dojoining"
        Me.bt_dojoining.Size = New System.Drawing.Size(93, 31)
        Me.bt_dojoining.TabIndex = 158
        Me.bt_dojoining.Text = "D.O.J"
        Me.bt_dojoining.UseVisualStyleBackColor = False
        '
        'AppointmentDatePicker
        '
        Me.AppointmentDatePicker.Font = New System.Drawing.Font("Calibri", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppointmentDatePicker.Location = New System.Drawing.Point(251, 392)
        Me.AppointmentDatePicker.Name = "AppointmentDatePicker"
        Me.AppointmentDatePicker.Size = New System.Drawing.Size(200, 28)
        Me.AppointmentDatePicker.TabIndex = 157
        '
        'bt_dob
        '
        Me.bt_dob.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.bt_dob.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_dob.ForeColor = System.Drawing.Color.White
        Me.bt_dob.Location = New System.Drawing.Point(251, 427)
        Me.bt_dob.Margin = New System.Windows.Forms.Padding(4)
        Me.bt_dob.Name = "bt_dob"
        Me.bt_dob.Size = New System.Drawing.Size(90, 31)
        Me.bt_dob.TabIndex = 156
        Me.bt_dob.Text = "D.O.B"
        Me.bt_dob.UseVisualStyleBackColor = False
        '
        'cbState
        '
        Me.cbState.BackColor = System.Drawing.SystemColors.Window
        Me.cbState.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbState.FormattingEnabled = True
        Me.cbState.Items.AddRange(New Object() {"Andhra Pradesh", "Andaman and Nicobar Island", "Arunachal Pradesh", "Assam", "Bihar", "Chandigarh", "Chhattisgarh", "Dadra and Nagar Haveli and Daman and Diu", "Delhi", "Goa", "Gujarat" & Global.Microsoft.VisualBasic.ChrW(9), "Haryana" & Global.Microsoft.VisualBasic.ChrW(9), "Himachal Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Jammu and Kashmir ", "Jharkhand", "Karnataka", "Kerala", "Ladakh", "Lakshadweep", "Madhya Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Maharashtra", "Manipur" & Global.Microsoft.VisualBasic.ChrW(9), "Meghalaya", "Mizoram", "Nagaland", "Odisha", "Punjab", "Puducherry", "Rajasthan", "Sikkim", "Tamil Nadu", "Telangana" & Global.Microsoft.VisualBasic.ChrW(9), "Tripura", "Uttar Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Uttarakhand" & Global.Microsoft.VisualBasic.ChrW(9), "West Bengal" & Global.Microsoft.VisualBasic.ChrW(9)})
        Me.cbState.Location = New System.Drawing.Point(689, 144)
        Me.cbState.Name = "cbState"
        Me.cbState.Size = New System.Drawing.Size(200, 32)
        Me.cbState.TabIndex = 164
        '
        'cbGender
        '
        Me.cbGender.BackColor = System.Drawing.SystemColors.Window
        Me.cbGender.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"Female", "Male", "Others"})
        Me.cbGender.Location = New System.Drawing.Point(252, 194)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(200, 32)
        Me.cbGender.TabIndex = 165
        '
        'Patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.homepage.My.Resources.Resources.patient
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 764)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.cbState)
        Me.Controls.Add(Me.bt_dojoining)
        Me.Controls.Add(Me.AppointmentDatePicker)
        Me.Controls.Add(Me.bt_dob)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtRoomNo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName_Search)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtHouseNumber)
        Me.Controls.Add(Me.txtDob)
        Me.Controls.Add(Me.txtMobile)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtPin)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Patients"
        Me.Text = "Patients"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents txtId As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents txtHouseNumber As TextBox
    Friend WithEvents txtDob As TextBox
    Friend WithEvents txtMobile As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPin As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtName_Search As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRoomNo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents bt_dojoining As Button
    Friend WithEvents AppointmentDatePicker As DateTimePicker
    Friend WithEvents bt_dob As Button
    Friend WithEvents cbState As ComboBox
    Friend WithEvents cbGender As ComboBox
End Class
