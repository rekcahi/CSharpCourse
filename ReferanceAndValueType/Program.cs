using System;

namespace ReferanceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {


            
            Console.WriteLine(GC.MaxGeneration); 
            string[] sehirler1 = new string[] { "Adana", "Mersin", "Antalya" };
            string[] sehirler2 = new string[] { "Adana1", "Mersin1", "Antalya1" };
            sehirler1 = sehirler2;
            Console.WriteLine(sehirler1[0]);
            Console.WriteLine(GC.MaxGeneration);



            Console.WriteLine("Hello World!");
        }
    }
}
