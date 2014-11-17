using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Ch06Ex006
{
    class Program
   {
        static void Main(string[] args)
        {
            //初始化数组
            int[] testArray = { 4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9 };   //定义数组testArray并赋值
            int[] maxValIndices;    //定义数组maxVallndices未赋值
            int maxVal = Maxima(testArray, out maxValIndices);  //定义maxVal并赋值为数组testArray中的最大值，并以最大值的序号为数组maxValIndices赋值
            Console.WriteLine("Maximum ValueType {0} found at element indices:", maxVal);
           //foreach的循环
            foreach (int index in maxValIndices)  //依次把maxValIndices的每个元素放到index中
            {
                Console.WriteLine(index);
             }
               Console.ReadKey();
             }
        static int Maxima(int[] integers, out int[] indices)
        {
            //Debug.WriteLine仅在调试模式下进行
            Console.WriteLine("Maximum value search started."); //Debug输出模式下输出maximum value search started
            indices = new int[1];
            int maxVal = integers[0];//给maxVal的为integers数组中的第0位参数
            indices[0] = 0;   //最大值下标数组indices第0位参数赋值为0
            int count = 1;  //定义count并赋值1

            Debug.WriteLine(string.Format("Maximum value initialized to {0},at element index 0.",maxVal));
                for (int i = 1;i < integers.Length;i++)
                {
                   Debug.WriteLine(string .Format("Now looking at element at index {0}.",i));
                    if(integers[i] > maxVal )
                    {
                        maxVal = integers[i];
                        count = 1;
                        indices = new int[1];
                        indices[0] = i;
                       Debug.WriteLine(string.Format ("New maximum found.New value is{0},at element index{1}.",maxVal ,i));
                    }
                    else
                    {
                        if(integers[i] == maxVal)
                        {
                            count++;
                            int[] oldIndices = indices;
                            indices = new int[count];
                            oldIndices.CopyTo(indices,0);
                            oldIndices [count - 1] = i;
                            Debug.WriteLine(string.Format("Duplicate maximum found at element index {0}.",i));
                        }
                    }
                }
                Console.WriteLine(string.Format("Maximum value {0} found,with  {1} occurrences.",maxVal,count));
                Debug.WriteLine("Maximum value search completed.");
            return maxVal ;
        }
   }
}
