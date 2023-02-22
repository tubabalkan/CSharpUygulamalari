using System;

namespace Arrays1Ben
{
    class Program
    {
        static void Main(string[] args)
        {
            /*string student1 = "Engin";
            string student2 = "Derin";
            string student3 = "Salih";*/

            string[] students = new string[3];

            students[0] = "Engin";
            students[1] = "Derin";
            students[2] = "Salih";
            string[] students3 = new string[3] { "Engin", "Derin", "Salih" };//bu gösterim de dogru 

            string[] students2 = new[] { "Engin", "Derin", "Salih" };
            //string[] students2 = { "Engin", "Derin", "Salih" }; bu gösterim de dogru
            
            
            
            foreach (var student in students2)
            {
                Console.WriteLine(students2);
            }

            foreach (var student  in students)
            {
                Console.WriteLine(student);
            }

            string[,] regions = new string[5, 3]
            {
                { "istanbul","izmit",  "balıkesir" },
                { "ankara",  "konya",  "kırıkkale" },
                { "antalya", "adana",  "mersin"    },
                { "rize",    "trabzon","samsun"    },
                { "izmir",   "mugla",  "manisa"    }
               
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {

                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                {
                    Console.WriteLine(regions[i, j]);
                }
                Console.WriteLine("***************");

            }



            Console.ReadLine();
        }
    }
}
