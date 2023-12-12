Public Class Form1
    Public Function binarysearch(arr, val)
        Dim start = 0, fin = arr.length - 1, mid
        While (start <= fin) 'repeats until all array values have been discarded except searched value 
            mid = Math.Floor((start + fin) / 2) 'middle index of the current valid array, rounded  
            If (arr(mid) = val) Then
                Return mid 'returns index of searched value if it is found 
            End If
            If (val < arr(mid)) Then
                fin = mid - 1 'discards the right half of the array if searched value is lower than middle array value 
            Else
                start = mid + 1 'discards the left half of the array if searched value is higher than middle array value 
            End If
        End While
        Return -1 'if nothing found returns -1 
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr = {}
        For i = 0 To 100 'generate array with values 1 to 100
            ReDim Preserve arr(i + 1)
            arr(i) = i + 1
        Next
        Try
            MessageBox.Show(binarysearch(arr, CInt(TextBox1.Text))) 'searches for value upon click 
        Catch ex As Exception
            MessageBox.Show("no work")
        End Try
    End Sub
End Class
