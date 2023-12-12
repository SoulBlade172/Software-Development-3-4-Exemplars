'random string generator v1.0.0
'author - ...
'date of creation - 12/8/2022
'changelog: 
' * nothing yet 
'
Public Class Form1
    Dim interval As Integer = 1, tick = interval, init = 0, testing = False,
        random = {"q", "w", "e", "r", "t", "y", "u", "i", "o", "p", "a", "s", "d", "f", "g", "h", "j", "k", "l", "z", "x", "c", "v", "b", "n", "m"}
    Private Sub FormLoader(sender As Object, e As EventArgs) Handles MyBase.Load
        'System.Diagnostics.Process.Start("shutdown", "-r -t 00") 
        lblTimer.Text = tick
        timer.Interval = 1000 ' set timer interval to 1 second when form loads 
        'lblCharacters.Text = (randstr(CInt(txtStrLen.Text)))
        randOptions() ' print out list of current possible random words; defualts to [random]
        pi.Text = Math.PI ' set text of pi label to pi; useless 
    End Sub
    Private Sub timerTick(sender As Object, e As EventArgs) Handles timer.Tick
        If tick <= 0 Then
            tick = interval + 1 ' timer interval is [interval] second(s); resets upon reaching 0 
            lstOutput.Items.Add(vbCrLf & randstr(CInt(txtStrLen.Text))) ' everytime the timer hits 0 generates a string 
        End If
        tick -= 1
        lblTimer.Text = tick ' updates timer text to show amount of seconds 
    End Sub
    Private Sub timerStart(sender As Object, e As EventArgs) Handles btnTimerStart.Click
        timer.Start() ' start timer when the button is clicked 
    End Sub
    Private Sub addRandom(sender As Object, e As EventArgs) Handles btnAddRandom.Click
        Dim index As Integer = 0
        If random(0) <> "" Then index = random.length ' redefines [index] if the array isn't empty 
        ' [index] is set to [random].length which is +1 higher than the index of the last item in the array 
        If txtRandInput.Text <> "" Then ' executes if textbox isn't blank
            ReDim Preserve random(index)
            random(index) = txtRandInput.Text ' pushes textbox value into the array 
            randOptions() ' display new possible random word(s)
            txtRandInput.Text = "" ' reset the textbox once string has been appended to [random] 
        End If
    End Sub
    Private Sub clear(sender As Object, e As EventArgs) Handles btnClear.Click
        random = {""} ' wipes all the current possible random words 
        randOptions() ' display new possible random word(s)
    End Sub
    Private Sub generate(sender As Object, e As EventArgs) Handles btnGenerate.Click
        lstOutput.Items.Add(vbCrLf & randstr(CInt(txtStrLen.Text))) ' push output to listbox 
    End Sub
    Private Sub validateOPLengthModifier(sender As Object, e As EventArgs) Handles txtStrLen.TextChanged
        If txtStrLen.Text = "" Then txtStrLen.Text = 0 ' if textbox value is blank adds a 0 
        If IsNumeric(txtStrLen.Text) = 0 Then txtStrLen.Text = 0 ' if textbox value is not an integer 
        If txtStrLen.Text.Contains("-") Then txtStrLen.Text *= -1 ' if value is negative makes positive
        If Math.Log10(CInt(txtStrLen.Text)) > 6 Then txtStrLen.Text = Math.Floor(CInt(txtStrLen.Text) / 10) ' stops more than 6 digits from being inputed 
        txtStrLen.Text = Math.Floor(CInt(txtStrLen.Text)) ' removes any decimal points 
    End Sub
    Private Sub clearOutput(sender As Object, e As EventArgs) Handles btnClearOutput.Click
        lstOutput.Items.Clear() ' clear the listbox of all generated values
    End Sub
    Public Function randstr(length As Integer) As String
        Dim str = ""
        'If length > random.Length - 1 Then length = random.Length - 1 
        Try
            For i = 0 To length - 1
                Dim rand = Math.Floor(VBMath.Rnd() * (random.Length - 1))
                ' lstOutput.Items.Add(random(i))
                str &= random(rand) ' attempts to generate a random string from values provided by [random] 
                echo((i, rand))
            Next i ' repeats [length] times; final returned value length is equal to [length] 
            Return str
        Catch ex As Exception
            echo(ex)
            Return "an error occured" ' if an error occcurs string is returned as error message 
        End Try
    End Function
    Public Sub randOptions()
        Dim initStr = "current random words: "
        For Each i In random
            If Array.IndexOf(random, i) = random.length - 1 Then
                initStr &= i
            Else initStr &= i & ", " ' append each value from [random] onto the end of [initStr], seperated by a comma; last value will not have a comma added 
            End If
            echo(i)
        Next
        lblCharacters.Text = initStr ' display new possible random word(s)
    End Sub
    Public Sub echo(str)
        If testing Then
            Console.WriteLine(str)
            Debug.WriteLine(str) ' debugging messages 
        End If
    End Sub
End Class
