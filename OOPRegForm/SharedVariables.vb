Public Module SharedData
    ' Student Identifiers
    Public studentID As String

    ' Student Name (separated for editing)
    Public lastName As String
    Public firstName As String
    Public middleInitial As String

    Public ReadOnly Property fullName As String
        Get
            Dim miFormatted As String = If(String.IsNullOrWhiteSpace(middleInitial), "", middleInitial.Trim().ToUpper() & ". ")
            Return $"{firstName} {miFormatted}{lastName}".Trim()
        End Get
    End Property

    Public course As String
    Public yearSection As String


    Public birthDate As Date
    Public gender As String
    Public age As Integer


    Public contactNumber As String
    Public email As String
    Public address As String
End Module
