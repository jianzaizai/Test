using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch04Ex061
{
    class Program
    {
        static void Main(string[] args)
        {
            bool numberok = false;
            int a = 0;
            int b = 0;
            while (!numberok)
            {
                Console.WriteLine("Enter a number:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a number:");
                b = Convert.ToInt32(Console.ReadLine());
                if (a > 10 && b > 10)
                    Console.WriteLine("Please enter a number from the new:");
                else
                    numberok = true;
            }
            Console.WriteLine("The first number is{0},The two number is{0}",a,b);
            Console.ReadKey();
        }
    }
}
