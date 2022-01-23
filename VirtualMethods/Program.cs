using System;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Virtual (sanal metod) ‘lar kalıtıldığı sınıflarda içeriği değiştirilebilen metodlardır.
            Yani temel sınfımız da bir method oluşturuyoruz. 
            Bu methodun içeriğini ileride değiştirme ihtiyacı duyuyoruz bu gibi durumlarda methodumuza virtual anahtar kelimesini ekleyerek override (ezmek) etmeye olanak tanımış oluyoruz.     
             
             */
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();
            Console.WriteLine("--------------");
        }
    }
    class Database
    {
        public virtual void Add()//Virtual yapılan metodlar override edilerek metodun içi değiştirilebilir
        {

            Console.WriteLine("Added by default");

        }
        public virtual void Delete()
        {
            Console.WriteLine("Deleted by default");

        }

    }
    class SqlServer:Database
    {
        public override void Add()
        {
            Console.WriteLine("Added by Virtual Method");

           // base.Add();
        }

    }
    class MySql:Database
    {

    }
}
