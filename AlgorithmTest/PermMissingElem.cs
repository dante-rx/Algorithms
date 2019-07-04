using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{
    /*
        An array A consisting of N different integers is given.
        The array contains integers in the range [1..(N + 1)], 
        which means that exactly one element is missing.
        Your goal is to find that missing element.
        Write a function:
        class Solution { public int solution(int[] A); }
        that, given an array A, returns the value of the missing element.
        For example, given array A such that:
        A[0] = 2
        A[1] = 3
        A[2] = 1
        A[3] = 5
        the function should return 4, as it is the missing element.

        Write an efficient algorithm for the following assumptions:
        N is an integer within the range [0..100,000];
        the elements of A are all distinct;
        each element of array A is an integer within the range [1..(N + 1)].
    */
    class PermMissingElem
    {
        public int solution1(int[] A)
        {
            bool[] B = new bool[A.Length];

            for(int i= 0; i<B.Length;i++)
            {
                B[i] = false;
            }

            for (int i=0; i<A.Length;i++)
            {
                int index = A[i]-1;
                if (index < B.Length)
                {
                    B[index] = true;
                }
            }
            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] == false)
                {
                    return i + 1;
                }
            }

            return 0;
        }

        public int solution2(int[] A)
        {
            int N = A.Length + 1;
            double sumOfA = 0;

            for (int i = 0; i < A.Length; i++)
            {
                sumOfA += A[i];
            }

            double toCompare = (N * (N + 1)) / 2;

            int result = (int)(toCompare - sumOfA);

            if (result > 0) return result;
            else return result * (-1);
        }
    }
}
