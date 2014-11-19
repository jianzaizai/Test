using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch09Ex02
{
    //类MyClass
    class MyClass
    {
        public int val;  //公共的int字段val
    }

    //结构myStruct
    struct myStruct
    {
        public int val;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass objectA = new MyClass();
            //把第一个对象引用赋给类型为myclass的第二个变量
            MyClass objectB = objectA;
            objectA.val = 10;
            objectB.val = 20;
            myStruct structA = new myStruct();
            //把第一个结构赋类型为mystruct第二个变量
            myStruct structB = structA;
            structA.val = 30;
            structB.val = 40;
            Console.WriteLine("objectA.val = {0}", objectA.val);
            Console.WriteLine("objectB.val = {0}", objectB.val);
            Console.WriteLine("structA.val = {0}", structA.val);
            Console.WriteLine("structB.val = {0}", structB.val);
            Console.ReadKey();
        }
    }
}
