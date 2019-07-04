using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{
    class Pyramid
    {
        public static void PrintHalfPyramid(int deep)
        {
            string result = "";
            for (int i=1;i<=deep;i++)
            {
                for (int j=1; j<=i;j++)
                {
                    result += "* ";
                }
                result += "\n";
            }
            Console.WriteLine(result);
        }

        public static void PrintPyramid(int deep)
        {
            string result = "";
            int temp = deep;
            for (int i = 1; i <= temp; i++)
            {
                for (int j = i; j <= temp; j++)
                {
                    result += "* ";
                }
                temp--;
                result += "\n";
                for (int k = 1; k <= i; k++)
                {
                    result += "  ";
                }
            }
            Console.WriteLine(result);
        }
    }
}
