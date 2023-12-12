Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim b = {1, 5, 14, 35246, 363, 2}
        Dim a = selectionsort(b)
        Dim c = ""
        For i = 0 To b.Length - 1
            c += a(i).ToString() + " "
        Next
        MessageBox.Show(c)
    End Sub
    Function selectionsort(arr() As Integer)
        Dim arrr = arr.Clone()
        Dim last = arrr.Length - 1
        For i = 0 To last
            Dim smallest = i
            For j = i + 1 To last
                If arrr(j) < arrr(smallest) Then
                    smallest = j
                End If
            Next
            If smallest <> i Then
                swap(arrr, smallest, i)
            End If
        Next
        Return arrr
    End Function
    Public Sub swap(ByRef arr() As Integer, left As Integer, right As Integer)
        Dim temp = arr(left)
        arr(left) = arr(right)
        arr(right) = temp
    End Sub
End Class
