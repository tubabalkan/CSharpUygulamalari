using System;

namespace referanceAndValueType
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;//deger tip deger tipte tamamen deger önemli
            int number2 = 20;
            number2 = number1;//number2 10 olur

            number1 = 30;

            Console.WriteLine(number2);

            string[] cities1 = new string[] { "Ankara", "Adana", "Afyon" };//101
            string[] cities2 = new string[] { "Bursa", "Bolu", "Balıkesir" };//102
            cities2 = cities1;// referans  102 den 101 oluyor

            cities1[0] = "İstanbul";//ankara istanbul olarak değişir
            Console.WriteLine(cities2[0]);
            
           

            Console.ReadLine();
        }
    }
}
