using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_6
{
    class Temperature
    {
        private double[] temp;

        public Temperature(double[] temperature) 
        {
            temp = temperature;
        }
        public double[] Temp
        {
            get 
            {
                return temp; 
            }
            set
            {
                temp = value;
            }
        }

        public double FindSum()
        {

            return temp.Sum();
        }

        public double FindAverage()
        {

            return temp.Average();

        }

        public double FindLowest()
        {

            return temp.Min();
            
        }

        public double FindHighest()
        {

            return temp.Max();
        }

        public double FindAverageExcludeLowest()
        {
            double sum = 0;
            int count = 0;

            for (int i = 0; i < temp.Length; i++)
                if (temp[i] > temp.Min())
                { sum += temp[i]; count++; }

            double averageExclude = sum / count;
            return averageExclude;
        }

        public override string ToString()
        {

            return "\nThe sum of temperature in a week: " + FindSum().ToString("F2")
                + "\nThe average of temperature in a week: " + FindAverage().ToString("F2")
                + "\nThe lowest temperature in a week: " + FindLowest().ToString("F2")
                + "\nThe highest temperature in a a week: " + FindHighest().ToString("F2")
                + "\nThe average excluding the lowest in a week: " + FindAverageExcludeLowest().ToString("F2");
        }

        public int[] FindDaysBelow(double tem)
        {
            int[] dayOfBelow = new int[7];
            int j = 0;

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < tem)
                { dayOfBelow[j] = i+1; j++; }
            }
            int[] daysBelow = new int[j];

            for (int i = 0; i < j; i++) 
            {
                if (dayOfBelow[i] > 0)
                    daysBelow[i] = dayOfBelow[i];
            }


            return daysBelow;
        }
    }
}
