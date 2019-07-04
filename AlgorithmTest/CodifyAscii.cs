using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{
    class CodifyAscii
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="palavra"></param>
        /// <returns></returns>
        public static string Codifica(string palavra)
        {
           // int f = 1;
            string result = "";
            foreach (var a in palavra)
            {
                result +=(int)a;
            }
            return result;
        }

        public static string Decodifica(string code)
        {
            var myArray = new char[100];
            string result = "";
            for (int i=0; i<=code.Length-2;)
            {
                int dizaine = code[i]-48;
                int unite = code[i + 1]-48;
                int letra = dizaine * 10 + unite;
                i += 2;
                result += (char)letra;
            }
            return result;
        }


        public static void CallCodifyAscii()
        {
            string toCode = "LINGUAGEM C";
            Console.WriteLine($"To code = {toCode}");
            string codified = CodifyAscii.Codifica(toCode);
            Console.WriteLine($"Codified = {codified}");
            string decodified = CodifyAscii.Decodifica(codified);
            Console.WriteLine($"Decodified = {decodified}");
        }

    }
}
