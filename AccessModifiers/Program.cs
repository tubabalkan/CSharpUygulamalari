using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Customer
    {
        int id;//birşey  yazmaz isen private olarak algılar 
        // private sadeece tanımlandığı yerde kullanılır

        private int Id { get; set; }//tanımlandığı blok dışında kullanılmaz
        protected int ıd { get; set; }//private ile aynı tek fark nesne olarak kullandığımız sınuflarda da kullanılır
        public void save()
        {
            Customer customer = new Customer();

        }
        public void Delete()
        {

        }
    }

    class Student : Customer//ıd protected olursa burada da kullanabiliriz
    {
        public void save2()
        {

        }
    }

    /* internal class Course//referans ihtiyacı olmadan kullanılır
    {
        public string Name { get; set; }
    }*/
    public class Course
    {
        public string Name { get; set; }
    }
}

