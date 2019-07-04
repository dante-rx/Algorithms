using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{
    class PythagoreanTriples
    {
        public static void CallPythagoreTriples()
        {
            Console.WriteLine("Method1 called");
            var myResultList = PythagoreanTriplesMethod1(1000);
            foreach (var item in myResultList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myResultList.Count);
            Console.WriteLine("-------------------------------");
        }

        public static List<string> PythagoreanTriplesMethod3(int limit)
        {
            int m = 2;
            int n = 1;

            int a = 0;
            int b = 0;
            int c = 0;
            var myList = new List<string>();
            a = m * m - n * n;
            b = 2 * m * n;
            c = m * m + n * n;

            int tempA = a;
            int tempB = b;
            int tempC = c;

            while (c <= limit)
            {
                tempA = a;
                tempB = b;
                tempC = c;
                int f = 1;
                while (tempC <= limit)
                {
                    string result1 = "{" + tempA + ", " + tempB + ", " + tempC + "}";
                    string result2 = "{" + tempB + ", " + tempA + ", " + tempC + "}";
                    string result3 = "{" + tempA + ", " + tempC + ", " + tempB + "}";
                    string result4 = "{" + tempB + ", " + tempC + ", " + tempA + "}";
                    string result5 = "{" + tempC + ", " + tempA + ", " + tempB + "}";
                    string result6 = "{" + tempC + ", " + tempB + ", " + tempA + "}";

                    var condition = !myList.Contains(result1);
                    condition &= !myList.Contains(result2);
                    condition &= !myList.Contains(result3);
                    condition &= !myList.Contains(result4);
                    condition &= !myList.Contains(result5);
                    condition &= !myList.Contains(result6);

                    if (condition)
                    {
                        if (tempC * tempC == (tempA * tempA + tempB * tempB))
                            myList.Add(result1);
                    }
                    f++;
                    tempA = a * f;
                    tempB = b * f;
                    tempC = c * f;
                }

                m++;
                n++;
                a = m * m - n * n;
                b = 2 * m * n;
                c = m * m + n * n;
            }

            return myList;
        }

        public static List<string> PythagoreanTriplesMethod2(int limit)
        {
            int a = 3;
            int b = 4;
            int c = 5;
            string result = "";
            var myList = new List<string>();
            int m = 2;
            while (c<=limit)
            {
                result = "{" + a + ", " + b + ", " + c + "}";

                if (!myList.Contains(result))
                {
                    if ((c * c) == (a * a + b * b))
                        myList.Add(result);
                }
                m++;
                a = 2 * m;
                b = m * m - 1;
                c = m * m + 1;
            }

            return myList;
        }

        public static List<string> PythagoreanTriplesMethod1(int limit)
        {
            int a = 3;
            int b = 4;
            int c = 5;
            var myList = new List<string>();

            int tempA = a;
            int tempB = b;
            int tempC = c;
            while (c <= limit)
            {
                int f = 1;

                while (tempC <= limit)
                {
                    string result1 = "{" + tempA + ", " + tempB + ", " + tempC + "}";

                    var condition = !myList.Contains(result1);

                    if (condition)
                    {
                        if (tempC*tempC == (tempA*tempA + tempB*tempB))
                            myList.Add(result1);
                    }
                    f++;
                    tempA = a * f;
                    tempB = b* f;
                    tempC = c *f;
                }

                do
                {
                    a++;
                    if (a % 2 == 0)
                    {
                        b = (a / 2) * (a / 2) - 1;
                        c = b + 2;
                    }
                    else
                    {
                        b = (a * a) / 2;
                        c = b + 1;
                    }
                } while (a >= b);

                tempA = a;
                tempB = b;
                tempC = c;
            }
            return myList;
        }
    }
}
