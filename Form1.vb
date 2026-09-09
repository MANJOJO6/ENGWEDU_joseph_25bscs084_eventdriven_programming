Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbGender.Items.Add("Male")
        cmbGender.Items.Add("Female")


        cmbCourse.Items.Add("Electrical Installation")
        cmbCourse.Items.Add("Plumbing")
        cmbCourse.Items.Add("Motor Vehicle Mechanics")
        cmbCourse.Items.Add("Building and Construction")
        cmbCourse.Items.Add("Tailoring and Fashion Design")
        cmbCourse.Items.Add("Hairdressing and Beauty")
        cmbCourse.Items.Add("Catering and Hotel Management")
        cmbCourse.Items.Add("Computer Applications")
        cmbCourse.Items.Add("Welding and Metal Fabrication")
        cmbCourse.Items.Add("Carpentry and Joinery")



    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click

        If txtName.Text.Trim() = "" Or
       txtNationality.Text.Trim() = "" Or
       txtPhoneNumber.Text.Trim() = "" Or
       txtEmail.Text.Trim() = "" Or
       txtSchool.Text.Trim() = "" Or
       txtAddress.Text.Trim() = "" Or
       cmbGender.SelectedIndex = -1 Or
       cmbCourse.SelectedIndex = -1 Then

            MessageBox.Show("APPLICATION FAILED!" & vbCrLf & vbCrLf &
                        "Please fill in all the required fields.",
                        "Application Failed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error)

        Else

            MessageBox.Show("STUDENT APPLICATION SUBMITTED SUCCESSFULLY!" & vbCrLf & vbCrLf &
                        "Welcome to HERNINGSHOLM VOCATIONAL SCHOOL!" & vbCrLf &
                        "Your application has been received successfully.",
                        "Application Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information)

        End If

    End Sub


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtName.Clear()
        txtNationality.Clear()
        txtPhoneNumber.Clear()
        txtEmail.Clear()
        txtAddress.Clear()
        txtSchool.Clear()

        cmbGender.SelectedIndex = -1
        cmbCourse.SelectedIndex = -1

        dtpDateOfBirth.Value = Date.Today

        txtName.Focus()

    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim answer As DialogResult

        answer = MessageBox.Show("Are you sure you want to exit?",
                             "Exit Application",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question)

        If answer = DialogResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
