using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr._1BiggerNumber.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int c;
            Console.WriteLine("write n");
           n= int.Parse(Console.ReadLine());
            Console.WriteLine("write c");
            c=int.Parse(Console.ReadLine());
            GetMax(n,c) ;
        }


        static void GetMax(int n,int c)
        {
            Console.WriteLine();
            if (n>c)
            {
                Console.WriteLine(n); ; 
            }
            else
            {
                Console.WriteLine(c); ;
            }
 
        }


    }
}
