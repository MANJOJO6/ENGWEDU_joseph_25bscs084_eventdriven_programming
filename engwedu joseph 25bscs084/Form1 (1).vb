Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    ' ---- Input restrictions (block invalid characters as the user types) ----

    ' Full Name and Nationality: letters and spaces only
    Private Sub LettersOnly_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress, txtNationality.KeyPress
        If Not (Char.IsLetter(e.KeyChar) OrElse e.KeyChar = " "c OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    ' Phone Number: digits only
    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    ' Email: letters, digits, and the characters @ . _ - only
    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        If Not (Char.IsLetterOrDigit(e.KeyChar) OrElse "@._-".IndexOf(e.KeyChar) >= 0 OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    ' Address and Previous School: letters, digits, spaces and basic punctuation (blocks symbols like @ # $ % etc.)
    Private Sub AddressStyle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAddress.KeyPress, txtSchool.KeyPress
        If Not (Char.IsLetterOrDigit(e.KeyChar) OrElse " ,.-".IndexOf(e.KeyChar) >= 0 OrElse Char.IsControl(e.KeyChar)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click

        Dim errorList As New List(Of String)

        ' Required-field checks
        If txtName.Text.Trim() = "" Then errorList.Add("Full Name is required.")
        If txtNationality.Text.Trim() = "" Then errorList.Add("Nationality is required.")
        If txtPhoneNumber.Text.Trim() = "" Then errorList.Add("Phone Number is required.")
        If txtEmail.Text.Trim() = "" Then errorList.Add("Email is required.")
        If txtSchool.Text.Trim() = "" Then errorList.Add("Previous School is required.")
        If txtAddress.Text.Trim() = "" Then errorList.Add("Address is required.")
        If cmbCourse.SelectedIndex = -1 Then errorList.Add("Please select a Course.")
        If Not (rbMale.Checked Or rbFemale.Checked) Then errorList.Add("Please select a Gender.")

        ' Format checks (catch pasted text that slipped past the KeyPress filters)
        If txtName.Text.Trim() <> "" AndAlso Not Regex.IsMatch(txtName.Text.Trim(), "^[A-Za-z ]+$") Then
            errorList.Add("Full Name must contain letters only.")
        End If

        If txtNationality.Text.Trim() <> "" AndAlso Not Regex.IsMatch(txtNationality.Text.Trim(), "^[A-Za-z ]+$") Then
            errorList.Add("Nationality must contain letters only.")
        End If

        If txtPhoneNumber.Text.Trim() <> "" Then
            If Not Regex.IsMatch(txtPhoneNumber.Text.Trim(), "^[0-9]+$") Then
                errorList.Add("Phone Number must contain numbers only.")
            ElseIf txtPhoneNumber.Text.Trim().Length < 7 Then
                errorList.Add("Phone Number must be at least 7 digits.")
            End If
        End If

        If txtEmail.Text.Trim() <> "" AndAlso Not Regex.IsMatch(txtEmail.Text.Trim(), "^[^@\s]+@[^@\s]+\.[^@\s]+$") Then
            errorList.Add("Email must contain an '@' sign and a valid domain (e.g. name@example.com).")
        End If

        If errorList.Count > 0 Then

            MessageBox.Show("APPLICATION FAILED!" & vbCrLf & vbCrLf &
                        "Please fix the following:" & vbCrLf &
                        "- " & String.Join(vbCrLf & "- ", errorList),
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

        rbMale.Checked = False
        rbFemale.Checked = False
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
