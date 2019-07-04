using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{
    /*
     * 
     * 
     * 
     */

    class CodilityTest1
    {
        /*
         *  Example test:   '0 - 22 1985--324'
            WRONG ANSWER (got 022-198-53-2-4 expected 022-198-53-24)

            Example test:   '555372654'
            WRONG ANSWER (got 555-372-6-54 expected 555-372-654)
         * 
         * 
         */
        public string solution(string S)
        {
            string result = string.Empty;

            S = S.Replace(" ", string.Empty);
            S = S.Replace("-", string.Empty);

            if (S.Length == 2)
            {
                result = S;
            }
            else if(S.Length % 3 == 0)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    if (i % 3 == 0 && i > 0)
                    {
                        result += "-";
                    }
                    result += S[i];
                }
            }
            else
            {
                int i = 0;
                for (i = 0; i < S.Length - 2; i++)
                {
                    if (i % 3 == 0 && i > 0)
                    {
                        result += "-";
                    }
                    result += S[i];
                }
                result += "-" + S[i] + S[i + 1];
            }

            return result;
        }
    }
}
