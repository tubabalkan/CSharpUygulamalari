using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "Akrana";
            Console.WriteLine(city[0]);//A yı yazdırır....
            foreach (var item in city)
            {
                Console.WriteLine(item);

            }
            string city2 = "istanbul";
            string result = city + city2;
            Console.WriteLine(result);
            Console.WriteLine(string.Format("{0} {1}", city, city2));//yan yana yazdırır


            Console.ReadLine();
        }
    }
}
