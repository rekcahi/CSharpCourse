using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {

            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla(2, 3));
            //Console.WriteLine(dortIslem.Topla2()); 

            var tip = typeof(DortIslem);
            // DortIslem dortIslem=(DortIslem)Activator.CreateInstance(tip);
            //  Console.WriteLine(dortIslem.Topla(4, 5));  
            var instance = Activator.CreateInstance(tip, 6, 5);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            // Console.WriteLine(methodInfo.Invoke(instance, null));

            var metodlar = tip.GetMethods();
            foreach (var item in metodlar)
            {
                Console.WriteLine("Metod Name:{0}", item.Name);
                foreach (var paraminfo in item.GetParameters())
                {
                    Console.WriteLine("Parametre Name:{0}", paraminfo.Name);
                }
                foreach (var attribute in item.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name:{0}", attribute.GetType().Name);
                }
            }
            Console.WriteLine("Hello World!");
        }
    }
    public class DortIslem
    {
        public DortIslem()
        {

        }

        private int _sayi1;
        private int _sayi2;

        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;


        }
        public int Topla(int sayi1, int sayi2)
        {

            return sayi1 + sayi2;
        }

        public int Carp(int sayi1, int sayi2)
        {

            return sayi1 * sayi2;
        }

        public int Topla2()
        {

            return _sayi1 + _sayi2;
        }

        [MetodName("Carpma")]
        public int Carp2()
        {

            return _sayi1 * _sayi2;
        }
    }
    public class MetodNameAttribute : Attribute
    {
        public MetodNameAttribute(string name)
        {

        }
    }
}
