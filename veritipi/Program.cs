using System;

namespace veritipi
{
    class Program
    {
        static void Main(string[] args)
        {
            int   number1 = 10;
            long  number2 = 54168256;
            short number3 = -32768;
            byte  number4 = 250;
            var   number5 = 10;//int olarak algılar
            number5 = 'A';
            Console.WriteLine("number1 is {0}", number1);//virgülden sonraki ilk deger
            Console.WriteLine("number2 is {0}", number2);
            Console.WriteLine("number3 is {0}", number3);
            Console.WriteLine("number4 is {0}", number4);
            Console.WriteLine("number5 is {0}", number5);
            //Console.WriteLine("Hello World!");
        }
    }
    enum Days
    {
        Monday=10,Tuesday=20,wednesday=30,thursday,friday,saturday,sunday
    }
}
