using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06Ex003
{
    class Program
    {
        static int SumVals(params int[] vals) //params不限参数个数
        {
            int sum = 0;
            foreach (int val in vals) //foreach循环语句
            {
                sum += val;//综合
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = SumVals(1, 5, 2, 9, 8);
            Console.WriteLine("Summed Values = {0}", sum);//输出总数多少
            Console.ReadKey();
        }
    }
}
