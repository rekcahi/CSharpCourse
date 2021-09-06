using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
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
