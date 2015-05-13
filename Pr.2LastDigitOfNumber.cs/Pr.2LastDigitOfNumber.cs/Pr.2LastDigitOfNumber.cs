using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr._2LastDigitOfNumber.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            int number;

            Console.WriteLine("Write number");
            number = int.Parse(Console.ReadLine());
            FindLastDigitOfNumber(number);
        }


        static void FindLastDigitOfNumber(int number)
        {
            string str;
            char lastItem;
            int lastItemToInt;
            int count = 0;

            str = Convert.ToString(number);

            for (int i = 0; i < str.Length; i++)
            {
                count++;
            }

            lastItem = str[count - 1];

            lastItemToInt = Convert.ToInt32(new string(lastItem, 1));


            
            PrintLastDigitOfNumberAsAnEnglishWord(lastItemToInt);
          
        }
        static void PrintLastDigitOfNumberAsAnEnglishWord(int lastItemToInt)
        {
            Console.WriteLine();
            switch (lastItemToInt)
            {
                case 0: Console.WriteLine("zero"); break;
                case 1: Console.WriteLine("one"); break;
                case 2: Console.WriteLine("rwo"); break;
                case 3: Console.WriteLine("three"); break;
                case 4: Console.WriteLine("for"); break;
                case 5: Console.WriteLine("five"); break;
                case 6: Console.WriteLine("six"); break;
                case 7: Console.WriteLine("seven"); break;
                case 8: Console.WriteLine("eight"); break;
                case 9: Console.WriteLine("nine"); break;

                default:
                    break;
            }
        }



    }
}
