using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    /*
     *

A non-empty array A consisting of N integers is given. The product of triplet (P, Q, R) equates to A[P] * A[Q] * A[R] (0 ≤ P < Q < R < N).

For example, array A such that:
  A[0] = -3
  A[1] = 1
  A[2] = 2
  A[3] = -2
  A[4] = 5
  A[5] = 6

contains the following example triplets:

        (0, 1, 2), product is −3 * 1 * 2 = −6
        (1, 2, 4), product is 1 * 2 * 5 = 10
        (2, 4, 5), product is 2 * 5 * 6 = 60

Your goal is to find the maximal product of any triplet.

Write a function:

    class Solution { public int solution(int[] A); }

that, given a non-empty array A, returns the value of the maximal product of any triplet.

For example, given array A such that:
  A[0] = -3
  A[1] = 1
  A[2] = 2
  A[3] = -2
  A[4] = 5
  A[5] = 6

the function should return 60, as the product of triplet (2, 4, 5) is maximal.

Write an efficient algorithm for the following assumptions:

        N is an integer within the range [3..100,000];
        each element of array A is an integer within the range [−1,000..1,000].


     * 
     * 
     * 
     */

    /// <summary>
    /// Maximize A[P] * A[Q] * A[R] for any triplet(P, Q, R).
    /// </summary>
    class MaxProductOfThree
    {
        public int solution(int[] A)
        {
            Array.Sort(A);
            int multiplication1 = A[A.Length - 1] * A[A.Length - 2] * A[A.Length - 3];
            int multiplication2 = A[A.Length - 1] * A[0] * A[1];
            return Math.Max(multiplication1, multiplication2);
        }

        public int solution2(int[] A)
        {
            int max = A[0] * A[1] * A[2];
            for (int i = 0; i < A.Length - 2; i++)
            {
                for (int j = i + 1; j < A.Length - 1; j++)
                {
                    for (int k = j + 1; k < A.Length; k++)
                    {
                        var product = A[i] * A[j] * A[k];
                        if (product > max)
                        {
                            max = product;
                        }
                    }
                }
            }
            return max;
        }
    }
}
