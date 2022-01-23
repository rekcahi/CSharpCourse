using System;

namespace Inheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[2]
            {
                new Customer{ FirstName="Recai"},
                new Student{FirstName="Sezai"}
            };

            foreach (var item in person)
            {
                Console.WriteLine(item.FirstName);

            }
            Customer customer = new Customer();
            
            Console.WriteLine("------");
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Customer:Person
    {
        public string City { get; set; }

    }
    class Student:Person
    {
        public string Department { get; set; }

    }
}
