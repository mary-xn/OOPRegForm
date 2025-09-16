Imports System.Data.OleDb

Public Class Form1
    Private isEditMode As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DropDownCourse.Items.Clear()
        DropDownCourse.Items.AddRange(New String() {
            "BS Computer Science",
            "BS Information Technology",
            "BS Information Systems",
            "BS Software Engineering",
            "BS Data Science",
            "BS Cybersecurity",
            "BS Computer Engineering"
        })
        DropDownCourse.SelectedIndex = -1

        dropDownSuffix.Items.Clear()
        dropDownSuffix.Items.AddRange(New String() {"Jr.", "Sr."})
        dropDownSuffix.SelectedIndex = -1


        DropDownYearSection.Items.Clear()
        Dim sections As Char() = {"A"c, "B"c, "C"c}
        For year As Integer = 1 To 4
            For Each section As Char In sections
                DropDownYearSection.Items.Add($"{year}{section}")
            Next
        Next
        DropDownYearSection.SelectedIndex = -1


        If Not String.IsNullOrWhiteSpace(SharedData.studentID) Then
            ' for existing records
            isEditMode = True
            submitBtn.Text = "Update"

            txtboxStudentID.Text = SharedData.studentID
            txtBoxLastName.Text = SharedData.lastName
            txtBoxFirstName.Text = SharedData.firstName
            txtBoxMiddleInitial.Text = SharedData.middleInitial

            DropDownCourse.Text = SharedData.course
            DropDownYearSection.Text = SharedData.yearSection
            dtpBirthdate.Value = SharedData.birthDate

            If SharedData.gender = "Female" Then
                radioFemale.Checked = True
            ElseIf SharedData.gender = "Male" Then
                radioMale.Checked = True
            End If

            txtBoxAge.Text = SharedData.age.ToString()
            txtBoxContactNum.Text = SharedData.contactNumber
            txtBoxEmail.Text = SharedData.email
            txtBoxStreetAddress.Text = SharedData.address
        Else
            ' for adding new record
            isEditMode = False
            submitBtn.Text = "Submit"
        End If
    End Sub

    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Try
            ' assigning values
            SharedData.studentID = txtboxStudentID.Text.Trim()
            SharedData.lastName = txtBoxLastName.Text.Trim()
            SharedData.firstName = txtBoxFirstName.Text.Trim()
            SharedData.middleInitial = txtBoxMiddleInitial.Text.Trim()

            SharedData.course = DropDownCourse.Text
            SharedData.yearSection = DropDownYearSection.Text
            SharedData.birthDate = dtpBirthdate.Value.Date
            SharedData.gender = If(radioFemale.Checked, "Female", If(radioMale.Checked, "Male", "Prefer not to say"))
            SharedData.age = Convert.ToInt16(txtBoxAge.Text.Trim())
            SharedData.contactNumber = txtBoxContactNum.Text.Trim()
            SharedData.email = txtBoxEmail.Text.Trim()
            SharedData.address = txtBoxStreetAddress.Text.Trim()

            If isEditMode Then
                ' update exisiting rec
                UpdateRecord()
                MessageBox.Show("Student record updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                ' add new record
                InsertRecord()
                MessageBox.Show("Student record added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            ' return to mainpage
            Dim mainPage As New MainPage
            mainPage.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error saving record: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' insert query
    Private Sub InsertRecord()
        Dim Insertquery As String =
            "INSERT INTO students (s_studentID, s_name, s_course, s_yearsection, s_gender, s_birthdate, s_age, s_contactnumber, s_email, s_address) " &
            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\jrcan\OneDrive\Desktop\students.accdb")
            con.Open()
            Using cmd As New OleDbCommand(Insertquery, con)
                cmd.Parameters.AddWithValue("?", SharedData.studentID)
                cmd.Parameters.AddWithValue("?", SharedData.fullName)
                cmd.Parameters.AddWithValue("?", SharedData.course)
                cmd.Parameters.AddWithValue("?", SharedData.yearSection)
                cmd.Parameters.AddWithValue("?", SharedData.gender)
                cmd.Parameters.AddWithValue("?", SharedData.birthDate)
                cmd.Parameters.AddWithValue("?", SharedData.age)
                cmd.Parameters.AddWithValue("?", SharedData.contactNumber)
                cmd.Parameters.AddWithValue("?", SharedData.email)
                cmd.Parameters.AddWithValue("?", SharedData.address)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' update query
    Private Sub UpdateRecord()
        Dim Updatequery As String =
            "UPDATE students SET s_name=?, s_course=?, s_yearsection=?, s_gender=?, s_birthdate=?, s_age=?, s_contactnumber=?, s_email=?, s_address=? " &
            "WHERE s_studentID=?"

        Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\jrcan\OneDrive\Desktop\students.accdb")
            con.Open()
            Using cmd As New OleDbCommand(Updatequery, con)
                cmd.Parameters.AddWithValue("?", SharedData.fullName)
                cmd.Parameters.AddWithValue("?", SharedData.course)
                cmd.Parameters.AddWithValue("?", SharedData.yearSection)
                cmd.Parameters.AddWithValue("?", SharedData.gender)
                cmd.Parameters.AddWithValue("?", SharedData.birthDate)
                cmd.Parameters.AddWithValue("?", SharedData.age)
                cmd.Parameters.AddWithValue("?", SharedData.contactNumber)
                cmd.Parameters.AddWithValue("?", SharedData.email)
                cmd.Parameters.AddWithValue("?", SharedData.address)
                cmd.Parameters.AddWithValue("?", SharedData.studentID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' auto-calculate of age
    Private Sub dtpBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthdate.ValueChanged
        Dim today As Date = Date.Today
        Dim age As Integer = today.Year - dtpBirthdate.Value.Year
        If (dtpBirthdate.Value.Date > today.AddYears(-age)) Then age -= 1
        txtBoxAge.Text = age.ToString()
    End Sub

    Private Sub BackToHomeBtn_Click(sender As Object, e As EventArgs) Handles BackToHomeBtn.Click
        Dim mainPage As New MainPage
        mainPage.Show()
        Me.Hide()
    End Sub
End Class
