Module even_range

    Sub Main()
        Dim r, no As Integer
        Console.Write("Enter the range:")
        r = Console.ReadLine

        Console.WriteLine("using for loop")
        For no = 1 To r
            If no Mod 2 = 0 Then
                Console.WriteLine(no)
            End If
        Next

        Console.WriteLine("using do while..loop")
        no = 1
        Do While no <= r
            If no Mod 2 = 0 Then
                Console.WriteLine(no)
            End If
            no = no + 1
        Loop

        Console.WriteLine("using do..loop while")
        no = 1
        Do
            If no Mod 2 = 0 Then
                Console.WriteLine(no)
            End If
            no = no + 1
        Loop While no <= r

        Console.WriteLine("using do..loop until")
        no = 1
        Do
            If no Mod 2 = 0 Then
                Console.WriteLine(no)
            End If
            no = no + 1
        Loop Until no > r


        Console.ReadLine()
    End Sub

End Module
