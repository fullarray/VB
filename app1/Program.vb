Imports System

Module Program
    Sub Main(args As String())
        'Program p = New Program ()
        Console.WriteLine("Hello World!")
        MyOne()
        MyTwo()
    End Sub

    Sub MyOne()
        Dim digit as Integer
        Dim stuff as String        
        digit = 1

        stuff = "Hello "
        Console.Write(stuff)
    End Sub

    Sub MyTwo()
        Dim digit as Integer
        Dim stuff as String
        digit = 2
        stuff = "World!"
        Console.Write(stuff)
    End Sub            
End Module
