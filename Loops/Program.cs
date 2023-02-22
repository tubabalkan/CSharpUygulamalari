using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i=0; i<=100; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finished!!!!!");
           
            Console.WriteLine("****************");
            Console.WriteLine("While Dongusu");
            int number = 100;
            while (number>=0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Now number is {0}", number);
            
            Console.WriteLine("****************");
            Console.WriteLine("Do While Dongusu");
            int number1 = 10;
            do
            {
                Console.WriteLine(number1);
                number1--;
            } while (number1>=0);
            Console.WriteLine("****************");
            Console.WriteLine("ForEach Dongusu");
            string[] students = new string[3] { "Engin", "Derin", "Salih" };
            foreach (var student in students)
            {
                Console.WriteLine(student);
            }










            Console.ReadLine();
        }
      
    }
}
