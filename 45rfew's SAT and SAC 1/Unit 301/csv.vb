Imports System.IO
Imports System.Text
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Clear()
        Dim file = "Book1.csv"
        Try
            Dim reader As New StreamReader(file), line = reader.ReadLine, col = line.Split(","), cols = col.Length - 1, r = 0
            If DataGridView1.Rows.Count = 0 Then
                For i = 0 To cols
                    Dim column As New DataGridViewTextBoxColumn() With {.HeaderText = col(i), .Name = col(i).ToLower()}
                    DataGridView1.Columns.Add(column)
                Next
            End If
            While True
                line = reader.ReadLine
                If line = Nothing Then Exit While
                Dim items = line.Split(",")
                DataGridView1.Rows.Add()
                For i = 0 To cols
                    DataGridView1.Rows(r).Cells(i).Value = items(i)
                Next
                r += 1
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("an error occurred")
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim found = False
        If TextBox1.Text <> Nothing Then
            For Each row As DataGridViewRow In DataGridView1.Rows
                If row.Cells.Item("name").Value = TextBox1.Text Then
                    MessageBox.Show($"{row.Cells.Item("name").Value} has a percentage of {row.Cells("percentage").Value}%")
                    found = True
                    Exit For
                End If
            Next
        Else MessageBox.Show("input a value")
        End If
        If Not found And TextBox1.Text <> Nothing Then
            TextBox1.Text = ""
            MessageBox.Show("not found")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim file = "Book1.csv"
        Try
            Dim writer As New StreamWriter(file, True)
            Dim arr = {"", "", "", ""}
            Dim newarr = TextBox2.Text.Split(",")
            For i = 0 To newarr.Length - 1
                If i = arr.Length Then Exit For
                arr(i) = newarr(i)
            Next
            If newarr.Length >= DataGridView1.Columns.Count - 1 Then
                Dim newrow = String.Join(",", arr)
                writer.WriteLine(newrow)
                writer.Close()
                MessageBox.Show("written to file")
            Else MessageBox.Show($"enter in {DataGridView1.Columns.Count} values seperated by commas")
            End If
        Catch ex As Exception
            MessageBox.Show("an error occurred")
        End Try
    End Sub
End Class
