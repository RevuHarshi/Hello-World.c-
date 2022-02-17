using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Eggs
    {
        public void DisplayOne()
        {
            Console.WriteLine("Eggs");
            Console.WriteLine("hi");
        }
    }
    class Caterpillar : Eggs
    {
        public void DisplayTwo()
        {
            Console.WriteLine("caterpillar");
        }
    }
    class Butterfly : Caterpillar
    {
        public void DisplayThree()
        {
            Console.WriteLine("Butterfly");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Butterfly b = new Butterfly();
            b.DisplayOne();
            b.DisplayTwo();
            b.DisplayThree();

            Console.ReadKey();
                
        }
    }
}
