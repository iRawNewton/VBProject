Public Class Form2
    Sub course()
        ComboBox1.Items.Add("BCA")
        ComboBox1.Items.Add("MCA")
    End Sub
    Sub sem()
        ListBox1.Items.Add("1")
        ListBox1.Items.Add("2")
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        course()
        sem()
    End Sub
End Class