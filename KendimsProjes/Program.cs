using System;

namespace KendimsProjes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Ornek 1
            string name, surname;
            Console.WriteLine("Adiniz: ");
            name = Console.ReadLine();   
            Console.WriteLine("Soyadiniz: ");
            surname = Console.ReadLine();
            Console.WriteLine("Merhaba {0} {1}", name, surname);
            //Console.ReadLine();//console.readkey() de kullanabiliriz
            Console.WriteLine("Birinci Ornek Bitti");
            Console.WriteLine("*****************************");

            //ornek2
            int number1, number2, collection;
            Console.WriteLine("Birinci Sayiyi Giriniz: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ikinci Sayiyi Giriniz: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            collection = number1 + number2;
            Console.WriteLine("{0} ve {1} Sayilarinin Toplami = {2} ",number1, number2,collection);
            Console.WriteLine("Ikinci Ornek Bitti");
            Console.WriteLine("*****************************");


            //ornek3
            double number11, number22, collection2, differences, products, episodess;
            Console.WriteLine("Birinci Sayiyi Giriniz:");
            number11 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ikinci Sayiyi Giriniz:");
            number22 = Convert.ToDouble(Console.ReadLine());
            collection = number1 + number2;
            differences = number1 - number2;
            products = number1 * number2;
            episodess = number1 / number2;
            Console.WriteLine("{0} ve {1} Sayilarinin Toplami = {2}", number1, number2, collection);
            Console.WriteLine("{0} ve {1} Sayilarinin Farki = {2}",number1,number2,differences);
            Console.WriteLine("{0} ve {1} Sayilarinin Carpimi = {2}", number1, number2, products);
            Console.WriteLine("{0} ve {1} Sayilarinin Bolumu = {2}", number1, number2, episodess);
            Console.WriteLine("Ucuncu Ornek Bitti");
            Console.WriteLine("*****************************");

            //Ornek4
            double number, conclusion;
            Console.WriteLine("Sayi Giriniz: ");
            number = Convert.ToDouble(Console.ReadLine());
            conclusion = number * 18 / 100;
            Console.WriteLine("Girilen Sayinin %18 i = {0}", conclusion);
            
            Console.WriteLine("Dorduncu Ornek Bitti");
            Console.WriteLine("*****************************");
            

            //Ornek5
            double sayi1, yuzde, sonuc;
            Console.WriteLine("Yuzdesini Ogrenmek Istediginiz Sayiyi Giriniz:");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Yuzdeyi Giriniz: ");
            yuzde = Convert.ToDouble(Console.ReadLine());
            sonuc = sayi1 * yuzde / 100;
            Console.WriteLine("Girilen Sayinin  % {0} i = {1}",yuzde, sonuc);
            Console.WriteLine("Besinci Ornek Bitti");
            Console.WriteLine("*****************************");

            //Ornek6
            int kisa, uzun, alan, cevre;
            Console.WriteLine("Kisa Kenari Giriniz:");
            kisa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uzun Kenari Giriniz:");
            uzun = Convert.ToInt32(Console.ReadLine());
            alan = kisa * uzun;
            cevre = 2 * (kisa + uzun);
            Console.WriteLine("Alan : ", + alan);
            Console.WriteLine("Cevre : ", + cevre);
            Console.WriteLine("Altinci Ornek Bitti");
            Console.WriteLine("*****************************");

            //Ornek7
            double yazili1, yazili2, yazili3, ortalama;
            Console.WriteLine("1.Yazili: ");
            yazili1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Yazili: ");
            yazili2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.Yazili: ");
            yazili3 = Convert.ToInt32(Console.ReadLine());
            ortalama = (yazili1 + yazili2 + yazili3) / 3;
            Console.WriteLine("Ortalamaniz = " + ortalama);
            if(ortalama>=50)
            {
                Console.WriteLine("Gectiniz");
            }
            else
            {
                Console.WriteLine("Kaldiniz");
            }
            Console.WriteLine("Yedinci Ornek Bitti");
            Console.WriteLine("*****************************");




            Console.ReadLine();
        }
    }
}
