Imports System.IO

'Date of creation - 28/05/23
'Creator - SoulBlade172
'The purpose of this form is to allow the user to search through the questions they have added
Public Class frmSearch
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        lstResults.Items.Clear() 'Clears list so duplicate entries do not appear
        Dim bFound As Boolean 'Boolean to check if a result was found or not
        Dim searchList As New List(Of String)() 'Stores values into a list so it can be searched through

        Try
            If txtSearch.Text <> Nothing Then
                If optName.Checked = True Then 'If the user is searching by name
                    For Each question As String In CreateQuestionArray()
                        If question.Contains("Name:") Then 'Adds all of the name values in the array into the search list
                            Dim temp As String = question.Replace("Name:", "").Trim()
                            searchList.Add(temp)
                        End If
                    Next
                    For Each question As String In CreateMultiQuestionArray()
                        If question.Contains("Name:") Then 'Same as above but from the multiple choice question array
                            Dim temp As String = question.Replace("Name:", "").Trim()
                            searchList.Add(temp)
                        End If
                    Next
                    For Each searchItem As String In searchList
                        If searchItem.Contains(txtSearch.Text) Then 'Linear search for the term in the text box, linear search used as it works best with text searching
                            bFound = True
                            lstResults.Items.Add(searchItem.Replace("Name:", "")) 'Adds names to the list box if they contain the search term
                        End If
                    Next
                ElseIf optTag.Checked = True Then 'If searching by tags
                    If cbxTagSearch.Text <> Nothing Then
                        Dim arr As String() = CreateQuestionArray()
                        Dim multiArr As String() = CreateMultiQuestionArray()
                        For i As Integer = 0 To UBound(arr)
                            If arr(i).Contains("Tag:") Then 'Checks for the tags in the array
                                Dim tagIndex As Integer = i
                                Dim nameIndex As Integer = tagIndex - 3 'Name three indexes before
                                Dim name As String = arr(nameIndex).Replace("Name:", "").Trim()
                                Dim tag As String = arr(tagIndex).Replace("Tag:", "").Trim()
                                Dim temp As String = $"{tag} - {name}" 'Puts them together so that it can be searched by tag and the name pops up
                                searchList.Add(temp)
                            End If
                        Next
                        For i As Integer = 0 To UBound(multiArr) 'Same as above but for the multiple choice question array
                            If multiArr(i).Contains("Tag:") Then
                                Dim tagIndex As Integer = i
                                Dim nameIndex As Integer = tagIndex - 6
                                Dim name As String = multiArr(nameIndex).Replace("Name:", "").Trim()
                                Dim tag As String = multiArr(tagIndex).Replace("Tag:", "").Trim()
                                Dim temp As String = $"{tag} - {name}"
                                searchList.Add(temp)
                            End If
                        Next
                        For Each searchItem As String In searchList 'Checks the items in the list and if it contains the tag selected, remove the tag from the variable and add the name to the list box
                            If searchItem.Contains(cbxTagSearch.Text) Then
                                bFound = True
                                lstResults.Items.Add(searchItem.Replace($"{cbxTagSearch.Text} - ", ""))
                            End If
                        Next
                    End If
                Else
                    MsgBox("No matching questions found with the search criteria.")
                End If
                If bFound = False Then 'If nothing was found
                    MsgBox("No matching questions found with the search criteria.")
                End If
            Else
                MsgBox("No matching questions found with the search criteria.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub frmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateTags(filepath:=Path.Combine(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Tags.txt"), cbxTagSearch)
        If optName.Checked = True Then 'Reveals appropriate controls depending on what search mode the user has selected
            lblSearchTerm.Visible = True
            txtSearch.Visible = True
            lblTagSearch.Visible = False
            cbxTagSearch.Visible = False
        ElseIf optTag.Checked = True Then
            lblSearchTerm.Visible = False
            txtSearch.Visible = False
            lblTagSearch.Visible = True
            cbxTagSearch.Visible = True
        End If
    End Sub

    Private Sub optName_CheckedChanged(sender As Object, e As EventArgs) Handles optName.CheckedChanged
        If optName.Checked = True Then 'Reveals appropriate controls depending on what search mode the user has selected
            lblSearchTerm.Visible = True
            txtSearch.Visible = True
            lblTagSearch.Visible = False
            cbxTagSearch.Visible = False
        ElseIf optTag.Checked = True Then
            lblSearchTerm.Visible = False
            txtSearch.Visible = False
            lblTagSearch.Visible = True
            cbxTagSearch.Visible = True
        End If
    End Sub

    Private Sub optTag_CheckedChanged(sender As Object, e As EventArgs) Handles optTag.CheckedChanged
        If optName.Checked = True Then 'Reveals appropriate controls depending on what search mode the user has selected
            lblSearchTerm.Visible = True
            txtSearch.Visible = True
            lblTagSearch.Visible = False
            cbxTagSearch.Visible = False
        ElseIf optTag.Checked = True Then
            lblSearchTerm.Visible = False
            txtSearch.Visible = False
            lblTagSearch.Visible = True
            cbxTagSearch.Visible = True
        End If
    End Sub
End Class