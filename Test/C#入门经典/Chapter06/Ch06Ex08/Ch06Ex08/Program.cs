using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06Ex08
{
    class Program
    {

        static void Main(string[] args)
        {
            int[] num = { -5, -11, 5, 0, 19, 30 };
     
            int max;
            int min;
            Max(num, out max);
            Console.WriteLine(max);
            Min(num, out min);
            Console.WriteLine(min);
            Console.ReadKey();
        }
        static void Max(int[] num, out int max)
        {
            int m = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (m < num[i])
                {
                    m = num[i];
                }
            }

            max = m;
        }

        public static void Min(int[] num, out int min)
        {
            int m = 0;
            for(int i = 0;i < num.Length;i++)
            {
                if(m>num[i])
                {
                    m = num[i];
                }
             
            }
               min = m;
         }
      }
}

