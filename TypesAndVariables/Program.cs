using System;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = 15;
            /*if(number1==10)
            {
                Console.WriteLine("Number1 is 10");
            }
            else
            {
                Console.WriteLine("Number1 in not 10");
            }*/

            /*switch(number1)
            {
                case 10:
                    Console.WriteLine("number1 is 10");
                    break;
                case 20:
                    Console.WriteLine("number1 is 20");
                    break;
                default:
                    Console.WriteLine("number1 is not 10 and number1 is not 20");
                    break;
            }*/

            Console.WriteLine("Girilen Sayinin 100 Lük Sistemde Nerede Oldugunu Bulan Program");
            if(number1>=0 && number1<=100)
            {
                Console.WriteLine("number1 is between 0-100");
            }
            else if(number1 >100 && number1<=200)
            {
                Console.WriteLine("number1 is between 100-200");
            }
            else if(number1>200 || number1<0)
            {
                Console.WriteLine("number1 is less than 0 or great than 200");
            }

        }
    }
}
