Public Class form1
    Private Sub txtGradeInput_TextChanged(sender As Object, e As EventArgs) Handles txtGradeInput.TextChanged
        Try 'attempts to invoke markoutput function 
            If txtGradeInput.Text >= 0 And txtGradeInput.Text <= 100 Then 'if the grade is between 0 to 100 it will output the mark 
                MarkOutput(txtGradeInput.Text, lblMarkOutput)
            Else 'otherwise mesageboxshows up 
                MessageBox.Show("Please enter an integer between 0 to 100")
                txtGradeInput.Text = "" 'empties the textbox 
            End If
        Catch ex As Exception 'catches ex if the input is not an integer 
            If txtGradeInput.Text <> "" Then 'excludes blank space 
                MessageBox.Show("Please only enter grade between 0 to 100") 'messagebox warms user 
            End If
            txtGradeInput.Text = "" 'empties textbox 
        End Try
    End Sub
    Private Sub MarkOutput(grade, textbox) 'function to calculate mark 
        Select Case grade
            Case 0.0 To 9
                textbox.Text = "Your student with a grade of " & txtGradeInput.Text & "% scored an E"
            Case 10 To 19
                textbox.Text = "Your student with a grade of " & txtGradeInput.Text & "% scored an E+"
            Case 20 To 29
                textbox.Text = "Your student with a grade of " & txtGradeInput.Text & "% scored a D"
            Case 30 To 39
                textbox.Text = "Your student with a grade of " & txtGradeInput.Text & "% scored a D+"
            Case 40 To 49
                textbox.Text = "Your student with a grade of " & txtGradeInput.Text & "% scored a C"
            Case 50 To 59
                textbox.Text = "Your student with a grade of " & txtGradeInput.Text & "% scored a C+"
            Case 60 To 69
                textbox.Text = "Your student with a grade of " & txtGradeInput.Text & "% scored a B"
            Case 70 To 79
                textbox.Text = "Your student with a grade of " & txtGradeInput.Text & "% scored a B+"
            Case 80 To 89
                textbox.Text = "Your student with a grade of " & txtGradeInput.Text & "% scored an A"
            Case 90 To 100
                textbox.Text = "Your student with a grade of " & txtGradeInput.Text & "% scored an A+"
            Case Else 'outputs the grade and mark onto label
                textbox.Text = "assadad " 'worst code i've ever written 
        End Select
    End Sub
End Class
