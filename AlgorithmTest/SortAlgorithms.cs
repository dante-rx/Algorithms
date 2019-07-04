using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{
    class SortAlgorithms
    {
        public static void CallBubleSort()
        {
            var myArray = new int[] { 49, 3, -1, 5, 6, -4, 2 };
            var result = BubleSort(myArray);
            foreach(var item in result)
            {
                Console.Write($"{item} ");
            }
        }

        public static int[] BubleSort(int [] myArray)
        {
            var result = new int[myArray.Length];
            var size = myArray.Length;

            for (int i =0; i< size-1;i++)
            {
                for (int j=0;j<size-i-1;j++)
                {
                    if(myArray[j+1]< myArray[j])
                    {
                        int temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                    }
                }
            }

            return myArray;
        }
    }
}
