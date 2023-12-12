'Author: 45rfew
'Created: 22/5/3 
'Version: 1.0.4
'Purpose: Search window that allows user to search for values
'Changelog: 
' 5/3/2023 - VERSION 0.0.1
' - Skeleton UI and basic functionality 
' - Only shows one value result 
' 8/6/2023 - VERSION 0.0.2 
' - Displays all values within the row instead of just the cell  
' 10/6/2023 - VERSION 0.0.3
' - UI improvements (no more button 1 button 2 lol) 
' - Added buttons for search and cancel
' - Bug fixes
'13/6/2023 VERSION 1.0.4
' - UI completed 
' - Added validation 
' 17/6/2023 - VERSION 1.0.4
' - Added internal documentation 

'TODO: allow search with multiple values

Public Class frmSearch
    Public Shared updated = False 'indicates if the data has been updated 
    Private Sub searchLoad(sender As Object, e As EventArgs) Handles MyBase.Activated 'event handles when the formm is activated, not loaded 
        'If updated = False Then
        Try
                cboColNames.Items.Clear() 'if data has not been updated clear the combobox and update its items 
                searches.fetchCol()
                updated = True
            Catch ex As Exception
                globalFunctions.echo("Create a class first")
            End Try
        'End If
    End Sub
    Private Sub search(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtInput.Text = "" Or cboColNames.SelectedIndex < 0 Then 'checks if the input is blank or if there is nothing selected 
            globalFunctions.echo("Search input invalid and/or no column selected")
            Exit Sub
        End If
        searches.fetchCell()
    End Sub
    Private Sub cancel(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to abandon process?", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            Hide()
        End If
    End Sub
    Private Sub clear(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOutput.Text = "Search results:"
    End Sub
End Class