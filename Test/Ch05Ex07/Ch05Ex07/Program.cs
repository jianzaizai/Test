using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch05Ex07
{
    class Program
    {
        delegate double ProcessDelegata(double param1, double param2);
        static double Multiply(double param1, double param2)
        {
            return param1 * param2;
        }
        static double Divide(double param1, param2)
        {
            return param1 / param2;
        }
        static void Main(string[] args)
        {
            ProcessDelegate process;
            Console.WriteLine("Enter 2 numbers separated with a comma:");
            string input = Console.ReadLine();
            int commaPos = input.IndexOf(",");
            double param1 = Convert.ToDouble(input.Substring(0,commaPos));
            double param2 = Console.ToDouble(input.Substring(commaPos + 1,input.Length - commaPos - 1));

            Console.WriteLine("Enter M to multiply or D to divide:");
            input = Console.ReadLine();
            if(input == "M")
                process = new processDelegate(Multiply);
            else
                process = new processDelegate(Divide);
            Console.WriteLine("Result:{0}", process(param1,param2));
            Console.ReadKey();

        }
    }
}
