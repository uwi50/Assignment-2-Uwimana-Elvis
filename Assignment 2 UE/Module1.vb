Module Module1
    Dim accountList As List(Of AccInfo) = New List(Of AccInfo)
    Sub Main()
        Dim choice As String
        Console.WriteLine(" ------------------------------")
        Console.WriteLine("|  Welcome to Our Bank System  |")
        Console.WriteLine(" ------------------------------")
        Do
            Console.WriteLine(" ")
            Console.Write(" 1.Add Account Information " & vbNewLine & " 2.Display Accounts Information" & vbNewLine & " 3.Exit" & vbNewLine & vbNewLine & "Choose an option(1,2 or 3): ")
            choice = Console.ReadLine()
            Select Case choice
                Case "1"
                    AddAccountInfo()
                Case "2"
                    DisplayAccountInfo()
                Case "3"
                    Console.WriteLine("See you soon, Hope you've Enjoyed using our system.")
                    Exit Do
                Case Else
                    Console.Write("Invalid choice Choose between the 3 Options")
                    Console.WriteLine(" ")
            End Select
        Loop While choice <> "3" Or choice <> "exit" Or choice <> "Exit"
        Console.ReadLine()
    End Sub
    Sub AddAccountInfo()
        Dim AccNumber, Name, Address, Email As String
        Dim Balance As Decimal

        Do
            Console.WriteLine(" ")
            Console.Write("Account number: ")
            AccNumber = Console.ReadLine()
            If AccNumber = "" Or AccNumber = "Exit" Or AccNumber = "exit" Then
                Exit Sub
            End If
            Console.Write("Name of Account Holder: ")
            Name = Console.ReadLine()
            Console.Write("Address of Account Holder: ")
            Address = Console.ReadLine()
            Console.Write("Email of Account Holder: ")
            Email = Console.ReadLine()
            Console.Write("Account Balance: ")
            Balance = Console.ReadLine()

            accountList.Add(New AccInfo(AccNumber, Name, Address, Email, Balance))

        Loop While AccNumber <> "" Or AccNumber <> "Exit" Or AccNumber <> "exit"
    End Sub
    Sub DisplayAccountInfo()

        For Each info In accountList
            Console.WriteLine(info)

        Next
        Console.ReadLine()
    End Sub

End Module