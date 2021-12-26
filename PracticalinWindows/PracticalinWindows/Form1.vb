Public Class Form1
    Dim x As Decimal
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        x = TextBox1.Text
        sqr_rt()
        Dim square As Decimal
        square = sq()
        frmcalc.TextBox2.Text = square
        frmcalc.Show()
        Me.Hide()
    End Sub
    Sub sqr_rt()
        Dim sq1 As Decimal
        sq1 = Math.Sqrt(x)
        frmcalc.TextBox1.Text = sq1
    End Sub
    Function sq() As Decimal
        x = x * x
        Return (x)
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox1.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class