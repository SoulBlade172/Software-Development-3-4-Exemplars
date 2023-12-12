Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arr() As Integer = {1, 5, 1, 7, 5, 2354, 745, 732, 41232, 234, 85463}, a = ""
        quicksort(arr, 0, arr.Length - 1)
        For i = 0 To arr.Length - 1
            a += arr(i).ToString + " "
        Next
        MessageBox.Show(a)
    End Sub
    Public Sub quicksort(ByRef arr() As Integer, low As Integer, high As Integer)
        If low < high Then
            Dim split = partition(arr, low, high)
            quicksort(arr, low, split - 1)
            quicksort(arr, split + 1, high)
        End If
    End Sub
    Public Function partition(ByRef arr() As Integer, low As Integer, high As Integer) As Integer
        Dim pivot = arr(high)
        For i = low To high
            If arr(i) < pivot Then
                swap(arr, low, i)
                low += 1
            End If
        Next
        swap(arr, low, high)
        Return low
    End Function
    Public Sub swap(ByRef arr() As Integer, left As Integer, right As Integer)
        Dim temp As Integer = arr(left)
        arr(left) = arr(right)
        arr(right) = temp
    End Sub
End Class
