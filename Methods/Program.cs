using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void GoodBy(string Name)
        {
            Console.WriteLine("Good by, " + Name + "!");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string Name = Console.ReadLine();
            GoodBy(Name);
        }
    }
}
