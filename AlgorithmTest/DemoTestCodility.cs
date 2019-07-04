using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    /*
     * 

This is a demo task.

Write a function:

    class Solution { public int solution(int[] A); }

that, given an array A of N integers, returns the smallest positive integer (greater than 0) that does not occur in A.

For example, given A = [1, 3, 6, 4, 1, 2], the function should return 5.

Given A = [1, 2, 3], the function should return 4.

Given A = [−1, −3], the function should return 1.

Write an efficient algorithm for the following assumptions:

        N is an integer within the range [1..100,000];
        each element of array A is an integer within the range [−1,000,000..1,000,000].


     * 
     * 
     * */

    class DemoTestCodility
    {
        public int solution(int[] A)
        {
            bool[] found = new bool[A.Length + 1];
            int result = found.Length;

            for (int i = 0; i < found.Length; i++)
            {
                found[i] = false;
            }
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    if (A[i] < found.Length)
                    {
                        found[A[i]] = true;
                    }
                }
            }

            for (int i = 1; i < found.Length; i++)
            {
                if (found[i] == false)
                {
                    result = i;
                    break;
                }
            }


            return result;
        }
    }
}
