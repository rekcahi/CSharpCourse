using System;
using System.Collections.Generic;
using System.Text;

namespace Norhwind.Entities.Concrete
{
   public class Product
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CategoryId { get; set; }
        public decimal UnitPrice { get; set; }
        public string QuantityPerUnit { get; set; }
        public Int16 UnitsInStock { get; set; }


    }
}
