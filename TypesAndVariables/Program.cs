using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            double doubleSayi = 10.4;
            decimal decimalSayi = 10.5m;
            char charakter = 'A';
            string charakterDizisi = "Ankara";
            bool condition = true;
            byte numberByte = 255;
            short numberShort = 23;//           
            int number1 = 12;
            long numberLong = 23;
            var sayi = 2;
            sayi = 'A';
            Console.WriteLine("Char {0}",charakter);
            Console.WriteLine(Days.Friday);
            Console.WriteLine(sayi);
            Console.ReadLine();
        }
        enum Days
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday

        }
    }
}
