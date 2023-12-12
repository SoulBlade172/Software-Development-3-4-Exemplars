Imports System.IO
Imports System.Xml
Public Class frm1
    Public Function openfile(Optional location As String = "C:\", Optional type As String = "All files (*.*)|*.*|All files (*.*)|*.*") As String
        Dim fd As OpenFileDialog = New OpenFileDialog()
        fd.Title = "Open file"
        fd.InitialDirectory = location
        fd.Filter = type
        If fd.ShowDialog() = DialogResult.OK Then
            Return fd.FileName
        Else
            Return Nothing
        End If
    End Function
    Private Sub open(sender As Object, e As EventArgs) Handles btnopen.Click
        Dim file As String = openfile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "XML Files|*.xml")
        Dim data As New DataSet
        Try
            data.ReadXml(file)
            DataGridView1.DataSource = data.Tables(0)
            cmbcolumns.Items.Clear()
            updatecombobox()
        Catch ex As Exception
            DataGridView1.DataSource = Nothing
            showmsg("wrong file format", 120, 1)
        End Try
        showmsg("file opened", 120)
    End Sub
    Private Sub save(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim sd As New SaveFileDialog()
        sd.Filter = "XML Files|*.xml"
        sd.Title = "Save DataGridView data as XML file"
        sd.ShowDialog()
        If sd.FileName <> "" Then
            Dim data As DataTable = DirectCast(DataGridView1.DataSource, DataTable)
            data.WriteXml(sd.FileName)
        End If
        'Dim data As DataTable = Nothing
        'DataGridView1.DataSource = DataTable
        'If TypeOf DataGridView1.DataSource Is DataTable Then
        '    data = DirectCast(DataGridView1.DataSource, DataTable)
        'End If
        'If data IsNot Nothing Then
        '    data.WriteXml(sd.FileName)
        'End If
        showmsg("file saved", 120)
    End Sub
    Private Sub addcolumn(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim column As New DataGridViewTextBoxColumn(), text = txtaddinput.Text, exists = False
        If text <> "" Then
            For Each i As DataGridViewColumn In DataGridView1.Columns
                If i.HeaderText = text Then
                    exists = True
                    showmsg("already exists", 120, 1)
                End If
            Next
            If Not exists Then
                column.HeaderText = text
                column.Name = text
                DataGridView1.Columns.Add(column)
                cmbcolumns.Items.Add(text)
                showmsg($"{txtupdatename.Text} column added to datagrid", 120)
            End If
        Else
            showmsg("enter value", 120, 1)
        End If
    End Sub
    Private Sub clear(sender As Object, e As EventArgs) Handles btnclear.Click, btnnew.Click
        DataGridView1.Columns.Clear()
        cmbcolumns.Items.Clear()
        showmsg("cleared", 120)
    End Sub
    Private Sub formsizechanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        DataGridView1.Height = Me.Height - 80
        DataGridView1.Width = Me.Width - 350
    End Sub
    Private Sub updatecolumn(sender As Object, e As EventArgs) Handles btnupdate.Click
        If cmbcolumns.Text <> "" Then
            Try
                DataGridView1.Columns(cmbcolumns.SelectedIndex).HeaderText = txtupdatename.Text
                Dim index = cmbcolumns.Items.IndexOf(cmbcolumns.Text)
                cmbcolumns.Items(index) = txtupdatename.Text
                showmsg($"{txtupdatename.Text} column updated to datagrid", 120)

            Catch ex As Exception
                Console.WriteLine(ex)
                showmsg("an error occured", 120, 1)
            End Try
        End If
    End Sub
    Public Sub updatecombobox()
        Dim length = DataGridView1.Columns.Count - 1
        If length > -1 Then
            For i = 0 To DataGridView1.Columns.Count - 1
                cmbcolumns.Items.Add(DataGridView1.Columns(i).HeaderText)
            Next
        End If
    End Sub
    Private Sub frm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Height = Me.Height - 80
        DataGridView1.Width = Me.Width - 350
        cmbcolumns.DropDownStyle = ComboBoxStyle.DropDownList
        Timer1.Start()
        Timer1.Interval = 1
        lblmessage.ForeColor = Color.White
    End Sub
    Dim tick = 0, sec = 0, timeout = -1
    Private Sub newfile(sender As Object, e As EventArgs) Handles btnnew.Click
        Dim xml As XmlWriter = XmlWriter.Create(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "new file.xml"))
        xml.WriteStartDocument()
        xml.WriteStartElement("head")
        xml.WriteAttributeString("title", "text")
        ' xml.WriteElementString("div", "div")
        xml.WriteEndElement()
        xml.Close()
        Dim data As New DataSet
        data.ReadXml(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "new file.xml"))
        DataGridView1.DataSource = data.Tables(0)
        cmbcolumns.Items.Clear()
        updatecombobox()
        showmsg("new file created", 120)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tick += 1
        If tick Mod 60 = 0 Then sec += 1
        If tick = timeout Then lblmessage.Text = ""
    End Sub
    Public Sub showmsg(text As String, time As Integer, Optional colour As Integer = 0)
        Dim colors = {Color.Green, Color.Red, Color.Blue}
        timeout = tick + time
        lblmessage.Text = text
        lblmessage.ForeColor = colors(colour)
    End Sub
End Class

