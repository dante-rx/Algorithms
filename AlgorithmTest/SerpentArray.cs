using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{
    class SerpentArray
    {
        public static void PrintSerpentArray(int[,] array)
        {
            int limLineSupIndex = array.GetLength(0)-1;
            int limColSupIndex = array.GetLength(1) -1;
            string result = "";

            for (int i=0; i<=limLineSupIndex;i++)
            {
                if ((i%2)==0)
                {
                    for (int j=0;j<=limColSupIndex;j++)
                    {
                        result += array[i, j] + " ";
                    }
                }
                else
                {
                    for (int j = limColSupIndex; j >= 0; j--)
                    {
                        result += array[i, j] + " ";
                    }
                }
            }

            Console.WriteLine(result);
        }


        public static void CallPrintSerpent()
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

            PrintSerpentArray(array3);
        }
    }
}
