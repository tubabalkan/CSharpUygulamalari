using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
           
            CustomerManager customerManager = new CustomerManager(10);
            customerManager.Add();
            customerManager.list();
            Product product = new Product { Id = 1, Name = "Leptop" };
            Product product2 = new Product(2, "Computer");
            EmpluyeeManager empluyeeManager = new EmpluyeeManager(new DatabaseLogger());
            

            empluyeeManager.Add();


            PersonManager personManager = new PersonManager("Product");
            personManager.Add();

            Teacher.Number = 10;


            Utilites.Validate();

            Manager.DoSomething();//statik olan method
            Manager manager = new Manager();
            manager.DoSomething2();//statik olmayan
            Console.ReadLine();


        }
    }
    class CustomerManager
    {
        int _count=15;//private

        public CustomerManager(int count)//metotta alt çizgi kullanılmaz

        {
            _count = count;
        }
        public CustomerManager()
        {
                
        }
        public void list()
        {
            Console.WriteLine("Listededdd {0} items ", _count);
        }
        public void Add()
        {
            Console.WriteLine("Added!!");
        }
    }
    class Product
    {
        public Product()
        {
                
        }
        private int _id;
        private string _name;
        public Product(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id { get; set; }
        public string Name { get; set; }
    }
    interface ILogger
    {
        void Log();
    }
    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged To Database");
        }
    }
    class File : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged To File");
        }
    }

    class EmpluyeeManager
    {
        // public ILogger Logger { get; set; }
        private ILogger _logger;
        public EmpluyeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!!");
        }
    }

    class BaseClass
    {
        private string _entity;
        public BaseClass(string entity)
        {
            _entity = entity;    
        }
        public void massage()
        {
            Console.WriteLine("{0} message",_entity);
        }
    }

    class PersonManager:BaseClass
    {
        public PersonManager(string entity): base(entity)
        {
                
        }
        public void Add()
        {
            Console.WriteLine("Added!!");
            massage();

        }
    }

    static class Teacher//neew lemeye gerek yok herkes tarafından kullanılır 
    {
        public static int Number { get; set; }
    }

    static class Utilites
    {
        static Utilites()
        {
            //statik bir nesenede kullanılması gereken bir şey varsa buraya yazılır
        }
        public static void Validate()
        {

            Console.WriteLine("Validation is done");

        }
    }
    class Manager//sınıf statik değil ise bazı özellikler statik olabilir bazıları olmayabilir
    {
        public static void DoSomething()
        {

            Console.WriteLine(" done");

        }
        public void DoSomething2()
        {
            Console.WriteLine("done2");
        }
    }

}
