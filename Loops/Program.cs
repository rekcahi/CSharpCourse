using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // ForMethod();
            // WhileMethod();
            // DoWhileMethod();
            // ForeachMethod();
          bool result= IsPrimeNumber(5);
            Console.WriteLine("Sonuç {0}",result);
        }

        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number; i++)
            {
                Console.WriteLine(i);
                if (number % i == 0)
                {
                    result = false;
                    break;
                
                }

            }
            return result;
        }

        private static void ForeachMethod()
        {
            string[] kisiler = { "Ali", "Veli", "Deli" };
            foreach (var item in kisiler)
            {
                Console.WriteLine(item);

            }
        }

        private static void DoWhileMethod()
        {
            int number = 100;
            do
            {
                Console.WriteLine(number);
                number--;

            } while (number>0);
        }

        private static void WhileMethod()
        {
            int number = 100;

            while (number > 0)
            {
                Console.WriteLine(number);
                number--;

            }
        }

        private static void ForMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");

            }
        }
    }
}
