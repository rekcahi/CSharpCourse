using System;

namespace AccessModifiers
{
    class Program:MyClass
    {
        static void Main(string[] args)
        {
            //private:sadece tanımlandığı blokta kullanılır
            //protected: inherit edilen classtan kullanılabilir
            //internal:
            Console.WriteLine("Hello World!");
            MyClass myClass = new MyClass();
          
        }
    }
    class MyClass
    {
        private int MyProperty { get; set; }
        public int MyProperty1 { get; set; }
        protected int MyProperty2 { get; set; }


    }
    class MyClass2:MyClass
    {
        public void Save()
        {
            MyProperty2= 12;// protected e erişilebiliyor

        }
      

    }
}
