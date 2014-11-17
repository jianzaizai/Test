using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06Ex004
{
    class Program
    {
        static void Write()   //Write()定义初始化了mystring
                             //与Main()定义的mystring不同
        {
            string myString = "String defined in Write()";
            Console.WriteLine("Now in Write()");  
            Console.WriteLine("myString = {0}", myString);
        }

        static void Main(string[] args)
        { 
            //Main()定义初始化变量string,Main()把控制权给了Write()
            string myString = "String defined in Main()";
            Write();
            Console.WriteLine("\nNow in Main()");
            Console.WriteLine("mystring = {0}", myString);
        }
    }
}
