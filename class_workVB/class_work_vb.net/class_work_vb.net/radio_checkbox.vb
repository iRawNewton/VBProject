Public Class radio_checkbox

    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        Dim Q, G As String
        If CK_UG.Checked = True And CK_PG.Checked = False Then
            Q = "Under Graduate"
        ElseIf CK_UG.Checked = True And CK_PG.Checked = True Then
            Q = "Under Graduate & Post Graduate"
        ElseIf CK_UG.Checked = False And CK_PG.Checked = True Then
            Q = "POST Graduate"
        Else
            Q = "Not Qualified"
        End If
        If RB_MALE.Checked = True Then
            G = "MALE"
        ElseIf RB_FEMALE.Checked = True Then
            G = "FEMALE"
        Else
            G = "OTHER"
        End If
        T3.Text = "EMP NO= " + T1.Text + "  EMP NAME= " + T2.Text + " Qualification= " + Q + " Gender = " + G
    End Sub

    Private Sub CK_UG_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CK_UG.CheckedChanged

    End Sub
End Class