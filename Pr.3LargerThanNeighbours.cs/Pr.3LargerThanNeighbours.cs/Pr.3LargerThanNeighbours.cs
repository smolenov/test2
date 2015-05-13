using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr._3LargerThanNeighbours.cs
{ 
    class Program
    {
      
        static void Main(string[] args)
        {
            
           string numbers;
           string[] arrNum;
           int[] arrIntNum;
           int convert;
           Console.WriteLine("Write numbers separated by a space");

           numbers = Console.ReadLine();
           arrNum = numbers.Split(' ');
            arrIntNum=new int[arrNum.Length];

           for (int conv = 0; conv < arrNum.Length; conv++)
           {
               convert = Convert.ToInt32(arrNum[conv]);
               arrIntNum[conv]=convert;

               LargerThanNeighbours(arrIntNum);
           }

         
        }
       
        static void LargerThanNeighbours(int[] arrIntNum)
        {
           int largerNeighbour;

           for (int i = 1; i < arrIntNum.Length - 1; i++)
           {
               if ((arrIntNum[i - 1]) > arrIntNum[i])
               {
                   largerNeighbour = 1;
               }


               if (((arrIntNum[i] > arrIntNum[i - 1]) && (arrIntNum[i] > arrIntNum[i + 1])))
               {
                  
                   largerNeighbour = 1;
                   
               }
               else
               {
                   largerNeighbour = 0;
                   
               }
               int arrLenght = arrIntNum.Length;


               if ((arrIntNum[arrLenght - 1] > arrIntNum[arrLenght - 2]))
               {
                   largerNeighbour = 1;
               }
              

               

               PrintLargerNeighbour(largerNeighbour);
               break;
           } 

            
        }

        static void PrintLargerNeighbour(int largerNeighbour)
        {
            if (largerNeighbour==1)
            {
                Console.WriteLine("true");
               
            }
            else
            {
                if (largerNeighbour==0)
                {
                    Console.WriteLine("false");
                    
                }
            }



            
            
        }




    }
}
