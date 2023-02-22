using System;

namespace Classes1Kendim
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CustomerManager customerManager = new CustomerManager();//classsın bir örnegi
            customerManager.Add();
            customerManager.Update();

            
            
            ProductManager productManager = new ProductManager();
            productManager.Add();
            productManager.Update();


            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id =1;
            customer.FirsName = "Engin ";
            customer.LastName = "Demiroğ";




            
            

            Console.ReadLine();

        }
    }

    
   




}
