using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coh06Ex05
{
    class Program
    {
        //求平均值
        int sum = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个年龄：");
            int age = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 5; i++)
            {  
                if (age < 0 || age > 100)
                {
                    Console.WriteLine("错误");
                    break;
                }
                else
                {
                    sum = sum + age;
                } 
            }
            Console.WriteLine("平均年龄是：{0}", sum / 5);
            Console.ReadKey();
        }
    }
}
