using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
           // List<string> kisiler = utilities.BuildList<string>("Ali", "Veli", "Deli");      

            List<Customer> musteriler = utilities.BuildList<Customer>(new Customer { FirstName = "Recai" },
                new Customer { FirstName = "Gamze" });


            foreach (var item in musteriler)
            {
                Console.WriteLine(item.FirstName);

            }
            Console.WriteLine("---------------------");
        }

        class Utilities
        {

            public List<T> BuildList<T>(params T[] items)
            {
                return new List<T>(items);
            }

        }
        interface ICustomerDal : IRepository<Customer>
        {
            void Custom();
        }

        interface IRepository<T> where T:class
        {
            List<T> GetAll();
            T Get(int id);
            void Add(T entity);
            void Delete(T entity);
            void Update(T entity);
        }
        class CustomerDal : ICustomerDal
        {
            public void Add(Customer entity)
            {
                throw new NotImplementedException();
            }

            public void Custom()
            {
                throw new NotImplementedException();
            }

            public void Delete(Customer entity)
            {
                throw new NotImplementedException();
            }

            public Customer Get(int id)
            {
                throw new NotImplementedException();
            }

            public List<Customer> GetAll()
            {
                throw new NotImplementedException();
            }

            public void Update(Customer entity)
            {
                throw new NotImplementedException();
            }
        }


        class Customer
        {
            public string FirstName { get; set; }


        }
    }
}
