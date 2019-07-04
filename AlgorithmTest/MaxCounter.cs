using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    /*
     * 

You are given N counters, initially set to 0, and you have two possible operations on them:

        increase(X) − counter X is increased by 1,
        max counter − all counters are set to the maximum value of any counter.

A non-empty array A of M integers is given. This array represents consecutive operations:

        if A[K] = X, such that 1 ≤ X ≤ N, then operation K is increase(X),
        if A[K] = N + 1 then operation K is max counter.

For example, given integer N = 5 and array A such that:
    A[0] = 3
    A[1] = 4
    A[2] = 4
    A[3] = 6
    A[4] = 1
    A[5] = 4
    A[6] = 4

the values of the counters after each consecutive operation will be:
    (0, 0, 1, 0, 0)
    (0, 0, 1, 1, 0)
    (0, 0, 1, 2, 0)
    (2, 2, 2, 2, 2)
    (3, 2, 2, 2, 2)
    (3, 2, 2, 3, 2)
    (3, 2, 2, 4, 2)

The goal is to calculate the value of every counter after all operations.

Write a function:

    class Solution { public int[] solution(int N, int[] A); }

that, given an integer N and a non-empty array A consisting of M integers, returns a sequence of integers representing the values of the counters.

Result array should be returned as an array of integers.

For example, given:
    A[0] = 3
    A[1] = 4
    A[2] = 4
    A[3] = 6
    A[4] = 1
    A[5] = 4
    A[6] = 4

the function should return [3, 2, 2, 4, 2], as explained above.

Write an efficient algorithm for the following assumptions:

        N and M are integers within the range [1..100,000];
        each element of array A is an integer within the range [1..N + 1].

     * 
     * */



    class MaxCounter
    {
        public int MaxValue(int a, int b)
        {
            if (a<b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }

        public void SetCountersToMax(ref int[] counters, int max)
        {
            for(int i=0;i<counters.Length;i++)
            {
                counters[i] = max;
            }
        }

        public bool Increase(int arrayValue, int N)
        {
            if (arrayValue<= N  && arrayValue>=1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int[] solution(int N, int[] A)
        {
            int[] counters = new int[N];
            SetCountersToMax(ref counters, 0);
            int max = 0;
            for (int i=0;i<A.Length;i++)
            {
                bool willIncrease = Increase(A[i], N);
                if (willIncrease == true)
                {
                    counters[A[i]-1] += 1;
                    max = MaxValue(counters[A[i]-1], max);
                }
                else
                {
                    SetCountersToMax(ref counters, max);
                }
            }
            return counters;
        }
    }
}
