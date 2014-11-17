using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch06Ex002
{
    class Program
    {
        static int MaxValue(int[] intArray)
        {
            //数组
            int maxVal = intArray[0];
            
            for (int i = 1; i < intArray.Length; i++)
            {
                //判断值的大小
                if (intArray[i] > maxVal)
                    maxVal = intArray[i];
            }
            return maxVal;
        }
        static void Main(string[] args)
        { 
            //数组赋初值
            int[] myArray = { 1, 8, 3, 6, 2, 5, 9, 3, 0, 2 };
            int maxVal = MaxValue(myArray);
            Console.WriteLine("The maxium value in myArray is {0}", maxVal);
            Console.ReadKey();
        }
    }
}
