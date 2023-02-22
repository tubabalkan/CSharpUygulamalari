using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerMagner customerMagner = new CustomerMagner();
            customerMagner.Add();
            customerMagner.Update();

            ProductMagner productMagner = new ProductMagner();
            productMagner.Add();
            productMagner.Update();
           
        }
    }
    /*class CustomerMagner
    {
        public void Add()
        {
            Console.WriteLine("CustomerMagner Added!!");

        }
        public void Update()
        {
            Console.WriteLine("CustomerMagner Updatedd!!");
        }
    }*/
    /*class ProductMagner
    {
        public void Add()
        {
            Console.WriteLine("ProductMagner Added!!");

        }
        public void Update()
        {
           Console.WriteLine("ProductMagner Updatedd!!");
        }
    }*/
}
