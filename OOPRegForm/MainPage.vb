Public Class MainPage
    Private Sub AddNewBtm_Click(sender As Object, e As EventArgs) Handles AddNewBtm.Click
        Dim form As New Form1
        form.Show()
        Me.Hide()
    End Sub
End Class