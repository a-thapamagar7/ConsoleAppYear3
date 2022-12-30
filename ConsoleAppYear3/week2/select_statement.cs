using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppYear3.week2
{
    internal class select_statement
    {
        public static void IfElse()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("1st number is greater");
            }
            else if (a < b)
            {
                Console.WriteLine("2nd number is greater");
            }
            else
            {
                Console.WriteLine("They are equal");
            }
        }

        public static void Switch()
        {
            Console.WriteLine("Press 1 for apple");
            Console.WriteLine("Press 2 for orange");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Apple");
                    break;
                case "2":
                    Console.WriteLine("Orangle");
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;
            }
        }
    }
}
