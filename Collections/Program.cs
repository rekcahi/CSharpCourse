using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //NewMethod1();
            // NewMethod();
            // NewMethod2();
            Dictionary<string, string> sozluk = new Dictionary<string, string>();
            sozluk.Add("person", "insan");
            sozluk.Add("pencil", "kalem");

            foreach (var item in sozluk)
            {
                Console.WriteLine(item.Value);

            }


            Console.WriteLine("------");
        }

        private static void NewMethod2()
        {
            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, NameSurname = "recai" });
            //customers.Add(new Customer { Id = 2, NameSurname = "gamze" });



            List<Customer> customers = new List<Customer>
            {
                new Customer { Id = 1, NameSurname = "recai" },
                new Customer { Id = 2, NameSurname = "gamze" }
            };

            customers.AddRange(new Customer[2]//dizi veya liste olarak ekler
            {
            new Customer{Id=3,NameSurname="Ali Baran" },
            new Customer{Id=4,NameSurname="test"}

            }
            );
            customers.Clear();
            customers.RemoveAll(c => c.NameSurname == "recai");

            foreach (var item in customers)
            {
                Console.WriteLine(item.NameSurname);

            }
        }

        private static void NewMethod1()
        {
            List<string> cities = new List<string>();//safe type
            cities.Add("İstanbul");
            cities.Add("Ankara");

            foreach (var item in cities)
            {
                Console.WriteLine(item);

            }
        }

        private static void NewMethod()
        {
            ArrayList cities = new ArrayList();
            cities.Add("Ankara");
            cities.Add("Kocaeli");
            foreach (var item in cities)
            {
                Console.WriteLine(item);
            }
            cities.Add("İstanbul");
            Console.WriteLine(cities[2]);
        }
    }

    class Customer
    {
        public int Id { get; set; }
        public string NameSurname { get; set; }

    }
}
