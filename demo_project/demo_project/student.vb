Imports System.Data.Odbc

Public Class student
    'GLOBAL DECLARATION
    Dim cn As New OdbcConnection("dsn=bca4th; user=root; pwd=1031871013")
    Dim cmd As New OdbcCommand
    Sub fk()
        cn.Open()
        cmd = New OdbcCommand("select * from dept", cn)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        ComboBox1.Items.Clear()
        While (dr.Read)
            ComboBox1.Items.Add(dr(0))
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fk()
        course()
        SEM()
    End Sub
    Sub course()
        ComboBox2.Items.Add("BCA")
        ComboBox2.Items.Add("MCA")
        ComboBox2.Items.Add("BBA")
        ComboBox2.Items.Add("MBA")
        ComboBox2.Items.Add("BSE ELE")
        ComboBox2.Items.Add("MSC ELE")
    End Sub
    Sub SEM()
        ComboBox3.Items.Add("1ST")
        ComboBox3.Items.Add("2ND")
        ComboBox3.Items.Add("3RD")
        ComboBox3.Items.Add("4TH")
        ComboBox3.Items.Add("5TH")
        ComboBox3.Items.Add("6TH")
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        TextBox5.Enabled = False
        cn.Open()
        cmd = New OdbcCommand("select * from dept where dno=' " & ComboBox1.Text & " '", cn)
        Dim dr As OdbcDataReader = cmd.ExecuteReader
        While dr.Read
            TextBox5.Text = dr(1).ToString
        End While
        dr.Close()
        cn.Close()
    End Sub

    Private Sub BTN_SAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SAVE.Click
        Dim G As String
        Try
            cn.Open()
            If RB1.Checked = True Then
                G = RB1.Text
            Else
                G = RB2.Text
            End If
            If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And ComboBox1.Text <> "" Then
                cmd = New OdbcCommand("insert into stud values(' " & TextBox1.Text & " ', ' " & TextBox2.Text & " ', ' " & TextBox3.Text & " ', ' " & TextBox4.Text & " ', ' " & G & " ', ' " & Format(DTP1.Value, "yyyy/MM/dd") & " ',  ' " & ComboBox1.Text & " ',  ' " & ComboBox2.Text & " ',  ' " & ComboBox3.Text & " ')", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Record saved successfully")

            Else
                MsgBox("Enter records properly", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("DUPLICATE ENTRY RECTRICTED!!!", MsgBoxStyle.Critical)
        Finally
            cn.Close()
            'SHOWDB()
            'CLEAR()
            'AUTO_G()
        End Try


    End Sub

    Private Sub BTN_SEARCH_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_SEARCH.Click
        Dim CN As New OdbcConnection("dsn=bca4th; user=root; pwd=1031871013")
        Dim da As New OdbcDataAdapter
        Dim x As Integer
        Dim g As String
        Dim dt As New DataTable
        Try
            CN.Open()
            x = InputBox("Enter the Student id to be seaarched")
            da = New OdbcDataAdapter("select * from stud where studid=' " & x & " '", CN)
            da.Fill(dt)
            TextBox1.Text = dt.Rows(0).Item(0)
            TextBox2.Text = dt.Rows(0).Item(1)
            TextBox3.Text = dt.Rows(0).Item(2)
            TextBox4.Text = dt.Rows(0).Item(3)
            g = Trim(dt.Rows(0).Item(4))
            DTP1.Value = dt.Rows(0).Item(5)
            ComboBox1.Text = dt.Rows(0).Item(6)
            ComboBox2.Text = dt.Rows(0).Item(7)
            ComboBox3.Text = dt.Rows(0).Item(8)
            If g = "MALE" Then
                RB1.Checked = True
            Else
                RB2.Checked = True
            End If
            'DGV1.DataSource = dt
            ' GroupBox1.Hide()
            '    GroupBox2.Hide()
        Catch ex As Exception
            MsgBox("INVALID STUDENT ID ENTERED, TRY AGAIN!", MsgBoxStyle.Exclamation)
        Finally
            CN.Close()
        End Try

    End Sub

    Private Sub BTN_UPDATE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_UPDATE.Click
        'Try
        Dim g As String
        cn.Open()
        If RB1.Checked = True Then
            g = "MALE"
        Else
            g = "FEMALE"
        End If
        cmd = New OdbcCommand("update stud set sname=' " & TextBox2.Text & " ', sadd=' " & TextBox3.Text & " ',scno=' " & TextBox4.Text & " ',gender=' " & g & " ', dob=' " & Format(DTP1.Value, "yyyy/MM/dd") & " ', did=' " & ComboBox1.Text & " ' , course=' " & ComboBox2.Text & " ' , sem=' " & ComboBox3.Text & " ' where studid=' " & TextBox1.Text & " '", cn)
        cmd.ExecuteNonQuery()
        MsgBox("Record updated successfully")
        'CLEAR()
        'Catch ex As Exception
        'MsgBox("INVALID UPDATION")
        'Finally
        cn.Close()
        'SHOWDB()
        'AUTO_G()
        'End Try
    End Sub

    Private Sub BTN_DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_DELETE.Click
        'Try
        cn.Open()
        cmd = New OdbcCommand("delete from stud where studid=' " & TextBox1.Text & " '", cn)
        cmd.ExecuteNonQuery()
        MsgBox("Record is deleted successfully", MsgBoxStyle.Information)
        ' CLEAR()


        'Catch ex As Exception
        '   MsgBox("ERROR!!!")
        'Finally
        cn.Close()
        'SHOWDB()
        '  AUTO_G()
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub BTN_EXIT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_EXIT.Click
        Me.Close()
    End Sub

    
End Class