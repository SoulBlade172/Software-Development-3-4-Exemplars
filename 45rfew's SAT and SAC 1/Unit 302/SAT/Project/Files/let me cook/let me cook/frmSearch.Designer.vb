<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearch
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
        Me.cboColNames = New System.Windows.Forms.ComboBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblNew = New System.Windows.Forms.Label()
        Me.lblSelectColumn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'cboColNames
        '
        Me.cboColNames.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cboColNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboColNames.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboColNames.ForeColor = System.Drawing.Color.Black
        Me.cboColNames.FormattingEnabled = True
        Me.cboColNames.Location = New System.Drawing.Point(346, 296)
        Me.cboColNames.Name = "cboColNames"
        Me.cboColNames.Size = New System.Drawing.Size(121, 26)
        Me.cboColNames.TabIndex = 0
        Me.cboColNames.TabStop = False
        '
        'txtInput
        '
        Me.txtInput.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(346, 370)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(114, 26)
        Me.txtInput.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(439, 461)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 49)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.TabStop = False
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnSearch.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(293, 461)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(123, 49)
        Me.btnSearch.TabIndex = 16
        Me.btnSearch.TabStop = False
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'lblNew
        '
        Me.lblNew.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblNew.BackColor = System.Drawing.Color.Transparent
        Me.lblNew.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNew.Location = New System.Drawing.Point(-204, -26)
        Me.lblNew.Name = "lblNew"
        Me.lblNew.Size = New System.Drawing.Size(984, 200)
        Me.lblNew.TabIndex = 19
        Me.lblNew.Text = "Search Item"
        Me.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSelectColumn
        '
        Me.lblSelectColumn.AutoSize = True
        Me.lblSelectColumn.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectColumn.Location = New System.Drawing.Point(343, 274)
        Me.lblSelectColumn.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectColumn.Name = "lblSelectColumn"
        Me.lblSelectColumn.Size = New System.Drawing.Size(113, 18)
        Me.lblSelectColumn.TabIndex = 20
        Me.lblSelectColumn.Text = "Select Column:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(343, 348)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Item to find:"
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClear.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnClear.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(21, 469)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(81, 33)
        Me.btnClear.TabIndex = 23
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.Gray
        Me.txtOutput.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOutput.Location = New System.Drawing.Point(21, 127)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(258, 328)
        Me.txtOutput.TabIndex = 24
        Me.txtOutput.Text = "Search results:"
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(586, 563)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblSelectColumn)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblNew)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.cboColNames)
        Me.Name = "frmSearch"
        Me.Text = "Search "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboColNames As ComboBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblNew As Label
    Friend WithEvents lblSelectColumn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents txtOutput As RichTextBox
End Class
