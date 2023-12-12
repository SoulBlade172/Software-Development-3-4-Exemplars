<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmStats
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
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblSelectColumn = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblCalc = New System.Windows.Forms.Label()
        Me.cboColNames = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.Gray
        Me.txtOutput.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(33, 142)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(258, 328)
        Me.txtOutput.TabIndex = 33
        Me.txtOutput.Text = "Search results:"
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(33, 479)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 33)
        Me.btnClear.TabIndex = 32
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblSelectColumn
        '
        Me.lblSelectColumn.AutoSize = True
        Me.lblSelectColumn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectColumn.Location = New System.Drawing.Point(349, 284)
        Me.lblSelectColumn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectColumn.Name = "lblSelectColumn"
        Me.lblSelectColumn.Size = New System.Drawing.Size(113, 18)
        Me.lblSelectColumn.TabIndex = 30
        Me.lblSelectColumn.Text = "Select Column:"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(451, 479)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 49)
        Me.btnCancel.TabIndex = 28
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCalculate.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCalculate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(307, 479)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(119, 49)
        Me.btnCalculate.TabIndex = 27
        Me.btnCalculate.TabStop = False
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'lblCalc
        '
        Me.lblCalc.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCalc.BackColor = System.Drawing.Color.Transparent
        Me.lblCalc.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalc.Location = New System.Drawing.Point(-202, -51)
        Me.lblCalc.Name = "lblCalc"
        Me.lblCalc.Size = New System.Drawing.Size(984, 200)
        Me.lblCalc.TabIndex = 29
        Me.lblCalc.Text = "Calculate Stats"
        Me.lblCalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboColNames
        '
        Me.cboColNames.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cboColNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboColNames.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboColNames.ForeColor = System.Drawing.Color.Black
        Me.cboColNames.FormattingEnabled = True
        Me.cboColNames.Location = New System.Drawing.Point(352, 314)
        Me.cboColNames.Name = "cboColNames"
        Me.cboColNames.Size = New System.Drawing.Size(121, 26)
        Me.cboColNames.TabIndex = 25
        Me.cboColNames.TabStop = False
        '
        'frmStats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(600, 585)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblSelectColumn)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblCalc)
        Me.Controls.Add(Me.cboColNames)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmStats"
        Me.Text = "Stat Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtOutput As RichTextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents lblSelectColumn As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblCalc As Label
    Friend WithEvents cboColNames As ComboBox
End Class
