using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coh06Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArray = { "我是", "你的", "哥哥" };
            Oper(strArray);     //调用函数
            Console.ReadKey();
        }

        static void Oper(string[] strs)
        {
            string resoult = string.Empty;
            for(int i = 0;i < strs.Length-1;i++)
            {
                resoult += strs[i] + "|";
            }

            resoult += strs[strs.Length - 1];

            Console.WriteLine(resoult);
        }
    }
}
