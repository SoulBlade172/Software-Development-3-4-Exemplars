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
        Me.lbllLogin = New System.Windows.Forms.Label()
        Me.txtPIN = New System.Windows.Forms.TextBox()
        Me.btnEnterPIN = New System.Windows.Forms.Button()
        Me.btnCloseLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbllLogin
        '
        Me.lbllLogin.AutoSize = True
        Me.lbllLogin.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllLogin.Location = New System.Drawing.Point(66, 9)
        Me.lbllLogin.Name = "lbllLogin"
        Me.lbllLogin.Size = New System.Drawing.Size(158, 18)
        Me.lbllLogin.TabIndex = 0
        Me.lbllLogin.Text = "Please enter your PIN"
        '
        'txtPIN
        '
        Me.txtPIN.Location = New System.Drawing.Point(48, 44)
        Me.txtPIN.Name = "txtPIN"
        Me.txtPIN.Size = New System.Drawing.Size(188, 20)
        Me.txtPIN.TabIndex = 1
        '
        'btnEnterPIN
        '
        Me.btnEnterPIN.Location = New System.Drawing.Point(48, 81)
        Me.btnEnterPIN.Name = "btnEnterPIN"
        Me.btnEnterPIN.Size = New System.Drawing.Size(75, 23)
        Me.btnEnterPIN.TabIndex = 2
        Me.btnEnterPIN.Text = "Enter"
        Me.btnEnterPIN.UseVisualStyleBackColor = True
        '
        'btnCloseLogin
        '
        Me.btnCloseLogin.Location = New System.Drawing.Point(161, 81)
        Me.btnCloseLogin.Name = "btnCloseLogin"
        Me.btnCloseLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnCloseLogin.TabIndex = 3
        Me.btnCloseLogin.Text = "Close"
        Me.btnCloseLogin.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(297, 129)
        Me.Controls.Add(Me.btnCloseLogin)
        Me.Controls.Add(Me.btnEnterPIN)
        Me.Controls.Add(Me.txtPIN)
        Me.Controls.Add(Me.lbllLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmLogin"
        Me.Text = "Study Application - Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbllLogin As Label
    Friend WithEvents txtPIN As TextBox
    Friend WithEvents btnEnterPIN As Button
    Friend WithEvents btnCloseLogin As Button
End Class
