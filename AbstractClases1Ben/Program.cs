using System;

namespace AbstractClases1Ben
{
    class Program
    {
        static void Main(string[] args)
        {
            DataBase dataBase = new oracle();
            dataBase.Add();
            dataBase.Delete();
            DataBase dataBase2 = new SqlServer();
            dataBase2.Add();
            dataBase2.Delete();
        }
    }

    abstract class DataBase
    {
        public void Add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
        
    }
    class SqlServer:DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by defaultSql");
        }
    }


    class oracle:DataBase
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }
}
