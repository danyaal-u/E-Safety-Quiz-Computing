Imports System

Module Program
    Sub Main()

Start:
        Console.WriteLine("Welcome to danyaal's amazing E-Safety Quiz")
        Console.WriteLine("Main Menu
a) Instructions
b) Start")
        Dim menu As String = Console.ReadLine()
        menu = LCase(menu)
        If menu = "a" Then
            Console.Clear()
            Console.WriteLine("Instructions:")
            Console.WriteLine("1) When starting the quiz, a question will appear on your screen. To submit an answer for
the question, the user must type a valid answer which is one of the numbers stated in the questions. 
This number can either be a number 1 - 4")
            Console.ReadLine()
            Console.Clear()
            GoTo Start
        ElseIf menu = "b" Then
            Console.Clear()
            Console.WriteLine("Are you sure you want to start this immensly hard quiz!
State response as either 'Yes' or 'No'")
            Dim startmenu As String = Console.ReadLine()
            startmenu = LCase(startmenu)
            If startmenu = "no" Then
                Console.Clear()
                Console.WriteLine("You are truly a failure")
                Console.WriteLine("Game Over")
                Console.ReadLine()
                End
            ElseIf startmenu = "yes" Then
                Console.Clear()
                Console.WriteLine("Let the fun begin :)")
                Console.ReadLine()
            ElseIf startmenu <> "yes" & "no" Then
                Console.Clear()
                Console.WriteLine("I don't understand what you mean, please try again")
                Console.ReadLine()
                Console.Clear()
                GoTo Start
            End If
        ElseIf menu <> "a" & "b" Then
            Console.WriteLine("Sorry I don't understand that message, please try again")
            Console.ReadLine()
            Console.Clear()
            GoTo Start
        End If

        Console.Clear()

        Dim Score As Integer

QuestionOne:
        Console.WriteLine("Question One: What should you do if a stranger sends you inappropriate messages?
1) Add them back and reply with inappropriate messages back.
2) Be kind and attempt to gain a friendship.
3) Block the stranger and report them.
4) Ignore them.")
        Dim userinput As Integer = Console.ReadLine()
        Dim Q1 = "3"
        If userinput = Q1 Then
            Console.Clear()
            Console.WriteLine("Well done, you got that question correct!")
            Score += 5
            Console.WriteLine("Your score is now " & Score)
            Console.ReadLine()
        ElseIf userinput <> Q1 Then
            Console.Clear()
            Console.WriteLine("You have got the question incorrect!")
            Console.WriteLine("Would you like to try again?
Please respond with 'Yes' or 'No'")
            Dim tryagainQ1 As String = Console.ReadLine()
            tryagainQ1 = LCase(tryagainQ1)
            If tryagainQ1 = "yes" Then
                Console.Clear()
                GoTo QuestionOne
            ElseIf tryagainQ1 = "no" Then
                Console.Clear()
                Score -= 2
                Console.WriteLine("Your score is now " & Score)
                Console.ReadLine()
            End If
        End If

        Console.Clear()

QuestionTwo:
        Console.WriteLine("Question Two: What is not personal information?	
1) Your passwords to your social media accounts.
2) Your home address.
3) What school you go to.
4) What type of pen you use to write with.")
        Dim userinputQ2 As Integer = Console.ReadLine()
        Dim Q2 = "4"
        If userinputQ2 = Q2 Then
            Console.Clear()
            Console.WriteLine("Well done, you got that question correct!")
            Score += 5
            Console.WriteLine("Your score is now " & Score)
            Console.ReadLine()
        ElseIf userinputQ2 <> Q2 Then
            Console.Clear()
            Console.WriteLine("You have got the question incorrect!")
            Console.WriteLine("Would you like to try again?
Please respond with 'Yes' or 'No'")
            Dim tryagainQ2 As String = Console.ReadLine()
            tryagainQ2 = LCase(tryagainQ2)
            If tryagainQ2 = "yes" Then
                Console.Clear()
                GoTo QuestionTwo
            ElseIf tryagainQ2 = "no" Then
                Console.Clear()
                Score -= 2
                Console.WriteLine("Your score is now " & Score)
                Console.ReadLine()
            End If
        End If

        Console.Clear()

QuestionThree:
        Console.WriteLine("Question Three: What is considered a great password
1) nathencharlesworth123
2) LNRn9D3t=/h'jgnY
3) Robloxman5
4) oWen213")
        Dim userinputQ3 As Integer = Console.ReadLine()
        Dim Q3 = "2"
        If userinputQ3 = Q3 Then
            Console.Clear()
            Console.WriteLine("Well done, you got that question correct!")
            Score += 5
            Console.WriteLine("Your score is now " & Score)
            Console.ReadLine()
        ElseIf userinputQ2 <> Q2 Then
            Console.Clear()
            Console.WriteLine("You have got the question incorrect!")
            Console.WriteLine("Would you like to try again?
Please respond with 'Yes' or 'No'")
            Dim tryagainQ3 As String = Console.ReadLine()
            tryagainQ3 = LCase(tryagainQ3)
            If tryagainQ3 = "yes" Then
                Console.Clear()
                GoTo QuestionThree
            ElseIf tryagainQ3 = "no" Then
                Console.Clear()
                Score -= 2
                Console.WriteLine("Your score is now " & Score)
                Console.ReadLine()
            End If
        End If

        Console.Clear()

QuestionFour:
        Console.WriteLine("Question Four: Should passwords have personal information in?
1) Yes
2) No")
        Dim userinputQ4 As Integer = Console.ReadLine()
        Dim Q4 = "2"
        If userinputQ4 = Q4 Then
            Console.Clear()
            Console.WriteLine("Well done, you got that question correct!")
            Score += 5
            Console.WriteLine("Your score is now " & Score)
            Console.ReadLine()
        ElseIf userinputQ4 <> Q4 Then
            Console.Clear()
            Console.WriteLine("You have got the question incorrect!")
            Console.WriteLine("Would you like to try again?
Please respond with 'Yes' or 'No'")
            Dim tryagainQ4 As String = Console.ReadLine()
            tryagainQ4 = LCase(tryagainQ4)
            If tryagainQ4 = "yes" Then
                Console.Clear()
                GoTo QuestionFour
            ElseIf tryagainQ4 = "no" Then
                Console.Clear()
                Score -= 2
                Console.WriteLine("Your score is now " & Score)
                Console.ReadLine()
            End If
        End If

        Console.Clear()

QuestionFive:
        Console.WriteLine("Question Five : What might someone do if they steal your identity?
1) Try access your bank account to set up a loan in your name.
2) Earn lots of money and then give you all the money.
3) Go to your school pretending to be you so you don’t have to do any of the work.")
        Dim userinputQ5 As Integer = Console.ReadLine()
        Dim Q5 = "1"
        If userinputQ5 = Q5 Then
            Console.Clear()
            Console.WriteLine("Well done, you got that question correct!")
            Score += 5
            Console.WriteLine("Your score is now " & Score)
            Console.ReadLine()
        ElseIf userinputQ5 <> Q5 Then
            Console.Clear()
            Console.WriteLine("You have got the question incorrect!")
            Console.WriteLine("Would you like to try again?
Please respond with 'Yes' or 'No'")
            Dim tryagainQ5 As String = Console.ReadLine()
            tryagainQ5 = LCase(tryagainQ5)
            If tryagainQ5 = "yes" Then
                Console.Clear()
                GoTo QuestionFive
            ElseIf tryagainQ5 = "no" Then
                Console.Clear()
                Score -= 2
                Console.WriteLine("Your score is now " & Score)
                Console.ReadLine()
            End If
        End If

        Console.Clear()

QuestionSix:
        Console.WriteLine("Question Six : Why can it be dangerous to be downloading files from website you don’t trust?
1) The person who you ar downloading the file from will come to your house and kidnap your family.
2) You could be downloading malware.
3) It could give you Covid-18,
4) Mr Charlesworth might give you a learning attitude 4.")
        Dim userinputQ6 As Integer = Console.ReadLine()
        Dim Q6 = "2"
        If userinputQ6 = Q6 Then
            Console.Clear()
            Console.WriteLine("Well done, you got that question correct!")
            Score += 5
            Console.WriteLine("Your score is now " & Score)
            Console.ReadLine()
        ElseIf userinputQ6 <> Q6 Then
            Console.Clear()
            Console.WriteLine("You have got the question incorrect!")
            Console.WriteLine("Would you like to try again?
Please respond with 'Yes' or 'No'")
            Dim tryagainQ6 As String = Console.ReadLine()
            tryagainQ6 = LCase(tryagainQ6)
            If tryagainQ6 = "yes" Then
                Console.Clear()
                GoTo QuestionSix
            ElseIf tryagainQ6 = "no" Then
                Console.Clear()
                Score -= 2
                Console.WriteLine("Your score is now " & Score)
                Console.ReadLine()
            End If
        End If

        Console.Clear()

QuestionSeven:
        Console.WriteLine("Question Seven: What program could you use to get rid of viruses?
1) A vaccine.
2) Storage Cleaner 3000
3) Real Anti-Virus 9102
4) Virus Downloader")
        Dim userinputQ7 As Integer = Console.ReadLine()
        Dim Q7 = "3"
        If userinputQ7 = Q7 Then
            Console.Clear()
            Console.WriteLine("Well done, you got that question correct!")
            Score += 5
            Console.WriteLine("Your score is now " & Score)
            Console.ReadLine()
        ElseIf userinputQ7 <> Q7 Then
            Console.Clear()
            Console.WriteLine("You have got the question incorrect!")
            Console.WriteLine("Would you like to try again?
Please respond with 'Yes' or 'No'")
            Dim tryagainQ7 As String = Console.ReadLine()
            tryagainQ7 = LCase(tryagainQ7)
            If tryagainQ7 = "yes" Then
                Console.Clear()
                GoTo QuestionSeven
            ElseIf tryagainQ7 = "no" Then
                Console.Clear()
                Score -= 2
                Console.WriteLine("Your score is now " & Score)
                Console.ReadLine()
            End If
        End If

        Console.Clear()

QuestionEight:
        Console.WriteLine("Question Eight: How long does something stay on the internet?
1) 5 to 7 working days.
2) A couple hours.
3) Forever until you delete it.
4) Forever no matter what.")
        Dim userinputQ8 As Integer = Console.ReadLine()
        Dim Q8 = "4"
        If userinputQ8 = Q8 Then
            Console.Clear()
            Console.WriteLine("Well done, you got that question correct!")
            Score += 5
            Console.WriteLine("Your score is now " & Score)
            Console.ReadLine()
        ElseIf userinputQ8 <> Q8 Then
            Console.Clear()
            Console.WriteLine("You have got the question incorrect!")
            Console.WriteLine("Would you like to try again?
Please respond with 'Yes' or 'No'")
            Dim tryagainQ8 As String = Console.ReadLine()
            tryagainQ8 = LCase(tryagainQ8)
            If tryagainQ8 = "yes" Then
                Console.Clear()
                GoTo QuestionEight
            ElseIf tryagainQ8 = "no" Then
                Console.Clear()
                Score -= 2
                Console.WriteLine("Your score is now " & Score)
                Console.ReadLine()
            End If
        End If

        Console.Clear()

QuestionNine:
        Console.WriteLine("Question Nine : Definition of Trolling?
1) To wind someone up.
        2) To make someone laugh.
        3) To physically abuse a police officer.
        4) To post something on social media.")
        Dim userinputQ9 As Integer = Console.ReadLine()
        Dim Q9 = "1"
        If userinputQ9 = Q9 Then
            Console.Clear()
            Console.WriteLine("Well done, you got that question correct!")
            Score += 5
            Console.WriteLine("Your score is now " & Score)
            Console.ReadLine()
        ElseIf userinputQ9 <> Q9 Then
            Console.Clear()
            Console.WriteLine("You have got the question incorrect!")
            Console.WriteLine("Would you like to try again?
Please respond with 'Yes' or 'No'")
            Dim tryagainQ9 As String = Console.ReadLine()
            tryagainQ9 = LCase(tryagainQ9)
            If tryagainQ9 = "yes" Then
                Console.Clear()
                GoTo QuestionNine
            ElseIf tryagainQ9 = "no" Then
                Console.Clear()
                Score -= 2
                Console.WriteLine("Your score is now " & Score)
                Console.ReadLine()
            End If
        End If

        Console.Clear()

QuestionTen:
        Console.WriteLine("Question Ten : Why should you not post your location on social media?
1) Your parents told you not to so you shouldn’t.
2) The government will be able to track you.
3) Someone might go to you house while you’re out and burgle it.
4) Your parents will be able to track where you’ve been.")
        Dim userinputQ10 As Integer = Console.ReadLine()
        Dim Q10 = "3"
        If userinputQ10 = Q10 Then
            Console.Clear()
            Console.WriteLine("Well done, you got that question correct!")
            Score += 5
            Console.WriteLine("Your score is now " & Score)
            Console.ReadLine()
        ElseIf userinputQ10 <> Q10 Then
            Console.Clear()
            Console.WriteLine("You have got the question incorrect!")
            Console.WriteLine("Would you like to try again?
Please respond with 'Yes' or 'No'")
            Dim tryagainQ10 As String = Console.ReadLine()
            tryagainQ10 = LCase(tryagainQ10)
            If tryagainQ10 = "yes" Then
                Console.Clear()
                GoTo QuestionTen
            ElseIf tryagainQ10 = "no" Then
                Console.Clear()
                Score -= 2
                Console.WriteLine("Your score is now " & Score)
                Console.ReadLine()
            End If
        End If

        Console.Clear()

        Console.WriteLine("Thank you for playing my quiz :)")
        Console.WriteLine("Your total score this session was " & Score)
        If Score <= 10 Then
            Console.WriteLine("You did Terrible")
            Console.WriteLine("Thank you for playing my quiz!")
            Console.ReadLine()
        ElseIf Score <= 20 Then
            Console.WriteLine("You did pretty bad, maybe next time will be better.")
            Console.WriteLine("Thank you for playing my quiz!")
        ElseIf Score >= 25 Then
            Console.WriteLine("You did okay, at least you got to the half way mark")
            Console.WriteLine("Thank you for playing my quiz!")
        ElseIf Score >= 35 Then
            Console.WriteLine("You did great!")
            Console.WriteLine("Thank you for playing my quiz")
        ElseIf Score <= 50 Then
            Console.WriteLine("You did outstanding, you are surely a true E-Safety Master!")
            Console.WriteLine("Thank you for playing my quiz!")
        End If

        Console.Clear()

PlayAgain:
        Console.WriteLine("Would you like to play again?")
        Console.WriteLine("Please state 'Yes' or 'No'")
        Dim playagain As String = Console.ReadLine()
        playagain = LCase(playagain)
        If playagain = "yes" Then
            Console.Clear()
            GoTo Start
        ElseIf playagain = "no" Then
            Console.Clear()
            Console.WriteLine("Thank you for playing my game")
            Console.ReadLine()
            End
        ElseIf playagain <> "yes" Or "no" Then
            Console.WriteLine("I didn't quite understand that, please try again")
            Console.ReadLine()
            GoTo PlayAgain
        End If

    End Sub
End Module
