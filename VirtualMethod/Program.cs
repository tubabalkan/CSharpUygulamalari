using System;

namespace VirtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlServer = new SqlServer();
            sqlServer.Add();
            MySql mySql = new MySql();
            mySql.Add();
        }
    }

    class DataBase
    {
        public virtual void Add()
        {
            Console.WriteLine("Added by default");
        }
        public virtual void Delete()//virtual 
        {
            Console.WriteLine("Deleted by default");

        }
    }
    class SqlServer: DataBase
    {
        public override void Add()
        {
            base.Add();
            Console.WriteLine("Added by sql code");
        }
    }
    class MySql : DataBase
    {

    }
}
