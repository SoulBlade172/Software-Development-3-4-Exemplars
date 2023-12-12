'Author: 45rfew
'Created: 22/5/23
'Version: 1.0.2
'Purpose: Login screen to the main program 
'Changelog: 
' 25/5/23 - VERSION 0.0.1
' - Core functions completed 
' 31/5/23 - VERSION 1.0.1
' - Login screen now up to standard;
' - Slight optimizations
' - Test option 
' 10/6/2023 - VERSION 1.0.2
' - UI refurbished 
' 17/6/2023 - VERSION 1.0.2
' - Added internal documentation 
' 13/7/2023 - VERSION 1.1.2
' - Added simple Caesar cipher encryption system lmao

Imports System.IO
Public Class frmLogin
    Dim logins = {{"234", "bcd"}, {"bnpoh", "vt"}, {"vtfsobnf", "qbttxpse"}, {"23456789", "1!rxfsuzvjpq"}, {"te", "te"}} ' array storing login credentials
    Dim test = 0 ' flag for testing
    Private Sub loginLoad(sender As Object, e As EventArgs) Handles MyBase.Activated 'event handles when the form is activated, not loaded
        If Not System.IO.File.Exists("UserLogins.txt") Then CreateUserLogins() 'creates user logins in a txt file if it doesn't exist 
        If test Then
            txtPassword.Text = "abc"
            txtUsername.Text = "123"
        End If

    End Sub

    Public Sub Login(Optional username As String = Nothing, Optional password As String = Nothing)
        If username = Nothing Then username = txtUsername.Text ' if username and password are not provided, treat them as null
        If password = Nothing Then password = txtPassword.Text
        Dim file = "UserLogins.txt", reader As New System.IO.StreamReader(file), line = reader.ReadLine(), login = {0, 0},
        correct = False
        Do While Not correct 'iterate through the file to find a matching username and password
            If line Is Nothing Then Exit Do
            ' Decrypt the line and split the decrypted values
            Dim decryptedLine = Decrypt(line), decryptedVal = decryptedLine.Split(" ")
            If username = decryptedVal(0) And password = decryptedVal(1) Then
                correct = True
                Hide()
                frmMain.Show() ' shows main form if username and password are correct
            End If
            line = reader.ReadLine()
        Loop
        If Not correct Then
            MessageBox.Show("Incorrect username or password")
            txtPassword.Text = "" ' throws error message and resets the password text
        End If
        reader.Close()
    End Sub
    Private Sub CreateUserLogins()
        Dim file As String = Path.Combine(Application.StartupPath, "UserLogins.txt") ' get the path to the username file
        Using writer As New StreamWriter(file)
            For i = 0 To logins.GetUpperBound(0) ' iterates through the logins array and writes the login credentials to the file
                Dim encryptedLine = ($"{logins(i, 0)}!{logins(i, 1)}")
                writer.WriteLine(encryptedLine)
            Next
        End Using
    End Sub
    Private Function Encrypt(value As String) As String 'simple Caesar cipher encryption (ty stackoverflow randos) 
        Dim encryptedVal = ""
        For Each ch As Char In value
            Dim encryptedChar = Chr(Asc(ch) + 1) 'shift each character by 1 position
            encryptedVal += encryptedChar
        Next
        Return encryptedVal
    End Function
    Private Function Decrypt(value As String) As String
        Dim decryptedVal = ""
        For Each ch As Char In value
            Dim decryptedChar = Chr(Asc(ch) - 1) 'shift each character back by 1 position
            decryptedVal += decryptedChar
        Next
        Return decryptedVal
    End Function
    Private Sub closeForm(sender As Object, e As EventArgs) Handles btnClose.Click
        End
    End Sub
    Private Sub enterMain(sender As Object, e As EventArgs) Handles btnEnter.Click
        Login(txtUsername.Text, txtPassword.Text)
    End Sub
End Class
 
