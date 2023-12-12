'Author: 45rfew
'Created: 13/6/3 
'Version: 1.0.2
'Purpose: Stats window that allows user to display stats of a column 
'Changelog: 
' 13/6/2023 - VERSION 0.0.1
' - UI and basic functionality 
' 14/6/2023 - VERSION 0.0.2
' - Bug fixes and general validation 
' - Columns combobox clears itself upon every activation of the form 
' - Closes form when a new class is created or when the tab control index changes 
' 17/6/2023 - VERSION 1.0.2
' - Added internal documentation 

Public Class frmStats
    Public Shared updated = False 'indicates if the data has been updated 
    Private Sub statsLoad(sender As Object, e As EventArgs) Handles MyBase.Activated 'event handles when the formm is activated, not loaded 
        If updated = False Then
            Try
                cboColNames.Items.Clear() 'if data has not been updated clear the combobox and update its items 
                stats.fetchCol()
                updated = True
            Catch ex As Exception
                globalFunctions.echo("Create a class first")
            End Try
        End If
    End Sub
    Private Sub search(sender As Object, e As EventArgs) Handles btnCalculate.Click
        stats.stats()
    End Sub
    Private Sub cancel(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to abandon process?", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            Hide()
            updated = False
        End If
    End Sub
    Private Sub clear(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOutput.Text = "Results:"
    End Sub
End Class