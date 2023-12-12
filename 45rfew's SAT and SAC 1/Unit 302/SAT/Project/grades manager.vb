'Author: 45rfew
'Created: 22/5/23
'Version: 0.7.4
'Purpose: Main screen for the grades manager solution 
'Changelog: 
' 31/5/23 - VERSION 0.0.1
' - Mostly completed save functionality 
' - Added create new class function 
' 3/6/23 - VERSION 0.0.2
' - Improved save functionalities; more robust 
' - Auto resizes tabcontrol 
' - Implemented functionality for opening (importing) classes 
' - Added functions to sort data 
' 10/6/2023 - VERSION 0.5.3
' - Save function now appends to file instead of creating new one
' - Added save as function
' - Search form closes itself when a new form is created or imported 
' - Added and completed delete class function 
' - Added search function 
' - New classes 'searches' and 'files'; contains related respective functions/subs 
' - When saving a class it is checked whether it has already been saved to a file previously; appends if so; if not creates a new one
' - Code optimizations 
' - Many many bug fixes 
' 14/6/2023 - VERSION 0.6.4
' - Can no longer import classes with the same name as an already existing one 
' - Removed message boxes showing up upon canceling a file dialog 
' - Search results within the search form are pushed to a listbox displayed within the form 
' - Validation added for search 
' - All open forms exluding the main form are closed upon switching classes or creating a new class 
' - Filters out _INT identifier when importing files 
' - Comboboxes for search, sort and stats are now cleared and updated upon every form activation 
' - Added stats function; displays stats for choosen column
' - New class 'stats'; contains related respective functions/subs 
' - Added mean, median, mode, range, count, quartile and IQR functions to stat calculations 
' - Validation added for stats; requires the column to contain at least 3 valid values 
' - Even more bug fixes 
' 16/6/2023 - VERSION 0.7.4
' - Added label to main 
' - Added option to change themes 
' - New class 'themes'; contains related respective functions/subs 
' - Added save all function; allows user to save all classes at once 
' 17/6/2023 - VERSION 0.7.4
' - Added internal documentation 
' 18/6/2023 - VERSION 1.0.5 - Initial release 
' Added options to add, delete and rename columns of a class 
' Extra visability when saving classes 
' Added error event handler for datagridviews; no longer uses the system default dialog 
' Feedback upon sorting (or trying to) a column 
' Disallows deleting a column if it is the only one displayed 
' Disallows renaming a column to one that already exists 
' Disallows creating a class with duplicate column names 
' Fixed bug that broke average calculation when working with string integers
' Filters out _INT keyword from all combo boxes 
' Cleaned code
' Bug fixes 

'TODO:
'fix sort - ong impossible 

Imports System.IO, System.Xml
Public Class frmMain
    Private Sub mainLoad(sender As Object, e As EventArgs) Handles MyBase.Load 'sets form size to maximun window size and adjusts main tab control to fit
        WindowState = FormWindowState.Maximized
        tbcMain.Height = Height - 100
        tbcMain.Width = Width - 320
        tmrMain.Interval = 100
        tmrMain.Start()
    End Sub
    Private Sub mainResized(sender As Object, e As EventArgs) Handles Me.SizeChanged 'adjusts tab control size to fit the form when it is resized 
        tbcMain.Height = Height - 100
        tbcMain.Width = Width - 320
    End Sub
    Public Sub tbcMainChanged(sender As Object, e As EventArgs) Handles tbcMain.SelectedIndexChanged 'hides open forms when classes are changed and sets their respective updated flag to 0 
        frmSearch.Hide()
        frmSort.Hide()
        frmStats.Hide()
        frmStats.updated = False
        frmSort.updated = False
        frmSearch.updated = False 'resets updated flags 
        classes.updateCBO() 'updates combobox to display any new or removed columns 
    End Sub
    Private Sub invokeFunc(invoker As Action)
        If classes.init Then invoker.Invoke() Else globalFunctions.echo("Create a class first")
    End Sub
    Private Sub stats(sender As Object, e As EventArgs) Handles mnuStats.Click
        invokeFunc(AddressOf frmStats.Show)
    End Sub
    Private Sub sort(sender As Object, e As EventArgs) Handles mnuSort.Click
        invokeFunc(AddressOf frmSort.Show)
    End Sub
    Private Sub search(sender As Object, e As EventArgs) Handles mnuSearch.Click
        invokeFunc(AddressOf frmSearch.Show)
    End Sub
    Private Sub newClass(sender As Object, e As EventArgs) Handles mnuNew.Click
        frmNew.Show()
    End Sub
    Private Sub delete(sender As Object, e As EventArgs) Handles mnuDelete.Click
        invokeFunc(AddressOf classes.deleteClass)
    End Sub
    Private Sub open(sender As Object, e As EventArgs) Handles mnuOpen.Click
        files.open()
        If classes.getClass IsNot Nothing Then classes.init = 1 'if a class has successfully been imported than the init value is set to 1 
    End Sub
    Private Sub save(sender As Object, e As EventArgs) Handles mnuSave.Click
        If classes.init = 0 Then 'checks if a class has previously been created/imported 
            globalFunctions.echo("Create a class first")
            Exit Sub
        End If
        For Each kvp As KeyValuePair(Of String, Boolean) In classes.classes 'iterate through each value within the dictionary to check if the respective class has been created as an xml file before
            If kvp.Key = tbcMain.SelectedTab.Text AndAlso kvp.Value = False Then
                files.saveAs()
                classes.classes(kvp.Key) = True 'creates new xml file and sets the saved flag of the object to true 
                Exit Sub 'breaks sub 
            Else
                files.save() 'if an xml file for the class already exists appends to that file 
            End If
        Next
    End Sub
    Private Sub saveAs(sender As Object, e As EventArgs) Handles mnuSaveAs.Click
        invokeFunc(AddressOf files.saveAs)
    End Sub
    Private Sub saveAll(sender As Object, e As EventArgs) Handles mnuSaveAll.Click
        invokeFunc(AddressOf files.saveAll)
    End Sub
    Private Sub theme(sender As Object, e As EventArgs) Handles mnuThemes.Click
        frmTheme.Show()
    End Sub
    Private Sub addCol(sender As Object, e As EventArgs) Handles btnAdd.Click
        invokeFunc(AddressOf classes.createCol)
    End Sub
    Private Sub updateCol(sender As Object, e As EventArgs) Handles txtUpdate.Click
        invokeFunc(AddressOf classes.updateCol)
    End Sub
    Private Sub deleteCol(sender As Object, e As EventArgs) Handles btnDelete.Click
        invokeFunc(AddressOf classes.deleteCol)
    End Sub
    Dim tick = 0
    Private Sub tmrMain_Tick(sender As Object, e As EventArgs) Handles tmrMain.Tick
        tick += 1
        If tick Mod 4 = 0 Then themes.applyThemeAll(themes.theme) 'checks and updates themes multiple times per second 
        'TODO: allow theme changing to be auto instead of manually applying 
    End Sub

    'UNUSED CODE:
    Private Sub a() 'an attempt at sorting the class via creating a dictionary and transfering all values into said dictionary, then sorting it within 
        Dim a = classes.getClass()
        a.DefaultCellStyle.ForeColor = Color.Red
        Dim dict As New Dictionary(Of String, String)()
        Dim grid As DataGridView = classes.getClass()
        For Each column As DataGridViewColumn In grid.Columns
            Dim columnName As String = column.Name
            For Each row As DataGridViewRow In grid.Rows
                Dim cellValue As Object = row.Cells(column.Index).Value
                If cellValue IsNot Nothing Then
                    Dim identifier As String = $"R{row.Index}_C{column.Index}"
                    dict.Add($"{columnName} {identifier}", cellValue.ToString())
                End If
            Next
        Next
    End Sub
    Private Sub b() 'attempt to get sorting fully working by creating new integer columns within classes 
        'Dim integerColumn As New DataGridViewColumn(New DataGridViewTextBoxCell())
        'integerColumn.Name = "IntegerColumn"
        'integerColumn.HeaderText = "Integer Column"
        'integerColumn.ValueType = GetType(Integer)
        'Dim a = classes.getClass
        'a.Columns.Add(integerColumn)
        'a.Sort(a.Columns(8), ComponentModel.ListSortDirection.Ascending)
        Dim ass = classes.getClass
        Dim columnIndex As Integer = 2
        ass.Columns.RemoveAt(columnIndex)
        Dim integerColumn As New DataGridViewTextBoxColumn()
        integerColumn.Name = "NewColumn"
        integerColumn.HeaderText = "New Column"
        integerColumn.ValueType = GetType(Integer)
        ass.Columns.Insert(columnIndex, integerColumn)
        Dim a = files.getNumericCol(classes.getClass())
        files.getBlankOrNumericCol(classes.getClass())
        For Each c In a
            MsgBox(c)
        Next
    End Sub
    Private Sub closeForm(sender As Object, e As EventArgs) Handles btnClose.Click
        If MsgBox("Are you sure you want to exit?", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            Close()
            End
        End If
    End Sub
End Class

Public Class globalFunctions 'public class containing all general functions throughout the solution 
    Public Shared Sub echo(msg)
        If TypeOf msg Is String Then MessageBox.Show(msg)
        Console.WriteLine(msg)
    End Sub
    Public Shared Function rand(num)
        Return Math.Floor(Rnd() * num)
    End Function
End Class

Public Class classes 'public class containing all related class function 
    Public Shared init As Integer = 0, init2 As Integer = 0, classes As New Dictionary(Of String, Boolean)(), 'stores names of all classes as key value pairs; with the key being class namme and value being if an xml file of that class exists as a boolean; used for easy iteration through key, value data pairs 
        font = New Font("Arial", 10) 'default font within classes
    Public Shared Function getClass() 'returns the class within the current selected tab in the main tab control 
        Return If(init, frmMain.tbcMain.SelectedTab.Controls.OfType(Of DataGridView)().FirstOrDefault(), Nothing) 'if there is no valid class returns nothing 
    End Function '200iq function ngl 
    Public Shared Function createClass(arr) As Boolean 'creates a new class with the given array of values which are treated as column names
        Dim grid = dataGrid(1)
        grid.DefaultCellStyle.Font = font 'creates an empty datagrid
        Try
            If arr.Length < 2 Then 'breaks if there are 1 or fewer values in the array
                globalFunctions.echo("Enter at least 2 values")
                Return False
            End If
            Dim colNames As New HashSet(Of String)() 'creating a hashset to store column names; hashsets can only store unqiue values meaning duplicate values are removed; list or array works fine but would need to filter them   
            For i = 1 To arr.Length - 1 'iterate through the array skipping the first element which is the class name 
                Dim name As String = arr(i)
                If String.IsNullOrWhiteSpace(name) Then 'check for blank names 
                    globalFunctions.echo("Column name cannot be blank")
                    Return False
                End If
                If colNames.Contains(name) Then 'check for duplicate names 
                    globalFunctions.echo("All columns must be unique")
                    Return False
                End If
                colNames.Add(name)
            Next
            For i = 1 To arr.Length - 1 'iterate through the array starting from index 1 (skip the class name)
                Dim columnName As String = arr(i)
                If columnName <> "" Then 'checks for empty value
                    If columnName.Split("_INT").Length >= 2 Then 'checks if the array value contains _INT to indicate an integer column
                        Dim col As New DataGridViewColumn(New DataGridViewTextBoxCell()) With {
                        .Name = columnName,
                        .HeaderText = columnName.Split("_INT")(0),
                        .ValueType = GetType(Integer)
                    }
                        grid.Columns.Add(col)
                    Else 'otherwise, creates a regular column
                        Dim col As New DataGridViewColumn(New DataGridViewTextBoxCell()) With {
                        .Name = columnName,
                        .HeaderText = columnName
                    }
                        grid.Columns.Add(col)
                    End If
                End If
            Next
            If grid.Columns.Count > 0 Then grid.Rows.Add("") 'creates a single empty row so data can be entered
            Dim className As String = arr(0).ToString()
            For Each page As TabPage In frmMain.tbcMain.TabPages 'checks if a class already exists with the same name
                Dim tabName As String = page.Text
                If tabName = className Then
                    globalFunctions.echo("Class name already exists")
                    Return False
                End If
            Next
            Dim tab As New TabPage(className) 'the first value within the array is taken as the class name
            tab.Controls.Add(grid)
            frmMain.tbcMain.TabPages.Add(tab)
            frmMain.tbcMain.SelectedTab = tab 'creates a new class and sets the selected tab to it
            classes(className) = False 'adds an entry to the classes dictionary indicating that the newly created class does not have a respective xml file
            If frmSearch.Visible Then frmSearch.Close()
            If Not init Then init = 1
            updateCBO()
            Return True
        Catch ex As Exception
            globalFunctions.echo("Error occurred while creating the class") 'if an error is thrown, display an error message
            Return False
        End Try
    End Function


    Public Shared Sub dummyClass() 'DEBUG function - creates an empty tab page within the main tab control 
        Dim current = getClass()
        If current Is Nothing And init2 = 0 Then
            Dim grid = dataGrid(0)
            grid.DefaultCellStyle.Font = font
            Try
                Dim tab As New TabPage(" ")
                tab.Controls.Add(grid)
                frmMain.tbcMain.TabPages.Add(tab)
                'frmMain.tbcMain.SelectedTab = tab
                init2 = 1
            Catch ex As Exception
                globalFunctions.echo(ex)
            End Try
        End If
    End Sub
    Public Shared Function dataGrid(b00lean) As DataGridView 'returns a new datagrid with specified settings defined by the parameter 
        Dim grid As New DataGridView With {
            .Dock = DockStyle.Fill,
            .AllowUserToAddRows = b00lean,
            .AllowUserToDeleteRows = b00lean,
            .AllowUserToOrderColumns = False,
            .AllowUserToResizeRows = b00lean,
            .AllowUserToResizeColumns = b00lean,
            .BackgroundColor = Color.White
        }
        AddHandler grid.DataError, AddressOf classDataError 'binds the error event to the method classDataError to replace the default error dialog
        Return grid
    End Function
    Private Shared Sub classDataError(sender As Object, e As DataGridViewDataErrorEventArgs) 'definded as private as it is not called elsewhere
        Dim grid = DirectCast(sender, DataGridView) 'binding the sender to type of datagridview 
        If grid.CurrentCell IsNot Nothing Then
            grid.CurrentCell.Value = DBNull.Value ' clear the cell where the error occurred and cancel any edits
            grid.CancelEdit()
        End If
        globalFunctions.echo("Enter a valid integer value")
        'e.ThrowException = False 
    End Sub
    Public Shared Sub deleteClass() 'deletes the current selected class 
        If init = 0 Then
            globalFunctions.echo("Create a class first")
            Exit Sub
        End If
        If MsgBox($"Are you sure you want to delete class {frmMain.tbcMain.SelectedTab.Text} permanently?", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            frmMain.tbcMain.TabPages.Remove(frmMain.tbcMain.SelectedTab)
        End If
    End Sub
    Public Shared Sub updateCBO() 'updates the main combobox with column names from the selected class 
        Dim grid = getClass(), length = grid.Columns.Count - 1
        If length > -1 Then 'check if there are columnms in the class 
            frmMain.cboCol.Items.Clear()
            For i = 0 To length 'reset the combo box then iterate each column and add their header to the combo box 
                frmMain.cboCol.Items.Add(grid.Columns(i).HeaderText)
            Next
            frmMain.cboCol.SelectedIndex = If(frmMain.cboCol.Items.Count > 0, 0, Nothing) 'set the selected index to the first item if available 
        End If
    End Sub
    Public Shared Sub createCol() 'creates a new column within the class 
        Dim column As New DataGridViewTextBoxColumn(), text = frmMain.txtInput.Text, exists = False, grid = getClass()
        If text = "" Then 'check if the column is blank; breaks if so 
            globalFunctions.echo("Column name cannot be blank")
            Exit Sub
        End If
        For Each i As DataGridViewColumn In grid.Columns 'checks if the column name already exists; breaks if so 
            If i.HeaderText = text Then
                exists = True
                globalFunctions.echo("Column name already exists")
                Exit Sub
            End If
        Next
        If Not exists Then 'creates column if the column name is unique 
            Try
                If text.Split("_INT").Length >= 2 Then 'checks if input value contains _INT to indicate an integer column 
                    Dim col As New DataGridViewColumn(New DataGridViewTextBoxCell()) With {
                        .Name = text,
                        .HeaderText = text.Split("_INT")(0),
                        .ValueType = GetType(Integer)
                    }
                    grid.Columns.Add(col)
                Else 'otherwise creates a regular column 
                    column.HeaderText = text
                    column.Name = text
                    grid.Columns.Add(column)
                    frmMain.cboCol.Items.Add(text)
                    frmMain.txtInput.Text = ""
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Public Shared Sub deleteCol() 'deletes the colummn from the class 
        Dim grid = getClass()
        If grid IsNot Nothing AndAlso grid.SelectedCells.Count > 0 Then 'check if the class and selected cells exist 
            Dim colIndex = frmMain.cboCol.SelectedIndex, text = frmMain.cboCol.Items(colIndex)
            If grid.Columns.Count > 1 Then 'check if theres at least one column 
                If MsgBox($"Are you sure you want to delete {text}?", MsgBoxStyle.YesNo, "Delete Column") = MsgBoxResult.Yes Then
                    grid.Columns.RemoveAt(colIndex) 'removes column and updates the combo box 
                    updateCBO()
                End If
            Else globalFunctions.echo("Class must have at least 1 column")
            End If
        End If
    End Sub
    Public Shared Sub updateCol() 'updates the header text of a column 
        Dim grid = getClass()
        If frmMain.cboCol.Text <> "" Then 'check if a column is selected 
            Try
                Dim colIndex = frmMain.cboCol.SelectedIndex,
                newHeader = frmMain.txtUpdateInput.Text, 'get the index of selected column and header text 
                colExists = False
                If String.Equals(grid.Columns(colIndex).HeaderText, newHeader, StringComparison.OrdinalIgnoreCase) Then 'check if new header is different from current one 
                    colExists = True
                    frmMain.txtUpdateInput.Text = ""
                    globalFunctions.echo("Column name already exists") 'throws error message if it is the same and breaks 
                    Exit Sub
                End If
                For i = 0 To grid.Columns.Count - 1 'iterate through class columns and check if new header already exists 
                    If i <> colIndex AndAlso String.Equals(grid.Columns(i).HeaderText, newHeader, StringComparison.OrdinalIgnoreCase) Then
                        colExists = True
                        Exit For
                    End If
                Next
                If Not colExists Then 'if the new header doesn't exist update 
                    grid.Columns(colIndex).HeaderText = newHeader
                    Dim index = frmMain.cboCol.Items.IndexOf(frmMain.cboCol.Text)
                    frmMain.cboCol.Items(index) = newHeader 'updates header text of selected column and updates the main combo box 
                    frmMain.txtUpdateInput.Text = ""
                Else
                    globalFunctions.echo("Column name already exists") 'returns an error message and clears input box 
                    frmMain.txtUpdateInput.Text = ""
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class

Public Class files 'public class containing all file related functions 
    Public Shared Sub save() 'appends data within a class to an xml file 
        Dim grid As DataGridView = classes.getClass(), 'gets the current selected class within the tab control 
            xml As New XmlDocument(), parent As XmlElement, path As String = filePath(), 'finds the file path for the xml file 
        exists As Boolean = File.Exists(path)
        If exists Then 'loads existing file 
            xml.Load(path)
            parent = xml.DocumentElement
        Else 'if there isn't one creates a new file 
            parent = xml.CreateElement(frmMain.tbcMain.SelectedTab.Text.Replace(" ", ""))
        End If
        If exists Then 'removes existing data if file exists
            parent.RemoveAll()
        End If
        For Each row As DataGridViewRow In grid.Rows 'iterate through each row in the class 
            Dim rowE As XmlElement = xml.CreateElement("row")
            For Each cell As DataGridViewCell In row.Cells 'iterate through each cell 
                Dim cName As String = grid.Columns(cell.ColumnIndex).Name
                Dim cellV As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "") 'gets the value of the cell; if nothing sets as a blank 
                Dim cellE As XmlElement = xml.CreateElement(cName.Replace(" ", "")) 'creates a new xml element for the cell 
                cellE.InnerText = cellV
                rowE.AppendChild(cellE) 'append cell element to row element 
            Next
            parent.AppendChild(rowE) 'append row element to root element 
        Next
        xml.AppendChild(parent) 'append root element to xml doc  
        Dim sfd As New SaveFileDialog With {.Filter = "XML Files|*.xml", .Title = "Save class data as XML file",
            .FileName = frmMain.tbcMain.SelectedTab.Text.Replace(" ", "") & ".xml"} 'creates a new safe file dialog and filters by xml files 
        If Not exists AndAlso sfd.ShowDialog() = DialogResult.OK Then
            path = sfd.FileName
        End If
        Using writer As XmlWriter = XmlWriter.Create(path, New XmlWriterSettings With {.Indent = True})
            xml.WriteTo(writer) 'appends to xml doc 
        End Using
        globalFunctions.echo("File saved (save)")
    End Sub
    Public Shared Function saveAs() As String 'creates a new xml file and saves class data
        Dim grid As DataGridView = classes.getClass() 'gets the current selected class within the tab control 
        Dim xml As New XmlDocument()
        Dim parent As XmlElement = xml.CreateElement(frmMain.tbcMain.SelectedTab.Text.Replace(" ", ""))
        For Each row As DataGridViewRow In grid.Rows 'iterate through each row in the class 
            Dim rowE As XmlElement = xml.CreateElement("row")
            For Each cell As DataGridViewCell In row.Cells 'iterate through each cell 
                Dim cName As String = grid.Columns(cell.ColumnIndex).Name
                Dim cellV As String = If(cell.Value IsNot Nothing, cell.Value.ToString(), "") 'gets the value of the cell; if nothing sets as a blank 
                Dim cellE As XmlElement = xml.CreateElement(cName.Replace(" ", "")) 'creates a new xml element for the cell 
                cellE.InnerText = cellV
                rowE.AppendChild(cellE) 'append cell element to row element 
            Next
            parent.AppendChild(rowE) 'append row element to root element 
        Next
        xml.AppendChild(parent) 'append root element to xml doc  
        Dim sfd As New SaveFileDialog With {.Filter = "XML Files|*.xml", .Title = "Save class data as XML file",
            .FileName = frmMain.tbcMain.SelectedTab.Text.Replace(" ", "") & ".xml"} 'creates a new safe file dialog and filters by xml files 
        If sfd.ShowDialog() = DialogResult.OK Then
            Using writer As XmlWriter = XmlWriter.Create(sfd.FileName, New XmlWriterSettings With {.Indent = True})
                xml.WriteTo(writer) 'creates and writes to new xml doc  
            End Using
            globalFunctions.echo("File saved (saved as)")
            Return sfd.FileName 'returns the name of the newly created file 
        Else
            Return String.Empty 'if a file wasn't successfully created returns null 
        End If
    End Function
    Public Shared Function filePath() As String 'returns the file path of the xml file 
        Dim name As String = frmMain.tbcMain.SelectedTab.Text.Replace(" ", "") & ".xml"
        Return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), name) 'combine file name with the documents folder 
    End Function
    Public Shared Sub open() 'opens an xml file and populates the data in a new class 
        Dim file As String = openfile(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "XML Files|*.xml"), 'opens a file dialog to select a xml file 
        data As New DataSet(), 'creates a new dataset to store xml data 
        grid = classes.dataGrid(1) 'creates empty datagrid to store xml data 
        grid.DefaultCellStyle.Font = classes.font
        Try
            data.ReadXml(file)
            grid.DataSource = data.Tables(0) 'binds the datasource of the datagrid to the first table in the dataset 
            Dim name As String = Path.GetFileNameWithoutExtension(file)
            Dim exist As TabPage = frmMain.tbcMain.TabPages.Cast(Of TabPage)().FirstOrDefault(Function(tab) tab.Text = name) 'check if a tab with the same name already exists 
            If exist IsNot Nothing Then
                MessageBox.Show("A tab with the same name already exists.")
            Else 'creates a new tab page with the class if it doesn't already exist 
                Dim tab As New TabPage(name)
                tab.Controls.Add(grid)
                frmMain.tbcMain.TabPages.Add(tab)
                frmMain.tbcMain.SelectedTab = tab
                classes.classes(name) = True
                If Not classes.init Then
                    classes.init = 1
                End If
            End If
        Catch ex As Exception
        End Try
        If classes.init Then
            Dim Cgrid = classes.getClass() 'gets the current class 
            For Each col As DataGridViewColumn In Cgrid.Columns 'iterates every column within the class 
                Dim head As String = col.HeaderText
                If head.Contains("_INT") Then 'if the header text contains the _INT indentifier filter it out 
                    head = head.Replace("_INT", "")
                    col.HeaderText = head
                End If
            Next
            classes.updateCBO()
        End If
    End Sub

    Public Shared Function openfile(Optional location As String = "C:\", Optional type As String = "All files (*.*)|*.*|All files (*.*)|*.*") As String 'opens a file dialog to choose a file; parameters are set to default values if not specified
        Dim fd As OpenFileDialog = New OpenFileDialog With {
            .Title = "Open file",
            .InitialDirectory = location,
            .Filter = type
        }
        Return If(fd.ShowDialog() = DialogResult.OK, fd.FileName, Nothing) 'if a file has been selected return the file path; otherwise returns nothing 
    End Function
    Public Shared Sub saveAll() 'save all classes at once in seprate xml files 
        If classes.init = 0 Then
            globalFunctions.echo("Create a class first")
            Exit Sub
        End If
        For Each tab As TabPage In frmMain.tbcMain.TabPages 'iterates through each class 
            frmMain.tbcMain.SelectedTab = tab
            Dim name As String = frmMain.tbcMain.SelectedTab.Text
            If classes.classes.ContainsKey(name) AndAlso classes.classes(name) = False Then 'if the value pair of the class matches to false saves the class in a new xml doc 
                Dim file As String = files.saveAs()
                If Not String.IsNullOrEmpty(file) Then 'updates the classes dictionary if file was successfully created 
                    classes.classes(name) = True
                    frmMain.tbcMain.SelectedTab.Text = Path.GetFileNameWithoutExtension(file)
                    frmMain.tbcMain.SelectedTab.Name = file
                End If
            Else
                files.save() 'appends data to xml file if it already exists 
            End If
        Next
        globalFunctions.echo("All classes saved")
    End Sub

    'UNUSED CODE: 
    Public Shared Sub savew(dgv As DataGridView)
        Dim sd As New SaveFileDialog With {
           .Filter = "XML Files|*.xml",
           .Title = "Save Class data as XML file"
        }
        sd.ShowDialog()
        If sd.FileName <> "" Then
            Dim data As DataTable = TryCast(dgv.DataSource, DataTable)
            If data IsNot Nothing Then
                data.WriteXml(sd.FileName)
                globalFunctions.echo("File saved")
            Else
                globalFunctions.echo("Not a DataTable")
            End If
        End If
    End Sub
    Public Shared Function getBlankOrNumericCol(grid As DataGridView) As List(Of Integer)
        'returns all blank or numeric columns within a class; was intended to use with earlier code that replaces columns within a class so it could be sorted  
        Dim nullOrNumeric As New List(Of Integer)()
        For columnIndex As Integer = 0 To grid.Columns.Count - 1
            Dim isNullOrNumeric As Boolean = True
            For rowIndex As Integer = 0 To grid.Rows.Count - 1
                Dim cell As DataGridViewCell = grid.Rows(rowIndex).Cells(columnIndex)
                If cell.Value IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cell.Value.ToString()) AndAlso Not IsNumeric(cell.Value) Then
                    isNullOrNumeric = False
                    Exit For
                End If
            Next
            If isNullOrNumeric Then
                nullOrNumeric.Add(columnIndex)
                MsgBox(columnIndex)
            End If
        Next
        Return nullOrNumeric
    End Function
    Public Shared Function getNumericCol(grid As DataGridView) As List(Of String) 'another attempt; this one replaced the columns but broke the sort
        Dim numericColumns As New List(Of String)()
        For Each column As DataGridViewColumn In grid.Columns
            Dim isNumericColumn As Boolean = False
            For Each row As DataGridViewRow In grid.Rows
                Dim cell As DataGridViewCell = row.Cells(column.Index)
                If cell.Value IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(cell.Value.ToString()) AndAlso IsNumeric(cell.Value) Then
                    isNumericColumn = True
                    Exit For
                End If
            Next
            If isNumericColumn Then
                numericColumns.Add(column.Name)
                MsgBox(column.Index)
                MsgBox(column.Name)
                column.ValueType = GetType(Integer)
                Dim columnIndex As Integer = column.Index
                Dim columnName As String = column.Name
                grid.Columns.RemoveAt(columnIndex)
                Dim integerColumn As New DataGridViewTextBoxColumn()
                integerColumn.Name = columnName
                integerColumn.HeaderText = columnName
                integerColumn.ValueType = GetType(Integer)
                grid.Columns.Insert(columnIndex, integerColumn)
                Exit For
            End If
        Next
        Return numericColumns
    End Function
End Class

Public Class sorts 'public class containing all sorting related functions 
    Public Shared Sub fetchCol()
        Dim grid As DataGridView = classes.getClass() 'get current selected class 
        frmSort.cboColNames.DropDownStyle = ComboBoxStyle.DropDownList
        For Each col As DataGridViewColumn In grid.Columns 'iterate over every column name within the class and append them to the combobox 
            frmSort.cboColNames.Items.Add(col.Name.Split("_INT")(0))
        Next
        frmSort.cboColNames.SelectedIndex = 0 'set initial value to the first index 
    End Sub
    Public Shared Function quickSort(arr() As Object, low As Integer, high As Integer) As Object() 'sorts an array of objects in ascending order 
        If low < high Then
            Dim split = partition(arr, low, high) 'partition the array and get the index of pivot 
            quickSort(arr, low, split - 1) 'sort sub arrays on left and right of the pivot index 
            quickSort(arr, split + 1, high)
        End If
        Return arr
    End Function
    Public Shared Function partition(arr() As Object, low As Integer, high As Integer) As Integer
        Dim pivot = arr(high)
        For i = low To high 'iterate through the array and compare each element with the pivot 
            If arr(i) IsNot Nothing AndAlso arr(i).CompareTo(pivot) < 0 Then
                swap(arr, low, i) 'swap the current element at the low index if it is larger 
                low += 1
            End If
        Next
        swap(arr, low, high) 'swap the pivot with the element at the low index 
        Return low
    End Function
    Public Shared Sub swap(arr() As Object, left As Integer, right As Integer) 'swaps 2 elements in an array of objects 
        Dim temp As Object = arr(left)
        arr(left) = arr(right)
        arr(right) = temp 'assign right element to the left element and vice versa; creates a temp value to do so 
    End Sub
    Public Shared Function isEqual(Of T)(list1 As List(Of T), list2 As List(Of T)) As Boolean 'checks if 2 lists are equal to each other; (of T) being a type param that allows the function to work with any type
        If list1 Is list2 Then 'check if the two lists reference the same object
            Return True
        End If
        If list1.Count <> list2.Count Then 'check if the counts of the two lists are different
            Return False
        End If
        For i = 0 To list1.Count - 1 'iterate over the elements of the lists and compare them
            If Not EqualityComparer(Of T).Default.Equals(list1(i), list2(i)) Then
                Return False
            End If
        Next
        Return True
    End Function
    Public Shared Sub sortCol() 'sorts a column based on acsending order 
        Dim grid As DataGridView = classes.getClass(), name As String = frmSort.cboColNames.Text, index = 0
        For Each column As DataGridViewColumn In grid.Columns 'iterate through each column and check if the name matches the name displayed in the combobox 
            If column.HeaderText = name Then
                index = column.Index 'if so returns the index of that column 
                Exit For
            End If
        Next
        Dim col As DataGridViewColumn = grid.Columns(index), 'defind the targeted column 
        isEmpty As Boolean = True 'flag to track if the column only contains empty values
        For i = 0 To grid.Rows.Count - 1
            Dim cell As Object = grid.Rows(i).Cells(index).Value
            If cell IsNot Nothing AndAlso Not String.IsNullOrEmpty(cell.ToString()) Then
                isEmpty = False 'if a nonempty value is found set the flag to 0 and break
                Exit For
            End If
        Next
        If isEmpty Then
            globalFunctions.echo("Column is empty") 'if the column is empty throw error message and break 
            Exit Sub
        End If
        If index >= 0 Then
            If col.ValueType Is GetType(Integer) Then 'if the type of the column is of integer check it for null values and replace them with 0 
                For i = 0 To grid.Rows.Count - 2 'ignore the last row which is automatically filled blank 
                    Dim cell As DataGridViewCell = grid.Rows(i).Cells(index)
                    If cell.Value Is Nothing OrElse cell.Value Is DBNull.Value Then
                        cell.Value = 0
                    End If
                Next
            End If
            Dim val As New List(Of String) 'create a new lists to store values; easiest method to add values to an empty datasource and read them 
            Dim empty As New List(Of Integer)
            For i = 0 To grid.Rows.Count - 1 'iterate through each row of the class 
                Dim cell As Object = grid.Rows(i).Cells(index).Value
                If cell IsNot Nothing AndAlso Not String.IsNullOrEmpty(cell.ToString()) Then
                    val.Add(cell.ToString()) 'adds the value to the list if its not null
                Else
                    empty.Add(i) 'adds to the empty list is it is null 
                End If
            Next
            Dim sorted = val 'duplicate the unsorted list 
            sorted.Sort() 'weird workaround but sort the sort the list using built in function 
            If isEqual(sorted, val) = False Then
                Dim sortedArr() As String = sorts.quickSort(val.ToArray(), 0, val.Count - 1) 'sort the unsorted list using quicksort function if the two lists are not equal
                For Each remove As Integer In empty 'remove items from the column once they have been sorted 
                    grid.Rows.RemoveAt(remove)
                Next
                For i = 0 To sortedArr.Length - 1 'iterate sorted array 
                    Dim Rindex As Integer = i + empty.Count
                    Dim row As DataGridViewRow = CType(grid.Rows(0).Clone(), DataGridViewRow) 'create a new row 
                    row.SetValues(sortedArr(i)) 'insert sorted values when matching the correct index 
                    grid.Rows.Insert(Rindex, row) 'replace the old column with the newly sorted one 
                Next
            End If
            grid.Sort(grid.Columns(index), ComponentModel.ListSortDirection.Ascending) 'weird workaround - sort the rest of the class using built in function 
            grid.Columns(index).SortMode = DataGridViewColumnSortMode.NotSortable
            globalFunctions.echo("Column sorted")
            Exit Sub
        End If
    End Sub
End Class

Public Class searches 'public class that contains related search functions 
    Public Shared Sub fetchCol()
        Dim grid As DataGridView = classes.getClass()
        frmSearch.cboColNames.DropDownStyle = ComboBoxStyle.DropDownList
        For Each col As DataGridViewColumn In grid.Columns 'iterate over every column name within the class and append them to the combobox 
            frmSearch.cboColNames.Items.Add(col.Name.Split("_INT")(0))
        Next
        frmSearch.cboColNames.SelectedIndex = 0 'set initial value to the first index 
    End Sub
    Public Shared Sub fetchCell() 'gets the cell index of the searched value within the class 
        Dim grid As DataGridView = classes.getClass(), search As String = frmSearch.txtInput.Text.Trim(),
        index = frmSearch.cboColNames.SelectedIndex, found = False
        If index < 0 AndAlso index > grid.Columns.Count Then 'check if the selected index is valid 
            MessageBox.Show("Select a valid column")
            Exit Sub
        End If
        For Each row As DataGridViewRow In grid.Rows 'iterate over each row in the class 
            Dim cell As Object = row.Cells(index).Value
            If cell IsNot Nothing AndAlso cell.ToString().Replace(" ", "") = search Then 'check if the cell value matches the search value 
                Dim rowData As String = fetchRow(row), 'gets every value within the row of the item found 
                rowNumber As Integer = row.Index + 1 'gets the row number where the value was found
                found = True
                frmSearch.txtOutput.SelectionColor = Color.Black
                frmSearch.txtOutput.AppendText($"{vbCrLf}Search for [")
                frmSearch.txtOutput.SelectionColor = Color.Red
                frmSearch.txtOutput.AppendText(frmSearch.txtInput.Text)
                frmSearch.txtOutput.SelectionColor = Color.Black
                frmSearch.txtOutput.AppendText($"] in [")
                frmSearch.txtOutput.SelectionColor = Color.Blue
                frmSearch.txtOutput.AppendText(frmSearch.cboColNames.Text)
                frmSearch.txtOutput.SelectionColor = Color.Black
                frmSearch.txtOutput.AppendText($"] column resulted in: ")
                frmSearch.txtOutput.SelectionColor = Color.DarkSlateBlue
                frmSearch.txtOutput.AppendText(rowData)
                frmSearch.txtOutput.SelectionColor = Color.Black
                frmSearch.txtOutput.AppendText($"{vbCrLf}At row: {rowNumber}") 'append the search result to the output textbox 
            End If
        Next
        If Not found Then
            globalFunctions.echo("Nothing found") 'outputs error message if nothing is found 
        End If
    End Sub
    Public Shared Function fetchRow(row As DataGridViewRow) As String 'gets the data of a class row 
        Dim data As New List(Of String)(), 'create a new list to store data of each cell in the row 
        grid As DataGridView = classes.getClass()
        For Each cell As DataGridViewCell In row.Cells 'iterate over each cell in the row 
            If cell.Value IsNot Nothing Then 'check if the cell value is not null and add it to the list 
                Dim rowD As String = $"{grid.Columns(cell.ColumnIndex).Name}: {cell.Value.ToString()}"
                data.Add(rowD)
            End If
        Next
        Return String.Join(", ", data) 'join the list containing every value within the row with commas 
    End Function
End Class

Public Class stats 'public class that contains all related stat calculations - did more calculations here than all of maths this year lmao 
    Public Shared Sub fetchCol()
        Dim grid As DataGridView = classes.getClass()
        frmStats.cboColNames.DropDownStyle = ComboBoxStyle.DropDownList
        For Each col As DataGridViewColumn In grid.Columns
            frmStats.cboColNames.Items.Add(col.Name.Split("_INT")(0)) 'iterate over every column name within the class and append them to the combobox 
        Next
        frmStats.cboColNames.SelectedIndex = 0 'set initial value to the first index 
    End Sub
    Public Shared Function fetchColArr(grid As DataGridView, col As String) As Object() 'fetches column values as an array 
        Dim val As New List(Of Object)()
        For i = 0 To grid.Rows.Count - 2 'iterate over the column, excluding the last row which is null 
            Dim row As DataGridViewRow = grid.Rows(i), cell As Object = row.Cells(col).Value
            'If cell Is Nothing Then 'check if cell value is not and replace it with blank 
            '    val.Add("")
            'Else
            '    val.Add(cell) 
            'End If
            If cell Is Nothing OrElse String.IsNullOrWhiteSpace(cell.ToString()) Then 'check for null values 
                val.Add(0) 'treat null values as 0 
            Else
                val.Add(cell) 'otherwise add cell value to the list 
            End If
        Next
        Dim arr As Object() = val.ToArray() 'converts list to an array for calculations and returns it 
        Return arr
    End Function
    Public Shared Function FindMode(arr() As Object) As String 'finds the mode within an array 
        Dim modes As New List(Of Object)() 'list to store all the modes that will be returned 
        Dim count As New Dictionary(Of Object, Integer)() 'dictionary to store the count of each value 
        For Each value In arr
            If value IsNot Nothing Then 'iterate through the dictionary checking for null values 
                If count.ContainsKey(value) Then
                    count(value) += 1 'increment the count of the value in the dictionary if it exists
                Else
                    count(value) = 1 'create an object within the dictionary with its value being 1 
                End If
            End If
        Next
        Dim maxCount = count.Values.Max() 'find the max count within the values 
        If maxCount = 1 Then
            Return "Not applicable" 'returns error if all the values are 1 
        End If
        For Each kvp In count
            If kvp.Value = maxCount Then 'iterate through the dictionary and add values with the highest count to the list 
                modes.Add(kvp.Key)
            End If
        Next
        Return String.Join(", ", modes.Select(Function(x) x.ToString())) 'returns the modes as a comma seperated string 
    End Function

    Public Shared Sub stats()
        Dim grid = classes.getClass, name = frmStats.cboColNames.Text, colName = Nothing
        For Each column As DataGridViewColumn In grid.Columns 'iterate through each column in the class and check if header matches with name 
            If column.HeaderText = name Then
                colName = column.Name 'gets the name of the column if they match
                Exit For
            End If
        Next
        If colName = Nothing Then 'breaks if no valid column name is found 
            globalFunctions.echo("An error occured")
            Exit Sub
        End If
        Dim colArr = fetchColArr(classes.getClass, colName), 'the array containing values to be calculated 
            numericCol = True, size = colArr.Length, sum = 0, empty = True, average
        For Each col In colArr
            If col IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(col.ToString()) Then 'check if the array is not empty 
                empty = False
                Exit For
            End If
        Next
        If empty Then 'check if array is empty 
            globalFunctions.echo("At least 3 valid values are required within the column")
            Exit Sub
        End If
        If size <= 2 Then 'check if the array contains at least 3 values 
            globalFunctions.echo("At least 3 values are required within the column")
            Exit Sub
        End If

        For i = 0 To colArr.Length - 1 'iterate through the array and replace null values with 0 
            If colArr(i) Is Nothing OrElse IsDBNull(colArr(i)) Then
                colArr(i) = 0.ToString 'false to string lmao 
            End If
        Next
        For Each col In colArr 'iterate through the array and check if it is nummerical 
            If col IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(col.ToString()) Then
                If Not IsNumeric(col) Then
                    numericCol = False
                    Exit For
                End If
            End If
        Next
        For Each cell In colArr
            Try
                sum += cell 'find the sum of the array
            Catch ex As Exception
                Try
                    sum += Val(cell) 'attempts to remove integer values if value from strings 
                Catch xe As Exception
                    sum += 0 'if the value if not an integer adds 0 
                End Try
            End Try
        Next
        average = Math.Floor(sum / size) 'calculate avarage 

        Dim medLow = (size / 2) - 1, 'middle low index 
            medHigh = (size / 2), 'middle high index 
            eOrO = size Mod 2, 'stores if the array is even or odd
            sortedArr = {}, median = 0
        Try
            If numericCol = False Then
                sortedArr = sorts.quickSort(colArr, 0, size - 1) 'sorts the array using quicksort 
                If eOrO = 0 Then
                    median = $"{sortedArr(medLow)} and {sortedArr(medHigh)}" 'if the array is even 
                Else
                    median = sortedArr(Math.Ceiling(medLow)) 'if the array is odd 
                End If
            Else
                sortedArr = colArr.OrderBy(Function(x) CDbl(x)).ToArray()
                median = Math.Round(Val((sortedArr(medLow)) + Val(sortedArr(medHigh))) / 2, 2) 'finds the median value 
            End If
        Catch ex As Exception
        End Try

        'Dim items = ""
        'For i = 0 To sortedArr.Length - 1
        '    items += (i + 1).ToString + ":" + sortedArr(i) + ", "
        'Next

        Dim count = size.ToString(), range, q1, q3, iqr
        Try
            range = If(Not numericCol, 0, sortedArr(sortedArr.Length - 1) - sortedArr(0)) 'range defaults to 0 in a non numerical array 
            If numericCol Then
                If size Mod 2 = 0 Then 'if the array is even calculate the quartiles 
                    q1 = (Val(sortedArr(size \ 4 - 1) + Val(sortedArr(size \ 4)))) / 2
                    q3 = Val((sortedArr((3 * size) \ 4 - 1)) + Val(sortedArr((3 * size) \ 4))) / 2
                Else 'calculate the quartiles for an odd array
                    q1 = Val(sortedArr((size + 1) \ 4 - 1))
                    q3 = Val(sortedArr((3 * size + 1) \ 4 - 1))
                End If
                iqr = Math.Round(q3 - q1, 2) 'calculate the iqr 
            Else 'if the array is not numerical returns not applicable 
                q1 = "Not applicable"
                q3 = "Not applicable"
                iqr = "Not applicable"
            End If
        Catch ex As Exception
            range = 0
            q1 = "Not applicable"
            q3 = "Not applicable"
            iqr = "Not applicable"
        End Try
        Dim mode = FindMode(colArr) 'calculate mode 
        'TODO: convert the rest of the calculations to functions 
        frmStats.txtOutput.SelectionColor = Color.Black 'display the results in a textbox output 
        frmStats.txtOutput.AppendText($"{vbCrLf}Analysis of [")
        frmStats.txtOutput.SelectionColor = Color.Red
        frmStats.txtOutput.AppendText(frmStats.cboColNames.Text)
        frmStats.txtOutput.SelectionColor = Color.Black
        frmStats.txtOutput.AppendText($"] resulted in:{vbCrLf}")
        frmStats.txtOutput.SelectionColor = Color.DarkSlateBlue
        frmStats.txtOutput.AppendText($"Average: {average.ToString + vbCrLf}Median: {median.ToString + vbCrLf}Mode: {mode.ToString + vbCrLf}Count: {count + vbCrLf}Range: {range.ToString + vbCrLf}Q1: {q1.ToString + vbCrLf}Q3: {q3.ToString + vbCrLf}IQR: {iqr.ToString}")
    End Sub
End Class

Public Class themes 'public class containing all related theme functions 
    Public Shared init = False, theme = "Default"
    Public Shared themes As New Dictionary(Of String, Color()) From { 'creates a new dictionary containing all the available themes 
        {"Default", {Color.DarkGray, Color.LightSlateGray, Color.Black, Color.LightSteelBlue}},
        {"Blue", {Color.Blue, Color.Black, Color.MidnightBlue, Color.White}},
        {"Green", {Color.Green, Color.White, Color.DarkGreen, Color.White}},
        {"Red", {Color.Red, Color.White, Color.DarkRed, Color.White}},
        {"Yellow", {Color.Yellow, Color.Black, Color.GreenYellow, Color.White}},
        {"Purple", {Color.Purple, Color.White, Color.DarkMagenta, Color.White}},
        {"Orange", {Color.Orange, Color.Black, Color.DarkOrange, Color.White}},
        {"Cyan", {Color.Cyan, Color.Black, Color.DarkCyan, Color.White}},
        {"Pink", {Color.Pink, Color.Black, Color.DeepPink, Color.White}},
        {"Gray", {Color.Gray, Color.Black, Color.DarkGray, Color.White}},
        {"Brown", {Color.Brown, Color.Black, Color.SaddleBrown, Color.White}},
        {"Teal", {Color.Teal, Color.Black, Color.DarkSlateGray, Color.White}},
        {"Gold", {Color.Gold, Color.Black, Color.DarkGoldenrod, Color.White}},
        {"Lime", {Color.Lime, Color.Black, Color.LimeGreen, Color.White}},
        {"Silver", {Color.Silver, Color.Black, Color.LightGray, Color.White}},
        {"Magenta", {Color.Magenta, Color.Black, Color.DarkMagenta, Color.White}},
        {"Aqua", {Color.Aqua, Color.Black, Color.DarkTurquoise, Color.White}},
        {"Navy", {Color.Navy, Color.White, Color.MidnightBlue, Color.White}},
        {"Olive", {Color.Olive, Color.White, Color.DarkOliveGreen, Color.White}},
        {"Maroon", {Color.Maroon, Color.White, Color.DarkRed, Color.White}},
        {"Indigo", {Color.Indigo, Color.White, Color.MediumPurple, Color.White}},
        {"SkyBlue", {Color.SkyBlue, Color.Black, Color.DeepSkyBlue, Color.White}},
        {"Coral", {Color.Coral, Color.Black, Color.DarkOrange, Color.White}},
        {"Turquoise", {Color.Turquoise, Color.Black, Color.MediumTurquoise, Color.White}},
        {"SlateGray", {Color.SlateGray, Color.Black, Color.DarkSlateGray, Color.White}},
        {"DarkCyan", {Color.DarkCyan, Color.Black, Color.Teal, Color.White}},
        {"DarkOrchid", {Color.DarkOrchid, Color.White, Color.MediumPurple, Color.White}},
        {"Lavender", {Color.Lavender, Color.Black, Color.Thistle, Color.White}},
        {"Crimson", {Color.Crimson, Color.White, Color.DarkRed, Color.White}} 'TODO: make this look less horrendous 
    } 'ty chad g pete for helping me create these theme options 
    Public Shared Sub applyTheme(form As Form, name As String) 'applys given theme to a singular form 
        Dim colors As Color() = themes(name) 'retrieve the colour theme from the dictionary in an array 
        form.BackColor = colors(0) 'sets the backcolour of the form 
        If name = "Default" Then
            For Each btn As Button In form.Controls.OfType(Of Button)() 'applys themes to all buttons, list boxes, rich text boxes, textboxes and combo boxes 
                btn.BackColor = colors(1)
                btn.ForeColor = colors(2)
            Next
            For Each lb As ListBox In form.Controls.OfType(Of ListBox)()
                lb.BackColor = colors(1)
                lb.ForeColor = colors(2)
            Next
            For Each rxt As RichTextBox In form.Controls.OfType(Of RichTextBox)()
                rxt.BackColor = colors(1)
                rxt.ForeColor = colors(2)
            Next
            For Each txt As TextBox In form.Controls.OfType(Of TextBox)()
                txt.BackColor = colors(1)
                txt.ForeColor = colors(2)
            Next
        Else
            For Each btn As Button In form.Controls.OfType(Of Button)()
                btn.BackColor = ControlPaint.Dark(colors(0))
                btn.ForeColor = ControlPaint.Light(btn.BackColor)
            Next
            For Each lb As ListBox In form.Controls.OfType(Of ListBox)()
                lb.BackColor = ControlPaint.Dark(colors(0))
                lb.ForeColor = ControlPaint.Light(lb.BackColor)
            Next
            For Each rxt As RichTextBox In form.Controls.OfType(Of RichTextBox)()
                rxt.BackColor = ControlPaint.Dark(colors(0))
                rxt.ForeColor = ControlPaint.Light(rxt.BackColor)
            Next
            For Each txt As TextBox In form.Controls.OfType(Of TextBox)()
                txt.BackColor = ControlPaint.Dark(colors(0))
                txt.ForeColor = ControlPaint.Light(txt.BackColor)
            Next
        End If
        For Each cbo As ComboBox In form.Controls.OfType(Of ComboBox)()
            cbo.BackColor = colors(3)
            cbo.ForeColor = colors(2)
        Next 'TODO: optimize 
    End Sub
    Public Shared Sub applyThemeAll(name As String) 'applys specified theme to all forms 
        If name Is Nothing Then name = "Default" 'if no theme is provided sets the theme to default 
        For Each form As Form In Application.OpenForms 'iterates through each form and applys the theme 
            applyTheme(form, name)
        Next
    End Sub
End Class

'Author: 45rfew
'Created: 22/5/28
'Version: 1.0.2
'Purpose: Screen displayed to create a new class 
'Changelog: 
' 5/31/2023 - VERSION 0.0.1
' - Core functions started; no file functionality 
' 3/6/2023 - VERSION 0.0.2
' - No longer clears input text for creating classes 
' 10/6/2023 - VERSION 1.0.2
' - UI completed 
' 17/6/2023 - VERSION 1.0.2
' - Added internal documentation 

Public Class frmNew
    Dim defaultClass() As String = {"CLASS NAME", "", "Name", "Last Name", "ID_INT", "Attendence", "Extension", "Modified", "Score_INT", "Remarks"} 'default class structure
    Public Sub newLoad(sender As Object, e As EventArgs) Handles MyBase.Activated 'event handles when the formm is activated, not loaded 
        txtInput.Text = String.Join(vbCrLf, defaultClass) 'set the default class structure based on the default class array 
    End Sub
    Public Sub create(sender As Object, e As EventArgs) Handles btnCreate.Click
        Dim input() As String = txtInput.Lines 'retrieves input lines from the textbox
        input = Array.FindAll(input, Function(item) Not String.IsNullOrWhiteSpace(item)) 'removes empty lines from input 
        If classes.createClass(input) Then Close() 'close the form if creation is successful 
        'txtInput.Text = ""
    End Sub
    Private Sub cancel(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to abandon process?", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub
End Class

'Author: 45rfew
'Created: 22/5/3 
'Version: 1.0.4
'Purpose: Search window that allows user to search for values
'Changelog: 
' 5/3/2023 - VERSION 0.0.1
' - Skeleton UI and basic functionality 
' - Only shows one value result 
' 8/6/2023 - VERSION 0.0.2 
' - Displays all values within the row instead of just the cell  
' 10/6/2023 - VERSION 0.0.3
' - UI improvements (no more button 1 button 2 lol) 
' - Added buttons for search and cancel
' - Bug fixes
'13/6/2023 VERSION 1.0.4
' - UI completed 
' - Added validation 
' 17/6/2023 - VERSION 1.0.4
' - Added internal documentation 

'TODO: allow search with multiple values

Public Class frmSearch
    Public Shared updated = False 'indicates if the data has been updated 
    Private Sub searchLoad(sender As Object, e As EventArgs) Handles MyBase.Activated 'event handles when the formm is activated, not loaded 
        If updated = False Then
            Try
                cboColNames.Items.Clear() 'if data has not been updated clear the combobox and update its items 
                searches.fetchCol()
                updated = True
            Catch ex As Exception
                globalFunctions.echo("Create a class first")
            End Try
        End If
    End Sub
    Private Sub search(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtInput.Text = "" Or cboColNames.SelectedIndex < 0 Then 'checks if the input is blank or if there is nothing selected 
            globalFunctions.echo("Search input invalid and/or no column selected")
            Exit Sub
        End If
        searches.fetchCell()
    End Sub
    Private Sub cancel(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to abandon process?", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            Hide()
        End If
    End Sub
    Private Sub clear(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOutput.Text = "Search results:"
    End Sub
End Class

'Author: 45rfew
'Created: 10/6/3 
'Version: 1.0.2
'Purpose: Sorting window that allows user to sort a column
'Changelog: 
' 10/6/2023 - VERSION 0.0.1
' - UI and basic functionality - cannot sort integer columns 
' 14/6/2023 - VERSION 0.0.2
' - Validation 
' - Updates combobox upon form activation 
' 17/6/2023 - VERSION 1.0.2
' - Added internal documentation 

Public Class frmSort
    Public Shared updated = False 'indicates if the data has been updated 
    Private Sub sortLoad(sender As Object, e As EventArgs) Handles MyBase.Activated  'event handles when the formm is activated, not loaded 
        If updated = False Then
            Try
                cboColNames.Items.Clear() 'if data has not been updated clear the combobox and update its items 
                sorts.fetchCol()
                updated = True
            Catch ex As Exception
                globalFunctions.echo("Create a class first")
            End Try
        End If
    End Sub
    Private Sub cancel(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to abandon process?", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub sort(sender As Object, e As EventArgs) Handles btnSort.Click
        sorts.sortCol()
    End Sub
End Class

'Author: 45rfew
'Created: 13/6/3 
'Version: 1.0.2
'Purpose: Stats window that allows user to display stats of a column 
'Changelog: 
' 13/6/2023 - VERSION 0.0.1
' - UI and basic functionality 
' 14/6/2023 - VERSION 0.0.2
' - Bug fixes and general validation 
' - Columns combobox clears itself upon every activation of the form 
' - Closes form when a new class is created or when the tab control index changes 
' 17/6/2023 - VERSION 1.0.2
' - Added internal documentation 

Public Class frmStats
    Public Shared updated = False 'indicates if the data has been updated 
    Private Sub statsLoad(sender As Object, e As EventArgs) Handles MyBase.Activated 'event handles when the formm is activated, not loaded 
        If updated = False Then
            Try
                cboColNames.Items.Clear() 'if data has not been updated clear the combobox and update its items 
                stats.fetchCol()
                updated = True
            Catch ex As Exception
                globalFunctions.echo("Create a class first")
            End Try
        End If
    End Sub
    Private Sub search(sender As Object, e As EventArgs) Handles btnCalculate.Click
        stats.stats()
    End Sub
    Private Sub cancel(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBox("Are you sure you want to abandon process?", MsgBoxStyle.YesNo, "Exit") = MsgBoxResult.Yes Then
            Hide()
            updated = False
        End If
    End Sub
    Private Sub clear(sender As Object, e As EventArgs) Handles btnClear.Click
        txtOutput.Text = "Results:"
    End Sub
End Class

'Author: 45rfew
'Created: 14/6/3 
'Version: 1.0.2
'Purpose: Theme selector that allows a user to change the theme
'Changelog: 
' 14/6/2023 - VERSION 0.0.1
' - UI and basic functionality
' 15/6/2023 - VERSION 0.0.2
' - All forms updated upon choosing a theme 
' - Defaults to the original theme 
' 17/6/2023 - VERSION 1.0.2
' - Added internal documentation 

Public Class frmTheme
    Private Sub themeLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each name As String In themes.themes.Keys 'iterate through the themes dictionary and populate the combobox with theme names 
            cboThemes.Items.Add(name)
        Next
        cboThemes.SelectedIndex = 0 'sets default index to 0 
    End Sub
    Private Sub themesIndexChanged(sender As Object, e As EventArgs) Handles cboThemes.SelectedIndexChanged
        If themes.themes.ContainsKey(cboThemes.Text) Then themes.applyThemeAll(cboThemes.Text) 'check if the selected theme exists in the dictionary 
        themes.theme = cboThemes.Text
    End Sub
    Private Sub cancel(sender As Object, e As EventArgs) Handles btnCancel.Click
        themes.theme = "Default"
        Close()
    End Sub
    Private Sub apply(sender As Object, e As EventArgs) Handles btnApply.Click
        Close()
    End Sub
End Class

