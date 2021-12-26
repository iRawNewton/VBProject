Imports System.Data.Odbc
Public Class admission_payment
    Dim cn As New OdbcConnection("dsn=bca4th; user=root; pwd=1031871013")
    Dim cmd As New OdbcCommand
    Sub fk()
        cn.Open()
        cmd = New OdbcCommand("select * from STUD", cn)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        While (dr.Read)
            ComboBox1.Items.Add(dr(0))
        End While
        dr.Close()
        cn.Close()
    End Sub
    Private Sub admission_payment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fk()
        mop()
    End Sub
    Sub mop()
        ComboBox2.Items.Add("CASH")
        ComboBox2.Items.Add("CHEQUE")

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox5.Enabled = False
        cn.Open()
        cmd = New OdbcCommand("select * from STUD where stdid=' " & ComboBox1.Text & " '", cn)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        While dr.Read
            TextBox3.Text = dr(1).ToString
            TextBox4.Text = dr(7).ToString
            TextBox5.Text = dr(8).ToString
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub BTN_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_EXIT.Click
        Me.Close()
    End Sub

    Private Sub BTN_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SAVE.Click
        ' Try
        cn.Open()
        If TextBox1.Text <> "" And ComboBox1.Text <> "" And TextBox2.Text <> "" And ComboBox2.Text <> "" Then
            cmd = New OdbcCommand("insert into adm_pay values(' " & TextBox1.Text & " ',' " & ComboBox1.Text & " ',' " & Format(DTP1.Value, "yyyy/MM/dd") & " ',' " & Format(DTP2.Value, "yyyy/MM/dd") & " ', ' " & TextBox2.Text & " ', ' " & ComboBox2.Text & " ')", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record saved successfully")

        Else
            MsgBox("Enter records properly", MsgBoxStyle.Information)
        End If
        'Catch ex As Exception
        'MsgBox("DUPLICATE ENTRY RECTRICTED!!!", MsgBoxStyle.Critical)
        'Finally
        cn.Close()
        'SHOWDB()
        'CLEAR()
        'AUTO_G()
        'End Try
    End Sub

    Private Sub BTN_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SEARCH.Click

    End Sub
End Class