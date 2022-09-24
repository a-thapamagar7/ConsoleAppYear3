using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public static void Addition()
        {
            int number = TakeInput();
            int number2 = TakeInput();

            int answer = number + number2;
            Console.WriteLine("The sum is " + answer);
        }

        public static void Subtraction()
        {
            int number = TakeInput();
            int number2 = TakeInput();

            int answer = number - number2;
            Console.WriteLine("The difference is " + answer);
        }

        public static void Multiplication()
        {
            
            int number = TakeInput();
            int number2 = TakeInput();

            int answer = number * number2;
            Console.WriteLine("The product is " + answer);
        }

        public static void Division()
        {
            
            int number = TakeInput();
            int number2 = TakeInput();

            int answer = number / number2;
            Console.WriteLine("The division is " + answer);
        }

        public static void ConcatString()
        {
            var str = TakeInputString();
            var str2 = TakeInputString();

            string answer = str + str2;
            Console.WriteLine("The result is " + answer);
        }

        public static void ConcatString2()
        {
            string str = TakeInputString();
            string str2 = TakeInputString();

            string answer = $"{str}{str2}";
            Console.WriteLine(answer);
        }

        public static void Calculator() 
        {

            Console.WriteLine("You can write +, -, /, *");
            string op = TakeInputString();

            if (op == "+") 
            {
                Addition();
            }
            else if (op == "-")
            {
                Subtraction();
            }
            else if (op == "/")
            {
                Division();
            }
            else if (op == "*")
            {
                Multiplication();
            }
        }
    }
}
