using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{
    class KadaneAlgorithm
    {
        public static void CallKadaneAlgo()
        {
            var myArray = new int[] {-2, 3,6,-2, -1, 5, -3 };
            Console.WriteLine(MaxSubArray(myArray));
        }

        public static int MaxSubArray(int [] myArray)
        {
            int currentMax = myArray[0];
            int globalMax = myArray[0];
            for (int i=1;i<myArray.Length;i++)
            {
                currentMax = Max(currentMax + myArray[i], myArray[i]);
                globalMax = Max(globalMax, currentMax);
            }

            return globalMax;
        }


        public static int Max (int a, int b)
        {
            if (a < b)
                return b;
            return a;
        }
    }
}
