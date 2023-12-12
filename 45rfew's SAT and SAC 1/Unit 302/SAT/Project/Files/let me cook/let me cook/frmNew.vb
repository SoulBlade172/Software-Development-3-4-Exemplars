'Author: 45rfew
'Created: 22/5/28
'Version: 1.0.2
'Purpose: Screen displayed to create a new class 
'Changelog: 
' 5/31/2023 - VERSION 0.0.1
' - Core functions started; no file functionality 
' 3/6/2023 - VERSION 0.0.2
' - No longer clears input text for creating classes 
' 10/6/2023 - VERSION 1.0.2
' - UI completed 
' 17/6/2023 - VERSION 1.0.2
' - Added internal documentation 

Public Class frmNew
    Dim defaultClass() As String = {"CLASS NAME", "", "Name", "Last Name", "ID_INT", "Attendence", "Extension", "Modified", "Score_INT", "Remarks"} 'default class structure
    Public Sub newLoad(sender As Object, e As EventArgs) Handles MyBase.Activated 'event handles when the formm is activated, not loaded 
        txtInput.Text = String.Join(vbCrLf, defaultClass) 'set the default class structure based on the default class array 
    End Sub
    Public Sub create(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim input() As String = txtInput.Lines 'retrieves input lines from the textbox
        input = Array.FindAll(input, Function(item) Not String.IsNullOrWhiteSpace(item)) 'removes empty lines from input 
        If classes.createClass(input) Then Close() 'close the form if creation is successful 
        'txtInput.Text = ""
    End Sub
    Private Sub cancel(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to abandon process?", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub
End Class