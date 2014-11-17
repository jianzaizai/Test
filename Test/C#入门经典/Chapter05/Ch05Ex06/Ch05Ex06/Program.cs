using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch05Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is a test.";
            char[] separator = { ' ' };
            string[] myWords;

            //使用<string>.split转换为string数组，把他指定的位置分开
            myWords = myString.Split(separator);
            foreach (string word in myWords)
            {
                Console.WriteLine("{0}", word);
            }
            Console.ReadKey();
        }
    }
}
