using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coh06Ex04
{
    class Program
    {
        //乘法表
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++) 
            {
                for (int j = 1; j <= 9; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
