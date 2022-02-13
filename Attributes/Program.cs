using System;

namespace Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id=1,FirstName="recai",LastName="Aydoğdu",Age=32 };
            CustomerDal customerDal = new CustomerDal();
           // customerDal.Add(customer);
            
            Console.WriteLine("Hello World!");
        }
    }
    [ToTable("Customers")]
    class Customer
    {
        [ReqiredProperty]
        [ReqiredProperty]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
    class CustomerDal
    {
        [Obsolete("Don't use Add,instead use AddNew Method",true)]
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3}",customer.Id,customer.FirstName,customer.LastName,customer.Age);
        }

        public void AddNew(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

    }
    [AttributeUsage(AttributeTargets.All,AllowMultiple=true)]
    class ReqiredPropertyAttribute:Attribute
    {

    }
    class ToTableAttribute:Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;

        }

    }
}
