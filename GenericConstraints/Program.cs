using System;

namespace GenericConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> s1 = new GenericList<int>();
            GenericList2<string> genericList2 = new GenericList2<string>();
            GenericList2<Product> genericList3 = new GenericList2<Product>();


           // GenericList3<string> genericList22 = new GenericList3<string>();
            GenericList3<Product> genericList33 = new GenericList3<Product>();



            Console.WriteLine("Hello World!");
        }
    }
    class GenericList<T> where T:struct//sadece değer tipleri int float ... gibi değerleri alabilir
    {

    }

    class GenericList2<T> where T:class//referance type --->string de bir referance typedir
    {

    }
    class GenericList3<T> where T:class,new()//newlenebilir
    {

    }

    class GenericList4<T> where T : class,IEntity, new()//newlenebilir
    {

    }

    interface IEntity
    {

    }
    class Product:IEntity
    {

    }
}
