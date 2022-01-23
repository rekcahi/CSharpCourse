using System;

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AccessModifiers.Demo demo = new AccessModifiers.Demo();
            demo.MyProperty = 12;
            Console.WriteLine("Hello World!");
        }
    }
}
