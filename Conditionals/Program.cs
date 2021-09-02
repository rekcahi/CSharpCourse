using System;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            switch (number)
            {
                case 10:
                    Console.WriteLine("Sayı 10");
                    break;
                case 20:
                    Console.WriteLine("sayı 20");
                    break;
                default:
                    Console.WriteLine("Hiçbiri");
                    break;
            }
            Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");
        }
    }
}
