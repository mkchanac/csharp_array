using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Lab6_6
{
    class TemperatureApp
    {
        static void Main()
        {
            double[] temperature = { 30.5, 18.5, 27.5, 26.5, 25.5, 27.5, 22.5 };

            Temperature firstWeek = new Temperature(temperature);

            int[] days = firstWeek.FindDaysBelow(25);
            string inValue = "";

            foreach (int x in days)
            {
                inValue += "\tDay " + x.ToString();
            }

            WriteLine(firstWeek);
            WriteLine("The days below the temperature is:" + inValue);

            ReadKey();

        }
    }
}
