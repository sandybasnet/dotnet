using System;

namespace ConsoleApp2
{
    internal class ExplicitCon
    {
        public ExplicitCon() //Defining the constructor
        {
            Console.WriteLine("Constructor is called");
        }

        static void Main()
        {
            ExplicitCon obj = new ExplicitCon(); //Calling the constructor
            ExplicitCon obj1 = new ExplicitCon();
            Console.ReadLine();
        }
    }
}
