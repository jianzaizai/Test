using System;
using System.Collections.Generic;
using System.Text;

namespace Ch11Ex01
{
    public class Chicken : Animal 
    {
        public void LayEgg()
        {
            Console.Write("{0} has laid an egg.", name);
        }
        public Chicken(string newName)  : base(newName)
        { 
        }
    }
}
