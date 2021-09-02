using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {


            //ref 
            //out
            /*
              ref ile kullanımda değişkene başlangıç değerinin verilmesi gerekirken out anahtar kelimesi ile kullanımda başlangıç değerinin verilmesine gerek yoktur.
             
             */


            var result = Add2(1,2);
            int number1 = 20;
            int number2 = 100;
            var result2 = RefMethod( ref number1, number2);
           // RefMethod();
            Console.WriteLine("result2 {0}",result2);
            Console.WriteLine("number1 {0}",number1);
            Add();
        }

        private static int Add2(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        static void Add()
        {
            Console.WriteLine("Added!!");

        }

        static int RefMethod( ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;


        }
        //OVERLOADİNG METODLAR
        static int Multiply(int number1,int number2)
        {
            return number1 * number2;
        
        
        }
        static int Multiply(int number1, int number2,int number3)
        {
            return number1 * number2*number3;


        }
        static int ParamTopla(params int[] sayilar)
        {

            return sayilar.Length;
        }


        static void DegerAl(params object[] gelenDegerler)
        {
            foreach (object eleman in gelenDegerler)
            {
                Console.WriteLine("Değer: {0} - Tipi: {1}", eleman, eleman.GetType().Name);
            }
            Console.WriteLine();
        }
    }
}
