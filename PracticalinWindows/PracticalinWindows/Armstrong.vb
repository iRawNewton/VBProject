Public Class Armstrong

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim n, x, sum, count, p As Integer
        n = TextBox1.Text
        p = n
        count = 0
        Do While n > 0
            n = n \ 10
            count = count + 1
        Loop
        sum = 0
        n = p
        Do While n > 0
            x = n Mod 10
            sum = sum + Math.Pow(x, count)
            n = n \ 10
        Loop
        If p = sum Then
            TextBox2.Text = ("Armstrong Number")
        Else
            TextBox2.Text = ("Not an armstrong Number")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class