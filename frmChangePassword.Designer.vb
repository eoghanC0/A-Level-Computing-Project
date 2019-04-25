<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.lblCurrentPassword = New System.Windows.Forms.Label()
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox()
        Me.lblNewPassword = New System.Windows.Forms.Label()
        Me.txtNewPassword = New System.Windows.Forms.TextBox()
        Me.lblRetypedNewPassword = New System.Windows.Forms.Label()
        Me.txtRetypedNewPassword = New System.Windows.Forms.TextBox()
        Me.btnUpdatePassword = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(28, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "User ID"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(220, 52)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(138, 26)
        Me.txtUserID.TabIndex = 5
        '
        'lblCurrentPassword
        '
        Me.lblCurrentPassword.AutoSize = True
        Me.lblCurrentPassword.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblCurrentPassword.ForeColor = System.Drawing.Color.Black
        Me.lblCurrentPassword.Location = New System.Drawing.Point(28, 105)
        Me.lblCurrentPassword.Name = "lblCurrentPassword"
        Me.lblCurrentPassword.Size = New System.Drawing.Size(135, 20)
        Me.lblCurrentPassword.TabIndex = 7
        Me.lblCurrentPassword.Text = "Current Password"
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Location = New System.Drawing.Point(220, 98)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.Size = New System.Drawing.Size(182, 26)
        Me.txtCurrentPassword.TabIndex = 0
        '
        'lblNewPassword
        '
        Me.lblNewPassword.AutoSize = True
        Me.lblNewPassword.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblNewPassword.ForeColor = System.Drawing.Color.Black
        Me.lblNewPassword.Location = New System.Drawing.Point(28, 152)
        Me.lblNewPassword.Name = "lblNewPassword"
        Me.lblNewPassword.Size = New System.Drawing.Size(113, 20)
        Me.lblNewPassword.TabIndex = 8
        Me.lblNewPassword.Text = "New Password"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(220, 148)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.Size = New System.Drawing.Size(182, 26)
        Me.txtNewPassword.TabIndex = 1
        '
        'lblRetypedNewPassword
        '
        Me.lblRetypedNewPassword.AutoSize = True
        Me.lblRetypedNewPassword.BackColor = System.Drawing.Color.LightSkyBlue
        Me.lblRetypedNewPassword.ForeColor = System.Drawing.Color.Black
        Me.lblRetypedNewPassword.Location = New System.Drawing.Point(28, 202)
        Me.lblRetypedNewPassword.Name = "lblRetypedNewPassword"
        Me.lblRetypedNewPassword.Size = New System.Drawing.Size(177, 20)
        Me.lblRetypedNewPassword.TabIndex = 9
        Me.lblRetypedNewPassword.Text = "Retyped New Password"
        '
        'txtRetypedNewPassword
        '
        Me.txtRetypedNewPassword.Location = New System.Drawing.Point(220, 195)
        Me.txtRetypedNewPassword.Name = "txtRetypedNewPassword"
        Me.txtRetypedNewPassword.Size = New System.Drawing.Size(182, 26)
        Me.txtRetypedNewPassword.TabIndex = 2
        '
        'btnUpdatePassword
        '
        Me.btnUpdatePassword.BackColor = System.Drawing.Color.White
        Me.btnUpdatePassword.ForeColor = System.Drawing.Color.Black
        Me.btnUpdatePassword.Location = New System.Drawing.Point(33, 263)
        Me.btnUpdatePassword.Name = "btnUpdatePassword"
        Me.btnUpdatePassword.Size = New System.Drawing.Size(172, 35)
        Me.btnUpdatePassword.TabIndex = 3
        Me.btnUpdatePassword.Text = "Update Password"
        Me.btnUpdatePassword.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.White
        Me.btnCancel.ForeColor = System.Drawing.Color.Black
        Me.btnCancel.Location = New System.Drawing.Point(236, 263)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 35)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(416, 354)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdatePassword)
        Me.Controls.Add(Me.txtRetypedNewPassword)
        Me.Controls.Add(Me.lblRetypedNewPassword)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.lblNewPassword)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Controls.Add(Me.lblCurrentPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmChangePassword"
        Me.Text = "frmChangePassword"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents lblCurrentPassword As System.Windows.Forms.Label
    Friend WithEvents txtCurrentPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblNewPassword As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblRetypedNewPassword As System.Windows.Forms.Label
    Friend WithEvents txtRetypedNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnUpdatePassword As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
