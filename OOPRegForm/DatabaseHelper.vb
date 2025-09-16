Imports System.Data.OleDb

Public Module DatabaseHelper
    Private ReadOnly connectionString As String = "Provider=Microsoft.ACE.OLEDB.16.0;Data Source=C:\Users\jrcan\OneDrive\Desktop\students.accdb"

    Public Sub InsertStudent()
        Dim query As String = "INSERT INTO students (s_studentID, s_name, s_course, s_yearsection, s_gender, s_birthdate, s_age, s_contactnumber, s_email, s_address) " &
                              "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

        Using con As New OleDbConnection(connectionString)
            con.Open()
            Using cmd As New OleDbCommand(query, con)
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

    Public Sub UpdateStudent()
        Dim query As String = "UPDATE students SET s_name=?, s_course=?, s_yearsection=?, s_gender=?, s_birthdate=?, s_age=?, s_contactnumber=?, s_email=?, s_address=? WHERE s_studentID=?"

        Using con As New OleDbConnection(connectionString)
            con.Open()
            Using cmd As New OleDbCommand(query, con)
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

    Public Sub DeleteStudent(studentID As String)
        Dim query As String = "DELETE FROM students WHERE s_studentID=?"
        Using con As New OleDbConnection(connectionString)
            con.Open()
            Using cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("?", studentID)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub
End Module
