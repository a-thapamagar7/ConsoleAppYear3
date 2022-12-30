// See https://aka.ms/new-console-template for more information



using ConsoleAppYear3.New;
using Year3ConsoleApp.Basics;
using System;
using ConsoleAppYear3.week2;
using ConsoleAppYear3.week3;

Boolean exit = false;
while (exit == false)
{
    int num1 = 0; int num2 = 0;

    Console.WriteLine("Console Calculator in C#\r");
    Console.WriteLine("------------------------\n");

    Console.WriteLine("Choose an option from the following list:");
    Console.WriteLine("Press 1 for Addition");
    Console.WriteLine("Press 2 for Subtraction");
    Console.WriteLine("Press 3 for Multiplication");
    Console.WriteLine("Press 4 for Division");
    Console.WriteLine("Press 5 for Jagged Arrays");
    Console.WriteLine("Press 6 for SingleDimensional Arrays");
    Console.WriteLine("Press 7 for ImplicitlyTyped Arrays");
    Console.WriteLine("Press 8 for MultiDimensional Arrays");
    Console.WriteLine("Press 9 for if else");
    Console.WriteLine("Press 10 for Switch");
    Console.WriteLine("Press 11 Do While");
    Console.WriteLine("Press 12 While");
    Console.WriteLine("Press 13 for For");
    Console.WriteLine("Press 14 for For Each");
    Console.WriteLine("Press 15 for Prime and Composite");
    Console.WriteLine("Press 16 for Odd and Even");
    Console.WriteLine("Press 17 for Swap");
    Console.WriteLine("Press 18 for Search String");
    Console.WriteLine("Press 0 for exit");
    Console.Write("Your option? ");

    string userResponse = Console.ReadLine();

    if (userResponse == "1" || userResponse == "2" || userResponse == "3" || userResponse == "4")
    {
        num1 = Class1.TakeInput();
        num2 = Class1.TakeInput();
    }
    switch (userResponse)
    {

        case "1":
            Class1.Addition(num1, num2);
            break;
        case "2":
            Class1.Subtraction(num1, num2);
            break;
        case "3":
            Class1.Multiplication(num1, num2);
            break;
        case "4":
            Class1.Division(num1, num2);
            break;
        case "5":
            Arrays.JaggedArray();
            break;
        case "6":
            Arrays.SingleDimensionalArray();
            break;
        case "7":
            Arrays.ImplicitlyTypedArray();
            break;
        case "8":
            Arrays.MultiDimensionalArray();
            break;
        case "9":
            select_statement.IfElse();
            break;
        case "10":
            select_statement.Switch();
            break;
        case "11":
            iteration_statement.Do_While();
            break;
        case "12":
            iteration_statement.While();
            break;
        case "13":
            iteration_statement.For_Loop();
            break;
        case "14":
            iteration_statement.Foreach_Loop();
            break;
        case "15":
            Questions.PrimeOrComposite();
            break;
        case "16":
            Questions.OddOrEven(); ;
            break;
        case "17":
            Questions.Swap(); ;
            break;
        case "18":
            Questions.SearchString(); ;
            break;
        default:
            Interpolation.StringInterpolation();
            break;
    }
    Console.Write("Do you want to continue y/n");
    string answer = Console.ReadLine();
    if (answer == "n")
    {
        exit = true;
    }
}
// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();