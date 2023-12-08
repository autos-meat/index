' MainForm.vb
Public Class MainForm
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CalculateArea()
    End Sub

    Private Sub CalculateArea()
        If Double.TryParse(txtLength.Text, Dim length As Double) AndAlso Double.TryParse(txtWidth.Text, Dim width As Double) Then
            Dim area As Double = length * width
            lblAreaResult.Text = $"Area: {area}"
        Else
            lblAreaResult.Text = "Invalid input. Please enter valid numbers for length and width."
        End If
    End Sub
End Class
