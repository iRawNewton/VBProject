Imports System.Data.Odbc
Public Class Dept
    'GLOBAL DECLARATION
    Dim cn As New OdbcConnection("dsn=bca4th; user=root; pwd=1031871013")
    Dim cmd As New OdbcCommand
    Sub SHOWDB()
        Dim da As New OdbcDataAdapter
        Dim dt As New DataTable
               cn.Open()
        da = New OdbcDataAdapter("select * from dept", cn)
        da.Fill(dt)
        DGV1.DataSource = dt
        cn.Close()
    End Sub
    Sub CLEAR()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox2.Focus()
    End Sub
    Sub AUTO_G()
        TextBox1.Enabled = False
        cn.Open()
        cmd = New OdbcCommand("select max(dno)+1 from dept", cn)
        If IsDBNull(cmd.ExecuteScalar) Then
            TextBox1.Text = 1
        Else
            TextBox1.Text = cmd.ExecuteScalar
        End If
        cn.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim cn As New OdbcConnection("dsn=bca4th; user=root; pwd=1031871013")
        Dim cmd As New OdbcCommand
        Try
            cn.Open()
            If TextBox1.Text <> "" And TextBox2.Text <> "" Then
                cmd = New OdbcCommand("insert into dept values(' " & TextBox1.Text & " ', ' " & TextBox2.Text & " ')", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Record saved successfully")

            Else
                MsgBox("Enter records properly", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox("DUPLICATE ENTRY RECTRICTED!!!", MsgBoxStyle.Critical)
        Finally
            cn.Close()
            SHOWDB()
            CLEAR()
            AUTO_G()
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim CN As New OdbcConnection("dsn=bca4th; user=root; pwd=1031871013")
        Dim da As New OdbcDataAdapter
        Dim x As Integer
        Dim dt As New DataTable
        Try
            CN.Open()
            x = InputBox("Enter the dept number to be seaarched")
            da = New OdbcDataAdapter("select * from dept where dno=' " & x & " '", CN)
            da.Fill(dt)
            TextBox1.Text = dt.Rows(0).Item(0)
            TextBox2.Text = dt.Rows(0).Item(1)
            DGV1.DataSource = dt
            ' GroupBox1.Hide()
            '    GroupBox2.Hide()
        Catch ex As Exception
            MsgBox("INVALID DEPT NUMBER ENTERED, TRY AGAIN!", MsgBoxStyle.Exclamation)
        Finally
            CN.Close()
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            cn.Open()
            cmd = New OdbcCommand("update dept set dname=' " & TextBox2.Text & " ' where dno=' " & TextBox1.Text & " '", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record updated successfully")
            CLEAR()
        Catch ex As Exception
            MsgBox("INVALID UPDATION")
        Finally
            cn.Close()
            SHOWDB()
            AUTO_G()
        End Try


    End Sub

    Private Sub Dept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox2.Focus()
        SHOWDB()
        CLEAR()
        AUTO_G()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'Try
        cn.Open()
        cmd = New OdbcCommand("delete from dept where dno=' " & TextBox1.Text & " '", cn)
        cmd.ExecuteNonQuery()
        MsgBox("Record is deleted successfully", MsgBoxStyle.Information)
        CLEAR()


        'Catch ex As Exception
        '   MsgBox("ERROR!!!")
        'Finally
        cn.Close()
        SHOWDB()
        AUTO_G()
        ' End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub
End Class
