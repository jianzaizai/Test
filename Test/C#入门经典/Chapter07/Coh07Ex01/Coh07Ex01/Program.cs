using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Coh07Ex01
{
   /* class Program
    {
        //通过字段来描述类别信息的变量
        private string name;
        public string Name
        {
            get {return name;}
            set {name = value;}
        }
        public string gender;
        public int age;
        public string address;
        public string phone;
        //通过方法来描述类的动作
        public void Eat()
        {
            Console.WriteLine("我在吃东西");
        }
        public void Sport()
        {
            Console.WriteLine("吃完一起健身");
            Console.ReadKey();

        }
    }
}*/
/*namespace_001
{*/
    class Program
    {
        static void Main(string[] args)
        {
            //类的实例化
            Person w = new Person() {Name="Join",gender="女",address="郑州",age=13,phone="321321312"};
            w.Eat();
            w.Sport();
            Console.WriteLine("我叫{0},是个{1}生,我住在{2},今年{3}岁,我的联系方式是{4}",w.Name,w.gender,w.address,w.age,w.phone);
            Console.ReadKey();
        /*static void Main(string[] args)
        {

        }*/
    }
   }
