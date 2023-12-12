<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNew
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
        Me.txtInput = New System.Windows.Forms.RichTextBox()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblCreate = New System.Windows.Forms.Label()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtInput.BackColor = System.Drawing.Color.LightSlateGray
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInput.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(24, 202)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(296, 305)
        Me.txtInput.TabIndex = 9
        Me.txtInput.Text = "a"
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCreate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(353, 457)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(119, 49)
        Me.btnCreate.TabIndex = 10
        Me.btnCreate.Text = "Enter"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(503, 457)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 49)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblCreate
        '
        Me.lblCreate.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCreate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCreate.Location = New System.Drawing.Point(21, 153)
        Me.lblCreate.Name = "lblCreate"
        Me.lblCreate.Size = New System.Drawing.Size(310, 56)
        Me.lblCreate.TabIndex = 12
        Me.lblCreate.Text = "Enter class name on the first line, followed by column names on each subsequent l" &
    "ine:"
        '
        'lblNew
        '
        Me.lblNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNew.BackColor = System.Drawing.Color.Transparent
        Me.lblNew.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(-164, -27)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(984, 200)
        Me.lblNew.TabIndex = 14
        Me.lblNew.Text = "Create Class"
        Me.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 515)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 56)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Include _INT after the column name if it is to store numerics"
        '
        'frmNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(664, 559)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblCreate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.lblNew)
        Me.Name = "frmNew"
        Me.Text = "New"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtInput As RichTextBox
    Friend WithEvents btnCreate As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblCreate As Label
    Friend WithEvents lblNew As Label
    Friend WithEvents Label1 As Label
End Class
