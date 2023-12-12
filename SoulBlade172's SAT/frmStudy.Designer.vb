<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStudy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStudy))
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtAnswer = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.grpMultiChoice = New System.Windows.Forms.GroupBox()
        Me.optMulti4 = New System.Windows.Forms.RadioButton()
        Me.optMulti3 = New System.Windows.Forms.RadioButton()
        Me.optMulti2 = New System.Windows.Forms.RadioButton()
        Me.optMulti1 = New System.Windows.Forms.RadioButton()
        Me.btnEnd = New System.Windows.Forms.Button()
        Me.grpMultiChoice.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.AutoSize = True
        Me.lblQuestion.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(144, 9)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(59, 16)
        Me.lblQuestion.TabIndex = 0
        Me.lblQuestion.Text = "Question"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAnswer
        '
        Me.lblAnswer.AutoSize = True
        Me.lblAnswer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(13, 65)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(54, 16)
        Me.lblAnswer.TabIndex = 1
        Me.lblAnswer.Text = "Answer:"
        '
        'txtAnswer
        '
        Me.txtAnswer.Location = New System.Drawing.Point(73, 64)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(264, 20)
        Me.txtAnswer.TabIndex = 2
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(97, 152)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmit.TabIndex = 3
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'grpMultiChoice
        '
        Me.grpMultiChoice.Controls.Add(Me.optMulti4)
        Me.grpMultiChoice.Controls.Add(Me.optMulti3)
        Me.grpMultiChoice.Controls.Add(Me.optMulti2)
        Me.grpMultiChoice.Controls.Add(Me.optMulti1)
        Me.grpMultiChoice.Location = New System.Drawing.Point(73, 57)
        Me.grpMultiChoice.Name = "grpMultiChoice"
        Me.grpMultiChoice.Size = New System.Drawing.Size(239, 89)
        Me.grpMultiChoice.TabIndex = 4
        Me.grpMultiChoice.TabStop = False
        Me.grpMultiChoice.Visible = False
        '
        'optMulti4
        '
        Me.optMulti4.AutoSize = True
        Me.optMulti4.Location = New System.Drawing.Point(6, 62)
        Me.optMulti4.Name = "optMulti4"
        Me.optMulti4.Size = New System.Drawing.Size(53, 17)
        Me.optMulti4.TabIndex = 3
        Me.optMulti4.TabStop = True
        Me.optMulti4.Text = "Multi4"
        Me.optMulti4.UseVisualStyleBackColor = True
        Me.optMulti4.Visible = False
        '
        'optMulti3
        '
        Me.optMulti3.AutoSize = True
        Me.optMulti3.Location = New System.Drawing.Point(6, 43)
        Me.optMulti3.Name = "optMulti3"
        Me.optMulti3.Size = New System.Drawing.Size(53, 17)
        Me.optMulti3.TabIndex = 2
        Me.optMulti3.TabStop = True
        Me.optMulti3.Text = "Multi3"
        Me.optMulti3.UseVisualStyleBackColor = True
        '
        'optMulti2
        '
        Me.optMulti2.AutoSize = True
        Me.optMulti2.Location = New System.Drawing.Point(6, 25)
        Me.optMulti2.Name = "optMulti2"
        Me.optMulti2.Size = New System.Drawing.Size(53, 17)
        Me.optMulti2.TabIndex = 1
        Me.optMulti2.TabStop = True
        Me.optMulti2.Text = "Multi2"
        Me.optMulti2.UseVisualStyleBackColor = True
        Me.optMulti2.Visible = False
        '
        'optMulti1
        '
        Me.optMulti1.AutoSize = True
        Me.optMulti1.Location = New System.Drawing.Point(6, 7)
        Me.optMulti1.Name = "optMulti1"
        Me.optMulti1.Size = New System.Drawing.Size(53, 17)
        Me.optMulti1.TabIndex = 0
        Me.optMulti1.TabStop = True
        Me.optMulti1.Text = "Multi1"
        Me.optMulti1.UseVisualStyleBackColor = True
        Me.optMulti1.Visible = False
        '
        'btnEnd
        '
        Me.btnEnd.Location = New System.Drawing.Point(178, 152)
        Me.btnEnd.Name = "btnEnd"
        Me.btnEnd.Size = New System.Drawing.Size(75, 23)
        Me.btnEnd.TabIndex = 5
        Me.btnEnd.Text = "End session"
        Me.btnEnd.UseVisualStyleBackColor = True
        '
        'frmStudy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(350, 183)
        Me.Controls.Add(Me.btnEnd)
        Me.Controls.Add(Me.grpMultiChoice)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblQuestion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmStudy"
        Me.Text = "Study window"
        Me.grpMultiChoice.ResumeLayout(False)
        Me.grpMultiChoice.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuestion As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtAnswer As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents grpMultiChoice As GroupBox
    Friend WithEvents optMulti4 As RadioButton
    Friend WithEvents optMulti3 As RadioButton
    Friend WithEvents optMulti2 As RadioButton
    Friend WithEvents optMulti1 As RadioButton
    Friend WithEvents btnEnd As Button
End Class
