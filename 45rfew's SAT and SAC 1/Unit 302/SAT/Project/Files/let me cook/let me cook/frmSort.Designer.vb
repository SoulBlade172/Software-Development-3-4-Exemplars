<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSort
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
        Me.lblSort = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.lblSelectColumn = New System.Windows.Forms.Label()
        Me.cboColNames = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'lblSort
        '
        Me.lblSort.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSort.BackColor = System.Drawing.Color.Transparent
        Me.lblSort.Font = New System.Drawing.Font("Arial", 20.0!)
        Me.lblSort.Location = New System.Drawing.Point(-79, 16)
        Me.lblSort.Name = "lblSort"
        Me.lblSort.Size = New System.Drawing.Size(479, 95)
        Me.lblSort.TabIndex = 20
        Me.lblSort.Text = "Sort Column"
        Me.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(165, 201)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 33)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSort
        '
        Me.btnSort.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSort.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnSort.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSort.Location = New System.Drawing.Point(79, 201)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(80, 33)
        Me.btnSort.TabIndex = 21
        Me.btnSort.TabStop = False
        Me.btnSort.Text = "Sort"
        Me.btnSort.UseVisualStyleBackColor = False
        '
        'lblSelectColumn
        '
        Me.lblSelectColumn.AutoSize = True
        Me.lblSelectColumn.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.lblSelectColumn.Location = New System.Drawing.Point(110, 123)
        Me.lblSelectColumn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectColumn.Name = "lblSelectColumn"
        Me.lblSelectColumn.Size = New System.Drawing.Size(113, 18)
        Me.lblSelectColumn.TabIndex = 24
        Me.lblSelectColumn.Text = "Select Column:"
        '
        'cboColNames
        '
        Me.cboColNames.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cboColNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboColNames.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cboColNames.ForeColor = System.Drawing.Color.Black
        Me.cboColNames.FormattingEnabled = True
        Me.cboColNames.Location = New System.Drawing.Point(113, 144)
        Me.cboColNames.Name = "cboColNames"
        Me.cboColNames.Size = New System.Drawing.Size(100, 24)
        Me.cboColNames.TabIndex = 23
        Me.cboColNames.TabStop = False
        '
        'frmSort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(320, 271)
        Me.Controls.Add(Me.lblSelectColumn)
        Me.Controls.Add(Me.cboColNames)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.lblSort)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSort"
        Me.Text = "Sort Column"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSort As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSort As Button
    Friend WithEvents lblSelectColumn As Label
    Friend WithEvents cboColNames As ComboBox
End Class
