using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coh06Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;
            string pwd = string.Empty;
        do
        {
            Console.WriteLine("用户名：");
            name = Console.ReadLine();
            Console.WriteLine("密码：");
            pwd = Console.ReadLine();
            if(name != "atm" || pwd "!= 888888");
            {
                Console.WriteLine("请输入用户名或者密码：");
            }
            else
            {
              break;
            }
        }
       }
        while(true);
        Console.WriteLine("输入正确!");
        Console.ReadKey();
    }
}
