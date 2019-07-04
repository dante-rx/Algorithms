using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmTest
{
    class CodilityTest3
    {
        public int solution(int[] T)
        {
            int result = 1;
            Array.Sort(T);
            for (int i = 1; i < T.Length - 1; i++)
            {
                if (T[i] != T[i + 1])
                {
                    result++;
                }
                if (result >= T.Length / 2)
                {
                    break;
                }
            }

            return result;

        }
    }
}
