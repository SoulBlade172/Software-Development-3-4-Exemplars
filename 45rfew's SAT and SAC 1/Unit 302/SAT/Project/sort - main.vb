'Author: 45rfew
'Created: 10/6/3 
'Version: 1.0.2
'Purpose: Sorting window that allows user to sort a column
'Changelog: 
' 10/6/2023 - VERSION 0.0.1
' - UI and basic functionality - cannot sort integer columns 
' 14/6/2023 - VERSION 0.0.2
' - Validation 
' - Updates combobox upon form activation 
' 17/6/2023 - VERSION 1.0.2
' - Added internal documentation 

Public Class frmSort
    Public Shared updated = False 'indicates if the data has been updated 
    Private Sub sortLoad(sender As Object, e As EventArgs) Handles MyBase.Activated  'event handles when the formm is activated, not loaded 
        If updated = False Then
            Try
                cboColNames.Items.Clear() 'if data has not been updated clear the combobox and update its items 
                sorts.fetchCol()
                updated = True
            Catch ex As Exception
                globalFunctions.echo("Create a class first")
            End Try
        End If
    End Sub
    Private Sub cancel(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to abandon process?", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub sort(sender As Object, e As EventArgs) Handles btnSort.Click
        sorts.sortCol()
    End Sub
End Class
