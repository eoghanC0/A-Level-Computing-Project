Imports System.Text.RegularExpressions
Module DefineGlobalObjects
    Public DBConnection As New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=F:\ProbabilityTrees\ProbabilityTreeDB.mdf;Integrated Security=True")
    Public UserType As String
    Public UserIDString As String
    Public UpdatePasswordEnabled As Boolean
    Public G As Graphics

    'Create a Public Sub ValidatePassword as this procedure is used in both frmChangePassword and frmUser
    Public Sub ValidatePassword(sender As Object, txtRetypedNewPassword As Object) 'Use three REGULAR EXPRESSIONS to check if the NewPassword contains the correct mix of characters
        Dim LowerCaseLetterIncluded As New Regex("[a-z]")
        Dim UpperCaseLetterIncluded As New Regex("[A-Z]")
        Dim NonAlphabeticCharacterIncluded As New Regex("[^a-zA-Z]")

        'Clear txtRetypedNewPassword incase the user has changed txtNewPassword after typing both the NewPassword and RetypedNewPassword
        txtRetypedNewPassword.Clear()
        txtRetypedNewPassword.Enabled = False 'The User is not allowed to key in the RetypedPassword until they have keyed in a valid NewPassword
        UpdatePasswordEnabled = False 'Set UpdatePasswordEnabled to false so user cannot update password or save record incase the user has changed txtNewPassword after typing both the NewPassword and RetypedNewPassword

        'Perform a LENGTH CHECK on the NewPassword, ie. check that it is at least 6 characters long
        If sender.Text.Length < 6 Then
            MessageBox.Show("This password is too short," & vbNewLine & "please enter a password that contains at least 6 characters.", "New Password Too Short", MessageBoxButtons.OK, MessageBoxIcon.Error)
            sender.Text = ""
            sender.Focus()
        Else
            'Use 3 REGULAR EXPRESSIONS to check that the NewPassword contains at least one lowercase letter, one uppercase letter and one non alphabetic character
            If LowerCaseLetterIncluded.IsMatch(sender.Text) And UpperCaseLetterIncluded.IsMatch(sender.Text) And NonAlphabeticCharacterIncluded.IsMatch(sender.Text) Then
                'NewPassword is strong, ie. it contains contains at least one Lowercase letter, one Uppercase letter and one non alphabetic character
                txtRetypedNewPassword.Enabled = True
                txtRetypedNewPassword.Focus()
            Else
                'NewPassword is long enough but it not strong
                MessageBox.Show("This password is too simple, it must include at least 1 lowercase letter," & vbNewLine & "at least one uppercase letter and at least one non alphabetic character," & vbNewLine & "eg. a digit or some other symbol.", "New Password Too Simple", MessageBoxButtons.OK, MessageBoxIcon.Error)
                sender.Text = "" 'Clear txtNewPassword so that the User can enter a different NewPassword
                sender.Focus()
            End If
        End If
    End Sub

    'Create a Public Sub ValidateRetypedPassword as this procedure is used in both frmChangePassword and frmUser
    Public Sub ValidateRetypedPassword(sender As Object, TxtNewPassword As Object)
        'Check that the NewPassword and the RetypedNewPassword are the same
        If sender.Text = TxtNewPassword.Text Then
            'The NewPassword and the RetypedNewPassword are the same
            UpdatePasswordEnabled = True 'Allow the User to save the NewPassword to tblUser
        Else
            'Display an error message telling the User that the NewPassword and the RetypedNewPassword are different
            MessageBox.Show("The Re-typed Password is not the same as your New Password, please try again.", "Passwords Different", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Force the user to go back and enter both the NewPassword and RetypedNewPassword again
            TxtNewPassword.Text = ""
            sender.Text = ""
            sender.enabled = False
            TxtNewPassword.Focus()
        End If
    End Sub
End Module

