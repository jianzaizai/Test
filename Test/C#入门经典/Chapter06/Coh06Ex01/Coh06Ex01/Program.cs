using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coh06Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.交换变量，借助第三方变量num3
            /*int num1 = 5;
            int num2 = 10;
            int num3 = 0;
            num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine("{0},{2}", num1, num2);
            Console.ReadKey();*/
            //2.交换变量,借助运算
            int num1 = 5;
            int num2 = 10;
            num1 = num2 + num1;//15
            num2 = num1 - num2;//5
            num1 = num1 - num2;
            Console.WriteLine("{0},{1}", num1, num2);
            Console.ReadKey();
        }
    }
}
