<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion
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
        Me.lbxQuestions = New System.Windows.Forms.ListBox()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.lblDisplayUser = New System.Windows.Forms.Label()
        Me.txtNoOfOutcomes1 = New System.Windows.Forms.TextBox()
        Me.txtNoOfOutcomes2 = New System.Windows.Forms.TextBox()
        Me.txtNoOfOutcomes3 = New System.Windows.Forms.TextBox()
        Me.txtNoOfEvents = New System.Windows.Forms.TextBox()
        Me.lblNoOfEvents = New System.Windows.Forms.Label()
        Me.lblNoOfOutcomes1 = New System.Windows.Forms.Label()
        Me.lblNoOfOutcomes2 = New System.Windows.Forms.Label()
        Me.lblNoOfOutcomes3 = New System.Windows.Forms.Label()
        Me.lblQuestionID = New System.Windows.Forms.Label()
        Me.txtQuestionID = New System.Windows.Forms.TextBox()
        Me.lblUserID = New System.Windows.Forms.Label()
        Me.btnAddNewQuestion = New System.Windows.Forms.Button()
        Me.btnDeleteQuestion = New System.Windows.Forms.Button()
        Me.btnSaveChanges = New System.Windows.Forms.Button()
        Me.btnSaveNewQuestion = New System.Windows.Forms.Button()
        Me.btnCancelChanges = New System.Windows.Forms.Button()
        Me.btnCancelAddQuestion = New System.Windows.Forms.Button()
        Me.btnProduceAnswer = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.Button()
        Me.btnSaveAs = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbxQuestions
        '
        Me.lbxQuestions.FormattingEnabled = True
        Me.lbxQuestions.ItemHeight = 28
        Me.lbxQuestions.Location = New System.Drawing.Point(13, 307)
        Me.lbxQuestions.Margin = New System.Windows.Forms.Padding(4)
        Me.lbxQuestions.Name = "lbxQuestions"
        Me.lbxQuestions.Size = New System.Drawing.Size(208, 424)
        Me.lbxQuestions.TabIndex = 6
        '
        'btnFirst
        '
        Me.btnFirst.BackColor = System.Drawing.Color.White
        Me.btnFirst.Location = New System.Drawing.Point(12, 263)
        Me.btnFirst.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(38, 26)
        Me.btnFirst.TabIndex = 0
        Me.btnFirst.Text = "|<"
        Me.btnFirst.UseVisualStyleBackColor = False
        '
        'btnPrevious
        '
        Me.btnPrevious.BackColor = System.Drawing.Color.White
        Me.btnPrevious.Location = New System.Drawing.Point(69, 263)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(38, 26)
        Me.btnPrevious.TabIndex = 51
        Me.btnPrevious.Text = "<"
        Me.btnPrevious.UseVisualStyleBackColor = False
        '
        'btnNext
        '
        Me.btnNext.BackColor = System.Drawing.Color.White
        Me.btnNext.Location = New System.Drawing.Point(126, 263)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(38, 26)
        Me.btnNext.TabIndex = 52
        Me.btnNext.Text = ">"
        Me.btnNext.UseVisualStyleBackColor = False
        '
        'btnLast
        '
        Me.btnLast.BackColor = System.Drawing.Color.White
        Me.btnLast.Location = New System.Drawing.Point(183, 263)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(38, 26)
        Me.btnLast.TabIndex = 68
        Me.btnLast.Text = ">|"
        Me.btnLast.UseVisualStyleBackColor = False
        '
        'lblDisplayUser
        '
        Me.lblDisplayUser.AutoSize = True
        Me.lblDisplayUser.Location = New System.Drawing.Point(66, 9)
        Me.lblDisplayUser.Name = "lblDisplayUser"
        Me.lblDisplayUser.Size = New System.Drawing.Size(124, 28)
        Me.lblDisplayUser.TabIndex = 69
        Me.lblDisplayUser.Text = "DisplayUser"
        '
        'txtNoOfOutcomes1
        '
        Me.txtNoOfOutcomes1.Location = New System.Drawing.Point(191, 140)
        Me.txtNoOfOutcomes1.Name = "txtNoOfOutcomes1"
        Me.txtNoOfOutcomes1.Size = New System.Drawing.Size(35, 35)
        Me.txtNoOfOutcomes1.TabIndex = 3
        '
        'txtNoOfOutcomes2
        '
        Me.txtNoOfOutcomes2.Location = New System.Drawing.Point(191, 182)
        Me.txtNoOfOutcomes2.Name = "txtNoOfOutcomes2"
        Me.txtNoOfOutcomes2.Size = New System.Drawing.Size(35, 35)
        Me.txtNoOfOutcomes2.TabIndex = 4
        '
        'txtNoOfOutcomes3
        '
        Me.txtNoOfOutcomes3.Location = New System.Drawing.Point(191, 220)
        Me.txtNoOfOutcomes3.Name = "txtNoOfOutcomes3"
        Me.txtNoOfOutcomes3.Size = New System.Drawing.Size(35, 35)
        Me.txtNoOfOutcomes3.TabIndex = 5
        '
        'txtNoOfEvents
        '
        Me.txtNoOfEvents.Location = New System.Drawing.Point(107, 98)
        Me.txtNoOfEvents.Name = "txtNoOfEvents"
        Me.txtNoOfEvents.Size = New System.Drawing.Size(35, 35)
        Me.txtNoOfEvents.TabIndex = 2
        '
        'lblNoOfEvents
        '
        Me.lblNoOfEvents.AutoSize = True
        Me.lblNoOfEvents.Location = New System.Drawing.Point(12, 101)
        Me.lblNoOfEvents.Name = "lblNoOfEvents"
        Me.lblNoOfEvents.Size = New System.Drawing.Size(138, 28)
        Me.lblNoOfEvents.TabIndex = 77
        Me.lblNoOfEvents.Text = "No Of Events"
        '
        'lblNoOfOutcomes1
        '
        Me.lblNoOfOutcomes1.AutoSize = True
        Me.lblNoOfOutcomes1.Location = New System.Drawing.Point(12, 143)
        Me.lblNoOfOutcomes1.Name = "lblNoOfOutcomes1"
        Me.lblNoOfOutcomes1.Size = New System.Drawing.Size(267, 28)
        Me.lblNoOfOutcomes1.TabIndex = 78
        Me.lblNoOfOutcomes1.Text = "No Of Outcomes In Event 1"
        '
        'lblNoOfOutcomes2
        '
        Me.lblNoOfOutcomes2.AutoSize = True
        Me.lblNoOfOutcomes2.Location = New System.Drawing.Point(12, 185)
        Me.lblNoOfOutcomes2.Name = "lblNoOfOutcomes2"
        Me.lblNoOfOutcomes2.Size = New System.Drawing.Size(270, 28)
        Me.lblNoOfOutcomes2.TabIndex = 79
        Me.lblNoOfOutcomes2.Text = "No Of Outcomes In Event 2"
        '
        'lblNoOfOutcomes3
        '
        Me.lblNoOfOutcomes3.AutoSize = True
        Me.lblNoOfOutcomes3.Location = New System.Drawing.Point(12, 223)
        Me.lblNoOfOutcomes3.Name = "lblNoOfOutcomes3"
        Me.lblNoOfOutcomes3.Size = New System.Drawing.Size(270, 28)
        Me.lblNoOfOutcomes3.TabIndex = 80
        Me.lblNoOfOutcomes3.Text = "No Of Outcomes In Event 3"
        '
        'lblQuestionID
        '
        Me.lblQuestionID.AutoSize = True
        Me.lblQuestionID.Location = New System.Drawing.Point(10, 59)
        Me.lblQuestionID.Name = "lblQuestionID"
        Me.lblQuestionID.Size = New System.Drawing.Size(127, 28)
        Me.lblQuestionID.TabIndex = 81
        Me.lblQuestionID.Text = "Question ID"
        '
        'txtQuestionID
        '
        Me.txtQuestionID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtQuestionID.Location = New System.Drawing.Point(98, 56)
        Me.txtQuestionID.Name = "txtQuestionID"
        Me.txtQuestionID.Size = New System.Drawing.Size(139, 35)
        Me.txtQuestionID.TabIndex = 1
        '
        'lblUserID
        '
        Me.lblUserID.AutoSize = True
        Me.lblUserID.Location = New System.Drawing.Point(9, 9)
        Me.lblUserID.Name = "lblUserID"
        Me.lblUserID.Size = New System.Drawing.Size(95, 28)
        Me.lblUserID.TabIndex = 83
        Me.lblUserID.Text = "UserID :"
        '
        'btnAddNewQuestion
        '
        Me.btnAddNewQuestion.BackColor = System.Drawing.Color.White
        Me.btnAddNewQuestion.Location = New System.Drawing.Point(1006, 95)
        Me.btnAddNewQuestion.Name = "btnAddNewQuestion"
        Me.btnAddNewQuestion.Size = New System.Drawing.Size(165, 30)
        Me.btnAddNewQuestion.TabIndex = 84
        Me.btnAddNewQuestion.Text = "Add New Question"
        Me.btnAddNewQuestion.UseVisualStyleBackColor = False
        '
        'btnDeleteQuestion
        '
        Me.btnDeleteQuestion.BackColor = System.Drawing.Color.White
        Me.btnDeleteQuestion.Location = New System.Drawing.Point(1006, 51)
        Me.btnDeleteQuestion.Name = "btnDeleteQuestion"
        Me.btnDeleteQuestion.Size = New System.Drawing.Size(165, 30)
        Me.btnDeleteQuestion.TabIndex = 85
        Me.btnDeleteQuestion.Text = "Delete Question"
        Me.btnDeleteQuestion.UseVisualStyleBackColor = False
        '
        'btnSaveChanges
        '
        Me.btnSaveChanges.BackColor = System.Drawing.Color.White
        Me.btnSaveChanges.Location = New System.Drawing.Point(1006, 224)
        Me.btnSaveChanges.Name = "btnSaveChanges"
        Me.btnSaveChanges.Size = New System.Drawing.Size(165, 34)
        Me.btnSaveChanges.TabIndex = 86
        Me.btnSaveChanges.Text = "Save Changes"
        Me.btnSaveChanges.UseVisualStyleBackColor = False
        '
        'btnSaveNewQuestion
        '
        Me.btnSaveNewQuestion.BackColor = System.Drawing.Color.White
        Me.btnSaveNewQuestion.Location = New System.Drawing.Point(1006, 182)
        Me.btnSaveNewQuestion.Name = "btnSaveNewQuestion"
        Me.btnSaveNewQuestion.Size = New System.Drawing.Size(165, 30)
        Me.btnSaveNewQuestion.TabIndex = 87
        Me.btnSaveNewQuestion.Text = "Save New Question"
        Me.btnSaveNewQuestion.UseVisualStyleBackColor = False
        '
        'btnCancelChanges
        '
        Me.btnCancelChanges.BackColor = System.Drawing.Color.White
        Me.btnCancelChanges.Location = New System.Drawing.Point(1006, 264)
        Me.btnCancelChanges.Name = "btnCancelChanges"
        Me.btnCancelChanges.Size = New System.Drawing.Size(165, 30)
        Me.btnCancelChanges.TabIndex = 88
        Me.btnCancelChanges.Text = "Cancel Changes"
        Me.btnCancelChanges.UseVisualStyleBackColor = False
        '
        'btnCancelAddQuestion
        '
        Me.btnCancelAddQuestion.BackColor = System.Drawing.Color.White
        Me.btnCancelAddQuestion.Location = New System.Drawing.Point(1006, 137)
        Me.btnCancelAddQuestion.Name = "btnCancelAddQuestion"
        Me.btnCancelAddQuestion.Size = New System.Drawing.Size(165, 33)
        Me.btnCancelAddQuestion.TabIndex = 89
        Me.btnCancelAddQuestion.Text = "Cancel Add Question"
        Me.btnCancelAddQuestion.UseVisualStyleBackColor = False
        '
        'btnProduceAnswer
        '
        Me.btnProduceAnswer.BackColor = System.Drawing.Color.White
        Me.btnProduceAnswer.Location = New System.Drawing.Point(1006, 302)
        Me.btnProduceAnswer.Name = "btnProduceAnswer"
        Me.btnProduceAnswer.Size = New System.Drawing.Size(165, 30)
        Me.btnProduceAnswer.TabIndex = 90
        Me.btnProduceAnswer.Text = "Produce Answer"
        Me.btnProduceAnswer.UseVisualStyleBackColor = False
        '
        'btnMenu
        '
        Me.btnMenu.BackColor = System.Drawing.Color.White
        Me.btnMenu.Location = New System.Drawing.Point(1006, 12)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(165, 30)
        Me.btnMenu.TabIndex = 91
        Me.btnMenu.Text = "Menu"
        Me.btnMenu.UseVisualStyleBackColor = False
        '
        'btnSaveAs
        '
        Me.btnSaveAs.BackColor = System.Drawing.Color.White
        Me.btnSaveAs.Location = New System.Drawing.Point(1006, 338)
        Me.btnSaveAs.Name = "btnSaveAs"
        Me.btnSaveAs.Size = New System.Drawing.Size(165, 30)
        Me.btnSaveAs.TabIndex = 92
        Me.btnSaveAs.Text = "Save As"
        Me.btnSaveAs.UseVisualStyleBackColor = False
        '
        'frmQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSkyBlue
        Me.ClientSize = New System.Drawing.Size(1182, 773)
        Me.Controls.Add(Me.btnSaveAs)
        Me.Controls.Add(Me.btnMenu)
        Me.Controls.Add(Me.btnProduceAnswer)
        Me.Controls.Add(Me.btnCancelAddQuestion)
        Me.Controls.Add(Me.btnCancelChanges)
        Me.Controls.Add(Me.btnSaveNewQuestion)
        Me.Controls.Add(Me.btnSaveChanges)
        Me.Controls.Add(Me.btnDeleteQuestion)
        Me.Controls.Add(Me.btnAddNewQuestion)
        Me.Controls.Add(Me.lblUserID)
        Me.Controls.Add(Me.txtQuestionID)
        Me.Controls.Add(Me.lblQuestionID)
        Me.Controls.Add(Me.lblNoOfOutcomes3)
        Me.Controls.Add(Me.lblNoOfOutcomes2)
        Me.Controls.Add(Me.lblNoOfOutcomes1)
        Me.Controls.Add(Me.lblNoOfEvents)
        Me.Controls.Add(Me.txtNoOfEvents)
        Me.Controls.Add(Me.txtNoOfOutcomes3)
        Me.Controls.Add(Me.txtNoOfOutcomes2)
        Me.Controls.Add(Me.txtNoOfOutcomes1)
        Me.Controls.Add(Me.lblDisplayUser)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.lbxQuestions)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmQuestion"
        Me.Text = "frmQuestion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbxQuestions As System.Windows.Forms.ListBox
    Friend WithEvents btnFirst As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents btnLast As System.Windows.Forms.Button
    Friend WithEvents lblDisplayUser As System.Windows.Forms.Label
    Friend WithEvents txtNoOfOutcomes1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNoOfOutcomes2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNoOfOutcomes3 As System.Windows.Forms.TextBox
    Friend WithEvents txtNoOfEvents As System.Windows.Forms.TextBox
    Friend WithEvents lblNoOfEvents As System.Windows.Forms.Label
    Friend WithEvents lblNoOfOutcomes1 As System.Windows.Forms.Label
    Friend WithEvents lblNoOfOutcomes2 As System.Windows.Forms.Label
    Friend WithEvents lblNoOfOutcomes3 As System.Windows.Forms.Label
    Friend WithEvents lblQuestionID As System.Windows.Forms.Label
    Friend WithEvents txtQuestionID As System.Windows.Forms.TextBox
    Friend WithEvents lblUserID As System.Windows.Forms.Label
    Friend WithEvents btnAddNewQuestion As System.Windows.Forms.Button
    Friend WithEvents btnDeleteQuestion As System.Windows.Forms.Button
    Friend WithEvents btnSaveChanges As System.Windows.Forms.Button
    Friend WithEvents btnSaveNewQuestion As System.Windows.Forms.Button
    Friend WithEvents btnCancelChanges As System.Windows.Forms.Button
    Friend WithEvents btnCancelAddQuestion As System.Windows.Forms.Button
    Friend WithEvents btnProduceAnswer As System.Windows.Forms.Button
    Friend WithEvents btnMenu As System.Windows.Forms.Button
    Friend WithEvents btnSaveAs As System.Windows.Forms.Button
End Class
