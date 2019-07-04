using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{
    class CheckMatrixAreSame
    {
        public static bool AreSameMatrix ( int [,] A, int [,]B)
        {
            int sizeCol = A.GetLength(1);
            int sizeLine = A.GetLength(0);

            for (int i=0;i<sizeLine;i++)
                for (int j=0; j<sizeCol;j++)
                    if (A[i, j] != B[i, j]) return false;

            return true;
        }

        public static void CallAreSameMatrix()
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
                { 1,  2,  3,  4,  5,  6},
                { 7,  8,  9, 10, 11, 12},
                {13, 14, 15, 16, 17, 18},
                {19, 20, 21, 22, 23, 24},
                {25, 26, 27, 28, 29, 30}
            };
            var array3 = new int[,]
            {
                { 31,  2,  3,  4,  5,  6},
                { 7,  8,  9, 10, 11, 12},
                {13, 14, 15, 16, 17, 18},
                {19, 20, 21, 22, 23, 24},
                {25, 26, 27, 28, 29, 30}
            };

            bool result = AreSameMatrix(array1, array2);
            if (result)
            {
                Console.WriteLine("Are the same!");
            }
            else
            {
                Console.WriteLine("Are not the same!");
            }
        }
    }
}
