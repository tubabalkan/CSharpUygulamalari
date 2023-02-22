using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {   // 1. ornek
            Console.WriteLine("Birinci Array");
            string[] students1 = new string[3];
            students1[0] = "Engin";
            students1[1] = "Derin";
            students1[2] = "Salih";
            foreach (var student in students1)
            {
                Console.WriteLine(student);

            }


            //2.ornek
            Console.WriteLine("*****************");
            Console.WriteLine("Ikinci Array");
            string[] students2 = new[] { "Ela", "Ecrin", "Kaan" };
            foreach (var student in students2)
            {
                Console.WriteLine(student);

            }

            //3.ornek
            Console.WriteLine("*****************");
            Console.WriteLine("Ucuncu Array");
            string[] students3 = { "Ahmet", "Ece", "Tuba" };
            foreach (var student in students3)
            {
                Console.WriteLine(student);

            }
            //4.ornek
            Console.WriteLine("*****************");
            Console.WriteLine("Dorduncu Array");
            string[] students4 = new string[] { "Can", "Murat", "Ali" };
            foreach (var student in students4)
            {
                Console.WriteLine(student);

            }
            Console.WriteLine();
            Console.WriteLine("Cok Boyutlu Array");
            string[,] regions = new string[5, 3]
            {
                { "Istanbul", "Izmit","Balıkesir"},
                { "Ankara", "Konya" , "Kırıkkale"},
                { "Antalya", "Adana" , "Mersin"},
                { "Rize", "Trabzon" , "Samsun"},
                { "Izmir", "Mugla" , "Manisa"}
            };
            for (int i = 0; i <=regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i,j]);

                }
                Console.WriteLine("********************");

            }
            Console.ReadLine();
        }
    }
}
