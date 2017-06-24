Imports System

Public Module MyProgram
    Sub Main
        ' This program is intended to be used to calculate my weekly budget based on income that week and projected expenses that week.
        Console.WriteLine("Calculating Weekly/ Budget")
        
        ' This is usually weekly (net) income but can be another period like bi-weekly or monthly
        Console.WriteLine("Get Income for week/period")
        Dim income1 As Double
        
        input(income1)
        
        ' At this point start inputting billing items. These are essentially billing items for the current week or period. 
        ' The question is at this point what direction this program will go? Will there be permanently assigned billing items or billing items adhoc defined each week. Can Flowgorithm define a true OO approach?
    End Sub
    
    ' .NET can only read single characters or entire lines from the console.
    ' The following functions are designed to help input specific data types.
    
    Private Sub input(ByRef result As Double)
        While Not Double.TryParse(Console.ReadLine(), result)
            ' No code in the loop
        End While
    End Sub
    
    Private Sub input(ByRef result As Integer)
        While Not Integer.TryParse(Console.ReadLine(), result)
            ' No code in the loop
        End While
    End Sub
    
    Private Sub input(ByRef result As Boolean)
        While Not Boolean.TryParse(Console.ReadLine(), result)
            ' No code in the loop
        End While
    End Sub
    
    Private Sub input(ByRef result As String)
        result = Console.ReadLine();
    End Sub
End Module
