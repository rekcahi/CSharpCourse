using System;
using System.Collections.Generic;
using System.Text;

namespace RecapProject1.Entities
{
   public class Product
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public Int16 UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; }


    }
}
