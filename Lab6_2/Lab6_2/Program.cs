using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab6_2
{
    class Program
    {
        static void Main()
        {
            int[] integer = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < integer.Length; i++) 
            {
                WriteLine(integer[i]);
            }
            WriteLine();
            for (int i = integer.Length - 1; i >= 0; i--) 
            {
                WriteLine(integer[i]);
            }


            ReadKey();

        }
    }
}
