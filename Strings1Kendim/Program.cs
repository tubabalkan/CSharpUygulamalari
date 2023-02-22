using System;

namespace Strings1Kendim
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "Ankara";
            // Console.WriteLine(city[0]);
            foreach (var item in city)
            {
                Console.WriteLine(item);
            }

            string city2 = "Istanbul";
            //string result = city + city2;
            //Console.WriteLine(result);
            Console.WriteLine(string.Format("{0} {1}", city2,city2));


            string sentence = "My name is Tuba Balkan";
            var result = sentence.Length;//uzunluk
            var result2 = sentence.Clone();//aynısını yazar
            bool result3 = sentence.EndsWith("n");// n ile bitiyor mu
            bool result4 = sentence.StartsWith("My Name");//my name ile başlıyor mu
            var result5 = sentence.IndexOf("name");//name kaçıncı harften başlıyor
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");//boşluğu sondan arar
            var result8 = sentence.Insert(0, "Hello, ");//metin eklemek için kullanılır
            var result9 = sentence.Substring(3);//3.karakterden sonrasını yazdırır
            var result10 = sentence.Substring(3,4);//3. karakterden sonra 4 tane al
            var result11 = sentence.ToLower();//butun karakterleri küçüge cevirir
            var result12 = sentence.ToUpper();//bütün harfleri büyük yapar
            var result13 = sentence.Replace(" ", "-");//tüm boşluklara - işaretini koyar
            var result14 = sentence.Remove(2);//belli bir indexten sonrasını atar
            var result15 = sentence.Remove(2,5);
            Console.WriteLine(result);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.WriteLine(result4);
            Console.WriteLine(result5);
            Console.WriteLine(result6);
            Console.WriteLine(result7);
            Console.WriteLine(result8);
            Console.WriteLine(result9);
            Console.WriteLine(result10);
            Console.WriteLine(result11);
            Console.WriteLine(result12);
            Console.WriteLine(result13);
            Console.WriteLine(result14);
            Console.WriteLine(result15);











            Console.ReadLine();
        }
    }
}
