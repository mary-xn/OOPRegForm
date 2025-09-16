<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AddNewBtm = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.StudentsGrid = New System.Windows.Forms.DataGridView()
        Me.RefreshBtn = New System.Windows.Forms.Button()
        CType(Me.StudentsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(498, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 50)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "REGISTRATION FORM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddNewBtm
        '
        Me.AddNewBtm.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.AddNewBtm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddNewBtm.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNewBtm.Location = New System.Drawing.Point(1015, 109)
        Me.AddNewBtm.Name = "AddNewBtm"
        Me.AddNewBtm.Size = New System.Drawing.Size(294, 68)
        Me.AddNewBtm.TabIndex = 4
        Me.AddNewBtm.Text = "Add New"
        Me.AddNewBtm.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1389, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.Color.PowderBlue
        Me.UpdateBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdateBtn.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Location = New System.Drawing.Point(1015, 211)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(294, 68)
        Me.UpdateBtn.TabIndex = 7
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.LightCoral
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Location = New System.Drawing.Point(1015, 316)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(294, 68)
        Me.DeleteBtn.TabIndex = 8
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'StudentsGrid
        '
        Me.StudentsGrid.BackgroundColor = System.Drawing.Color.Linen
        Me.StudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentsGrid.Location = New System.Drawing.Point(12, 109)
        Me.StudentsGrid.Name = "StudentsGrid"
        Me.StudentsGrid.RowHeadersWidth = 51
        Me.StudentsGrid.RowTemplate.Height = 24
        Me.StudentsGrid.Size = New System.Drawing.Size(939, 475)
        Me.StudentsGrid.TabIndex = 9
        '
        'RefreshBtn
        '
        Me.RefreshBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RefreshBtn.Font = New System.Drawing.Font("Verdana", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.Location = New System.Drawing.Point(1015, 427)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.Size = New System.Drawing.Size(294, 68)
        Me.RefreshBtn.TabIndex = 10
        Me.RefreshBtn.Text = "Refresh"
        Me.RefreshBtn.UseVisualStyleBackColor = False
        '
        'MainPage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1406, 642)
        Me.Controls.Add(Me.RefreshBtn)
        Me.Controls.Add(Me.StudentsGrid)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AddNewBtm)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainPage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainPage"
        CType(Me.StudentsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents AddNewBtm As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents StudentsGrid As DataGridView
    Friend WithEvents RefreshBtn As Button
End Class
