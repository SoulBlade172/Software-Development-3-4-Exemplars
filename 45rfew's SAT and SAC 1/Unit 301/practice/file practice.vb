Imports System.IO
Imports System.txt
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file = "text.txt"
        Dim reader As New StreamReader(file)
        RichTextBox1.Text = reader.ReadToEnd
        reader.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim file = "text.txt"
        Dim writer As New StreamWriter(file, True)
        writer.WriteLine(RichTextBox2.Text)
        writer.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sd As New SaveFileDialog() With {.Filter = "text files|*.txt"}
        If sd.ShowDialog = DialogResult.OK Then
            Dim writer As New StreamWriter(sd.FileName)
            writer.Write(RichTextBox3.Text)
            writer.Close()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim od As New OpenFileDialog() With {.Filter = "text files|*.txt"}
        If od.ShowDialog = DialogResult.OK Then
            Dim reader As New StreamReader(od.FileName)
            RichTextBox4.Text = reader.ReadToEnd
            reader.Close()
        End If
    End Sub


    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim file = "text.txt"
    '    Dim reader As New StreamReader(file)
    '    RichTextBox1.Text = reader.ReadToEnd
    '    reader.Close()
    'End Sub
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button3.Click
    '    Dim file = "text.txt"
    '    Dim writer As New StreamWriter(file, True)
    '    writer.WriteLine(RichTextBox2.Text)
    '    writer.Close()
    'End Sub
    'Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
    '    Dim sd As New SaveFileDialog() With {.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), .Filter = "text files|*.txt", .Title = "save file as", .FileName = "new file"}
    '    If sd.ShowDialog = DialogResult.OK Then
    '        Dim text = RichTextBox3.Text
    '        Dim writer As New StreamWriter(sd.OpenFile)
    '        writer.WriteLine(text)
    '        writer.Close()
    '    End If
    'End Sub
    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    Dim od As New OpenFileDialog() With {.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), .Title = "open file", .Filter = "text files|*.txt"}
    '    If od.ShowDialog = DialogResult.OK Then
    '        Dim reader As New StreamReader(od.FileName)
    '        RichTextBox4.Text = reader.ReadToEnd()
    '        reader.Close()
    '    End If
    'End Sub
End Class
