Public Class listbox_combo

    Private Sub course()
        LB1.Items.Add("BCA")
        LB1.Items.Add("MCA")
        LB1.Items.Add("BBA")
        LB1.Items.Add("MBA")
    End Sub
    Private Sub day_DOB()
        Dim d As Integer
        For d = 1 To 31
            CB1.Items.Add(d)
        Next
    End Sub
    Private Sub month_DOB()
        Dim m As Integer
        For m = 1 To 12
            CB2.Items.Add(m)
        Next
    End Sub
    Private Sub year_DOB()
        Dim y As Integer
        For y = 2019 To 1990 Step -1
            CB3.Items.Add(y)
        Next
    End Sub
    Private Sub listbox_combo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        course()
        day_DOB()
        month_DOB()
        year_DOB()
    End Sub

    Private Sub B1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B1.Click
        T3.Text = "The values entered for the student are: Roll no= " + T1.Text + " Name= " + T2.Text + " Course= " + LB1.Text + "  Date of birth= " + CB1.Text + "-" + CB2.Text + "-" + CB3.Text

    End Sub

    Private Sub LB1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LB1.SelectedIndexChanged

    End Sub
End Class