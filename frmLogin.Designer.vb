<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lbltitle = New System.Windows.Forms.Label()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnEditRecords = New System.Windows.Forms.Button()
        Me.btnChangePassword = New System.Windows.Forms.Button()
        Me.btnEditQuestions = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.ForeColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.btnLogin, "btnLogin")
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'lblUserID
        '
        resources.ApplyResources(Me.lblUserID, "lblUserID")
        Me.lblUserID.ForeColor = System.Drawing.Color.Black
        Me.lblUserID.Name = "lblUserID"
        '
        'lblPassword
        '
        resources.ApplyResources(Me.lblPassword, "lblPassword")
        Me.lblPassword.ForeColor = System.Drawing.Color.Black
        Me.lblPassword.Name = "lblPassword"
        '
        'txtUserID
        '
        resources.ApplyResources(Me.txtUserID, "txtUserID")
        Me.txtUserID.Name = "txtUserID"
        '
        'txtPassword
        '
        resources.ApplyResources(Me.txtPassword, "txtPassword")
        Me.txtPassword.Name = "txtPassword"
        '
        'lbltitle
        '
        resources.ApplyResources(Me.lbltitle, "lbltitle")
        Me.lbltitle.ForeColor = System.Drawing.Color.Black
        Me.lbltitle.Name = "lbltitle"
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnLogout, "btnLogout")
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnEditRecords
        '
        Me.btnEditRecords.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnEditRecords, "btnEditRecords")
        Me.btnEditRecords.Name = "btnEditRecords"
        Me.btnEditRecords.UseVisualStyleBackColor = False
        '
        'btnChangePassword
        '
        Me.btnChangePassword.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnChangePassword, "btnChangePassword")
        Me.btnChangePassword.Name = "btnChangePassword"
        Me.btnChangePassword.UseVisualStyleBackColor = False
        '
        'btnEditQuestions
        '
        Me.btnEditQuestions.BackColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnEditQuestions, "btnEditQuestions")
        Me.btnEditQuestions.Name = "btnEditQuestions"
        Me.btnEditQuestions.UseVisualStyleBackColor = False
        '
        'frmLogin
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Controls.Add(Me.btnEditQuestions)
        Me.Controls.Add(Me.btnChangePassword)
        Me.Controls.Add(Me.btnEditRecords)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.lbltitle)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.btnLogin)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lbltitle As System.Windows.Forms.Label
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnEditRecords As System.Windows.Forms.Button
    Friend WithEvents btnChangePassword As System.Windows.Forms.Button
    Friend WithEvents btnEditQuestions As System.Windows.Forms.Button

End Class
