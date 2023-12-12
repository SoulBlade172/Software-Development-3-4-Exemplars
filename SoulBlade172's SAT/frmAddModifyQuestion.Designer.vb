<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddModifyQuestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddModifyQuestion))
        Me.lblQuestionField = New System.Windows.Forms.Label()
        Me.txtQuestionField = New System.Windows.Forms.TextBox()
        Me.lblAnswerField = New System.Windows.Forms.Label()
        Me.txtAnswerField = New System.Windows.Forms.TextBox()
        Me.lblNameField = New System.Windows.Forms.Label()
        Me.txtNameField = New System.Windows.Forms.TextBox()
        Me.lblQuestionType = New System.Windows.Forms.Label()
        Me.cbxQuestionType = New System.Windows.Forms.ComboBox()
        Me.lblTag = New System.Windows.Forms.Label()
        Me.cbxTag = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtAnswerField2 = New System.Windows.Forms.TextBox()
        Me.txtAnswerField3 = New System.Windows.Forms.TextBox()
        Me.txtAnswerField4 = New System.Windows.Forms.TextBox()
        Me.lblCorrectAnswer = New System.Windows.Forms.Label()
        Me.txtCorrectAnswerField = New System.Windows.Forms.TextBox()
        Me.btnAddTag = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQuestionField
        '
        Me.lblQuestionField.AutoSize = True
        Me.lblQuestionField.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionField.Location = New System.Drawing.Point(13, 13)
        Me.lblQuestionField.Name = "lblQuestionField"
        Me.lblQuestionField.Size = New System.Drawing.Size(59, 16)
        Me.lblQuestionField.TabIndex = 0
        Me.lblQuestionField.Text = "Question"
        '
        'txtQuestionField
        '
        Me.txtQuestionField.Location = New System.Drawing.Point(13, 33)
        Me.txtQuestionField.Name = "txtQuestionField"
        Me.txtQuestionField.Size = New System.Drawing.Size(263, 20)
        Me.txtQuestionField.TabIndex = 1
        '
        'lblAnswerField
        '
        Me.lblAnswerField.AutoSize = True
        Me.lblAnswerField.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswerField.Location = New System.Drawing.Point(13, 68)
        Me.lblAnswerField.Name = "lblAnswerField"
        Me.lblAnswerField.Size = New System.Drawing.Size(50, 16)
        Me.lblAnswerField.TabIndex = 2
        Me.lblAnswerField.Text = "Answer"
        '
        'txtAnswerField
        '
        Me.txtAnswerField.Location = New System.Drawing.Point(12, 87)
        Me.txtAnswerField.Name = "txtAnswerField"
        Me.txtAnswerField.Size = New System.Drawing.Size(263, 20)
        Me.txtAnswerField.TabIndex = 3
        '
        'lblNameField
        '
        Me.lblNameField.AutoSize = True
        Me.lblNameField.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameField.Location = New System.Drawing.Point(13, 239)
        Me.lblNameField.Name = "lblNameField"
        Me.lblNameField.Size = New System.Drawing.Size(41, 16)
        Me.lblNameField.TabIndex = 4
        Me.lblNameField.Text = "Name"
        '
        'txtNameField
        '
        Me.txtNameField.Location = New System.Drawing.Point(12, 258)
        Me.txtNameField.Name = "txtNameField"
        Me.txtNameField.Size = New System.Drawing.Size(263, 20)
        Me.txtNameField.TabIndex = 5
        '
        'lblQuestionType
        '
        Me.lblQuestionType.AutoSize = True
        Me.lblQuestionType.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionType.Location = New System.Drawing.Point(287, 9)
        Me.lblQuestionType.Name = "lblQuestionType"
        Me.lblQuestionType.Size = New System.Drawing.Size(88, 16)
        Me.lblQuestionType.TabIndex = 6
        Me.lblQuestionType.Text = "Question type"
        '
        'cbxQuestionType
        '
        Me.cbxQuestionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxQuestionType.FormattingEnabled = True
        Me.cbxQuestionType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cbxQuestionType.Items.AddRange(New Object() {"Short answer", "Multiple choice"})
        Me.cbxQuestionType.Location = New System.Drawing.Point(290, 31)
        Me.cbxQuestionType.Name = "cbxQuestionType"
        Me.cbxQuestionType.Size = New System.Drawing.Size(85, 21)
        Me.cbxQuestionType.TabIndex = 7
        '
        'lblTag
        '
        Me.lblTag.AutoSize = True
        Me.lblTag.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTag.Location = New System.Drawing.Point(316, 68)
        Me.lblTag.Name = "lblTag"
        Me.lblTag.Size = New System.Drawing.Size(27, 16)
        Me.lblTag.TabIndex = 8
        Me.lblTag.Text = "Tag"
        '
        'cbxTag
        '
        Me.cbxTag.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTag.FormattingEnabled = True
        Me.cbxTag.Location = New System.Drawing.Point(290, 87)
        Me.cbxTag.Name = "cbxTag"
        Me.cbxTag.Size = New System.Drawing.Size(85, 21)
        Me.cbxTag.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(293, 165)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtAnswerField2
        '
        Me.txtAnswerField2.Location = New System.Drawing.Point(12, 113)
        Me.txtAnswerField2.Name = "txtAnswerField2"
        Me.txtAnswerField2.Size = New System.Drawing.Size(263, 20)
        Me.txtAnswerField2.TabIndex = 11
        Me.txtAnswerField2.Visible = False
        '
        'txtAnswerField3
        '
        Me.txtAnswerField3.Location = New System.Drawing.Point(12, 139)
        Me.txtAnswerField3.Name = "txtAnswerField3"
        Me.txtAnswerField3.Size = New System.Drawing.Size(263, 20)
        Me.txtAnswerField3.TabIndex = 12
        Me.txtAnswerField3.Visible = False
        '
        'txtAnswerField4
        '
        Me.txtAnswerField4.Location = New System.Drawing.Point(12, 165)
        Me.txtAnswerField4.Name = "txtAnswerField4"
        Me.txtAnswerField4.Size = New System.Drawing.Size(263, 20)
        Me.txtAnswerField4.TabIndex = 13
        Me.txtAnswerField4.Visible = False
        '
        'lblCorrectAnswer
        '
        Me.lblCorrectAnswer.AutoSize = True
        Me.lblCorrectAnswer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorrectAnswer.Location = New System.Drawing.Point(10, 188)
        Me.lblCorrectAnswer.Name = "lblCorrectAnswer"
        Me.lblCorrectAnswer.Size = New System.Drawing.Size(95, 16)
        Me.lblCorrectAnswer.TabIndex = 14
        Me.lblCorrectAnswer.Text = "Correct Answer"
        Me.lblCorrectAnswer.Visible = False
        '
        'txtCorrectAnswerField
        '
        Me.txtCorrectAnswerField.Location = New System.Drawing.Point(12, 207)
        Me.txtCorrectAnswerField.Name = "txtCorrectAnswerField"
        Me.txtCorrectAnswerField.Size = New System.Drawing.Size(263, 20)
        Me.txtCorrectAnswerField.TabIndex = 15
        Me.txtCorrectAnswerField.Visible = False
        '
        'btnAddTag
        '
        Me.btnAddTag.Location = New System.Drawing.Point(293, 128)
        Me.btnAddTag.Name = "btnAddTag"
        Me.btnAddTag.Size = New System.Drawing.Size(75, 23)
        Me.btnAddTag.TabIndex = 16
        Me.btnAddTag.Text = "Add tag"
        Me.btnAddTag.UseVisualStyleBackColor = True
        '
        'frmAddModifyQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(387, 290)
        Me.Controls.Add(Me.btnAddTag)
        Me.Controls.Add(Me.txtCorrectAnswerField)
        Me.Controls.Add(Me.lblCorrectAnswer)
        Me.Controls.Add(Me.txtAnswerField4)
        Me.Controls.Add(Me.txtAnswerField3)
        Me.Controls.Add(Me.txtAnswerField2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbxTag)
        Me.Controls.Add(Me.lblTag)
        Me.Controls.Add(Me.cbxQuestionType)
        Me.Controls.Add(Me.lblQuestionType)
        Me.Controls.Add(Me.txtNameField)
        Me.Controls.Add(Me.lblNameField)
        Me.Controls.Add(Me.txtAnswerField)
        Me.Controls.Add(Me.lblAnswerField)
        Me.Controls.Add(Me.txtQuestionField)
        Me.Controls.Add(Me.lblQuestionField)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAddModifyQuestion"
        Me.Text = "Edit question"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestionField As Label
    Friend WithEvents txtQuestionField As TextBox
    Friend WithEvents lblAnswerField As Label
    Friend WithEvents txtAnswerField As TextBox
    Friend WithEvents lblNameField As Label
    Friend WithEvents txtNameField As TextBox
    Friend WithEvents lblQuestionType As Label
    Friend WithEvents cbxQuestionType As ComboBox
    Friend WithEvents lblTag As Label
    Friend WithEvents cbxTag As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents txtAnswerField2 As TextBox
    Friend WithEvents txtAnswerField3 As TextBox
    Friend WithEvents txtAnswerField4 As TextBox
    Friend WithEvents lblCorrectAnswer As Label
    Friend WithEvents txtCorrectAnswerField As TextBox
    Friend WithEvents btnAddTag As Button
End Class
