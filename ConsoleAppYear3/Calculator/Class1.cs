using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Year3ConsoleApp.Basics;

namespace ConsoleAppYear3.New
{
    internal class Class1
    {
        public static int TakeInput()
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        public static string TakeInputString()
        {
            Console.WriteLine("Enter the string");
            string number = Console.ReadLine();
            return number;
        }

        public static void Addition(int number, int number2)
        {
            int answer = number + number2;
            Console.WriteLine("The sum is " + answer);
        }

        public static void Subtraction(int number, int number2)
        {

            int answer = number - number2;
            Console.WriteLine("The difference is " + answer);
        }

        public static void Multiplication(int number, int number2)
        {

            int answer = number * number2;
            Console.WriteLine("The product is " + answer);
        }

        public static void Division(int number, int number2)
        {

            int answer = number / number2;
            Console.WriteLine("The division is " + answer);
        }

        public static void ConcatString(string str, string str2)
        {

            string answer = str + str2;
            Console.WriteLine("The result is " + answer);
        }

        public static void ConcatString2(string str, string str2)
        {

            string answer = $"{str}{str2}";
            Console.WriteLine(answer);
        }

        Boolean exit = false;

        public static void Method()
        {
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

        }


    }
}
