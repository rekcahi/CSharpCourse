using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstarct classlar da interfaces gibi newlenemez
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
        public abstract void Delete();

    }
    class SqlServer : Database
    {
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
