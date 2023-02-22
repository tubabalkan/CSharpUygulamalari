using System;

namespace Methods1Ben
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
            var result = Add2(20);
            int number1 = 20;
            int number2 = 100;
            //ref te number1 a deger vermen gerek out ta gerek yok
            //var result2 = Add3(ref number1, number2);//değer tiplerin referans tip gibi davranmasını sağlar ref
            //var result2 = Add3(out number1, number2);//ref gibi farkı set etmene gerek yok
            var result2 = Add3( number1, number2);//number1=30 yukarıdakı ile methottaki farklı
            Console.WriteLine(result);
            Console.WriteLine(result2);//önce method çalıştı
            Console.WriteLine(number1);//20 değer tipler burada 


            Console.WriteLine(multiply(2,4));
            Console.WriteLine(multiply(2, 4,5));
           // Console.WriteLine(Add4(1, 2, 3, 4, 5, 6));

            Console.ReadLine();
        }
        static void Add()
        {
            Console.WriteLine("Added!!!");
        }
        static int Add2(int number1,int number2=30)//birincisine deger veremezin
        {
            var result = number1 + number2;
            return result;
        }
        static int Add3( int number1, int number2) // ref eklenebilir
        {
            number1 = 30;
            return number1 + number2;
        }
        static int multiply(int numbeer1, int number2 )
        {
            return numbeer1 * number2;
        }
        static int multiply(int numbeer1, int number2,int number3)
        {
            return numbeer1 * number2 * number3;
             
        }
       /* static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
       */


        /* static int Add4(int number1, int number2)
         {
             return number1 + number2;
         }*/
    }
}
