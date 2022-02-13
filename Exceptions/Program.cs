using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            HandleException(() => 
            {
               NewMethod1();
            });               
            // NewMethod();    
        }

        private static void HandleException(Action p)
        {
            try
            {
                p.Invoke();
            }
            catch (RecordNotFountException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void NewMethod1()
        {
            List<string> isimler = new List<string> { "ali", "veli" };
            if (!isimler.Contains("alii"))
            {
               throw new RecordNotFountException("Kayıt bulunamadı");
            }
            else
            {
                Console.WriteLine("Kayıt bulundu");
            }
        }

        private static void NewMethod()
        {
            try
            {
                string[] isimler = new string[3] { "Ali", "Veli", "Deli" };
                isimler[3] = "Mamo";

            }
            catch (IndexOutOfRangeException ex)
            {

                Console.WriteLine("----------------->" + ex.InnerException);//Hatanın detayını verir
                Console.WriteLine(ex.Message);
            }
            finally
            {

                Console.WriteLine("Finally çalıştı");


            }
        }
    }
}
