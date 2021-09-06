using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer { Id = 1, FistName = "Ali", LastName = "Veli", Address = "Adress" };
            personManager.Add(customer);
            Console.WriteLine("Hello World!");
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FistName { get; set; }
        string LastName { get; set; }

    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Departman { get; set; }

    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FistName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {

            Console.WriteLine(person.FistName + "Added!");

        }

    }
}
