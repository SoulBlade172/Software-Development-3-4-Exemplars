Imports System.Xml
Imports System.IO
Public Class Form1
    Dim xwriter As XmlWriterSettings = New XmlWriterSettings() With {.Indent = True}
    Dim writer As XmlWriter = XmlWriter.Create("authors.xml", xwriter)
    Dim labels = {"code", "fname", "lname"},
            elements = {{"1", "2", "3", "4", "5"},
            {"black", "tony", "lee", "jordan", "jordan"},
            {"widow", "stark", "eckart", "child", "peterson"}}
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            writer.WriteStartDocument()
            writer.WriteStartElement("authors")
            For j = 0 To elements.GetLength(1) - 1
                writer.WriteStartElement("author")
                For i = 0 To labels.Length - 1
                    If i = 0 Then
                        writer.WriteAttributeString(labels(i), elements(i, j))
                    Else
                        writer.WriteElementString(labels(i), elements(i, j))
                    End If
                Next
                writer.WriteEndElement()
            Next
            writer.WriteEndElement()
            writer.WriteEndDocument()
            writer.Flush()
            writer.Close()
            MessageBox.Show("file created in project debug folder")
            Try
                Dim xml As XmlDocument = New XmlDocument(), nodelist As XmlNodeList
                xml.Load("authors.xml")
                nodelist = xml.GetElementsByTagName("author")
                ListBox1.Items.Clear()
                For Each nodes In nodelist
                    Dim name = nodes.item(labels(1)).innertext
                    Dim lname = nodes.item(labels(2)).innertext
                    ListBox1.Items.Add(name)
                    ListBox1.Items.Add(lname)
                Next
            Catch ex As Exception
                MessageBox.Show("could not show file")
            End Try
        Catch ex As Exception
            MessageBox.Show("an error occurred")
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text <> "" AndAlso TextBox2.Text <> "" Then
            Try
                writer = XmlWriter.Create("authors.xml", xwriter)
                writer.WriteStartElement("author")
                createrec(TextBox1.Text.ToString, TextBox2.Text.ToString)
                writer.WriteEndElement()
                writer.WriteEndDocument()
                writer.Close()
                MessageBox.Show("appended to file")
            Catch ex As Exception
                MessageBox.Show("an error occurred")
            End Try
        Else
            MessageBox.Show("enter values")
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim xml As New XmlDocument
            xml.Load("authors.xml")
            Dim nodelist As XmlNodeList = xml.GetElementsByTagName("author")
            Dim search = TextBox3.Text.ToString()
            Dim found = False
            For Each nodes In nodelist
                If search = nodes("fname").InnerText.ToString() Then
                    MessageBox.Show($"{nodes("fname").InnerText} {nodes("lname").InnerText}")
                    found = True
                    Exit For

                End If
                If found = False Then MessageBox.Show("not found")
            Next
        Catch ex As Exception
            MessageBox.Show("an error occurred")
        End Try
    End Sub
    Public Sub createrec(name, lname)
        writer.WriteStartElement("author")
        writer.WriteAttributeString("code", "0")
        writer.WriteElementString("fname", name)
        writer.WriteElementString("lname", lname)
        writer.WriteEndElement()
        ListBox1.Items.Add(name)
        ListBox1.Items.Add(lname)
    End Sub
End Class
