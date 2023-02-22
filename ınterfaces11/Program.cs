using System;

namespace ınterfaces11
{
    class Program
    {
        static void Main(string[] args)
        {
            /* PersonManager manager = new PersonManager();
             manager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demirog", Adress = "Ankara" });
             Student student = new Student
             {
                 Id = 1,
                 FirstName = "Derin",
                 LastName= "Demirog",
                 Departman="Computer Sciences"
             };
             manager.Add(student);
            // İKİNCİ KISIM
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());*/


            ICustomerDal[] customerDals = new ICustomerDal[3]
                {
                
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()
                
                
                };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }







            Console.ReadLine();
        }
    }
    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }


    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departman { get; set; }
    }
    class Worker : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Departman { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
