using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab6_5
{
    class Program
    {
        static void Main()
        {
            string[] name = new string[5];

            for (int i = 0; i < name.Length; i++) 
            {
                WriteLine("Enter your name, last name first: ");
                name[i] = ReadLine();
            }

            Array.Sort(name);
            foreach (string x in name) { WriteLine(x); }
            ReadKey();
            
        }
    }
}
