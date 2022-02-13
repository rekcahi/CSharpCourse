using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstarct classlar da interfaces gibi newlenemez


            /*          
             
            Abstract Method Sadece Abstract Sınıflarda Tanımlanabilir ve methodun gövdesi olamaz.
            Abstract Methodlar Mutlaka Override(Ezmek) Edilmek Zorundadır.

            Virtual Methodlarda ise Bu Override(Ezmek) Olayı İsteğe Bağlıdır. Virtual Methodlarda, 
            eğer geri dönüş tipi void değilse gövde olmak zorundadır. 
            Virtual methodlar tüm classlarda kullanılabilir.
            Yani abstract method gibi abstract class  içinde olma zorunluluğu yoktur.
             */
            Database database = new SqlServer();
            database.Add();
            database.Delete();


            Console.WriteLine("Hello World!");
        }
    }
     abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        
        }
        /*
          Abstract Method Sadece Abstract Sınıflarda Tanımlanabilir ve methodun gövdesi olamaz.
          Abstract Methodlar Mutlaka Override(Ezmek) Edilmek Zorundadır.
         */
        public abstract void Delete();

        /*  Virtual Methodlarda ise Bu Override(Ezmek) Olayı İsteğe Bağlıdır.Virtual Methodlarda,
            eğer geri dönüş tipi void değilse gövde olmak zorundadır.
            Virtual methodlar tüm classlarda kullanılabilir.
            Yani abstract method gibi abstract class içinde olma zorunluluğu yoktur.
        */
        public virtual void Update()
        {
            Console.WriteLine("Updated by default");
        }
    }
    class SqlServer : Database
    {
        public override void Update()
        {
            Console.WriteLine("Updated  by Sql");
            // base.Update();
        }

        public override void Delete()
        {
            Console.WriteLine("Deleted  by Sql");
        }
    }
    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted  by Oracle");
        }
    }
}
