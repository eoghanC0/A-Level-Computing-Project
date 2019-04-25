<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserRecords
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
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblFormClassTitle = New System.Windows.Forms.Label()
        Me.txtFormClassTitle = New System.Windows.Forms.TextBox()
        Me.lbxRequiredUser = New System.Windows.Forms.ListBox()
        Me.btnAddNewUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnSaveNewRecord = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnCancelChanges = New System.Windows.Forms.Button()
        Me.btnCancelAddRecord = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblRetypedNewPassword = New System.Windows.Forms.Label()
        Me.txtRetypedNewPassword = New System.Windows.Forms.TextBox()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.ForeColor = System.Drawing.Color.Black
        Me.lblUserID.Location = New System.Drawing.Point(188, 26)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(70, 22)
        Me.lblUserID.TabIndex = 17
        Me.lblUserID.Text = "User ID"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(388, 23)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(137, 29)
        Me.txtUserID.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.ForeColor = System.Drawing.Color.Black
        Me.lblFirstName.Location = New System.Drawing.Point(188, 70)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(94, 22)
        Me.lblFirstName.TabIndex = 18
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(388, 67)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(119, 29)
        Me.txtFirstName.TabIndex = 1
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.ForeColor = System.Drawing.Color.Black
        Me.lblSurname.Location = New System.Drawing.Point(188, 120)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(79, 22)
        Me.lblSurname.TabIndex = 19
        Me.lblSurname.Text = "Surname"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(388, 117)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(118, 29)
        Me.txtSurname.TabIndex = 2
        '
        'lblFormClassTitle
        '
        Me.lblFormClassTitle.AutoSize = True
        Me.lblFormClassTitle.ForeColor = System.Drawing.Color.Black
        Me.lblFormClassTitle.Location = New System.Drawing.Point(188, 173)
        Me.lblFormClassTitle.Name = "lblFormClassTitle"
        Me.lblFormClassTitle.Size = New System.Drawing.Size(149, 22)
        Me.lblFormClassTitle.TabIndex = 20
        Me.lblFormClassTitle.Text = "Form Class / Title"
        '
        'txtFormClassTitle
        '
        Me.txtFormClassTitle.Location = New System.Drawing.Point(388, 166)
        Me.txtFormClassTitle.Name = "txtFormClassTitle"
        Me.txtFormClassTitle.Size = New System.Drawing.Size(42, 29)
        Me.txtFormClassTitle.TabIndex = 3
        '
        'lbxRequiredUser
        '
        Me.lbxRequiredUser.FormattingEnabled = True
        Me.lbxRequiredUser.ItemHeight = 22
        Me.lbxRequiredUser.Location = New System.Drawing.Point(12, 9)
        Me.lbxRequiredUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lbxRequiredUser.Name = "lbxRequiredUser"
        Me.lbxRequiredUser.Size = New System.Drawing.Size(170, 356)
        Me.lbxRequiredUser.TabIndex = 16
        '
        'btnAddNewUser
        '
        Me.btnAddNewUser.BackColor = System.Drawing.Color.White
        Me.btnAddNewUser.ForeColor = System.Drawing.Color.Black
        Me.btnAddNewUser.Location = New System.Drawing.Point(552, 19)
        Me.btnAddNewUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAddNewUser.Name = "btnAddNewUser"
        Me.btnAddNewUser.Size = New System.Drawing.Size(158, 33)
        Me.btnAddNewUser.TabIndex = 10
        Me.btnAddNewUser.Text = "Add New User"
        Me.btnAddNewUser.UseVisualStyleBackColor = False
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.BackColor = System.Drawing.Color.White
        Me.btnDeleteUser.ForeColor = System.Drawing.Color.Black
        Me.btnDeleteUser.Location = New System.Drawing.Point(552, 63)
        Me.btnDeleteUser.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(158, 33)
        Me.btnDeleteUser.TabIndex = 11
        Me.btnDeleteUser.Text = "Delete User"
        Me.btnDeleteUser.UseVisualStyleBackColor = False
        '
        'btnSaveNewRecord
        '
        Me.btnSaveNewRecord.BackColor = System.Drawing.Color.White
        Me.btnSaveNewRecord.ForeColor = System.Drawing.Color.Black
        Me.btnSaveNewRecord.Location = New System.Drawing.Point(552, 219)
        Me.btnSaveNewRecord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveNewRecord.Name = "btnSaveNewRecord"
        Me.btnSaveNewRecord.Size = New System.Drawing.Size(158, 33)
        Me.btnSaveNewRecord.TabIndex = 14
        Me.btnSaveNewRecord.Text = "Save New Record"
        Me.btnSaveNewRecord.UseVisualStyleBackColor = False
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.BackColor = System.Drawing.Color.White
        Me.btnSaveChanges.ForeColor = System.Drawing.Color.Black
        Me.btnSaveChanges.Location = New System.Drawing.Point(552, 162)
        Me.btnSaveChanges.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(158, 33)
        Me.btnSaveChanges.TabIndex = 13
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = False
        '
        'btnCancelChanges
        '
        Me.btnCancelChanges.BackColor = System.Drawing.Color.White
        Me.btnCancelChanges.ForeColor = System.Drawing.Color.Black
        Me.btnCancelChanges.Location = New System.Drawing.Point(552, 113)
        Me.btnCancelChanges.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelChanges.Name = "btnCancelChanges"
        Me.btnCancelChanges.Size = New System.Drawing.Size(158, 33)
        Me.btnCancelChanges.TabIndex = 12
        Me.btnCancelChanges.Text = "Cancel Changes"
        Me.btnCancelChanges.UseVisualStyleBackColor = False
        '
        'btnCancelAddRecord
        '
        Me.btnCancelAddRecord.BackColor = System.Drawing.Color.White
        Me.btnCancelAddRecord.ForeColor = System.Drawing.Color.Black
        Me.btnCancelAddRecord.Location = New System.Drawing.Point(552, 267)
        Me.btnCancelAddRecord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnCancelAddRecord.Name = "btnCancelAddRecord"
        Me.btnCancelAddRecord.Size = New System.Drawing.Size(167, 33)
        Me.btnCancelAddRecord.TabIndex = 15
        Me.btnCancelAddRecord.Text = "Cancel Add Record"
        Me.btnCancelAddRecord.UseVisualStyleBackColor = False
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.White
        Me.btnFirst.ForeColor = System.Drawing.Color.Black
        Me.btnFirst.Location = New System.Drawing.Point(191, 326)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(51, 31)
        Me.btnFirst.TabIndex = 6
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.White
        Me.btnPrevious.ForeColor = System.Drawing.Color.Black
        Me.btnPrevious.Location = New System.Drawing.Point(286, 326)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(51, 31)
        Me.btnPrevious.TabIndex = 7
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.ForeColor = System.Drawing.Color.Black
        Me.btnNext.Location = New System.Drawing.Point(388, 326)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(51, 31)
        Me.btnNext.TabIndex = 8
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.White
        Me.btnLast.ForeColor = System.Drawing.Color.Black
        Me.btnLast.Location = New System.Drawing.Point(479, 326)
        Me.btnLast.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(51, 31)
        Me.btnLast.TabIndex = 9
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Location = New System.Drawing.Point(188, 226)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(84, 22)
        Me.lblPassword.TabIndex = 21
        Me.lblPassword.Text = "Password"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(388, 223)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(118, 29)
        Me.txtPassword.TabIndex = 4
        '
        'lblRetypedNewPassword
        '
        Me.lblRetypedNewPassword.AutoSize = True
        Me.lblRetypedNewPassword.ForeColor = System.Drawing.Color.Black
        Me.lblRetypedNewPassword.Location = New System.Drawing.Point(188, 274)
        Me.lblRetypedNewPassword.Name = "lblRetypedNewPassword"
        Me.lblRetypedNewPassword.Size = New System.Drawing.Size(194, 22)
        Me.lblRetypedNewPassword.TabIndex = 22
        Me.lblRetypedNewPassword.Text = "Retyped New Password"
        '
        'txtRetypedNewPassword
        '
        Me.txtRetypedNewPassword.Location = New System.Drawing.Point(388, 271)
        Me.txtRetypedNewPassword.Name = "txtRetypedNewPassword"
        Me.txtRetypedNewPassword.Size = New System.Drawing.Size(119, 29)
        Me.txtRetypedNewPassword.TabIndex = 5
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.White
        Me.btnMenu.ForeColor = System.Drawing.Color.Black
        Me.btnMenu.Location = New System.Drawing.Point(552, 324)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(167, 33)
        Me.btnMenu.TabIndex = 23
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'frmUserRecords
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(724, 378)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.txtRetypedNewPassword)
        Me.Controls.Add(Me.lblRetypedNewPassword)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnCancelAddRecord)
        Me.Controls.Add(Me.btnCancelChanges)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.btnSaveNewRecord)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnAddNewUser)
        Me.Controls.Add(Me.lbxRequiredUser)
        Me.Controls.Add(Me.txtFormClassTitle)
        Me.Controls.Add(Me.lblFormClassTitle)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblUserID)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmUserRecords"
        Me.Text = "User Records"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblSurname As System.Windows.Forms.Label
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents lblFormClassTitle As System.Windows.Forms.Label
    Friend WithEvents txtFormClassTitle As System.Windows.Forms.TextBox
    Friend WithEvents lbxRequiredUser As System.Windows.Forms.ListBox
    Friend WithEvents btnAddNewUser As System.Windows.Forms.Button
    Friend WithEvents btnDeleteUser As System.Windows.Forms.Button
    Friend WithEvents btnSaveNewRecord As System.Windows.Forms.Button
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents btnCancelChanges As System.Windows.Forms.Button
    Friend WithEvents btnCancelAddRecord As System.Windows.Forms.Button
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblRetypedNewPassword As System.Windows.Forms.Label
    Friend WithEvents txtRetypedNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnMenu As System.Windows.Forms.Button
End Class
