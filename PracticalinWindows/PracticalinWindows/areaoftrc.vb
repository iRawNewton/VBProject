Public Class areaoftrc


    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Dim x, y, z As Integer
        x = BT.Text
        y = HT.Text
        z = 0.5 * x * y
        AT.Text = z
    End Sub

    Private Sub B2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B2.Click
        Dim x, y, z As Integer
        x = BR.Text
        y = LR.Text
        z = x * y
        AR.Text = z
    End Sub
    Private Sub B3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B3.Click
        Dim x, y As Decimal
        x = RC.Text
        y = 3.15 * x * x
        AC.Text = y
    End Sub

    Private Sub B4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B4.Click
        BT.Clear()
        HT.Clear()
        BR.Clear()
        LR.Clear()
        RC.Clear()
        AT.Clear()
        AR.Clear()
        AC.Clear()
        BT.Focus()
    End Sub

    Private Sub B5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B5.Click
        Me.Close()
    End Sub
End Class