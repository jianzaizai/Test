using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch07Ex001
{
    class Program
    {
        static string[] eTypes = { "none", "simple", "index", "nested index" };
        //定义一个数组变量
        static void Main(string[] args)
        {
            foreach (string eType in eTypes)
            {
                //try { 执行的代码，其中可能有异常。一旦发现异常，则立即跳到catch执行。否则不会执行catch里面的内容 }
                //catch { 除非try里面执行代码发生了异常，否则这里的代码不会执行 }
                //finally { //不管什么情况都会执行，包括try catch 里面用了return ,可以理解为只要执行了try或者catch，就一定会执行 finally }
                try   //在Main()下调用函数ThrowException
                {
                    Console.WriteLine("Main() try block reached.");
                    Console.WriteLine("ThrowException(\"{0}\") called.", eType);

                    ThrowException(eType);
                    Console.WriteLine("Main() try block continues.");
                }
                catch (System.IndexOutOfRangeException e)
                {
                    Console.WriteLine("Main() system.IndeOutOfRangeException catch" + " block reached.Message:\n\"{0}", e.Message);
                }
                catch
                {
                    Console.WriteLine("Main() general catch block reached.");
                }
                finally
                {
                    Console.WriteLine("Main() finally block reached.");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        static void ThrowException(string exceptionType)
        {
            Console .WriteLine ("ThrowException(\"{0}\") reached.", exceptionType);
            //switch判断
            switch (exceptionType)
            {
                case "none":           //不抛出异常
                    Console .WriteLine ("Not throwing an exceptionType.");
                    break;
                case "simple":          //抛出一般异常
                    Console .WriteLine ("Throwing System.Exception.");
                    //throw(new System.Exception());
                    break;
                case "index":          //抛出System.IndexOutOfRangeException异常
                    Console.WriteLine("Throwing System.IndexOutOfRangeException.");
                    eTypes[4] = "error";
                    break;
                case "nested index":     //包含自己的try块，其中的代码调用ThrowException ("index")，抛出一个System.IndexOutOfRangeException异常
                    try
                    {
                        Console.WriteLine ("ThrowException (\"nested index\") " + "try block reached.");
                        Console .WriteLine ("ThrowException(\"index\") called.");
                        ThrowException ("index");
                    }
                    catch 
                    {
                        Console .WriteLine ("ThrowException(\"nested index\") general" + "catch block reached.");
                    }
                    finally 
                    {
                        Console .WriteLine ("ThrowException(\"nested index\") finally" + "block reached.");
                    }
                    break;
            }
        }
    }
}
