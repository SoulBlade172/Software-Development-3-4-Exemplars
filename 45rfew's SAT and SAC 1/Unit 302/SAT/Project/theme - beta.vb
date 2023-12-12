'Author: 45rfew
'Created: 14/6/3 
'Version: 1.0.2
'Purpose: Theme selector that allows a user to change the theme
'Changelog: 
' 14/6/2023 - VERSION 0.0.1
' - UI and basic functionality
' 15/6/2023 - VERSION 0.0.2
' - All forms updated upon choosing a theme 
' - Defaults to the original theme 
' 17/6/2023 - VERSION 1.0.2
' - Added internal documentation 

Public Class frmTheme
    Private Sub themeLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each name As String In themes.themes.Keys 'iterate through the themes dictionary and populate the combobox with theme names 
            cboThemes.Items.Add(name)
        Next
        cboThemes.SelectedIndex = 0 'sets default index to 0 
    End Sub
    Private Sub themesIndexChanged(sender As Object, e As EventArgs) Handles cboThemes.SelectedIndexChanged
        If themes.themes.ContainsKey(cboThemes.Text) Then themes.applyThemeAll(cboThemes.Text) 'check if the selected theme exists in the dictionary 
        themes.theme = cboThemes.Text
    End Sub
    Private Sub cancel(sender As Object, e As EventArgs) Handles btnCancel.Click
        themes.theme = "Default"
        Close()
    End Sub
    Private Sub apply(sender As Object, e As EventArgs) Handles btnApply.Click
        Close()
    End Sub
End Class

