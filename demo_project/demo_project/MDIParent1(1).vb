﻿Imports System.Data.Odbc
Public Class Payment

    Private Sub fees_fines_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cn As New OdbcConnection("dsn=mini_project; user=root; pwd=1031871013")
        Dim cmd As New OdbcCommand
        'Try
        cn.Open()

        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> " " And TextBox5.Text <> "  " And TextBox6.Text <> "" And TextBox7.Text <> "" Then
            cmd = New OdbcCommand("insert into student values(' " & TextBox1.Text & " ', ' " & TextBox2.Text & " ', ' " & TextBox3.Text & " ', ' " & Format(DateTimePicker1.Value, "yyyy/MM/dd") & " ', ' " & Format(DateTimePicker2.Value, "yyyy/MM/dd") & " ', ' " & TextBox4.Text & " ', ' " & TextBox5.Text & " ', ' " & TextBox6.Text & " ' , ' " & TextBox7.Text & "  ')", cn)
            cmd.ExecuteNonQuery()
            MsgBox("Record saved successfully")
        Else
            MsgBox("Enter records properly", MsgBoxStyle.Information)
        End If
        'Catch ex As Exception
        '    MsgBox("Enter data properly", MsgBoxStyle.Critical)
        'Finally
        'End Try
        cn.Close()
    End Sub
End Class                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\bin\Debug\PracticalinWindows.exe
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\bin\Debug\PracticalinWindows.pdb
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\bin\Debug\PracticalinWindows.xml
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\ResolveAssemblyReference.cache
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\PracticalinWindows.areaoftrc.resources
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\PracticalinWindows.evenodd.resources
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\PracticalinWindows.MDIParent1.resources
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\PracticalinWindows.Resources.resources
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\PracticalinWindows.Quadratic.resources
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\Raw_Newton.vbproj.GenerateResource.Cache
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\PracticalinWindows.exe
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\PracticalinWindows.xml
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\PracticalinWindows.pdb
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\PracticalinWindows.prime_or_not.resources
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\PracticalinWindows.Print_even.resources
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\PracticalinWindows.Print_prime.resources
D:\LENOVO\Documents\Visual Studio 2008\Projects\PracticalinWindows\PracticalinWindows\obj\Debug\PracticalinWindows.Armstrong.resources
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         