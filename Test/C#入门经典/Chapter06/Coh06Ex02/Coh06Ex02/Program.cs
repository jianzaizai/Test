using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coh06Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            //类型转换

            //Convert不再仅是内存级别的转换，而是考虑数据意义的转换。Convert是一个加工、改造的过程

            //Convert.ToInt32(能转换成int类型的数据)来把其他类型数据转换成int类型

            Console.WriteLine("请输入名字：");
            string name = Console.ReadLine();
            Console.WriteLine("你的语文成绩是：");
            int Chinese = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("你的数学成绩是：");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("你的英语成绩是：");
            int English = Convert.ToInt32(Console.ReadLine());
            int sum = Chinese + math + English;
            float avg = sum / 3;
            Console.WriteLine("{0},总成绩是{1}，平均成绩是{2}", name, sum, avg);
            Console.ReadKey();
        }
    }
}
