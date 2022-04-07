using System;

namespace Delegates
{
    class Program
    {

        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate int MyDelegate3(int sayi1,int sayi2);
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            Matematik matematik = new Matematik();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();
            MyDelegate myDelegate = customerManager.SendMessage;
            //myDelegate += customerManager.ShowAlert;
            //myDelegate -= customerManager.SendMessage;
            //myDelegate();

            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2("test");

            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            var sonuc=myDelegate3(5,4);
            Console.WriteLine(sonuc);
          //  Console.WriteLine("Hello World!");
        }
    }

   public class CustomerManager
    {
        public void SendMessage() 
        {
            Console.WriteLine("Hello!");        
        
        }

        public void ShowAlert()
        {
            Console.WriteLine("Be Careful!!");

        }


        public void SendMessage2(string message)
        {
            Console.WriteLine(message);

        }

        public void ShowAlert2(string text)
        {
            Console.WriteLine(text);

        }

    }

    public class Matematik
    {
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;

        }

        public int Carp(int sayi1, int sayi2)
        {
            return sayi1 *sayi2;

        }

    }
}
