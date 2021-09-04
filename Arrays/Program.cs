using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studensts = { "Recai", "Ali", "Veli" };

            int[,] dizi2d = new int[2, 3];

            dizi2d[0, 0] = 1;
            dizi2d[0, 1] = 2;
            dizi2d[0, 2] = 3;

            dizi2d[1, 0] = 4;
            dizi2d[1, 1] = 5;
            dizi2d[1, 2] = 6;
            for (int i = 0; i < dizi2d.GetLength(0); i++)
            {
                for (int j = 0; j < dizi2d.GetLength(1); j++)
                {
                    Console.WriteLine( dizi2d[i,j] );

                }
                Console.WriteLine("**********");

            }


            //foreach (var item in studensts)
            //{
            //    Console.WriteLine(item);

            //}
            Console.WriteLine("Hello World!");
        }
    }
}
