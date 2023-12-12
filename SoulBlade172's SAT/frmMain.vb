Imports System.ComponentModel
Imports System.IO
Imports Microsoft.Win32

'Creator - SoulBlade172
'Date of creation - 23/05/23
'The purpose of this form is to house the functionalities of the home page, which are:
'Going to other forms within the application
'Displaying added questions
'Also holds functions and subs used throughout the program

Public Module GlobalFunctions 'Allows the following subs and functions to be used within all forms of the program, thanks to - https://stackoverflow.com/questions/26791067/how-to-make-a-function-sub-available-to-all-forms-in-a-project
    Public Sub PopulateTags(ByRef filepath As String, cbx As ComboBox) 'Adds saved tags to a combo box
        If File.Exists(filepath) Then
            Dim objReader As New StreamReader(filepath)
            cbx.Items.Clear() 'Clears items so it does not add repeat items
            Do While objReader.Peek() <> -1 'Peek checks next available character, if nothing, -1; runs as long as there is data
                cbx.Items.Add(objReader.ReadLine())
            Loop
        End If
    End Sub

    Public modify As Boolean 'Variable used to determine whether the add/modify question window should be blank or not

    Public Function CreateQuestionArray() 'Creates the array which holds the short answer questions
        If File.Exists(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Questions.txt")) Then
            Dim reader As New StreamReader(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Questions.txt"))
            Dim sline As String = reader.ReadToEnd() 'Reads entire file first and then stores it
            Dim lines As List(Of String) = New List(Of String)()
            For Each line As String In sline.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries) 'Prevents empty strings from being added
                Dim splitValues As String() = line.Split(",") 'Complete data is split by commas, CSV file
                lines.AddRange(splitValues) 'Added to list
            Next
            Dim arr() As String = lines.ToArray() 'List items converted into an array to be used
            Return arr
        Else
            Return Nothing 'If the file does not exist do not make anything
        End If
    End Function

    Public Function CreateMultiQuestionArray() 'Creates the array which holds the multiple choice questions, same process as above but using a different file
        If File.Exists(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "MultiQuestions.txt")) Then
            Dim reader As New StreamReader(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "MultiQuestions.txt"))
            Dim sline As String = reader.ReadToEnd()
            Dim lines As List(Of String) = New List(Of String)()
            For Each line As String In sline.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
                Dim splitValues As String() = line.Split(",")
                lines.AddRange(splitValues)
            Next
            Dim arr() As String = lines.ToArray()
            Return arr
        Else
            Return Nothing
        End If
    End Function

    'Variables used to auto-fill the text boxes when editing a question
    Public editName As String
    Public editAnswer As String
    Public editAnswer2 As String
    Public editAnswer3 As String
    Public editAnswer4 As String
    Public editCorrectAnswer As String
    Public editQuestion As String
    Public editTag As String
End Module

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnStudy_Click(sender As Object, e As EventArgs) Handles btnStudy.Click
        frmStudy.Show()
        Hide()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        frmSearch.Show()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        modify = False 'Making a new question
        frmAddModifyQuestion.Show()
    End Sub

    Private Sub AddTagToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddTagToolStripMenuItem.Click
        frmAddTag.Show()
    End Sub

    Private Sub ModifyQuestionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyQuestionToolStripMenuItem.Click
        modify = True 'Editing an existing question
        If lstQuestions.SelectedItem <> Nothing Then 'Gets edit values ready before opening edit window
            editName = lstQuestions.SelectedItem.ToString
            editQuestion = lblQuestionSelected.Text.Replace("Question selected: ", "")
            frmAddModifyQuestion.Show()
        Else
            MsgBox("No question is selected.")
        End If
    End Sub

    Private Sub frmMain_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'Closes all other forms before closing itself so the program stops running
        frmLogin.Close()
        frmAddModifyQuestion.Close()
        frmAddTag.Close()
        frmSearch.Close()
        frmStudy.Close()
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Questions.txt")) Then
            For Each question As String In CreateQuestionArray()
                If question.Contains("Name:") Then 'Checks array for name values and adds it to the list box
                    Dim temp As String = question.Replace("Name:", "").Trim()
                    lstQuestions.Items.Add(temp)
                End If
            Next
        End If
        If File.Exists(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "MultiQuestions.txt")) Then
            For Each question As String In CreateMultiQuestionArray()
                If question.Contains("Name:") Then 'Same as above but for the multiple choice questions
                    Dim temp As String = question.Replace("Name:", "").Trim()
                    lstQuestions.Items.Add(temp)
                End If
            Next
        End If
    End Sub

    Private Sub lstQuestions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstQuestions.SelectedIndexChanged
        Try
            Dim questionArray As String() = CreateQuestionArray()
            Dim multi_questionArray As String() = CreateMultiQuestionArray()

            If lstQuestions.SelectedItem <> Nothing Then
                Dim selectedQuestion As String = lstQuestions.SelectedItem.ToString()

                'Check if the selected question is in the questionArray
                Dim selectedQuestionIndex As Integer = Array.FindIndex(questionArray, Function(question) question.Contains(selectedQuestion)) 'Gets index of selected question in list box from array
                If selectedQuestionIndex >= 0 AndAlso selectedQuestionIndex + 1 < questionArray.Length Then 'Validation so that it does not go beyond array
                    Dim QuestionIndex As Integer = selectedQuestionIndex + 1 'Question always next index after name index
                    Dim question As String = questionArray(QuestionIndex).Replace("Question:", "").Trim() 'Replace pointer so that only data remains
                    Dim AnswerIndex As Integer = selectedQuestionIndex + 2 'Answer always two indexes after name index
                    editAnswer = questionArray(AnswerIndex).Replace("Answer1:", "").Trim()
                    Dim TagIndex As Integer = selectedQuestionIndex + 3 'Tag always three indexes after name index
                    editTag = questionArray(TagIndex).Replace("Tag:", "").Trim()
                    Dim ScoreIndex As Integer = selectedQuestionIndex + 4 'Score always four indexes after name index
                    Dim score As String = questionArray(ScoreIndex).Replace("Score:", "").Trim()
                    lblQuestionSelected.Text = $"Question selected: {question}"
                    lblScore.Text = $"Times incorrect: {score}"
                End If

                'If the selected question is not found in the questionArray, check the multi_questionArray
                If selectedQuestionIndex < 0 Then
                    selectedQuestionIndex = Array.FindIndex(multi_questionArray, Function(question) question.Contains(selectedQuestion))
                    If selectedQuestionIndex >= 0 AndAlso selectedQuestionIndex + 1 < multi_questionArray.Length Then
                        Dim QuestionIndex As Integer = selectedQuestionIndex + 1 'Question always next index after name index
                        Dim question As String = multi_questionArray(QuestionIndex).Replace("Question:", "").Trim()
                        Dim AnswerIndex As Integer = selectedQuestionIndex + 2 'Answer always two indexes after name index
                        editAnswer = multi_questionArray(AnswerIndex).Replace("Answer1:", "").Trim()
                        Dim Answer2Index As Integer = selectedQuestionIndex + 3 'Answer2 always three indexes after name index
                        editAnswer2 = multi_questionArray(Answer2Index).Replace("Answer2:", "").Trim()
                        Dim Answer3Index As Integer = selectedQuestionIndex + 4 'Answer3 always four indexes after name index
                        editAnswer3 = multi_questionArray(Answer3Index).Replace("Answer3:", "").Trim()
                        Dim Answer4Index As Integer = selectedQuestionIndex + 5 'Answer4 always five indexes after name index
                        editAnswer4 = multi_questionArray(Answer4Index).Replace("Answer4:", "").Trim()
                        Dim TagIndex As Integer = selectedQuestionIndex + 6 'Tag always six indexes after name index
                        editTag = multi_questionArray(TagIndex).Replace("Tag:", "").Trim()
                        Dim ScoreIndex As Integer = selectedQuestionIndex + 7 'Score always seven indexes after name index
                        Dim score As String = multi_questionArray(ScoreIndex).Replace("Score:", "").Trim()
                        Dim CorrectAnswerIndex As Integer = selectedQuestionIndex + 8 'Correct answer always eight indexes after name index
                        editCorrectAnswer = multi_questionArray(CorrectAnswerIndex).Replace("CorrectAnswer:", "").Trim()
                        lblQuestionSelected.Text = $"Question selected: {question}"
                        lblScore.Text = $"Times incorrect: {score}"
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        'Clears and refills listbox with questions stored
        lstQuestions.Items.Clear()

        If File.Exists(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Questions.txt")) Then
            For Each question As String In CreateQuestionArray()
                If question.Contains("Name:") Then
                    Dim temp As String = question.Replace("Name:", "").Trim()
                    lstQuestions.Items.Add(temp)
                End If
            Next
        End If
        If File.Exists(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "MultiQuestions.txt")) Then
            For Each question As String In CreateMultiQuestionArray()
                If question.Contains("Name:") Then
                    Dim temp As String = question.Replace("Name:", "").Trim()
                    lstQuestions.Items.Add(temp)
                End If
            Next
        End If
    End Sub

    Private Sub SortToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SortToolStripMenuItem.Click
        Dim sortList As New List(Of String)() 'List temporarily stores array values so that it can be sorted

        For Each question As String In CreateQuestionArray()
            If question.Contains("Name:") Then 'Puts name values from array into list
                Dim temp As String = question.Replace("Name:", "").Trim()
                sortList.Add(temp)
            End If
        Next

        For Each question As String In CreateMultiQuestionArray()
            If question.Contains("Name:") Then 'Puts name values from multiple choice array into list
                Dim temp As String = question.Replace("Name:", "").Trim()
                sortList.Add(temp)
            End If
        Next

        sortList.Sort() 'Sorts alphabetically
        lstQuestions.Items.Clear()

        For Each item In sortList 'Adds sorted items into the listbox
            lstQuestions.Items.Add(item)
        Next
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        MsgBox("Unfortunately this feature was impossible to test due to the error of 'the file is being used by another application' always showing up no matter what I did, and it seems unrelated to the code. I even tried it on a separate device. Please look at the code yourself to understand the working behind it.")
        Dim confirmation As DialogResult = MsgBox("Are you sure you want to delete the selected question?", vbYesNo, "Delete question")
        If confirmation = DialogResult.Yes Then 'If user says yes
            Try
                Dim questionArray As String() = CreateQuestionArray()
                Dim multi_questionArray As String() = CreateMultiQuestionArray()
                If lstQuestions.SelectedItem <> Nothing Then
                    Dim selectedQuestion As String = lstQuestions.SelectedItem.ToString()

                    Dim selectedQuestionIndex As Integer = Array.FindIndex(questionArray, Function(question) question.Contains(selectedQuestion)) 'Find the question's index in the array

                    If selectedQuestionIndex >= 0 AndAlso selectedQuestionIndex + 1 < questionArray.Length Then 'Checks if it is a valid index value
                        'Set up indexes for following values
                        Dim QuestionIndex As Integer = selectedQuestionIndex + 1
                        Dim AnswerIndex As Integer = selectedQuestionIndex + 2
                        Dim TagIndex As Integer = selectedQuestionIndex + 3
                        Dim ScoreIndex As Integer = selectedQuestionIndex + 4
                        If File.Exists(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Questions.txt")) Then
                            Using objWriter As StreamWriter = File.CreateText(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Questions.txt"))
                                'Clears existing value in array
                                objWriter.WriteLine(questionArray(selectedQuestionIndex))
                                objWriter.WriteLine(questionArray(QuestionIndex))
                                objWriter.WriteLine(questionArray(AnswerIndex))
                                objWriter.WriteLine(questionArray(TagIndex))
                                objWriter.WriteLine(questionArray(ScoreIndex))
                            End Using
                            MessageBox.Show("Question deleted successfully.")
                        Else
                            MessageBox.Show("An error occurred whilst trying to delete the file, please try again.")
                        End If
                    End If

                    'If it does not exist in the short answer question array, check the multiple choice question array
                    If selectedQuestionIndex >= 0 Then
                        selectedQuestionIndex = Array.FindIndex(multi_questionArray, Function(question) question.Contains(selectedQuestion)) 'Finds the question's index in the multiple choice array
                        If selectedQuestionIndex >= 0 AndAlso selectedQuestionIndex + 1 < multi_questionArray.Length Then 'Checks if it is a valid index value
                            Dim QuestionIndex As Integer = selectedQuestionIndex + 1
                            Dim AnswerIndex As Integer = selectedQuestionIndex + 2
                            Dim Answer2Index As Integer = selectedQuestionIndex + 3
                            Dim Answer3Index As Integer = selectedQuestionIndex + 4
                            Dim Answer4Index As Integer = selectedQuestionIndex + 5
                            Dim TagIndex As Integer = selectedQuestionIndex + 6
                            Dim ScoreIndex As Integer = selectedQuestionIndex + 7
                            Dim CorrectAnswerIndex As Integer = selectedQuestionIndex + 8
                            If File.Exists(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "MultiQuestions.txt")) Then
                                Using objWriter As StreamWriter = File.CreateText(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Questions.txt"))
                                    'Clears existing value in array
                                    objWriter.WriteLine(questionArray(selectedQuestionIndex))
                                    objWriter.WriteLine(questionArray(QuestionIndex))
                                    objWriter.WriteLine(questionArray(AnswerIndex))
                                    objWriter.WriteLine(questionArray(Answer2Index))
                                    objWriter.WriteLine(questionArray(Answer3Index))
                                    objWriter.WriteLine(questionArray(Answer4Index))
                                    objWriter.WriteLine(questionArray(TagIndex))
                                    objWriter.WriteLine(questionArray(ScoreIndex))
                                    objWriter.WriteLine(questionArray(CorrectAnswerIndex))
                                End Using
                                MessageBox.Show("Question deleted successfully.")
                            Else
                                MessageBox.Show("An error occurred whilst trying to delete the file, please try again.")
                            End If
                        End If
                    End If
                Else
                    MsgBox("No question is selected.")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Public Function openfile(Optional location = "C:\", Optional type = "All files (*.*)|*.*|All files (*.*)|*.*")
        Dim fd As New OpenFileDialog With {
            .Title = "Open file",
            .InitialDirectory = location
        }
        If fd.ShowDialog() = DialogResult.OK Then
            Return fd.FileName 'File name is returned, working the same way as the old variables did
        Else
            Return Nothing
        End If
    End Function

    Private Sub OpenOnBootToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenOnBootToolStripMenuItem.Click
        MsgBox("This code does work as long as you have administrator permissions and give the correct file path to the exe.")
        Dim confirmation As DialogResult = MsgBox("Would you like the program to open up on boot?", vbYesNo)
        If confirmation = DialogResult.Yes Then
            Try
                Dim programPath As String = openfile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Executable files|*.exe") 'Input file path of solution exe
                If File.Exists(programPath) Then
                    'Courtesy of https://www.codeproject.com/questions/253297/want-to-make-vb-net-application-run-at-startup-whe
                    Dim regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True) 'Sets registry key in the run folder where programs set in there open up on boot
                    regKey.SetValue("Study Application", programPath)

                    regKey.Close()
                    MsgBox("The program will now automatically open up on boot. If you wish to revert this change, please click the 'Remove auto-boot' menu strip item.")
                Else
                    MsgBox("Invalid file path.")
                End If
            Catch ex As Exception
                MsgBox("Operation failed, please ensure you are running the program in administrator mode.")
            End Try
        End If
    End Sub

    Private Sub RemoveAutobootToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveAutobootToolStripMenuItem.Click
        Dim confirmation As DialogResult = MsgBox("Would you like to remove the auto-boot?", vbYesNo)
        Try
            If confirmation = DialogResult.Yes Then
                Dim regKey As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                regKey.DeleteValue("Study Application", False) 'Removes previously set registry key

                regKey.Close()

                MsgBox("The program has been removed from startup.")
            End If
        Catch ex As Exception
            MsgBox("Operation failed, please ensure you are running the program in administrator mode.")
        End Try
    End Sub

    Private Sub DeleteALLQuestionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteALLQuestionsToolStripMenuItem.Click
        Try
            MsgBox("I have confirmed during testing that this delete function DOES WORK, but the error 'file is being used by another application' still often appears. You might need a program like LockHunter to test this function out properly. If you need to see proof of it working, please contact me.")
            Dim confirmation As DialogResult = MsgBox("Are you sure you wish to delete ALL questions? This action CANNOT be undone.", vbYesNo, "Delete ALL questions")
            If confirmation = DialogResult.Yes Then
                If File.Exists(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Questions.txt")) = True Then
                    My.Computer.FileSystem.DeleteFile(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Questions.txt")) 'Deletes short answer questions file
                End If
                If File.Exists(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "MultiQuestions.txt")) = True Then
                    My.Computer.FileSystem.DeleteFile(Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "MultiQuestions.txt")) 'Deletes multiple choice questions file
                End If
            End If
            MsgBox("The questions have successfully been deleted.")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click
        Dim confirmation As DialogResult = MsgBox("Export the saved questions into a test? This will replace an already existing exported test.", vbYesNo, "Export")
        Try
            If confirmation = DialogResult.Yes Then
                Dim questionArray As String() = CreateQuestionArray()
                Dim multi_questionArray As String() = CreateMultiQuestionArray()
                Dim filePath As String = Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Exported Test.txt")
                If File.Exists(filePath) = False Then 'If the file does not exist already, make it
                    File.Create(filePath).Dispose()
                End If
                If File.Exists(filePath) Then
                    Using objWriter As StreamWriter = File.CreateText(filePath) 'Overwrites existing text
                        For Each questionEntry As String In questionArray
                            If questionEntry.Contains("Question:") Then 'Looks for questions stored in the array
                                'Prints as test format
                                Dim question As String = questionEntry.Replace("Question:", "").Trim()
                                objWriter.WriteLine($"Question: {question}")
                                objWriter.WriteLine("Answer:")
                                objWriter.WriteLine() 'Creates newline to separate the questions
                            End If
                        Next

                        For Each multiQuestionEntry As String In multi_questionArray
                            If multiQuestionEntry.Contains("Question:") Then
                                'Same as above but prints the multiple choice questions as well after setting the index values
                                Dim selectedQuestion As String = multiQuestionEntry.Replace("Question:", "").Trim()
                                objWriter.WriteLine($"Question: {selectedQuestion}")
                                objWriter.WriteLine("Answers:")
                                Dim selectedQuestionIndex As Integer = Array.FindIndex(multi_questionArray, Function(question) question.Contains(selectedQuestion))
                                Dim AnswerIndex As Integer = selectedQuestionIndex + 1
                                Dim Answer2Index As Integer = selectedQuestionIndex + 2
                                Dim Answer3Index As Integer = selectedQuestionIndex + 3
                                Dim Answer4Index As Integer = selectedQuestionIndex + 4
                                Dim answer1 As String = multi_questionArray(AnswerIndex).Replace("Answer1:", "").Trim()
                                Dim answer2 As String = multi_questionArray(Answer2Index).Replace("Answer2:", "").Trim()
                                Dim answer3 As String = multi_questionArray(Answer3Index).Replace("Answer3:", "").Trim()
                                Dim answer4 As String = multi_questionArray(Answer4Index).Replace("Answer4:", "").Trim()
                                objWriter.WriteLine($"A {answer1}")
                                objWriter.WriteLine($"B {answer2}")
                                objWriter.WriteLine($"C {answer3}")
                                objWriter.WriteLine($"D {answer4}")
                                objWriter.WriteLine()
                            End If
                        Next
                    End Using
                    MsgBox("Test saved successfully.")
                Else
                    MsgBox("Export failed, please try again.")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
