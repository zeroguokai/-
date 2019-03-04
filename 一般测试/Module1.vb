Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim a As New Regex("def?")
        Console.WriteLine(a.Match("ddddecfffff"))
        Console.ReadLine()

    End Sub



End Module