using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coh06Ex06
{
    class Program
    {
        //重复让用户输入一个数，判断该数是否是质数，输入Q结束
        static void Main(string[] args)
        {
            IsPer();
            Console.ReadKey();
        }
        static void IsPer()
        {
            while (true)
            {
                Console.WriteLine("亲请输入一个数字，按q结束");

                string str = Console.ReadLine();

                if(str == "q")
                {
                    Console.WriteLine("输入结束");

                    break;
                }
                else
                {
                    int num = Convert.ToInt32(str);

                    bool b = true;

                    for(int i = 2;i <num-1;i++)
                    {
                        if(num % i == 0)
                        {
                            Console.WriteLine("不是质数");

                            b = false;

                            break;
                        }
                    }
                    if(b == true)
                    {
                        Console.WriteLine("是质数");
                    }
                }
            }
        }
    }
}
