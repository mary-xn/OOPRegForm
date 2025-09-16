Imports System.Data
Imports System.Data.OleDb

Public Class MainPage
    Private ReadOnly connectionString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\jrcan\OneDrive\Desktop\students.accdb"

    Private Sub MainPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()

    End Sub

    Private Sub LoadStudents()
        Try
            Using con As New OleDbConnection(connectionString)
                con.Open()
                Dim query As String = "SELECT * FROM students"
                Dim adapter As New OleDbDataAdapter(query, con)
                Dim table As New DataTable()
                adapter.Fill(table)
                StudentsGrid.DataSource = table
            End Using


            StudentsGrid.ReadOnly = True
            StudentsGrid.AllowUserToAddRows = False
            StudentsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        Catch ex As Exception
            MessageBox.Show("Error loading students: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub AddNewBtm_Click(sender As Object, e As EventArgs) Handles AddNewBtm.Click
        SharedData.studentID = ""
        Dim form As New Form1
        form.Show()
        Me.Hide()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If String.IsNullOrWhiteSpace(SharedData.studentID) Then
            MessageBox.Show("Please select a student to update.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        Dim editForm As New Form1
        editForm.Show()
        Me.Hide()
    End Sub


    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If String.IsNullOrWhiteSpace(SharedData.studentID) Then
            MessageBox.Show("Please select a student before deleting.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim result = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete",
                                         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                DatabaseHelper.DeleteStudent(SharedData.studentID)
                MessageBox.Show("Student record deleted successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadStudents()
                SharedData.studentID = "" ' clear selection
            End If
        Catch ex As Exception
            MessageBox.Show("Delete Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        LoadStudents()
        SharedData.studentID = ""
    End Sub


    Private Sub StudentsGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentsGrid.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = StudentsGrid.Rows(e.RowIndex)

            SharedData.studentID = row.Cells("s_studentID").Value.ToString()

            ' Split full name if needed
            Dim fullName As String = row.Cells("s_name").Value.ToString()
            Dim parts() As String = fullName.Split(" "c)
            If parts.Length >= 2 Then
                SharedData.firstName = parts(0)
                SharedData.lastName = parts(parts.Length - 1)
                If parts.Length > 2 Then SharedData.middleInitial = parts(1)
            Else
                SharedData.firstName = fullName
                SharedData.lastName = ""
                SharedData.middleInitial = ""
            End If

            SharedData.course = row.Cells("s_course").Value.ToString()
            SharedData.yearSection = row.Cells("s_yearsection").Value.ToString()
            SharedData.gender = row.Cells("s_gender").Value.ToString()
            SharedData.birthDate = Convert.ToDateTime(row.Cells("s_birthdate").Value)
            SharedData.age = Convert.ToInt32(row.Cells("s_age").Value)
            SharedData.contactNumber = row.Cells("s_contactnumber").Value.ToString()
            SharedData.email = row.Cells("s_email").Value.ToString()
            SharedData.address = row.Cells("s_address").Value.ToString()
        End If
    End Sub
End Class
