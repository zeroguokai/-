Imports System.Text.RegularExpressions
Module Module1

    Sub Main()
        Dim a As New Regex("def?")
        Console.WriteLine(a.Match("ddddecffffff"))
        Console.WriteLine("第二次修改")
        Console.ReadLine()

    End Sub



End Module