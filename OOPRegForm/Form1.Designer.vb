<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.STudentIDLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.MiddleInitialLabel = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DropDownCourse = New System.Windows.Forms.ComboBox()
        Me.txtBoxLastName = New System.Windows.Forms.TextBox()
        Me.txtBoxFirstName = New System.Windows.Forms.TextBox()
        Me.txtBoxMiddleInitial = New System.Windows.Forms.TextBox()
        Me.SuffixLabel = New System.Windows.Forms.Label()
        Me.dropDownSuffix = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DropDownYearSection = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.radioFemale = New System.Windows.Forms.RadioButton()
        Me.radioMale = New System.Windows.Forms.RadioButton()
        Me.radioPreferNotToSay = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpBirthdate = New System.Windows.Forms.DateTimePicker()
        Me.txtBoxAge = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtBoxContactNum = New System.Windows.Forms.TextBox()
        Me.txtBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBoxStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtBoxProvince = New System.Windows.Forms.TextBox()
        Me.txtBoxCity = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtBoxBlock = New System.Windows.Forms.TextBox()
        Me.txtBoxHouseNum = New System.Windows.Forms.TextBox()
        Me.txtBoxPostalCode = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.submitBtn = New System.Windows.Forms.Button()
        Me.txtboxStudentID = New System.Windows.Forms.TextBox()
        Me.BackToHomeBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxLot = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxBarangay = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(498, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 50)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "REGISTRATION FORM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'STudentIDLabel
        '
        Me.STudentIDLabel.AutoSize = True
        Me.STudentIDLabel.BackColor = System.Drawing.Color.Transparent
        Me.STudentIDLabel.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.STudentIDLabel.Location = New System.Drawing.Point(12, 102)
        Me.STudentIDLabel.Name = "STudentIDLabel"
        Me.STudentIDLabel.Size = New System.Drawing.Size(116, 20)
        Me.STudentIDLabel.TabIndex = 3
        Me.STudentIDLabel.Text = "Student ID*"
        Me.STudentIDLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastNameLabel.Location = New System.Drawing.Point(131, 164)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(111, 20)
        Me.LastNameLabel.TabIndex = 7
        Me.LastNameLabel.Text = "Last Name*"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNameLabel.Location = New System.Drawing.Point(362, 164)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(114, 20)
        Me.FirstNameLabel.TabIndex = 8
        Me.FirstNameLabel.Text = "First Name*"
        '
        'MiddleInitialLabel
        '
        Me.MiddleInitialLabel.AutoSize = True
        Me.MiddleInitialLabel.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MiddleInitialLabel.Location = New System.Drawing.Point(591, 164)
        Me.MiddleInitialLabel.Name = "MiddleInitialLabel"
        Me.MiddleInitialLabel.Size = New System.Drawing.Size(37, 20)
        Me.MiddleInitialLabel.TabIndex = 9
        Me.MiddleInitialLabel.Text = "M.I"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(131, 236)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Course*"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DropDownCourse
        '
        Me.DropDownCourse.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropDownCourse.FormattingEnabled = True
        Me.DropDownCourse.Location = New System.Drawing.Point(135, 259)
        Me.DropDownCourse.Name = "DropDownCourse"
        Me.DropDownCourse.Size = New System.Drawing.Size(442, 28)
        Me.DropDownCourse.TabIndex = 15
        '
        'txtBoxLastName
        '
        Me.txtBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxLastName.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxLastName.Location = New System.Drawing.Point(135, 189)
        Me.txtBoxLastName.Multiline = True
        Me.txtBoxLastName.Name = "txtBoxLastName"
        Me.txtBoxLastName.Size = New System.Drawing.Size(211, 24)
        Me.txtBoxLastName.TabIndex = 16
        '
        'txtBoxFirstName
        '
        Me.txtBoxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxFirstName.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxFirstName.Location = New System.Drawing.Point(366, 189)
        Me.txtBoxFirstName.Multiline = True
        Me.txtBoxFirstName.Name = "txtBoxFirstName"
        Me.txtBoxFirstName.Size = New System.Drawing.Size(211, 24)
        Me.txtBoxFirstName.TabIndex = 17
        '
        'txtBoxMiddleInitial
        '
        Me.txtBoxMiddleInitial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxMiddleInitial.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxMiddleInitial.Location = New System.Drawing.Point(595, 189)
        Me.txtBoxMiddleInitial.Multiline = True
        Me.txtBoxMiddleInitial.Name = "txtBoxMiddleInitial"
        Me.txtBoxMiddleInitial.Size = New System.Drawing.Size(59, 24)
        Me.txtBoxMiddleInitial.TabIndex = 18
        '
        'SuffixLabel
        '
        Me.SuffixLabel.AutoSize = True
        Me.SuffixLabel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SuffixLabel.Location = New System.Drawing.Point(675, 166)
        Me.SuffixLabel.Name = "SuffixLabel"
        Me.SuffixLabel.Size = New System.Drawing.Size(49, 18)
        Me.SuffixLabel.TabIndex = 19
        Me.SuffixLabel.Text = "Suffix"
        '
        'dropDownSuffix
        '
        Me.dropDownSuffix.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropDownSuffix.FormattingEnabled = True
        Me.dropDownSuffix.Location = New System.Drawing.Point(679, 187)
        Me.dropDownSuffix.Name = "dropDownSuffix"
        Me.dropDownSuffix.Size = New System.Drawing.Size(59, 28)
        Me.dropDownSuffix.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(581, 236)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(164, 20)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Year and Section*"
        '
        'DropDownYearSection
        '
        Me.DropDownYearSection.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropDownYearSection.FormattingEnabled = True
        Me.DropDownYearSection.Location = New System.Drawing.Point(585, 259)
        Me.DropDownYearSection.Name = "DropDownYearSection"
        Me.DropDownYearSection.Size = New System.Drawing.Size(153, 28)
        Me.DropDownYearSection.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 316)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Gender*"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'radioFemale
        '
        Me.radioFemale.AutoSize = True
        Me.radioFemale.Location = New System.Drawing.Point(135, 318)
        Me.radioFemale.Name = "radioFemale"
        Me.radioFemale.Size = New System.Drawing.Size(74, 20)
        Me.radioFemale.TabIndex = 24
        Me.radioFemale.TabStop = True
        Me.radioFemale.Text = "Female"
        Me.radioFemale.UseVisualStyleBackColor = True
        '
        'radioMale
        '
        Me.radioMale.AutoSize = True
        Me.radioMale.Location = New System.Drawing.Point(286, 318)
        Me.radioMale.Name = "radioMale"
        Me.radioMale.Size = New System.Drawing.Size(58, 20)
        Me.radioMale.TabIndex = 25
        Me.radioMale.TabStop = True
        Me.radioMale.Text = "Male"
        Me.radioMale.UseVisualStyleBackColor = True
        '
        'radioPreferNotToSay
        '
        Me.radioPreferNotToSay.AutoSize = True
        Me.radioPreferNotToSay.Location = New System.Drawing.Point(427, 318)
        Me.radioPreferNotToSay.Name = "radioPreferNotToSay"
        Me.radioPreferNotToSay.Size = New System.Drawing.Size(124, 20)
        Me.radioPreferNotToSay.TabIndex = 26
        Me.radioPreferNotToSay.TabStop = True
        Me.radioPreferNotToSay.Text = "Prefer not to say"
        Me.radioPreferNotToSay.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(131, 357)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 20)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Birthdate*"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(674, 357)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 20)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Age*"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpBirthdate
        '
        Me.dtpBirthdate.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpBirthdate.Location = New System.Drawing.Point(135, 383)
        Me.dtpBirthdate.MaxDate = New Date(2025, 9, 17, 0, 0, 0, 0)
        Me.dtpBirthdate.Name = "dtpBirthdate"
        Me.dtpBirthdate.Size = New System.Drawing.Size(519, 28)
        Me.dtpBirthdate.TabIndex = 29
        '
        'txtBoxAge
        '
        Me.txtBoxAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxAge.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxAge.Location = New System.Drawing.Point(675, 383)
        Me.txtBoxAge.Multiline = True
        Me.txtBoxAge.Name = "txtBoxAge"
        Me.txtBoxAge.Size = New System.Drawing.Size(59, 24)
        Me.txtBoxAge.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(7, 435)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 20)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Contact No.*"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBoxContactNum
        '
        Me.txtBoxContactNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxContactNum.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxContactNum.Location = New System.Drawing.Point(134, 435)
        Me.txtBoxContactNum.Multiline = True
        Me.txtBoxContactNum.Name = "txtBoxContactNum"
        Me.txtBoxContactNum.Size = New System.Drawing.Size(603, 24)
        Me.txtBoxContactNum.TabIndex = 32
        '
        'txtBoxEmail
        '
        Me.txtBoxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxEmail.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxEmail.Location = New System.Drawing.Point(135, 487)
        Me.txtBoxEmail.Multiline = True
        Me.txtBoxEmail.Name = "txtBoxEmail"
        Me.txtBoxEmail.Size = New System.Drawing.Size(603, 24)
        Me.txtBoxEmail.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(12, 487)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 20)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Email*"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(809, 102)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(148, 20)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Street Address*"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBoxStreetAddress
        '
        Me.txtBoxStreetAddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxStreetAddress.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxStreetAddress.Location = New System.Drawing.Point(812, 125)
        Me.txtBoxStreetAddress.Multiline = True
        Me.txtBoxStreetAddress.Name = "txtBoxStreetAddress"
        Me.txtBoxStreetAddress.Size = New System.Drawing.Size(497, 24)
        Me.txtBoxStreetAddress.TabIndex = 36
        '
        'txtBoxProvince
        '
        Me.txtBoxProvince.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxProvince.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxProvince.Location = New System.Drawing.Point(813, 341)
        Me.txtBoxProvince.Multiline = True
        Me.txtBoxProvince.Name = "txtBoxProvince"
        Me.txtBoxProvince.Size = New System.Drawing.Size(299, 24)
        Me.txtBoxProvince.TabIndex = 37
        '
        'txtBoxCity
        '
        Me.txtBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxCity.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxCity.Location = New System.Drawing.Point(1081, 263)
        Me.txtBoxCity.Multiline = True
        Me.txtBoxCity.Name = "txtBoxCity"
        Me.txtBoxCity.Size = New System.Drawing.Size(233, 24)
        Me.txtBoxCity.TabIndex = 38
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(809, 318)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(92, 20)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "Province*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(1077, 238)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(54, 20)
        Me.Label16.TabIndex = 40
        Me.Label16.Text = "City*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(1206, 166)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(55, 20)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Block"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(808, 166)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 20)
        Me.Label18.TabIndex = 43
        Me.Label18.Text = "House No."
        '
        'txtBoxBlock
        '
        Me.txtBoxBlock.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxBlock.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxBlock.Location = New System.Drawing.Point(1210, 191)
        Me.txtBoxBlock.Multiline = True
        Me.txtBoxBlock.Name = "txtBoxBlock"
        Me.txtBoxBlock.Size = New System.Drawing.Size(99, 24)
        Me.txtBoxBlock.TabIndex = 42
        '
        'txtBoxHouseNum
        '
        Me.txtBoxHouseNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxHouseNum.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxHouseNum.Location = New System.Drawing.Point(812, 191)
        Me.txtBoxHouseNum.Multiline = True
        Me.txtBoxHouseNum.Name = "txtBoxHouseNum"
        Me.txtBoxHouseNum.Size = New System.Drawing.Size(251, 24)
        Me.txtBoxHouseNum.TabIndex = 41
        '
        'txtBoxPostalCode
        '
        Me.txtBoxPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxPostalCode.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxPostalCode.Location = New System.Drawing.Point(1161, 341)
        Me.txtBoxPostalCode.Multiline = True
        Me.txtBoxPostalCode.Name = "txtBoxPostalCode"
        Me.txtBoxPostalCode.Size = New System.Drawing.Size(153, 24)
        Me.txtBoxPostalCode.TabIndex = 45
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(1157, 318)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(120, 20)
        Me.Label19.TabIndex = 46
        Me.Label19.Text = "Postal Code*"
        '
        'ClearBtn
        '
        Me.ClearBtn.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearBtn.Location = New System.Drawing.Point(604, 551)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(150, 42)
        Me.ClearBtn.TabIndex = 47
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = False
        '
        'submitBtn
        '
        Me.submitBtn.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.submitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.submitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.submitBtn.Location = New System.Drawing.Point(779, 551)
        Me.submitBtn.Name = "submitBtn"
        Me.submitBtn.Size = New System.Drawing.Size(150, 42)
        Me.submitBtn.TabIndex = 48
        Me.submitBtn.Text = "Submit"
        Me.submitBtn.UseVisualStyleBackColor = False
        '
        'txtboxStudentID
        '
        Me.txtboxStudentID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtboxStudentID.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtboxStudentID.Location = New System.Drawing.Point(135, 102)
        Me.txtboxStudentID.Multiline = True
        Me.txtboxStudentID.Name = "txtboxStudentID"
        Me.txtboxStudentID.Size = New System.Drawing.Size(603, 24)
        Me.txtboxStudentID.TabIndex = 49
        '
        'BackToHomeBtn
        '
        Me.BackToHomeBtn.BackColor = System.Drawing.Color.LemonChiffon
        Me.BackToHomeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackToHomeBtn.Location = New System.Drawing.Point(427, 551)
        Me.BackToHomeBtn.Name = "BackToHomeBtn"
        Me.BackToHomeBtn.Size = New System.Drawing.Size(150, 42)
        Me.BackToHomeBtn.TabIndex = 50
        Me.BackToHomeBtn.Text = "View"
        Me.BackToHomeBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1077, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Lot"
        '
        'txtBoxLot
        '
        Me.txtBoxLot.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxLot.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxLot.Location = New System.Drawing.Point(1081, 191)
        Me.txtBoxLot.Multiline = True
        Me.txtBoxLot.Name = "txtBoxLot"
        Me.txtBoxLot.Size = New System.Drawing.Size(99, 24)
        Me.txtBoxLot.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(809, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 20)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Barangay*"
        '
        'txtBoxBarangay
        '
        Me.txtBoxBarangay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBoxBarangay.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxBarangay.Location = New System.Drawing.Point(812, 263)
        Me.txtBoxBarangay.Multiline = True
        Me.txtBoxBarangay.Name = "txtBoxBarangay"
        Me.txtBoxBarangay.Size = New System.Drawing.Size(251, 24)
        Me.txtBoxBarangay.TabIndex = 53
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1394, 626)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBoxBarangay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBoxLot)
        Me.Controls.Add(Me.BackToHomeBtn)
        Me.Controls.Add(Me.txtboxStudentID)
        Me.Controls.Add(Me.submitBtn)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtBoxPostalCode)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtBoxBlock)
        Me.Controls.Add(Me.txtBoxHouseNum)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtBoxCity)
        Me.Controls.Add(Me.txtBoxProvince)
        Me.Controls.Add(Me.txtBoxStreetAddress)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtBoxEmail)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtBoxContactNum)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtBoxAge)
        Me.Controls.Add(Me.dtpBirthdate)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.radioPreferNotToSay)
        Me.Controls.Add(Me.radioMale)
        Me.Controls.Add(Me.radioFemale)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DropDownYearSection)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dropDownSuffix)
        Me.Controls.Add(Me.SuffixLabel)
        Me.Controls.Add(Me.txtBoxMiddleInitial)
        Me.Controls.Add(Me.txtBoxFirstName)
        Me.Controls.Add(Me.txtBoxLastName)
        Me.Controls.Add(Me.DropDownCourse)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MiddleInitialLabel)
        Me.Controls.Add(Me.FirstNameLabel)
        Me.Controls.Add(Me.LastNameLabel)
        Me.Controls.Add(Me.STudentIDLabel)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents STudentIDLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents MiddleInitialLabel As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DropDownCourse As ComboBox
    Friend WithEvents txtBoxLastName As TextBox
    Friend WithEvents txtBoxFirstName As TextBox
    Friend WithEvents txtBoxMiddleInitial As TextBox
    Friend WithEvents SuffixLabel As Label
    Friend WithEvents dropDownSuffix As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DropDownYearSection As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents radioFemale As RadioButton
    Friend WithEvents radioMale As RadioButton
    Friend WithEvents radioPreferNotToSay As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpBirthdate As DateTimePicker
    Friend WithEvents txtBoxAge As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBoxContactNum As TextBox
    Friend WithEvents txtBoxEmail As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtBoxStreetAddress As TextBox
    Friend WithEvents txtBoxProvince As TextBox
    Friend WithEvents txtBoxCity As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents txtBoxBlock As TextBox
    Friend WithEvents txtBoxHouseNum As TextBox
    Friend WithEvents txtBoxPostalCode As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents ClearBtn As Button
    Friend WithEvents submitBtn As Button
    Friend WithEvents txtboxStudentID As TextBox
    Friend WithEvents BackToHomeBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxLot As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBoxBarangay As TextBox
End Class
