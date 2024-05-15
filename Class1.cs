using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Class1
    {
        int i; bool a;
        static void Main() 
        {
            Class1 p = new ConsoleApp2.Class1();
            Console.WriteLine(p.a);
            Console.WriteLine(p.i);
            Console.WriteLine("Second Hello");
        }
    }
}
