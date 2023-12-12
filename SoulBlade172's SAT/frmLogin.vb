Imports System.IO

'Date of creation - 26/05/23
'Creator - SoulBlade172
'The purpose of this form is to have a login function to the application to add some security via the user adding their own PIN and then entering it upon opening the program.
Public Class frmLogin
    Private Sub btnCloseLogin_Click(sender As Object, e As EventArgs) Handles btnCloseLogin.Click
        Close()
    End Sub

    Private Sub btnEnterPIN_Click(sender As Object, e As EventArgs) Handles btnEnterPIN.Click
        Try
            Dim filePath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "PIN.txt")
            If File.Exists(filePath) = True Then
                Dim reader As New StreamReader(filePath)
                If txtPIN.Text = reader.ReadToEnd Then 'Matches text to PIN stored, if correct allows the user through
                    frmMain.Show()
                    Hide()
                    'Displays main window and hides login
                Else 'If entered PIN does not match stored PIN
                    MsgBox("Incorrect PIN, please try again.")
                    txtPIN.Text = ""
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.message)
        End Try
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim filePath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "PIN.txt")
            While File.Exists(filePath) = False 'Create PIN if it has not been created already, keeps running as long as the PIN file does not exist
                Dim pin As String = InputBox("Please input a 4 number PIN that will be used to login into the application.", "Create PIN")
                If IsNumeric(pin) = True And Len(pin) = 4 Then 'Validation for type (numeric) and length (4)
                    My.Computer.FileSystem.WriteAllText(filePath, pin, False)
                Else
                    MsgBox("Please input a valid PIN.")
                End If
            End While
        Catch ex As Exception
            MsgBox(ex.message)
        End Try
    End Sub
End Class