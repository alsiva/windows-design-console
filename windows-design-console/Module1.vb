Module Module1

    Sub Main()
        Const a As String = "###############"
        Const b As String = "#-------------#"
        Const c As String = "#------#------#"
        Const d As String = "#----#---#----#"
        Const x As String = "#----#--------#"
        Const y As String = "#--------#----#"

        Console.ForegroundColor = ConsoleColor.Cyan
        Console.WriteLine(a)

        For i = 1 To 3
            Console.WriteLine(d)
        Next
        Console.WriteLine(a)
        For i = 1 To 9
            Console.WriteLine(b)
        Next
        Console.WriteLine(a)
        Console.WriteLine("")
        Console.ForegroundColor = ConsoleColor.Yellow
        For i = 1 To 2
            Console.WriteLine(a)
            For j = 1 To 3
                Console.WriteLine(x)
            Next
            Console.WriteLine(a)
            For n = 1 To 3
                Console.WriteLine(y)
            Next
        Next
        Console.WriteLine(a)
        Console.ReadKey()
    End Sub

End Module
