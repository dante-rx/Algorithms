using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{
    class SpiralArray
    {
        public static void PrintSpiralArray (int [,] array)
        {
            int limLineSupIndex = array.GetLength(0)-1;
            int limColSupIndex = array.GetLength(1)-1;

            int limLineInfIndex = 0;
            int limColInfIndex = 0;

            string result = "";
            var numberPrinted = 0;

            while (limColInfIndex <= limColSupIndex && limLineInfIndex <= limLineSupIndex)
            {
                if (limLineInfIndex <= limLineSupIndex)
                {
                    for (int i = limColInfIndex; i <= limColSupIndex; i++)
                    {
                        numberPrinted = array[limLineInfIndex, i];
                        result += numberPrinted + " ";
                    }
                    limLineInfIndex++;
                }

                if (limColInfIndex <= limColSupIndex)
                {
                    for (int i = limLineInfIndex; i <= limLineSupIndex; i++)
                    {
                        numberPrinted = array[i, limColSupIndex];
                        result += numberPrinted + " ";
                    }
                    limColSupIndex--;
                }

                if (limLineInfIndex <= limLineSupIndex)
                {
                    for (int i = limColSupIndex; i >= limColInfIndex; i--)
                    {
                        numberPrinted = array[limLineSupIndex, i];
                        result += numberPrinted + " ";
                    }
                    limLineSupIndex--;
                }

                if (limColInfIndex <= limColSupIndex)
                {
                    for (int i = limLineSupIndex; i >= limLineInfIndex; i--)
                    {
                        numberPrinted = array[i, limColInfIndex];
                        result += numberPrinted + " ";
                    }
                    limColInfIndex++;
                }
            }

            Console.WriteLine(result);

        }

        public static void CallPrintSpiral()
        {
            var array1 = new int[,]
            {
                { 1,  2,  3,  4,  5,  6},
                { 7,  8,  9, 10, 11, 12},
                {13, 14, 15, 16, 17, 18},
                {19, 20, 21, 22, 23, 24},
                {25, 26, 27, 28, 29, 30}
            };

            var array2 = new int[,]
            {
                    { 1   ,2  , 3 ,  4 },
                    { 5  , 6  , 7 ,  8 },
                    { 9  , 10,  11 , 12 },
                    { 13,  14 , 15,  16 }
            };

            var array3 = new int[,]
            {
               { 1  ,2  , 3 ,  4 , 5  ,6  },
               { 7  ,8  , 9 , 10 , 11 ,12 },
               { 13 ,14 , 15, 16 , 17 ,18 }
            };

            var array4 = new int[,]
            {
               { 1,  2,  3},
               { 7,  8,  9},
               {13, 14, 15},
               {19, 20, 21},
               {25, 26, 27},
               {28, 29, 30},
               {31, 32, 33},
            };

            PrintSpiralArray(array4);
        }
    }
}
