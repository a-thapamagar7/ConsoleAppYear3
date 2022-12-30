using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppYear3.week3
{
    internal class Questions
    {
        public static void PrimeOrComposite()
        {
            Console.WriteLine("Enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            bool composite = false;
            for (int i = 2; i < input; i++)
            {
                if (input % i == 0)
                {
                    composite = true;
                    break;
                }

            }
            if (composite) Console.WriteLine("The number is composite");
            else Console.WriteLine("The number is prime");
        }

        public static void OddOrEven()
        {
            Console.WriteLine("Enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input % 2 == 0) Console.WriteLine("The number is even");
            else Console.WriteLine("The number is odd");
        }

        public static void Swap()
        {
            Console.WriteLine("Enter a number");
            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number");
            int input2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The first number is " + input);
            Console.WriteLine("The first number is " + input2);
            int temp = input;
            input = input2;
            input2 = temp;
            Console.WriteLine("The first number is " + input);
            Console.WriteLine("The first number is " + input2);
        }

        public static void SearchString()
        {
            Console.WriteLine("Enter a string");
            String input = Console.ReadLine();
            String[] ram = { "ram", "shyam", "cat" };
            bool found = false;
            for (int i = 0; i < ram.Length; i++)
            {
                if (input.ToUpper() == ram[i].ToUpper())
                {
                    Console.WriteLine("The index of the number found is " + i);
                    found = true;
                    break;
                }
            }
            if (!found) Console.WriteLine("The string is not found");
        }
    }
}
