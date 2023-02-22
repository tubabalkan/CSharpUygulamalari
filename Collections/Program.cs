using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            //ArrayList tüm veri tipleri için kullanılır(int string vb)

            /* ArrayList cities = new ArrayList();
             cities.Add("Ankara");
             cities.Add("Adana");
             cities.Add("İstanbul");

             cities.Add(1);
             cities.Add('A');
             foreach (var city in cities)
             {
                 Console.WriteLine(city);
             }
            Console.WriteLine(cities[2]);*/

            /*
            //Tip Güvenli Tipler: sadece aynı veri tipi kullanılır


            List<string> cities = new List<string>();
            cities.Add("Ankara");
            cities.Add("İstanbul");

            Console.WriteLine(cities.Contains("Ankara"));//arama yapar
            Console.WriteLine(cities.Contains("Adana"));

           




            foreach (var city in cities)
            {
                Console.WriteLine(city);
            }

            //List<Customer> customers = new List<Customer>();
            //customers.Add(new Customer { Id = 1, FirstName = "Engin" });
            //customers.Add(new Customer { Id = 2, FirstName = "Derin" });



            List<Customer> customers = new List<Customer>
            {
           new Customer { Id = 1, FirstName = "Engin" },
           new Customer { Id = 2, FirstName = "Derin" }

            };

            var count = customers.Count;//eleman sayısını verir
            var customer2= new Customer
            {
                Id=3, FirstName="Salih"
            };
            customers.Add(customer2);
            customers.AddRange(new Customer[2]
            {
                new Customer { Id=4,FirstName="Ali"},
                new Customer { Id=5,FirstName="Ayşe"}
            });

            Console.WriteLine(customers.Contains(new Customer { Id = 1, FirstName = "Engin" }));//new denildiği zaman referansa bakar




            // customers.Clear();//liste temizleme



            var index=customers.IndexOf(customer2);//kaçıncı sırada oldugunu 
            Console.WriteLine("ındex : {0}", index);

            customers.Add(customer2);




            var index2=customers.LastIndexOf(customer2);//aramaya sondan başlar
            Console.WriteLine("ındex : {0}", index2);


            customers.Insert(0,customer2);
            customers.Remove(customer2);//ilk değeri alır diğerlerini yok sayar
            customers.RemoveAll(c=>c.FirstName=="Salih");//salihi bul ve sil

            foreach (var customer in customers)
            {
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.Id);
            }


            Console.WriteLine("Count : {0}", count);*/



            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Book", "Kitap");
            dictionary.Add("Table", "Tablo");
            dictionary.Add("Computer", "Bilgisayar");

            //Console.WriteLine(dictionary["Table"]);


            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
                Console.WriteLine(item);
            }

                Console.WriteLine(dictionary.ContainsKey("glass"));//var mı?
                Console.WriteLine(dictionary.ContainsKey("Table"));














            Console.ReadLine();
        }
    }

    class Customer
    {
        public int Id { get; set;}
        public string FirstName { get; set; }
    }
}
