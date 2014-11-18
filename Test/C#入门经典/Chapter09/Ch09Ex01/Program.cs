using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch09Ex01
{
    //定义类，只能继承
    public abstract class MyBase
    {
    }
    internal class MyClass : MyBase
    { 
    }
    //公共接口函数
    public interface IMyBaseInterface
    { 
    }
    internal interface IMyBaseInterface2
    { 
    }
    internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2
    { 
    }
    //密封类，不能派生，只能实例化
    internal sealed class MyComplexClass : MyClass, IMyInterface
    { 
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyComplexClass myObj = new MyComplexClass();
            Console.WriteLine(myObj.ToString());
            Console.ReadKey();
        }
    }
}
