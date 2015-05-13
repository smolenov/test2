using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr4First_LargerThanNeighbo.cs
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
            arrIntNum = new int[arrNum.Length];

            for (int conv = 0; conv < arrNum.Length; conv++)
            {
                convert = Convert.ToInt32(arrNum[conv]);
                arrIntNum[conv] = convert;

                LargerThanNeighbours(arrIntNum);
            }


        }


        static void LargerThanNeighbours(int[] arrIntNum)
        {
            int largerNeighbour;
            int[] arrIndex=new int[3];

            for (int i = 1; i < arrIntNum.Length - 1; i++)
            {
                if ((arrIntNum[i - 1]) > arrIntNum[i])
                {
                    largerNeighbour = 1;
                    arrIndex[0] = arrIntNum[i];

                }


                int arrLenght = arrIntNum.Length;


                if ((arrIntNum[arrLenght - 1] > arrIntNum[arrLenght - 2]))
                {
                    largerNeighbour = 1;
                    arrIndex[2] = arrIntNum[i];
                }


                if (((arrIntNum[i] > arrIntNum[i - 1]) && (arrIntNum[i] > arrIntNum[i + 1])))
                {

                    largerNeighbour = 1;
                    arrIndex[1] = arrIntNum[i];
                    

                }

                else
                {
                    largerNeighbour = 0;
                    
                }
               
                



                PrintFirstLargerNeighbour(largerNeighbour, arrIntNum,arrIndex);
                break;
            }


        }


        static void PrintFirstLargerNeighbour(int largerNeighbour, int[] arrIntNum, int[]arrIndex)
        {
          
            if (largerNeighbour == 1)
            {
                for (int i = 1; i < arrIndex.Length-1; i++)
                {
                    if (((arrIndex[i] > arrIndex[i - 1]) && (arrIndex[i] > arrIndex[i + 1])))
                    {
                        Console.WriteLine();
                        Console.WriteLine(arrIndex[i]);   
                    }
                   

                   
                }
                

            }

            if (largerNeighbour==0)
            {
                Console.WriteLine("-1");
            }
          
         }
       



    }
}

        
    

