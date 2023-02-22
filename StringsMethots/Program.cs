using System;

namespace StringsMethots
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "My Name Is Tuba";
            var result = sentence.Length;// kac karakterden olustugunu bulur..
            Console.WriteLine(result);
            var result2 = sentence.Clone();//sentence deki yazıyı result2 ye klonlar..
            
            sentence = "My Name Is Tuba Balkan";
            Console.WriteLine(result2);

            bool result3 = sentence.EndsWith("n");
            Console.WriteLine(result3);

            bool result4 = sentence.StartsWith("m");
            Console.WriteLine(result4);

            var result5 = sentence.IndexOf("Name");//Arama Yapar...
            Console.WriteLine(result5);

            var result6 = sentence.IndexOf(" ");//Arama Yapar...
            Console.WriteLine(result6);

            var result7 = sentence.LastIndexOf(" ");//Sondan Baslayarak Arama Yapar...
            Console.WriteLine(result7);

            var result8 = sentence.Insert(0, "Hello, ");//0. Karakterden Sonra Hello, Yazısını Ekle
            Console.WriteLine(result8);

            var result9 = sentence.Substring(3);//3. Karakterden Sonrasını Yazdir
            Console.WriteLine(result9);

            var result10 = sentence.Substring(3,4);//3. Karakterden Sonra 4 Karakter Yazdir
            Console.WriteLine(result10);

            var result11 = sentence.ToLower();//Tum Karakterleri Kucuk Harfe Cevirir..
            Console.WriteLine(result11);

            var result12 = sentence.ToUpper();//Tum Karakterleri Buyuk Harfe Cevirir..
            Console.WriteLine(result12);

            var result13 = sentence.Replace(" ", "-");//Bosluk Yerine - Isaretini Yazar..
            Console.WriteLine(result13);

            var result14 = sentence.Remove(2);
            Console.WriteLine(result14);//2.Karakterden Sonrasını Atar.......

            var result15 = sentence.Remove(2,5);
            Console.WriteLine(result15);//2.Karakterden Sonra Gelen 5 Karakteri Atar.......












            Console.ReadLine();
        }
    }
}
