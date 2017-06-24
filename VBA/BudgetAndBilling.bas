Option Explicit

Sub Main
    ' This program is intended to be used to calculate my weekly budget based on income that week and projected expenses that week.
    Output "Calculating Weekly/ Budget"
    
    ' This is usually weekly (net) income but can be another period like bi-weekly or monthly
    Output "Get Income for week/period"
    Dim income1 As Double
    
    income1 = InputValue("income1")
    
    ' At this point start inputting billing items. These are essentially billing items for the current week or period. 
    ' The question is at this point what direction this program will go? Will there be permanently assigned billing items or billing items adhoc defined each week. Can Flowgorithm define a true OO approach?
End Sub

' The following functions are called whenever the program needs to input or output data.
' You can change these functions to use other controls rather than pop-up windows.

Function InputValue (Name As String) As Double
    InputValue = Val(InputBox("Please enter a value for " & Name))
End Function

Function InputText (Name As String) As String
    InputText = InputBox("Please enter a value for " & Name)
End Function

Sub Output (Text As String)
    Msgbox Text
End Sub
