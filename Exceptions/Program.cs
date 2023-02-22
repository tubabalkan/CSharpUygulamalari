using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Threading;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Except();
            try
            {  
                
                Find();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }


            //Method
            HandleException(() =>
            {

                Find();

            });



            Console.ReadLine();

        }

        private static void HandleException(Action action)
        {
            try
            {

                action.Invoke();

            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }

        private static void Except()
        {
            try
            {

                string[] student = new string[3] { "Engin", "Derin", "Salih" };
                student[3] = "Ahmet";

            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (DivideByZeroException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (Exception exception)
            {

                //Console.WriteLine(exception.Message);//hatanın mesajını verir
                Console.WriteLine(exception.InnerException);//daha detaylı bir bilgi verir

            }
        }

        private static void Find()
        {
            List<string> student = new List<string> { "Engin", "Derin", "Salih" };

            if (!student.Contains("Ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found");//hata oluştur
            }

            else
            {
                Console.WriteLine("Record Found!");
            }
        }
    }
}
