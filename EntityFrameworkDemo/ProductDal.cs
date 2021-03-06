using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace EntityFrameworkDemo
{
    class ProductDal
    {


        //public List<Product> GetAll()
        //{
        //using (ETradeContext context=new ETradeContext())
        //{
        //    return context.Products.ToList();
        //}
        //}

        public void Add(Product product)
        {

            using (ETradeContext context = new ETradeContext())
            {
                // context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = EntityState.Added;
                context.SaveChanges();
            }


        }


        public void Update(Product product)
        {

            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Modified;
                context.SaveChanges();
            }


        }

        public void Delete(Product product)
        {

            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = EntityState.Deleted;
                context.SaveChanges();
            }


        }




    }
}
