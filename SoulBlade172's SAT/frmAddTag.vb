Imports System.IO

'Date of creation - 28/05/23
'Creator - SoulBlade172
'The purpose of this form is to create tags that will be saved by the application and fetched later by other functions.
Public Class frmAddTag
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim tag As String = txtTagName.Text, filePath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Tags.txt")
            My.Computer.FileSystem.WriteAllText(filePath, tag & vbCrLf, True) 'Appends and adds a new line, thanks to - https://learn.microsoft.com/en-us/dotnet/visual-basic/developing-apps/programming/drives-directories-files/how-to-append-to-text-files
            MsgBox("Tag created successfully.")
            txtTagName.Text = "" 'Creates tag and clears textbox
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class