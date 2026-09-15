<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        btnApply = New Button()
        btnClear = New Button()
        btnExit = New Button()
        GroupBox2 = New GroupBox()
        Label3 = New Label()
        Label1 = New Label()
        dtpApplicationDate = New DateTimePicker()
        txtSchool = New TextBox()
        cmbCourse = New ComboBox()
        lblschool = New Label()
        lblCourse = New Label()
        lblDate = New Label()
        lblAccademicInfo = New Label()
        txtAddress = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNumber = New TextBox()
        dtpDateOfBirth = New DateTimePicker()
        txtNationality = New TextBox()
        txtName = New TextBox()
        lblAddress = New Label()
        lblEmail = New Label()
        lblPhoneNumber = New Label()
        lblcontact = New Label()
        lblNationality = New Label()
        lblGender = New Label()
        lblDateOfBirth = New Label()
        lblName = New Label()
        lblInfo = New Label()
        Label2 = New Label()
        rbMale = New RadioButton()
        rbFemale = New RadioButton()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.DarkMagenta
        GroupBox1.BackgroundImage = My.Resources.Resources.SEE_HERE1
        GroupBox1.BackgroundImageLayout = ImageLayout.Zoom
        GroupBox1.Controls.Add(rbMale)
        GroupBox1.Controls.Add(rbFemale)
        GroupBox1.Controls.Add(btnApply)
        GroupBox1.Controls.Add(btnClear)
        GroupBox1.Controls.Add(btnExit)
        GroupBox1.Controls.Add(GroupBox2)
        GroupBox1.Controls.Add(dtpApplicationDate)
        GroupBox1.Controls.Add(txtSchool)
        GroupBox1.Controls.Add(cmbCourse)
        GroupBox1.Controls.Add(lblschool)
        GroupBox1.Controls.Add(lblCourse)
        GroupBox1.Controls.Add(lblDate)
        GroupBox1.Controls.Add(lblAccademicInfo)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(txtPhoneNumber)
        GroupBox1.Controls.Add(dtpDateOfBirth)
        GroupBox1.Controls.Add(txtNationality)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(lblAddress)
        GroupBox1.Controls.Add(lblEmail)
        GroupBox1.Controls.Add(lblPhoneNumber)
        GroupBox1.Controls.Add(lblcontact)
        GroupBox1.Controls.Add(lblNationality)
        GroupBox1.Controls.Add(lblGender)
        GroupBox1.Controls.Add(lblDateOfBirth)
        GroupBox1.Controls.Add(lblName)
        GroupBox1.Controls.Add(lblInfo)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Location = New Point(199, 1)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(690, 590)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        ' 
        ' btnApply
        ' 
        btnApply.BackColor = Color.Navy
        btnApply.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnApply.Location = New Point(282, 535)
        btnApply.Name = "btnApply"
        btnApply.Size = New Size(213, 39)
        btnApply.TabIndex = 56
        btnApply.Text = "APPLY / REGISTER"
        btnApply.UseVisualStyleBackColor = False
        ' 
        ' btnClear
        ' 
        btnClear.BackColor = Color.Yellow
        btnClear.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(228, 482)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(89, 34)
        btnClear.TabIndex = 54
        btnClear.Text = "CLEAR"
        btnClear.UseVisualStyleBackColor = False
        ' 
        ' btnExit
        ' 
        btnExit.BackColor = Color.Yellow
        btnExit.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnExit.Location = New Point(467, 482)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(89, 34)
        btnExit.TabIndex = 55
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.BackColor = Color.Yellow
        GroupBox2.Controls.Add(Label3)
        GroupBox2.Controls.Add(Label1)
        GroupBox2.Location = New Point(0, 11)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(735, 43)
        GroupBox2.TabIndex = 57
        GroupBox2.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(143, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(373, 25)
        Label3.TabIndex = 28
        Label3.Text = "HERNINGSHOLM VOCATIONAL SCHOOL"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(212, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(226, 20)
        Label1.TabIndex = 0
        Label1.Text = "STUDENT APPLICATION FORM"
        ' 
        ' dtpApplicationDate
        ' 
        dtpApplicationDate.Location = New Point(360, 424)
        dtpApplicationDate.Name = "dtpApplicationDate"
        dtpApplicationDate.Size = New Size(221, 23)
        dtpApplicationDate.TabIndex = 53
        ' 
        ' txtSchool
        ' 
        txtSchool.BackColor = Color.Silver
        txtSchool.Location = New Point(360, 395)
        txtSchool.Name = "txtSchool"
        txtSchool.Size = New Size(214, 23)
        txtSchool.TabIndex = 52
        ' 
        ' cmbCourse
        ' 
        cmbCourse.BackColor = Color.Silver
        cmbCourse.FormattingEnabled = True
        cmbCourse.Location = New Point(360, 366)
        cmbCourse.Name = "cmbCourse"
        cmbCourse.Size = New Size(135, 23)
        cmbCourse.TabIndex = 51
        ' 
        ' lblschool
        ' 
        lblschool.AutoSize = True
        lblschool.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblschool.Location = New Point(85, 408)
        lblschool.Name = "lblschool"
        lblschool.Size = New Size(121, 15)
        lblschool.TabIndex = 50
        lblschool.Text = "PREVIOUS SCHOOL :"
        ' 
        ' lblCourse
        ' 
        lblCourse.AutoSize = True
        lblCourse.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblCourse.Location = New Point(85, 378)
        lblCourse.Name = "lblCourse"
        lblCourse.Size = New Size(59, 15)
        lblCourse.TabIndex = 49
        lblCourse.Text = "COURSE :"
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblDate.Location = New Point(85, 436)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(114, 15)
        lblDate.TabIndex = 48
        lblDate.Text = "APPLICATION DATE"
        ' 
        ' lblAccademicInfo
        ' 
        lblAccademicInfo.AutoSize = True
        lblAccademicInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblAccademicInfo.Location = New Point(297, 348)
        lblAccademicInfo.Name = "lblAccademicInfo"
        lblAccademicInfo.Size = New Size(160, 15)
        lblAccademicInfo.TabIndex = 47
        lblAccademicInfo.Text = "ACCADEMIC INFORMATION"
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.Silver
        txtAddress.Location = New Point(360, 312)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(210, 23)
        txtAddress.TabIndex = 46
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.Silver
        txtEmail.Location = New Point(360, 283)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(214, 23)
        txtEmail.TabIndex = 45
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.BackColor = Color.Silver
        txtPhoneNumber.Location = New Point(360, 249)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(214, 23)
        txtPhoneNumber.TabIndex = 44
        ' 
        ' dtpDateOfBirth
        ' 
        dtpDateOfBirth.Location = New Point(360, 117)
        dtpDateOfBirth.Name = "dtpDateOfBirth"
        dtpDateOfBirth.Size = New Size(214, 23)
        dtpDateOfBirth.TabIndex = 43
        ' 
        ' txtNationality
        ' 
        txtNationality.BackColor = Color.Silver
        txtNationality.Location = New Point(360, 189)
        txtNationality.Name = "txtNationality"
        txtNationality.Size = New Size(214, 23)
        txtNationality.TabIndex = 41
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.Silver
        txtName.Location = New Point(360, 84)
        txtName.Name = "txtName"
        txtName.Size = New Size(214, 23)
        txtName.TabIndex = 40
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold)
        lblAddress.Location = New Point(85, 328)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(67, 15)
        lblAddress.TabIndex = 39
        lblAddress.Text = "ADDRESS :"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(85, 291)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(42, 15)
        lblEmail.TabIndex = 38
        lblEmail.Text = "Email :"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPhoneNumber.Location = New Point(85, 258)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(107, 15)
        lblPhoneNumber.TabIndex = 37
        lblPhoneNumber.Text = "PHONE NUMBER :"
        ' 
        ' lblcontact
        ' 
        lblcontact.AutoSize = True
        lblcontact.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblcontact.Location = New Point(297, 228)
        lblcontact.Name = "lblcontact"
        lblcontact.Size = New Size(146, 15)
        lblcontact.TabIndex = 36
        lblcontact.Text = "CONTACT INFORMATION"
        ' 
        ' lblNationality
        ' 
        lblNationality.AutoSize = True
        lblNationality.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNationality.Location = New Point(85, 197)
        lblNationality.Name = "lblNationality"
        lblNationality.Size = New Size(73, 15)
        lblNationality.TabIndex = 35
        lblNationality.Text = "Nationality :"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGender.Location = New Point(85, 164)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(60, 15)
        lblGender.TabIndex = 34
        lblGender.Text = "GENDER :"
        ' 
        ' lblDateOfBirth
        ' 
        lblDateOfBirth.AutoSize = True
        lblDateOfBirth.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDateOfBirth.Location = New Point(85, 125)
        lblDateOfBirth.Name = "lblDateOfBirth"
        lblDateOfBirth.Size = New Size(88, 15)
        lblDateOfBirth.TabIndex = 33
        lblDateOfBirth.Text = "Date Of Birth :"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(85, 92)
        lblName.Name = "lblName"
        lblName.Size = New Size(77, 15)
        lblName.TabIndex = 32
        lblName.Text = "FULL NAME :"
        ' 
        ' lblInfo
        ' 
        lblInfo.AutoSize = True
        lblInfo.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInfo.Location = New Point(297, 56)
        lblInfo.Name = "lblInfo"
        lblInfo.Size = New Size(153, 15)
        lblInfo.TabIndex = 31
        lblInfo.Text = "PERSONAL INFORMATION"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Image = My.Resources.Resources.SEE_HERE
        Label2.Location = New Point(318, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 15)
        Label2.TabIndex = 30
        ' 
        ' rbMale
        ' 
        rbMale.AutoSize = True
        rbMale.Location = New Point(360, 157)
        rbMale.Name = "rbMale"
        rbMale.Size = New Size(51, 19)
        rbMale.TabIndex = 58
        rbMale.TabStop = True
        rbMale.Text = "Male"
        rbMale.UseVisualStyleBackColor = True
        ' 
        ' rbFemale
        ' 
        rbFemale.AutoSize = True
        rbFemale.Location = New Point(440, 157)
        rbFemale.Name = "rbFemale"
        rbFemale.Size = New Size(63, 19)
        rbFemale.TabIndex = 59
        rbFemale.TabStop = True
        rbFemale.Text = "Female"
        rbFemale.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Silver
        BackgroundImage = My.Resources.Resources.ben_10
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1130, 611)
        Controls.Add(GroupBox1)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "HERNINGSHOLM VOCATIONAL SCHOOL - Student Application"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnApply As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents dtpApplicationDate As DateTimePicker
    Friend WithEvents txtSchool As TextBox
    Friend WithEvents cmbCourse As ComboBox
    Friend WithEvents lblschool As Label
    Friend WithEvents lblCourse As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblAccademicInfo As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents dtpDateOfBirth As DateTimePicker
    Friend WithEvents txtNationality As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblcontact As Label
    Friend WithEvents lblNationality As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents rbMale As RadioButton
    Friend WithEvents rbFemale As RadioButton

End Class
