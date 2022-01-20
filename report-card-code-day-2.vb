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
        
        '********************************************* DAY 2 Variables *********************************************
        Dim bestGrade As Integer
        Dim bestSubject As String
        
        Dim worstGrade As Integer
        Dim worstSubject As String
        '***********************************************************************************************************
        
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
         
         '********************************** DAY 2 CODE ******************************************
         
            'Use a For loop to figure out what the highest mark was.
             bestGrade = marksArrInt(1) 'set the first mark as the bestGrade
            'use this loop to compare the bestGrade to each of the grades stored in the marksArrInt. The highest grade will be stored in bestGrade
            For i As Integer = 1 To 4
                If marksArrInt(i) >= bestGrade Then 
                bestGrade = marksArrInt(i) 'if another element is larger, then it is the max
                
                bestSubject = subjectsArrStr(i)
                End If
            Next i
            
            
            'Use a For loop to figure out what the lowest mark was.
            worstGrade = marksArrInt(1) 'set the first mark as the bestGrade
            'use this loop to compare the worstGrade to each of the grades stored in the marksArrInt. The lowest grade will be stored in worstGrade
            For i As Integer = 1 To 4
                If marksArrInt(i) <= worstGrade Then 
                worstGrade = marksArrInt(i) 'if another element is smaller, then it is the worstGrade
                worstSubject = subjectsArrStr(i)
                End If
            Next j
         
         '****************************************************************************************
         
         
         
         
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
         console.WriteLine("Semester Average: " & CStr(overallAverage) & "%")
         Console.WriteLine(overallAverageMessage)
         Console.WriteLine(vbNewLine)
         
         '**************************************************** DAY 2 CODE ***************************************************
         
         'Lets echo out the best and worst grades.
         Console.WriteLine("******************** Best and Worst Grades / Subjects *************************")
         Console.WriteLine(vbNewLine)
         
         'Now lets display the Best Grade.
         Console.WriteLine("Best Subject: " & bestSubject & " Grade: " & CStr(bestGrade) & "%")
         'Now lets display the Best Grade.
         Console.WriteLine("Worst Subject: " & worstSubject & " Grade: " & CStr(worstGrade) & "%")
         
         Console.WriteLine(vbNewLine)
         Console.WriteLine("**************************** Honor Role ***************************************")
         Console.WriteLine(vbNewLine)
        'we will use a for loop to loop through the grades and only show them to the user if they are above 80%
        For i As Integer = 1 to 4
            If marksArrInt(i) >= 80 Then
                Console.WriteLine("Subject: " & subjectsArrStr(i) & " Grade: " & marksArrInt(i) & "%")
            End If
        Next i
        Console.WriteLine(vbNewLine)

        
         Console.WriteLine("********************* Failed Classes (No Credit Earned) ***********************")
         Console.WriteLine(vbNewLine)
        'we will use a for loop to loop through the grades and only show them to the user if they are below 50%
        For i As Integer = 1 to 4
            If marksArrInt(i) < 50 Then
                Console.WriteLine("Subject: " & subjectsArrStr(i) & " Grade: " & marksArrInt(i) & "%")
            End If
        Next i
        
        Console.WriteLine(vbNewLine)
        Console.WriteLine("************************* Report Card end *******************************")
        
        '****************************************************************************************

    End Sub
End Module
