using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch10Ex01
{
    public class MyClass
    {
        public readonly string Name;
        private int intVal;  //私有的

        public int Val
        {
            get
            {   //get块有一个属性类型的返回值
                return intVal;
            }
            set
            {
                if(value >= 0 && value <= 10)
                    intVal = value;
                else
                    throw (new ArgumentOutOfRangeException("Val", value, "Val must be assigned a value between 0 and 10.")); 
             }
        }
        public override string ToString()  //override重写一个基类Tostring输出一个字符串
        {
            return "Name: " + Name + "\nVal: " + Val;
        }
        private MyClass() : this("Default Name")
        {
        }
        public MyClass(string newName)
        {
            Name = newName;
            intVal = 0;
        }
    }
}
