using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new Oracle();
            database.Add();
            database.Delete();

            Database database1 = new SqlServer();
            database1.Add();
            database1.Delete();
            Console.ReadLine();
            
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
            Console.WriteLine("Delete by Sql");
        }

    }

    class Oracle: Database
    {
        public override void Delete()
        {
            Console.WriteLine("Delete by Oracle");
        }
    }


}
