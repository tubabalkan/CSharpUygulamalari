using System;

namespace Interfaces1Ben
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Engin",
                LastName = "Demiroğ",
                Address = "Ankara"
            };
            Student student = new Student
            {
                Id = 1,
                FirstName = "Derin",
                LastName = "Demiroğ",
                Departman= " Computer Sciences"
            };
            manager.Add(student);
            manager.Add(customer );
        }
    }
    interface IPerson//soyut nesne tek başlarına anlam ifade etmez
    {
        int Id { get; set; }
        string  FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson//somut nesne  IPerson yazılınca IPerson için ne geçerli ise Customer için de o geçerli
    {
       public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student:IPerson //somut nesne
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
        