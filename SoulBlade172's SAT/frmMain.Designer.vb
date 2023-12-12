<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SortToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenOnBootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemoveAutobootToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTagToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyQuestionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteALLQuestionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lstQuestions = New System.Windows.Forms.ListBox()
        Me.lblStudy = New System.Windows.Forms.Label()
        Me.btnStudy = New System.Windows.Forms.Button()
        Me.lblQuestionSelected = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(533, 24)
        Me.mnuMain.TabIndex = 0
        Me.mnuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportToolStripMenuItem, Me.SortToolStripMenuItem, Me.SearchToolStripMenuItem, Me.OpenOnBootToolStripMenuItem, Me.RemoveAutobootToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'SortToolStripMenuItem
        '
        Me.SortToolStripMenuItem.Name = "SortToolStripMenuItem"
        Me.SortToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SortToolStripMenuItem.Text = "Sort"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'OpenOnBootToolStripMenuItem
        '
        Me.OpenOnBootToolStripMenuItem.Name = "OpenOnBootToolStripMenuItem"
        Me.OpenOnBootToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.OpenOnBootToolStripMenuItem.Text = "Open on boot"
        '
        'RemoveAutobootToolStripMenuItem
        '
        Me.RemoveAutobootToolStripMenuItem.Name = "RemoveAutobootToolStripMenuItem"
        Me.RemoveAutobootToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RemoveAutobootToolStripMenuItem.Text = "Remove auto-boot"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.AddTagToolStripMenuItem, Me.ModifyQuestionToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.DeleteALLQuestionsToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AddToolStripMenuItem.Text = "Add question"
        '
        'AddTagToolStripMenuItem
        '
        Me.AddTagToolStripMenuItem.Name = "AddTagToolStripMenuItem"
        Me.AddTagToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AddTagToolStripMenuItem.Text = "Add tag"
        '
        'ModifyQuestionToolStripMenuItem
        '
        Me.ModifyQuestionToolStripMenuItem.Name = "ModifyQuestionToolStripMenuItem"
        Me.ModifyQuestionToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ModifyQuestionToolStripMenuItem.Text = "Modify question"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'DeleteALLQuestionsToolStripMenuItem
        '
        Me.DeleteALLQuestionsToolStripMenuItem.Name = "DeleteALLQuestionsToolStripMenuItem"
        Me.DeleteALLQuestionsToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.DeleteALLQuestionsToolStripMenuItem.Text = "Delete ALL questions"
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(66, 36)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(115, 18)
        Me.lblSelect.TabIndex = 1
        Me.lblSelect.Text = "Select question"
        '
        'lstQuestions
        '
        Me.lstQuestions.FormattingEnabled = True
        Me.lstQuestions.Location = New System.Drawing.Point(12, 59)
        Me.lstQuestions.Name = "lstQuestions"
        Me.lstQuestions.Size = New System.Drawing.Size(232, 95)
        Me.lstQuestions.TabIndex = 2
        '
        'lblStudy
        '
        Me.lblStudy.AutoSize = True
        Me.lblStudy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStudy.Location = New System.Drawing.Point(375, 59)
        Me.lblStudy.Name = "lblStudy"
        Me.lblStudy.Size = New System.Drawing.Size(125, 16)
        Me.lblStudy.TabIndex = 3
        Me.lblStudy.Text = "Begin study session"
        '
        'btnStudy
        '
        Me.btnStudy.Location = New System.Drawing.Point(398, 78)
        Me.btnStudy.Name = "btnStudy"
        Me.btnStudy.Size = New System.Drawing.Size(75, 23)
        Me.btnStudy.TabIndex = 4
        Me.btnStudy.Text = "Study"
        Me.btnStudy.UseVisualStyleBackColor = True
        '
        'lblQuestionSelected
        '
        Me.lblQuestionSelected.AutoSize = True
        Me.lblQuestionSelected.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestionSelected.Location = New System.Drawing.Point(12, 169)
        Me.lblQuestionSelected.Name = "lblQuestionSelected"
        Me.lblQuestionSelected.Size = New System.Drawing.Size(137, 18)
        Me.lblQuestionSelected.TabIndex = 5
        Me.lblQuestionSelected.Text = "Question selected:"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(12, 225)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(118, 18)
        Me.lblScore.TabIndex = 6
        Me.lblScore.Text = "Times incorrect:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(398, 199)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(398, 131)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(75, 23)
        Me.btnRefresh.TabIndex = 8
        Me.btnRefresh.Text = "Refresh list"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(533, 286)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblQuestionSelected)
        Me.Controls.Add(Me.btnStudy)
        Me.Controls.Add(Me.lblStudy)
        Me.Controls.Add(Me.lstQuestions)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.mnuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Study Application"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SortToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTagToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModifyQuestionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblSelect As Label
    Friend WithEvents lstQuestions As ListBox
    Friend WithEvents lblStudy As Label
    Friend WithEvents btnStudy As Button
    Friend WithEvents lblQuestionSelected As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents OpenOnBootToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RemoveAutobootToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteALLQuestionsToolStripMenuItem As ToolStripMenuItem
End Class
