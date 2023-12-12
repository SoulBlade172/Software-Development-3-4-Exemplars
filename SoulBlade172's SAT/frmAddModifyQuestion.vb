Imports System.IO

'Date of creation - 28/05/23
'Creator - SoulBlade172
'The purpose of this form will be to allow the user to add and modify existing questions within the application.

Public Class frmAddModifyQuestion
    Private Sub frmAddModifyQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTags(filepath:=Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Tags.txt"), cbxTag)
        If modify = False Then 'If the add question menu strip has been clicked, clear textboxes and change window title
            txtAnswerField.Text = ""
            txtNameField.Text = ""
            txtQuestionField.Text = ""
            Text = "Add question"
            cbxQuestionType.SelectedIndex = 0
        ElseIf modify = True Then 'If the edit question menu strip has been clicked, auto-fill the text boxes with the values of the selected question
            If editAnswer2 <> Nothing Then 'Checks if it is a multiple choice question
                cbxQuestionType.SelectedIndex = 1 'Sets it to be a multiple choice type entry
                txtAnswerField2.Text = editAnswer2
                txtAnswerField3.Text = editAnswer3
                txtAnswerField4.Text = editAnswer4
                txtCorrectAnswerField.Text = editCorrectAnswer
            End If
            Text = "Modify question"
            txtAnswerField.Text = editAnswer
            txtNameField.Text = editName
            txtQuestionField.Text = editQuestion
            cbxTag.Text = editTag
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            'Checks if the files for storing both types of questions exists, if not create it
            Dim filepath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Questions.txt")
            Dim multiFilepath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "MultiQuestions.txt")
            If File.Exists(filepath) = False Then
                File.Create(filepath).Dispose()
            End If
            If File.Exists(multiFilepath) = False Then
                File.Create(multiFilepath).Dispose()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            'Stores values entered into text boxes
            Dim name As String = txtNameField.Text, question As String = txtQuestionField.Text, answer As String = txtAnswerField.Text,
        filepath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Questions.txt"), tag As String = cbxTag.Text
            If name.Contains("Name:") Or question.Contains("Question:") Or answer.Contains("Answer:") Then 'Prevents breakage of CSV pointers
                MsgBox("Please change the contents of the textboxes so that they do not include 'Name:', 'Question:', or 'Answer:'.")
            Else
                If cbxQuestionType.SelectedIndex = 0 Then 'If the user has selected short answer creation
                    If modify = False Then 'If they are creating a new question
                        If File.Exists(filepath) Then
                            Using objWriter As StreamWriter = File.AppendText(filepath) 'Writes the inputted values
                                objWriter.WriteLine($"Name:{name},Question:{question},Answer1:{answer},Tag:{tag},Score:0")
                            End Using
                            MsgBox("Question saved successfully.")
                        Else
                            MsgBox("An error occurred whilst trying to save the file, please try again.")
                        End If
                    Else
                        If File.Exists(filepath) Then
                            Dim lines As List(Of String) = File.ReadAllLines(filepath).ToList() 'Stores file contents into a list so it can be edited
                            For i As Integer = 0 To lines.Count - 1
                                If lines(i).Contains($"Name:{editName}") Then 'Checks if it contains the name that is to be edited, if so replace it with the new name
                                    Dim parts As String() = lines(i).Split(",")
                                    For j As Integer = 0 To parts.Length - 1
                                        If parts(j).Contains("Name:") Then
                                            parts(j) = $"Name:{name}"
                                            Exit For
                                        End If
                                    Next
                                    lines(i) = String.Join(",", parts) 'Puts it back together
                                End If
                                If lines(i).Contains($"Question:{editQuestion}") Then 'Checks if it contains the question that is to be edited, if so replace it with the new question
                                    Dim parts As String() = lines(i).Split(",")
                                    For j As Integer = 0 To parts.Length - 1
                                        If parts(j).Contains("Question:") Then
                                            parts(j) = $"Question:{question}"
                                            Exit For
                                        End If
                                    Next
                                    lines(i) = String.Join(",", parts)
                                End If
                                If lines(i).Contains($"Answer1:{editAnswer}") Then 'Checks if it contains the answer that is to be edited, if so replace it with the new answer
                                    Dim parts As String() = lines(i).Split(",")
                                    For j As Integer = 0 To parts.Length - 1
                                        If parts(j).Contains("Answer1:") Then
                                            parts(j) = $"Answer1:{answer}"
                                            Exit For
                                        End If
                                    Next
                                    lines(i) = String.Join(",", parts)
                                End If
                                If lines(i).Contains($"Tag:{editTag}") Then 'Checks if it contains the tag that is to be edited, if so replace it with the new tag
                                    Dim parts As String() = lines(i).Split(",")
                                    For j As Integer = 0 To parts.Length - 1
                                        If parts(j).Contains("Tag:") Then
                                            parts(j) = $"Tag:{tag}"
                                            Exit For
                                        End If
                                    Next
                                    lines(i) = String.Join(",", parts)
                                End If
                            Next
                            File.WriteAllLines(filepath, lines) 'Rewrites the file with updated values
                            MsgBox("Question updated successfully.")
                        End If
                    End If
                Else 'If the user is creating a multiple choice question
                    'Assign entered text values to variables
                    Dim answer2 As String = txtAnswerField2.Text, answer3 As String = txtAnswerField3.Text, answer4 As String = txtAnswerField4.Text, correctAns As String = txtCorrectAnswerField.Text, multiFilepath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "MultiQuestions.txt")
                    If name.Contains("Name:") Or question.Contains("Question:") Or answer.Contains("Answer:") Or answer2.Contains("Answer2:") Or answer3.Contains("Answer3:") Or answer4.Contains("Answer4:") Or correctAns.Contains("CorrectAnswer:") Then 'Prevents breakage of pointers in the CSV
                        MsgBox("Please change the contents of the textboxes so that they do not include 'Name:', 'Question:', 'Answer:', 'Answer2:', 'Answer3:', or 'Answer4:'.")
                    Else
                        If modify = False Then 'Creating a new question
                            If File.Exists(multiFilepath) Then
                                Using objWriter As StreamWriter = File.AppendText(multiFilepath)
                                    objWriter.WriteLine($"Name:{name},Question:{question},Answer1:{answer},Answer2:{answer2},Answer3:{answer3},Answer4:{answer4},Tag:{tag},Score:0,CorrectAnswer:{correctAns}")
                                End Using
                                MsgBox("Question saved successfully.")
                            Else
                                MsgBox("An error occurred whilst trying to save the file, please try again.")
                            End If
                        Else
                            If File.Exists(multiFilepath) Then
                                Dim lines As List(Of String) = File.ReadAllLines(multiFilepath).ToList()
                                For i As Integer = 0 To lines.Count - 1
                                    If lines(i).Contains($"Name:{editName}") Then 'Checks if it contains the name that is to be edited, if so replace it with the new name
                                        Dim parts As String() = lines(i).Split(",")
                                        For j As Integer = 0 To parts.Length - 1
                                            If parts(j).Contains("Name:") Then
                                                parts(j) = $"Name:{name}"
                                                Exit For
                                            End If
                                        Next
                                        lines(i) = String.Join(",", parts) 'Puts it back together
                                        Exit For
                                    End If
                                    If lines(i).Contains($"Question:{editQuestion}") Then 'Checks if it contains the question that is to be edited, if so replace it with the new question
                                        Dim parts As String() = lines(i).Split(",")
                                        For j As Integer = 0 To parts.Length - 1
                                            If parts(j).Contains("Question:") Then
                                                parts(j) = $"Question:{question}"
                                                Exit For
                                            End If
                                        Next
                                        lines(i) = String.Join(",", parts)
                                    End If
                                    If lines(i).Contains($"Answer1:{editAnswer}") Then 'Checks if it contains the first answer that is to be edited, if so replace it with the new first answer
                                        Dim parts As String() = lines(i).Split(",")
                                        For j As Integer = 0 To parts.Length - 1
                                            If parts(j).Contains("Answer1:") Then
                                                parts(j) = $"Answer1:{answer}"
                                                Exit For
                                            End If
                                        Next
                                        lines(i) = String.Join(",", parts)
                                    End If
                                    If lines(i).Contains($"Answer2:{editAnswer2}") Then 'Checks if it contains the second answer that is to be edited, if so replace it with the new second answer
                                        Dim parts As String() = lines(i).Split(",")
                                        For j As Integer = 0 To parts.Length - 1
                                            If parts(j).Contains("Answer2:") Then
                                                parts(j) = $"Answer2:{answer}"
                                                Exit For
                                            End If
                                        Next
                                        lines(i) = String.Join(",", parts)
                                    End If
                                    If lines(i).Contains($"Answer3:{editAnswer3}") Then 'Checks if it contains the third answer that is to be edited, if so replace it with the new third answer
                                        Dim parts As String() = lines(i).Split(",")
                                        For j As Integer = 0 To parts.Length - 1
                                            If parts(j).Contains("Answer3:") Then
                                                parts(j) = $"Answer3:{answer3}"
                                                Exit For
                                            End If
                                        Next
                                        lines(i) = String.Join(",", parts)
                                    End If
                                    If lines(i).Contains($"Answer4:{editAnswer4}") Then 'Checks if it contains the new fourth answer that is to be edited, if so replace it with the new fourth answer
                                        Dim parts As String() = lines(i).Split(",")
                                        For j As Integer = 0 To parts.Length - 1
                                            If parts(j).Contains("Answer4:") Then
                                                parts(j) = $"Answer4:{answer4}"
                                                Exit For
                                            End If
                                        Next
                                        lines(i) = String.Join(",", parts)
                                    End If
                                    If lines(i).Contains($"Tag:{editTag}") Then 'Checks if it contains the tag that is to be edited, if so replace it with the new tag
                                        Dim parts As String() = lines(i).Split(",")
                                        For j As Integer = 0 To parts.Length - 1
                                            If parts(j).Contains("Tag:") Then
                                                parts(j) = $"Tag:{tag}"
                                                Exit For
                                            End If
                                        Next
                                        lines(i) = String.Join(",", parts)
                                    End If
                                    If lines(i).Contains($"CorrectAnswer:{editCorrectAnswer}") Then 'Checks if it contains the correct answer that is to be edited, if so replace it with the new correct answer
                                        Dim parts As String() = lines(i).Split(",")
                                        For j As Integer = 0 To parts.Length - 1
                                            If parts(j).Contains("CorrectAnswer:") Then
                                                parts(j) = $"CorrectAnswer:{correctAns}"
                                                Exit For
                                            End If
                                        Next
                                        lines(i) = String.Join(",", parts)
                                    End If
                                Next
                                File.WriteAllLines(multiFilepath, lines) 'Rewrites the file with updated values
                                MsgBox("Question updated successfully.")
                            Else
                                MsgBox("An error occurred whilst trying to save the file, please try again.")
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbxQuestionType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxQuestionType.SelectedIndexChanged
        If cbxQuestionType.SelectedIndex = 0 Then 'Reveals appropriate controls depending on the question type selected
            txtAnswerField2.Hide()
            txtAnswerField3.Hide()
            txtAnswerField4.Hide()
            txtCorrectAnswerField.Hide()
            lblCorrectAnswer.Hide()
        Else
            txtAnswerField2.Show()
            txtAnswerField3.Show()
            txtAnswerField4.Show()
            txtCorrectAnswerField.Show()
            lblCorrectAnswer.Show()
        End If
    End Sub

    Private Sub btnAddTag_Click(sender As Object, e As EventArgs) Handles btnAddTag.Click
        frmAddTag.Show()
    End Sub
End Class