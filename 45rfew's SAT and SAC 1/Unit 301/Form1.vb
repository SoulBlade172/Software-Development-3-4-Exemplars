Public Class Form1
    Public Function binarysearch(arr, val)
        Dim start = 0, fin = arr.length - 1, mid
        While (start <= fin)
            mid = Math.Floor((start + fin) / 2)
            If (arr(mid) = val) Then
            Return mid
        End If
            If (val < arr(mid)) Then
                fin = mid - 1
            Else
                start = mid + 1
            End If
        End While
        Return -1
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim arr = {}
        For i = 0 To 100
            ReDim Preserve arr(i + 1)
            arr(i) = i + 1
        Next
        Try
            MessageBox.Show(binarysearch(arr, CInt(TextBox1.Text)))
        Catch ex As Exception
            MessageBox.Show("no work")
        End Try
    End Sub
End Class
