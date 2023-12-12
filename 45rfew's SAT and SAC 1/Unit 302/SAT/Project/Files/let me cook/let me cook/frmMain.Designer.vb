<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAs = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSaveAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSort = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSearch = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStats = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuThemes = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbcMain = New System.Windows.Forms.TabControl()
        Me.tmrMain = New System.Windows.Forms.Timer(Me.components)
        Me.lblMain = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.cboCol = New System.Windows.Forms.ComboBox()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.txtUpdateInput = New System.Windows.Forms.TextBox()
        Me.txtUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblINT = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuMain.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(984, 26)
        Me.mnuMain.TabIndex = 2
        Me.mnuMain.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuOpen, Me.mnuSave, Me.mnuSaveAs, Me.mnuSaveAll})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(134, 22)
        Me.mnuNew.Text = "New"
        '
        'mnuOpen
        '
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(134, 22)
        Me.mnuOpen.Text = "Open"
        '
        'mnuSave
        '
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(134, 22)
        Me.mnuSave.Text = "Save"
        '
        'mnuSaveAs
        '
        Me.mnuSaveAs.Name = "mnuSaveAs"
        Me.mnuSaveAs.Size = New System.Drawing.Size(134, 22)
        Me.mnuSaveAs.Text = "Save As"
        '
        'mnuSaveAll
        '
        Me.mnuSaveAll.Name = "mnuSaveAll"
        Me.mnuSaveAll.Size = New System.Drawing.Size(134, 22)
        Me.mnuSaveAll.Text = "Save All"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSort, Me.mnuSearch, Me.mnuDelete})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(48, 22)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'mnuSort
        '
        Me.mnuSort.Name = "mnuSort"
        Me.mnuSort.Size = New System.Drawing.Size(126, 22)
        Me.mnuSort.Text = "Sort"
        '
        'mnuSearch
        '
        Me.mnuSearch.Name = "mnuSearch"
        Me.mnuSearch.Size = New System.Drawing.Size(126, 22)
        Me.mnuSearch.Text = "Search"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(126, 22)
        Me.mnuDelete.Text = "Delete"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStats, Me.mnuThemes})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(59, 22)
        Me.ViewToolStripMenuItem.Text = "View "
        '
        'mnuStats
        '
        Me.mnuStats.Name = "mnuStats"
        Me.mnuStats.Size = New System.Drawing.Size(132, 22)
        Me.mnuStats.Text = "Stats"
        '
        'mnuThemes
        '
        Me.mnuThemes.Name = "mnuThemes"
        Me.mnuThemes.Size = New System.Drawing.Size(132, 22)
        Me.mnuThemes.Text = "Themes"
        '
        'tbcMain
        '
        Me.tbcMain.Location = New System.Drawing.Point(26, 107)
        Me.tbcMain.Name = "tbcMain"
        Me.tbcMain.SelectedIndex = 0
        Me.tbcMain.Size = New System.Drawing.Size(728, 372)
        Me.tbcMain.TabIndex = 4
        '
        'tmrMain
        '
        '
        'lblMain
        '
        Me.lblMain.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblMain.BackColor = System.Drawing.Color.Transparent
        Me.lblMain.Font = New System.Drawing.Font("Arial", 24.0!)
        Me.lblMain.Location = New System.Drawing.Point(0, 21)
        Me.lblMain.Name = "lblMain"
        Me.lblMain.Size = New System.Drawing.Size(984, 95)
        Me.lblMain.TabIndex = 26
        Me.lblMain.Text = "Grading Manager"
        Me.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnAdd.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(856, 417)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(80, 28)
        Me.btnAdd.TabIndex = 31
        Me.btnAdd.TabStop = False
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'cboCol
        '
        Me.cboCol.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.cboCol.BackColor = System.Drawing.Color.LightSteelBlue
        Me.cboCol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCol.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.cboCol.ForeColor = System.Drawing.Color.Black
        Me.cboCol.FormattingEnabled = True
        Me.cboCol.Location = New System.Drawing.Point(794, 172)
        Me.cboCol.Name = "cboCol"
        Me.cboCol.Size = New System.Drawing.Size(150, 24)
        Me.cboCol.TabIndex = 32
        Me.cboCol.TabStop = False
        '
        'txtInput
        '
        Me.txtInput.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtInput.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInput.Location = New System.Drawing.Point(794, 337)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(150, 26)
        Me.txtInput.TabIndex = 33
        '
        'txtUpdateInput
        '
        Me.txtUpdateInput.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtUpdateInput.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdateInput.Location = New System.Drawing.Point(794, 224)
        Me.txtUpdateInput.Name = "txtUpdateInput"
        Me.txtUpdateInput.Size = New System.Drawing.Size(150, 26)
        Me.txtUpdateInput.TabIndex = 35
        '
        'txtUpdate
        '
        Me.txtUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtUpdate.BackColor = System.Drawing.Color.LightSlateGray
        Me.txtUpdate.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUpdate.Location = New System.Drawing.Point(794, 260)
        Me.txtUpdate.Name = "txtUpdate"
        Me.txtUpdate.Size = New System.Drawing.Size(79, 28)
        Me.txtUpdate.TabIndex = 34
        Me.txtUpdate.TabStop = False
        Me.txtUpdate.Text = "Rename"
        Me.txtUpdate.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnDelete.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnDelete.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(879, 260)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(68, 28)
        Me.btnDelete.TabIndex = 36
        Me.btnDelete.TabStop = False
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'lblSelect
        '
        Me.lblSelect.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(806, 131)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(122, 36)
        Me.lblSelect.TabIndex = 37
        Me.lblSelect.Text = "Select column to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " rename/delete:"
        '
        'lblAdd
        '
        Me.lblAdd.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Location = New System.Drawing.Point(822, 316)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(94, 18)
        Me.lblAdd.TabIndex = 38
        Me.lblAdd.Text = "Add column:"
        '
        'lblINT
        '
        Me.lblINT.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblINT.AutoSize = True
        Me.lblINT.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblINT.Location = New System.Drawing.Point(812, 366)
        Me.lblINT.Name = "lblINT"
        Me.lblINT.Size = New System.Drawing.Size(125, 48)
        Me.lblINT.TabIndex = 39
        Me.lblINT.Text = "Insert _INT at the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "end if the column " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is to store integers"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnClose.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Black
        Me.btnClose.Location = New System.Drawing.Point(828, 485)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(119, 49)
        Me.btnClose.TabIndex = 40
        Me.btnClose.TabStop = False
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnRemove
        '
        Me.btnRemove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRemove.BackColor = System.Drawing.Color.LightSlateGray
        Me.btnRemove.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemove.Location = New System.Drawing.Point(33, 485)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(119, 50)
        Me.btnRemove.TabIndex = 42
        Me.btnRemove.TabStop = False
        Me.btnRemove.Text = "Remove Selected Items"
        Me.btnRemove.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblINT)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.lblSelect)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.txtUpdateInput)
        Me.Controls.Add(Me.txtUpdate)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.cboCol)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.mnuMain)
        Me.Controls.Add(Me.tbcMain)
        Me.Controls.Add(Me.lblMain)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.mnuMain
        Me.Margin = New System.Windows.Forms.Padding(9, 8, 9, 8)
        Me.Name = "frmMain"
        Me.Text = "Grades manager"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents tbcMain As TabControl
    Friend WithEvents mnuSort As ToolStripMenuItem
    Friend WithEvents mnuSearch As ToolStripMenuItem
    Friend WithEvents mnuDelete As ToolStripMenuItem
    Friend WithEvents mnuOpen As ToolStripMenuItem
    Friend WithEvents mnuSave As ToolStripMenuItem
    Friend WithEvents mnuSaveAs As ToolStripMenuItem
    Friend WithEvents mnuStats As ToolStripMenuItem
    Friend WithEvents mnuThemes As ToolStripMenuItem
    Friend WithEvents tmrMain As Timer
    Friend WithEvents lblMain As Label
    Friend WithEvents mnuSaveAll As ToolStripMenuItem
    Friend WithEvents btnAdd As Button
    Friend WithEvents cboCol As ComboBox
    Friend WithEvents txtInput As TextBox
    Friend WithEvents txtUpdateInput As TextBox
    Friend WithEvents txtUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblSelect As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents lblINT As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents btnRemove As Button
End Class
