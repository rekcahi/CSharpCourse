using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class ETradeContext:DbContext
    {        
        public DbSet<Product> Products { get; set; }

    }
}
