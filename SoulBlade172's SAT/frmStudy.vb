Imports System.ComponentModel
Imports System.IO

'Date of creation - 26/05/23
'Creator - SoulBlade172
'The purpose of this form is to have a study window in which the user can be presented with questions they have added to the program and then answer them.
Public Module StudyVariables
    Public QuestionIndex As Integer
    Public multiStudy As Boolean = False
End Module
Public Module CustomMessageBox 'Couretsy of https://stackoverflow.com/questions/47190131/simple-dialog-like-msgbox-with-custom-buttons-vb
    Private result As String
    Public Function Show(options As IEnumerable(Of String), Optional message As String = "", Optional title As String = "") As String 'Button options followed by prompt message and finally the message box's title
        result = "Cancel"
        'Formatting for custom message box
        Dim myForm As New Form With {.Text = title}
        Dim tlp As New TableLayoutPanel With {.ColumnCount = 1, .RowCount = 2}
        Dim flp As New FlowLayoutPanel()
        Dim l As New Label With {.Text = message}
        myForm.Controls.Add(tlp)
        tlp.Dock = DockStyle.Fill
        tlp.Controls.Add(l)
        l.Dock = DockStyle.Fill
        tlp.Controls.Add(flp)
        flp.Dock = DockStyle.Fill
        For Each o In options
            Dim b As New Button With {.Text = o}
            flp.Controls.Add(b)
            AddHandler b.Click,
                Sub(sender As Object, e As EventArgs)
                    result = DirectCast(sender, Button).Text
                    myForm.Close()
                End Sub
        Next
        myForm.FormBorderStyle = FormBorderStyle.FixedDialog
        myForm.Height = 100
        myForm.ShowDialog()
        Return result 'Returns what the user clicks in the message box
    End Function
End Module

Public Class frmStudy
    Private Sub frmStudy_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        frmMain.Show()
    End Sub

    Dim arr = CreateQuestionArray()
    Dim multiArr = CreateMultiQuestionArray()
    Private Sub frmStudy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim studyType = CustomMessageBox.Show(
            {"Multiple choice", "Short answer"},
            "What type of questions would you like to study?",
            "Study type")
        If studyType = "Short answer" Then
            multiStudy = False 'Sets to display only short answer questions
            txtAnswer.Visible = True
            grpMultiChoice.Visible = False
            optMulti1.Visible = False
            optMulti2.Visible = False
            optMulti3.Visible = False
            optMulti4.Visible = False
            For i = 0 To UBound(arr)
                If arr(i).ToString.Contains("Question:") Then 'Displays question onto the study window
                    QuestionIndex = i
                    lblQuestion.Text = $"Question {vbNewLine} {arr(i).ToString.Replace("Question:", "").Trim()}"
                    Exit For
                End If
            Next
        ElseIf studyType = "Multiple choice" Then
            multiStudy = True 'Sets to display only multiple choice questions and its related controls
            txtAnswer.Visible = False
            grpMultiChoice.Visible = True
            optMulti1.Visible = True
            optMulti2.Visible = True
            optMulti3.Visible = True
            optMulti4.Visible = True
            For i = 0 To UBound(multiArr)
                If multiArr(i).ToString.Contains("Question:") Then
                    QuestionIndex = i
                    lblQuestion.Text = $"Question {vbNewLine} {multiArr(i).ToString.Replace("Question:", "").Trim()}"
                    'Set the text of the radio buttons to the answers stored
                    optMulti1.Text = multiArr(QuestionIndex + 1).ToString.Replace("Answer1:", "")
                    optMulti2.Text = multiArr(QuestionIndex + 2).ToString.Replace("Answer2:", "")
                    optMulti3.Text = multiArr(QuestionIndex + 3).ToString.Replace("Answer3:", "")
                    optMulti4.Text = multiArr(QuestionIndex + 4).ToString.Replace("Answer4:", "")
                    Exit For
                End If
            Next
        Else
            frmMain.Show()
            Hide()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            If multiStudy = False Then
                Dim question As String = lblQuestion.Text.Split(vbCrLf)(1).TrimStart()
                Dim arr = CreateQuestionArray()
                For i As Integer = 0 To UBound(arr)
                    If arr(i).Contains(question) Then 'Checks the array to see if it contains the displayed question
                        Dim ans As String = arr(QuestionIndex + 1).Replace("Answer1:", "").Trim() 'Gets its corresponding answer
                        Dim result As DialogResult = MsgBox($"Answer: {ans}{vbNewLine}Your answer: {txtAnswer.Text}{vbNewLine}Was the answer correct?", MsgBoxStyle.YesNo)
                        If result = DialogResult.No Then 'If user says they got it incorrect
                            MsgBox("Another functionality that I could not test due to the 'file is being used by another application' error. Again, it seems unrelated to the code, and even a program like LockHunter fails to fix the issue, but it might work on other devices. If it does not work, please check the code to see how it would have worked.")
                            Dim scoreIndex = i + 3 'Score always 3 indexes after
                            arr(scoreIndex) = arr(scoreIndex).Replace("Score:", "").Trim()
                            Dim score As Integer
                            If Integer.TryParse(arr(scoreIndex), score) Then 'Converts string to integer to add to it
                                score += 1
                                arr(scoreIndex) = "Score:" + score.ToString() 'Converts the updated score to a string to put it back into the array

                                'Update the CSV file with the modified score
                                Dim filePath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Questions.txt")

                                Using writer As New StreamWriter(filePath) 'Rewrite file
                                    For j As Integer = 0 To UBound(arr)
                                        writer.WriteLine(arr(j))
                                    Next
                                End Using
                            Else
                                MsgBox("Invalid score format.")
                            End If
                        End If
                    End If
                Next

                txtAnswer.Text = ""

                'Find the index of the current question and display the next question
                Dim currentIndex As Integer = Array.FindIndex(Of String)(arr, Function(line) line.Contains(question)) 'Finds index of current question
                If currentIndex >= 0 Then
                    For i As Integer = currentIndex + 1 To UBound(arr) 'Goes to next index from the current question
                        If i = UBound(arr) Then 'If there are no more questions
                            MsgBox("Congratulations! You have studied all of the questions. Returning to the main screen.")
                            frmMain.Show()
                            Hide()
                        Else 'If there is more questions
                            If arr(i).Contains("Question:") Then 'Refreshses label with next question
                                lblQuestion.Text = $"Question {vbNewLine} {arr(i).Replace("Question:", "").Trim()}"
                                Exit For
                            End If
                        End If
                    Next
                End If
            Else 'If the user selected to study multiple choice questions
                Dim question As String = lblQuestion.Text.Split(vbCrLf)(1).TrimStart()
                Dim multiArr = CreateMultiQuestionArray()
                For i As Integer = 0 To UBound(multiArr)
                    If multiArr(i).Contains(question) Then
                        Dim ans As String = multiArr(i + 7).Replace("CorrectAnswer:", "").Trim() 'Gets correct answer from array, always 7 indexes after
                        Dim chosenAns As String = ""
                        'Assigns the chosen answer variable to whatever radio button is selected
                        If optMulti1.Checked = True Then
                            chosenAns = optMulti1.Text
                        ElseIf optMulti2.Checked = True Then
                            chosenAns = optMulti2.Text
                        ElseIf optMulti3.Checked = True Then
                            chosenAns = optMulti3.Text
                        ElseIf optMulti4.Checked = True Then
                            chosenAns = optMulti4.Text
                        End If
                        Dim result As DialogResult = MsgBox($"Answer: {ans}{vbNewLine}Your answer: {chosenAns}{vbNewLine}Was the answer correct?", MsgBoxStyle.YesNo)
                        If result = DialogResult.No Then
                            MsgBox("Another functionality that I could not test due to the 'file is being used by another application' error. Again, it seems unrelated to the code, and even a program like LockHunter fails to fix the issue, but it might work on other devices. If it does not work, please check the code to see how it would have worked.")
                            'Same process as before but score index is different
                            Dim scoreIndex = i + 6
                            multiArr(scoreIndex) = multiArr(scoreIndex).Replace("Score:", "").Trim()
                            Dim score As Integer
                            If Integer.TryParse(multiArr(scoreIndex), score) Then
                                score += 1
                                multiArr(scoreIndex) = "Score:" + score.ToString()

                                'Update the CSV file with the modified score
                                Dim filePath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Questions.txt")
                                Dim lines As List(Of String) = File.ReadAllLines(filePath).ToList()
                                lines(i) = String.Join(",", multiArr)
                                File.WriteAllLines(filePath, lines)
                            Else
                                MsgBox("Invalid score format.")
                            End If
                        End If
                    End If
                Next

                txtAnswer.Text = ""

                'Find the index of the current question and display the next question
                Dim currentIndex As Integer = Array.FindIndex(Of String)(multiArr, Function(line) line.Contains(question)) 'Finds index of current question
                If currentIndex >= 0 Then
                    For i As Integer = currentIndex + 1 To UBound(multiArr) 'Goes to next index from the current question
                        If i = UBound(multiArr) Then 'If there are no more questions
                            MsgBox("Congratulations! You have studied all of the questions. Returning to the main screen.")
                            frmMain.Show()
                            Hide()
                        Else 'If there is more questions
                            If multiArr(i).Contains("Question:") Then 'Refreshses label with next question
                                lblQuestion.Text = $"Question {vbNewLine} {multiArr(i).Replace("Question:", "").Trim()}"
                                Exit For
                            End If
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEnd_Click(sender As Object, e As EventArgs) Handles btnEnd.Click
        frmMain.Show()
        Close()
    End Sub
End Class