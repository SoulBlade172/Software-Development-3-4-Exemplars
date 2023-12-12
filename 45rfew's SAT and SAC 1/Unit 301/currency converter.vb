'currency converter 
'
'convert currency into aud lmao 
'
'author - ... 
'date of creation - 2/7/23
'
Public Class z
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim currency() As RadioButton = {optUsd, optYen, optEuro}, rates = {1.4, 0.1, 1.8}, rate As Double = 0
        For i = 0 To 2
            If currency(i).Checked Then rate = rates(i) 'checks all radio buttons and sets rate to currency checked  
        Next
        If IsNumeric(txtInput.Text) Then
            If CInt(txtInput.Text) > 0 Then 'filters out negative values
                Try
                    lblOutput.Text = Math.Abs(Math.Round(CInt(txtInput.Text) * rate, 2)) 'treats any negatives as positive 
                    'rounds to 2 dp 
                    'converts the currency and displays the value on label
                Catch ex As Exception
                    MessageBox.Show("enter a valid value") 'if it is not a valid number clears textbox and asks for number 
                    txtInput.Clear()
                End Try
            Else
                MessageBox.Show("enter positive value")
            End If
        Else
            MessageBox.Show("enter value between 0 and 100000000") 'clear textbox if negative value 
            txtInput.Clear()
        End If
    End Sub
    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        If IsNumeric(txtInput.Text) Then
            If Math.Log10(CInt(txtInput.Text)) > 8 Then 'disallows numbers larger than 100000000.0 to prevent integer overflow 
                MessageBox.Show("input too large")
                txtInput.Clear()
            End If
        End If
    End Sub
End Class
