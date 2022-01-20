' Assignment Title: Report Card Assignment
' Description: This program will allow the user to enter their subjects and grades for the semester. and then output a "Report Card"


Module VBModule
    Sub Main()
        'Create the variables and arrays we will need. 
        'We will have 4 marks and 4 subjects. The marks will be numbers (integers: "90"%) and the subjects will be strings 
        Dim instructionsString as string = "Please enter your Subject and then grade for the subject! (do this for all 4 subjects)"
        Dim subjectsArrStr(5) As string
        Dim marksArrInt(5) As Integer 
        Dim reportCardArr(5) As string
        Dim overallAverage As Double
        Dim overallAverageMessage As string
        
        
        'Get the information from the user using a loop. CStr() is used to convert a Integer to a String.
         For i As Integer = 1 to 4
            Console.WriteLine("Please Enter your Subject " & CStr(i) & " Name:(E.g: Math, English, History, Science..)")
            subjectsArrStr(i) = Console.ReadLine()
            Console.WriteLine("Please Enter the mark you received for subject " & CStr(i) & ": (E.g: 80, 90, 10, 65..)")
            marksArrInt(i) = Console.ReadLine()
         Next i
         
         'Add a little Claculating message.
         Console.WriteLine("Calculating report card....")
         
         'now We need to calculate the report card. and determine what level they got for each subject and add it to the reportCardArr to easily display to the user later. 
         For i As Integer =  1 to 4
            'check if the mark is a fail (r)
            If marksArrInt(i) < 50 then
            'The mark is a fail (r)
            reportCardArr(i) = "Subject " & CStr(i) & " " + subjectsArrStr(i) & ": " & marksArrInt(i) & "% (R)"
            Else If marksArrInt(i) >= 50 And marksArrInt(i) <= 59 Then
            'The mark is between 50 - 59% Level 1
            reportCardArr(i) = "Subject " & CStr(i) & " " & subjectsArrStr(i) & ": " & marksArrInt(i) & "% (Level 1)"
            Else If marksArrInt(i) > 59 And marksArrInt(i) <= 69 Then
            'The mark is between 60 and 69 Level 2
            reportCardArr(i) = "Subject " + CStr(i) & " " & subjectsArrStr(i) & ": " & marksArrInt(i) & "% (Level 2)"
            Else If marksArrInt(i) > 69 And marksArrInt(i) <= 79 Then
            'The mark is between 70 and 79 Level 3
            reportCardArr(i) = "Subject " + CStr(i) & " " & subjectsArrStr(i) & ": " & marksArrInt(i) & "% (Level 3)"
            Else If marksArrInt(i) > 79 And marksArrInt(i) <= 100 Then
            'the mark is between 80 and 100 Level 4
            reportCardArr(i) = "Subject " + CStr(i) & " " & subjectsArrStr(i) & ": " & marksArrInt(i) & "% (Level 4)"
            End If
         Next i
         
         'Lets calculate the overall...
         overallAverage = (marksArrInt(1) + marksArrInt(2) + marksArrInt(3) + marksArrInt(4)) / 4
         'Create a nice message dependent on the mark they got.
         If overallAverage < 50 Then
         overallAverageMessage = "Better luck next time.."
         Else If overallAverage >= 50 And overallAverage <= 59 Then
         overallAverageMessage = "You passed, but you need some improvements..."
         Else If overallAverage >= 59 And overallAverage <= 69 Then
         overallAverageMessage = "You did okay.. Continue to improve.."
         Else If overallAverage >= 69 And overallAverage <= 79 Then
         overallAverageMessage = "Good job.. Keep pushing yourself.."
         Else If overallAverage >= 79 And overallAverage <= 100 Then
         overallAverageMessage = "You did an awesome job this semester.. Keep up the great work..."
         End If
         
         'Add a little Calulation complete message.
         Console.WriteLine("Calculation Complete.. Generating Report card....")
         
         'Eveything is calculated and stored. LEts display the info to the user. 
         Console.WriteLine("************************ Report Card **************************")
         Console.WriteLine(vbNewLine)
         For i As Integer = 1 to 4
            console.WriteLine(reportCardArr(i))
         Next i
         
         Console.WriteLine(vbNewLine)
         Console.WriteLine("******************** Semester Average *************************")
         Console.WriteLine(vbNewLine)
         
         'Now lets display the overallAverage and overallAverageMessage
         console.WriteLine("Semester Average: " & overallAverage & "%")
         Console.WriteLine(overallAverageMessage)
         Console.WriteLine(vbNewLine)
         Console.WriteLine("***************************************************************")
         
    End Sub
End Module
