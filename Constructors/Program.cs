using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyClass myClass = new MyClass(10);
            MyClass myClass1 = new MyClass();

            myClass.Listed();
        }

        interface ILog
        {

            void Log();

        }
        class DbLog : ILog
        {
            public void Log()
            {
                Console.WriteLine("DB Log");
            }
        }

        class SMSLog : ILog
        {
            public void Log()
            {
                Console.WriteLine("SMS Log");
            }
        }


        class MyClass
        {
            public MyClass()//overloading
            {

            }

            private int _count;//private bir field _ ile başlar
            public MyClass(int count)
            {
                _count = count;
                    
            }


            public void Listed()
            {

                Console.WriteLine("Lİsted {0}",_count);
            }

        }
    }
}
