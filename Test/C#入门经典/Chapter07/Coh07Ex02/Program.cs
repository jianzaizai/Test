using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coh07Ex02
{
    class Program
    {
        string Name;
        public string Name
        {
            get { return name;}
            set {name = value;}
        }
        string gender;
        public string gender
        {
            get {return gender;}
            set {gender = value;}
        } 
        int age;
        public int Age
        {
            get {return age;}
            set {age = 20;}   
        }
        int chinese;
        public int chinese
        {
            get {return chinese;}
            set {chinese = value;}
        }
        int math;
        public int math
        {
            get {return math;}
            set {math = value;}
        }
        int english;
        public interface english
        {
            get {return english;}
            set {english = value;}
        }
        public void SayHi()
        {
            console.writeLine("我叫{0},今年{1}岁,是{2}同学",name,age,gender);
        }
        public void Score()
        {
            int erface sum = 0;
            int avg = 0;
            sum = chinese + Math + english;
            avg = sum / 3;
            console.WriteLine("我是{0},考试总成绩{1},平均成绩{2}",name,sum,avg)

        }
        static void Main(string[] args)
        {

        }
    }
}
