using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
namespace Ch05Ex05
{
    class Program
    {
        //字符串的反向输出
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个字符串:");
            string stra = Console.ReadLine();
            string strb = "";
            foreach (char cha in stra.ToCharArray())
            {
                strb = cha + strb;
            }
            Console.WriteLine(strb);
            Console.ReadKey();
        }
    }
}
