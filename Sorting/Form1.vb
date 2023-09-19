Public Class Form1
    Dim arr() As Integer



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        arr = New Integer() {
            Val(TextBox1.Text),
            Val(TextBox2.Text),
            Val(TextBox3.Text),
            Val(TextBox4.Text),
            Val(TextBox5.Text),
            Val(TextBox6.Text),
            Val(TextBox7.Text)}
        Array.Sort(arr)
        Dim i As Integer = 1
        For Each num As Integer In arr
            Dim textBoxName As String = "h" & i.ToString()
            Dim textBox As TextBox = DirectCast(Me.Controls.Find(textBoxName, True).FirstOrDefault(), TextBox)
            If textBox IsNot Nothing Then
                textBox.Text = num.ToString()
            End If
            i += 1
        Next
    End Sub
End Class
