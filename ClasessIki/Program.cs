using System;

namespace ClasessIki
{
    class Program
    {
        static void Main(string[] args)
        {
            Custom custom = new Custom();
            custom.City = "Ankara";
            custom.Id = 1;
            custom.FirstName = "Engin";
            custom.LastName = "Demirog";
            Console.WriteLine(custom.City);
            Console.WriteLine(custom.Id);
            Console.WriteLine(custom.FirstName);
            Console.WriteLine(custom.LastName);

          



            Console.ReadLine();
        }
    }
}
