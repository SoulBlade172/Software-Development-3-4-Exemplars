<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTheme
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
        Me.lblSelectTheme = New System.Windows.Forms.Label()
        Me.cboThemes = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblSort = New System.Windows.Forms.Label()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSelectTheme
        '
        Me.lblSelectTheme.AutoSize = True
        Me.lblSelectTheme.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblSelectTheme.Location = New System.Drawing.Point(49, 115)
        Me.lblSelectTheme.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectTheme.Name = "lblSelectTheme"
        Me.lblSelectTheme.Size = New System.Drawing.Size(108, 18)
        Me.lblSelectTheme.TabIndex = 29
        Me.lblSelectTheme.Text = "Select Theme:"
        '
        'cboThemes
        '
        Me.cboThemes.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cboThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboThemes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboThemes.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cboThemes.ForeColor = System.Drawing.Color.Black
        Me.cboThemes.FormattingEnabled = True
        Me.cboThemes.Location = New System.Drawing.Point(55, 137)
        Me.cboThemes.Name = "cboThemes"
        Me.cboThemes.Size = New System.Drawing.Size(100, 24)
        Me.cboThemes.TabIndex = 28
        Me.cboThemes.TabStop = False
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(264, 137)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 33)
        Me.btnCancel.TabIndex = 27
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'lblSort
        '
        Me.lblSort.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSort.BackColor = System.Drawing.Color.Transparent
        Me.lblSort.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lblSort.Location = New System.Drawing.Point(-48, 0)
        Me.lblSort.Name = "lblSort"
        Me.lblSort.Size = New System.Drawing.Size(479, 95)
        Me.lblSort.TabIndex = 25
        Me.lblSort.Text = "Change Theme"
        Me.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnApply
        '
        Me.btnApply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnApply.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnApply.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.Location = New System.Drawing.Point(178, 137)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(80, 33)
        Me.btnApply.TabIndex = 30
        Me.btnApply.TabStop = False
        Me.btnApply.Text = "Apply"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'frmTheme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(381, 191)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.lblSelectTheme)
        Me.Controls.Add(Me.cboThemes)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblSort)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTheme"
        Me.Text = "Theme Selector"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelectTheme As Label
    Friend WithEvents cboThemes As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblSort As Label
    Friend WithEvents btnApply As Button
End Class
