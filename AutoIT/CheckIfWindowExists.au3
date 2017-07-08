#cs ----------------------------------------------------------------------------

 AutoIt Version: 3.3.14.2
 Author:         Ray Nieva

 Script Function:
	Check to see If Window Exists AutoIT script.

#ce ----------------------------------------------------------------------------

; Script Start - Add your code below here

#include <MsgBoxConstants.au3>

Local $X = WinExists("Network and Sharing Center")
If  $X=1 Then
  MsgBox($MB_OK, "Checking for Window", "Network and Sharing Center is Open")
Else
  MsgBox($MB_OK, "Checking for Window", "Network and Sharing Center is NOT Open")
  MsgBox($MB_OK, "Open Window", "Will Start Network and Sharing Center")
  Run ("explorer shell:::{8E908FC9-BECC-40f6-915B-F4CA0E70D03D}")
EndIF