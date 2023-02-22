﻿using System;

namespace inheritances
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName="Engin"
                },
                new Student
                {
                    FirstName="Derin"
                },
                new Person
                {
                    FirstName="Salih"
                }
            };
            foreach (var person in persons)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.ReadLine();

        }
    }
    class Person
    {
        public int Id { get; set; }
        public int FirstName { get; set; }
        public int LastName { get; set; }
    }

    class Customer : Person
    {
        public string city { get; set; }
    }

    class Student : Person
    {
        public string departman { get; set; }
    }
}
