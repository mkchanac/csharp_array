using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab6_3
{
    class Program
    {
        static void Main()
        {
            int[] lab = { 1, 2, 3, 4, 5, 6, 7, 8 };
            displayAllValues(lab);
            WriteLine();
            displayAllValuesReverse(lab);
            WriteLine();
            displayTheSum(lab);
            WriteLine();
            displayLessThanArgument(lab);
            WriteLine();
            displayHigherThanAverage(lab);
            ReadKey();
        }
        public static void displayAllValues(int[] lab) 
        {
            for (int i = 0; i < lab.Length; i++) 
            {
                WriteLine(lab[i]);
            }
        }
        public static void displayAllValuesReverse(int[] lab)
        {
            Array.Reverse(lab);
            for (int i = 0; i < lab.Length; i++)
            {
                WriteLine(lab[i]);
            }
        }
        public static void displayTheSum(int[] lab)
        {
            Array.Reverse(lab);
            int sum = 0;
            for (int i = 0; i < lab.Length; i++)
            {
                sum += i;
            }
            WriteLine(sum);
        }
        public static void displayLessThanArgument(int[] lab)
        {
            for (int i = 0; i < lab.Length; i++)
            {
                if (lab[i] < 5)
                { WriteLine(lab[i]); }
            }
        }

        public static void displayHigherThanAverage(int[] lab)
        {
            int average;
            int sum = 0;
            for (int i = 0; i < lab.Length; i++)
            {
                sum += lab[i];
            }
            average = (int) sum / lab.Length;
            for (int i = 0; i < lab.Length; i++)
            {
                if (lab[i] > average)
                { WriteLine(lab[i]); }
            }
        }
    }
}
