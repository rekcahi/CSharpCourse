using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Recai1";
            customer.LastName = "Aydoğdu1";
            customer.City = "Bitlis";

            Customer customer1 = new Customer { Id = 2, FirstName = "Recai2", LastName = "Aydoğdu2", City = "Tatvan" };
           
            Console.WriteLine(customer.FirstName);



            //Customer customer = new Customer
            //{

            //    Id = 1,
            //    FirstName = "Recai",
            //    LastName = "Aydoğdu"

            //};
            //  NewMethod();
            // Console.WriteLine(customer.FirstName);
        }

        private static void NewMethod()
        {
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();
        }
    }
}
