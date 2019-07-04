using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    class codilityTest2
    {
        public int solution(int[] A)
        {
            if (A.Length <= 2) return -2;

            int minDistance = int.MaxValue;

            Array.Sort(A);

            for (int i = 0; i < A.Length - 1; i++)
            {
                int currentDistance = Math.Abs(A[i] - A[i + 1]);
                if (currentDistance < minDistance)
                {
                    minDistance = currentDistance;
                }

            }

            if (minDistance > 100000000)
            {
                return -1;
            }

            return minDistance;

        }
    }
}
