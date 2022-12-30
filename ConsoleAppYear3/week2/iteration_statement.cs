using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppYear3.week2
{
    internal class iteration_statement
    {
        public static void Do_While()
        {
            
            int num = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine(num);
                num++;
            }
            while (num < 10);
        }
        
        public static void While()
        {
            
            int num = Convert.ToInt32(Console.ReadLine());
            while (num < 10)
            {
                Console.WriteLine(num);
                num++;
            }
            
        }

        public static void For_Loop()
        {
            int[] ram = { 10, 20, 30, 40 };
            for (int i = 0; i < ram.Length; i++)
            {
                Console.WriteLine(ram);
            }
        }

        public static void Foreach_Loop()
        {
            int[] ram = { 10, 20, 30, 40 };
            foreach (int i in ram)
            {
                Console.WriteLine(i);
            }

        }
    }
}
