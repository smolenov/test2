using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr._5ReverseNumber.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            Console.WriteLine("Write floating-point number");
            number = Console.ReadLine();

            ReverseNumber(number);
           

        }

        static void ReverseNumber(string number)
        {
           
            
           string convert;
            char[] charArray;

            charArray = number.ToCharArray();
            Array.Reverse(charArray);
            convert = new string(charArray);

           
            Console.WriteLine(convert);
        }



    }
}
