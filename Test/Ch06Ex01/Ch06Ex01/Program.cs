using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06Ex01
{
    //定义委托
    public delegate void GreetingDelegate(string name);
    class Program
    {
        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("morning, " + name);
        }
        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("上午好, " + name);
        }
        //接受一个GreetingDelegate类型的方法作为参数
        private static void GreetPeople(string name, GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }
        static void Main(string[] args)
        {
            GreetPeople("jay,"  EnglishGreeting);
            GreetPeople("同学,"  ChineseGreeting);
            Console.ReadKey();
        }
    }
}
