using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyClass myClass = new MyClass(10);
            myClass.Listed();
        }


        class MyClass
        {

            private int _count;
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
