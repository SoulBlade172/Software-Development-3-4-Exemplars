Imports System.IO
Public Class frm1
    Public Function openfile(Optional location = "C:\", Optional type = "All files (*.*)|*.*|All files (*.*)|*.*")
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Open file"
        fd.InitialDirectory = location
        fd.Filter = type
        If fd.ShowDialog() = DialogResult.OK Then
            Return fd.FileName
        Else Return Nothing
        End If
    End Function
    Public Sub savefile(text, Optional location = "C:\", Optional type = "All files (*.*)|*.*|All files (*.*)|*.*")
        Dim sd As New SaveFileDialog()
        sd.Filter = type
        sd.Title = "Save file"
        sd.FileName = text.split(" ")(0)
        sd.InitialDirectory = location
        If sd.ShowDialog() = DialogResult.OK Then
            Dim writer As StreamWriter = New StreamWriter(sd.OpenFile())
            If writer IsNot Nothing Then
                writer.WriteLine(text)
                writer.Close()
            End If
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As String = openfile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Text files|*.txt")
        Dim filename = file.Split("\")(file.Split("\").Length - 1).Split(".")(0)
        Me.lblfilename.Text = filename
        lbleditor.Text = $"Editing {filename}"
        If System.IO.File.Exists(file) Then
            Dim reader As New StreamReader(file)
            txtcontent.Text = reader.ReadToEnd
            txtediter.Text = txtcontent.Text
            reader.Close()
        Else MessageBox.Show("does not exist")
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        savefile(txtediter.Text, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Text files|*.txt")
    End Sub
End Class
