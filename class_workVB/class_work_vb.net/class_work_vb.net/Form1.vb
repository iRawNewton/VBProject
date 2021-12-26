Public Class Form1

   
    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        Try
            Dim a, b, c As Integer
            a = T1.Text
            b = T2.Text
            c = a / b
            T3.Text = c

        Catch ex As Exception
            MsgBox("CANNOT DIVIDE A NUMBER BY ZERO", MsgBoxStyle.Critical)
        Finally
            MsgBox("Thank you!")

        End Try
    End Sub
End Class
