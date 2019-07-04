using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALGORITHME
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            arr[0] = 100;
            arr[1] = 200;
            arr[2] = 300;
            arr[3] = 400;
            arr[4] = 500;
            arr[5] = 600;
            arr[6] = 800;
            arr[7] = 800;
            arr[8] = 900;
            arr[9] = 1000;
            int a = Array.IndexOf(arr, 801);
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
