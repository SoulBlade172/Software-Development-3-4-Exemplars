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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearch))
        Me.lblSearchTerm = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.lblTagSearch = New System.Windows.Forms.Label()
        Me.cbxTagSearch = New System.Windows.Forms.ComboBox()
        Me.lblResults = New System.Windows.Forms.Label()
        Me.lstResults = New System.Windows.Forms.ListBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.grpSearchType = New System.Windows.Forms.GroupBox()
        Me.optTag = New System.Windows.Forms.RadioButton()
        Me.optName = New System.Windows.Forms.RadioButton()
        Me.grpSearchType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSearchTerm
        '
        Me.lblSearchTerm.AutoSize = True
        Me.lblSearchTerm.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchTerm.Location = New System.Drawing.Point(12, 9)
        Me.lblSearchTerm.Name = "lblSearchTerm"
        Me.lblSearchTerm.Size = New System.Drawing.Size(82, 16)
        Me.lblSearchTerm.TabIndex = 0
        Me.lblSearchTerm.Text = "Search term:"
        Me.lblSearchTerm.Visible = False
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(121, 9)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(198, 20)
        Me.txtSearch.TabIndex = 1
        Me.txtSearch.Visible = False
        '
        'lblTagSearch
        '
        Me.lblTagSearch.AutoSize = True
        Me.lblTagSearch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTagSearch.Location = New System.Drawing.Point(12, 10)
        Me.lblTagSearch.Name = "lblTagSearch"
        Me.lblTagSearch.Size = New System.Drawing.Size(91, 16)
        Me.lblTagSearch.TabIndex = 2
        Me.lblTagSearch.Text = "Tag to include:"
        Me.lblTagSearch.Visible = False
        '
        'cbxTagSearch
        '
        Me.cbxTagSearch.FormattingEnabled = True
        Me.cbxTagSearch.Location = New System.Drawing.Point(121, 9)
        Me.cbxTagSearch.Name = "cbxTagSearch"
        Me.cbxTagSearch.Size = New System.Drawing.Size(198, 21)
        Me.cbxTagSearch.TabIndex = 3
        Me.cbxTagSearch.Visible = False
        '
        'lblResults
        '
        Me.lblResults.AutoSize = True
        Me.lblResults.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResults.Location = New System.Drawing.Point(12, 103)
        Me.lblResults.Name = "lblResults"
        Me.lblResults.Size = New System.Drawing.Size(106, 16)
        Me.lblResults.TabIndex = 4
        Me.lblResults.Text = "Results (names):"
        '
        'lstResults
        '
        Me.lstResults.FormattingEnabled = True
        Me.lstResults.Location = New System.Drawing.Point(121, 65)
        Me.lstResults.Name = "lstResults"
        Me.lstResults.Size = New System.Drawing.Size(198, 95)
        Me.lstResults.TabIndex = 5
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(199, 177)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'grpSearchType
        '
        Me.grpSearchType.Controls.Add(Me.optTag)
        Me.grpSearchType.Controls.Add(Me.optName)
        Me.grpSearchType.Location = New System.Drawing.Point(348, 9)
        Me.grpSearchType.Name = "grpSearchType"
        Me.grpSearchType.Size = New System.Drawing.Size(109, 100)
        Me.grpSearchType.TabIndex = 7
        Me.grpSearchType.TabStop = False
        Me.grpSearchType.Text = "Search type"
        '
        'optTag
        '
        Me.optTag.AutoSize = True
        Me.optTag.Location = New System.Drawing.Point(7, 44)
        Me.optTag.Name = "optTag"
        Me.optTag.Size = New System.Drawing.Size(79, 17)
        Me.optTag.TabIndex = 1
        Me.optTag.Text = "Tag search"
        Me.optTag.UseVisualStyleBackColor = True
        '
        'optName
        '
        Me.optName.AutoSize = True
        Me.optName.Checked = True
        Me.optName.Location = New System.Drawing.Point(7, 20)
        Me.optName.Name = "optName"
        Me.optName.Size = New System.Drawing.Size(88, 17)
        Me.optName.TabIndex = 0
        Me.optName.TabStop = True
        Me.optName.Text = "Name search"
        Me.optName.UseVisualStyleBackColor = True
        '
        'frmSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(469, 212)
        Me.Controls.Add(Me.grpSearchType)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lstResults)
        Me.Controls.Add(Me.lblResults)
        Me.Controls.Add(Me.cbxTagSearch)
        Me.Controls.Add(Me.lblTagSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.lblSearchTerm)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSearch"
        Me.Text = "Search"
        Me.grpSearchType.ResumeLayout(False)
        Me.grpSearchType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSearchTerm As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblTagSearch As Label
    Friend WithEvents cbxTagSearch As ComboBox
    Friend WithEvents lblResults As Label
    Friend WithEvents lstResults As ListBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents grpSearchType As GroupBox
    Friend WithEvents optTag As RadioButton
    Friend WithEvents optName As RadioButton
End Class
