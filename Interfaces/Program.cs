using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
           // NewMethod();
            ICustomerDal[] customerDals = new ICustomerDal[2]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal()
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();

            }
        }

        private static void NewMethod()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            //Interfaces newlenemez IPerson iperson=new IIPerson()
            IPerson person = new Customer();// bu şekilde yapılabilir
                                            // InterfacesIntro();
            Console.WriteLine("Hello World!");
        }

        private static void InterfacesIntro()
    {
        PersonManager personManager = new PersonManager();
        Customer customer = new Customer { Id = 1, FistName = "Ali", LastName = "Veli", Address = "Adress" };
        personManager.Add(customer);
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
