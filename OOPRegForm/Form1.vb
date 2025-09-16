Imports System.Data
Imports System.Data.OleDb
Imports System.Runtime.CompilerServices

Public Class Form1
    Inherits Form

    Dim con As OleDbConnection
    Dim studentID As String
    Dim fullName As String
    Dim course As String
    Dim yearSection As String
    Dim birthDate As DateTime
    Dim gender As String
    Dim age As Int16
    Dim contactNumber As Long
    Dim email As String
    Dim address As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' --- Populate Course Dropdown ---
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

        ' --- Populate Suffix Dropdown ---
        dropDownSuffix.Items.Clear()
        dropDownSuffix.Items.AddRange(New String() {"Jr.", "Sr."})
        dropDownSuffix.SelectedIndex = -1

        ' --- Populate Year and Section Dropdown (1A–4C) ---
        DropDownYearSection.Items.Clear()
        Dim sections As Char() = {"A"c, "B"c, "C"c}
        For year As Integer = 1 To 4
            For Each section As Char In sections
                DropDownYearSection.Items.Add($"{year}{section}")
            Next
        Next
        DropDownYearSection.SelectedIndex = -1
    End Sub




    Private Sub submitBtn_Click(sender As Object, e As EventArgs) Handles submitBtn.Click
        Dim emptyFields As New List(Of String)

        ' Check for empty required fields first
        If String.IsNullOrWhiteSpace(txtboxStudentID.Text) Then
            emptyFields.Add("Student ID")
        End If
        If String.IsNullOrWhiteSpace(txtBoxLastName.Text) Then
            emptyFields.Add("Last Name")
        End If
        If String.IsNullOrWhiteSpace(txtBoxFirstName.Text) Then
            emptyFields.Add("First Name")
        End If
        If String.IsNullOrWhiteSpace(txtBoxBarangay.Text) Then
            emptyFields.Add("Barangay")
        End If
        ' Middle Initial can be optional, skip empty check if optional

        If DropDownCourse.SelectedIndex = -1 Then
            emptyFields.Add("Course")
        End If

        If DropDownYearSection.SelectedIndex = -1 Then
            emptyFields.Add("Year and Section")
        End If

        ' Gender radio buttons check
        If Not (radioFemale.Checked Or radioMale.Checked Or radioPreferNotToSay.Checked) Then
            emptyFields.Add("Gender")
        End If

        If String.IsNullOrWhiteSpace(txtBoxAge.Text) Then
            emptyFields.Add("Age")
        End If

        If String.IsNullOrWhiteSpace(txtBoxContactNum.Text) Then
            emptyFields.Add("Contact Number")
        End If

        If String.IsNullOrWhiteSpace(txtBoxEmail.Text) Then
            emptyFields.Add("Email")
        End If

        If String.IsNullOrWhiteSpace(txtBoxStreetAddress.Text) Then
            emptyFields.Add("Street Address")
        End If

        If String.IsNullOrWhiteSpace(txtBoxProvince.Text) Then
            emptyFields.Add("Province")
        End If

        If String.IsNullOrWhiteSpace(txtBoxCity.Text) Then
            emptyFields.Add("City")
        End If

        If String.IsNullOrWhiteSpace(txtBoxPostalCode.Text) Then
            emptyFields.Add("Postal Code")
        End If

        If String.IsNullOrWhiteSpace(txtBoxBarangay.Text) Then
            emptyFields.Add("Barangay")
        End If


        ' If there are empty fields, show one message listing them all
        If emptyFields.Count > 0 Then
            Dim message As String = "Please fill in the following required fields:" & Environment.NewLine & String.Join(Environment.NewLine, emptyFields)
            MessageBox.Show(message, "Missing Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' --- Now do your regex and validation logic for formats ---

        Dim nameRegex As String = "^[A-Za-z\s\-']+$"
        Dim middleInitialRegex As String = "^[A-Za-z]$"
        Dim studentIDRegex As String = "^(19|20)\d{2}\d{4}-[A-Z]$"
        Dim contactRegex As String = "^\d{10,15}$"
        Dim emailRegex As String = "^[^@\s]+@[^@\s]+\.[^@\s]+$"
        Dim postalCodeRegex As String = "^\d{4,6}$"

        ' Student ID format check
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtboxStudentID.Text, studentIDRegex) Then
            MessageBox.Show("Student ID must be in the format YYYYNNNN-X (e.g., 20240310-C).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtboxStudentID.Focus()
            Exit Sub
        Else
            ' Validate year part of Student ID
            Dim yearPart As String = txtboxStudentID.Text.Substring(0, 4)
            Dim yearValue As Integer
            If Integer.TryParse(yearPart, yearValue) Then
                If yearValue > Date.Now.Year Then
                    MessageBox.Show("The year in Student ID cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtboxStudentID.Focus()
                    Exit Sub
                End If
            Else
                MessageBox.Show("Invalid year in Student ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtboxStudentID.Focus()
                Exit Sub
            End If
        End If

        ' Last Name validation
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtBoxLastName.Text, nameRegex) Then
            MessageBox.Show("Please enter a valid Last Name (letters only).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxLastName.Focus()
            Exit Sub
        End If

        ' First Name validation
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtBoxFirstName.Text, nameRegex) Then
            MessageBox.Show("Please enter a valid First Name (letters only).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxFirstName.Focus()
            Exit Sub
        End If

        ' Middle Initial validation (optional field)
        If Not String.IsNullOrWhiteSpace(txtBoxMiddleInitial.Text) AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(txtBoxMiddleInitial.Text, middleInitialRegex) Then
            MessageBox.Show("Middle Initial must be a single letter.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxMiddleInitial.Focus()
            Exit Sub
        End If

        ' Birthdate check
        If dtpBirthdate.Value > Date.Now Then
            MessageBox.Show("Birthdate cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dtpBirthdate.Focus()
            Exit Sub
        End If

        ' Age validation (must match birthdate)
        Dim calculatedAge As Integer = Date.Now.Year - dtpBirthdate.Value.Year
        If dtpBirthdate.Value.Date > Date.Now.AddYears(-calculatedAge) Then
            calculatedAge -= 1
        End If

        Dim inputAge As Integer
        If Not Integer.TryParse(txtBoxAge.Text, inputAge) OrElse inputAge <> calculatedAge Then
            MessageBox.Show("Age does not match Birthdate.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxAge.Focus()
            Exit Sub
        End If

        ' Contact Number validation
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtBoxContactNum.Text, contactRegex) Then
            MessageBox.Show("Please enter a valid Contact Number (10–15 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxContactNum.Focus()
            Exit Sub
        End If

        ' Email validation
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtBoxEmail.Text, emailRegex) Then
            MessageBox.Show("Please enter a valid Email Address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxEmail.Focus()
            Exit Sub
        End If

        ' Province validation
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtBoxProvince.Text, nameRegex) Then
            MessageBox.Show("Please enter a valid Province (letters only).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxProvince.Focus()
            Exit Sub
        End If

        ' City validation
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtBoxCity.Text, nameRegex) Then
            MessageBox.Show("Please enter a valid City (letters only).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxCity.Focus()
            Exit Sub
        End If



        ' Postal Code validation
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtBoxPostalCode.Text, postalCodeRegex) Then
            MessageBox.Show("Please enter a valid Postal Code (numeric only, 4–6 digits).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxPostalCode.Focus()
            Exit Sub
        End If

        Dim addressPartRegex As String = "^[A-Za-z0-9\s\-']+$" ' letters, numbers, spaces, hyphens

        If Not String.IsNullOrWhiteSpace(txtBoxLot.Text) AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(txtBoxLot.Text, addressPartRegex) Then
            MessageBox.Show("Lot must contain only letters, numbers, or hyphens.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxLot.Focus()
            Exit Sub
        End If

        If Not String.IsNullOrWhiteSpace(txtBoxBlock.Text) AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(txtBoxBlock.Text, addressPartRegex) Then
            MessageBox.Show("Block must contain only letters, numbers, or hyphens.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxBlock.Focus()
            Exit Sub
        End If

        If Not String.IsNullOrWhiteSpace(txtBoxHouseNum.Text) AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(txtBoxHouseNum.Text, addressPartRegex) Then
            MessageBox.Show("House Number must contain only letters, numbers, or hyphens.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxHouseNum.Focus()
            Exit Sub
        End If

        Dim barangayRegex As String = "^\d+$"
        If Not System.Text.RegularExpressions.Regex.IsMatch(txtBoxBarangay.Text.Trim(), barangayRegex) Then
            MessageBox.Show("Barangay must contain numbers only.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxBarangay.Focus()
            Exit Sub
        End If


        ' Assign form values to variables
        studentID = txtboxStudentID.Text.Trim()

        ' Format full name: First M. Last, Suffix (if available)
        Dim miFormatted As String = If(String.IsNullOrWhiteSpace(txtBoxMiddleInitial.Text), "", txtBoxMiddleInitial.Text.Trim().ToUpper() & ". ")
        Dim suffixFormatted As String = If(String.IsNullOrWhiteSpace(dropDownSuffix.Text), "", ", " & dropDownSuffix.Text.Trim())
        fullName = $"{txtBoxFirstName.Text.Trim()} {miFormatted}{txtBoxLastName.Text.Trim()}{suffixFormatted}"

        course = DropDownCourse.Text
        yearSection = DropDownYearSection.Text
        birthDate = dtpBirthdate.Value ' standard date format

        If radioFemale.Checked Then
            gender = "Female"
        ElseIf radioMale.Checked Then
            gender = "Male"
        ElseIf radioPreferNotToSay.Checked Then
            gender = "Prefer not to say"
        End If

        ' Safe parsing for numeric fields
        age = Convert.ToInt16(txtBoxAge.Text.Trim())
        If Not Long.TryParse(txtBoxContactNum.Text.Trim(), contactNumber) Then
            MessageBox.Show("Invalid contact number (too long or not numeric).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxContactNum.Focus()
            Exit Sub
        End If

        txtBoxContactNum.MaxLength = 11

        email = txtBoxEmail.Text.Trim()

        ' Optional address parts
        Dim houseNum As String = txtBoxHouseNum.Text.Trim()
        Dim lot As String = txtBoxLot.Text.Trim()
        Dim block As String = txtBoxBlock.Text.Trim()
        Dim barangay As Integer
        If Not Integer.TryParse(txtBoxBarangay.Text.Trim(), barangay) Then
            MessageBox.Show("Barangay must be a valid number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtBoxBarangay.Focus()
            Exit Sub
        End If

        txtBoxBarangay.MaxLength = 3

        ' Full address format (include optional if filled)
        Dim optionalParts As String = ""
        If Not String.IsNullOrWhiteSpace(houseNum) Then optionalParts &= $"House No. {houseNum}, "
        If Not String.IsNullOrWhiteSpace(lot) Then optionalParts &= $"Lot {lot}, "
        If Not String.IsNullOrWhiteSpace(block) Then optionalParts &= $"Block {block}, "
        If Not String.IsNullOrWhiteSpace(barangay) Then optionalParts &= $"Brgy. {barangay}, "

        ' Final full address
        address = $"{optionalParts}{txtBoxStreetAddress.Text.Trim()}, {txtBoxCity.Text.Trim()}, {txtBoxProvince.Text.Trim()}, {txtBoxPostalCode.Text.Trim()}"

        Dim Insertquery As String = "INSERT INTO students (s_studentID, s_name, s_course, s_yearsection, s_gender, s_birthdate, s_age, s_contactnumber, s_email, s_address) 
VALUES(?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
        Runquery(Insertquery)

        ' If reached here, all validations passed
        MessageBox.Show("Form submitted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)




    End Sub

    Private Sub dtpBirthdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpBirthdate.ValueChanged
        Dim today As Date = Date.Today
        Dim birthDate As Date = dtpBirthdate.Value

        Dim age As Integer = today.Year - birthDate.Year

        If birthDate > today.AddYears(-age) Then
            age -= 1
        End If

        txtBoxAge.Text = age.ToString()
    End Sub

    Private Sub BackToHomeBtn_Click(sender As Object, e As EventArgs) Handles BackToHomeBtn.Click
        Dim main As New MainPage()
        main.Show()           ' Show MainPage
        Me.Hide()             ' Optionally hide the current form
    End Sub

    Private Sub txtBoxBarangay_TextChanged(sender As Object, e As EventArgs) Handles txtBoxBarangay.TextChanged

    End Sub

    Private Sub txtBoxLot_TextChanged(sender As Object, e As EventArgs) Handles txtBoxLot.TextChanged

    End Sub

    Private Sub txtBoxBlock_TextChanged(sender As Object, e As EventArgs) Handles txtBoxBlock.TextChanged

    End Sub

    Private Sub txtBoxCity_TextChanged(sender As Object, e As EventArgs) Handles txtBoxCity.TextChanged

    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        ' Textboxes
        txtboxStudentID.Clear()
        txtBoxLastName.Clear()
        txtBoxFirstName.Clear()
        txtBoxMiddleInitial.Clear()
        txtBoxAge.Clear()
        txtBoxContactNum.Clear()
        txtBoxEmail.Clear()
        txtBoxStreetAddress.Clear()
        txtBoxLot.Clear()
        txtBoxBlock.Clear()
        txtBoxBarangay.Clear()
        txtBoxProvince.Clear()
        txtBoxCity.Clear()
        txtBoxPostalCode.Clear()

        ' Dropdowns
        DropDownCourse.SelectedIndex = -1
        DropDownYearSection.SelectedIndex = -1
        dropDownSuffix.SelectedIndex = -1

        ' Radio buttons
        radioFemale.Checked = False
        radioMale.Checked = False
        radioPreferNotToSay.Checked = False

        ' Date picker
        dtpBirthdate.Value = Date.Today
    End Sub

    Public Sub Runquery(ByVal query As String)
        Try
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\jrcan\OneDrive\Desktop\students.accdb")
            con.Open()

            Using cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("?", studentID)         ' s_studentID
                cmd.Parameters.AddWithValue("?", fullName)          ' s_name
                cmd.Parameters.AddWithValue("?", course)            ' s_course
                cmd.Parameters.AddWithValue("?", yearSection)       ' s_yearsection
                cmd.Parameters.AddWithValue("?", gender)            ' s_gender
                cmd.Parameters.AddWithValue("?", birthDate) ' s_birthdate (use DateTime)
                cmd.Parameters.AddWithValue("?", age)               ' s_age
                cmd.Parameters.AddWithValue("?", contactNumber)     ' s_contactnumber
                cmd.Parameters.AddWithValue("?", email)             ' s_email
                cmd.Parameters.AddWithValue("?", address)


                cmd.ExecuteNonQuery()
            End Using

            MessageBox.Show("Student information saved to database.", "Database Insert", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Database Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub


    Private Sub dropDownSuffix_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dropDownSuffix.SelectedIndexChanged

    End Sub

    Private Sub txtBoxHouseNum_TextChanged(sender As Object, e As EventArgs) Handles txtBoxHouseNum.TextChanged

    End Sub

    Private Sub txtBoxMiddleInitial_TextChanged(sender As Object, e As EventArgs) Handles txtBoxMiddleInitial.TextChanged

    End Sub

    Private Sub txtBoxFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtBoxFirstName.TextChanged

    End Sub

    Private Sub txtBoxLastName_TextChanged(sender As Object, e As EventArgs) Handles txtBoxLastName.TextChanged

    End Sub

    Private Sub DropDownCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownCourse.SelectedIndexChanged

    End Sub

    Private Sub DropDownYearSection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DropDownYearSection.SelectedIndexChanged

    End Sub

    Private Sub radioFemale_CheckedChanged(sender As Object, e As EventArgs) Handles radioFemale.CheckedChanged

    End Sub

    Private Sub radioMale_CheckedChanged(sender As Object, e As EventArgs) Handles radioMale.CheckedChanged

    End Sub

    Private Sub radioPreferNotToSay_CheckedChanged(sender As Object, e As EventArgs) Handles radioPreferNotToSay.CheckedChanged

    End Sub

    Private Sub txtBoxAge_TextChanged(sender As Object, e As EventArgs) Handles txtBoxAge.TextChanged

    End Sub

    Private Sub txtBoxContactNum_TextChanged(sender As Object, e As EventArgs) Handles txtBoxContactNum.TextChanged

    End Sub

    Private Sub txtBoxEmail_TextChanged(sender As Object, e As EventArgs) Handles txtBoxEmail.TextChanged

    End Sub

    Private Sub txtboxStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtboxStudentID.TextChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub txtBoxStreetAddress_TextChanged(sender As Object, e As EventArgs) Handles txtBoxStreetAddress.TextChanged

    End Sub
End Class
